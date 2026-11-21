using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Buffers
{
	// Token: 0x0200037F RID: 895
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct AhoCorasickBuilder
	{
		// Token: 0x06003C01 RID: 15361 RVA: 0x000C7D43 File Offset: 0x000C5F43
		public AhoCorasickBuilder(ReadOnlySpan<string> values, bool ignoreCase, ref HashSet<string> unreachableValues)
		{
			this._nodes = default(ValueListBuilder<AhoCorasickNode>);
			this._parents = default(ValueListBuilder<int>);
			this._startingAsciiChars = default(IndexOfAnyAsciiSearcher.AsciiState);
			this._values = values;
			this._ignoreCase = ignoreCase;
			this.BuildTrie(ref unreachableValues);
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x000C7D80 File Offset: 0x000C5F80
		public AhoCorasick Build()
		{
			this.AddSuffixLinks();
			for (int i = 0; i < this._nodes.Length; i++)
			{
				this._nodes[i].OptimizeChildren();
			}
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported)
			{
				this.GenerateStartingAsciiCharsBitmap();
			}
			return new AhoCorasick(this._nodes.AsSpan().ToArray(), this._startingAsciiChars);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x000C7DE5 File Offset: 0x000C5FE5
		public void Dispose()
		{
			this._nodes.Dispose();
			this._parents.Dispose();
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x000C7E00 File Offset: 0x000C6000
		private unsafe void BuildTrie(ref HashSet<string> unreachableValues)
		{
			this._nodes.Append(new AhoCorasickNode());
			this._parents.Append(0);
			ReadOnlySpan<string> values = this._values;
			for (int i = 0; i < values.Length; i++)
			{
				string text = *values[i];
				int num = 0;
				ref AhoCorasickNode ptr = ref this._nodes[num];
				for (int j = 0; j < text.Length; j++)
				{
					char c = text[j];
					int length;
					if (!ptr.TryGetChild(c, out length))
					{
						length = this._nodes.Length;
						ptr.AddChild(c, length);
						this._nodes.Append(new AhoCorasickNode());
						this._parents.Append(num);
					}
					ptr = this._nodes[length];
					num = length;
					if (ptr.MatchLength != 0)
					{
						if (unreachableValues == null)
						{
							unreachableValues = new HashSet<string>(StringComparer.Ordinal);
						}
						unreachableValues.Add(text);
						break;
					}
					if (j == text.Length - 1)
					{
						ptr.MatchLength = text.Length;
						break;
					}
				}
			}
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x000C7F1C File Offset: 0x000C611C
		private unsafe void AddSuffixLinks()
		{
			Queue<ValueTuple<char, int>> queue = new Queue<ValueTuple<char, int>>();
			queue.Enqueue(new ValueTuple<char, int>('\0', 0));
			ValueTuple<char, int> valueTuple;
			while (queue.TryDequeue(out valueTuple))
			{
				ref AhoCorasickNode ptr = ref this._nodes[valueTuple.Item2];
				int num = *this._parents[valueTuple.Item2];
				int i = this._nodes[num].SuffixLink;
				if (num != 0)
				{
					while (i >= 0)
					{
						ref AhoCorasickNode ptr2 = ref this._nodes[i];
						int num2;
						if (ptr2.TryGetChild(valueTuple.Item1, out num2))
						{
							i = num2;
							break;
						}
						if (i == 0)
						{
							break;
						}
						i = ptr2.SuffixLink;
					}
				}
				if (ptr.MatchLength != 0)
				{
					ptr.SuffixLink = -1;
				}
				else
				{
					ptr.SuffixLink = i;
					if (i >= 0)
					{
						ptr.MatchLength = this._nodes[i].MatchLength;
					}
					ptr.AddChildrenToQueue(queue);
				}
			}
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x000C8004 File Offset: 0x000C6204
		private unsafe void GenerateStartingAsciiCharsBitmap()
		{
			Span<char> initialSpan = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(initialSpan);
			ReadOnlySpan<string> values = this._values;
			for (int i = 0; i < values.Length; i++)
			{
				char c = (*values[i])[0];
				if (this._ignoreCase)
				{
					valueListBuilder.Append(char.ToLowerInvariant(c));
					valueListBuilder.Append(char.ToUpperInvariant(c));
				}
				else
				{
					valueListBuilder.Append(c);
				}
			}
			if (Ascii.IsValid(valueListBuilder.AsSpan()))
			{
				IndexOfAnyAsciiSearcher.ComputeAsciiState<char>(valueListBuilder.AsSpan(), out this._startingAsciiChars);
			}
			valueListBuilder.Dispose();
		}

		// Token: 0x04000CA3 RID: 3235
		private readonly ReadOnlySpan<string> _values;

		// Token: 0x04000CA4 RID: 3236
		private readonly bool _ignoreCase;

		// Token: 0x04000CA5 RID: 3237
		private ValueListBuilder<AhoCorasickNode> _nodes;

		// Token: 0x04000CA6 RID: 3238
		private ValueListBuilder<int> _parents;

		// Token: 0x04000CA7 RID: 3239
		private IndexOfAnyAsciiSearcher.AsciiState _startingAsciiChars;
	}
}

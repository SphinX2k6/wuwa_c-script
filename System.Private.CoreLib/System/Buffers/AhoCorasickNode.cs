using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000380 RID: 896
	internal struct AhoCorasickNode
	{
		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x000C80AC File Offset: 0x000C62AC
		private static object EmptyChildrenSentinel
		{
			get
			{
				return Array.Empty<int>();
			}
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x000C80B3 File Offset: 0x000C62B3
		public AhoCorasickNode()
		{
			this.SuffixLink = 0;
			this.MatchLength = 0;
			this._firstChildIndex = 0;
			this._firstChildChar = -1;
			this._children = AhoCorasickNode.EmptyChildrenSentinel;
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x000C80DC File Offset: 0x000C62DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool TryGetChild(char c, out int index)
		{
			if (this._firstChildChar == (int)c)
			{
				index = this._firstChildIndex;
				return true;
			}
			object children = this._children;
			if (children.GetType() == typeof(int[]))
			{
				int[] array = Unsafe.As<int[]>(children);
				if ((int)c < array.Length)
				{
					index = array[(int)c];
					if (index >= 0)
					{
						return true;
					}
				}
				index = 0;
				return false;
			}
			return Unsafe.As<Dictionary<char, int>>(children).TryGetValue(c, out index);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x000C8148 File Offset: 0x000C6348
		public void AddChild(char c, int index)
		{
			if (this._firstChildChar < 0)
			{
				this._firstChildChar = (int)c;
				this._firstChildIndex = index;
				return;
			}
			if (this._children == AhoCorasickNode.EmptyChildrenSentinel)
			{
				this._children = new Dictionary<char, int>();
			}
			((Dictionary<char, int>)this._children).Add(c, index);
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x000C8198 File Offset: 0x000C6398
		public readonly void AddChildrenToQueue([TupleElementNames(new string[]
		{
			"Char",
			"Index"
		})] Queue<ValueTuple<char, int>> queue)
		{
			if (this._firstChildChar >= 0)
			{
				queue.Enqueue(new ValueTuple<char, int>((char)this._firstChildChar, this._firstChildIndex));
				Dictionary<char, int> dictionary = this._children as Dictionary<char, int>;
				if (dictionary != null)
				{
					foreach (KeyValuePair<char, int> keyValuePair in dictionary)
					{
						char c;
						int num;
						keyValuePair.Deconstruct(out c, out num);
						char item = c;
						int item2 = num;
						queue.Enqueue(new ValueTuple<char, int>(item, item2));
					}
				}
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000C8230 File Offset: 0x000C6430
		public unsafe void OptimizeChildren()
		{
			Dictionary<char, int> dictionary = this._children as Dictionary<char, int>;
			if (dictionary != null)
			{
				dictionary.Add((char)this._firstChildChar, this._firstChildIndex);
				float num = -2f;
				foreach (KeyValuePair<char, int> keyValuePair in dictionary)
				{
					char c;
					int num2;
					keyValuePair.Deconstruct(out c, out num2);
					char c2 = c;
					int firstChildIndex = num2;
					float num3 = char.IsAscii(c2) ? (*CharacterFrequencyHelper.AsciiFrequency[(int)c2]) : -1f;
					if (num3 > num)
					{
						num = num3;
						this._firstChildChar = (int)c2;
						this._firstChildIndex = firstChildIndex;
					}
				}
				dictionary.Remove((char)this._firstChildChar);
				int[] children;
				if (AhoCorasickNode.<OptimizeChildren>g__TryCreateJumpTable|11_0(dictionary, out children))
				{
					this._children = children;
				}
			}
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x000C8310 File Offset: 0x000C6510
		[CompilerGenerated]
		internal static bool <OptimizeChildren>g__TryCreateJumpTable|11_0(Dictionary<char, int> children, [NotNullWhen(true)] out int[] table)
		{
			int num = -1;
			foreach (KeyValuePair<char, int> keyValuePair in children)
			{
				char c;
				int num2;
				keyValuePair.Deconstruct(out c, out num2);
				char val = c;
				num = Math.Max(num, (int)val);
			}
			int num3 = AhoCorasickNode.<OptimizeChildren>g__TableMemoryFootprintBytesEstimate|11_1(num);
			int num4 = AhoCorasickNode.<OptimizeChildren>g__DictionaryMemoryFootprintBytesEstimate|11_2(children.Count);
			if (num3 > num4 * 2)
			{
				table = null;
				return false;
			}
			table = new int[num + 1];
			Array.Fill<int>(table, -1);
			foreach (KeyValuePair<char, int> keyValuePair in children)
			{
				char c;
				int num2;
				keyValuePair.Deconstruct(out c, out num2);
				char c2 = c;
				int num5 = num2;
				table[(int)c2] = num5;
			}
			return true;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x000C83F0 File Offset: 0x000C65F0
		[CompilerGenerated]
		internal static int <OptimizeChildren>g__TableMemoryFootprintBytesEstimate|11_1(int maxValue)
		{
			return 32 + maxValue * 4;
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x000C83F8 File Offset: 0x000C65F8
		[CompilerGenerated]
		internal static int <OptimizeChildren>g__DictionaryMemoryFootprintBytesEstimate|11_2(int childCount)
		{
			int result;
			if (childCount < 8)
			{
				if (childCount >= 4)
				{
					result = 272;
				}
				else
				{
					result = 192;
				}
			}
			else if (childCount >= 12)
			{
				result = childCount * 25;
			}
			else
			{
				result = 352;
			}
			return result;
		}

		// Token: 0x04000CA8 RID: 3240
		public int SuffixLink;

		// Token: 0x04000CA9 RID: 3241
		public int MatchLength;

		// Token: 0x04000CAA RID: 3242
		private int _firstChildChar;

		// Token: 0x04000CAB RID: 3243
		private int _firstChildIndex;

		// Token: 0x04000CAC RID: 3244
		private object _children;
	}
}

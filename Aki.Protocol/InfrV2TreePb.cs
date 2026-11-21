using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F8 RID: 2040
	public sealed class InfrV2TreePb : IMessage<InfrV2TreePb>, IMessage, IEquatable<InfrV2TreePb>, IDeepCloneable<InfrV2TreePb>, IBufferMessage
	{
		// Token: 0x0600B6F0 RID: 46832 RVA: 0x001B4558 File Offset: 0x001B2758
		[NullableContext(1)]
		public static InfrV2TreePb Create()
		{
			return new InfrV2TreePb();
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x0600B6F1 RID: 46833 RVA: 0x001B455F File Offset: 0x001B275F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600B6F2 RID: 46834 RVA: 0x001B4562 File Offset: 0x001B2762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreePb.Descriptor;
			}
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x001B4569 File Offset: 0x001B2769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb()
		{
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x001B457C File Offset: 0x001B277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb(InfrV2TreePb other) : this()
		{
			this.trees_ = other.trees_.Clone();
			this.manualTraceTree_ = other.manualTraceTree_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x001B45B2 File Offset: 0x001B27B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb Clone()
		{
			return new InfrV2TreePb(this);
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600B6F6 RID: 46838 RVA: 0x001B45BA File Offset: 0x001B27BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrV2OneTree> Trees
		{
			get
			{
				return this.trees_;
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x001B45C2 File Offset: 0x001B27C2
		// (set) Token: 0x0600B6F8 RID: 46840 RVA: 0x001B45CA File Offset: 0x001B27CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ManualTraceTree
		{
			get
			{
				return this.manualTraceTree_;
			}
			set
			{
				this.manualTraceTree_ = value;
			}
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x001B45D3 File Offset: 0x001B27D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreePb);
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x001B45E4 File Offset: 0x001B27E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreePb other)
		{
			return other != null && (other == this || (this.trees_.Equals(other.trees_) && this.ManualTraceTree == other.ManualTraceTree && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x001B4634 File Offset: 0x001B2834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trees_.GetHashCode();
			if (this.ManualTraceTree != 0)
			{
				num ^= this.ManualTraceTree.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x001B4681 File Offset: 0x001B2881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x001B468E File Offset: 0x001B288E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x001B4698 File Offset: 0x001B2898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trees_.WriteTo(ref output, InfrV2TreePb._repeated_trees_codec);
			if (this.ManualTraceTree != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ManualTraceTree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x001B46E8 File Offset: 0x001B28E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trees_.CalculateSize(InfrV2TreePb._repeated_trees_codec);
			if (this.ManualTraceTree != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ManualTraceTree);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x001B473C File Offset: 0x001B293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreePb other)
		{
			if (other == null)
			{
				return;
			}
			this.trees_.Add(other.trees_);
			if (other.ManualTraceTree != 0)
			{
				this.ManualTraceTree = other.ManualTraceTree;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x001B4789 File Offset: 0x001B2989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x001B4794 File Offset: 0x001B2994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ManualTraceTree = input.ReadInt32();
					}
				}
				else
				{
					this.trees_.AddEntriesFrom(ref input, InfrV2TreePb._repeated_trees_codec);
				}
			}
		}

		// Token: 0x0400512B RID: 20779
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400512C RID: 20780
		public const int TreesFieldNumber = 1;

		// Token: 0x0400512D RID: 20781
		private static readonly FieldCodec<InfrV2OneTree> _repeated_trees_codec = FieldCodec.ForMessage<InfrV2OneTree>(10U, InfrV2OneTree.Parser);

		// Token: 0x0400512E RID: 20782
		private readonly RepeatedField<InfrV2OneTree> trees_ = new RepeatedField<InfrV2OneTree>();

		// Token: 0x0400512F RID: 20783
		public const int ManualTraceTreeFieldNumber = 3;

		// Token: 0x04005130 RID: 20784
		private int manualTraceTree_;
	}
}

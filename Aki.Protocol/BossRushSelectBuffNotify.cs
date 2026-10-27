using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DE RID: 478
	[NetMessage(EMessageId.BossRushSelectBuffNotify)]
	public sealed class BossRushSelectBuffNotify : IMessage<BossRushSelectBuffNotify>, IMessage, IEquatable<BossRushSelectBuffNotify>, IDeepCloneable<BossRushSelectBuffNotify>, IBufferMessage
	{
		// Token: 0x060035FD RID: 13821 RVA: 0x00087C93 File Offset: 0x00085E93
		[NullableContext(1)]
		public static BossRushSelectBuffNotify Create()
		{
			return new BossRushSelectBuffNotify();
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x00087C9A File Offset: 0x00085E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x00087C9D File Offset: 0x00085E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSelectBuffNotify.Descriptor;
			}
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00087CA4 File Offset: 0x00085EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify()
		{
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00087CB8 File Offset: 0x00085EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify(BossRushSelectBuffNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.selectBuffIndices_ = other.selectBuffIndices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x00087D05 File Offset: 0x00085F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSelectBuffNotify Clone()
		{
			return new BossRushSelectBuffNotify(this);
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x00087D0D File Offset: 0x00085F0D
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x00087D15 File Offset: 0x00085F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00087D1E File Offset: 0x00085F1E
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x00087D26 File Offset: 0x00085F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x00087D2F File Offset: 0x00085F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuffIndices
		{
			get
			{
				return this.selectBuffIndices_;
			}
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00087D37 File Offset: 0x00085F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSelectBuffNotify);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00087D48 File Offset: 0x00085F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSelectBuffNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.selectBuffIndices_.Equals(other.selectBuffIndices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00087DA8 File Offset: 0x00085FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.selectBuffIndices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00087E0E File Offset: 0x0008600E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00087E1B File Offset: 0x0008601B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00087E24 File Offset: 0x00086024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectBuffIndices_.WriteTo(ref output, BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00087E90 File Offset: 0x00086090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.selectBuffIndices_.CalculateSize(BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00087EFC File Offset: 0x000860FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSelectBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.selectBuffIndices_.Add(other.selectBuffIndices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00087F5D File Offset: 0x0008615D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00087F68 File Offset: 0x00086168
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
				if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.selectBuffIndices_.AddEntriesFrom(ref input, BossRushSelectBuffNotify._repeated_selectBuffIndices_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A89 RID: 10889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A8A RID: 10890
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04002A8B RID: 10891
		private int activityId_;

		// Token: 0x04002A8C RID: 10892
		public const int InstIdFieldNumber = 12;

		// Token: 0x04002A8D RID: 10893
		private int instId_;

		// Token: 0x04002A8E RID: 10894
		public const int SelectBuffIndicesFieldNumber = 8;

		// Token: 0x04002A8F RID: 10895
		private static readonly FieldCodec<int> _repeated_selectBuffIndices_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04002A90 RID: 10896
		private readonly RepeatedField<int> selectBuffIndices_ = new RepeatedField<int>();
	}
}

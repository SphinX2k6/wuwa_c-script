using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038C RID: 908
	[NetMessage(EMessageId.DangoMonopolyRewardNotify)]
	public sealed class DangoMonopolyRewardNotify : IMessage<DangoMonopolyRewardNotify>, IMessage, IEquatable<DangoMonopolyRewardNotify>, IDeepCloneable<DangoMonopolyRewardNotify>, IBufferMessage
	{
		// Token: 0x060059BF RID: 22975 RVA: 0x000DA843 File Offset: 0x000D8A43
		[NullableContext(1)]
		public static DangoMonopolyRewardNotify Create()
		{
			return new DangoMonopolyRewardNotify();
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x000DA84A File Offset: 0x000D8A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060059C1 RID: 22977 RVA: 0x000DA84D File Offset: 0x000D8A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyRewardNotify.Descriptor;
			}
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x000DA854 File Offset: 0x000D8A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify()
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x000DA867 File Offset: 0x000D8A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify(DangoMonopolyRewardNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.rewardDatas_ = other.rewardDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x000DA89D File Offset: 0x000D8A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify Clone()
		{
			return new DangoMonopolyRewardNotify(this);
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060059C5 RID: 22981 RVA: 0x000DA8A5 File Offset: 0x000D8AA5
		// (set) Token: 0x060059C6 RID: 22982 RVA: 0x000DA8AD File Offset: 0x000D8AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060059C7 RID: 22983 RVA: 0x000DA8B6 File Offset: 0x000D8AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyRewardPb> RewardDatas
		{
			get
			{
				return this.rewardDatas_;
			}
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x000DA8BE File Offset: 0x000D8ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyRewardNotify);
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x000DA8CC File Offset: 0x000D8ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyRewardNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.rewardDatas_.Equals(other.rewardDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x000DA91C File Offset: 0x000D8B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.rewardDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x000DA969 File Offset: 0x000D8B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x000DA976 File Offset: 0x000D8B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x000DA980 File Offset: 0x000D8B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardDatas_.WriteTo(ref output, DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x000DA9D0 File Offset: 0x000D8BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			num += this.rewardDatas_.CalculateSize(DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x000DAA24 File Offset: 0x000D8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this.rewardDatas_.Add(other.rewardDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x000DAA71 File Offset: 0x000D8C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x000DAA7C File Offset: 0x000D8C7C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.rewardDatas_.AddEntriesFrom(ref input, DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
				}
			}
		}

		// Token: 0x0400357C RID: 13692
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400357D RID: 13693
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400357E RID: 13694
		private int reason_;

		// Token: 0x0400357F RID: 13695
		public const int RewardDatasFieldNumber = 1;

		// Token: 0x04003580 RID: 13696
		private static readonly FieldCodec<DangoMonopolyRewardPb> _repeated_rewardDatas_codec = FieldCodec.ForMessage<DangoMonopolyRewardPb>(10U, DangoMonopolyRewardPb.Parser);

		// Token: 0x04003581 RID: 13697
		private readonly RepeatedField<DangoMonopolyRewardPb> rewardDatas_ = new RepeatedField<DangoMonopolyRewardPb>();
	}
}

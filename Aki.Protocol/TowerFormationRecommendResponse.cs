using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BB RID: 5051
	[NetMessage(EMessageId.TowerFormationRecommendResponse)]
	public sealed class TowerFormationRecommendResponse : IMessage<TowerFormationRecommendResponse>, IMessage, IEquatable<TowerFormationRecommendResponse>, IDeepCloneable<TowerFormationRecommendResponse>, IBufferMessage
	{
		// Token: 0x0601ACBA RID: 109754 RVA: 0x003E2AC5 File Offset: 0x003E0CC5
		[NullableContext(1)]
		public static TowerFormationRecommendResponse Create()
		{
			return new TowerFormationRecommendResponse();
		}

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x0601ACBB RID: 109755 RVA: 0x003E2ACC File Offset: 0x003E0CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x0601ACBC RID: 109756 RVA: 0x003E2ACF File Offset: 0x003E0CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFormationRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0601ACBD RID: 109757 RVA: 0x003E2AD6 File Offset: 0x003E0CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendResponse()
		{
		}

		// Token: 0x0601ACBE RID: 109758 RVA: 0x003E2AEC File Offset: 0x003E0CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendResponse(TowerFormationRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this.towerConfigId_ = other.towerConfigId_;
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACBF RID: 109759 RVA: 0x003E2B45 File Offset: 0x003E0D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendResponse Clone()
		{
			return new TowerFormationRecommendResponse(this);
		}

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x0601ACC0 RID: 109760 RVA: 0x003E2B4D File Offset: 0x003E0D4D
		// (set) Token: 0x0601ACC1 RID: 109761 RVA: 0x003E2B55 File Offset: 0x003E0D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x0601ACC2 RID: 109762 RVA: 0x003E2B5E File Offset: 0x003E0D5E
		// (set) Token: 0x0601ACC3 RID: 109763 RVA: 0x003E2B66 File Offset: 0x003E0D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x0601ACC4 RID: 109764 RVA: 0x003E2B6F File Offset: 0x003E0D6F
		// (set) Token: 0x0601ACC5 RID: 109765 RVA: 0x003E2B77 File Offset: 0x003E0D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x0601ACC6 RID: 109766 RVA: 0x003E2B80 File Offset: 0x003E0D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRecommendFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x0601ACC7 RID: 109767 RVA: 0x003E2B88 File Offset: 0x003E0D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFormationRecommendResponse);
		}

		// Token: 0x0601ACC8 RID: 109768 RVA: 0x003E2B98 File Offset: 0x003E0D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFormationRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && this.TowerConfigId == other.TowerConfigId && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACC9 RID: 109769 RVA: 0x003E2C08 File Offset: 0x003E0E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			num ^= this.formations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACCA RID: 109770 RVA: 0x003E2C8D File Offset: 0x003E0E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACCB RID: 109771 RVA: 0x003E2C9A File Offset: 0x003E0E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACCC RID: 109772 RVA: 0x003E2CA4 File Offset: 0x003E0EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TowerConfigId);
			}
			this.formations_.WriteTo(ref output, TowerFormationRecommendResponse._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACCD RID: 109773 RVA: 0x003E2D2C File Offset: 0x003E0F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			num += this.formations_.CalculateSize(TowerFormationRecommendResponse._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACCE RID: 109774 RVA: 0x003E2DA4 File Offset: 0x003E0FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFormationRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this.formations_.Add(other.formations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACCF RID: 109775 RVA: 0x003E2E19 File Offset: 0x003E1019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACD0 RID: 109776 RVA: 0x003E2E24 File Offset: 0x003E1024
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
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.NeedUpdateSeason = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.TowerConfigId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.formations_.AddEntriesFrom(ref input, TowerFormationRecommendResponse._repeated_formations_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B8E RID: 39822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B8F RID: 39823
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009B90 RID: 39824
		private ErrorCode errorCode_;

		// Token: 0x04009B91 RID: 39825
		public const int NeedUpdateSeasonFieldNumber = 5;

		// Token: 0x04009B92 RID: 39826
		private bool needUpdateSeason_;

		// Token: 0x04009B93 RID: 39827
		public const int TowerConfigIdFieldNumber = 11;

		// Token: 0x04009B94 RID: 39828
		private int towerConfigId_;

		// Token: 0x04009B95 RID: 39829
		public const int FormationsFieldNumber = 15;

		// Token: 0x04009B96 RID: 39830
		private static readonly FieldCodec<TowerRecommendFormation> _repeated_formations_codec = FieldCodec.ForMessage<TowerRecommendFormation>(122U, TowerRecommendFormation.Parser);

		// Token: 0x04009B97 RID: 39831
		private readonly RepeatedField<TowerRecommendFormation> formations_ = new RepeatedField<TowerRecommendFormation>();
	}
}

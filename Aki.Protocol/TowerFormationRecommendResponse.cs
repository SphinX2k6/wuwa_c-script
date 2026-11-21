using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142E RID: 5166
	[NetMessage(EMessageId.TowerFormationRecommendResponse)]
	public sealed class TowerFormationRecommendResponse : IMessage<TowerFormationRecommendResponse>, IMessage, IEquatable<TowerFormationRecommendResponse>, IDeepCloneable<TowerFormationRecommendResponse>, IBufferMessage
	{
		// Token: 0x0601B745 RID: 112453 RVA: 0x003FDD89 File Offset: 0x003FBF89
		[NullableContext(1)]
		public static TowerFormationRecommendResponse Create()
		{
			return new TowerFormationRecommendResponse();
		}

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x0601B746 RID: 112454 RVA: 0x003FDD90 File Offset: 0x003FBF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x0601B747 RID: 112455 RVA: 0x003FDD93 File Offset: 0x003FBF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFormationRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0601B748 RID: 112456 RVA: 0x003FDD9A File Offset: 0x003FBF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendResponse()
		{
		}

		// Token: 0x0601B749 RID: 112457 RVA: 0x003FDDB0 File Offset: 0x003FBFB0
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

		// Token: 0x0601B74A RID: 112458 RVA: 0x003FDE09 File Offset: 0x003FC009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendResponse Clone()
		{
			return new TowerFormationRecommendResponse(this);
		}

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x0601B74B RID: 112459 RVA: 0x003FDE11 File Offset: 0x003FC011
		// (set) Token: 0x0601B74C RID: 112460 RVA: 0x003FDE19 File Offset: 0x003FC019
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

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x0601B74D RID: 112461 RVA: 0x003FDE22 File Offset: 0x003FC022
		// (set) Token: 0x0601B74E RID: 112462 RVA: 0x003FDE2A File Offset: 0x003FC02A
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

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x0601B74F RID: 112463 RVA: 0x003FDE33 File Offset: 0x003FC033
		// (set) Token: 0x0601B750 RID: 112464 RVA: 0x003FDE3B File Offset: 0x003FC03B
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

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x0601B751 RID: 112465 RVA: 0x003FDE44 File Offset: 0x003FC044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRecommendFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x0601B752 RID: 112466 RVA: 0x003FDE4C File Offset: 0x003FC04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFormationRecommendResponse);
		}

		// Token: 0x0601B753 RID: 112467 RVA: 0x003FDE5C File Offset: 0x003FC05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFormationRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && this.TowerConfigId == other.TowerConfigId && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B754 RID: 112468 RVA: 0x003FDECC File Offset: 0x003FC0CC
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

		// Token: 0x0601B755 RID: 112469 RVA: 0x003FDF51 File Offset: 0x003FC151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B756 RID: 112470 RVA: 0x003FDF5E File Offset: 0x003FC15E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B757 RID: 112471 RVA: 0x003FDF68 File Offset: 0x003FC168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TowerConfigId);
			}
			this.formations_.WriteTo(ref output, TowerFormationRecommendResponse._repeated_formations_codec);
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B758 RID: 112472 RVA: 0x003FDFF0 File Offset: 0x003FC1F0
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

		// Token: 0x0601B759 RID: 112473 RVA: 0x003FE068 File Offset: 0x003FC268
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

		// Token: 0x0601B75A RID: 112474 RVA: 0x003FE0DD File Offset: 0x003FC2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B75B RID: 112475 RVA: 0x003FE0E8 File Offset: 0x003FC2E8
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
				if (num <= 96U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.TowerConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.formations_.AddEntriesFrom(ref input, TowerFormationRecommendResponse._repeated_formations_codec);
						continue;
					}
					if (num == 120U)
					{
						this.NeedUpdateSeason = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009FD5 RID: 40917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FD6 RID: 40918
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009FD7 RID: 40919
		private ErrorCode errorCode_;

		// Token: 0x04009FD8 RID: 40920
		public const int NeedUpdateSeasonFieldNumber = 15;

		// Token: 0x04009FD9 RID: 40921
		private bool needUpdateSeason_;

		// Token: 0x04009FDA RID: 40922
		public const int TowerConfigIdFieldNumber = 12;

		// Token: 0x04009FDB RID: 40923
		private int towerConfigId_;

		// Token: 0x04009FDC RID: 40924
		public const int FormationsFieldNumber = 13;

		// Token: 0x04009FDD RID: 40925
		private static readonly FieldCodec<TowerRecommendFormation> _repeated_formations_codec = FieldCodec.ForMessage<TowerRecommendFormation>(106U, TowerRecommendFormation.Parser);

		// Token: 0x04009FDE RID: 40926
		private readonly RepeatedField<TowerRecommendFormation> formations_ = new RepeatedField<TowerRecommendFormation>();
	}
}

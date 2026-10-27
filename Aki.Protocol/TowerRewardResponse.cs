using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CA RID: 5066
	[NetMessage(EMessageId.TowerRewardResponse)]
	public sealed class TowerRewardResponse : IMessage<TowerRewardResponse>, IMessage, IEquatable<TowerRewardResponse>, IDeepCloneable<TowerRewardResponse>, IBufferMessage
	{
		// Token: 0x0601ADEB RID: 110059 RVA: 0x003E52FD File Offset: 0x003E34FD
		[NullableContext(1)]
		public static TowerRewardResponse Create()
		{
			return new TowerRewardResponse();
		}

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x0601ADEC RID: 110060 RVA: 0x003E5304 File Offset: 0x003E3504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x0601ADED RID: 110061 RVA: 0x003E5307 File Offset: 0x003E3507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x003E530E File Offset: 0x003E350E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse()
		{
		}

		// Token: 0x0601ADEF RID: 110063 RVA: 0x003E5324 File Offset: 0x003E3524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse(TowerRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this.rewardIndexList_ = other.rewardIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADF0 RID: 110064 RVA: 0x003E5371 File Offset: 0x003E3571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse Clone()
		{
			return new TowerRewardResponse(this);
		}

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x0601ADF1 RID: 110065 RVA: 0x003E5379 File Offset: 0x003E3579
		// (set) Token: 0x0601ADF2 RID: 110066 RVA: 0x003E5381 File Offset: 0x003E3581
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

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x0601ADF3 RID: 110067 RVA: 0x003E538A File Offset: 0x003E358A
		// (set) Token: 0x0601ADF4 RID: 110068 RVA: 0x003E5392 File Offset: 0x003E3592
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

		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x0601ADF5 RID: 110069 RVA: 0x003E539B File Offset: 0x003E359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndexList
		{
			get
			{
				return this.rewardIndexList_;
			}
		}

		// Token: 0x0601ADF6 RID: 110070 RVA: 0x003E53A3 File Offset: 0x003E35A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRewardResponse);
		}

		// Token: 0x0601ADF7 RID: 110071 RVA: 0x003E53B4 File Offset: 0x003E35B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && this.rewardIndexList_.Equals(other.rewardIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADF8 RID: 110072 RVA: 0x003E5414 File Offset: 0x003E3614
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
			num ^= this.rewardIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADF9 RID: 110073 RVA: 0x003E5480 File Offset: 0x003E3680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADFA RID: 110074 RVA: 0x003E548D File Offset: 0x003E368D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADFB RID: 110075 RVA: 0x003E5498 File Offset: 0x003E3698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.NeedUpdateSeason);
			}
			this.rewardIndexList_.WriteTo(ref output, TowerRewardResponse._repeated_rewardIndexList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADFC RID: 110076 RVA: 0x003E5504 File Offset: 0x003E3704
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
			num += this.rewardIndexList_.CalculateSize(TowerRewardResponse._repeated_rewardIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADFD RID: 110077 RVA: 0x003E5564 File Offset: 0x003E3764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRewardResponse other)
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
			this.rewardIndexList_.Add(other.rewardIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADFE RID: 110078 RVA: 0x003E55C5 File Offset: 0x003E37C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADFF RID: 110079 RVA: 0x003E55D0 File Offset: 0x003E37D0
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
					if (num == 64U)
					{
						this.NeedUpdateSeason = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.rewardIndexList_.AddEntriesFrom(ref input, TowerRewardResponse._repeated_rewardIndexList_codec);
			}
		}

		// Token: 0x04009BE2 RID: 39906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BE3 RID: 39907
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009BE4 RID: 39908
		private ErrorCode errorCode_;

		// Token: 0x04009BE5 RID: 39909
		public const int NeedUpdateSeasonFieldNumber = 8;

		// Token: 0x04009BE6 RID: 39910
		private bool needUpdateSeason_;

		// Token: 0x04009BE7 RID: 39911
		public const int RewardIndexListFieldNumber = 12;

		// Token: 0x04009BE8 RID: 39912
		private static readonly FieldCodec<int> _repeated_rewardIndexList_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009BE9 RID: 39913
		private readonly RepeatedField<int> rewardIndexList_ = new RepeatedField<int>();
	}
}

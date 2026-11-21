using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BA RID: 1722
	[NetMessage(EMessageId.GetLevelPlayRewardsResponse)]
	public sealed class GetLevelPlayRewardsResponse : IMessage<GetLevelPlayRewardsResponse>, IMessage, IEquatable<GetLevelPlayRewardsResponse>, IDeepCloneable<GetLevelPlayRewardsResponse>, IBufferMessage
	{
		// Token: 0x06009DE7 RID: 40423 RVA: 0x0017F6BC File Offset: 0x0017D8BC
		[NullableContext(1)]
		public static GetLevelPlayRewardsResponse Create()
		{
			return new GetLevelPlayRewardsResponse();
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x0017F6C3 File Offset: 0x0017D8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x0017F6C6 File Offset: 0x0017D8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelPlayRewardsResponse.Descriptor;
			}
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x0017F6CD File Offset: 0x0017D8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse()
		{
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x0017F6EC File Offset: 0x0017D8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse(GetLevelPlayRewardsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardNodeIds_ = other.rewardNodeIds_.Clone();
			this.treasureBoxIds_ = other.treasureBoxIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x0017F73E File Offset: 0x0017D93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse Clone()
		{
			return new GetLevelPlayRewardsResponse(this);
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06009DED RID: 40429 RVA: 0x0017F746 File Offset: 0x0017D946
		// (set) Token: 0x06009DEE RID: 40430 RVA: 0x0017F74E File Offset: 0x0017D94E
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06009DEF RID: 40431 RVA: 0x0017F757 File Offset: 0x0017D957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardNodeIds
		{
			get
			{
				return this.rewardNodeIds_;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x0017F75F File Offset: 0x0017D95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxIds
		{
			get
			{
				return this.treasureBoxIds_;
			}
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x0017F767 File Offset: 0x0017D967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelPlayRewardsResponse);
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x0017F778 File Offset: 0x0017D978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelPlayRewardsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardNodeIds_.Equals(other.rewardNodeIds_) && this.treasureBoxIds_.Equals(other.treasureBoxIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x0017F7DC File Offset: 0x0017D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rewardNodeIds_.GetHashCode();
			num ^= this.treasureBoxIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x0017F83D File Offset: 0x0017DA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x0017F84A File Offset: 0x0017DA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x0017F854 File Offset: 0x0017DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.treasureBoxIds_.WriteTo(ref output, GetLevelPlayRewardsResponse._repeated_treasureBoxIds_codec);
			this.rewardNodeIds_.WriteTo(ref output, GetLevelPlayRewardsResponse._repeated_rewardNodeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x0017F8B4 File Offset: 0x0017DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardNodeIds_.CalculateSize(GetLevelPlayRewardsResponse._repeated_rewardNodeIds_codec);
			num += this.treasureBoxIds_.CalculateSize(GetLevelPlayRewardsResponse._repeated_treasureBoxIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x0017F918 File Offset: 0x0017DB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelPlayRewardsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardNodeIds_.Add(other.rewardNodeIds_);
			this.treasureBoxIds_.Add(other.treasureBoxIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x0017F976 File Offset: 0x0017DB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x0017F980 File Offset: 0x0017DB80
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4A;
					}
					if (num == 88U || num == 90U)
					{
						this.rewardNodeIds_.AddEntriesFrom(ref input, GetLevelPlayRewardsResponse._repeated_rewardNodeIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.treasureBoxIds_.AddEntriesFrom(ref input, GetLevelPlayRewardsResponse._repeated_treasureBoxIds_codec);
			}
		}

		// Token: 0x04004A59 RID: 19033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A5A RID: 19034
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004A5B RID: 19035
		private ErrorCode errorCode_;

		// Token: 0x04004A5C RID: 19036
		public const int RewardNodeIdsFieldNumber = 11;

		// Token: 0x04004A5D RID: 19037
		private static readonly FieldCodec<int> _repeated_rewardNodeIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004A5E RID: 19038
		private readonly RepeatedField<int> rewardNodeIds_ = new RepeatedField<int>();

		// Token: 0x04004A5F RID: 19039
		public const int TreasureBoxIdsFieldNumber = 9;

		// Token: 0x04004A60 RID: 19040
		private static readonly FieldCodec<int> _repeated_treasureBoxIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004A61 RID: 19041
		private readonly RepeatedField<int> treasureBoxIds_ = new RepeatedField<int>();
	}
}

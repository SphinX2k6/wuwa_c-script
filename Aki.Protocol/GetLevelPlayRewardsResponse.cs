using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CE RID: 1742
	[NetMessage(EMessageId.GetLevelPlayRewardsResponse)]
	public sealed class GetLevelPlayRewardsResponse : IMessage<GetLevelPlayRewardsResponse>, IMessage, IEquatable<GetLevelPlayRewardsResponse>, IDeepCloneable<GetLevelPlayRewardsResponse>, IBufferMessage
	{
		// Token: 0x06009F3D RID: 40765 RVA: 0x001820F0 File Offset: 0x001802F0
		[NullableContext(1)]
		public static GetLevelPlayRewardsResponse Create()
		{
			return new GetLevelPlayRewardsResponse();
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06009F3E RID: 40766 RVA: 0x001820F7 File Offset: 0x001802F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x001820FA File Offset: 0x001802FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelPlayRewardsResponse.Descriptor;
			}
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x00182101 File Offset: 0x00180301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse()
		{
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x00182120 File Offset: 0x00180320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse(GetLevelPlayRewardsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardNodeIds_ = other.rewardNodeIds_.Clone();
			this.treasureBoxIds_ = other.treasureBoxIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x00182172 File Offset: 0x00180372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsResponse Clone()
		{
			return new GetLevelPlayRewardsResponse(this);
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06009F43 RID: 40771 RVA: 0x0018217A File Offset: 0x0018037A
		// (set) Token: 0x06009F44 RID: 40772 RVA: 0x00182182 File Offset: 0x00180382
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

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06009F45 RID: 40773 RVA: 0x0018218B File Offset: 0x0018038B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardNodeIds
		{
			get
			{
				return this.rewardNodeIds_;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06009F46 RID: 40774 RVA: 0x00182193 File Offset: 0x00180393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxIds
		{
			get
			{
				return this.treasureBoxIds_;
			}
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x0018219B File Offset: 0x0018039B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelPlayRewardsResponse);
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x001821AC File Offset: 0x001803AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelPlayRewardsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardNodeIds_.Equals(other.rewardNodeIds_) && this.treasureBoxIds_.Equals(other.treasureBoxIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x00182210 File Offset: 0x00180410
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

		// Token: 0x06009F4A RID: 40778 RVA: 0x00182271 File Offset: 0x00180471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x0018227E File Offset: 0x0018047E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x00182288 File Offset: 0x00180488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.treasureBoxIds_.WriteTo(ref output, GetLevelPlayRewardsResponse._repeated_treasureBoxIds_codec);
			this.rewardNodeIds_.WriteTo(ref output, GetLevelPlayRewardsResponse._repeated_rewardNodeIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x001822E8 File Offset: 0x001804E8
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

		// Token: 0x06009F4E RID: 40782 RVA: 0x0018234C File Offset: 0x0018054C
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

		// Token: 0x06009F4F RID: 40783 RVA: 0x001823AA File Offset: 0x001805AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x001823B4 File Offset: 0x001805B4
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.treasureBoxIds_.AddEntriesFrom(ref input, GetLevelPlayRewardsResponse._repeated_treasureBoxIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.rewardNodeIds_.AddEntriesFrom(ref input, GetLevelPlayRewardsResponse._repeated_rewardNodeIds_codec);
						continue;
					}
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A60 RID: 19040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A61 RID: 19041
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004A62 RID: 19042
		private ErrorCode errorCode_;

		// Token: 0x04004A63 RID: 19043
		public const int RewardNodeIdsFieldNumber = 8;

		// Token: 0x04004A64 RID: 19044
		private static readonly FieldCodec<int> _repeated_rewardNodeIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004A65 RID: 19045
		private readonly RepeatedField<int> rewardNodeIds_ = new RepeatedField<int>();

		// Token: 0x04004A66 RID: 19046
		public const int TreasureBoxIdsFieldNumber = 7;

		// Token: 0x04004A67 RID: 19047
		private static readonly FieldCodec<int> _repeated_treasureBoxIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004A68 RID: 19048
		private readonly RepeatedField<int> treasureBoxIds_ = new RepeatedField<int>();
	}
}

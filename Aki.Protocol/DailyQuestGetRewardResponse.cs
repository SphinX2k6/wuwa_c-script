using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000328 RID: 808
	[NetMessage(EMessageId.DailyQuestGetRewardResponse)]
	public sealed class DailyQuestGetRewardResponse : IMessage<DailyQuestGetRewardResponse>, IMessage, IEquatable<DailyQuestGetRewardResponse>, IDeepCloneable<DailyQuestGetRewardResponse>, IBufferMessage
	{
		// Token: 0x0600511C RID: 20764 RVA: 0x000C55C1 File Offset: 0x000C37C1
		[NullableContext(1)]
		public static DailyQuestGetRewardResponse Create()
		{
			return new DailyQuestGetRewardResponse();
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x0600511D RID: 20765 RVA: 0x000C55C8 File Offset: 0x000C37C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x000C55CB File Offset: 0x000C37CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestGetRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x000C55D2 File Offset: 0x000C37D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse()
		{
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x000C55E5 File Offset: 0x000C37E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse(DailyQuestGetRewardResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x000C561B File Offset: 0x000C381B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse Clone()
		{
			return new DailyQuestGetRewardResponse(this);
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x000C5623 File Offset: 0x000C3823
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x000C562B File Offset: 0x000C382B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x000C5634 File Offset: 0x000C3834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyQuestReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x000C563C File Offset: 0x000C383C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestGetRewardResponse);
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x000C564C File Offset: 0x000C384C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestGetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x000C569C File Offset: 0x000C389C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			num ^= this.rewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x000C56EF File Offset: 0x000C38EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x000C56FC File Offset: 0x000C38FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x000C5708 File Offset: 0x000C3908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			this.rewards_.WriteTo(ref output, DailyQuestGetRewardResponse._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x000C5758 File Offset: 0x000C3958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			num += this.rewards_.CalculateSize(DailyQuestGetRewardResponse._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x000C57AC File Offset: 0x000C39AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestGetRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this.rewards_.Add(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x000C57F9 File Offset: 0x000C39F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x000C5804 File Offset: 0x000C3A04
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
				if (num != 80U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewards_.AddEntriesFrom(ref input, DailyQuestGetRewardResponse._repeated_rewards_codec);
					}
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400328C RID: 12940
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400328D RID: 12941
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x0400328E RID: 12942
		private ErrorCode errorId_;

		// Token: 0x0400328F RID: 12943
		public const int RewardsFieldNumber = 11;

		// Token: 0x04003290 RID: 12944
		private static readonly FieldCodec<DailyQuestReward> _repeated_rewards_codec = FieldCodec.ForMessage<DailyQuestReward>(90U, DailyQuestReward.Parser);

		// Token: 0x04003291 RID: 12945
		private readonly RepeatedField<DailyQuestReward> rewards_ = new RepeatedField<DailyQuestReward>();
	}
}

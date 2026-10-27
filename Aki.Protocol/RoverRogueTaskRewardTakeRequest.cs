using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001130 RID: 4400
	[NetMessage(EMessageId.RoverRogueTaskRewardTakeRequest)]
	public sealed class RoverRogueTaskRewardTakeRequest : IMessage<RoverRogueTaskRewardTakeRequest>, IMessage, IEquatable<RoverRogueTaskRewardTakeRequest>, IDeepCloneable<RoverRogueTaskRewardTakeRequest>, IBufferMessage
	{
		// Token: 0x06017788 RID: 96136 RVA: 0x00368CF1 File Offset: 0x00366EF1
		[NullableContext(1)]
		public static RoverRogueTaskRewardTakeRequest Create()
		{
			return new RoverRogueTaskRewardTakeRequest();
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x06017789 RID: 96137 RVA: 0x00368CF8 File Offset: 0x00366EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x0601778A RID: 96138 RVA: 0x00368CFB File Offset: 0x00366EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskRewardTakeRequest.Descriptor;
			}
		}

		// Token: 0x0601778B RID: 96139 RVA: 0x00368D02 File Offset: 0x00366F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest()
		{
		}

		// Token: 0x0601778C RID: 96140 RVA: 0x00368D15 File Offset: 0x00366F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest(RoverRogueTaskRewardTakeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601778D RID: 96141 RVA: 0x00368D4B File Offset: 0x00366F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest Clone()
		{
			return new RoverRogueTaskRewardTakeRequest(this);
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x0601778E RID: 96142 RVA: 0x00368D53 File Offset: 0x00366F53
		// (set) Token: 0x0601778F RID: 96143 RVA: 0x00368D5B File Offset: 0x00366F5B
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

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x06017790 RID: 96144 RVA: 0x00368D64 File Offset: 0x00366F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06017791 RID: 96145 RVA: 0x00368D6C File Offset: 0x00366F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskRewardTakeRequest);
		}

		// Token: 0x06017792 RID: 96146 RVA: 0x00368D7C File Offset: 0x00366F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskRewardTakeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017793 RID: 96147 RVA: 0x00368DCC File Offset: 0x00366FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017794 RID: 96148 RVA: 0x00368E19 File Offset: 0x00367019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017795 RID: 96149 RVA: 0x00368E26 File Offset: 0x00367026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017796 RID: 96150 RVA: 0x00368E30 File Offset: 0x00367030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.rewardIds_.WriteTo(ref output, RoverRogueTaskRewardTakeRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017797 RID: 96151 RVA: 0x00368E80 File Offset: 0x00367080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.rewardIds_.CalculateSize(RoverRogueTaskRewardTakeRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017798 RID: 96152 RVA: 0x00368ED4 File Offset: 0x003670D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTaskRewardTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017799 RID: 96153 RVA: 0x00368F21 File Offset: 0x00367121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601779A RID: 96154 RVA: 0x00368F2C File Offset: 0x0036712C
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
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIds_.AddEntriesFrom(ref input, RoverRogueTaskRewardTakeRequest._repeated_rewardIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B8F RID: 35727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B90 RID: 35728
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04008B91 RID: 35729
		private int activityId_;

		// Token: 0x04008B92 RID: 35730
		public const int RewardIdsFieldNumber = 8;

		// Token: 0x04008B93 RID: 35731
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008B94 RID: 35732
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116A RID: 4458
	[NetMessage(EMessageId.RoverRogueTaskRewardTakeRequest)]
	public sealed class RoverRogueTaskRewardTakeRequest : IMessage<RoverRogueTaskRewardTakeRequest>, IMessage, IEquatable<RoverRogueTaskRewardTakeRequest>, IDeepCloneable<RoverRogueTaskRewardTakeRequest>, IBufferMessage
	{
		// Token: 0x06017D29 RID: 97577 RVA: 0x00378041 File Offset: 0x00376241
		[NullableContext(1)]
		public static RoverRogueTaskRewardTakeRequest Create()
		{
			return new RoverRogueTaskRewardTakeRequest();
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x06017D2A RID: 97578 RVA: 0x00378048 File Offset: 0x00376248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x06017D2B RID: 97579 RVA: 0x0037804B File Offset: 0x0037624B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskRewardTakeRequest.Descriptor;
			}
		}

		// Token: 0x06017D2C RID: 97580 RVA: 0x00378052 File Offset: 0x00376252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest()
		{
		}

		// Token: 0x06017D2D RID: 97581 RVA: 0x00378065 File Offset: 0x00376265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest(RoverRogueTaskRewardTakeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D2E RID: 97582 RVA: 0x0037809B File Offset: 0x0037629B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeRequest Clone()
		{
			return new RoverRogueTaskRewardTakeRequest(this);
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x06017D2F RID: 97583 RVA: 0x003780A3 File Offset: 0x003762A3
		// (set) Token: 0x06017D30 RID: 97584 RVA: 0x003780AB File Offset: 0x003762AB
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

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x06017D31 RID: 97585 RVA: 0x003780B4 File Offset: 0x003762B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06017D32 RID: 97586 RVA: 0x003780BC File Offset: 0x003762BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskRewardTakeRequest);
		}

		// Token: 0x06017D33 RID: 97587 RVA: 0x003780CC File Offset: 0x003762CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskRewardTakeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D34 RID: 97588 RVA: 0x0037811C File Offset: 0x0037631C
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

		// Token: 0x06017D35 RID: 97589 RVA: 0x00378169 File Offset: 0x00376369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D36 RID: 97590 RVA: 0x00378176 File Offset: 0x00376376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D37 RID: 97591 RVA: 0x00378180 File Offset: 0x00376380
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

		// Token: 0x06017D38 RID: 97592 RVA: 0x003781D0 File Offset: 0x003763D0
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

		// Token: 0x06017D39 RID: 97593 RVA: 0x00378224 File Offset: 0x00376424
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

		// Token: 0x06017D3A RID: 97594 RVA: 0x00378271 File Offset: 0x00376471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D3B RID: 97595 RVA: 0x0037827C File Offset: 0x0037647C
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
					if (num != 88U && num != 90U)
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

		// Token: 0x04008E22 RID: 36386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E23 RID: 36387
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04008E24 RID: 36388
		private int activityId_;

		// Token: 0x04008E25 RID: 36389
		public const int RewardIdsFieldNumber = 11;

		// Token: 0x04008E26 RID: 36390
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04008E27 RID: 36391
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}

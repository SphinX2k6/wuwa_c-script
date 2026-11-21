using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029A RID: 666
	[NetMessage(EMessageId.CircumFluenceTaskRewardRequest)]
	public sealed class CircumFluenceTaskRewardRequest : IMessage<CircumFluenceTaskRewardRequest>, IMessage, IEquatable<CircumFluenceTaskRewardRequest>, IDeepCloneable<CircumFluenceTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600458D RID: 17805 RVA: 0x000AADC8 File Offset: 0x000A8FC8
		[NullableContext(1)]
		public static CircumFluenceTaskRewardRequest Create()
		{
			return new CircumFluenceTaskRewardRequest();
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x000AADCF File Offset: 0x000A8FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x000AADD2 File Offset: 0x000A8FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x000AADD9 File Offset: 0x000A8FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest()
		{
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x000AADEC File Offset: 0x000A8FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest(CircumFluenceTaskRewardRequest other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x000AAE39 File Offset: 0x000A9039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardRequest Clone()
		{
			return new CircumFluenceTaskRewardRequest(this);
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x000AAE41 File Offset: 0x000A9041
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x000AAE49 File Offset: 0x000A9049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceRewardType RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x000AAE52 File Offset: 0x000A9052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000AAE5A File Offset: 0x000A905A
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x000AAE62 File Offset: 0x000A9062
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

		// Token: 0x06004598 RID: 17816 RVA: 0x000AAE6B File Offset: 0x000A906B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceTaskRewardRequest);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000AAE7C File Offset: 0x000A907C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceTaskRewardRequest other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000AAEDC File Offset: 0x000A90DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				num ^= this.RewardType.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x000AAF48 File Offset: 0x000A9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x000AAF55 File Offset: 0x000A9155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x000AAF60 File Offset: 0x000A9160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, CircumFluenceTaskRewardRequest._repeated_ids_codec);
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.RewardType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x000AAFCC File Offset: 0x000A91CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardType != CircumFluenceRewardType.TaskReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardType);
			}
			num += this.ids_.CalculateSize(CircumFluenceTaskRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x000AB038 File Offset: 0x000A9238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CircumFluenceTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardType != CircumFluenceRewardType.TaskReward)
			{
				this.RewardType = other.RewardType;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x000AB099 File Offset: 0x000A9299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x000AB0A4 File Offset: 0x000A92A4
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.RewardType = (CircumFluenceRewardType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.ids_.AddEntriesFrom(ref input, CircumFluenceTaskRewardRequest._repeated_ids_codec);
			}
		}

		// Token: 0x04002F54 RID: 12116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F55 RID: 12117
		public const int RewardTypeFieldNumber = 13;

		// Token: 0x04002F56 RID: 12118
		private CircumFluenceRewardType rewardType_;

		// Token: 0x04002F57 RID: 12119
		public const int IdsFieldNumber = 10;

		// Token: 0x04002F58 RID: 12120
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04002F59 RID: 12121
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04002F5A RID: 12122
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04002F5B RID: 12123
		private int activityId_;
	}
}

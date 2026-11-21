using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000116 RID: 278
	public sealed class ArtemisActivityInfo : IMessage<ArtemisActivityInfo>, IMessage, IEquatable<ArtemisActivityInfo>, IDeepCloneable<ArtemisActivityInfo>, IBufferMessage
	{
		// Token: 0x06002642 RID: 9794 RVA: 0x00065E1A File Offset: 0x0006401A
		[NullableContext(1)]
		public static ArtemisActivityInfo Create()
		{
			return new ArtemisActivityInfo();
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x00065E21 File Offset: 0x00064021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00065E24 File Offset: 0x00064024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisActivityInfo.Descriptor;
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00065E2B File Offset: 0x0006402B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo()
		{
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00065E33 File Offset: 0x00064033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo(ArtemisActivityInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockIndex_ = other.unlockIndex_;
			this.rewardedIndex_ = other.rewardedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00065E70 File Offset: 0x00064070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo Clone()
		{
			return new ArtemisActivityInfo(this);
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x00065E78 File Offset: 0x00064078
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00065E80 File Offset: 0x00064080
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00065E89 File Offset: 0x00064089
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x00065E91 File Offset: 0x00064091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockIndex
		{
			get
			{
				return this.unlockIndex_;
			}
			set
			{
				this.unlockIndex_ = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00065E9A File Offset: 0x0006409A
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00065EA2 File Offset: 0x000640A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedIndex
		{
			get
			{
				return this.rewardedIndex_;
			}
			set
			{
				this.rewardedIndex_ = value;
			}
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00065EAB File Offset: 0x000640AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisActivityInfo);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00065EBC File Offset: 0x000640BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.UnlockIndex == other.UnlockIndex && this.RewardedIndex == other.RewardedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00065F18 File Offset: 0x00064118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.UnlockIndex != 0)
			{
				num ^= this.UnlockIndex.GetHashCode();
			}
			if (this.RewardedIndex != 0)
			{
				num ^= this.RewardedIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00065F89 File Offset: 0x00064189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00065F96 File Offset: 0x00064196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00065FA0 File Offset: 0x000641A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.UnlockIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnlockIndex);
			}
			if (this.RewardedIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardedIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00066014 File Offset: 0x00064214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.UnlockIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockIndex);
			}
			if (this.RewardedIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00066084 File Offset: 0x00064284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.UnlockIndex != 0)
			{
				this.UnlockIndex = other.UnlockIndex;
			}
			if (other.RewardedIndex != 0)
			{
				this.RewardedIndex = other.RewardedIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000660E8 File Offset: 0x000642E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000660F4 File Offset: 0x000642F4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RewardedIndex = input.ReadInt32();
						}
					}
					else
					{
						this.UnlockIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002657 RID: 9815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002658 RID: 9816
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04002659 RID: 9817
		private int activityId_;

		// Token: 0x0400265A RID: 9818
		public const int UnlockIndexFieldNumber = 2;

		// Token: 0x0400265B RID: 9819
		private int unlockIndex_;

		// Token: 0x0400265C RID: 9820
		public const int RewardedIndexFieldNumber = 3;

		// Token: 0x0400265D RID: 9821
		private int rewardedIndex_;
	}
}

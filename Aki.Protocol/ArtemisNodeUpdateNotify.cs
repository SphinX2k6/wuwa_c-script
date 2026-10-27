using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000116 RID: 278
	[NetMessage(EMessageId.ArtemisNodeUpdateNotify)]
	public sealed class ArtemisNodeUpdateNotify : IMessage<ArtemisNodeUpdateNotify>, IMessage, IEquatable<ArtemisNodeUpdateNotify>, IDeepCloneable<ArtemisNodeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600260F RID: 9743 RVA: 0x00065486 File Offset: 0x00063686
		[NullableContext(1)]
		public static ArtemisNodeUpdateNotify Create()
		{
			return new ArtemisNodeUpdateNotify();
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x0006548D File Offset: 0x0006368D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x00065490 File Offset: 0x00063690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00065497 File Offset: 0x00063697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0006549F File Offset: 0x0006369F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify(ArtemisNodeUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockIndex_ = other.unlockIndex_;
			this.rewardedIndex_ = other.rewardedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000654DC File Offset: 0x000636DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify Clone()
		{
			return new ArtemisNodeUpdateNotify(this);
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000654E4 File Offset: 0x000636E4
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x000654EC File Offset: 0x000636EC
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000654F5 File Offset: 0x000636F5
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x000654FD File Offset: 0x000636FD
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x00065506 File Offset: 0x00063706
		// (set) Token: 0x0600261A RID: 9754 RVA: 0x0006550E File Offset: 0x0006370E
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

		// Token: 0x0600261B RID: 9755 RVA: 0x00065517 File Offset: 0x00063717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateNotify);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00065528 File Offset: 0x00063728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.UnlockIndex == other.UnlockIndex && this.RewardedIndex == other.RewardedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00065584 File Offset: 0x00063784
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

		// Token: 0x0600261E RID: 9758 RVA: 0x000655F5 File Offset: 0x000637F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00065602 File Offset: 0x00063802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0006560C File Offset: 0x0006380C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnlockIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.UnlockIndex);
			}
			if (this.RewardedIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RewardedIndex);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00065684 File Offset: 0x00063884
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

		// Token: 0x06002622 RID: 9762 RVA: 0x000656F4 File Offset: 0x000638F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeUpdateNotify other)
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

		// Token: 0x06002623 RID: 9763 RVA: 0x00065758 File Offset: 0x00063958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00065764 File Offset: 0x00063964
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
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
		}

		// Token: 0x040025FA RID: 9722
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025FB RID: 9723
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040025FC RID: 9724
		private int activityId_;

		// Token: 0x040025FD RID: 9725
		public const int UnlockIndexFieldNumber = 5;

		// Token: 0x040025FE RID: 9726
		private int unlockIndex_;

		// Token: 0x040025FF RID: 9727
		public const int RewardedIndexFieldNumber = 10;

		// Token: 0x04002600 RID: 9728
		private int rewardedIndex_;
	}
}

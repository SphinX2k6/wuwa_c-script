using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000118 RID: 280
	[NetMessage(EMessageId.ArtemisNodeUpdateNotify)]
	public sealed class ArtemisNodeUpdateNotify : IMessage<ArtemisNodeUpdateNotify>, IMessage, IEquatable<ArtemisNodeUpdateNotify>, IDeepCloneable<ArtemisNodeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x000664AA File Offset: 0x000646AA
		[NullableContext(1)]
		public static ArtemisNodeUpdateNotify Create()
		{
			return new ArtemisNodeUpdateNotify();
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x000664B1 File Offset: 0x000646B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x000664B4 File Offset: 0x000646B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000664BB File Offset: 0x000646BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify()
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000664C3 File Offset: 0x000646C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify(ArtemisNodeUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockIndex_ = other.unlockIndex_;
			this.rewardedIndex_ = other.rewardedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00066500 File Offset: 0x00064700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateNotify Clone()
		{
			return new ArtemisNodeUpdateNotify(this);
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00066508 File Offset: 0x00064708
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00066510 File Offset: 0x00064710
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00066519 File Offset: 0x00064719
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x00066521 File Offset: 0x00064721
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0006652A File Offset: 0x0006472A
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x00066532 File Offset: 0x00064732
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

		// Token: 0x0600267A RID: 9850 RVA: 0x0006653B File Offset: 0x0006473B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateNotify);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0006654C File Offset: 0x0006474C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.UnlockIndex == other.UnlockIndex && this.RewardedIndex == other.RewardedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000665A8 File Offset: 0x000647A8
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

		// Token: 0x0600267D RID: 9853 RVA: 0x00066619 File Offset: 0x00064819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00066626 File Offset: 0x00064826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00066630 File Offset: 0x00064830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardedIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RewardedIndex);
			}
			if (this.UnlockIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UnlockIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x000666A8 File Offset: 0x000648A8
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

		// Token: 0x06002681 RID: 9857 RVA: 0x00066718 File Offset: 0x00064918
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

		// Token: 0x06002682 RID: 9858 RVA: 0x0006677C File Offset: 0x0006497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00066788 File Offset: 0x00064988
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnlockIndex = input.ReadInt32();
						}
					}
					else
					{
						this.RewardedIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002665 RID: 9829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002666 RID: 9830
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04002667 RID: 9831
		private int activityId_;

		// Token: 0x04002668 RID: 9832
		public const int UnlockIndexFieldNumber = 14;

		// Token: 0x04002669 RID: 9833
		private int unlockIndex_;

		// Token: 0x0400266A RID: 9834
		public const int RewardedIndexFieldNumber = 12;

		// Token: 0x0400266B RID: 9835
		private int rewardedIndex_;
	}
}

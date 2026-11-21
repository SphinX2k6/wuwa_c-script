using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BB RID: 4795
	public sealed class SolarSchoolQuestDataPb : IMessage<SolarSchoolQuestDataPb>, IMessage, IEquatable<SolarSchoolQuestDataPb>, IDeepCloneable<SolarSchoolQuestDataPb>, IBufferMessage
	{
		// Token: 0x0601997A RID: 104826 RVA: 0x003BB919 File Offset: 0x003B9B19
		[NullableContext(1)]
		public static SolarSchoolQuestDataPb Create()
		{
			return new SolarSchoolQuestDataPb();
		}

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x0601997B RID: 104827 RVA: 0x003BB920 File Offset: 0x003B9B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x0601997C RID: 104828 RVA: 0x003BB923 File Offset: 0x003B9B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolQuestDataPb.Descriptor;
			}
		}

		// Token: 0x0601997D RID: 104829 RVA: 0x003BB92A File Offset: 0x003B9B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolQuestDataPb()
		{
		}

		// Token: 0x0601997E RID: 104830 RVA: 0x003BB954 File Offset: 0x003B9B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolQuestDataPb(SolarSchoolQuestDataPb other) : this()
		{
			this.questList_ = other.questList_.Clone();
			this.completedNodeBit_ = other.completedNodeBit_.Clone();
			this.pendingNodeId_ = other.pendingNodeId_.Clone();
			this.rewardedSolarSchoolQuestBit_ = other.rewardedSolarSchoolQuestBit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601997F RID: 104831 RVA: 0x003BB9B7 File Offset: 0x003B9BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolQuestDataPb Clone()
		{
			return new SolarSchoolQuestDataPb(this);
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x06019980 RID: 104832 RVA: 0x003BB9BF File Offset: 0x003B9BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolOneQuestPb> QuestList
		{
			get
			{
				return this.questList_;
			}
		}

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x06019981 RID: 104833 RVA: 0x003BB9C7 File Offset: 0x003B9BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> CompletedNodeBit
		{
			get
			{
				return this.completedNodeBit_;
			}
		}

		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x06019982 RID: 104834 RVA: 0x003BB9CF File Offset: 0x003B9BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PendingNodeId
		{
			get
			{
				return this.pendingNodeId_;
			}
		}

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x06019983 RID: 104835 RVA: 0x003BB9D7 File Offset: 0x003B9BD7
		// (set) Token: 0x06019984 RID: 104836 RVA: 0x003BB9DF File Offset: 0x003B9BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RewardedSolarSchoolQuestBit
		{
			get
			{
				return this.rewardedSolarSchoolQuestBit_;
			}
			set
			{
				this.rewardedSolarSchoolQuestBit_ = value;
			}
		}

		// Token: 0x06019985 RID: 104837 RVA: 0x003BB9E8 File Offset: 0x003B9BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolQuestDataPb);
		}

		// Token: 0x06019986 RID: 104838 RVA: 0x003BB9F8 File Offset: 0x003B9BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolQuestDataPb other)
		{
			return other != null && (other == this || (this.questList_.Equals(other.questList_) && this.completedNodeBit_.Equals(other.completedNodeBit_) && this.pendingNodeId_.Equals(other.pendingNodeId_) && this.RewardedSolarSchoolQuestBit == other.RewardedSolarSchoolQuestBit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019987 RID: 104839 RVA: 0x003BBA70 File Offset: 0x003B9C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questList_.GetHashCode();
			num ^= this.completedNodeBit_.GetHashCode();
			num ^= this.pendingNodeId_.GetHashCode();
			if (this.RewardedSolarSchoolQuestBit != 0L)
			{
				num ^= this.RewardedSolarSchoolQuestBit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019988 RID: 104840 RVA: 0x003BBAD9 File Offset: 0x003B9CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019989 RID: 104841 RVA: 0x003BBAE6 File Offset: 0x003B9CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601998A RID: 104842 RVA: 0x003BBAF0 File Offset: 0x003B9CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questList_.WriteTo(ref output, SolarSchoolQuestDataPb._repeated_questList_codec);
			this.completedNodeBit_.WriteTo(ref output, SolarSchoolQuestDataPb._repeated_completedNodeBit_codec);
			this.pendingNodeId_.WriteTo(ref output, SolarSchoolQuestDataPb._repeated_pendingNodeId_codec);
			if (this.RewardedSolarSchoolQuestBit != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RewardedSolarSchoolQuestBit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601998B RID: 104843 RVA: 0x003BBB60 File Offset: 0x003B9D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questList_.CalculateSize(SolarSchoolQuestDataPb._repeated_questList_codec);
			num += this.completedNodeBit_.CalculateSize(SolarSchoolQuestDataPb._repeated_completedNodeBit_codec);
			num += this.pendingNodeId_.CalculateSize(SolarSchoolQuestDataPb._repeated_pendingNodeId_codec);
			if (this.RewardedSolarSchoolQuestBit != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardedSolarSchoolQuestBit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601998C RID: 104844 RVA: 0x003BBBD8 File Offset: 0x003B9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolQuestDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.questList_.Add(other.questList_);
			this.completedNodeBit_.Add(other.completedNodeBit_);
			this.pendingNodeId_.Add(other.pendingNodeId_);
			if (other.RewardedSolarSchoolQuestBit != 0L)
			{
				this.RewardedSolarSchoolQuestBit = other.RewardedSolarSchoolQuestBit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601998D RID: 104845 RVA: 0x003BBC47 File Offset: 0x003B9E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601998E RID: 104846 RVA: 0x003BBC50 File Offset: 0x003B9E50
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.questList_.AddEntriesFrom(ref input, SolarSchoolQuestDataPb._repeated_questList_codec);
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.completedNodeBit_.AddEntriesFrom(ref input, SolarSchoolQuestDataPb._repeated_completedNodeBit_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.pendingNodeId_.AddEntriesFrom(ref input, SolarSchoolQuestDataPb._repeated_pendingNodeId_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RewardedSolarSchoolQuestBit = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400972F RID: 38703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009730 RID: 38704
		public const int QuestListFieldNumber = 1;

		// Token: 0x04009731 RID: 38705
		private static readonly FieldCodec<SolarSchoolOneQuestPb> _repeated_questList_codec = FieldCodec.ForMessage<SolarSchoolOneQuestPb>(10U, SolarSchoolOneQuestPb.Parser);

		// Token: 0x04009732 RID: 38706
		private readonly RepeatedField<SolarSchoolOneQuestPb> questList_ = new RepeatedField<SolarSchoolOneQuestPb>();

		// Token: 0x04009733 RID: 38707
		public const int CompletedNodeBitFieldNumber = 2;

		// Token: 0x04009734 RID: 38708
		private static readonly FieldCodec<long> _repeated_completedNodeBit_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04009735 RID: 38709
		private readonly RepeatedField<long> completedNodeBit_ = new RepeatedField<long>();

		// Token: 0x04009736 RID: 38710
		public const int PendingNodeIdFieldNumber = 3;

		// Token: 0x04009737 RID: 38711
		private static readonly FieldCodec<int> _repeated_pendingNodeId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009738 RID: 38712
		private readonly RepeatedField<int> pendingNodeId_ = new RepeatedField<int>();

		// Token: 0x04009739 RID: 38713
		public const int RewardedSolarSchoolQuestBitFieldNumber = 4;

		// Token: 0x0400973A RID: 38714
		private long rewardedSolarSchoolQuestBit_;
	}
}

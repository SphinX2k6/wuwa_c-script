using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B9 RID: 4793
	public sealed class SolarSchoolOneQuestRewardPb : IMessage<SolarSchoolOneQuestRewardPb>, IMessage, IEquatable<SolarSchoolOneQuestRewardPb>, IDeepCloneable<SolarSchoolOneQuestRewardPb>, IBufferMessage
	{
		// Token: 0x0601994D RID: 104781 RVA: 0x003BB1A1 File Offset: 0x003B93A1
		[NullableContext(1)]
		public static SolarSchoolOneQuestRewardPb Create()
		{
			return new SolarSchoolOneQuestRewardPb();
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x0601994E RID: 104782 RVA: 0x003BB1A8 File Offset: 0x003B93A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolOneQuestRewardPb> Parser
		{
			get
			{
				return SolarSchoolOneQuestRewardPb._parser;
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x0601994F RID: 104783 RVA: 0x003BB1AF File Offset: 0x003B93AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x06019950 RID: 104784 RVA: 0x003BB1B2 File Offset: 0x003B93B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneQuestRewardPb.Descriptor;
			}
		}

		// Token: 0x06019951 RID: 104785 RVA: 0x003BB1B9 File Offset: 0x003B93B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestRewardPb()
		{
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x003BB1C1 File Offset: 0x003B93C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestRewardPb(SolarSchoolOneQuestRewardPb other) : this()
		{
			this.questRewardId_ = other.questRewardId_;
			this.progress_ = other.progress_;
			this.rewarded_ = other.rewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019953 RID: 104787 RVA: 0x003BB1FE File Offset: 0x003B93FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestRewardPb Clone()
		{
			return new SolarSchoolOneQuestRewardPb(this);
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x06019954 RID: 104788 RVA: 0x003BB206 File Offset: 0x003B9406
		// (set) Token: 0x06019955 RID: 104789 RVA: 0x003BB20E File Offset: 0x003B940E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestRewardId
		{
			get
			{
				return this.questRewardId_;
			}
			set
			{
				this.questRewardId_ = value;
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x06019956 RID: 104790 RVA: 0x003BB217 File Offset: 0x003B9417
		// (set) Token: 0x06019957 RID: 104791 RVA: 0x003BB21F File Offset: 0x003B941F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x06019958 RID: 104792 RVA: 0x003BB228 File Offset: 0x003B9428
		// (set) Token: 0x06019959 RID: 104793 RVA: 0x003BB230 File Offset: 0x003B9430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x0601995A RID: 104794 RVA: 0x003BB239 File Offset: 0x003B9439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneQuestRewardPb);
		}

		// Token: 0x0601995B RID: 104795 RVA: 0x003BB248 File Offset: 0x003B9448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneQuestRewardPb other)
		{
			return other != null && (other == this || (this.QuestRewardId == other.QuestRewardId && this.Progress == other.Progress && this.Rewarded == other.Rewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601995C RID: 104796 RVA: 0x003BB2A4 File Offset: 0x003B94A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestRewardId != 0)
			{
				num ^= this.QuestRewardId.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601995D RID: 104797 RVA: 0x003BB315 File Offset: 0x003B9515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601995E RID: 104798 RVA: 0x003BB322 File Offset: 0x003B9522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601995F RID: 104799 RVA: 0x003BB32C File Offset: 0x003B952C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestRewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestRewardId);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Progress);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019960 RID: 104800 RVA: 0x003BB3A0 File Offset: 0x003B95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestRewardId);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019961 RID: 104801 RVA: 0x003BB404 File Offset: 0x003B9604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneQuestRewardPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestRewardId != 0)
			{
				this.QuestRewardId = other.QuestRewardId;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019962 RID: 104802 RVA: 0x003BB468 File Offset: 0x003B9668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019963 RID: 104803 RVA: 0x003BB474 File Offset: 0x003B9674
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
							this.Rewarded = input.ReadBool();
						}
					}
					else
					{
						this.Progress = input.ReadInt32();
					}
				}
				else
				{
					this.QuestRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400971A RID: 38682
		private static readonly MessageParser<SolarSchoolOneQuestRewardPb> _parser = new MessageParser<SolarSchoolOneQuestRewardPb>(() => new SolarSchoolOneQuestRewardPb());

		// Token: 0x0400971B RID: 38683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400971C RID: 38684
		public const int QuestRewardIdFieldNumber = 1;

		// Token: 0x0400971D RID: 38685
		private int questRewardId_;

		// Token: 0x0400971E RID: 38686
		public const int ProgressFieldNumber = 2;

		// Token: 0x0400971F RID: 38687
		private int progress_;

		// Token: 0x04009720 RID: 38688
		public const int RewardedFieldNumber = 3;

		// Token: 0x04009721 RID: 38689
		private bool rewarded_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B8 RID: 4792
	public sealed class SolarSchoolOneQuestPb : IMessage<SolarSchoolOneQuestPb>, IMessage, IEquatable<SolarSchoolOneQuestPb>, IDeepCloneable<SolarSchoolOneQuestPb>, IBufferMessage
	{
		// Token: 0x06019938 RID: 104760 RVA: 0x003BAED5 File Offset: 0x003B90D5
		[NullableContext(1)]
		public static SolarSchoolOneQuestPb Create()
		{
			return new SolarSchoolOneQuestPb();
		}

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x06019939 RID: 104761 RVA: 0x003BAEDC File Offset: 0x003B90DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolOneQuestPb> Parser
		{
			get
			{
				return SolarSchoolOneQuestPb._parser;
			}
		}

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x0601993A RID: 104762 RVA: 0x003BAEE3 File Offset: 0x003B90E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x0601993B RID: 104763 RVA: 0x003BAEE6 File Offset: 0x003B90E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneQuestPb.Descriptor;
			}
		}

		// Token: 0x0601993C RID: 104764 RVA: 0x003BAEED File Offset: 0x003B90ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestPb()
		{
		}

		// Token: 0x0601993D RID: 104765 RVA: 0x003BAF00 File Offset: 0x003B9100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestPb(SolarSchoolOneQuestPb other) : this()
		{
			this.questId_ = other.questId_;
			this.questReward_ = other.questReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601993E RID: 104766 RVA: 0x003BAF36 File Offset: 0x003B9136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneQuestPb Clone()
		{
			return new SolarSchoolOneQuestPb(this);
		}

		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x0601993F RID: 104767 RVA: 0x003BAF3E File Offset: 0x003B913E
		// (set) Token: 0x06019940 RID: 104768 RVA: 0x003BAF46 File Offset: 0x003B9146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x06019941 RID: 104769 RVA: 0x003BAF4F File Offset: 0x003B914F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolOneQuestRewardPb> QuestReward
		{
			get
			{
				return this.questReward_;
			}
		}

		// Token: 0x06019942 RID: 104770 RVA: 0x003BAF57 File Offset: 0x003B9157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneQuestPb);
		}

		// Token: 0x06019943 RID: 104771 RVA: 0x003BAF68 File Offset: 0x003B9168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneQuestPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.questReward_.Equals(other.questReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019944 RID: 104772 RVA: 0x003BAFB8 File Offset: 0x003B91B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			num ^= this.questReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019945 RID: 104773 RVA: 0x003BB005 File Offset: 0x003B9205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019946 RID: 104774 RVA: 0x003BB012 File Offset: 0x003B9212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019947 RID: 104775 RVA: 0x003BB01C File Offset: 0x003B921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			this.questReward_.WriteTo(ref output, SolarSchoolOneQuestPb._repeated_questReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019948 RID: 104776 RVA: 0x003BB06C File Offset: 0x003B926C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			num += this.questReward_.CalculateSize(SolarSchoolOneQuestPb._repeated_questReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019949 RID: 104777 RVA: 0x003BB0C0 File Offset: 0x003B92C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneQuestPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this.questReward_.Add(other.questReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601994A RID: 104778 RVA: 0x003BB10D File Offset: 0x003B930D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601994B RID: 104779 RVA: 0x003BB118 File Offset: 0x003B9318
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.questReward_.AddEntriesFrom(ref input, SolarSchoolOneQuestPb._repeated_questReward_codec);
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009713 RID: 38675
		private static readonly MessageParser<SolarSchoolOneQuestPb> _parser = new MessageParser<SolarSchoolOneQuestPb>(() => new SolarSchoolOneQuestPb());

		// Token: 0x04009714 RID: 38676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009715 RID: 38677
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04009716 RID: 38678
		private int questId_;

		// Token: 0x04009717 RID: 38679
		public const int QuestRewardFieldNumber = 2;

		// Token: 0x04009718 RID: 38680
		private static readonly FieldCodec<SolarSchoolOneQuestRewardPb> _repeated_questReward_codec = FieldCodec.ForMessage<SolarSchoolOneQuestRewardPb>(18U, SolarSchoolOneQuestRewardPb.Parser);

		// Token: 0x04009719 RID: 38681
		private readonly RepeatedField<SolarSchoolOneQuestRewardPb> questReward_ = new RepeatedField<SolarSchoolOneQuestRewardPb>();
	}
}

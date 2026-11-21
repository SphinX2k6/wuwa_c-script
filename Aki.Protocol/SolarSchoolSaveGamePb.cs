using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BE RID: 4798
	public sealed class SolarSchoolSaveGamePb : IMessage<SolarSchoolSaveGamePb>, IMessage, IEquatable<SolarSchoolSaveGamePb>, IDeepCloneable<SolarSchoolSaveGamePb>, IBufferMessage
	{
		// Token: 0x060199B4 RID: 104884 RVA: 0x003BC0E1 File Offset: 0x003BA2E1
		[NullableContext(1)]
		public static SolarSchoolSaveGamePb Create()
		{
			return new SolarSchoolSaveGamePb();
		}

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x060199B5 RID: 104885 RVA: 0x003BC0E8 File Offset: 0x003BA2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x060199B6 RID: 104886 RVA: 0x003BC0EB File Offset: 0x003BA2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSaveGamePb.Descriptor;
			}
		}

		// Token: 0x060199B7 RID: 104887 RVA: 0x003BC0F2 File Offset: 0x003BA2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveGamePb()
		{
		}

		// Token: 0x060199B8 RID: 104888 RVA: 0x003BC0FC File Offset: 0x003BA2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveGamePb(SolarSchoolSaveGamePb other) : this()
		{
			this.player_ = ((other.player_ != null) ? other.player_.Clone() : null);
			this.time_ = ((other.time_ != null) ? other.time_.Clone() : null);
			this.character_ = ((other.character_ != null) ? other.character_.Clone() : null);
			this.quest_ = ((other.quest_ != null) ? other.quest_.Clone() : null);
			this.inventory_ = ((other.inventory_ != null) ? other.inventory_.Clone() : null);
			this.schedule_ = ((other.schedule_ != null) ? other.schedule_.Clone() : null);
			this.exam_ = ((other.exam_ != null) ? other.exam_.Clone() : null);
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this.avg_ = ((other.avg_ != null) ? other.avg_.Clone() : null);
			this.summary_ = ((other.summary_ != null) ? other.summary_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199B9 RID: 104889 RVA: 0x003BC254 File Offset: 0x003BA454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveGamePb Clone()
		{
			return new SolarSchoolSaveGamePb(this);
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x060199BA RID: 104890 RVA: 0x003BC25C File Offset: 0x003BA45C
		// (set) Token: 0x060199BB RID: 104891 RVA: 0x003BC264 File Offset: 0x003BA464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolPlayerDataPb Player
		{
			get
			{
				return this.player_;
			}
			set
			{
				this.player_ = value;
			}
		}

		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x060199BC RID: 104892 RVA: 0x003BC26D File Offset: 0x003BA46D
		// (set) Token: 0x060199BD RID: 104893 RVA: 0x003BC275 File Offset: 0x003BA475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTimeDataPb Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x060199BE RID: 104894 RVA: 0x003BC27E File Offset: 0x003BA47E
		// (set) Token: 0x060199BF RID: 104895 RVA: 0x003BC286 File Offset: 0x003BA486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolCharacterDataPb Character
		{
			get
			{
				return this.character_;
			}
			set
			{
				this.character_ = value;
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x060199C0 RID: 104896 RVA: 0x003BC28F File Offset: 0x003BA48F
		// (set) Token: 0x060199C1 RID: 104897 RVA: 0x003BC297 File Offset: 0x003BA497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolQuestDataPb Quest
		{
			get
			{
				return this.quest_;
			}
			set
			{
				this.quest_ = value;
			}
		}

		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x060199C2 RID: 104898 RVA: 0x003BC2A0 File Offset: 0x003BA4A0
		// (set) Token: 0x060199C3 RID: 104899 RVA: 0x003BC2A8 File Offset: 0x003BA4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInventoryDataPb Inventory
		{
			get
			{
				return this.inventory_;
			}
			set
			{
				this.inventory_ = value;
			}
		}

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x060199C4 RID: 104900 RVA: 0x003BC2B1 File Offset: 0x003BA4B1
		// (set) Token: 0x060199C5 RID: 104901 RVA: 0x003BC2B9 File Offset: 0x003BA4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolScheduleDataPb Schedule
		{
			get
			{
				return this.schedule_;
			}
			set
			{
				this.schedule_ = value;
			}
		}

		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x060199C6 RID: 104902 RVA: 0x003BC2C2 File Offset: 0x003BA4C2
		// (set) Token: 0x060199C7 RID: 104903 RVA: 0x003BC2CA File Offset: 0x003BA4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamDataPb Exam
		{
			get
			{
				return this.exam_;
			}
			set
			{
				this.exam_ = value;
			}
		}

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x060199C8 RID: 104904 RVA: 0x003BC2D3 File Offset: 0x003BA4D3
		// (set) Token: 0x060199C9 RID: 104905 RVA: 0x003BC2DB File Offset: 0x003BA4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopDataPb Shop
		{
			get
			{
				return this.shop_;
			}
			set
			{
				this.shop_ = value;
			}
		}

		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x060199CA RID: 104906 RVA: 0x003BC2E4 File Offset: 0x003BA4E4
		// (set) Token: 0x060199CB RID: 104907 RVA: 0x003BC2EC File Offset: 0x003BA4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAvgDataPb Avg
		{
			get
			{
				return this.avg_;
			}
			set
			{
				this.avg_ = value;
			}
		}

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x060199CC RID: 104908 RVA: 0x003BC2F5 File Offset: 0x003BA4F5
		// (set) Token: 0x060199CD RID: 104909 RVA: 0x003BC2FD File Offset: 0x003BA4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryRecordDataPb Summary
		{
			get
			{
				return this.summary_;
			}
			set
			{
				this.summary_ = value;
			}
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x060199CE RID: 104910 RVA: 0x003BC306 File Offset: 0x003BA506
		// (set) Token: 0x060199CF RID: 104911 RVA: 0x003BC30E File Offset: 0x003BA50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLocationDataPb Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x060199D0 RID: 104912 RVA: 0x003BC317 File Offset: 0x003BA517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSaveGamePb);
		}

		// Token: 0x060199D1 RID: 104913 RVA: 0x003BC328 File Offset: 0x003BA528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSaveGamePb other)
		{
			return other != null && (other == this || (object.Equals(this.Player, other.Player) && object.Equals(this.Time, other.Time) && object.Equals(this.Character, other.Character) && object.Equals(this.Quest, other.Quest) && object.Equals(this.Inventory, other.Inventory) && object.Equals(this.Schedule, other.Schedule) && object.Equals(this.Exam, other.Exam) && object.Equals(this.Shop, other.Shop) && object.Equals(this.Avg, other.Avg) && object.Equals(this.Summary, other.Summary) && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199D2 RID: 104914 RVA: 0x003BC438 File Offset: 0x003BA638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.player_ != null)
			{
				num ^= this.Player.GetHashCode();
			}
			if (this.time_ != null)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this.character_ != null)
			{
				num ^= this.Character.GetHashCode();
			}
			if (this.quest_ != null)
			{
				num ^= this.Quest.GetHashCode();
			}
			if (this.inventory_ != null)
			{
				num ^= this.Inventory.GetHashCode();
			}
			if (this.schedule_ != null)
			{
				num ^= this.Schedule.GetHashCode();
			}
			if (this.exam_ != null)
			{
				num ^= this.Exam.GetHashCode();
			}
			if (this.shop_ != null)
			{
				num ^= this.Shop.GetHashCode();
			}
			if (this.avg_ != null)
			{
				num ^= this.Avg.GetHashCode();
			}
			if (this.summary_ != null)
			{
				num ^= this.Summary.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060199D3 RID: 104915 RVA: 0x003BC550 File Offset: 0x003BA750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199D4 RID: 104916 RVA: 0x003BC55D File Offset: 0x003BA75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199D5 RID: 104917 RVA: 0x003BC568 File Offset: 0x003BA768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.player_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Player);
			}
			if (this.time_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Time);
			}
			if (this.character_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Character);
			}
			if (this.quest_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Quest);
			}
			if (this.inventory_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Inventory);
			}
			if (this.schedule_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Schedule);
			}
			if (this.exam_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Exam);
			}
			if (this.shop_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Shop);
			}
			if (this.avg_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Avg);
			}
			if (this.summary_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Summary);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199D6 RID: 104918 RVA: 0x003BC6C0 File Offset: 0x003BA8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.player_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Player);
			}
			if (this.time_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Time);
			}
			if (this.character_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Character);
			}
			if (this.quest_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Quest);
			}
			if (this.inventory_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Inventory);
			}
			if (this.schedule_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Schedule);
			}
			if (this.exam_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Exam);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			if (this.avg_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Avg);
			}
			if (this.summary_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Summary);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060199D7 RID: 104919 RVA: 0x003BC7F0 File Offset: 0x003BA9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSaveGamePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.player_ != null)
			{
				if (this.player_ == null)
				{
					this.Player = new SolarSchoolPlayerDataPb();
				}
				this.Player.MergeFrom(other.Player);
			}
			if (other.time_ != null)
			{
				if (this.time_ == null)
				{
					this.Time = new SolarSchoolTimeDataPb();
				}
				this.Time.MergeFrom(other.Time);
			}
			if (other.character_ != null)
			{
				if (this.character_ == null)
				{
					this.Character = new SolarSchoolCharacterDataPb();
				}
				this.Character.MergeFrom(other.Character);
			}
			if (other.quest_ != null)
			{
				if (this.quest_ == null)
				{
					this.Quest = new SolarSchoolQuestDataPb();
				}
				this.Quest.MergeFrom(other.Quest);
			}
			if (other.inventory_ != null)
			{
				if (this.inventory_ == null)
				{
					this.Inventory = new SolarSchoolInventoryDataPb();
				}
				this.Inventory.MergeFrom(other.Inventory);
			}
			if (other.schedule_ != null)
			{
				if (this.schedule_ == null)
				{
					this.Schedule = new SolarSchoolScheduleDataPb();
				}
				this.Schedule.MergeFrom(other.Schedule);
			}
			if (other.exam_ != null)
			{
				if (this.exam_ == null)
				{
					this.Exam = new SolarSchoolExamDataPb();
				}
				this.Exam.MergeFrom(other.Exam);
			}
			if (other.shop_ != null)
			{
				if (this.shop_ == null)
				{
					this.Shop = new SolarSchoolShopDataPb();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			if (other.avg_ != null)
			{
				if (this.avg_ == null)
				{
					this.Avg = new SolarSchoolAvgDataPb();
				}
				this.Avg.MergeFrom(other.Avg);
			}
			if (other.summary_ != null)
			{
				if (this.summary_ == null)
				{
					this.Summary = new SolarSchoolSummaryRecordDataPb();
				}
				this.Summary.MergeFrom(other.Summary);
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new SolarSchoolLocationDataPb();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060199D8 RID: 104920 RVA: 0x003BC9FC File Offset: 0x003BABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199D9 RID: 104921 RVA: 0x003BCA08 File Offset: 0x003BAC08
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
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.player_ == null)
							{
								this.Player = new SolarSchoolPlayerDataPb();
							}
							input.ReadMessage(this.Player);
							continue;
						}
						if (num == 18U)
						{
							if (this.time_ == null)
							{
								this.Time = new SolarSchoolTimeDataPb();
							}
							input.ReadMessage(this.Time);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.character_ == null)
							{
								this.Character = new SolarSchoolCharacterDataPb();
							}
							input.ReadMessage(this.Character);
							continue;
						}
						if (num == 34U)
						{
							if (this.quest_ == null)
							{
								this.Quest = new SolarSchoolQuestDataPb();
							}
							input.ReadMessage(this.Quest);
							continue;
						}
						if (num == 42U)
						{
							if (this.inventory_ == null)
							{
								this.Inventory = new SolarSchoolInventoryDataPb();
							}
							input.ReadMessage(this.Inventory);
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 50U)
					{
						if (this.schedule_ == null)
						{
							this.Schedule = new SolarSchoolScheduleDataPb();
						}
						input.ReadMessage(this.Schedule);
						continue;
					}
					if (num == 58U)
					{
						if (this.exam_ == null)
						{
							this.Exam = new SolarSchoolExamDataPb();
						}
						input.ReadMessage(this.Exam);
						continue;
					}
					if (num == 66U)
					{
						if (this.shop_ == null)
						{
							this.Shop = new SolarSchoolShopDataPb();
						}
						input.ReadMessage(this.Shop);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.avg_ == null)
						{
							this.Avg = new SolarSchoolAvgDataPb();
						}
						input.ReadMessage(this.Avg);
						continue;
					}
					if (num == 82U)
					{
						if (this.summary_ == null)
						{
							this.Summary = new SolarSchoolSummaryRecordDataPb();
						}
						input.ReadMessage(this.Summary);
						continue;
					}
					if (num == 90U)
					{
						if (this.location_ == null)
						{
							this.Location = new SolarSchoolLocationDataPb();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009742 RID: 38722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009743 RID: 38723
		public const int PlayerFieldNumber = 1;

		// Token: 0x04009744 RID: 38724
		private SolarSchoolPlayerDataPb player_;

		// Token: 0x04009745 RID: 38725
		public const int TimeFieldNumber = 2;

		// Token: 0x04009746 RID: 38726
		private SolarSchoolTimeDataPb time_;

		// Token: 0x04009747 RID: 38727
		public const int CharacterFieldNumber = 3;

		// Token: 0x04009748 RID: 38728
		private SolarSchoolCharacterDataPb character_;

		// Token: 0x04009749 RID: 38729
		public const int QuestFieldNumber = 4;

		// Token: 0x0400974A RID: 38730
		private SolarSchoolQuestDataPb quest_;

		// Token: 0x0400974B RID: 38731
		public const int InventoryFieldNumber = 5;

		// Token: 0x0400974C RID: 38732
		private SolarSchoolInventoryDataPb inventory_;

		// Token: 0x0400974D RID: 38733
		public const int ScheduleFieldNumber = 6;

		// Token: 0x0400974E RID: 38734
		private SolarSchoolScheduleDataPb schedule_;

		// Token: 0x0400974F RID: 38735
		public const int ExamFieldNumber = 7;

		// Token: 0x04009750 RID: 38736
		private SolarSchoolExamDataPb exam_;

		// Token: 0x04009751 RID: 38737
		public const int ShopFieldNumber = 8;

		// Token: 0x04009752 RID: 38738
		private SolarSchoolShopDataPb shop_;

		// Token: 0x04009753 RID: 38739
		public const int AvgFieldNumber = 9;

		// Token: 0x04009754 RID: 38740
		private SolarSchoolAvgDataPb avg_;

		// Token: 0x04009755 RID: 38741
		public const int SummaryFieldNumber = 10;

		// Token: 0x04009756 RID: 38742
		private SolarSchoolSummaryRecordDataPb summary_;

		// Token: 0x04009757 RID: 38743
		public const int LocationFieldNumber = 11;

		// Token: 0x04009758 RID: 38744
		private SolarSchoolLocationDataPb location_;
	}
}

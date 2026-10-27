using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000707 RID: 1799
	public sealed class GoogleGameStatsShow : IMessage<GoogleGameStatsShow>, IMessage, IEquatable<GoogleGameStatsShow>, IDeepCloneable<GoogleGameStatsShow>, IBufferMessage
	{
		// Token: 0x0600A3C0 RID: 41920 RVA: 0x0018B97A File Offset: 0x00189B7A
		[NullableContext(1)]
		public static GoogleGameStatsShow Create()
		{
			return new GoogleGameStatsShow();
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x0018B981 File Offset: 0x00189B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x0018B984 File Offset: 0x00189B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GoogleGameStatsShow.Descriptor;
			}
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x0018B98B File Offset: 0x00189B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow()
		{
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x0018B994 File Offset: 0x00189B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow(GoogleGameStatsShow other) : this()
		{
			this.teleportNumber_ = other.teleportNumber_;
			this.boxOpenNumber_ = other.boxOpenNumber_;
			this.activeRoleNumber_ = other.activeRoleNumber_;
			this.activeDays_ = other.activeDays_;
			this.fetterUnLockMonsters_ = other.fetterUnLockMonsters_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x0018B9F4 File Offset: 0x00189BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow Clone()
		{
			return new GoogleGameStatsShow(this);
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600A3C6 RID: 41926 RVA: 0x0018B9FC File Offset: 0x00189BFC
		// (set) Token: 0x0600A3C7 RID: 41927 RVA: 0x0018BA04 File Offset: 0x00189C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeleportNumber
		{
			get
			{
				return this.teleportNumber_;
			}
			set
			{
				this.teleportNumber_ = value;
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600A3C8 RID: 41928 RVA: 0x0018BA0D File Offset: 0x00189C0D
		// (set) Token: 0x0600A3C9 RID: 41929 RVA: 0x0018BA15 File Offset: 0x00189C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxOpenNumber
		{
			get
			{
				return this.boxOpenNumber_;
			}
			set
			{
				this.boxOpenNumber_ = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x0018BA1E File Offset: 0x00189C1E
		// (set) Token: 0x0600A3CB RID: 41931 RVA: 0x0018BA26 File Offset: 0x00189C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveRoleNumber
		{
			get
			{
				return this.activeRoleNumber_;
			}
			set
			{
				this.activeRoleNumber_ = value;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600A3CC RID: 41932 RVA: 0x0018BA2F File Offset: 0x00189C2F
		// (set) Token: 0x0600A3CD RID: 41933 RVA: 0x0018BA37 File Offset: 0x00189C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveDays
		{
			get
			{
				return this.activeDays_;
			}
			set
			{
				this.activeDays_ = value;
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600A3CE RID: 41934 RVA: 0x0018BA40 File Offset: 0x00189C40
		// (set) Token: 0x0600A3CF RID: 41935 RVA: 0x0018BA48 File Offset: 0x00189C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FetterUnLockMonsters
		{
			get
			{
				return this.fetterUnLockMonsters_;
			}
			set
			{
				this.fetterUnLockMonsters_ = value;
			}
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x0018BA51 File Offset: 0x00189C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GoogleGameStatsShow);
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x0018BA60 File Offset: 0x00189C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GoogleGameStatsShow other)
		{
			return other != null && (other == this || (this.TeleportNumber == other.TeleportNumber && this.BoxOpenNumber == other.BoxOpenNumber && this.ActiveRoleNumber == other.ActiveRoleNumber && this.ActiveDays == other.ActiveDays && this.FetterUnLockMonsters == other.FetterUnLockMonsters && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x0018BADC File Offset: 0x00189CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeleportNumber != 0)
			{
				num ^= this.TeleportNumber.GetHashCode();
			}
			if (this.BoxOpenNumber != 0)
			{
				num ^= this.BoxOpenNumber.GetHashCode();
			}
			if (this.ActiveRoleNumber != 0)
			{
				num ^= this.ActiveRoleNumber.GetHashCode();
			}
			if (this.ActiveDays != 0)
			{
				num ^= this.ActiveDays.GetHashCode();
			}
			if (this.FetterUnLockMonsters != 0)
			{
				num ^= this.FetterUnLockMonsters.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x0018BB7F File Offset: 0x00189D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x0018BB8C File Offset: 0x00189D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x0018BB98 File Offset: 0x00189D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeleportNumber != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TeleportNumber);
			}
			if (this.BoxOpenNumber != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoxOpenNumber);
			}
			if (this.ActiveRoleNumber != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActiveRoleNumber);
			}
			if (this.ActiveDays != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActiveDays);
			}
			if (this.FetterUnLockMonsters != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FetterUnLockMonsters);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x0018BC44 File Offset: 0x00189E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeleportNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeleportNumber);
			}
			if (this.BoxOpenNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxOpenNumber);
			}
			if (this.ActiveRoleNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveRoleNumber);
			}
			if (this.ActiveDays != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveDays);
			}
			if (this.FetterUnLockMonsters != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FetterUnLockMonsters);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x0018BCE4 File Offset: 0x00189EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GoogleGameStatsShow other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeleportNumber != 0)
			{
				this.TeleportNumber = other.TeleportNumber;
			}
			if (other.BoxOpenNumber != 0)
			{
				this.BoxOpenNumber = other.BoxOpenNumber;
			}
			if (other.ActiveRoleNumber != 0)
			{
				this.ActiveRoleNumber = other.ActiveRoleNumber;
			}
			if (other.ActiveDays != 0)
			{
				this.ActiveDays = other.ActiveDays;
			}
			if (other.FetterUnLockMonsters != 0)
			{
				this.FetterUnLockMonsters = other.FetterUnLockMonsters;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x0018BD70 File Offset: 0x00189F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x0018BD7C File Offset: 0x00189F7C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TeleportNumber = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BoxOpenNumber = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ActiveRoleNumber = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ActiveDays = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FetterUnLockMonsters = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BA5 RID: 19365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BA6 RID: 19366
		public const int TeleportNumberFieldNumber = 1;

		// Token: 0x04004BA7 RID: 19367
		private int teleportNumber_;

		// Token: 0x04004BA8 RID: 19368
		public const int BoxOpenNumberFieldNumber = 2;

		// Token: 0x04004BA9 RID: 19369
		private int boxOpenNumber_;

		// Token: 0x04004BAA RID: 19370
		public const int ActiveRoleNumberFieldNumber = 3;

		// Token: 0x04004BAB RID: 19371
		private int activeRoleNumber_;

		// Token: 0x04004BAC RID: 19372
		public const int ActiveDaysFieldNumber = 4;

		// Token: 0x04004BAD RID: 19373
		private int activeDays_;

		// Token: 0x04004BAE RID: 19374
		public const int FetterUnLockMonstersFieldNumber = 5;

		// Token: 0x04004BAF RID: 19375
		private int fetterUnLockMonsters_;
	}
}

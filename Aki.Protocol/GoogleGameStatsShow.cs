using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F3 RID: 1779
	public sealed class GoogleGameStatsShow : IMessage<GoogleGameStatsShow>, IMessage, IEquatable<GoogleGameStatsShow>, IDeepCloneable<GoogleGameStatsShow>, IBufferMessage
	{
		// Token: 0x0600A26A RID: 41578 RVA: 0x00188F46 File Offset: 0x00187146
		[NullableContext(1)]
		public static GoogleGameStatsShow Create()
		{
			return new GoogleGameStatsShow();
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x00188F4D File Offset: 0x0018714D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x00188F50 File Offset: 0x00187150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GoogleGameStatsShow.Descriptor;
			}
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x00188F57 File Offset: 0x00187157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow()
		{
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x00188F60 File Offset: 0x00187160
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

		// Token: 0x0600A26F RID: 41583 RVA: 0x00188FC0 File Offset: 0x001871C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow Clone()
		{
			return new GoogleGameStatsShow(this);
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600A270 RID: 41584 RVA: 0x00188FC8 File Offset: 0x001871C8
		// (set) Token: 0x0600A271 RID: 41585 RVA: 0x00188FD0 File Offset: 0x001871D0
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

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600A272 RID: 41586 RVA: 0x00188FD9 File Offset: 0x001871D9
		// (set) Token: 0x0600A273 RID: 41587 RVA: 0x00188FE1 File Offset: 0x001871E1
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

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600A274 RID: 41588 RVA: 0x00188FEA File Offset: 0x001871EA
		// (set) Token: 0x0600A275 RID: 41589 RVA: 0x00188FF2 File Offset: 0x001871F2
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

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600A276 RID: 41590 RVA: 0x00188FFB File Offset: 0x001871FB
		// (set) Token: 0x0600A277 RID: 41591 RVA: 0x00189003 File Offset: 0x00187203
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

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600A278 RID: 41592 RVA: 0x0018900C File Offset: 0x0018720C
		// (set) Token: 0x0600A279 RID: 41593 RVA: 0x00189014 File Offset: 0x00187214
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

		// Token: 0x0600A27A RID: 41594 RVA: 0x0018901D File Offset: 0x0018721D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GoogleGameStatsShow);
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x0018902C File Offset: 0x0018722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GoogleGameStatsShow other)
		{
			return other != null && (other == this || (this.TeleportNumber == other.TeleportNumber && this.BoxOpenNumber == other.BoxOpenNumber && this.ActiveRoleNumber == other.ActiveRoleNumber && this.ActiveDays == other.ActiveDays && this.FetterUnLockMonsters == other.FetterUnLockMonsters && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x001890A8 File Offset: 0x001872A8
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

		// Token: 0x0600A27D RID: 41597 RVA: 0x0018914B File Offset: 0x0018734B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x00189158 File Offset: 0x00187358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x00189164 File Offset: 0x00187364
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

		// Token: 0x0600A280 RID: 41600 RVA: 0x00189210 File Offset: 0x00187410
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

		// Token: 0x0600A281 RID: 41601 RVA: 0x001892B0 File Offset: 0x001874B0
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

		// Token: 0x0600A282 RID: 41602 RVA: 0x0018933C File Offset: 0x0018753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x00189348 File Offset: 0x00187548
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

		// Token: 0x04004B9E RID: 19358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B9F RID: 19359
		public const int TeleportNumberFieldNumber = 1;

		// Token: 0x04004BA0 RID: 19360
		private int teleportNumber_;

		// Token: 0x04004BA1 RID: 19361
		public const int BoxOpenNumberFieldNumber = 2;

		// Token: 0x04004BA2 RID: 19362
		private int boxOpenNumber_;

		// Token: 0x04004BA3 RID: 19363
		public const int ActiveRoleNumberFieldNumber = 3;

		// Token: 0x04004BA4 RID: 19364
		private int activeRoleNumber_;

		// Token: 0x04004BA5 RID: 19365
		public const int ActiveDaysFieldNumber = 4;

		// Token: 0x04004BA6 RID: 19366
		private int activeDays_;

		// Token: 0x04004BA7 RID: 19367
		public const int FetterUnLockMonstersFieldNumber = 5;

		// Token: 0x04004BA8 RID: 19368
		private int fetterUnLockMonsters_;
	}
}

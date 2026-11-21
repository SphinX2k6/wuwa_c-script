using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FD RID: 2557
	[NetMessage(EMessageId.MonthCardUseNotify)]
	public sealed class MonthCardUseNotify : IMessage<MonthCardUseNotify>, IMessage, IEquatable<MonthCardUseNotify>, IDeepCloneable<MonthCardUseNotify>, IBufferMessage
	{
		// Token: 0x0600E012 RID: 57362 RVA: 0x0020D957 File Offset: 0x0020BB57
		[NullableContext(1)]
		public static MonthCardUseNotify Create()
		{
			return new MonthCardUseNotify();
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600E013 RID: 57363 RVA: 0x0020D95E File Offset: 0x0020BB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x0020D961 File Offset: 0x0020BB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardUseNotify.Descriptor;
			}
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x0020D968 File Offset: 0x0020BB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardUseNotify()
		{
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x0020D970 File Offset: 0x0020BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardUseNotify(MonthCardUseNotify other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.days_ = other.days_;
			this.dailyRewardItemId_ = other.dailyRewardItemId_;
			this.dailyRewardItemCount_ = other.dailyRewardItemCount_;
			this.extendedDays_ = other.extendedDays_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x0020D9DC File Offset: 0x0020BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardUseNotify Clone()
		{
			return new MonthCardUseNotify(this);
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x0020D9E4 File Offset: 0x0020BBE4
		// (set) Token: 0x0600E019 RID: 57369 RVA: 0x0020D9EC File Offset: 0x0020BBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x0020D9F5 File Offset: 0x0020BBF5
		// (set) Token: 0x0600E01B RID: 57371 RVA: 0x0020D9FD File Offset: 0x0020BBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600E01C RID: 57372 RVA: 0x0020DA06 File Offset: 0x0020BC06
		// (set) Token: 0x0600E01D RID: 57373 RVA: 0x0020DA0E File Offset: 0x0020BC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Days
		{
			get
			{
				return this.days_;
			}
			set
			{
				this.days_ = value;
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x0020DA17 File Offset: 0x0020BC17
		// (set) Token: 0x0600E01F RID: 57375 RVA: 0x0020DA1F File Offset: 0x0020BC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyRewardItemId
		{
			get
			{
				return this.dailyRewardItemId_;
			}
			set
			{
				this.dailyRewardItemId_ = value;
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600E020 RID: 57376 RVA: 0x0020DA28 File Offset: 0x0020BC28
		// (set) Token: 0x0600E021 RID: 57377 RVA: 0x0020DA30 File Offset: 0x0020BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyRewardItemCount
		{
			get
			{
				return this.dailyRewardItemCount_;
			}
			set
			{
				this.dailyRewardItemCount_ = value;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600E022 RID: 57378 RVA: 0x0020DA39 File Offset: 0x0020BC39
		// (set) Token: 0x0600E023 RID: 57379 RVA: 0x0020DA41 File Offset: 0x0020BC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtendedDays
		{
			get
			{
				return this.extendedDays_;
			}
			set
			{
				this.extendedDays_ = value;
			}
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x0020DA4A File Offset: 0x0020BC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardUseNotify);
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x0020DA58 File Offset: 0x0020BC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardUseNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.Days == other.Days && this.DailyRewardItemId == other.DailyRewardItemId && this.DailyRewardItemCount == other.DailyRewardItemCount && this.ExtendedDays == other.ExtendedDays && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x0020DAE4 File Offset: 0x0020BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.Days != 0)
			{
				num ^= this.Days.GetHashCode();
			}
			if (this.DailyRewardItemId != 0)
			{
				num ^= this.DailyRewardItemId.GetHashCode();
			}
			if (this.DailyRewardItemCount != 0)
			{
				num ^= this.DailyRewardItemCount.GetHashCode();
			}
			if (this.ExtendedDays != 0)
			{
				num ^= this.ExtendedDays.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x0020DBA0 File Offset: 0x0020BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E028 RID: 57384 RVA: 0x0020DBAD File Offset: 0x0020BDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E029 RID: 57385 RVA: 0x0020DBB8 File Offset: 0x0020BDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtendedDays != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExtendedDays);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Days);
			}
			if (this.DailyRewardItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DailyRewardItemId);
			}
			if (this.DailyRewardItemCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DailyRewardItemCount);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E02A RID: 57386 RVA: 0x0020DC80 File Offset: 0x0020BE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.Days != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Days);
			}
			if (this.DailyRewardItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyRewardItemId);
			}
			if (this.DailyRewardItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyRewardItemCount);
			}
			if (this.ExtendedDays != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtendedDays);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E02B RID: 57387 RVA: 0x0020DD38 File Offset: 0x0020BF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardUseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.Days != 0)
			{
				this.Days = other.Days;
			}
			if (other.DailyRewardItemId != 0)
			{
				this.DailyRewardItemId = other.DailyRewardItemId;
			}
			if (other.DailyRewardItemCount != 0)
			{
				this.DailyRewardItemCount = other.DailyRewardItemCount;
			}
			if (other.ExtendedDays != 0)
			{
				this.ExtendedDays = other.ExtendedDays;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E02C RID: 57388 RVA: 0x0020DDD8 File Offset: 0x0020BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E02D RID: 57389 RVA: 0x0020DDE4 File Offset: 0x0020BFE4
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.ExtendedDays = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Days = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.DailyRewardItemId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.DailyRewardItemCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005C9B RID: 23707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C9C RID: 23708
		public const int ItemIdFieldNumber = 4;

		// Token: 0x04005C9D RID: 23709
		private int itemId_;

		// Token: 0x04005C9E RID: 23710
		public const int CountFieldNumber = 14;

		// Token: 0x04005C9F RID: 23711
		private int count_;

		// Token: 0x04005CA0 RID: 23712
		public const int DaysFieldNumber = 7;

		// Token: 0x04005CA1 RID: 23713
		private int days_;

		// Token: 0x04005CA2 RID: 23714
		public const int DailyRewardItemIdFieldNumber = 8;

		// Token: 0x04005CA3 RID: 23715
		private int dailyRewardItemId_;

		// Token: 0x04005CA4 RID: 23716
		public const int DailyRewardItemCountFieldNumber = 9;

		// Token: 0x04005CA5 RID: 23717
		private int dailyRewardItemCount_;

		// Token: 0x04005CA6 RID: 23718
		public const int ExtendedDaysFieldNumber = 1;

		// Token: 0x04005CA7 RID: 23719
		private int extendedDays_;
	}
}

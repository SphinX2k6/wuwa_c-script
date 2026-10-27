using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084C RID: 2124
	public sealed class ItemExchangeInfo : IMessage<ItemExchangeInfo>, IMessage, IEquatable<ItemExchangeInfo>, IDeepCloneable<ItemExchangeInfo>, IBufferMessage
	{
		// Token: 0x0600BD7D RID: 48509 RVA: 0x001C280F File Offset: 0x001C0A0F
		[NullableContext(1)]
		public static ItemExchangeInfo Create()
		{
			return new ItemExchangeInfo();
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x001C2816 File Offset: 0x001C0A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemExchangeInfo> Parser
		{
			get
			{
				return ItemExchangeInfo._parser;
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600BD7F RID: 48511 RVA: 0x001C281D File Offset: 0x001C0A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x001C2820 File Offset: 0x001C0A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfo.Descriptor;
			}
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x001C2827 File Offset: 0x001C0A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfo()
		{
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x001C2830 File Offset: 0x001C0A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfo(ItemExchangeInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.todayTimes_ = other.todayTimes_;
			this.totalTimes_ = other.totalTimes_;
			this.dailyLimit_ = other.dailyLimit_;
			this.totalLimit_ = other.totalLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x001C2890 File Offset: 0x001C0A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfo Clone()
		{
			return new ItemExchangeInfo(this);
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600BD84 RID: 48516 RVA: 0x001C2898 File Offset: 0x001C0A98
		// (set) Token: 0x0600BD85 RID: 48517 RVA: 0x001C28A0 File Offset: 0x001C0AA0
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

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x001C28A9 File Offset: 0x001C0AA9
		// (set) Token: 0x0600BD87 RID: 48519 RVA: 0x001C28B1 File Offset: 0x001C0AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TodayTimes
		{
			get
			{
				return this.todayTimes_;
			}
			set
			{
				this.todayTimes_ = value;
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x001C28BA File Offset: 0x001C0ABA
		// (set) Token: 0x0600BD89 RID: 48521 RVA: 0x001C28C2 File Offset: 0x001C0AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTimes
		{
			get
			{
				return this.totalTimes_;
			}
			set
			{
				this.totalTimes_ = value;
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x001C28CB File Offset: 0x001C0ACB
		// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x001C28D3 File Offset: 0x001C0AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyLimit
		{
			get
			{
				return this.dailyLimit_;
			}
			set
			{
				this.dailyLimit_ = value;
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x001C28DC File Offset: 0x001C0ADC
		// (set) Token: 0x0600BD8D RID: 48525 RVA: 0x001C28E4 File Offset: 0x001C0AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalLimit
		{
			get
			{
				return this.totalLimit_;
			}
			set
			{
				this.totalLimit_ = value;
			}
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x001C28ED File Offset: 0x001C0AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfo);
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x001C28FC File Offset: 0x001C0AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.TodayTimes == other.TodayTimes && this.TotalTimes == other.TotalTimes && this.DailyLimit == other.DailyLimit && this.TotalLimit == other.TotalLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD90 RID: 48528 RVA: 0x001C2978 File Offset: 0x001C0B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.TodayTimes != 0)
			{
				num ^= this.TodayTimes.GetHashCode();
			}
			if (this.TotalTimes != 0)
			{
				num ^= this.TotalTimes.GetHashCode();
			}
			if (this.DailyLimit != 0)
			{
				num ^= this.DailyLimit.GetHashCode();
			}
			if (this.TotalLimit != 0)
			{
				num ^= this.TotalLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x001C2A1B File Offset: 0x001C0C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD92 RID: 48530 RVA: 0x001C2A28 File Offset: 0x001C0C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x001C2A34 File Offset: 0x001C0C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.TodayTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TodayTimes);
			}
			if (this.TotalTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalTimes);
			}
			if (this.DailyLimit != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DailyLimit);
			}
			if (this.TotalLimit != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TotalLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x001C2AE0 File Offset: 0x001C0CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.TodayTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TodayTimes);
			}
			if (this.TotalTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTimes);
			}
			if (this.DailyLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyLimit);
			}
			if (this.TotalLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x001C2B80 File Offset: 0x001C0D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.TodayTimes != 0)
			{
				this.TodayTimes = other.TodayTimes;
			}
			if (other.TotalTimes != 0)
			{
				this.TotalTimes = other.TotalTimes;
			}
			if (other.DailyLimit != 0)
			{
				this.DailyLimit = other.DailyLimit;
			}
			if (other.TotalLimit != 0)
			{
				this.TotalLimit = other.TotalLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD96 RID: 48534 RVA: 0x001C2C0C File Offset: 0x001C0E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x001C2C18 File Offset: 0x001C0E18
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
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TodayTimes = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TotalTimes = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.DailyLimit = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TotalLimit = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040052C9 RID: 21193
		private static readonly MessageParser<ItemExchangeInfo> _parser = new MessageParser<ItemExchangeInfo>(() => new ItemExchangeInfo());

		// Token: 0x040052CA RID: 21194
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052CB RID: 21195
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052CC RID: 21196
		private int itemId_;

		// Token: 0x040052CD RID: 21197
		public const int TodayTimesFieldNumber = 2;

		// Token: 0x040052CE RID: 21198
		private int todayTimes_;

		// Token: 0x040052CF RID: 21199
		public const int TotalTimesFieldNumber = 3;

		// Token: 0x040052D0 RID: 21200
		private int totalTimes_;

		// Token: 0x040052D1 RID: 21201
		public const int DailyLimitFieldNumber = 4;

		// Token: 0x040052D2 RID: 21202
		private int dailyLimit_;

		// Token: 0x040052D3 RID: 21203
		public const int TotalLimitFieldNumber = 5;

		// Token: 0x040052D4 RID: 21204
		private int totalLimit_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083A RID: 2106
	public sealed class ItemExchangeInfo : IMessage<ItemExchangeInfo>, IMessage, IEquatable<ItemExchangeInfo>, IDeepCloneable<ItemExchangeInfo>, IBufferMessage
	{
		// Token: 0x0600BC4F RID: 48207 RVA: 0x001C033B File Offset: 0x001BE53B
		[NullableContext(1)]
		public static ItemExchangeInfo Create()
		{
			return new ItemExchangeInfo();
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x001C0342 File Offset: 0x001BE542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemExchangeInfo> Parser
		{
			get
			{
				return ItemExchangeInfo._parser;
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x0600BC51 RID: 48209 RVA: 0x001C0349 File Offset: 0x001BE549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x001C034C File Offset: 0x001BE54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfo.Descriptor;
			}
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x001C0353 File Offset: 0x001BE553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfo()
		{
		}

		// Token: 0x0600BC54 RID: 48212 RVA: 0x001C035C File Offset: 0x001BE55C
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

		// Token: 0x0600BC55 RID: 48213 RVA: 0x001C03BC File Offset: 0x001BE5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfo Clone()
		{
			return new ItemExchangeInfo(this);
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x001C03C4 File Offset: 0x001BE5C4
		// (set) Token: 0x0600BC57 RID: 48215 RVA: 0x001C03CC File Offset: 0x001BE5CC
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

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x001C03D5 File Offset: 0x001BE5D5
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x001C03DD File Offset: 0x001BE5DD
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

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x001C03E6 File Offset: 0x001BE5E6
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x001C03EE File Offset: 0x001BE5EE
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

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600BC5C RID: 48220 RVA: 0x001C03F7 File Offset: 0x001BE5F7
		// (set) Token: 0x0600BC5D RID: 48221 RVA: 0x001C03FF File Offset: 0x001BE5FF
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

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x001C0408 File Offset: 0x001BE608
		// (set) Token: 0x0600BC5F RID: 48223 RVA: 0x001C0410 File Offset: 0x001BE610
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

		// Token: 0x0600BC60 RID: 48224 RVA: 0x001C0419 File Offset: 0x001BE619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfo);
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x001C0428 File Offset: 0x001BE628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.TodayTimes == other.TodayTimes && this.TotalTimes == other.TotalTimes && this.DailyLimit == other.DailyLimit && this.TotalLimit == other.TotalLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x001C04A4 File Offset: 0x001BE6A4
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

		// Token: 0x0600BC63 RID: 48227 RVA: 0x001C0547 File Offset: 0x001BE747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x001C0554 File Offset: 0x001BE754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x001C0560 File Offset: 0x001BE760
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

		// Token: 0x0600BC66 RID: 48230 RVA: 0x001C060C File Offset: 0x001BE80C
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

		// Token: 0x0600BC67 RID: 48231 RVA: 0x001C06AC File Offset: 0x001BE8AC
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

		// Token: 0x0600BC68 RID: 48232 RVA: 0x001C0738 File Offset: 0x001BE938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x001C0744 File Offset: 0x001BE944
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

		// Token: 0x040052CC RID: 21196
		private static readonly MessageParser<ItemExchangeInfo> _parser = new MessageParser<ItemExchangeInfo>(() => new ItemExchangeInfo());

		// Token: 0x040052CD RID: 21197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052CE RID: 21198
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052CF RID: 21199
		private int itemId_;

		// Token: 0x040052D0 RID: 21200
		public const int TodayTimesFieldNumber = 2;

		// Token: 0x040052D1 RID: 21201
		private int todayTimes_;

		// Token: 0x040052D2 RID: 21202
		public const int TotalTimesFieldNumber = 3;

		// Token: 0x040052D3 RID: 21203
		private int totalTimes_;

		// Token: 0x040052D4 RID: 21204
		public const int DailyLimitFieldNumber = 4;

		// Token: 0x040052D5 RID: 21205
		private int dailyLimit_;

		// Token: 0x040052D6 RID: 21206
		public const int TotalLimitFieldNumber = 5;

		// Token: 0x040052D7 RID: 21207
		private int totalLimit_;
	}
}

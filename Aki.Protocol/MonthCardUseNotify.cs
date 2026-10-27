using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0E RID: 2574
	[NetMessage(EMessageId.MonthCardUseNotify)]
	public sealed class MonthCardUseNotify : IMessage<MonthCardUseNotify>, IMessage, IEquatable<MonthCardUseNotify>, IDeepCloneable<MonthCardUseNotify>, IBufferMessage
	{
		// Token: 0x0600E12C RID: 57644 RVA: 0x0020FB43 File Offset: 0x0020DD43
		[NullableContext(1)]
		public static MonthCardUseNotify Create()
		{
			return new MonthCardUseNotify();
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600E12D RID: 57645 RVA: 0x0020FB4A File Offset: 0x0020DD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x0020FB4D File Offset: 0x0020DD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardUseNotify.Descriptor;
			}
		}

		// Token: 0x0600E12F RID: 57647 RVA: 0x0020FB54 File Offset: 0x0020DD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardUseNotify()
		{
		}

		// Token: 0x0600E130 RID: 57648 RVA: 0x0020FB5C File Offset: 0x0020DD5C
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

		// Token: 0x0600E131 RID: 57649 RVA: 0x0020FBC8 File Offset: 0x0020DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardUseNotify Clone()
		{
			return new MonthCardUseNotify(this);
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600E132 RID: 57650 RVA: 0x0020FBD0 File Offset: 0x0020DDD0
		// (set) Token: 0x0600E133 RID: 57651 RVA: 0x0020FBD8 File Offset: 0x0020DDD8
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

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600E134 RID: 57652 RVA: 0x0020FBE1 File Offset: 0x0020DDE1
		// (set) Token: 0x0600E135 RID: 57653 RVA: 0x0020FBE9 File Offset: 0x0020DDE9
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

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600E136 RID: 57654 RVA: 0x0020FBF2 File Offset: 0x0020DDF2
		// (set) Token: 0x0600E137 RID: 57655 RVA: 0x0020FBFA File Offset: 0x0020DDFA
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

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0600E138 RID: 57656 RVA: 0x0020FC03 File Offset: 0x0020DE03
		// (set) Token: 0x0600E139 RID: 57657 RVA: 0x0020FC0B File Offset: 0x0020DE0B
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

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0600E13A RID: 57658 RVA: 0x0020FC14 File Offset: 0x0020DE14
		// (set) Token: 0x0600E13B RID: 57659 RVA: 0x0020FC1C File Offset: 0x0020DE1C
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

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x0020FC25 File Offset: 0x0020DE25
		// (set) Token: 0x0600E13D RID: 57661 RVA: 0x0020FC2D File Offset: 0x0020DE2D
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

		// Token: 0x0600E13E RID: 57662 RVA: 0x0020FC36 File Offset: 0x0020DE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardUseNotify);
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x0020FC44 File Offset: 0x0020DE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardUseNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.Days == other.Days && this.DailyRewardItemId == other.DailyRewardItemId && this.DailyRewardItemCount == other.DailyRewardItemCount && this.ExtendedDays == other.ExtendedDays && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x0020FCD0 File Offset: 0x0020DED0
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

		// Token: 0x0600E141 RID: 57665 RVA: 0x0020FD8C File Offset: 0x0020DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E142 RID: 57666 RVA: 0x0020FD99 File Offset: 0x0020DF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E143 RID: 57667 RVA: 0x0020FDA4 File Offset: 0x0020DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DailyRewardItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DailyRewardItemId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ItemId);
			}
			if (this.DailyRewardItemCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DailyRewardItemCount);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Count);
			}
			if (this.ExtendedDays != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ExtendedDays);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Days);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x0020FE70 File Offset: 0x0020E070
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

		// Token: 0x0600E145 RID: 57669 RVA: 0x0020FF28 File Offset: 0x0020E128
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

		// Token: 0x0600E146 RID: 57670 RVA: 0x0020FFC8 File Offset: 0x0020E1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x0020FFD4 File Offset: 0x0020E1D4
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
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.DailyRewardItemId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.DailyRewardItemCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ExtendedDays = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Days = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005C92 RID: 23698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C93 RID: 23699
		public const int ItemIdFieldNumber = 6;

		// Token: 0x04005C94 RID: 23700
		private int itemId_;

		// Token: 0x04005C95 RID: 23701
		public const int CountFieldNumber = 12;

		// Token: 0x04005C96 RID: 23702
		private int count_;

		// Token: 0x04005C97 RID: 23703
		public const int DaysFieldNumber = 15;

		// Token: 0x04005C98 RID: 23704
		private int days_;

		// Token: 0x04005C99 RID: 23705
		public const int DailyRewardItemIdFieldNumber = 3;

		// Token: 0x04005C9A RID: 23706
		private int dailyRewardItemId_;

		// Token: 0x04005C9B RID: 23707
		public const int DailyRewardItemCountFieldNumber = 8;

		// Token: 0x04005C9C RID: 23708
		private int dailyRewardItemCount_;

		// Token: 0x04005C9D RID: 23709
		public const int ExtendedDaysFieldNumber = 14;

		// Token: 0x04005C9E RID: 23710
		private int extendedDays_;
	}
}

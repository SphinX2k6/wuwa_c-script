using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C9 RID: 4809
	public sealed class SolarSchoolSlotCellPb : IMessage<SolarSchoolSlotCellPb>, IMessage, IEquatable<SolarSchoolSlotCellPb>, IDeepCloneable<SolarSchoolSlotCellPb>, IBufferMessage
	{
		// Token: 0x06019AB4 RID: 105140 RVA: 0x003BEC26 File Offset: 0x003BCE26
		[NullableContext(1)]
		public static SolarSchoolSlotCellPb Create()
		{
			return new SolarSchoolSlotCellPb();
		}

		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x06019AB5 RID: 105141 RVA: 0x003BEC2D File Offset: 0x003BCE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolSlotCellPb> Parser
		{
			get
			{
				return SolarSchoolSlotCellPb._parser;
			}
		}

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x06019AB6 RID: 105142 RVA: 0x003BEC34 File Offset: 0x003BCE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x06019AB7 RID: 105143 RVA: 0x003BEC37 File Offset: 0x003BCE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSlotCellPb.Descriptor;
			}
		}

		// Token: 0x06019AB8 RID: 105144 RVA: 0x003BEC3E File Offset: 0x003BCE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSlotCellPb()
		{
		}

		// Token: 0x06019AB9 RID: 105145 RVA: 0x003BEC48 File Offset: 0x003BCE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSlotCellPb(SolarSchoolSlotCellPb other) : this()
		{
			this.weekday_ = other.weekday_;
			this.slot_ = other.slot_;
			this.behaviorId_ = other.behaviorId_;
			this.replacedLowBehaviorId_ = other.replacedLowBehaviorId_;
			this.firstWeekday_ = other.firstWeekday_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019ABA RID: 105146 RVA: 0x003BECA8 File Offset: 0x003BCEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSlotCellPb Clone()
		{
			return new SolarSchoolSlotCellPb(this);
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x06019ABB RID: 105147 RVA: 0x003BECB0 File Offset: 0x003BCEB0
		// (set) Token: 0x06019ABC RID: 105148 RVA: 0x003BECB8 File Offset: 0x003BCEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Weekday
		{
			get
			{
				return this.weekday_;
			}
			set
			{
				this.weekday_ = value;
			}
		}

		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x06019ABD RID: 105149 RVA: 0x003BECC1 File Offset: 0x003BCEC1
		// (set) Token: 0x06019ABE RID: 105150 RVA: 0x003BECC9 File Offset: 0x003BCEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x06019ABF RID: 105151 RVA: 0x003BECD2 File Offset: 0x003BCED2
		// (set) Token: 0x06019AC0 RID: 105152 RVA: 0x003BECDA File Offset: 0x003BCEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BehaviorId
		{
			get
			{
				return this.behaviorId_;
			}
			set
			{
				this.behaviorId_ = value;
			}
		}

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x06019AC1 RID: 105153 RVA: 0x003BECE3 File Offset: 0x003BCEE3
		// (set) Token: 0x06019AC2 RID: 105154 RVA: 0x003BECEB File Offset: 0x003BCEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReplacedLowBehaviorId
		{
			get
			{
				return this.replacedLowBehaviorId_;
			}
			set
			{
				this.replacedLowBehaviorId_ = value;
			}
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x06019AC3 RID: 105155 RVA: 0x003BECF4 File Offset: 0x003BCEF4
		// (set) Token: 0x06019AC4 RID: 105156 RVA: 0x003BECFC File Offset: 0x003BCEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstWeekday
		{
			get
			{
				return this.firstWeekday_;
			}
			set
			{
				this.firstWeekday_ = value;
			}
		}

		// Token: 0x06019AC5 RID: 105157 RVA: 0x003BED05 File Offset: 0x003BCF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSlotCellPb);
		}

		// Token: 0x06019AC6 RID: 105158 RVA: 0x003BED14 File Offset: 0x003BCF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSlotCellPb other)
		{
			return other != null && (other == this || (this.Weekday == other.Weekday && this.Slot == other.Slot && this.BehaviorId == other.BehaviorId && this.ReplacedLowBehaviorId == other.ReplacedLowBehaviorId && this.FirstWeekday == other.FirstWeekday && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019AC7 RID: 105159 RVA: 0x003BED90 File Offset: 0x003BCF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Weekday != 0)
			{
				num ^= this.Weekday.GetHashCode();
			}
			if (this.Slot != 0)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.BehaviorId != 0)
			{
				num ^= this.BehaviorId.GetHashCode();
			}
			if (this.ReplacedLowBehaviorId != 0)
			{
				num ^= this.ReplacedLowBehaviorId.GetHashCode();
			}
			if (this.FirstWeekday != 0)
			{
				num ^= this.FirstWeekday.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AC8 RID: 105160 RVA: 0x003BEE33 File Offset: 0x003BD033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AC9 RID: 105161 RVA: 0x003BEE40 File Offset: 0x003BD040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019ACA RID: 105162 RVA: 0x003BEE4C File Offset: 0x003BD04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Weekday != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Weekday);
			}
			if (this.Slot != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Slot);
			}
			if (this.BehaviorId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BehaviorId);
			}
			if (this.ReplacedLowBehaviorId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ReplacedLowBehaviorId);
			}
			if (this.FirstWeekday != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FirstWeekday);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019ACB RID: 105163 RVA: 0x003BEEF8 File Offset: 0x003BD0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Weekday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Weekday);
			}
			if (this.Slot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			if (this.BehaviorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BehaviorId);
			}
			if (this.ReplacedLowBehaviorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReplacedLowBehaviorId);
			}
			if (this.FirstWeekday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstWeekday);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019ACC RID: 105164 RVA: 0x003BEF98 File Offset: 0x003BD198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSlotCellPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Weekday != 0)
			{
				this.Weekday = other.Weekday;
			}
			if (other.Slot != 0)
			{
				this.Slot = other.Slot;
			}
			if (other.BehaviorId != 0)
			{
				this.BehaviorId = other.BehaviorId;
			}
			if (other.ReplacedLowBehaviorId != 0)
			{
				this.ReplacedLowBehaviorId = other.ReplacedLowBehaviorId;
			}
			if (other.FirstWeekday != 0)
			{
				this.FirstWeekday = other.FirstWeekday;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019ACD RID: 105165 RVA: 0x003BF024 File Offset: 0x003BD224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019ACE RID: 105166 RVA: 0x003BF030 File Offset: 0x003BD230
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
						this.Weekday = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Slot = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BehaviorId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ReplacedLowBehaviorId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FirstWeekday = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097A2 RID: 38818
		private static readonly MessageParser<SolarSchoolSlotCellPb> _parser = new MessageParser<SolarSchoolSlotCellPb>(() => new SolarSchoolSlotCellPb());

		// Token: 0x040097A3 RID: 38819
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097A4 RID: 38820
		public const int WeekdayFieldNumber = 1;

		// Token: 0x040097A5 RID: 38821
		private int weekday_;

		// Token: 0x040097A6 RID: 38822
		public const int SlotFieldNumber = 2;

		// Token: 0x040097A7 RID: 38823
		private int slot_;

		// Token: 0x040097A8 RID: 38824
		public const int BehaviorIdFieldNumber = 3;

		// Token: 0x040097A9 RID: 38825
		private int behaviorId_;

		// Token: 0x040097AA RID: 38826
		public const int ReplacedLowBehaviorIdFieldNumber = 4;

		// Token: 0x040097AB RID: 38827
		private int replacedLowBehaviorId_;

		// Token: 0x040097AC RID: 38828
		public const int FirstWeekdayFieldNumber = 5;

		// Token: 0x040097AD RID: 38829
		private int firstWeekday_;
	}
}

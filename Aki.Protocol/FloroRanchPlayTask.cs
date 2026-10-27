using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D2 RID: 1490
	public sealed class FloroRanchPlayTask : IMessage<FloroRanchPlayTask>, IMessage, IEquatable<FloroRanchPlayTask>, IDeepCloneable<FloroRanchPlayTask>, IBufferMessage
	{
		// Token: 0x060089BE RID: 35262 RVA: 0x0014C550 File Offset: 0x0014A750
		[NullableContext(1)]
		public static FloroRanchPlayTask Create()
		{
			return new FloroRanchPlayTask();
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x0014C557 File Offset: 0x0014A757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayTask> Parser
		{
			get
			{
				return FloroRanchPlayTask._parser;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x0014C55E File Offset: 0x0014A75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x0014C561 File Offset: 0x0014A761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTask.Descriptor;
			}
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x0014C568 File Offset: 0x0014A768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask()
		{
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0014C570 File Offset: 0x0014A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask(FloroRanchPlayTask other) : this()
		{
			this.taskType_ = other.taskType_;
			switch (other.DataCase)
			{
			case FloroRanchPlayTask.DataOneofCase.DayStart:
				this.DayStart = other.DayStart.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.Event:
				this.Event = other.Event.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.Shop:
				this.Shop = other.Shop.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.Gacha:
				this.Gacha = other.Gacha.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.StageStart:
				this.StageStart = other.StageStart.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.StageEnd:
				this.StageEnd = other.StageEnd.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.UnitActions:
				this.UnitActions = other.UnitActions.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.WageSettleTask:
				this.WageSettleTask = other.WageSettleTask.Clone();
				break;
			case FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent:
				this.FloroRanchPlayEvent = other.FloroRanchPlayEvent.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x0014C687 File Offset: 0x0014A887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask Clone()
		{
			return new FloroRanchPlayTask(this);
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x0014C68F File Offset: 0x0014A88F
		// (set) Token: 0x060089C6 RID: 35270 RVA: 0x0014C697 File Offset: 0x0014A897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTaskType TaskType
		{
			get
			{
				return this.taskType_;
			}
			set
			{
				this.taskType_ = value;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0014C6A0 File Offset: 0x0014A8A0
		// (set) Token: 0x060089C8 RID: 35272 RVA: 0x0014C6B8 File Offset: 0x0014A8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart DayStart
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.DayStart)
				{
					return null;
				}
				return (FloroRanchDayStart)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.DayStart);
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x0014C6CE File Offset: 0x0014A8CE
		// (set) Token: 0x060089CA RID: 35274 RVA: 0x0014C6E6 File Offset: 0x0014A8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent Event
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.Event)
				{
					return null;
				}
				return (FloroRanchEvent)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.Event);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x0014C6FC File Offset: 0x0014A8FC
		// (set) Token: 0x060089CC RID: 35276 RVA: 0x0014C714 File Offset: 0x0014A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop Shop
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.Shop)
				{
					return null;
				}
				return (FloroRanchShop)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.Shop);
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x0014C72A File Offset: 0x0014A92A
		// (set) Token: 0x060089CE RID: 35278 RVA: 0x0014C742 File Offset: 0x0014A942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Gacha
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.Gacha)
				{
					return null;
				}
				return (FloroRanchGacha)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.Gacha);
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x0014C758 File Offset: 0x0014A958
		// (set) Token: 0x060089D0 RID: 35280 RVA: 0x0014C770 File Offset: 0x0014A970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart StageStart
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.StageStart)
				{
					return null;
				}
				return (FloroRanchStageStart)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.StageStart);
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x0014C786 File Offset: 0x0014A986
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x0014C79E File Offset: 0x0014A99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd StageEnd
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.StageEnd)
				{
					return null;
				}
				return (FloroRanchStageEnd)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.StageEnd);
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x0014C7B4 File Offset: 0x0014A9B4
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x0014C7CC File Offset: 0x0014A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions UnitActions
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.UnitActions)
				{
					return null;
				}
				return (FRUnitActions)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.UnitActions);
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x0014C7E2 File Offset: 0x0014A9E2
		// (set) Token: 0x060089D6 RID: 35286 RVA: 0x0014C7FB File Offset: 0x0014A9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask WageSettleTask
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.WageSettleTask)
				{
					return null;
				}
				return (FloroRanchWageSettleTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.WageSettleTask);
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0014C812 File Offset: 0x0014AA12
		// (set) Token: 0x060089D8 RID: 35288 RVA: 0x0014C82B File Offset: 0x0014AA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent FloroRanchPlayEvent
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent)
				{
					return null;
				}
				return (FloroRanchPlayEvent)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayTask.DataOneofCase.None : FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent);
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060089D9 RID: 35289 RVA: 0x0014C842 File Offset: 0x0014AA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0014C84A File Offset: 0x0014AA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchPlayTask.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0014C85A File Offset: 0x0014AA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTask);
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x0014C868 File Offset: 0x0014AA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTask other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && object.Equals(this.DayStart, other.DayStart) && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && object.Equals(this.Gacha, other.Gacha) && object.Equals(this.StageStart, other.StageStart) && object.Equals(this.StageEnd, other.StageEnd) && object.Equals(this.UnitActions, other.UnitActions) && object.Equals(this.WageSettleTask, other.WageSettleTask) && object.Equals(this.FloroRanchPlayEvent, other.FloroRanchPlayEvent) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x0014C970 File Offset: 0x0014AB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskType != FloroRanchPlayTaskType.DayStart)
			{
				num ^= this.TaskType.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.DayStart)
			{
				num ^= this.DayStart.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Event)
			{
				num ^= this.Event.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Shop)
			{
				num ^= this.Shop.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Gacha)
			{
				num ^= this.Gacha.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageStart)
			{
				num ^= this.StageStart.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageEnd)
			{
				num ^= this.StageEnd.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.UnitActions)
			{
				num ^= this.UnitActions.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.WageSettleTask)
			{
				num ^= this.WageSettleTask.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent)
			{
				num ^= this.FloroRanchPlayEvent.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x0014CA8F File Offset: 0x0014AC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x0014CA9C File Offset: 0x0014AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089E0 RID: 35296 RVA: 0x0014CAA8 File Offset: 0x0014ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != FloroRanchPlayTaskType.DayStart)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TaskType);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.DayStart)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DayStart);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Event)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Event);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Shop)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Shop);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Gacha)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Gacha);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageStart)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.StageStart);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageEnd)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.StageEnd);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.UnitActions)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.UnitActions);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.WageSettleTask)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.WageSettleTask);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FloroRanchPlayEvent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x0014CBEC File Offset: 0x0014ADEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskType != FloroRanchPlayTaskType.DayStart)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TaskType);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.DayStart)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DayStart);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Event)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Event);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Shop)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Gacha)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Gacha);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageStart)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageStart);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageEnd)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageEnd);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.UnitActions)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnitActions);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.WageSettleTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WageSettleTask);
			}
			if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FloroRanchPlayEvent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x0014CD10 File Offset: 0x0014AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskType != FloroRanchPlayTaskType.DayStart)
			{
				this.TaskType = other.TaskType;
			}
			switch (other.DataCase)
			{
			case FloroRanchPlayTask.DataOneofCase.DayStart:
				if (this.DayStart == null)
				{
					this.DayStart = new FloroRanchDayStart();
				}
				this.DayStart.MergeFrom(other.DayStart);
				break;
			case FloroRanchPlayTask.DataOneofCase.Event:
				if (this.Event == null)
				{
					this.Event = new FloroRanchEvent();
				}
				this.Event.MergeFrom(other.Event);
				break;
			case FloroRanchPlayTask.DataOneofCase.Shop:
				if (this.Shop == null)
				{
					this.Shop = new FloroRanchShop();
				}
				this.Shop.MergeFrom(other.Shop);
				break;
			case FloroRanchPlayTask.DataOneofCase.Gacha:
				if (this.Gacha == null)
				{
					this.Gacha = new FloroRanchGacha();
				}
				this.Gacha.MergeFrom(other.Gacha);
				break;
			case FloroRanchPlayTask.DataOneofCase.StageStart:
				if (this.StageStart == null)
				{
					this.StageStart = new FloroRanchStageStart();
				}
				this.StageStart.MergeFrom(other.StageStart);
				break;
			case FloroRanchPlayTask.DataOneofCase.StageEnd:
				if (this.StageEnd == null)
				{
					this.StageEnd = new FloroRanchStageEnd();
				}
				this.StageEnd.MergeFrom(other.StageEnd);
				break;
			case FloroRanchPlayTask.DataOneofCase.UnitActions:
				if (this.UnitActions == null)
				{
					this.UnitActions = new FRUnitActions();
				}
				this.UnitActions.MergeFrom(other.UnitActions);
				break;
			case FloroRanchPlayTask.DataOneofCase.WageSettleTask:
				if (this.WageSettleTask == null)
				{
					this.WageSettleTask = new FloroRanchWageSettleTask();
				}
				this.WageSettleTask.MergeFrom(other.WageSettleTask);
				break;
			case FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent:
				if (this.FloroRanchPlayEvent == null)
				{
					this.FloroRanchPlayEvent = new FloroRanchPlayEvent();
				}
				this.FloroRanchPlayEvent.MergeFrom(other.FloroRanchPlayEvent);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x0014CEE7 File Offset: 0x0014B0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x0014CEF0 File Offset: 0x0014B0F0
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
						if (num == 8U)
						{
							this.TaskType = (FloroRanchPlayTaskType)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							FloroRanchDayStart floroRanchDayStart = new FloroRanchDayStart();
							if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.DayStart)
							{
								floroRanchDayStart.MergeFrom(this.DayStart);
							}
							input.ReadMessage(floroRanchDayStart);
							this.DayStart = floroRanchDayStart;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							FloroRanchEvent floroRanchEvent = new FloroRanchEvent();
							if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Event)
							{
								floroRanchEvent.MergeFrom(this.Event);
							}
							input.ReadMessage(floroRanchEvent);
							this.Event = floroRanchEvent;
							continue;
						}
						if (num == 34U)
						{
							FloroRanchShop floroRanchShop = new FloroRanchShop();
							if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Shop)
							{
								floroRanchShop.MergeFrom(this.Shop);
							}
							input.ReadMessage(floroRanchShop);
							this.Shop = floroRanchShop;
							continue;
						}
						if (num == 42U)
						{
							FloroRanchGacha floroRanchGacha = new FloroRanchGacha();
							if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.Gacha)
							{
								floroRanchGacha.MergeFrom(this.Gacha);
							}
							input.ReadMessage(floroRanchGacha);
							this.Gacha = floroRanchGacha;
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						FloroRanchStageStart floroRanchStageStart = new FloroRanchStageStart();
						if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageStart)
						{
							floroRanchStageStart.MergeFrom(this.StageStart);
						}
						input.ReadMessage(floroRanchStageStart);
						this.StageStart = floroRanchStageStart;
						continue;
					}
					if (num == 58U)
					{
						FloroRanchStageEnd floroRanchStageEnd = new FloroRanchStageEnd();
						if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.StageEnd)
						{
							floroRanchStageEnd.MergeFrom(this.StageEnd);
						}
						input.ReadMessage(floroRanchStageEnd);
						this.StageEnd = floroRanchStageEnd;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						FRUnitActions frunitActions = new FRUnitActions();
						if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.UnitActions)
						{
							frunitActions.MergeFrom(this.UnitActions);
						}
						input.ReadMessage(frunitActions);
						this.UnitActions = frunitActions;
						continue;
					}
					if (num == 74U)
					{
						FloroRanchWageSettleTask floroRanchWageSettleTask = new FloroRanchWageSettleTask();
						if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.WageSettleTask)
						{
							floroRanchWageSettleTask.MergeFrom(this.WageSettleTask);
						}
						input.ReadMessage(floroRanchWageSettleTask);
						this.WageSettleTask = floroRanchWageSettleTask;
						continue;
					}
					if (num == 82U)
					{
						FloroRanchPlayEvent floroRanchPlayEvent = new FloroRanchPlayEvent();
						if (this.dataCase_ == FloroRanchPlayTask.DataOneofCase.FloroRanchPlayEvent)
						{
							floroRanchPlayEvent.MergeFrom(this.FloroRanchPlayEvent);
						}
						input.ReadMessage(floroRanchPlayEvent);
						this.FloroRanchPlayEvent = floroRanchPlayEvent;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043B1 RID: 17329
		private static readonly MessageParser<FloroRanchPlayTask> _parser = new MessageParser<FloroRanchPlayTask>(() => new FloroRanchPlayTask());

		// Token: 0x040043B2 RID: 17330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043B3 RID: 17331
		public const int TaskTypeFieldNumber = 1;

		// Token: 0x040043B4 RID: 17332
		private FloroRanchPlayTaskType taskType_;

		// Token: 0x040043B5 RID: 17333
		public const int DayStartFieldNumber = 2;

		// Token: 0x040043B6 RID: 17334
		public const int EventFieldNumber = 3;

		// Token: 0x040043B7 RID: 17335
		public const int ShopFieldNumber = 4;

		// Token: 0x040043B8 RID: 17336
		public const int GachaFieldNumber = 5;

		// Token: 0x040043B9 RID: 17337
		public const int StageStartFieldNumber = 6;

		// Token: 0x040043BA RID: 17338
		public const int StageEndFieldNumber = 7;

		// Token: 0x040043BB RID: 17339
		public const int UnitActionsFieldNumber = 8;

		// Token: 0x040043BC RID: 17340
		public const int WageSettleTaskFieldNumber = 9;

		// Token: 0x040043BD RID: 17341
		public const int FloroRanchPlayEventFieldNumber = 10;

		// Token: 0x040043BE RID: 17342
		private object data_;

		// Token: 0x040043BF RID: 17343
		private FloroRanchPlayTask.DataOneofCase dataCase_;

		// Token: 0x020017A1 RID: 6049
		public enum DataOneofCase
		{
			// Token: 0x0400C6CA RID: 50890
			None,
			// Token: 0x0400C6CB RID: 50891
			DayStart = 2,
			// Token: 0x0400C6CC RID: 50892
			Event,
			// Token: 0x0400C6CD RID: 50893
			Shop,
			// Token: 0x0400C6CE RID: 50894
			Gacha,
			// Token: 0x0400C6CF RID: 50895
			StageStart,
			// Token: 0x0400C6D0 RID: 50896
			StageEnd,
			// Token: 0x0400C6D1 RID: 50897
			UnitActions,
			// Token: 0x0400C6D2 RID: 50898
			WageSettleTask,
			// Token: 0x0400C6D3 RID: 50899
			FloroRanchPlayEvent
		}
	}
}

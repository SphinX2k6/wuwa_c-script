using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BD RID: 1469
	public sealed class FloroRanchPlayTask : IMessage<FloroRanchPlayTask>, IMessage, IEquatable<FloroRanchPlayTask>, IDeepCloneable<FloroRanchPlayTask>, IBufferMessage
	{
		// Token: 0x06008856 RID: 34902 RVA: 0x00149934 File Offset: 0x00147B34
		[NullableContext(1)]
		public static FloroRanchPlayTask Create()
		{
			return new FloroRanchPlayTask();
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008857 RID: 34903 RVA: 0x0014993B File Offset: 0x00147B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayTask> Parser
		{
			get
			{
				return FloroRanchPlayTask._parser;
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x00149942 File Offset: 0x00147B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06008859 RID: 34905 RVA: 0x00149945 File Offset: 0x00147B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTask.Descriptor;
			}
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x0014994C File Offset: 0x00147B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask()
		{
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x00149954 File Offset: 0x00147B54
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

		// Token: 0x0600885C RID: 34908 RVA: 0x00149A6B File Offset: 0x00147C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask Clone()
		{
			return new FloroRanchPlayTask(this);
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600885D RID: 34909 RVA: 0x00149A73 File Offset: 0x00147C73
		// (set) Token: 0x0600885E RID: 34910 RVA: 0x00149A7B File Offset: 0x00147C7B
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

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x00149A84 File Offset: 0x00147C84
		// (set) Token: 0x06008860 RID: 34912 RVA: 0x00149A9C File Offset: 0x00147C9C
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

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06008861 RID: 34913 RVA: 0x00149AB2 File Offset: 0x00147CB2
		// (set) Token: 0x06008862 RID: 34914 RVA: 0x00149ACA File Offset: 0x00147CCA
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06008863 RID: 34915 RVA: 0x00149AE0 File Offset: 0x00147CE0
		// (set) Token: 0x06008864 RID: 34916 RVA: 0x00149AF8 File Offset: 0x00147CF8
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

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06008865 RID: 34917 RVA: 0x00149B0E File Offset: 0x00147D0E
		// (set) Token: 0x06008866 RID: 34918 RVA: 0x00149B26 File Offset: 0x00147D26
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

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x00149B3C File Offset: 0x00147D3C
		// (set) Token: 0x06008868 RID: 34920 RVA: 0x00149B54 File Offset: 0x00147D54
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

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06008869 RID: 34921 RVA: 0x00149B6A File Offset: 0x00147D6A
		// (set) Token: 0x0600886A RID: 34922 RVA: 0x00149B82 File Offset: 0x00147D82
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x0600886B RID: 34923 RVA: 0x00149B98 File Offset: 0x00147D98
		// (set) Token: 0x0600886C RID: 34924 RVA: 0x00149BB0 File Offset: 0x00147DB0
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

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x0600886D RID: 34925 RVA: 0x00149BC6 File Offset: 0x00147DC6
		// (set) Token: 0x0600886E RID: 34926 RVA: 0x00149BDF File Offset: 0x00147DDF
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x0600886F RID: 34927 RVA: 0x00149BF6 File Offset: 0x00147DF6
		// (set) Token: 0x06008870 RID: 34928 RVA: 0x00149C0F File Offset: 0x00147E0F
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

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06008871 RID: 34929 RVA: 0x00149C26 File Offset: 0x00147E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTask.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00149C2E File Offset: 0x00147E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchPlayTask.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x00149C3E File Offset: 0x00147E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTask);
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x00149C4C File Offset: 0x00147E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTask other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && object.Equals(this.DayStart, other.DayStart) && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && object.Equals(this.Gacha, other.Gacha) && object.Equals(this.StageStart, other.StageStart) && object.Equals(this.StageEnd, other.StageEnd) && object.Equals(this.UnitActions, other.UnitActions) && object.Equals(this.WageSettleTask, other.WageSettleTask) && object.Equals(this.FloroRanchPlayEvent, other.FloroRanchPlayEvent) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x00149D54 File Offset: 0x00147F54
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

		// Token: 0x06008876 RID: 34934 RVA: 0x00149E73 File Offset: 0x00148073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00149E80 File Offset: 0x00148080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x00149E8C File Offset: 0x0014808C
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

		// Token: 0x06008879 RID: 34937 RVA: 0x00149FD0 File Offset: 0x001481D0
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

		// Token: 0x0600887A RID: 34938 RVA: 0x0014A0F4 File Offset: 0x001482F4
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

		// Token: 0x0600887B RID: 34939 RVA: 0x0014A2CB File Offset: 0x001484CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x0014A2D4 File Offset: 0x001484D4
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

		// Token: 0x040043A7 RID: 17319
		private static readonly MessageParser<FloroRanchPlayTask> _parser = new MessageParser<FloroRanchPlayTask>(() => new FloroRanchPlayTask());

		// Token: 0x040043A8 RID: 17320
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043A9 RID: 17321
		public const int TaskTypeFieldNumber = 1;

		// Token: 0x040043AA RID: 17322
		private FloroRanchPlayTaskType taskType_;

		// Token: 0x040043AB RID: 17323
		public const int DayStartFieldNumber = 2;

		// Token: 0x040043AC RID: 17324
		public const int EventFieldNumber = 3;

		// Token: 0x040043AD RID: 17325
		public const int ShopFieldNumber = 4;

		// Token: 0x040043AE RID: 17326
		public const int GachaFieldNumber = 5;

		// Token: 0x040043AF RID: 17327
		public const int StageStartFieldNumber = 6;

		// Token: 0x040043B0 RID: 17328
		public const int StageEndFieldNumber = 7;

		// Token: 0x040043B1 RID: 17329
		public const int UnitActionsFieldNumber = 8;

		// Token: 0x040043B2 RID: 17330
		public const int WageSettleTaskFieldNumber = 9;

		// Token: 0x040043B3 RID: 17331
		public const int FloroRanchPlayEventFieldNumber = 10;

		// Token: 0x040043B4 RID: 17332
		private object data_;

		// Token: 0x040043B5 RID: 17333
		private FloroRanchPlayTask.DataOneofCase dataCase_;

		// Token: 0x02001819 RID: 6169
		public enum DataOneofCase
		{
			// Token: 0x0400CBF5 RID: 52213
			None,
			// Token: 0x0400CBF6 RID: 52214
			DayStart = 2,
			// Token: 0x0400CBF7 RID: 52215
			Event,
			// Token: 0x0400CBF8 RID: 52216
			Shop,
			// Token: 0x0400CBF9 RID: 52217
			Gacha,
			// Token: 0x0400CBFA RID: 52218
			StageStart,
			// Token: 0x0400CBFB RID: 52219
			StageEnd,
			// Token: 0x0400CBFC RID: 52220
			UnitActions,
			// Token: 0x0400CBFD RID: 52221
			WageSettleTask,
			// Token: 0x0400CBFE RID: 52222
			FloroRanchPlayEvent
		}
	}
}

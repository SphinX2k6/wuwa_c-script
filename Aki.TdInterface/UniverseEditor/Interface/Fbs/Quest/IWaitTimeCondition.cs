using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046DF RID: 18143
	public struct IWaitTimeCondition : IFlatbufferObject
	{
		// Token: 0x17007F0D RID: 32525
		// (get) Token: 0x0601AACC RID: 109260 RVA: 0x003CAB41 File Offset: 0x003C8D41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AACD RID: 109261 RVA: 0x003CAB4E File Offset: 0x003C8D4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AACE RID: 109262 RVA: 0x003CAB58 File Offset: 0x003C8D58
		public static IWaitTimeCondition GetRootAsIWaitTimeCondition(ByteBuffer _bb)
		{
			return IWaitTimeCondition.GetRootAsIWaitTimeCondition(_bb, default(IWaitTimeCondition));
		}

		// Token: 0x0601AACF RID: 109263 RVA: 0x003CAB74 File Offset: 0x003C8D74
		public static IWaitTimeCondition GetRootAsIWaitTimeCondition(ByteBuffer _bb, IWaitTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AAD0 RID: 109264 RVA: 0x003CAB91 File Offset: 0x003C8D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AAD1 RID: 109265 RVA: 0x003CABA0 File Offset: 0x003C8DA0
		public IWaitTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F0E RID: 32526
		// (get) Token: 0x0601AAD2 RID: 109266 RVA: 0x003CABB0 File Offset: 0x003C8DB0
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F0F RID: 32527
		// (get) Token: 0x0601AAD3 RID: 109267 RVA: 0x003CABEC File Offset: 0x003C8DEC
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007F10 RID: 32528
		// (get) Token: 0x0601AAD4 RID: 109268 RVA: 0x003CAC4C File Offset: 0x003C8E4C
		public int Days
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F11 RID: 32529
		// (get) Token: 0x0601AAD5 RID: 109269 RVA: 0x003CAC88 File Offset: 0x003C8E88
		public int Hours
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F12 RID: 32530
		// (get) Token: 0x0601AAD6 RID: 109270 RVA: 0x003CACC8 File Offset: 0x003C8EC8
		public int Minutes
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F13 RID: 32531
		// (get) Token: 0x0601AAD7 RID: 109271 RVA: 0x003CAD08 File Offset: 0x003C8F08
		public int Seconds
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AAD8 RID: 109272 RVA: 0x003CAD45 File Offset: 0x003C8F45
		public static Offset<IWaitTimeCondition> CreateIWaitTimeCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int Days = 0, int Hours = 0, int Minutes = 0, int Seconds = 0)
		{
			builder.StartTable(6);
			IWaitTimeCondition.AddSeconds(builder, Seconds);
			IWaitTimeCondition.AddMinutes(builder, Minutes);
			IWaitTimeCondition.AddHours(builder, Hours);
			IWaitTimeCondition.AddDays(builder, Days);
			IWaitTimeCondition.AddPreConditions(builder, PreConditionsOffset);
			IWaitTimeCondition.AddType(builder, Type);
			return IWaitTimeCondition.EndIWaitTimeCondition(builder);
		}

		// Token: 0x0601AAD9 RID: 109273 RVA: 0x003CAD81 File Offset: 0x003C8F81
		public static void StartIWaitTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601AADA RID: 109274 RVA: 0x003CAD8A File Offset: 0x003C8F8A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AADB RID: 109275 RVA: 0x003CAD95 File Offset: 0x003C8F95
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601AADC RID: 109276 RVA: 0x003CADA5 File Offset: 0x003C8FA5
		public static void AddDays(FlatBufferBuilder builder, int days)
		{
			builder.AddInt(2, days, 0);
		}

		// Token: 0x0601AADD RID: 109277 RVA: 0x003CADB0 File Offset: 0x003C8FB0
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(3, hours, 0);
		}

		// Token: 0x0601AADE RID: 109278 RVA: 0x003CADBB File Offset: 0x003C8FBB
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(4, minutes, 0);
		}

		// Token: 0x0601AADF RID: 109279 RVA: 0x003CADC6 File Offset: 0x003C8FC6
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(5, seconds, 0);
		}

		// Token: 0x0601AAE0 RID: 109280 RVA: 0x003CADD1 File Offset: 0x003C8FD1
		public static Offset<IWaitTimeCondition> EndIWaitTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitTimeCondition>(builder.EndTable());
		}

		// Token: 0x0601AAE1 RID: 109281 RVA: 0x003CADE0 File Offset: 0x003C8FE0
		public IWaitTimeConditionT UnPack()
		{
			IWaitTimeConditionT waitTimeConditionT = new IWaitTimeConditionT();
			this.UnPackTo(waitTimeConditionT);
			return waitTimeConditionT;
		}

		// Token: 0x0601AAE2 RID: 109282 RVA: 0x003CADFC File Offset: 0x003C8FFC
		public void UnPackTo(IWaitTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Days = this.Days;
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Seconds = this.Seconds;
		}

		// Token: 0x0601AAE3 RID: 109283 RVA: 0x003CAE74 File Offset: 0x003C9074
		public static Offset<IWaitTimeCondition> Pack(FlatBufferBuilder builder, IWaitTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitTimeCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IWaitTimeCondition.CreateIWaitTimeCondition(builder, _o.Type, preConditionsOffset, _o.Days, _o.Hours, _o.Minutes, _o.Seconds);
		}

		// Token: 0x0400C928 RID: 51496
		private Table __p;
	}
}

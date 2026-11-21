using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D5 RID: 22485
	public struct IFixedDateTimeRefreshRule : IFlatbufferObject
	{
		// Token: 0x1700A289 RID: 41609
		// (get) Token: 0x060244DF RID: 148703 RVA: 0x004FCF1C File Offset: 0x004FB11C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244E0 RID: 148704 RVA: 0x004FCF29 File Offset: 0x004FB129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244E1 RID: 148705 RVA: 0x004FCF30 File Offset: 0x004FB130
		public static IFixedDateTimeRefreshRule GetRootAsIFixedDateTimeRefreshRule(ByteBuffer _bb)
		{
			return IFixedDateTimeRefreshRule.GetRootAsIFixedDateTimeRefreshRule(_bb, default(IFixedDateTimeRefreshRule));
		}

		// Token: 0x060244E2 RID: 148706 RVA: 0x004FCF4C File Offset: 0x004FB14C
		public static IFixedDateTimeRefreshRule GetRootAsIFixedDateTimeRefreshRule(ByteBuffer _bb, IFixedDateTimeRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244E3 RID: 148707 RVA: 0x004FCF69 File Offset: 0x004FB169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244E4 RID: 148708 RVA: 0x004FCF78 File Offset: 0x004FB178
		public IFixedDateTimeRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A28A RID: 41610
		// (get) Token: 0x060244E5 RID: 148709 RVA: 0x004FCF88 File Offset: 0x004FB188
		public ERefreshRule Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefreshRule.CD;
				}
				return (ERefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A28B RID: 41611
		// (get) Token: 0x060244E6 RID: 148710 RVA: 0x004FCFC4 File Offset: 0x004FB1C4
		public int Hours
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A28C RID: 41612
		// (get) Token: 0x060244E7 RID: 148711 RVA: 0x004FD000 File Offset: 0x004FB200
		public int Minutes
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

		// Token: 0x1700A28D RID: 41613
		// (get) Token: 0x060244E8 RID: 148712 RVA: 0x004FD03C File Offset: 0x004FB23C
		public int Seconds
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

		// Token: 0x1700A28E RID: 41614
		// (get) Token: 0x060244E9 RID: 148713 RVA: 0x004FD07C File Offset: 0x004FB27C
		public int RefreshRate
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

		// Token: 0x1700A28F RID: 41615
		// (get) Token: 0x060244EA RID: 148714 RVA: 0x004FD0BC File Offset: 0x004FB2BC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A290 RID: 41616
		// (get) Token: 0x060244EB RID: 148715 RVA: 0x004FD11C File Offset: 0x004FB31C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060244EC RID: 148716 RVA: 0x004FD15C File Offset: 0x004FB35C
		public static Offset<IFixedDateTimeRefreshRule> CreateIFixedDateTimeRefreshRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD, int Hours = 0, int Minutes = 0, int Seconds = 0, int RefreshRate = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IFixedDateTimeRefreshRule.AddCondition(builder, ConditionOffset);
			IFixedDateTimeRefreshRule.AddRefreshRate(builder, RefreshRate);
			IFixedDateTimeRefreshRule.AddSeconds(builder, Seconds);
			IFixedDateTimeRefreshRule.AddMinutes(builder, Minutes);
			IFixedDateTimeRefreshRule.AddHours(builder, Hours);
			IFixedDateTimeRefreshRule.AddNullMask(builder, NullMask);
			IFixedDateTimeRefreshRule.AddType(builder, Type);
			return IFixedDateTimeRefreshRule.EndIFixedDateTimeRefreshRule(builder);
		}

		// Token: 0x060244ED RID: 148717 RVA: 0x004FD1AB File Offset: 0x004FB3AB
		public static void StartIFixedDateTimeRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060244EE RID: 148718 RVA: 0x004FD1B4 File Offset: 0x004FB3B4
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244EF RID: 148719 RVA: 0x004FD1BF File Offset: 0x004FB3BF
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(1, hours, 0);
		}

		// Token: 0x060244F0 RID: 148720 RVA: 0x004FD1CA File Offset: 0x004FB3CA
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(2, minutes, 0);
		}

		// Token: 0x060244F1 RID: 148721 RVA: 0x004FD1D5 File Offset: 0x004FB3D5
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(3, seconds, 0);
		}

		// Token: 0x060244F2 RID: 148722 RVA: 0x004FD1E0 File Offset: 0x004FB3E0
		public static void AddRefreshRate(FlatBufferBuilder builder, int refreshRate)
		{
			builder.AddInt(4, refreshRate, 0);
		}

		// Token: 0x060244F3 RID: 148723 RVA: 0x004FD1EB File Offset: 0x004FB3EB
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(5, conditionOffset.Value, 0);
		}

		// Token: 0x060244F4 RID: 148724 RVA: 0x004FD1FB File Offset: 0x004FB3FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060244F5 RID: 148725 RVA: 0x004FD206 File Offset: 0x004FB406
		public static Offset<IFixedDateTimeRefreshRule> EndIFixedDateTimeRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTimeRefreshRule>(builder.EndTable());
		}

		// Token: 0x060244F6 RID: 148726 RVA: 0x004FD214 File Offset: 0x004FB414
		public IFixedDateTimeRefreshRuleT UnPack()
		{
			IFixedDateTimeRefreshRuleT fixedDateTimeRefreshRuleT = new IFixedDateTimeRefreshRuleT();
			this.UnPackTo(fixedDateTimeRefreshRuleT);
			return fixedDateTimeRefreshRuleT;
		}

		// Token: 0x060244F7 RID: 148727 RVA: 0x004FD230 File Offset: 0x004FB430
		public void UnPackTo(IFixedDateTimeRefreshRuleT _o)
		{
			_o.Type = this.Type;
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Seconds = this.Seconds;
			_o.RefreshRate = this.RefreshRate;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060244F8 RID: 148728 RVA: 0x004FD2B4 File Offset: 0x004FB4B4
		public static Offset<IFixedDateTimeRefreshRule> Pack(FlatBufferBuilder builder, IFixedDateTimeRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTimeRefreshRule>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IFixedDateTimeRefreshRule.CreateIFixedDateTimeRefreshRule(builder, _o.Type, _o.Hours, _o.Minutes, _o.Seconds, _o.RefreshRate, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400EFC6 RID: 61382
		private Table __p;
	}
}

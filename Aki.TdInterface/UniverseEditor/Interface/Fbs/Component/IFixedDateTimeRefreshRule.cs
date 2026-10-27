using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200526D RID: 21101
	public struct IFixedDateTimeRefreshRule : IFlatbufferObject
	{
		// Token: 0x17009A8D RID: 39565
		// (get) Token: 0x06022549 RID: 140617 RVA: 0x004C2458 File Offset: 0x004C0658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602254A RID: 140618 RVA: 0x004C2465 File Offset: 0x004C0665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602254B RID: 140619 RVA: 0x004C246C File Offset: 0x004C066C
		public static IFixedDateTimeRefreshRule GetRootAsIFixedDateTimeRefreshRule(ByteBuffer _bb)
		{
			return IFixedDateTimeRefreshRule.GetRootAsIFixedDateTimeRefreshRule(_bb, default(IFixedDateTimeRefreshRule));
		}

		// Token: 0x0602254C RID: 140620 RVA: 0x004C2488 File Offset: 0x004C0688
		public static IFixedDateTimeRefreshRule GetRootAsIFixedDateTimeRefreshRule(ByteBuffer _bb, IFixedDateTimeRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602254D RID: 140621 RVA: 0x004C24A5 File Offset: 0x004C06A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602254E RID: 140622 RVA: 0x004C24B4 File Offset: 0x004C06B4
		public IFixedDateTimeRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A8E RID: 39566
		// (get) Token: 0x0602254F RID: 140623 RVA: 0x004C24C4 File Offset: 0x004C06C4
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

		// Token: 0x17009A8F RID: 39567
		// (get) Token: 0x06022550 RID: 140624 RVA: 0x004C2500 File Offset: 0x004C0700
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

		// Token: 0x17009A90 RID: 39568
		// (get) Token: 0x06022551 RID: 140625 RVA: 0x004C253C File Offset: 0x004C073C
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

		// Token: 0x17009A91 RID: 39569
		// (get) Token: 0x06022552 RID: 140626 RVA: 0x004C2578 File Offset: 0x004C0778
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

		// Token: 0x17009A92 RID: 39570
		// (get) Token: 0x06022553 RID: 140627 RVA: 0x004C25B8 File Offset: 0x004C07B8
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

		// Token: 0x17009A93 RID: 39571
		// (get) Token: 0x06022554 RID: 140628 RVA: 0x004C25F8 File Offset: 0x004C07F8
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

		// Token: 0x17009A94 RID: 39572
		// (get) Token: 0x06022555 RID: 140629 RVA: 0x004C2658 File Offset: 0x004C0858
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

		// Token: 0x06022556 RID: 140630 RVA: 0x004C2698 File Offset: 0x004C0898
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

		// Token: 0x06022557 RID: 140631 RVA: 0x004C26E7 File Offset: 0x004C08E7
		public static void StartIFixedDateTimeRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06022558 RID: 140632 RVA: 0x004C26F0 File Offset: 0x004C08F0
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022559 RID: 140633 RVA: 0x004C26FB File Offset: 0x004C08FB
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(1, hours, 0);
		}

		// Token: 0x0602255A RID: 140634 RVA: 0x004C2706 File Offset: 0x004C0906
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(2, minutes, 0);
		}

		// Token: 0x0602255B RID: 140635 RVA: 0x004C2711 File Offset: 0x004C0911
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(3, seconds, 0);
		}

		// Token: 0x0602255C RID: 140636 RVA: 0x004C271C File Offset: 0x004C091C
		public static void AddRefreshRate(FlatBufferBuilder builder, int refreshRate)
		{
			builder.AddInt(4, refreshRate, 0);
		}

		// Token: 0x0602255D RID: 140637 RVA: 0x004C2727 File Offset: 0x004C0927
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(5, conditionOffset.Value, 0);
		}

		// Token: 0x0602255E RID: 140638 RVA: 0x004C2737 File Offset: 0x004C0937
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602255F RID: 140639 RVA: 0x004C2742 File Offset: 0x004C0942
		public static Offset<IFixedDateTimeRefreshRule> EndIFixedDateTimeRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTimeRefreshRule>(builder.EndTable());
		}

		// Token: 0x06022560 RID: 140640 RVA: 0x004C2750 File Offset: 0x004C0950
		public IFixedDateTimeRefreshRuleT UnPack()
		{
			IFixedDateTimeRefreshRuleT fixedDateTimeRefreshRuleT = new IFixedDateTimeRefreshRuleT();
			this.UnPackTo(fixedDateTimeRefreshRuleT);
			return fixedDateTimeRefreshRuleT;
		}

		// Token: 0x06022561 RID: 140641 RVA: 0x004C276C File Offset: 0x004C096C
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

		// Token: 0x06022562 RID: 140642 RVA: 0x004C27F0 File Offset: 0x004C09F0
		public static Offset<IFixedDateTimeRefreshRule> Pack(FlatBufferBuilder builder, IFixedDateTimeRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTimeRefreshRule>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IFixedDateTimeRefreshRule.CreateIFixedDateTimeRefreshRule(builder, _o.Type, _o.Hours, _o.Minutes, _o.Seconds, _o.RefreshRate, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400E3C0 RID: 58304
		private Table __p;
	}
}

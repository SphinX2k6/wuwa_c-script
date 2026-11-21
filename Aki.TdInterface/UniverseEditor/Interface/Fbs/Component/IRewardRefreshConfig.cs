using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E77 RID: 24183
	public struct IRewardRefreshConfig : IFlatbufferObject
	{
		// Token: 0x1700B27A RID: 45690
		// (get) Token: 0x06028781 RID: 165761 RVA: 0x00588BD0 File Offset: 0x00586DD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028782 RID: 165762 RVA: 0x00588BDD File Offset: 0x00586DDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028783 RID: 165763 RVA: 0x00588BE4 File Offset: 0x00586DE4
		public static IRewardRefreshConfig GetRootAsIRewardRefreshConfig(ByteBuffer _bb)
		{
			return IRewardRefreshConfig.GetRootAsIRewardRefreshConfig(_bb, default(IRewardRefreshConfig));
		}

		// Token: 0x06028784 RID: 165764 RVA: 0x00588C00 File Offset: 0x00586E00
		public static IRewardRefreshConfig GetRootAsIRewardRefreshConfig(ByteBuffer _bb, IRewardRefreshConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028785 RID: 165765 RVA: 0x00588C1D File Offset: 0x00586E1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028786 RID: 165766 RVA: 0x00588C2C File Offset: 0x00586E2C
		public IRewardRefreshConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B27B RID: 45691
		// (get) Token: 0x06028787 RID: 165767 RVA: 0x00588C3C File Offset: 0x00586E3C
		public TRefreshCondition RefreshConditionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TRefreshCondition.NONE;
				}
				return (TRefreshCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028788 RID: 165768 RVA: 0x00588C78 File Offset: 0x00586E78
		public TTable? RefreshCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028789 RID: 165769 RVA: 0x00588CBC File Offset: 0x00586EBC
		public IRefreshOnDeath RefreshConditionAsIRefreshOnDeath()
		{
			return this.RefreshCondition<IRefreshOnDeath>().Value;
		}

		// Token: 0x0602878A RID: 165770 RVA: 0x00588CD8 File Offset: 0x00586ED8
		public IRefreshOnHostInteract RefreshConditionAsIRefreshOnHostInteract()
		{
			return this.RefreshCondition<IRefreshOnHostInteract>().Value;
		}

		// Token: 0x1700B27C RID: 45692
		// (get) Token: 0x0602878B RID: 165771 RVA: 0x00588CF4 File Offset: 0x00586EF4
		public TRefreshRule RefreshTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRefreshRule.NONE;
				}
				return (TRefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602878C RID: 165772 RVA: 0x00588D30 File Offset: 0x00586F30
		public TTable? RefreshType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602878D RID: 165773 RVA: 0x00588D78 File Offset: 0x00586F78
		public ICdRefreshRule RefreshTypeAsICdRefreshRule()
		{
			return this.RefreshType<ICdRefreshRule>().Value;
		}

		// Token: 0x0602878E RID: 165774 RVA: 0x00588D94 File Offset: 0x00586F94
		public IFixedDateTimeRefreshRule RefreshTypeAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshType<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x0602878F RID: 165775 RVA: 0x00588DB0 File Offset: 0x00586FB0
		public IRandomNpcRule RefreshTypeAsIRandomNpcRule()
		{
			return this.RefreshType<IRandomNpcRule>().Value;
		}

		// Token: 0x1700B27D RID: 45693
		// (get) Token: 0x06028790 RID: 165776 RVA: 0x00588DCC File Offset: 0x00586FCC
		public int MaxCount
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

		// Token: 0x1700B27E RID: 45694
		// (get) Token: 0x06028791 RID: 165777 RVA: 0x00588E0C File Offset: 0x0058700C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028792 RID: 165778 RVA: 0x00588E49 File Offset: 0x00587049
		public static Offset<IRewardRefreshConfig> CreateIRewardRefreshConfig(FlatBufferBuilder builder, TRefreshCondition RefreshCondition_type = TRefreshCondition.NONE, int RefreshConditionOffset = 0, TRefreshRule RefreshType_type = TRefreshRule.NONE, int RefreshTypeOffset = 0, int MaxCount = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRewardRefreshConfig.AddMaxCount(builder, MaxCount);
			IRewardRefreshConfig.AddRefreshType(builder, RefreshTypeOffset);
			IRewardRefreshConfig.AddRefreshCondition(builder, RefreshConditionOffset);
			IRewardRefreshConfig.AddNullMask(builder, NullMask);
			IRewardRefreshConfig.AddRefreshTypeType(builder, RefreshType_type);
			IRewardRefreshConfig.AddRefreshConditionType(builder, RefreshCondition_type);
			return IRewardRefreshConfig.EndIRewardRefreshConfig(builder);
		}

		// Token: 0x06028793 RID: 165779 RVA: 0x00588E85 File Offset: 0x00587085
		public static void StartIRewardRefreshConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06028794 RID: 165780 RVA: 0x00588E8E File Offset: 0x0058708E
		public static void AddRefreshConditionType(FlatBufferBuilder builder, TRefreshCondition refreshConditionType)
		{
			builder.AddByte(0, (byte)refreshConditionType, 0);
		}

		// Token: 0x06028795 RID: 165781 RVA: 0x00588E99 File Offset: 0x00587099
		public static void AddRefreshCondition(FlatBufferBuilder builder, int refreshConditionOffset)
		{
			builder.AddOffset(1, refreshConditionOffset, 0);
		}

		// Token: 0x06028796 RID: 165782 RVA: 0x00588EA4 File Offset: 0x005870A4
		public static void AddRefreshTypeType(FlatBufferBuilder builder, TRefreshRule refreshTypeType)
		{
			builder.AddByte(2, (byte)refreshTypeType, 0);
		}

		// Token: 0x06028797 RID: 165783 RVA: 0x00588EAF File Offset: 0x005870AF
		public static void AddRefreshType(FlatBufferBuilder builder, int refreshTypeOffset)
		{
			builder.AddOffset(3, refreshTypeOffset, 0);
		}

		// Token: 0x06028798 RID: 165784 RVA: 0x00588EBA File Offset: 0x005870BA
		public static void AddMaxCount(FlatBufferBuilder builder, int maxCount)
		{
			builder.AddInt(4, maxCount, 0);
		}

		// Token: 0x06028799 RID: 165785 RVA: 0x00588EC5 File Offset: 0x005870C5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602879A RID: 165786 RVA: 0x00588ED0 File Offset: 0x005870D0
		public static Offset<IRewardRefreshConfig> EndIRewardRefreshConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRewardRefreshConfig>(builder.EndTable());
		}

		// Token: 0x0602879B RID: 165787 RVA: 0x00588EE0 File Offset: 0x005870E0
		public IRewardRefreshConfigT UnPack()
		{
			IRewardRefreshConfigT rewardRefreshConfigT = new IRewardRefreshConfigT();
			this.UnPackTo(rewardRefreshConfigT);
			return rewardRefreshConfigT;
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x00588EFC File Offset: 0x005870FC
		public void UnPackTo(IRewardRefreshConfigT _o)
		{
			_o.RefreshCondition = new TRefreshConditionUnion();
			_o.RefreshCondition.Type = this.RefreshConditionType;
			TRefreshCondition refreshConditionType = this.RefreshConditionType;
			if (refreshConditionType != TRefreshCondition.IRefreshOnDeath)
			{
				if (refreshConditionType == TRefreshCondition.IRefreshOnHostInteract)
				{
					_o.RefreshCondition.Value = ((this.RefreshCondition<IRefreshOnHostInteract>() != null) ? this.RefreshCondition<IRefreshOnHostInteract>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.RefreshCondition.Value = ((this.RefreshCondition<IRefreshOnDeath>() != null) ? this.RefreshCondition<IRefreshOnDeath>().Value.UnPack() : null);
			}
			_o.RefreshType = new TRefreshRuleUnion();
			_o.RefreshType.Type = this.RefreshTypeType;
			switch (this.RefreshTypeType)
			{
			case TRefreshRule.ICdRefreshRule:
				_o.RefreshType.Value = ((this.RefreshType<ICdRefreshRule>() != null) ? this.RefreshType<ICdRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IFixedDateTimeRefreshRule:
				_o.RefreshType.Value = ((this.RefreshType<IFixedDateTimeRefreshRule>() != null) ? this.RefreshType<IFixedDateTimeRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IRandomNpcRule:
				_o.RefreshType.Value = ((this.RefreshType<IRandomNpcRule>() != null) ? this.RefreshType<IRandomNpcRule>().Value.UnPack() : null);
				break;
			}
			_o.MaxCount = this.MaxCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602879D RID: 165789 RVA: 0x005890A0 File Offset: 0x005872A0
		public static Offset<IRewardRefreshConfig> Pack(FlatBufferBuilder builder, IRewardRefreshConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRewardRefreshConfig>);
			}
			TRefreshCondition refreshCondition_type = (_o.RefreshCondition == null) ? TRefreshCondition.NONE : _o.RefreshCondition.Type;
			int refreshConditionOffset = (_o.RefreshCondition == null) ? 0 : TRefreshConditionUnion.Pack(builder, _o.RefreshCondition);
			TRefreshRule refreshType_type = (_o.RefreshType == null) ? TRefreshRule.NONE : _o.RefreshType.Type;
			int refreshTypeOffset = (_o.RefreshType == null) ? 0 : TRefreshRuleUnion.Pack(builder, _o.RefreshType);
			return IRewardRefreshConfig.CreateIRewardRefreshConfig(builder, refreshCondition_type, refreshConditionOffset, refreshType_type, refreshTypeOffset, _o.MaxCount, _o.NullMask);
		}

		// Token: 0x0400FA9F RID: 64159
		private Table __p;
	}
}

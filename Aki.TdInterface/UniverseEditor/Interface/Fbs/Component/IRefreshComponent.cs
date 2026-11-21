using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1E RID: 24094
	public struct IRefreshComponent : IFlatbufferObject
	{
		// Token: 0x1700B196 RID: 45462
		// (get) Token: 0x060283C7 RID: 164807 RVA: 0x005808DE File Offset: 0x0057EADE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060283C8 RID: 164808 RVA: 0x005808EB File Offset: 0x0057EAEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060283C9 RID: 164809 RVA: 0x005808F4 File Offset: 0x0057EAF4
		public static IRefreshComponent GetRootAsIRefreshComponent(ByteBuffer _bb)
		{
			return IRefreshComponent.GetRootAsIRefreshComponent(_bb, default(IRefreshComponent));
		}

		// Token: 0x060283CA RID: 164810 RVA: 0x00580910 File Offset: 0x0057EB10
		public static IRefreshComponent GetRootAsIRefreshComponent(ByteBuffer _bb, IRefreshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283CB RID: 164811 RVA: 0x0058092D File Offset: 0x0057EB2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283CC RID: 164812 RVA: 0x0058093C File Offset: 0x0057EB3C
		public IRefreshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B197 RID: 45463
		// (get) Token: 0x060283CD RID: 164813 RVA: 0x0058094C File Offset: 0x0057EB4C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B198 RID: 45464
		// (get) Token: 0x060283CE RID: 164814 RVA: 0x0058098C File Offset: 0x0057EB8C
		public TRefreshRule RefreshRuleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRefreshRule.NONE;
				}
				return (TRefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060283CF RID: 164815 RVA: 0x005809C8 File Offset: 0x0057EBC8
		public TTable? RefreshRule<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060283D0 RID: 164816 RVA: 0x00580A0C File Offset: 0x0057EC0C
		public ICdRefreshRule RefreshRuleAsICdRefreshRule()
		{
			return this.RefreshRule<ICdRefreshRule>().Value;
		}

		// Token: 0x060283D1 RID: 164817 RVA: 0x00580A28 File Offset: 0x0057EC28
		public IFixedDateTimeRefreshRule RefreshRuleAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshRule<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x060283D2 RID: 164818 RVA: 0x00580A44 File Offset: 0x0057EC44
		public IRandomNpcRule RefreshRuleAsIRandomNpcRule()
		{
			return this.RefreshRule<IRandomNpcRule>().Value;
		}

		// Token: 0x1700B199 RID: 45465
		// (get) Token: 0x060283D3 RID: 164819 RVA: 0x00580A60 File Offset: 0x0057EC60
		public bool IsDisableRefreshAfterDroppingReward
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B19A RID: 45466
		// (get) Token: 0x060283D4 RID: 164820 RVA: 0x00580AA0 File Offset: 0x0057ECA0
		public bool IsResetOnDungeonRestart
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B19B RID: 45467
		// (get) Token: 0x060283D5 RID: 164821 RVA: 0x00580AE0 File Offset: 0x0057ECE0
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

		// Token: 0x060283D6 RID: 164822 RVA: 0x00580B1D File Offset: 0x0057ED1D
		public static Offset<IRefreshComponent> CreateIRefreshComponent(FlatBufferBuilder builder, bool Disabled = false, TRefreshRule RefreshRule_type = TRefreshRule.NONE, int RefreshRuleOffset = 0, bool IsDisableRefreshAfterDroppingReward = false, bool IsResetOnDungeonRestart = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRefreshComponent.AddRefreshRule(builder, RefreshRuleOffset);
			IRefreshComponent.AddNullMask(builder, NullMask);
			IRefreshComponent.AddIsResetOnDungeonRestart(builder, IsResetOnDungeonRestart);
			IRefreshComponent.AddIsDisableRefreshAfterDroppingReward(builder, IsDisableRefreshAfterDroppingReward);
			IRefreshComponent.AddRefreshRuleType(builder, RefreshRule_type);
			IRefreshComponent.AddDisabled(builder, Disabled);
			return IRefreshComponent.EndIRefreshComponent(builder);
		}

		// Token: 0x060283D7 RID: 164823 RVA: 0x00580B59 File Offset: 0x0057ED59
		public static void StartIRefreshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060283D8 RID: 164824 RVA: 0x00580B62 File Offset: 0x0057ED62
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060283D9 RID: 164825 RVA: 0x00580B6D File Offset: 0x0057ED6D
		public static void AddRefreshRuleType(FlatBufferBuilder builder, TRefreshRule refreshRuleType)
		{
			builder.AddByte(1, (byte)refreshRuleType, 0);
		}

		// Token: 0x060283DA RID: 164826 RVA: 0x00580B78 File Offset: 0x0057ED78
		public static void AddRefreshRule(FlatBufferBuilder builder, int refreshRuleOffset)
		{
			builder.AddOffset(2, refreshRuleOffset, 0);
		}

		// Token: 0x060283DB RID: 164827 RVA: 0x00580B83 File Offset: 0x0057ED83
		public static void AddIsDisableRefreshAfterDroppingReward(FlatBufferBuilder builder, bool isDisableRefreshAfterDroppingReward)
		{
			builder.AddBool(3, isDisableRefreshAfterDroppingReward, false);
		}

		// Token: 0x060283DC RID: 164828 RVA: 0x00580B8E File Offset: 0x0057ED8E
		public static void AddIsResetOnDungeonRestart(FlatBufferBuilder builder, bool isResetOnDungeonRestart)
		{
			builder.AddBool(4, isResetOnDungeonRestart, false);
		}

		// Token: 0x060283DD RID: 164829 RVA: 0x00580B99 File Offset: 0x0057ED99
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060283DE RID: 164830 RVA: 0x00580BA4 File Offset: 0x0057EDA4
		public static Offset<IRefreshComponent> EndIRefreshComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshComponent>(builder.EndTable());
		}

		// Token: 0x060283DF RID: 164831 RVA: 0x00580BB4 File Offset: 0x0057EDB4
		public IRefreshComponentT UnPack()
		{
			IRefreshComponentT refreshComponentT = new IRefreshComponentT();
			this.UnPackTo(refreshComponentT);
			return refreshComponentT;
		}

		// Token: 0x060283E0 RID: 164832 RVA: 0x00580BD0 File Offset: 0x0057EDD0
		public void UnPackTo(IRefreshComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RefreshRule = new TRefreshRuleUnion();
			_o.RefreshRule.Type = this.RefreshRuleType;
			switch (this.RefreshRuleType)
			{
			case TRefreshRule.ICdRefreshRule:
				_o.RefreshRule.Value = ((this.RefreshRule<ICdRefreshRule>() != null) ? this.RefreshRule<ICdRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IFixedDateTimeRefreshRule:
				_o.RefreshRule.Value = ((this.RefreshRule<IFixedDateTimeRefreshRule>() != null) ? this.RefreshRule<IFixedDateTimeRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IRandomNpcRule:
				_o.RefreshRule.Value = ((this.RefreshRule<IRandomNpcRule>() != null) ? this.RefreshRule<IRandomNpcRule>().Value.UnPack() : null);
				break;
			}
			_o.IsDisableRefreshAfterDroppingReward = this.IsDisableRefreshAfterDroppingReward;
			_o.IsResetOnDungeonRestart = this.IsResetOnDungeonRestart;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060283E1 RID: 164833 RVA: 0x00580CF0 File Offset: 0x0057EEF0
		public static Offset<IRefreshComponent> Pack(FlatBufferBuilder builder, IRefreshComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshComponent>);
			}
			TRefreshRule refreshRule_type = (_o.RefreshRule == null) ? TRefreshRule.NONE : _o.RefreshRule.Type;
			int refreshRuleOffset = (_o.RefreshRule == null) ? 0 : TRefreshRuleUnion.Pack(builder, _o.RefreshRule);
			return IRefreshComponent.CreateIRefreshComponent(builder, _o.Disabled, refreshRule_type, refreshRuleOffset, _o.IsDisableRefreshAfterDroppingReward, _o.IsResetOnDungeonRestart, _o.NullMask);
		}

		// Token: 0x0400FA04 RID: 64004
		private Table __p;
	}
}

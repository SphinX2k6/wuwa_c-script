using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005817 RID: 22551
	public struct IRefreshComponent : IFlatbufferObject
	{
		// Token: 0x1700A872 RID: 43122
		// (get) Token: 0x06025EA7 RID: 155303 RVA: 0x0053A752 File Offset: 0x00538952
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025EA8 RID: 155304 RVA: 0x0053A75F File Offset: 0x0053895F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025EA9 RID: 155305 RVA: 0x0053A768 File Offset: 0x00538968
		public static IRefreshComponent GetRootAsIRefreshComponent(ByteBuffer _bb)
		{
			return IRefreshComponent.GetRootAsIRefreshComponent(_bb, default(IRefreshComponent));
		}

		// Token: 0x06025EAA RID: 155306 RVA: 0x0053A784 File Offset: 0x00538984
		public static IRefreshComponent GetRootAsIRefreshComponent(ByteBuffer _bb, IRefreshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025EAB RID: 155307 RVA: 0x0053A7A1 File Offset: 0x005389A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025EAC RID: 155308 RVA: 0x0053A7B0 File Offset: 0x005389B0
		public IRefreshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A873 RID: 43123
		// (get) Token: 0x06025EAD RID: 155309 RVA: 0x0053A7C0 File Offset: 0x005389C0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A874 RID: 43124
		// (get) Token: 0x06025EAE RID: 155310 RVA: 0x0053A800 File Offset: 0x00538A00
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

		// Token: 0x06025EAF RID: 155311 RVA: 0x0053A83C File Offset: 0x00538A3C
		public TTable? RefreshRule<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025EB0 RID: 155312 RVA: 0x0053A880 File Offset: 0x00538A80
		public ICdRefreshRule RefreshRuleAsICdRefreshRule()
		{
			return this.RefreshRule<ICdRefreshRule>().Value;
		}

		// Token: 0x06025EB1 RID: 155313 RVA: 0x0053A89C File Offset: 0x00538A9C
		public IFixedDateTimeRefreshRule RefreshRuleAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshRule<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x06025EB2 RID: 155314 RVA: 0x0053A8B8 File Offset: 0x00538AB8
		public IRandomNpcRule RefreshRuleAsIRandomNpcRule()
		{
			return this.RefreshRule<IRandomNpcRule>().Value;
		}

		// Token: 0x1700A875 RID: 43125
		// (get) Token: 0x06025EB3 RID: 155315 RVA: 0x0053A8D4 File Offset: 0x00538AD4
		public bool IsDisableRefreshAfterDroppingReward
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A876 RID: 43126
		// (get) Token: 0x06025EB4 RID: 155316 RVA: 0x0053A914 File Offset: 0x00538B14
		public bool IsResetOnDungeonRestart
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A877 RID: 43127
		// (get) Token: 0x06025EB5 RID: 155317 RVA: 0x0053A954 File Offset: 0x00538B54
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

		// Token: 0x06025EB6 RID: 155318 RVA: 0x0053A991 File Offset: 0x00538B91
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

		// Token: 0x06025EB7 RID: 155319 RVA: 0x0053A9CD File Offset: 0x00538BCD
		public static void StartIRefreshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025EB8 RID: 155320 RVA: 0x0053A9D6 File Offset: 0x00538BD6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025EB9 RID: 155321 RVA: 0x0053A9E1 File Offset: 0x00538BE1
		public static void AddRefreshRuleType(FlatBufferBuilder builder, TRefreshRule refreshRuleType)
		{
			builder.AddByte(1, (byte)refreshRuleType, 0);
		}

		// Token: 0x06025EBA RID: 155322 RVA: 0x0053A9EC File Offset: 0x00538BEC
		public static void AddRefreshRule(FlatBufferBuilder builder, int refreshRuleOffset)
		{
			builder.AddOffset(2, refreshRuleOffset, 0);
		}

		// Token: 0x06025EBB RID: 155323 RVA: 0x0053A9F7 File Offset: 0x00538BF7
		public static void AddIsDisableRefreshAfterDroppingReward(FlatBufferBuilder builder, bool isDisableRefreshAfterDroppingReward)
		{
			builder.AddBool(3, isDisableRefreshAfterDroppingReward, false);
		}

		// Token: 0x06025EBC RID: 155324 RVA: 0x0053AA02 File Offset: 0x00538C02
		public static void AddIsResetOnDungeonRestart(FlatBufferBuilder builder, bool isResetOnDungeonRestart)
		{
			builder.AddBool(4, isResetOnDungeonRestart, false);
		}

		// Token: 0x06025EBD RID: 155325 RVA: 0x0053AA0D File Offset: 0x00538C0D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025EBE RID: 155326 RVA: 0x0053AA18 File Offset: 0x00538C18
		public static Offset<IRefreshComponent> EndIRefreshComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshComponent>(builder.EndTable());
		}

		// Token: 0x06025EBF RID: 155327 RVA: 0x0053AA28 File Offset: 0x00538C28
		public IRefreshComponentT UnPack()
		{
			IRefreshComponentT refreshComponentT = new IRefreshComponentT();
			this.UnPackTo(refreshComponentT);
			return refreshComponentT;
		}

		// Token: 0x06025EC0 RID: 155328 RVA: 0x0053AA44 File Offset: 0x00538C44
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

		// Token: 0x06025EC1 RID: 155329 RVA: 0x0053AB64 File Offset: 0x00538D64
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

		// Token: 0x0400ED19 RID: 60697
		private Table __p;
	}
}

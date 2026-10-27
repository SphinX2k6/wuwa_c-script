using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017FE RID: 6142
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleSettlement : IDynamicSettlementConfig
	{
		// Token: 0x060083E5 RID: 33765 RVA: 0x0013A9C8 File Offset: 0x00138BC8
		private IBattleSettlement_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleSettlement 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleSettlement_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleSettlement_SetValue());
			}
			return result;
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x0013AA00 File Offset: 0x00138C00
		public static IBattleSettlement Create([Nullable(2)] IBattleSettlement instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleSettlement
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x0013AA13 File Offset: 0x00138C13
		public static IBattleSettlement CreateFromSetValue([Nullable(2)] IBattleSettlement_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleSettlement
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x0013AA26 File Offset: 0x00138C26
		public new IBattleSettlement_SetValue ToSetValue()
		{
			return new IBattleSettlement_SetValue
			{
				Type = this.Type,
				GamePlayCue = this.GamePlayCue,
				BgmType = this.BgmType
			};
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x060083E9 RID: 33769 RVA: 0x0013AA51 File Offset: 0x00138C51
		// (set) Token: 0x060083EA RID: 33770 RVA: 0x0013AA7C File Offset: 0x00138C7C
		public override EDynamicSettlementType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicSettlementType.Battle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x0013AA8C File Offset: 0x00138C8C
		// (set) Token: 0x060083EC RID: 33772 RVA: 0x0013AAC6 File Offset: 0x00138CC6
		public virtual int? GamePlayCue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamePlayCue;
				}
				IBattleSettlement_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamePlayCue;
			}
			set
			{
				this.GetOrCreatePoco().GamePlayCue = value;
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x060083ED RID: 33773 RVA: 0x0013AAD4 File Offset: 0x00138CD4
		// (set) Token: 0x060083EE RID: 33774 RVA: 0x0013AB0E File Offset: 0x00138D0E
		public virtual EBattleSettlementBgmType? BgmType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BgmType;
				}
				IBattleSettlement_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BgmType;
			}
			set
			{
				this.GetOrCreatePoco().BgmType = value;
			}
		}

		// Token: 0x04005397 RID: 21399
		[Nullable(2)]
		protected new IBattleSettlement FbInstance;

		// Token: 0x04005398 RID: 21400
		[Nullable(2)]
		protected new IBattleSettlement_SetValue PocoInterface;
	}
}

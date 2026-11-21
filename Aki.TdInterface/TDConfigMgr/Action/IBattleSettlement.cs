using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001987 RID: 6535
	public class IBattleSettlement : IDynamicSettlementConfig
	{
		// Token: 0x06008B01 RID: 35585 RVA: 0x0014A0B0 File Offset: 0x001482B0
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

		// Token: 0x06008B02 RID: 35586 RVA: 0x0014A0E8 File Offset: 0x001482E8
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

		// Token: 0x06008B03 RID: 35587 RVA: 0x0014A0FB File Offset: 0x001482FB
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

		// Token: 0x06008B04 RID: 35588 RVA: 0x0014A10E File Offset: 0x0014830E
		public new IBattleSettlement_SetValue ToSetValue()
		{
			return new IBattleSettlement_SetValue
			{
				Type = this.Type,
				GamePlayCue = this.GamePlayCue,
				BgmType = this.BgmType
			};
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x06008B05 RID: 35589 RVA: 0x0014A139 File Offset: 0x00148339
		// (set) Token: 0x06008B06 RID: 35590 RVA: 0x0014A164 File Offset: 0x00148364
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

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x06008B07 RID: 35591 RVA: 0x0014A174 File Offset: 0x00148374
		// (set) Token: 0x06008B08 RID: 35592 RVA: 0x0014A1AE File Offset: 0x001483AE
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

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x06008B09 RID: 35593 RVA: 0x0014A1BC File Offset: 0x001483BC
		// (set) Token: 0x06008B0A RID: 35594 RVA: 0x0014A1F6 File Offset: 0x001483F6
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

		// Token: 0x040057DF RID: 22495
		[Nullable(2)]
		protected new IBattleSettlement FbInstance;

		// Token: 0x040057E0 RID: 22496
		[Nullable(2)]
		protected new IBattleSettlement_SetValue PocoInterface;
	}
}

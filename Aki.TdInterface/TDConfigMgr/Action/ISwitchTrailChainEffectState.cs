using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002144 RID: 8516
	public class ISwitchTrailChainEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00194EAC File Offset: 0x001930AC
		private ISwitchTrailChainEffectState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchTrailChainEffectState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchTrailChainEffectState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchTrailChainEffectState_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00194EE4 File Offset: 0x001930E4
		public static ISwitchTrailChainEffectState Create([Nullable(2)] ISwitchTrailChainEffectState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchTrailChainEffectState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x00194EF7 File Offset: 0x001930F7
		public static ISwitchTrailChainEffectState CreateFromSetValue([Nullable(2)] ISwitchTrailChainEffectState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchTrailChainEffectState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x00194F0A File Offset: 0x0019310A
		public new ISwitchTrailChainEffectState_SetValue ToSetValue()
		{
			return new ISwitchTrailChainEffectState_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				Pos = this.Pos
			};
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600B4CC RID: 46284 RVA: 0x00194F35 File Offset: 0x00193135
		// (set) Token: 0x0600B4CD RID: 46285 RVA: 0x00194F60 File Offset: 0x00193160
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600B4CE RID: 46286 RVA: 0x00194F6E File Offset: 0x0019316E
		// (set) Token: 0x0600B4CF RID: 46287 RVA: 0x00194F99 File Offset: 0x00193199
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x00194FA7 File Offset: 0x001931A7
		// (set) Token: 0x0600B4D1 RID: 46289 RVA: 0x00194FCE File Offset: 0x001931CE
		public virtual IBasePos2 Pos
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos;
				}
				ISwitchTrailChainEffectState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pos;
			}
			set
			{
				this.GetOrCreatePoco().Pos = value;
			}
		}

		// Token: 0x04006AF4 RID: 27380
		[Nullable(2)]
		protected new ISwitchTrailChainEffectState FbInstance;

		// Token: 0x04006AF5 RID: 27381
		[Nullable(2)]
		protected new ISwitchTrailChainEffectState_SetValue PocoInterface;
	}
}

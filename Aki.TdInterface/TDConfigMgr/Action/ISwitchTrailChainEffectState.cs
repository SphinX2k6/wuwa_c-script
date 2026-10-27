using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0B RID: 7947
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchTrailChainEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600A9F6 RID: 43510 RVA: 0x0017EEB4 File Offset: 0x0017D0B4
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

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x0017EEEC File Offset: 0x0017D0EC
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

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x0017EEFF File Offset: 0x0017D0FF
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

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x0017EF12 File Offset: 0x0017D112
		public new ISwitchTrailChainEffectState_SetValue ToSetValue()
		{
			return new ISwitchTrailChainEffectState_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				Pos = this.Pos
			};
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A9FA RID: 43514 RVA: 0x0017EF3D File Offset: 0x0017D13D
		// (set) Token: 0x0600A9FB RID: 43515 RVA: 0x0017EF68 File Offset: 0x0017D168
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

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A9FC RID: 43516 RVA: 0x0017EF76 File Offset: 0x0017D176
		// (set) Token: 0x0600A9FD RID: 43517 RVA: 0x0017EFA1 File Offset: 0x0017D1A1
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

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x0017EFAF File Offset: 0x0017D1AF
		// (set) Token: 0x0600A9FF RID: 43519 RVA: 0x0017EFD6 File Offset: 0x0017D1D6
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

		// Token: 0x04006505 RID: 25861
		[Nullable(2)]
		protected new ISwitchTrailChainEffectState FbInstance;

		// Token: 0x04006506 RID: 25862
		[Nullable(2)]
		protected new ISwitchTrailChainEffectState_SetValue PocoInterface;
	}
}

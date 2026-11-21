using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E61 RID: 7777
	public class INpcFollowConfig
	{
		// Token: 0x0600A559 RID: 42329 RVA: 0x00179308 File Offset: 0x00177508
		private INpcFollowConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcFollowConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcFollowConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcFollowConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x00179340 File Offset: 0x00177540
		public static INpcFollowConfig Create([Nullable(2)] INpcFollowConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x00179353 File Offset: 0x00177553
		public static INpcFollowConfig CreateFromSetValue([Nullable(2)] INpcFollowConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x00179366 File Offset: 0x00177566
		public INpcFollowConfig_SetValue ToSetValue()
		{
			return new INpcFollowConfig_SetValue
			{
				PerformerWhenEnter = this.PerformerWhenEnter,
				PerformerWhenExit = this.PerformerWhenExit
			};
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x00179388 File Offset: 0x00177588
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x001793E9 File Offset: 0x001775E9
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenEnter
		{
			get
			{
				if (this._PerformerWhenEnterInited)
				{
					return this._PerformerWhenEnterCache;
				}
				this._PerformerWhenEnterInited = true;
				if (this.FbInstance != null)
				{
					this._PerformerWhenEnterCache = IPerformerRangeBoundaryActionTrigger.Create(this.FbInstance.PerformerWhenEnter);
				}
				else
				{
					INpcFollowConfig_SetValue pocoInterface = this.PocoInterface;
					this._PerformerWhenEnterCache = ((pocoInterface != null) ? pocoInterface.PerformerWhenEnter : null);
				}
				return this._PerformerWhenEnterCache;
			}
			set
			{
				this.GetOrCreatePoco().PerformerWhenEnter = value;
				this._PerformerWhenEnterInited = false;
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x00179400 File Offset: 0x00177600
		// (set) Token: 0x0600A560 RID: 42336 RVA: 0x00179461 File Offset: 0x00177661
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenExit
		{
			get
			{
				if (this._PerformerWhenExitInited)
				{
					return this._PerformerWhenExitCache;
				}
				this._PerformerWhenExitInited = true;
				if (this.FbInstance != null)
				{
					this._PerformerWhenExitCache = IPerformerRangeBoundaryActionTrigger.Create(this.FbInstance.PerformerWhenExit);
				}
				else
				{
					INpcFollowConfig_SetValue pocoInterface = this.PocoInterface;
					this._PerformerWhenExitCache = ((pocoInterface != null) ? pocoInterface.PerformerWhenExit : null);
				}
				return this._PerformerWhenExitCache;
			}
			set
			{
				this.GetOrCreatePoco().PerformerWhenExit = value;
				this._PerformerWhenExitInited = false;
			}
		}

		// Token: 0x040063DE RID: 25566
		[Nullable(2)]
		protected INpcFollowConfig FbInstance;

		// Token: 0x040063DF RID: 25567
		[Nullable(2)]
		protected INpcFollowConfig_SetValue PocoInterface;

		// Token: 0x040063E0 RID: 25568
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenEnterCache;

		// Token: 0x040063E1 RID: 25569
		private bool _PerformerWhenEnterInited;

		// Token: 0x040063E2 RID: 25570
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenExitCache;

		// Token: 0x040063E3 RID: 25571
		private bool _PerformerWhenExitInited;
	}
}

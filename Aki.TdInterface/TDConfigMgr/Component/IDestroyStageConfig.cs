using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002FC RID: 764
	public class IDestroyStageConfig : ILifeStageConfig
	{
		// Token: 0x06000E29 RID: 3625 RVA: 0x0003410C File Offset: 0x0003230C
		private IDestroyStageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroyStageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroyStageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroyStageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00034144 File Offset: 0x00032344
		public static IDestroyStageConfig Create([Nullable(2)] IDestroyStageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyStageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00034157 File Offset: 0x00032357
		public static IDestroyStageConfig CreateFromSetValue([Nullable(2)] IDestroyStageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroyStageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0003416A File Offset: 0x0003236A
		public new IDestroyStageConfig_SetValue ToSetValue()
		{
			return new IDestroyStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration,
				BulletId = this.BulletId,
				Actions = this.Actions
			};
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00034198 File Offset: 0x00032398
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000341D2 File Offset: 0x000323D2
		public override float? PerformDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDuration;
				}
				IDestroyStageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformDuration;
			}
			set
			{
				this.GetOrCreatePoco().PerformDuration = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000341E0 File Offset: 0x000323E0
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0003421A File Offset: 0x0003241A
		public virtual long? BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				IDestroyStageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00034228 File Offset: 0x00032428
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000342BB File Offset: 0x000324BB
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IDestroyStageConfig_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04000CD3 RID: 3283
		[Nullable(2)]
		protected new IDestroyStageConfig FbInstance;

		// Token: 0x04000CD4 RID: 3284
		[Nullable(2)]
		protected new IDestroyStageConfig_SetValue PocoInterface;

		// Token: 0x04000CD5 RID: 3285
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000CD6 RID: 3286
		private bool _ActionsInited;
	}
}

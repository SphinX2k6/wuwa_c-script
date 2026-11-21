using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D6 RID: 726
	public class ICreateStageConfig : ILifeStageConfig
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x00032B34 File Offset: 0x00030D34
		private ICreateStageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreateStageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreateStageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreateStageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00032B6C File Offset: 0x00030D6C
		public static ICreateStageConfig Create([Nullable(2)] ICreateStageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateStageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00032B7F File Offset: 0x00030D7F
		public static ICreateStageConfig CreateFromSetValue([Nullable(2)] ICreateStageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreateStageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00032B92 File Offset: 0x00030D92
		public new ICreateStageConfig_SetValue ToSetValue()
		{
			return new ICreateStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration,
				BulletConfig = this.BulletConfig,
				Actions = this.Actions
			};
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00032BC0 File Offset: 0x00030DC0
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00032BFA File Offset: 0x00030DFA
		public override float? PerformDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDuration;
				}
				ICreateStageConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00032C08 File Offset: 0x00030E08
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00032C69 File Offset: 0x00030E69
		[Nullable(2)]
		public virtual ICreateBulletConfig BulletConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._BulletConfigInited)
				{
					return this._BulletConfigCache;
				}
				this._BulletConfigInited = true;
				if (this.FbInstance != null)
				{
					this._BulletConfigCache = ICreateBulletConfig.Create(this.FbInstance.BulletConfig);
				}
				else
				{
					ICreateStageConfig_SetValue pocoInterface = this.PocoInterface;
					this._BulletConfigCache = ((pocoInterface != null) ? pocoInterface.BulletConfig : null);
				}
				return this._BulletConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BulletConfig = value;
				this._BulletConfigInited = false;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00032C80 File Offset: 0x00030E80
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00032D13 File Offset: 0x00030F13
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
					ICreateStageConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000C7A RID: 3194
		[Nullable(2)]
		protected new ICreateStageConfig FbInstance;

		// Token: 0x04000C7B RID: 3195
		[Nullable(2)]
		protected new ICreateStageConfig_SetValue PocoInterface;

		// Token: 0x04000C7C RID: 3196
		private ICreateBulletConfig _BulletConfigCache;

		// Token: 0x04000C7D RID: 3197
		private bool _BulletConfigInited;

		// Token: 0x04000C7E RID: 3198
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000C7F RID: 3199
		private bool _ActionsInited;
	}
}

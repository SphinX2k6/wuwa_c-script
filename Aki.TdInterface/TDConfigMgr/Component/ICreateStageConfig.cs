using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000293 RID: 659
	[NullableContext(1)]
	[Nullable(0)]
	public class ICreateStageConfig : ILifeStageConfig
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x0002FE44 File Offset: 0x0002E044
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

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002FE7C File Offset: 0x0002E07C
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

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002FE8F File Offset: 0x0002E08F
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

		// Token: 0x06000C4E RID: 3150 RVA: 0x0002FEA2 File Offset: 0x0002E0A2
		public new ICreateStageConfig_SetValue ToSetValue()
		{
			return new ICreateStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration,
				BulletConfig = this.BulletConfig,
				Actions = this.Actions
			};
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0002FED0 File Offset: 0x0002E0D0
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0002FF0A File Offset: 0x0002E10A
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0002FF18 File Offset: 0x0002E118
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x0002FF79 File Offset: 0x0002E179
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0002FF90 File Offset: 0x0002E190
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00030023 File Offset: 0x0002E223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04000B99 RID: 2969
		[Nullable(2)]
		protected new ICreateStageConfig FbInstance;

		// Token: 0x04000B9A RID: 2970
		[Nullable(2)]
		protected new ICreateStageConfig_SetValue PocoInterface;

		// Token: 0x04000B9B RID: 2971
		private ICreateBulletConfig _BulletConfigCache;

		// Token: 0x04000B9C RID: 2972
		private bool _BulletConfigInited;

		// Token: 0x04000B9D RID: 2973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000B9E RID: 2974
		private bool _ActionsInited;
	}
}

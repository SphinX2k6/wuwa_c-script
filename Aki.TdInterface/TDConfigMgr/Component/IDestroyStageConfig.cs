using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B5 RID: 693
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyStageConfig : ILifeStageConfig
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x000311D8 File Offset: 0x0002F3D8
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

		// Token: 0x06000CFA RID: 3322 RVA: 0x00031210 File Offset: 0x0002F410
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

		// Token: 0x06000CFB RID: 3323 RVA: 0x00031223 File Offset: 0x0002F423
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x00031236 File Offset: 0x0002F436
		public new IDestroyStageConfig_SetValue ToSetValue()
		{
			return new IDestroyStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration,
				BulletId = this.BulletId,
				Actions = this.Actions
			};
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00031264 File Offset: 0x0002F464
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x0003129E File Offset: 0x0002F49E
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000312AC File Offset: 0x0002F4AC
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x000312E6 File Offset: 0x0002F4E6
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000312F4 File Offset: 0x0002F4F4
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00031387 File Offset: 0x0002F587
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
					IDestroyStageConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000BE9 RID: 3049
		[Nullable(2)]
		protected new IDestroyStageConfig FbInstance;

		// Token: 0x04000BEA RID: 3050
		[Nullable(2)]
		protected new IDestroyStageConfig_SetValue PocoInterface;

		// Token: 0x04000BEB RID: 3051
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000BEC RID: 3052
		private bool _ActionsInited;
	}
}

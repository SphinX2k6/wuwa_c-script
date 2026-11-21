using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000407 RID: 1031
	public class IFoxJumpInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00041A90 File Offset: 0x0003FC90
		private IFoxJumpInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxJumpInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxJumpInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxJumpInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00041AC8 File Offset: 0x0003FCC8
		public static IFoxJumpInteractPoint Create([Nullable(2)] IFoxJumpInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00041ADB File Offset: 0x0003FCDB
		public static IFoxJumpInteractPoint CreateFromSetValue([Nullable(2)] IFoxJumpInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxJumpInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00041AEE File Offset: 0x0003FCEE
		public new IFoxJumpInteractPoint_SetValue ToSetValue()
		{
			return new IFoxJumpInteractPoint_SetValue
			{
				Type = this.Type,
				LockConfigId = this.LockConfigId,
				Actions = this.Actions,
				PositionConfig = this.PositionConfig
			};
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00041B25 File Offset: 0x0003FD25
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x00041B50 File Offset: 0x0003FD50
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00041B5E File Offset: 0x0003FD5E
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x00041B89 File Offset: 0x0003FD89
		public virtual int LockConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LockConfigId;
			}
			set
			{
				this.GetOrCreatePoco().LockConfigId = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00041B98 File Offset: 0x0003FD98
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x00041C2B File Offset: 0x0003FE2B
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
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
					IFoxJumpInteractPoint_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00041C40 File Offset: 0x0003FE40
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x00041C67 File Offset: 0x0003FE67
		public virtual IFoxJumpInteractPointRelationType PositionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionConfig;
				}
				IFoxJumpInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PositionConfig;
			}
			set
			{
				this.GetOrCreatePoco().PositionConfig = value;
			}
		}

		// Token: 0x0400103E RID: 4158
		[Nullable(2)]
		protected new IFoxJumpInteractPoint FbInstance;

		// Token: 0x0400103F RID: 4159
		[Nullable(2)]
		protected new IFoxJumpInteractPoint_SetValue PocoInterface;

		// Token: 0x04001040 RID: 4160
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001041 RID: 4161
		private bool _ActionsInited;
	}
}

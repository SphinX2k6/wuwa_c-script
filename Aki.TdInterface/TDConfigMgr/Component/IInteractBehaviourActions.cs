using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CD RID: 1229
	public class IInteractBehaviourActions : ILevelAIBehaviourBase
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00049F9C File Offset: 0x0004819C
		private IInteractBehaviourActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractBehaviourActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractBehaviourActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractBehaviourActions_SetValue());
			}
			return result;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00049FD4 File Offset: 0x000481D4
		public static IInteractBehaviourActions Create([Nullable(2)] IInteractBehaviourActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractBehaviourActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00049FE7 File Offset: 0x000481E7
		public static IInteractBehaviourActions CreateFromSetValue([Nullable(2)] IInteractBehaviourActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractBehaviourActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00049FFA File Offset: 0x000481FA
		public new IInteractBehaviourActions_SetValue ToSetValue()
		{
			return new IInteractBehaviourActions_SetValue
			{
				Type = this.Type,
				Actions = this.Actions
			};
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0004A019 File Offset: 0x00048219
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x0004A044 File Offset: 0x00048244
		public override ELevelAIBehaviourType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0004A054 File Offset: 0x00048254
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x0004A0E7 File Offset: 0x000482E7
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
					IInteractBehaviourActions_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400127B RID: 4731
		[Nullable(2)]
		protected new IInteractBehaviourActions FbInstance;

		// Token: 0x0400127C RID: 4732
		[Nullable(2)]
		protected new IInteractBehaviourActions_SetValue PocoInterface;

		// Token: 0x0400127D RID: 4733
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x0400127E RID: 4734
		private bool _ActionsInited;
	}
}

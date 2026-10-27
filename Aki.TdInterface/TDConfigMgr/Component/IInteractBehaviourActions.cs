using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000474 RID: 1140
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractBehaviourActions : ILevelAIBehaviourBase
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x00046254 File Offset: 0x00044454
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

		// Token: 0x060016FA RID: 5882 RVA: 0x0004628C File Offset: 0x0004448C
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

		// Token: 0x060016FB RID: 5883 RVA: 0x0004629F File Offset: 0x0004449F
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

		// Token: 0x060016FC RID: 5884 RVA: 0x000462B2 File Offset: 0x000444B2
		public new IInteractBehaviourActions_SetValue ToSetValue()
		{
			return new IInteractBehaviourActions_SetValue
			{
				Type = this.Type,
				Actions = this.Actions
			};
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000462D1 File Offset: 0x000444D1
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x000462FC File Offset: 0x000444FC
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0004630C File Offset: 0x0004450C
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0004639F File Offset: 0x0004459F
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

		// Token: 0x04001159 RID: 4441
		[Nullable(2)]
		protected new IInteractBehaviourActions FbInstance;

		// Token: 0x0400115A RID: 4442
		[Nullable(2)]
		protected new IInteractBehaviourActions_SetValue PocoInterface;

		// Token: 0x0400115B RID: 4443
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x0400115C RID: 4444
		private bool _ActionsInited;
	}
}

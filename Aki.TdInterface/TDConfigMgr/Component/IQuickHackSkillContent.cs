using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006DF RID: 1759
	public class IQuickHackSkillContent
	{
		// Token: 0x0600253E RID: 9534 RVA: 0x00064F20 File Offset: 0x00063120
		private IQuickHackSkillContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuickHackSkillContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuickHackSkillContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuickHackSkillContent_SetValue());
			}
			return result;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00064F58 File Offset: 0x00063158
		public static IQuickHackSkillContent Create([Nullable(2)] IQuickHackSkillContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuickHackSkillContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00064F6B File Offset: 0x0006316B
		public static IQuickHackSkillContent CreateFromSetValue([Nullable(2)] IQuickHackSkillContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuickHackSkillContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00064F7E File Offset: 0x0006317E
		public IQuickHackSkillContent_SetValue ToSetValue()
		{
			return new IQuickHackSkillContent_SetValue
			{
				EntityState = this.EntityState,
				Actions = this.Actions
			};
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x00064F9D File Offset: 0x0006319D
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x00064FC8 File Offset: 0x000631C8
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x00064FD8 File Offset: 0x000631D8
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x0006506B File Offset: 0x0006326B
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
					IQuickHackSkillContent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040019B8 RID: 6584
		[Nullable(2)]
		protected IQuickHackSkillContent FbInstance;

		// Token: 0x040019B9 RID: 6585
		[Nullable(2)]
		protected IQuickHackSkillContent_SetValue PocoInterface;

		// Token: 0x040019BA RID: 6586
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040019BB RID: 6587
		private bool _ActionsInited;
	}
}

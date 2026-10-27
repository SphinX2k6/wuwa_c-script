using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000642 RID: 1602
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuickHackSkillContent
	{
		// Token: 0x06002238 RID: 8760 RVA: 0x0005E20C File Offset: 0x0005C40C
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

		// Token: 0x06002239 RID: 8761 RVA: 0x0005E244 File Offset: 0x0005C444
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

		// Token: 0x0600223A RID: 8762 RVA: 0x0005E257 File Offset: 0x0005C457
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

		// Token: 0x0600223B RID: 8763 RVA: 0x0005E26A File Offset: 0x0005C46A
		public IQuickHackSkillContent_SetValue ToSetValue()
		{
			return new IQuickHackSkillContent_SetValue
			{
				EntityState = this.EntityState,
				Actions = this.Actions
			};
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0005E289 File Offset: 0x0005C489
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0005E2C4 File Offset: 0x0005C4C4
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x0005E357 File Offset: 0x0005C557
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

		// Token: 0x040017C6 RID: 6086
		[Nullable(2)]
		protected IQuickHackSkillContent FbInstance;

		// Token: 0x040017C7 RID: 6087
		[Nullable(2)]
		protected IQuickHackSkillContent_SetValue PocoInterface;

		// Token: 0x040017C8 RID: 6088
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040017C9 RID: 6089
		private bool _ActionsInited;
	}
}

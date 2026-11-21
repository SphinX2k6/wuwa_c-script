using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039F RID: 927
	public class IExploreSkillPullGiant : IExploreSkillInteractType
	{
		// Token: 0x06001237 RID: 4663 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		private IExploreSkillPullGiant_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillPullGiant 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillPullGiant_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillPullGiant_SetValue());
			}
			return result;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
		public static IExploreSkillPullGiant Create([Nullable(2)] IExploreSkillPullGiant instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillPullGiant
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0003D3F3 File Offset: 0x0003B5F3
		public static IExploreSkillPullGiant CreateFromSetValue([Nullable(2)] IExploreSkillPullGiant_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillPullGiant
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0003D406 File Offset: 0x0003B606
		public new IExploreSkillPullGiant_SetValue ToSetValue()
		{
			return new IExploreSkillPullGiant_SetValue
			{
				Type = this.Type,
				PullTime = this.PullTime,
				Actions = this.Actions
			};
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x0003D431 File Offset: 0x0003B631
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x0003D45C File Offset: 0x0003B65C
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

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0003D46A File Offset: 0x0003B66A
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x0003D499 File Offset: 0x0003B699
		public virtual float PullTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PullTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PullTime;
			}
			set
			{
				this.GetOrCreatePoco().PullTime = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x0003D53B File Offset: 0x0003B73B
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
					IExploreSkillPullGiant_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000F12 RID: 3858
		[Nullable(2)]
		protected new IExploreSkillPullGiant FbInstance;

		// Token: 0x04000F13 RID: 3859
		[Nullable(2)]
		protected new IExploreSkillPullGiant_SetValue PocoInterface;

		// Token: 0x04000F14 RID: 3860
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000F15 RID: 3861
		private bool _ActionsInited;
	}
}

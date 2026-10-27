using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000356 RID: 854
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillPullGiant : IExploreSkillInteractType
	{
		// Token: 0x060010F3 RID: 4339 RVA: 0x0003A0C4 File Offset: 0x000382C4
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

		// Token: 0x060010F4 RID: 4340 RVA: 0x0003A0FC File Offset: 0x000382FC
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

		// Token: 0x060010F5 RID: 4341 RVA: 0x0003A10F File Offset: 0x0003830F
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

		// Token: 0x060010F6 RID: 4342 RVA: 0x0003A122 File Offset: 0x00038322
		public new IExploreSkillPullGiant_SetValue ToSetValue()
		{
			return new IExploreSkillPullGiant_SetValue
			{
				Type = this.Type,
				PullTime = this.PullTime,
				Actions = this.Actions
			};
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0003A14D File Offset: 0x0003834D
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0003A178 File Offset: 0x00038378
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0003A186 File Offset: 0x00038386
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0003A1B5 File Offset: 0x000383B5
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0003A1C4 File Offset: 0x000383C4
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0003A257 File Offset: 0x00038457
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

		// Token: 0x04000E1B RID: 3611
		[Nullable(2)]
		protected new IExploreSkillPullGiant FbInstance;

		// Token: 0x04000E1C RID: 3612
		[Nullable(2)]
		protected new IExploreSkillPullGiant_SetValue PocoInterface;

		// Token: 0x04000E1D RID: 3613
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000E1E RID: 3614
		private bool _ActionsInited;
	}
}

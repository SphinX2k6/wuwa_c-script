using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200035A RID: 858
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillQuantumDiffusion : IExploreSkillInteractType
	{
		// Token: 0x0600110B RID: 4363 RVA: 0x0003A400 File Offset: 0x00038600
		private IExploreSkillQuantumDiffusion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillQuantumDiffusion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillQuantumDiffusion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillQuantumDiffusion_SetValue());
			}
			return result;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0003A438 File Offset: 0x00038638
		public static IExploreSkillQuantumDiffusion Create([Nullable(2)] IExploreSkillQuantumDiffusion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillQuantumDiffusion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0003A44B File Offset: 0x0003864B
		public static IExploreSkillQuantumDiffusion CreateFromSetValue([Nullable(2)] IExploreSkillQuantumDiffusion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillQuantumDiffusion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0003A45E File Offset: 0x0003865E
		public new IExploreSkillQuantumDiffusion_SetValue ToSetValue()
		{
			return new IExploreSkillQuantumDiffusion_SetValue
			{
				Type = this.Type,
				NeedFollowShooter = this.NeedFollowShooter,
				Actions = this.Actions
			};
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0003A489 File Offset: 0x00038689
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0003A4B4 File Offset: 0x000386B4
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0003A4C4 File Offset: 0x000386C4
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0003A4FE File Offset: 0x000386FE
		public virtual bool? NeedFollowShooter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NeedFollowShooter;
				}
				IExploreSkillQuantumDiffusion_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NeedFollowShooter;
			}
			set
			{
				this.GetOrCreatePoco().NeedFollowShooter = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0003A50C File Offset: 0x0003870C
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0003A59F File Offset: 0x0003879F
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
					IExploreSkillQuantumDiffusion_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000E29 RID: 3625
		[Nullable(2)]
		protected new IExploreSkillQuantumDiffusion FbInstance;

		// Token: 0x04000E2A RID: 3626
		[Nullable(2)]
		protected new IExploreSkillQuantumDiffusion_SetValue PocoInterface;

		// Token: 0x04000E2B RID: 3627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000E2C RID: 3628
		private bool _ActionsInited;
	}
}

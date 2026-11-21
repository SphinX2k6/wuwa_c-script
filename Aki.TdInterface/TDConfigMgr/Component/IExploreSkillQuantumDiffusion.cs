using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A3 RID: 931
	public class IExploreSkillQuantumDiffusion : IExploreSkillInteractType
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
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

		// Token: 0x06001250 RID: 4688 RVA: 0x0003D71C File Offset: 0x0003B91C
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

		// Token: 0x06001251 RID: 4689 RVA: 0x0003D72F File Offset: 0x0003B92F
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

		// Token: 0x06001252 RID: 4690 RVA: 0x0003D742 File Offset: 0x0003B942
		public new IExploreSkillQuantumDiffusion_SetValue ToSetValue()
		{
			return new IExploreSkillQuantumDiffusion_SetValue
			{
				Type = this.Type,
				NeedFollowShooter = this.NeedFollowShooter,
				Actions = this.Actions
			};
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0003D76D File Offset: 0x0003B96D
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x0003D798 File Offset: 0x0003B998
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0003D7A8 File Offset: 0x0003B9A8
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x0003D7E2 File Offset: 0x0003B9E2
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0003D7F0 File Offset: 0x0003B9F0
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x0003D883 File Offset: 0x0003BA83
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04000F20 RID: 3872
		[Nullable(2)]
		protected new IExploreSkillQuantumDiffusion FbInstance;

		// Token: 0x04000F21 RID: 3873
		[Nullable(2)]
		protected new IExploreSkillQuantumDiffusion_SetValue PocoInterface;

		// Token: 0x04000F22 RID: 3874
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000F23 RID: 3875
		private bool _ActionsInited;
	}
}

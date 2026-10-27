using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB4 RID: 3252
	public class IExploreSkillQuantumDiffusion : IExploreSkillInteractType
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x000BA329 File Offset: 0x000B8529
		[NullableContext(1)]
		public static IExploreSkillQuantumDiffusion Create(IExploreSkillQuantumDiffusion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillQuantumDiffusion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06004A67 RID: 19047 RVA: 0x000BA348 File Offset: 0x000B8548
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06004A68 RID: 19048 RVA: 0x000BA358 File Offset: 0x000B8558
		public virtual bool? NeedFollowShooter
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NeedFollowShooter);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06004A69 RID: 19049 RVA: 0x000BA390 File Offset: 0x000B8590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002A73 RID: 10867
		private IExploreSkillQuantumDiffusion Instance;

		// Token: 0x04002A74 RID: 10868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A75 RID: 10869
		private bool _ActionsInited;
	}
}

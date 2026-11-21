using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D96 RID: 3478
	public class IExploreSkillQuantumDiffusion : IExploreSkillInteractType
	{
		// Token: 0x06004F14 RID: 20244 RVA: 0x000C4D39 File Offset: 0x000C2F39
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

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x000C4D58 File Offset: 0x000C2F58
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004F16 RID: 20246 RVA: 0x000C4D68 File Offset: 0x000C2F68
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x000C4DA0 File Offset: 0x000C2FA0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
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

		// Token: 0x04002CED RID: 11501
		private IExploreSkillQuantumDiffusion Instance;

		// Token: 0x04002CEE RID: 11502
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002CEF RID: 11503
		private bool _ActionsInited;
	}
}

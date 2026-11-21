using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D90 RID: 3472
	public class IExploreSkillPullGiant : IExploreSkillInteractType
	{
		// Token: 0x06004EFC RID: 20220 RVA: 0x000C4AD7 File Offset: 0x000C2CD7
		public static IExploreSkillPullGiant Create(IExploreSkillPullGiant? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillPullGiant
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x000C4AF6 File Offset: 0x000C2CF6
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x000C4B03 File Offset: 0x000C2D03
		public virtual float PullTime
		{
			get
			{
				return this.Instance.PullTime;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x000C4B10 File Offset: 0x000C2D10
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002CE1 RID: 11489
		private IExploreSkillPullGiant Instance;

		// Token: 0x04002CE2 RID: 11490
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002CE3 RID: 11491
		private bool _ActionsInited;
	}
}

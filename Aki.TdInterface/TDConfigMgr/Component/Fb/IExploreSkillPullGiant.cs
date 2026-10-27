using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAE RID: 3246
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillPullGiant : IExploreSkillInteractType
	{
		// Token: 0x06004A4E RID: 19022 RVA: 0x000BA0C7 File Offset: 0x000B82C7
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

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x000BA0E6 File Offset: 0x000B82E6
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x000BA0F3 File Offset: 0x000B82F3
		public virtual float PullTime
		{
			get
			{
				return this.Instance.PullTime;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x000BA100 File Offset: 0x000B8300
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

		// Token: 0x04002A67 RID: 10855
		private IExploreSkillPullGiant Instance;

		// Token: 0x04002A68 RID: 10856
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A69 RID: 10857
		private bool _ActionsInited;
	}
}

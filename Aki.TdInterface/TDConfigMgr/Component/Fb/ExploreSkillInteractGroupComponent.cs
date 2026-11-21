using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAE RID: 3502
	public class ExploreSkillInteractGroupComponent : IComponentBase
	{
		// Token: 0x06004F9A RID: 20378 RVA: 0x000C61DD File Offset: 0x000C43DD
		public static ExploreSkillInteractGroupComponent Create(IExploreSkillInteractGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExploreSkillInteractGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x000C61FC File Offset: 0x000C43FC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x000C6234 File Offset: 0x000C4434
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x000C624C File Offset: 0x000C444C
		public virtual List<IExploreSkillInteract> ExploreSkillInteractList
		{
			get
			{
				if (this._ExploreSkillInteractListInited)
				{
					return this._ExploreSkillInteractListCache;
				}
				this._ExploreSkillInteractListInited = true;
				int exploreSkillInteractListLength = this.Instance.ExploreSkillInteractListLength;
				this._ExploreSkillInteractListCache = new List<IExploreSkillInteract>(exploreSkillInteractListLength);
				for (int i = 0; i < exploreSkillInteractListLength; i++)
				{
					this._ExploreSkillInteractListCache.Add(IExploreSkillInteract.Create(this.Instance.ExploreSkillInteractList(i)));
				}
				return this._ExploreSkillInteractListCache;
			}
		}

		// Token: 0x04002D63 RID: 11619
		private IExploreSkillInteractGroupComponent Instance;

		// Token: 0x04002D64 RID: 11620
		private List<IExploreSkillInteract> _ExploreSkillInteractListCache;

		// Token: 0x04002D65 RID: 11621
		private bool _ExploreSkillInteractListInited;
	}
}

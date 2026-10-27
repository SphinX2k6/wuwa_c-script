using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCA RID: 3274
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreSkillInteractGroupComponent : IComponentBase
	{
		// Token: 0x06004ADF RID: 19167 RVA: 0x000BB5A5 File Offset: 0x000B97A5
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

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x000BB5C4 File Offset: 0x000B97C4
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

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x000BB5FC File Offset: 0x000B97FC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x000BB614 File Offset: 0x000B9814
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

		// Token: 0x04002ADD RID: 10973
		private IExploreSkillInteractGroupComponent Instance;

		// Token: 0x04002ADE RID: 10974
		private List<IExploreSkillInteract> _ExploreSkillInteractListCache;

		// Token: 0x04002ADF RID: 10975
		private bool _ExploreSkillInteractListInited;
	}
}

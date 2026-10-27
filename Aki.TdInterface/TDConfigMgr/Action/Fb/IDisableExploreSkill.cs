using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002944 RID: 10564
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableExploreSkill
	{
		// Token: 0x0600EA46 RID: 59974 RVA: 0x00224E57 File Offset: 0x00223057
		[NullableContext(1)]
		public static IDisableExploreSkill Create(IDisableExploreSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableExploreSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x00224E78 File Offset: 0x00223078
		public virtual bool? PlaceTemporaryTeleport
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PlaceTemporaryTeleport);
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x0600EA48 RID: 59976 RVA: 0x00224EB0 File Offset: 0x002230B0
		public virtual bool? IsComplementary
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsComplementary);
			}
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x00224EE8 File Offset: 0x002230E8
		public virtual List<EExploreSkillType> ExploreSkillList
		{
			get
			{
				if (this._ExploreSkillListInited)
				{
					return this._ExploreSkillListCache;
				}
				this._ExploreSkillListInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int exploreSkillListLength = this.Instance.ExploreSkillListLength;
				this._ExploreSkillListCache = new List<EExploreSkillType>(exploreSkillListLength);
				for (int i = 0; i < exploreSkillListLength; i++)
				{
					this._ExploreSkillListCache.Add((EExploreSkillType)this.Instance.ExploreSkillList(i));
				}
				return this._ExploreSkillListCache;
			}
		}

		// Token: 0x0400812C RID: 33068
		private IDisableExploreSkill Instance;

		// Token: 0x0400812D RID: 33069
		private List<EExploreSkillType> _ExploreSkillListCache;

		// Token: 0x0400812E RID: 33070
		private bool _ExploreSkillListInited;
	}
}

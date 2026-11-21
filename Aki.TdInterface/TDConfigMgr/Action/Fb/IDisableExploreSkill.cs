using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C26 RID: 11302
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableExploreSkill
	{
		// Token: 0x0600F8B1 RID: 63665 RVA: 0x00242437 File Offset: 0x00240637
		[NullableContext(0)]
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

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x0600F8B2 RID: 63666 RVA: 0x00242458 File Offset: 0x00240658
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

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x0600F8B3 RID: 63667 RVA: 0x00242490 File Offset: 0x00240690
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

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x0600F8B4 RID: 63668 RVA: 0x002424C8 File Offset: 0x002406C8
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

		// Token: 0x04008808 RID: 34824
		private IDisableExploreSkill Instance;

		// Token: 0x04008809 RID: 34825
		private List<EExploreSkillType> _ExploreSkillListCache;

		// Token: 0x0400880A RID: 34826
		private bool _ExploreSkillListInited;
	}
}

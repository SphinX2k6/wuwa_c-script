using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2A RID: 11306
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableSectionalSkillOperation : ISkillOperationType
	{
		// Token: 0x0600F8CE RID: 63694 RVA: 0x00242992 File Offset: 0x00240B92
		[NullableContext(0)]
		public static IDisableSectionalSkillOperation Create(IDisableSectionalSkillOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSectionalSkillOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x0600F8CF RID: 63695 RVA: 0x002429B1 File Offset: 0x00240BB1
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x002429C0 File Offset: 0x00240BC0
		public virtual EDisplayModeInSkillOp? DisplayMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EDisplayModeInSkillOp?((EDisplayModeInSkillOp)this.Instance.DisplayMode);
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x0600F8D1 RID: 63697 RVA: 0x002429F6 File Offset: 0x00240BF6
		public virtual IDisableExploreSkill DisableExploreSkill
		{
			get
			{
				if (this._DisableExploreSkillInited)
				{
					return this._DisableExploreSkillCache;
				}
				this._DisableExploreSkillInited = true;
				this._DisableExploreSkillCache = IDisableExploreSkill.Create(this.Instance.DisableExploreSkill);
				return this._DisableExploreSkillCache;
			}
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x0600F8D2 RID: 63698 RVA: 0x00242A2C File Offset: 0x00240C2C
		public virtual bool? DisableSkillWheel
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSkillWheel);
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x0600F8D3 RID: 63699 RVA: 0x00242A62 File Offset: 0x00240C62
		public virtual IDisableBattleSkillOptions DisableBattleSkill
		{
			get
			{
				if (this._DisableBattleSkillInited)
				{
					return this._DisableBattleSkillCache;
				}
				this._DisableBattleSkillInited = true;
				this._DisableBattleSkillCache = IDisableBattleSkillOptions.Create(this.Instance.DisableBattleSkill);
				return this._DisableBattleSkillCache;
			}
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x0600F8D4 RID: 63700 RVA: 0x00242A98 File Offset: 0x00240C98
		public virtual bool? DisableSwitchRole
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSwitchRole);
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x0600F8D5 RID: 63701 RVA: 0x00242AD0 File Offset: 0x00240CD0
		public virtual ETeamDisplayModeInSkillOp? TeamDisplayMode
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new ETeamDisplayModeInSkillOp?((ETeamDisplayModeInSkillOp)this.Instance.TeamDisplayMode);
			}
		}

		// Token: 0x04008810 RID: 34832
		private IDisableSectionalSkillOperation Instance;

		// Token: 0x04008811 RID: 34833
		private IDisableExploreSkill _DisableExploreSkillCache;

		// Token: 0x04008812 RID: 34834
		private bool _DisableExploreSkillInited;

		// Token: 0x04008813 RID: 34835
		private IDisableBattleSkillOptions _DisableBattleSkillCache;

		// Token: 0x04008814 RID: 34836
		private bool _DisableBattleSkillInited;
	}
}

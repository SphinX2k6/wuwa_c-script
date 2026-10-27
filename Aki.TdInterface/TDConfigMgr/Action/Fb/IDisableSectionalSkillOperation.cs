using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002948 RID: 10568
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableSectionalSkillOperation : ISkillOperationType
	{
		// Token: 0x0600EA63 RID: 60003 RVA: 0x002253B2 File Offset: 0x002235B2
		[NullableContext(1)]
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

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x0600EA64 RID: 60004 RVA: 0x002253D1 File Offset: 0x002235D1
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x0600EA65 RID: 60005 RVA: 0x002253E0 File Offset: 0x002235E0
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

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x00225416 File Offset: 0x00223616
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

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x0022544C File Offset: 0x0022364C
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

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x00225482 File Offset: 0x00223682
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

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x002254B8 File Offset: 0x002236B8
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

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x002254F0 File Offset: 0x002236F0
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

		// Token: 0x04008134 RID: 33076
		private IDisableSectionalSkillOperation Instance;

		// Token: 0x04008135 RID: 33077
		private IDisableExploreSkill _DisableExploreSkillCache;

		// Token: 0x04008136 RID: 33078
		private bool _DisableExploreSkillInited;

		// Token: 0x04008137 RID: 33079
		private IDisableBattleSkillOptions _DisableBattleSkillCache;

		// Token: 0x04008138 RID: 33080
		private bool _DisableBattleSkillInited;
	}
}

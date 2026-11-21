using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B73 RID: 11123
	public class ISwitchSeason : IClientSetSeasonStateConfig
	{
		// Token: 0x0600F460 RID: 62560 RVA: 0x0023A339 File Offset: 0x00238539
		public static ISwitchSeason Create(ISwitchSeason? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchSeason
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x0600F461 RID: 62561 RVA: 0x0023A358 File Offset: 0x00238558
		public override EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x0600F462 RID: 62562 RVA: 0x0023A365 File Offset: 0x00238565
		public virtual ESeason Season
		{
			get
			{
				return (ESeason)this.Instance.Season;
			}
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x0600F463 RID: 62563 RVA: 0x0023A372 File Offset: 0x00238572
		public virtual float TransitionSpeed
		{
			get
			{
				return this.Instance.TransitionSpeed;
			}
		}

		// Token: 0x04008603 RID: 34307
		private ISwitchSeason Instance;
	}
}

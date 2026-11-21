using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDC RID: 11484
	public class IDisableAlertAreaDungeonCondition : IDisableAlertAreaCondition
	{
		// Token: 0x0600FB9C RID: 64412 RVA: 0x00246F4D File Offset: 0x0024514D
		public static IDisableAlertAreaDungeonCondition Create(IDisableAlertAreaDungeonCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaDungeonCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x0600FB9D RID: 64413 RVA: 0x00246F6C File Offset: 0x0024516C
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x0600FB9E RID: 64414 RVA: 0x00246F79 File Offset: 0x00245179
		public virtual int RelatedDungeonId
		{
			get
			{
				return this.Instance.RelatedDungeonId;
			}
		}

		// Token: 0x04008978 RID: 35192
		private IDisableAlertAreaDungeonCondition Instance;
	}
}

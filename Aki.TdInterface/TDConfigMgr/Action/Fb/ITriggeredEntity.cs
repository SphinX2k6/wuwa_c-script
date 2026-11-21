using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8F RID: 10895
	public class ITriggeredEntity : ITargetEntityType
	{
		// Token: 0x0600F06B RID: 61547 RVA: 0x00233B07 File Offset: 0x00231D07
		public static ITriggeredEntity Create(ITriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x00233B26 File Offset: 0x00231D26
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04008433 RID: 33843
		private ITriggeredEntity Instance;
	}
}

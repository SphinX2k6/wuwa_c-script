using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0C RID: 3084
	public class IOnThrowTriggerTimeCondition : IBulletCreateCondition
	{
		// Token: 0x060046BB RID: 18107 RVA: 0x000B3E8C File Offset: 0x000B208C
		public static IOnThrowTriggerTimeCondition Create(IOnThrowTriggerTimeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnThrowTriggerTimeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x000B3EAB File Offset: 0x000B20AB
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x000B3EB8 File Offset: 0x000B20B8
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x000B3EC5 File Offset: 0x000B20C5
		public virtual float TriggerTime
		{
			get
			{
				return this.Instance.TriggerTime;
			}
		}

		// Token: 0x040027B1 RID: 10161
		private IOnThrowTriggerTimeCondition Instance;
	}
}

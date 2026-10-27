using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3E RID: 2878
	public class IOnThrowTriggerTimeCondition : IBulletCreateCondition
	{
		// Token: 0x06004262 RID: 16994 RVA: 0x000A9DC8 File Offset: 0x000A7FC8
		[NullableContext(1)]
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

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x000A9DE7 File Offset: 0x000A7FE7
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x000A9DF4 File Offset: 0x000A7FF4
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x000A9E01 File Offset: 0x000A8001
		public virtual float TriggerTime
		{
			get
			{
				return this.Instance.TriggerTime;
			}
		}

		// Token: 0x04002569 RID: 9577
		private IOnThrowTriggerTimeCondition Instance;
	}
}

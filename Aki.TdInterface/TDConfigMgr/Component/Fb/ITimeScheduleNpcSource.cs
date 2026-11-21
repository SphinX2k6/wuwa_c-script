using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED7 RID: 3799
	public class ITimeScheduleNpcSource
	{
		// Token: 0x0600559B RID: 21915 RVA: 0x000D24CD File Offset: 0x000D06CD
		public static ITimeScheduleNpcSource Create(ITimeScheduleNpcSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleNpcSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x0600559C RID: 21916 RVA: 0x000D24EC File Offset: 0x000D06EC
		public virtual ETimeScheduleNpcSourceType Type
		{
			get
			{
				return (ETimeScheduleNpcSourceType)this.Instance.Type;
			}
		}

		// Token: 0x040030FA RID: 12538
		private ITimeScheduleNpcSource Instance;
	}
}

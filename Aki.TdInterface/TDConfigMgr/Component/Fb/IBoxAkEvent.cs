using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA5 RID: 2981
	public class IBoxAkEvent : IAkEventTypeConfig
	{
		// Token: 0x0600442D RID: 17453 RVA: 0x000ACFAA File Offset: 0x000AB1AA
		public static IBoxAkEvent Create(IBoxAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x000ACFC9 File Offset: 0x000AB1C9
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x000ACFD6 File Offset: 0x000AB1D6
		public virtual EAudioType AudioType
		{
			get
			{
				return (EAudioType)this.Instance.AudioType;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x000ACFE3 File Offset: 0x000AB1E3
		public virtual int Priority
		{
			get
			{
				return this.Instance.Priority;
			}
		}

		// Token: 0x040025BE RID: 9662
		private IBoxAkEvent Instance;
	}
}

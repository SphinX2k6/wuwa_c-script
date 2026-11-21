using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA6 RID: 2982
	public class IDefaultAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06004432 RID: 17458 RVA: 0x000ACFF8 File Offset: 0x000AB1F8
		public static IDefaultAkEvent Create(IDefaultAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x000AD017 File Offset: 0x000AB217
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x040025BF RID: 9663
		private IDefaultAkEvent Instance;
	}
}

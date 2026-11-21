using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEF RID: 10991
	public class IPostAkEventType
	{
		// Token: 0x0600F1EA RID: 61930 RVA: 0x00235CAC File Offset: 0x00233EAC
		public static IPostAkEventType Create(IPostAkEventType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x0600F1EB RID: 61931 RVA: 0x00235CCB File Offset: 0x00233ECB
		public virtual EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x040084D1 RID: 34001
		private IPostAkEventType Instance;
	}
}

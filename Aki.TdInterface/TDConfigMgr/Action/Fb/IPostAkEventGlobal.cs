using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF1 RID: 10993
	public class IPostAkEventGlobal : IPostAkEventType
	{
		// Token: 0x0600F1F2 RID: 61938 RVA: 0x00235D2E File Offset: 0x00233F2E
		public static IPostAkEventGlobal Create(IPostAkEventGlobal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventGlobal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x0600F1F3 RID: 61939 RVA: 0x00235D4D File Offset: 0x00233F4D
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x0600F1F4 RID: 61940 RVA: 0x00235D5A File Offset: 0x00233F5A
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x040084D3 RID: 34003
		private IPostAkEventGlobal Instance;
	}
}

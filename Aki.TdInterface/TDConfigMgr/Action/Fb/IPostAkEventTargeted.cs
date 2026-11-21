using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF0 RID: 10992
	public class IPostAkEventTargeted : IPostAkEventType
	{
		// Token: 0x0600F1ED RID: 61933 RVA: 0x00235CE0 File Offset: 0x00233EE0
		public static IPostAkEventTargeted Create(IPostAkEventTargeted? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventTargeted
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x0600F1EE RID: 61934 RVA: 0x00235CFF File Offset: 0x00233EFF
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x0600F1EF RID: 61935 RVA: 0x00235D0C File Offset: 0x00233F0C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x00235D19 File Offset: 0x00233F19
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x040084D2 RID: 34002
		private IPostAkEventTargeted Instance;
	}
}

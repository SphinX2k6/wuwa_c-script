using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF4 RID: 10996
	public class IPostAkEventMap : IPostAkEventType
	{
		// Token: 0x0600F1FC RID: 61948 RVA: 0x00235DD7 File Offset: 0x00233FD7
		public static IPostAkEventMap Create(IPostAkEventMap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventMap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x0600F1FD RID: 61949 RVA: 0x00235DF6 File Offset: 0x00233FF6
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x00235E03 File Offset: 0x00234003
		public virtual IPlayMapMusic MapEventType
		{
			get
			{
				if (this._MapEventTypeInited)
				{
					return this._MapEventTypeCache;
				}
				this._MapEventTypeInited = true;
				this._MapEventTypeCache = IPlayMapMusic.Create(this.Instance.MapEventType);
				return this._MapEventTypeCache;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x00235E37 File Offset: 0x00234037
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x040084D6 RID: 34006
		private IPostAkEventMap Instance;

		// Token: 0x040084D7 RID: 34007
		[Nullable(2)]
		private IPlayMapMusic _MapEventTypeCache;

		// Token: 0x040084D8 RID: 34008
		private bool _MapEventTypeInited;
	}
}

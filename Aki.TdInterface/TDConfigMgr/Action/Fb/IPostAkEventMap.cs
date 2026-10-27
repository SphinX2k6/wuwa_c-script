using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002821 RID: 10273
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventMap : IPostAkEventType
	{
		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00218F73 File Offset: 0x00217173
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

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x00218F92 File Offset: 0x00217192
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x00218F9F File Offset: 0x0021719F
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

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x00218FD3 File Offset: 0x002171D3
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04007E19 RID: 32281
		private IPostAkEventMap Instance;

		// Token: 0x04007E1A RID: 32282
		[Nullable(2)]
		private IPlayMapMusic _MapEventTypeCache;

		// Token: 0x04007E1B RID: 32283
		private bool _MapEventTypeInited;
	}
}

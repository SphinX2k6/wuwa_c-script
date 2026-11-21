using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A88 RID: 10888
	[NullableContext(2)]
	[Nullable(0)]
	public class AddGuestCharacter : ActionParams
	{
		// Token: 0x0600F051 RID: 61521 RVA: 0x002338DE File Offset: 0x00231ADE
		[NullableContext(0)]
		public static AddGuestCharacter Create(IAddGuestCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddGuestCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x0600F052 RID: 61522 RVA: 0x002338FD File Offset: 0x00231AFD
		public virtual int GuestCharacterId
		{
			get
			{
				return this.Instance.GuestCharacterId;
			}
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x0600F053 RID: 61523 RVA: 0x0023390A File Offset: 0x00231B0A
		public virtual IActiveRange ActiveRange
		{
			get
			{
				if (this._ActiveRangeInited)
				{
					return this._ActiveRangeCache;
				}
				this._ActiveRangeInited = true;
				this._ActiveRangeCache = IActiveRange.Create(this.Instance.ActiveRange);
				return this._ActiveRangeCache;
			}
		}

		// Token: 0x0400842A RID: 33834
		private IAddGuestCharacter Instance;

		// Token: 0x0400842B RID: 33835
		private IActiveRange _ActiveRangeCache;

		// Token: 0x0400842C RID: 33836
		private bool _ActiveRangeInited;
	}
}

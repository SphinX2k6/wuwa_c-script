using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B5 RID: 10165
	[NullableContext(2)]
	[Nullable(0)]
	public class AddGuestCharacter : ActionParams
	{
		// Token: 0x0600E22F RID: 57903 RVA: 0x00216B0A File Offset: 0x00214D0A
		[NullableContext(1)]
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

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x0600E230 RID: 57904 RVA: 0x00216B29 File Offset: 0x00214D29
		public virtual int GuestCharacterId
		{
			get
			{
				return this.Instance.GuestCharacterId;
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x0600E231 RID: 57905 RVA: 0x00216B36 File Offset: 0x00214D36
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

		// Token: 0x04007D73 RID: 32115
		private IAddGuestCharacter Instance;

		// Token: 0x04007D74 RID: 32116
		private IActiveRange _ActiveRangeCache;

		// Token: 0x04007D75 RID: 32117
		private bool _ActiveRangeInited;
	}
}

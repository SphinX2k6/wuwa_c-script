using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200270E RID: 9998
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnLockCookSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600DF11 RID: 57105 RVA: 0x00211089 File Offset: 0x0020F289
		public static IUnLockCookSystemItem Create(IUnLockCookSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnLockCookSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x002110A8 File Offset: 0x0020F2A8
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x002110B5 File Offset: 0x0020F2B5
		public virtual IUnlockCookSystemCookBook UnlockOption
		{
			get
			{
				if (this._UnlockOptionInited)
				{
					return this._UnlockOptionCache;
				}
				this._UnlockOptionInited = true;
				this._UnlockOptionCache = IUnlockCookSystemCookBook.Create(this.Instance.UnlockOption);
				return this._UnlockOptionCache;
			}
		}

		// Token: 0x04007BCA RID: 31690
		private IUnLockCookSystemItem Instance;

		// Token: 0x04007BCB RID: 31691
		[Nullable(2)]
		private IUnlockCookSystemCookBook _UnlockOptionCache;

		// Token: 0x04007BCC RID: 31692
		private bool _UnlockOptionInited;
	}
}

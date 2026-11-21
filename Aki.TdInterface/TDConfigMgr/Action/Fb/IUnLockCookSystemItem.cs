using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D5 RID: 10709
	public class IUnLockCookSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600ECFD RID: 60669 RVA: 0x0022DA31 File Offset: 0x0022BC31
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

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x0600ECFE RID: 60670 RVA: 0x0022DA50 File Offset: 0x0022BC50
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x0022DA5D File Offset: 0x0022BC5D
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

		// Token: 0x0400826F RID: 33391
		private IUnLockCookSystemItem Instance;

		// Token: 0x04008270 RID: 33392
		[Nullable(2)]
		private IUnlockCookSystemCookBook _UnlockOptionCache;

		// Token: 0x04008271 RID: 33393
		private bool _UnlockOptionInited;
	}
}

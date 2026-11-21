using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001489 RID: 5257
	public class ICustomPlaceholderBindingProgress
	{
		// Token: 0x06007767 RID: 30567 RVA: 0x0011E610 File Offset: 0x0011C810
		public static ICustomPlaceholderBindingProgress Create(ICustomPlaceholderBindingProgress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPlaceholderBindingProgress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x0011E62F File Offset: 0x0011C82F
		public virtual string PlaceHolderName
		{
			get
			{
				return this.Instance.PlaceHolderName;
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x0011E63C File Offset: 0x0011C83C
		public virtual IPlayerHavingItemCount BindingProgressType
		{
			get
			{
				if (this._BindingProgressTypeInited)
				{
					return this._BindingProgressTypeCache;
				}
				this._BindingProgressTypeInited = true;
				this._BindingProgressTypeCache = IPlayerHavingItemCount.Create(this.Instance.BindingProgressType);
				return this._BindingProgressTypeCache;
			}
		}

		// Token: 0x0400448B RID: 17547
		private ICustomPlaceholderBindingProgress Instance;

		// Token: 0x0400448C RID: 17548
		[Nullable(2)]
		private IPlayerHavingItemCount _BindingProgressTypeCache;

		// Token: 0x0400448D RID: 17549
		private bool _BindingProgressTypeInited;
	}
}

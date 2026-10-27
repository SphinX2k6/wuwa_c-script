using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001339 RID: 4921
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPlaceholderBindingProgress
	{
		// Token: 0x060070C7 RID: 28871 RVA: 0x001100A4 File Offset: 0x0010E2A4
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

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x060070C8 RID: 28872 RVA: 0x001100C3 File Offset: 0x0010E2C3
		public virtual string PlaceHolderName
		{
			get
			{
				return this.Instance.PlaceHolderName;
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060070C9 RID: 28873 RVA: 0x001100D0 File Offset: 0x0010E2D0
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

		// Token: 0x0400410F RID: 16655
		private ICustomPlaceholderBindingProgress Instance;

		// Token: 0x04004110 RID: 16656
		[Nullable(2)]
		private IPlayerHavingItemCount _BindingProgressTypeCache;

		// Token: 0x04004111 RID: 16657
		private bool _BindingProgressTypeInited;
	}
}

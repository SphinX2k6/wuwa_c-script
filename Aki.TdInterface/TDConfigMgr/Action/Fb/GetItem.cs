using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FC RID: 10492
	public class GetItem : ActionParams
	{
		// Token: 0x0600E970 RID: 59760 RVA: 0x002278EE File Offset: 0x00225AEE
		public static GetItem Create(IGetItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GetItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x0600E971 RID: 59761 RVA: 0x00227910 File Offset: 0x00225B10
		public virtual List<IItemData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<IItemData>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(IItemData.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x0600E972 RID: 59762 RVA: 0x0022797C File Offset: 0x00225B7C
		public virtual EItemGetUiType? UiType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EItemGetUiType?((EItemGetUiType)this.Instance.UiType);
			}
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x002279B2 File Offset: 0x00225BB2
		[Nullable(2)]
		public virtual IItemGetUiConfigSpecialQuest UiConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._UiConfigInited)
				{
					return this._UiConfigCache;
				}
				this._UiConfigInited = true;
				this._UiConfigCache = IItemGetUiConfigSpecialQuest.Create(this.Instance.UiConfig);
				return this._UiConfigCache;
			}
		}

		// Token: 0x040080A8 RID: 32936
		private IGetItem Instance;

		// Token: 0x040080A9 RID: 32937
		private List<IItemData> _ItemsCache;

		// Token: 0x040080AA RID: 32938
		private bool _ItemsInited;

		// Token: 0x040080AB RID: 32939
		[Nullable(2)]
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x040080AC RID: 32940
		private bool _UiConfigInited;
	}
}

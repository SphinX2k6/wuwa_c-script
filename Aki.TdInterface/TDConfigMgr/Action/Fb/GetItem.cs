using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263C RID: 9788
	[NullableContext(1)]
	[Nullable(0)]
	public class GetItem : ActionParams
	{
		// Token: 0x0600DBA2 RID: 56226 RVA: 0x0020B122 File Offset: 0x00209322
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

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x0020B144 File Offset: 0x00209344
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

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0600DBA4 RID: 56228 RVA: 0x0020B1B0 File Offset: 0x002093B0
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

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x0020B1E6 File Offset: 0x002093E6
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

		// Token: 0x04007A0C RID: 31244
		private IGetItem Instance;

		// Token: 0x04007A0D RID: 31245
		private List<IItemData> _ItemsCache;

		// Token: 0x04007A0E RID: 31246
		private bool _ItemsInited;

		// Token: 0x04007A0F RID: 31247
		[Nullable(2)]
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04007A10 RID: 31248
		private bool _UiConfigInited;
	}
}

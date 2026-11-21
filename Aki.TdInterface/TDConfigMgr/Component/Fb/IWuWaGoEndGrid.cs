using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F0E RID: 3854
	public class IWuWaGoEndGrid : IWuWaGoEntityBase
	{
		// Token: 0x060056A1 RID: 22177 RVA: 0x000D4808 File Offset: 0x000D2A08
		public static IWuWaGoEndGrid Create(IWuWaGoEndGrid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoEndGrid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x060056A2 RID: 22178 RVA: 0x000D4827 File Offset: 0x000D2A27
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x060056A3 RID: 22179 RVA: 0x000D4834 File Offset: 0x000D2A34
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				this._LinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.LinkData);
				return this._LinkDataCache;
			}
		}

		// Token: 0x040031B5 RID: 12725
		private IWuWaGoEndGrid Instance;

		// Token: 0x040031B6 RID: 12726
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x040031B7 RID: 12727
		private bool _LinkDataInited;
	}
}

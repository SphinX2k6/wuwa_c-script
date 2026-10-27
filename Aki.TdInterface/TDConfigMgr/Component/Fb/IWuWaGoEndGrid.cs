using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E12 RID: 3602
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoEndGrid : IWuWaGoEntityBase
	{
		// Token: 0x0600517A RID: 20858 RVA: 0x000C8F40 File Offset: 0x000C7140
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

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x000C8F5F File Offset: 0x000C715F
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x000C8F6C File Offset: 0x000C716C
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

		// Token: 0x04002EED RID: 12013
		private IWuWaGoEndGrid Instance;

		// Token: 0x04002EEE RID: 12014
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002EEF RID: 12015
		private bool _LinkDataInited;
	}
}

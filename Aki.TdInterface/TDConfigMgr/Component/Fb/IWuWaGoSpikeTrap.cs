using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F08 RID: 3848
	public class IWuWaGoSpikeTrap : IWuWaGoEntityBase
	{
		// Token: 0x0600568B RID: 22155 RVA: 0x000D45F4 File Offset: 0x000D27F4
		public static IWuWaGoSpikeTrap Create(IWuWaGoSpikeTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoSpikeTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x000D4613 File Offset: 0x000D2813
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x0600568D RID: 22157 RVA: 0x000D4620 File Offset: 0x000D2820
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

		// Token: 0x040031A7 RID: 12711
		private IWuWaGoSpikeTrap Instance;

		// Token: 0x040031A8 RID: 12712
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x040031A9 RID: 12713
		private bool _LinkDataInited;
	}
}

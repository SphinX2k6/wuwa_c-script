using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0C RID: 3596
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoSpikeTrap : IWuWaGoEntityBase
	{
		// Token: 0x06005164 RID: 20836 RVA: 0x000C8D2C File Offset: 0x000C6F2C
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x000C8D4B File Offset: 0x000C6F4B
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x000C8D58 File Offset: 0x000C6F58
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

		// Token: 0x04002EDF RID: 11999
		private IWuWaGoSpikeTrap Instance;

		// Token: 0x04002EE0 RID: 12000
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002EE1 RID: 12001
		private bool _LinkDataInited;
	}
}

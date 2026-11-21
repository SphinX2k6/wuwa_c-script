using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002849 RID: 10313
	public class DestroyDynamicEntities : ActionParams
	{
		// Token: 0x0600E629 RID: 58921 RVA: 0x0022160A File Offset: 0x0021F80A
		public static DestroyDynamicEntities Create(IDestroyDynamicEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyDynamicEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x0600E62A RID: 58922 RVA: 0x00221629 File Offset: 0x0021F829
		public virtual IDestroyVisionDisplay DestroyEntitiesConfig
		{
			get
			{
				if (this._DestroyEntitiesConfigInited)
				{
					return this._DestroyEntitiesConfigCache;
				}
				this._DestroyEntitiesConfigInited = true;
				this._DestroyEntitiesConfigCache = IDestroyVisionDisplay.Create(this.Instance.DestroyEntitiesConfig);
				return this._DestroyEntitiesConfigCache;
			}
		}

		// Token: 0x04007ED5 RID: 32469
		private IDestroyDynamicEntities Instance;

		// Token: 0x04007ED6 RID: 32470
		[Nullable(2)]
		private IDestroyVisionDisplay _DestroyEntitiesConfigCache;

		// Token: 0x04007ED7 RID: 32471
		private bool _DestroyEntitiesConfigInited;
	}
}

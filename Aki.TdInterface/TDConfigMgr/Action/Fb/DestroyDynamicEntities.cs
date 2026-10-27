using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259A RID: 9626
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyDynamicEntities : ActionParams
	{
		// Token: 0x0600D8AF RID: 55471 RVA: 0x00205936 File Offset: 0x00203B36
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

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0600D8B0 RID: 55472 RVA: 0x00205955 File Offset: 0x00203B55
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

		// Token: 0x0400786E RID: 30830
		private IDestroyDynamicEntities Instance;

		// Token: 0x0400786F RID: 30831
		[Nullable(2)]
		private IDestroyVisionDisplay _DestroyEntitiesConfigCache;

		// Token: 0x04007870 RID: 30832
		private bool _DestroyEntitiesConfigInited;
	}
}

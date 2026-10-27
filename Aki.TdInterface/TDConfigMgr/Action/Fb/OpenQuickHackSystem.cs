using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFB RID: 11003
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem : ActionParams
	{
		// Token: 0x0600F107 RID: 61703 RVA: 0x0022F87A File Offset: 0x0022DA7A
		[NullableContext(1)]
		public static OpenQuickHackSystem Create(IOpenQuickHackSystem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenQuickHackSystem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x0600F108 RID: 61704 RVA: 0x0022F899 File Offset: 0x0022DA99
		public virtual int DeviceId
		{
			get
			{
				return this.Instance.DeviceId;
			}
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x0600F109 RID: 61705 RVA: 0x0022F8A8 File Offset: 0x0022DAA8
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x0600F10A RID: 61706 RVA: 0x0022F91D File Offset: 0x0022DB1D
		public virtual IOpenQuickHackCameraConfig CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = IOpenQuickHackCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x04008495 RID: 33941
		private IOpenQuickHackSystem Instance;

		// Token: 0x04008496 RID: 33942
		private List<int> _EntitiesCache;

		// Token: 0x04008497 RID: 33943
		private bool _EntitiesInited;

		// Token: 0x04008498 RID: 33944
		private IOpenQuickHackCameraConfig _CameraConfigCache;

		// Token: 0x04008499 RID: 33945
		private bool _CameraConfigInited;
	}
}

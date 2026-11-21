using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF8 RID: 3832
	public class IDollComboCamera
	{
		// Token: 0x0600563D RID: 22077 RVA: 0x000D3ACA File Offset: 0x000D1CCA
		public static IDollComboCamera Create(IDollComboCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollComboCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x000D3AE9 File Offset: 0x000D1CE9
		public virtual float Fov
		{
			get
			{
				return this.Instance.Fov;
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x000D3AF8 File Offset: 0x000D1CF8
		public virtual List<IDollComboCameraConfig> ComboCameras
		{
			get
			{
				if (this._ComboCamerasInited)
				{
					return this._ComboCamerasCache;
				}
				this._ComboCamerasInited = true;
				int comboCamerasLength = this.Instance.ComboCamerasLength;
				this._ComboCamerasCache = new List<IDollComboCameraConfig>(comboCamerasLength);
				for (int i = 0; i < comboCamerasLength; i++)
				{
					this._ComboCamerasCache.Add(IDollComboCameraConfig.Create(this.Instance.ComboCameras(i)));
				}
				return this._ComboCamerasCache;
			}
		}

		// Token: 0x04003167 RID: 12647
		private IDollComboCamera Instance;

		// Token: 0x04003168 RID: 12648
		private List<IDollComboCameraConfig> _ComboCamerasCache;

		// Token: 0x04003169 RID: 12649
		private bool _ComboCamerasInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFC RID: 3580
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollComboCamera
	{
		// Token: 0x06005116 RID: 20758 RVA: 0x000C8202 File Offset: 0x000C6402
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x000C8221 File Offset: 0x000C6421
		public virtual float Fov
		{
			get
			{
				return this.Instance.Fov;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x000C8230 File Offset: 0x000C6430
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

		// Token: 0x04002E9F RID: 11935
		private IDollComboCamera Instance;

		// Token: 0x04002EA0 RID: 11936
		private List<IDollComboCameraConfig> _ComboCamerasCache;

		// Token: 0x04002EA1 RID: 11937
		private bool _ComboCamerasInited;
	}
}

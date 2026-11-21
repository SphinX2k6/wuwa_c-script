using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DEF RID: 11759
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem : ActionParams
	{
		// Token: 0x0600FFBD RID: 65469 RVA: 0x0024D586 File Offset: 0x0024B786
		[NullableContext(0)]
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

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x0600FFBE RID: 65470 RVA: 0x0024D5A5 File Offset: 0x0024B7A5
		public virtual int DeviceId
		{
			get
			{
				return this.Instance.DeviceId;
			}
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x0600FFBF RID: 65471 RVA: 0x0024D5B4 File Offset: 0x0024B7B4
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

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x0600FFC0 RID: 65472 RVA: 0x0024D629 File Offset: 0x0024B829
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

		// Token: 0x04008B99 RID: 35737
		private IOpenQuickHackSystem Instance;

		// Token: 0x04008B9A RID: 35738
		private List<int> _EntitiesCache;

		// Token: 0x04008B9B RID: 35739
		private bool _EntitiesInited;

		// Token: 0x04008B9C RID: 35740
		private IOpenQuickHackCameraConfig _CameraConfigCache;

		// Token: 0x04008B9D RID: 35741
		private bool _CameraConfigInited;
	}
}

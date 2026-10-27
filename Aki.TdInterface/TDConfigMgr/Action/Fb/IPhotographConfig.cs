using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002652 RID: 9810
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig
	{
		// Token: 0x0600DBFA RID: 56314 RVA: 0x0020BDAA File Offset: 0x00209FAA
		[NullableContext(1)]
		public static IPhotographConfig Create(IPhotographConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x0600DBFB RID: 56315 RVA: 0x0020BDCC File Offset: 0x00209FCC
		public virtual List<int> PhotoTargets
		{
			get
			{
				if (this._PhotoTargetsInited)
				{
					return this._PhotoTargetsCache;
				}
				this._PhotoTargetsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int photoTargetsLength = this.Instance.PhotoTargetsLength;
				this._PhotoTargetsCache = new List<int>(photoTargetsLength);
				for (int i = 0; i < photoTargetsLength; i++)
				{
					this._PhotoTargetsCache.Add(this.Instance.PhotoTargets(i));
				}
				return this._PhotoTargetsCache;
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x0020BE41 File Offset: 0x0020A041
		public virtual IPhotographPlayerPerform PlayerPerform
		{
			get
			{
				if (this._PlayerPerformInited)
				{
					return this._PlayerPerformCache;
				}
				this._PlayerPerformInited = true;
				this._PlayerPerformCache = IPhotographPlayerPerform.Create(this.Instance.PlayerPerform);
				return this._PlayerPerformCache;
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x0600DBFD RID: 56317 RVA: 0x0020BE75 File Offset: 0x0020A075
		public virtual IPhotographCameraParams CameraParams
		{
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				this._CameraParamsCache = IPhotographCameraParams.Create(this.Instance.CameraParams);
				return this._CameraParamsCache;
			}
		}

		// Token: 0x04007A48 RID: 31304
		private IPhotographConfig Instance;

		// Token: 0x04007A49 RID: 31305
		private List<int> _PhotoTargetsCache;

		// Token: 0x04007A4A RID: 31306
		private bool _PhotoTargetsInited;

		// Token: 0x04007A4B RID: 31307
		private IPhotographPlayerPerform _PlayerPerformCache;

		// Token: 0x04007A4C RID: 31308
		private bool _PlayerPerformInited;

		// Token: 0x04007A4D RID: 31309
		private IPhotographCameraParams _CameraParamsCache;

		// Token: 0x04007A4E RID: 31310
		private bool _CameraParamsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002916 RID: 10518
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig
	{
		// Token: 0x0600E9D6 RID: 59862 RVA: 0x00228682 File Offset: 0x00226882
		[NullableContext(0)]
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

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x002286A4 File Offset: 0x002268A4
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

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x0600E9D8 RID: 59864 RVA: 0x00228719 File Offset: 0x00226919
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

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x0022874D File Offset: 0x0022694D
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

		// Token: 0x040080EA RID: 33002
		private IPhotographConfig Instance;

		// Token: 0x040080EB RID: 33003
		private List<int> _PhotoTargetsCache;

		// Token: 0x040080EC RID: 33004
		private bool _PhotoTargetsInited;

		// Token: 0x040080ED RID: 33005
		private IPhotographPlayerPerform _PlayerPerformCache;

		// Token: 0x040080EE RID: 33006
		private bool _PlayerPerformInited;

		// Token: 0x040080EF RID: 33007
		private IPhotographCameraParams _CameraParamsCache;

		// Token: 0x040080F0 RID: 33008
		private bool _CameraParamsInited;
	}
}

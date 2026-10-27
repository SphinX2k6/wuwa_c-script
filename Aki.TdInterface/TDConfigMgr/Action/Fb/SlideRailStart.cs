using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A16 RID: 10774
	[NullableContext(2)]
	[Nullable(0)]
	public class SlideRailStart : ActionParams
	{
		// Token: 0x0600ED8C RID: 60812 RVA: 0x00229FE5 File Offset: 0x002281E5
		[NullableContext(1)]
		public static SlideRailStart Create(ISlideRailStart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailStart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x0600ED8D RID: 60813 RVA: 0x0022A004 File Offset: 0x00228204
		public virtual int RailEntityId
		{
			get
			{
				return this.Instance.RailEntityId;
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x0600ED8E RID: 60814 RVA: 0x0022A011 File Offset: 0x00228211
		[Nullable(1)]
		public virtual string SlidePerformDaPath
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.SlidePerformDaPath;
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x0600ED8F RID: 60815 RVA: 0x0022A01E File Offset: 0x0022821E
		public virtual ISlideRailFollowConfig SlideRailFollowConfig
		{
			get
			{
				if (this._SlideRailFollowConfigInited)
				{
					return this._SlideRailFollowConfigCache;
				}
				this._SlideRailFollowConfigInited = true;
				this._SlideRailFollowConfigCache = ISlideRailFollowConfig.Create(this.Instance.SlideRailFollowConfig);
				return this._SlideRailFollowConfigCache;
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x0022A052 File Offset: 0x00228252
		public virtual ISlideRailRTPCParams RTPCParams
		{
			get
			{
				if (this._RTPCParamsInited)
				{
					return this._RTPCParamsCache;
				}
				this._RTPCParamsInited = true;
				this._RTPCParamsCache = ISlideRailRTPCParams.Create(this.Instance.RTPCParams);
				return this._RTPCParamsCache;
			}
		}

		// Token: 0x040082C0 RID: 33472
		private ISlideRailStart Instance;

		// Token: 0x040082C1 RID: 33473
		private ISlideRailFollowConfig _SlideRailFollowConfigCache;

		// Token: 0x040082C2 RID: 33474
		private bool _SlideRailFollowConfigInited;

		// Token: 0x040082C3 RID: 33475
		private ISlideRailRTPCParams _RTPCParamsCache;

		// Token: 0x040082C4 RID: 33476
		private bool _RTPCParamsInited;
	}
}

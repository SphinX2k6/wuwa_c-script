using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D03 RID: 11523
	[NullableContext(2)]
	[Nullable(0)]
	public class SlideRailStart : ActionParams
	{
		// Token: 0x0600FC23 RID: 64547 RVA: 0x00247969 File Offset: 0x00245B69
		[NullableContext(0)]
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

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x0600FC24 RID: 64548 RVA: 0x00247988 File Offset: 0x00245B88
		public virtual int RailEntityId
		{
			get
			{
				return this.Instance.RailEntityId;
			}
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x0600FC25 RID: 64549 RVA: 0x00247995 File Offset: 0x00245B95
		[Nullable(0)]
		public virtual string SlidePerformDaPath
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.SlidePerformDaPath;
			}
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x0600FC26 RID: 64550 RVA: 0x002479A2 File Offset: 0x00245BA2
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

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x0600FC27 RID: 64551 RVA: 0x002479D6 File Offset: 0x00245BD6
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

		// Token: 0x040089B1 RID: 35249
		private ISlideRailStart Instance;

		// Token: 0x040089B2 RID: 35250
		private ISlideRailFollowConfig _SlideRailFollowConfigCache;

		// Token: 0x040089B3 RID: 35251
		private bool _SlideRailFollowConfigInited;

		// Token: 0x040089B4 RID: 35252
		private ISlideRailRTPCParams _RTPCParamsCache;

		// Token: 0x040089B5 RID: 35253
		private bool _RTPCParamsInited;
	}
}

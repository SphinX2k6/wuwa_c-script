using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002212 RID: 8722
	[NullableContext(1)]
	[Nullable(0)]
	public class SlideRailStart : ActionParams
	{
		// Token: 0x0600BF78 RID: 49016 RVA: 0x001B829C File Offset: 0x001B649C
		private SlideRailStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SlideRailStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SlideRailStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SlideRailStart_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x001B82D4 File Offset: 0x001B64D4
		public static SlideRailStart Create([Nullable(2)] SlideRailStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x001B82E7 File Offset: 0x001B64E7
		public static SlideRailStart CreateFromSetValue([Nullable(2)] SlideRailStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SlideRailStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x001B82FA File Offset: 0x001B64FA
		public SlideRailStart_SetValue ToSetValue()
		{
			return new SlideRailStart_SetValue
			{
				RailEntityId = this.RailEntityId,
				SlidePerformDaPath = this.SlidePerformDaPath,
				SlideRailFollowConfig = this.SlideRailFollowConfig,
				RTPCParams = this.RTPCParams
			};
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x001B8331 File Offset: 0x001B6531
		// (set) Token: 0x0600BF7D RID: 49021 RVA: 0x001B835C File Offset: 0x001B655C
		public virtual int RailEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RailEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RailEntityId;
			}
			set
			{
				this.GetOrCreatePoco().RailEntityId = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600BF7E RID: 49022 RVA: 0x001B836A File Offset: 0x001B656A
		// (set) Token: 0x0600BF7F RID: 49023 RVA: 0x001B8395 File Offset: 0x001B6595
		public virtual string SlidePerformDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlidePerformDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SlidePerformDaPath;
			}
			set
			{
				this.GetOrCreatePoco().SlidePerformDaPath = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x001B83A4 File Offset: 0x001B65A4
		// (set) Token: 0x0600BF81 RID: 49025 RVA: 0x001B8405 File Offset: 0x001B6605
		[Nullable(2)]
		public virtual ISlideRailFollowConfig SlideRailFollowConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._SlideRailFollowConfigInited)
				{
					return this._SlideRailFollowConfigCache;
				}
				this._SlideRailFollowConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SlideRailFollowConfigCache = ISlideRailFollowConfig.Create(this.FbInstance.SlideRailFollowConfig);
				}
				else
				{
					SlideRailStart_SetValue pocoInterface = this.PocoInterface;
					this._SlideRailFollowConfigCache = ((pocoInterface != null) ? pocoInterface.SlideRailFollowConfig : null);
				}
				return this._SlideRailFollowConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SlideRailFollowConfig = value;
				this._SlideRailFollowConfigInited = false;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x001B841C File Offset: 0x001B661C
		// (set) Token: 0x0600BF83 RID: 49027 RVA: 0x001B847D File Offset: 0x001B667D
		[Nullable(2)]
		public virtual ISlideRailRTPCParams RTPCParams
		{
			[NullableContext(2)]
			get
			{
				if (this._RTPCParamsInited)
				{
					return this._RTPCParamsCache;
				}
				this._RTPCParamsInited = true;
				if (this.FbInstance != null)
				{
					this._RTPCParamsCache = ISlideRailRTPCParams.Create(this.FbInstance.RTPCParams);
				}
				else
				{
					SlideRailStart_SetValue pocoInterface = this.PocoInterface;
					this._RTPCParamsCache = ((pocoInterface != null) ? pocoInterface.RTPCParams : null);
				}
				return this._RTPCParamsCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RTPCParams = value;
				this._RTPCParamsInited = false;
			}
		}

		// Token: 0x04007227 RID: 29223
		[Nullable(2)]
		protected new SlideRailStart FbInstance;

		// Token: 0x04007228 RID: 29224
		[Nullable(2)]
		protected SlideRailStart_SetValue PocoInterface;

		// Token: 0x04007229 RID: 29225
		private ISlideRailFollowConfig _SlideRailFollowConfigCache;

		// Token: 0x0400722A RID: 29226
		private bool _SlideRailFollowConfigInited;

		// Token: 0x0400722B RID: 29227
		private ISlideRailRTPCParams _RTPCParamsCache;

		// Token: 0x0400722C RID: 29228
		private bool _RTPCParamsInited;
	}
}

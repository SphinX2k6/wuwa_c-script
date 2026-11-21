using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247D RID: 9341
	public class SlideRailStart : ActionParams
	{
		// Token: 0x0600CB36 RID: 52022 RVA: 0x001CF968 File Offset: 0x001CDB68
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

		// Token: 0x0600CB37 RID: 52023 RVA: 0x001CF9A0 File Offset: 0x001CDBA0
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

		// Token: 0x0600CB38 RID: 52024 RVA: 0x001CF9B3 File Offset: 0x001CDBB3
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

		// Token: 0x0600CB39 RID: 52025 RVA: 0x001CF9C6 File Offset: 0x001CDBC6
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

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600CB3A RID: 52026 RVA: 0x001CF9FD File Offset: 0x001CDBFD
		// (set) Token: 0x0600CB3B RID: 52027 RVA: 0x001CFA28 File Offset: 0x001CDC28
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

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x001CFA36 File Offset: 0x001CDC36
		// (set) Token: 0x0600CB3D RID: 52029 RVA: 0x001CFA61 File Offset: 0x001CDC61
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

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x001CFA70 File Offset: 0x001CDC70
		// (set) Token: 0x0600CB3F RID: 52031 RVA: 0x001CFAD1 File Offset: 0x001CDCD1
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

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600CB40 RID: 52032 RVA: 0x001CFAE8 File Offset: 0x001CDCE8
		// (set) Token: 0x0600CB41 RID: 52033 RVA: 0x001CFB49 File Offset: 0x001CDD49
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

		// Token: 0x04007871 RID: 30833
		[Nullable(2)]
		protected new SlideRailStart FbInstance;

		// Token: 0x04007872 RID: 30834
		[Nullable(2)]
		protected SlideRailStart_SetValue PocoInterface;

		// Token: 0x04007873 RID: 30835
		private ISlideRailFollowConfig _SlideRailFollowConfigCache;

		// Token: 0x04007874 RID: 30836
		private bool _SlideRailFollowConfigInited;

		// Token: 0x04007875 RID: 30837
		private ISlideRailRTPCParams _RTPCParamsCache;

		// Token: 0x04007876 RID: 30838
		private bool _RTPCParamsInited;
	}
}

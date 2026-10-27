using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200220E RID: 8718
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidePerformStart : ActionParams
	{
		// Token: 0x0600BF66 RID: 48998 RVA: 0x001B80A4 File Offset: 0x001B62A4
		private SlidePerformStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SlidePerformStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SlidePerformStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SlidePerformStart_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x001B80DC File Offset: 0x001B62DC
		public static SlidePerformStart Create([Nullable(2)] SlidePerformStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlidePerformStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x001B80EF File Offset: 0x001B62EF
		public static SlidePerformStart CreateFromSetValue([Nullable(2)] SlidePerformStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SlidePerformStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF69 RID: 49001 RVA: 0x001B8102 File Offset: 0x001B6302
		public SlidePerformStart_SetValue ToSetValue()
		{
			return new SlidePerformStart_SetValue
			{
				SlideEntityId = this.SlideEntityId,
				SlidePerformConfig = this.SlidePerformConfig
			};
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x001B8121 File Offset: 0x001B6321
		// (set) Token: 0x0600BF6B RID: 49003 RVA: 0x001B814C File Offset: 0x001B634C
		public virtual int SlideEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlideEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SlideEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SlideEntityId = value;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600BF6C RID: 49004 RVA: 0x001B815C File Offset: 0x001B635C
		// (set) Token: 0x0600BF6D RID: 49005 RVA: 0x001B81BD File Offset: 0x001B63BD
		public virtual ISlopeSlidePerformStart SlidePerformConfig
		{
			get
			{
				if (this._SlidePerformConfigInited)
				{
					return this._SlidePerformConfigCache;
				}
				this._SlidePerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SlidePerformConfigCache = ISlopeSlidePerformStart.Create(this.FbInstance.SlidePerformConfig);
				}
				else
				{
					SlidePerformStart_SetValue pocoInterface = this.PocoInterface;
					this._SlidePerformConfigCache = ((pocoInterface != null) ? pocoInterface.SlidePerformConfig : null);
				}
				return this._SlidePerformConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SlidePerformConfig = value;
				this._SlidePerformConfigInited = false;
			}
		}

		// Token: 0x0400721E RID: 29214
		[Nullable(2)]
		protected new SlidePerformStart FbInstance;

		// Token: 0x0400721F RID: 29215
		[Nullable(2)]
		protected SlidePerformStart_SetValue PocoInterface;

		// Token: 0x04007220 RID: 29216
		private ISlopeSlidePerformStart _SlidePerformConfigCache;

		// Token: 0x04007221 RID: 29217
		private bool _SlidePerformConfigInited;
	}
}

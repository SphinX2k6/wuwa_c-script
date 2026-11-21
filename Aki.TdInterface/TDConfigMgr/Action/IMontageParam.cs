using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF7 RID: 7671
	public class IMontageParam
	{
		// Token: 0x0600A2FB RID: 41723 RVA: 0x00174DA8 File Offset: 0x00172FA8
		private IMontageParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageParam_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x00174DE0 File Offset: 0x00172FE0
		public static IMontageParam Create([Nullable(2)] IMontageParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x00174DF3 File Offset: 0x00172FF3
		public static IMontageParam CreateFromSetValue([Nullable(2)] IMontageParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x00174E06 File Offset: 0x00173006
		public IMontageParam_SetValue ToSetValue()
		{
			return new IMontageParam_SetValue
			{
				MontageId = this.MontageId,
				IsLoop = this.IsLoop,
				KeepPose = this.KeepPose,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x00174E40 File Offset: 0x00173040
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x00174EA1 File Offset: 0x001730A1
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IMontageParam_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x00174EB8 File Offset: 0x001730B8
		// (set) Token: 0x0600A302 RID: 41730 RVA: 0x00174EF2 File Offset: 0x001730F2
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A303 RID: 41731 RVA: 0x00174F00 File Offset: 0x00173100
		// (set) Token: 0x0600A304 RID: 41732 RVA: 0x00174F3A File Offset: 0x0017313A
		public virtual bool? KeepPose
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPose;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPose;
			}
			set
			{
				this.GetOrCreatePoco().KeepPose = value;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A305 RID: 41733 RVA: 0x00174F48 File Offset: 0x00173148
		// (set) Token: 0x0600A306 RID: 41734 RVA: 0x00174F82 File Offset: 0x00173182
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IMontageParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x040062C2 RID: 25282
		[Nullable(2)]
		protected IMontageParam FbInstance;

		// Token: 0x040062C3 RID: 25283
		[Nullable(2)]
		protected IMontageParam_SetValue PocoInterface;

		// Token: 0x040062C4 RID: 25284
		private IMontageId _MontageIdCache;

		// Token: 0x040062C5 RID: 25285
		private bool _MontageIdInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F35 RID: 7989
	public class IPlayWalkingOverlayRenderMontage
	{
		// Token: 0x0600AA03 RID: 43523 RVA: 0x00181A80 File Offset: 0x0017FC80
		private IPlayWalkingOverlayRenderMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayWalkingOverlayRenderMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayWalkingOverlayRenderMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayWalkingOverlayRenderMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x00181AB8 File Offset: 0x0017FCB8
		public static IPlayWalkingOverlayRenderMontage Create([Nullable(2)] IPlayWalkingOverlayRenderMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayWalkingOverlayRenderMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x00181ACB File Offset: 0x0017FCCB
		public static IPlayWalkingOverlayRenderMontage CreateFromSetValue([Nullable(2)] IPlayWalkingOverlayRenderMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayWalkingOverlayRenderMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x00181ADE File Offset: 0x0017FCDE
		public IPlayWalkingOverlayRenderMontage_SetValue ToSetValue()
		{
			return new IPlayWalkingOverlayRenderMontage_SetValue
			{
				EntityId = this.EntityId,
				OverlapMontageId = this.OverlapMontageId,
				LoopDuration = this.LoopDuration,
				RepeatTimes = this.RepeatTimes
			};
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600AA07 RID: 43527 RVA: 0x00181B15 File Offset: 0x0017FD15
		// (set) Token: 0x0600AA08 RID: 43528 RVA: 0x00181B40 File Offset: 0x0017FD40
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x00181B50 File Offset: 0x0017FD50
		// (set) Token: 0x0600AA0A RID: 43530 RVA: 0x00181BB1 File Offset: 0x0017FDB1
		public virtual IMontageId OverlapMontageId
		{
			get
			{
				if (this._OverlapMontageIdInited)
				{
					return this._OverlapMontageIdCache;
				}
				this._OverlapMontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._OverlapMontageIdCache = IMontageId.Create(this.FbInstance.OverlapMontageId);
				}
				else
				{
					IPlayWalkingOverlayRenderMontage_SetValue pocoInterface = this.PocoInterface;
					this._OverlapMontageIdCache = ((pocoInterface != null) ? pocoInterface.OverlapMontageId : null);
				}
				return this._OverlapMontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
				this._OverlapMontageIdInited = false;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600AA0B RID: 43531 RVA: 0x00181BC8 File Offset: 0x0017FDC8
		// (set) Token: 0x0600AA0C RID: 43532 RVA: 0x00181C02 File Offset: 0x0017FE02
		public virtual float? LoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopDuration;
				}
				IPlayWalkingOverlayRenderMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopDuration;
			}
			set
			{
				this.GetOrCreatePoco().LoopDuration = value;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x00181C10 File Offset: 0x0017FE10
		// (set) Token: 0x0600AA0E RID: 43534 RVA: 0x00181C4A File Offset: 0x0017FE4A
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				IPlayWalkingOverlayRenderMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x04006603 RID: 26115
		[Nullable(2)]
		protected IPlayWalkingOverlayRenderMontage FbInstance;

		// Token: 0x04006604 RID: 26116
		[Nullable(2)]
		protected IPlayWalkingOverlayRenderMontage_SetValue PocoInterface;

		// Token: 0x04006605 RID: 26117
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04006606 RID: 26118
		private bool _OverlapMontageIdInited;
	}
}

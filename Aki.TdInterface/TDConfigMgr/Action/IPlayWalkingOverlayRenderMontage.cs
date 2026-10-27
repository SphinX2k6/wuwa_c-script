using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D24 RID: 7460
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayWalkingOverlayRenderMontage
	{
		// Token: 0x0600A017 RID: 40983 RVA: 0x0016D65C File Offset: 0x0016B85C
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

		// Token: 0x0600A018 RID: 40984 RVA: 0x0016D694 File Offset: 0x0016B894
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

		// Token: 0x0600A019 RID: 40985 RVA: 0x0016D6A7 File Offset: 0x0016B8A7
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

		// Token: 0x0600A01A RID: 40986 RVA: 0x0016D6BA File Offset: 0x0016B8BA
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

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x0016D6F1 File Offset: 0x0016B8F1
		// (set) Token: 0x0600A01C RID: 40988 RVA: 0x0016D71C File Offset: 0x0016B91C
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

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x0016D72C File Offset: 0x0016B92C
		// (set) Token: 0x0600A01E RID: 40990 RVA: 0x0016D78D File Offset: 0x0016B98D
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

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x0016D7A4 File Offset: 0x0016B9A4
		// (set) Token: 0x0600A020 RID: 40992 RVA: 0x0016D7DE File Offset: 0x0016B9DE
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

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x0016D7EC File Offset: 0x0016B9EC
		// (set) Token: 0x0600A022 RID: 40994 RVA: 0x0016D826 File Offset: 0x0016BA26
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

		// Token: 0x04006087 RID: 24711
		[Nullable(2)]
		protected IPlayWalkingOverlayRenderMontage FbInstance;

		// Token: 0x04006088 RID: 24712
		[Nullable(2)]
		protected IPlayWalkingOverlayRenderMontage_SetValue PocoInterface;

		// Token: 0x04006089 RID: 24713
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x0400608A RID: 24714
		private bool _OverlapMontageIdInited;
	}
}

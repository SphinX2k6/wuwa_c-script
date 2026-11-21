using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8D RID: 11661
	public class IPlayWalkingOverlayRenderMontage
	{
		// Token: 0x0600FE3C RID: 65084 RVA: 0x0024AE9E File Offset: 0x0024909E
		public static IPlayWalkingOverlayRenderMontage Create(IPlayWalkingOverlayRenderMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayWalkingOverlayRenderMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x0600FE3D RID: 65085 RVA: 0x0024AEBD File Offset: 0x002490BD
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x0600FE3E RID: 65086 RVA: 0x0024AECA File Offset: 0x002490CA
		public virtual IMontageId OverlapMontageId
		{
			get
			{
				if (this._OverlapMontageIdInited)
				{
					return this._OverlapMontageIdCache;
				}
				this._OverlapMontageIdInited = true;
				this._OverlapMontageIdCache = IMontageId.Create(this.Instance.OverlapMontageId);
				return this._OverlapMontageIdCache;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x0600FE3F RID: 65087 RVA: 0x0024AF00 File Offset: 0x00249100
		public virtual float? LoopDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LoopDuration);
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x0600FE40 RID: 65088 RVA: 0x0024AF38 File Offset: 0x00249138
		public virtual int? RepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RepeatTimes);
			}
		}

		// Token: 0x04008AC7 RID: 35527
		private IPlayWalkingOverlayRenderMontage Instance;

		// Token: 0x04008AC8 RID: 35528
		[Nullable(2)]
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04008AC9 RID: 35529
		private bool _OverlapMontageIdInited;
	}
}

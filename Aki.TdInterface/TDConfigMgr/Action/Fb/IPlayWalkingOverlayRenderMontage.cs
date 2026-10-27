using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A99 RID: 10905
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayWalkingOverlayRenderMontage
	{
		// Token: 0x0600EF86 RID: 61318 RVA: 0x0022D192 File Offset: 0x0022B392
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

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x0600EF87 RID: 61319 RVA: 0x0022D1B1 File Offset: 0x0022B3B1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x0600EF88 RID: 61320 RVA: 0x0022D1BE File Offset: 0x0022B3BE
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

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x0600EF89 RID: 61321 RVA: 0x0022D1F4 File Offset: 0x0022B3F4
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

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x0022D22C File Offset: 0x0022B42C
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

		// Token: 0x040083C3 RID: 33731
		private IPlayWalkingOverlayRenderMontage Instance;

		// Token: 0x040083C4 RID: 33732
		[Nullable(2)]
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x040083C5 RID: 33733
		private bool _OverlapMontageIdInited;
	}
}

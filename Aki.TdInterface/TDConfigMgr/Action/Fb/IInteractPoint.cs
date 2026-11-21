using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B22 RID: 11042
	public class IInteractPoint
	{
		// Token: 0x0600F2DE RID: 62174 RVA: 0x0023768A File Offset: 0x0023588A
		public static IInteractPoint Create(IInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x0600F2DF RID: 62175 RVA: 0x002376A9 File Offset: 0x002358A9
		public virtual int Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x0600F2E0 RID: 62176 RVA: 0x002376B6 File Offset: 0x002358B6
		public virtual List<IInteractEffect> InteractEffects
		{
			get
			{
				if (this._InteractEffectsInited)
				{
					return this._InteractEffectsCache;
				}
				this._InteractEffectsInited = true;
				this._InteractEffectsCache = ActionReadHelper.ReadIInteractPoint_InteractEffects(this.Instance);
				return this._InteractEffectsCache;
			}
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x0600F2E1 RID: 62177 RVA: 0x002376E5 File Offset: 0x002358E5
		public virtual bool IsValidPoint
		{
			get
			{
				return this.Instance.IsValidPoint;
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x0600F2E2 RID: 62178 RVA: 0x002376F4 File Offset: 0x002358F4
		public virtual float? ProtectTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ProtectTime);
			}
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x0600F2E3 RID: 62179 RVA: 0x0023772C File Offset: 0x0023592C
		public virtual bool? CancelRaycast
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CancelRaycast);
			}
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x0600F2E4 RID: 62180 RVA: 0x00237762 File Offset: 0x00235962
		[Nullable(2)]
		public virtual IDragInteractPointInteraction InteractionConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._InteractionConfigInited)
				{
					return this._InteractionConfigCache;
				}
				this._InteractionConfigInited = true;
				this._InteractionConfigCache = IDragInteractPointInteraction.Create(this.Instance.InteractionConfig);
				return this._InteractionConfigCache;
			}
		}

		// Token: 0x04008546 RID: 34118
		private IInteractPoint Instance;

		// Token: 0x04008547 RID: 34119
		private List<IInteractEffect> _InteractEffectsCache;

		// Token: 0x04008548 RID: 34120
		private bool _InteractEffectsInited;

		// Token: 0x04008549 RID: 34121
		[Nullable(2)]
		private IDragInteractPointInteraction _InteractionConfigCache;

		// Token: 0x0400854A RID: 34122
		private bool _InteractionConfigInited;
	}
}

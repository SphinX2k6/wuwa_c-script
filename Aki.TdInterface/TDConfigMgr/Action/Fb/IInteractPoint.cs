using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284F RID: 10319
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPoint
	{
		// Token: 0x0600E4B9 RID: 58553 RVA: 0x0021A826 File Offset: 0x00218A26
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

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x0021A845 File Offset: 0x00218A45
		public virtual int Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x0021A852 File Offset: 0x00218A52
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

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x0600E4BC RID: 58556 RVA: 0x0021A881 File Offset: 0x00218A81
		public virtual bool IsValidPoint
		{
			get
			{
				return this.Instance.IsValidPoint;
			}
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x0021A890 File Offset: 0x00218A90
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

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x0600E4BE RID: 58558 RVA: 0x0021A8C8 File Offset: 0x00218AC8
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

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x0021A8FE File Offset: 0x00218AFE
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

		// Token: 0x04007E89 RID: 32393
		private IInteractPoint Instance;

		// Token: 0x04007E8A RID: 32394
		private List<IInteractEffect> _InteractEffectsCache;

		// Token: 0x04007E8B RID: 32395
		private bool _InteractEffectsInited;

		// Token: 0x04007E8C RID: 32396
		[Nullable(2)]
		private IDragInteractPointInteraction _InteractionConfigCache;

		// Token: 0x04007E8D RID: 32397
		private bool _InteractionConfigInited;
	}
}

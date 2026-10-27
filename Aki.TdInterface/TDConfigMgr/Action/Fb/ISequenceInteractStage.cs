using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002850 RID: 10320
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceInteractStage
	{
		// Token: 0x0600E4C1 RID: 58561 RVA: 0x0021A93A File Offset: 0x00218B3A
		public static ISequenceInteractStage Create(ISequenceInteractStage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceInteractStage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x0600E4C2 RID: 58562 RVA: 0x0021A959 File Offset: 0x00218B59
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInteractEffect> EnterStageEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EnterStageEffectsInited)
				{
					return this._EnterStageEffectsCache;
				}
				this._EnterStageEffectsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				this._EnterStageEffectsCache = ActionReadHelper.ReadISequenceInteractStage_EnterStageEffects(this.Instance);
				return this._EnterStageEffectsCache;
			}
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x0021A99C File Offset: 0x00218B9C
		public virtual List<IInteractPoint> InteractPoints
		{
			get
			{
				if (this._InteractPointsInited)
				{
					return this._InteractPointsCache;
				}
				this._InteractPointsInited = true;
				int interactPointsLength = this.Instance.InteractPointsLength;
				this._InteractPointsCache = new List<IInteractPoint>(interactPointsLength);
				for (int i = 0; i < interactPointsLength; i++)
				{
					this._InteractPointsCache.Add(IInteractPoint.Create(this.Instance.InteractPoints(i)));
				}
				return this._InteractPointsCache;
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x0600E4C4 RID: 58564 RVA: 0x0021AA05 File Offset: 0x00218C05
		[Nullable(2)]
		public virtual string UiTipText
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UiTipText;
			}
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x0021AA14 File Offset: 0x00218C14
		public virtual bool? IsResetAfterStageEnd
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsResetAfterStageEnd);
			}
		}

		// Token: 0x04007E8E RID: 32398
		private ISequenceInteractStage Instance;

		// Token: 0x04007E8F RID: 32399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IInteractEffect> _EnterStageEffectsCache;

		// Token: 0x04007E90 RID: 32400
		private bool _EnterStageEffectsInited;

		// Token: 0x04007E91 RID: 32401
		private List<IInteractPoint> _InteractPointsCache;

		// Token: 0x04007E92 RID: 32402
		private bool _InteractPointsInited;
	}
}

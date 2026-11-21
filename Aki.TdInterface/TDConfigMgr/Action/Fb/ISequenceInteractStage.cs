using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B23 RID: 11043
	public class ISequenceInteractStage
	{
		// Token: 0x0600F2E6 RID: 62182 RVA: 0x0023779E File Offset: 0x0023599E
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

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x0600F2E7 RID: 62183 RVA: 0x002377BD File Offset: 0x002359BD
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IInteractEffect> EnterStageEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x0600F2E8 RID: 62184 RVA: 0x00237800 File Offset: 0x00235A00
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

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x0600F2E9 RID: 62185 RVA: 0x00237869 File Offset: 0x00235A69
		[Nullable(2)]
		public virtual string UiTipText
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UiTipText;
			}
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x0600F2EA RID: 62186 RVA: 0x00237878 File Offset: 0x00235A78
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

		// Token: 0x0400854B RID: 34123
		private ISequenceInteractStage Instance;

		// Token: 0x0400854C RID: 34124
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IInteractEffect> _EnterStageEffectsCache;

		// Token: 0x0400854D RID: 34125
		private bool _EnterStageEffectsInited;

		// Token: 0x0400854E RID: 34126
		private List<IInteractPoint> _InteractPointsCache;

		// Token: 0x0400854F RID: 34127
		private bool _InteractPointsInited;
	}
}

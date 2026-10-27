using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002876 RID: 10358
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneInspection : IUiGame
	{
		// Token: 0x0600E57C RID: 58748 RVA: 0x0021BCF1 File Offset: 0x00219EF1
		public static ISceneInspection Create(ISceneInspection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInspection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x0600E57D RID: 58749 RVA: 0x0021BD10 File Offset: 0x00219F10
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x0600E57E RID: 58750 RVA: 0x0021BD1D File Offset: 0x00219F1D
		public virtual string SaveVarName
		{
			get
			{
				return this.Instance.SaveVarName;
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x0600E57F RID: 58751 RVA: 0x0021BD2C File Offset: 0x00219F2C
		public virtual List<ISceneInspectionPoint> InteractPoints
		{
			get
			{
				if (this._InteractPointsInited)
				{
					return this._InteractPointsCache;
				}
				this._InteractPointsInited = true;
				int interactPointsLength = this.Instance.InteractPointsLength;
				this._InteractPointsCache = new List<ISceneInspectionPoint>(interactPointsLength);
				for (int i = 0; i < interactPointsLength; i++)
				{
					this._InteractPointsCache.Add(ISceneInspectionPoint.Create(this.Instance.InteractPoints(i)));
				}
				return this._InteractPointsCache;
			}
		}

		// Token: 0x04007EE4 RID: 32484
		private ISceneInspection Instance;

		// Token: 0x04007EE5 RID: 32485
		private List<ISceneInspectionPoint> _InteractPointsCache;

		// Token: 0x04007EE6 RID: 32486
		private bool _InteractPointsInited;
	}
}

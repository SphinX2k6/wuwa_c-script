using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B4C RID: 11084
	public class ISceneInspection : IUiGame
	{
		// Token: 0x0600F3AD RID: 62381 RVA: 0x00238C45 File Offset: 0x00236E45
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

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x00238C64 File Offset: 0x00236E64
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x0600F3AF RID: 62383 RVA: 0x00238C71 File Offset: 0x00236E71
		public virtual string SaveVarName
		{
			get
			{
				return this.Instance.SaveVarName;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x00238C80 File Offset: 0x00236E80
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

		// Token: 0x040085A4 RID: 34212
		private ISceneInspection Instance;

		// Token: 0x040085A5 RID: 34213
		private List<ISceneInspectionPoint> _InteractPointsCache;

		// Token: 0x040085A6 RID: 34214
		private bool _InteractPointsInited;
	}
}

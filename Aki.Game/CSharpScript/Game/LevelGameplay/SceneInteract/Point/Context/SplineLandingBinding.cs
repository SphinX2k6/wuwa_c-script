using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8F RID: 27279
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineLandingBinding
	{
		// Token: 0x06043C7A RID: 277626 RVA: 0x01097151 File Offset: 0x01095351
		public SplineLandingBinding(int SplineEntityId, int BorrowerPbDataId)
		{
			this.SplineEntityId = SplineEntityId;
			this.BorrowerPbDataId = BorrowerPbDataId;
		}

		// Token: 0x06043C7B RID: 277627 RVA: 0x01097168 File Offset: 0x01095368
		public USplineComponent TryGetSplineComponent()
		{
			if (this.Disposed)
			{
				return null;
			}
			if (this.SplineLoaded)
			{
				USplineComponent splineComp = this.SplineComp;
				if (splineComp == null || !splineComp.IsValid())
				{
					return null;
				}
				return this.SplineComp;
			}
			else
			{
				this.SplineLoaded = true;
				if (this.SplineEntityId == 0)
				{
					return null;
				}
				this.SplineComp = GameSplineModel.Instance.LoadAndGetSplineComponent(this.SplineEntityId, this.BorrowerPbDataId, EIdType.PbDataId);
				USplineComponent splineComp2 = this.SplineComp;
				if (splineComp2 == null || !splineComp2.IsValid())
				{
					return null;
				}
				return this.SplineComp;
			}
		}

		// Token: 0x06043C7C RID: 277628 RVA: 0x010971F0 File Offset: 0x010953F0
		public void Dispose()
		{
			if (this.Disposed)
			{
				return;
			}
			this.Disposed = true;
			if (this.SplineLoaded && this.SplineEntityId != 0)
			{
				GameSplineModel instance = GameSplineModel.Instance;
				if (instance != null)
				{
					instance.ReleaseSpline(this.SplineEntityId, (long)this.BorrowerPbDataId, EIdType.PbDataId);
				}
			}
			this.SplineComp = null;
			this.SplineLoaded = false;
		}

		// Token: 0x0402369F RID: 145055
		private USplineComponent SplineComp;

		// Token: 0x040236A0 RID: 145056
		private bool SplineLoaded;

		// Token: 0x040236A1 RID: 145057
		private bool Disposed;

		// Token: 0x040236A2 RID: 145058
		public readonly int SplineEntityId;

		// Token: 0x040236A3 RID: 145059
		private readonly int BorrowerPbDataId;
	}
}

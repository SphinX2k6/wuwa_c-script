using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BEC RID: 23532
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineLandingBinding
	{
		// Token: 0x06039CC8 RID: 236744 RVA: 0x0103B9A5 File Offset: 0x01039BA5
		public SplineLandingBinding(int SplineEntityId, int BorrowerPbDataId)
		{
			this.SplineEntityId = SplineEntityId;
			this.BorrowerPbDataId = BorrowerPbDataId;
		}

		// Token: 0x06039CC9 RID: 236745 RVA: 0x0103B9BC File Offset: 0x01039BBC
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

		// Token: 0x06039CCA RID: 236746 RVA: 0x0103BA44 File Offset: 0x01039C44
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

		// Token: 0x0401E891 RID: 125073
		private USplineComponent SplineComp;

		// Token: 0x0401E892 RID: 125074
		private bool SplineLoaded;

		// Token: 0x0401E893 RID: 125075
		private bool Disposed;

		// Token: 0x0401E894 RID: 125076
		public readonly int SplineEntityId;

		// Token: 0x0401E895 RID: 125077
		private readonly int BorrowerPbDataId;
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag.Capability
{
	// Token: 0x020071AF RID: 29103
	[NullableContext(2)]
	[Nullable(0)]
	public class SnapInterpolationData : CapabilityData
	{
		// Token: 0x06047379 RID: 291705 RVA: 0x01219A79 File Offset: 0x01217C79
		public SnapInterpolationData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0604737A RID: 291706 RVA: 0x01219A8D File Offset: 0x01217C8D
		public override void OnAdded()
		{
		}

		// Token: 0x0604737B RID: 291707 RVA: 0x01219A8F File Offset: 0x01217C8F
		public override void OnRemoved()
		{
			this.Active = false;
			this.Elapsed = 0f;
			this.SetDistanceFunc = null;
		}

		// Token: 0x0604737C RID: 291708 RVA: 0x01219AAC File Offset: 0x01217CAC
		[NullableContext(1)]
		public void SetDistance(float startDistance, float targetDistance, Func<float, bool, float> setDistanceFunc, float? duration = null)
		{
			this.StartDistance = startDistance;
			this.TargetDistance = targetDistance;
			this.SetDistanceFunc = setDistanceFunc;
			float duration2;
			if (duration != null)
			{
				float? num = duration;
				float num2 = 0f;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					duration2 = duration.Value;
					goto IL_4A;
				}
			}
			duration2 = SnapInterpolationData.DefaultSnapInterpDuration;
			IL_4A:
			this.Duration = duration2;
			this.Elapsed = 0f;
			this.Active = true;
		}

		// Token: 0x0604737D RID: 291709 RVA: 0x01219B1A File Offset: 0x01217D1A
		public void Clear()
		{
			this.Active = false;
			this.Elapsed = 0f;
		}

		// Token: 0x04025727 RID: 153383
		public static readonly float DefaultSnapInterpDuration = 0.5f;

		// Token: 0x04025728 RID: 153384
		public Func<float, bool, float> SetDistanceFunc;

		// Token: 0x04025729 RID: 153385
		public float Duration = SnapInterpolationData.DefaultSnapInterpDuration;

		// Token: 0x0402572A RID: 153386
		public bool Active;

		// Token: 0x0402572B RID: 153387
		public float StartDistance;

		// Token: 0x0402572C RID: 153388
		public float TargetDistance;

		// Token: 0x0402572D RID: 153389
		public float Elapsed;
	}
}

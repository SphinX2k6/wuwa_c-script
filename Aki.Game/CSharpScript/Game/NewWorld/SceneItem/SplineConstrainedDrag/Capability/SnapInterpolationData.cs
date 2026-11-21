using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag.Capability
{
	// Token: 0x02006264 RID: 25188
	[NullableContext(2)]
	[Nullable(0)]
	public class SnapInterpolationData : CapabilityData
	{
		// Token: 0x0603CC74 RID: 248948 RVA: 0x0117397D File Offset: 0x01171B7D
		public SnapInterpolationData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0603CC75 RID: 248949 RVA: 0x01173991 File Offset: 0x01171B91
		public override void OnAdded()
		{
		}

		// Token: 0x0603CC76 RID: 248950 RVA: 0x01173993 File Offset: 0x01171B93
		public override void OnRemoved()
		{
			this.Active = false;
			this.Elapsed = 0f;
			this.SetDistanceFunc = null;
		}

		// Token: 0x0603CC77 RID: 248951 RVA: 0x011739B0 File Offset: 0x01171BB0
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

		// Token: 0x0603CC78 RID: 248952 RVA: 0x01173A1E File Offset: 0x01171C1E
		public void Clear()
		{
			this.Active = false;
			this.Elapsed = 0f;
		}

		// Token: 0x04020396 RID: 131990
		public static readonly float DefaultSnapInterpDuration = 0.5f;

		// Token: 0x04020397 RID: 131991
		public Func<float, bool, float> SetDistanceFunc;

		// Token: 0x04020398 RID: 131992
		public float Duration = SnapInterpolationData.DefaultSnapInterpDuration;

		// Token: 0x04020399 RID: 131993
		public bool Active;

		// Token: 0x0402039A RID: 131994
		public float StartDistance;

		// Token: 0x0402039B RID: 131995
		public float TargetDistance;

		// Token: 0x0402039C RID: 131996
		public float Elapsed;
	}
}

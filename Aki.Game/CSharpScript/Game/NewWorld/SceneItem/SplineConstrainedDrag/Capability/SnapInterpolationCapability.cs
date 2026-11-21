using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag.Capability
{
	// Token: 0x02006263 RID: 25187
	public class SnapInterpolationCapability : Capability
	{
		// Token: 0x0603CC6B RID: 248939 RVA: 0x011737DB File Offset: 0x011719DB
		[NullableContext(2)]
		public SnapInterpolationCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0603CC6C RID: 248940 RVA: 0x011737E4 File Offset: 0x011719E4
		[NullableContext(1)]
		protected override ICapabilityConfig GetDefaultConfig()
		{
			return new CapabilityConfig
			{
				Tags = new List<int>(),
				TickGroup = new ETickingGroup?(ETickingGroup.TG_PrePhysics),
				TickGroupOrder = 100,
				InterruptsTags = new List<int>()
			};
		}

		// Token: 0x0603CC6D RID: 248941 RVA: 0x01173815 File Offset: 0x01171A15
		public override void Setup()
		{
		}

		// Token: 0x0603CC6E RID: 248942 RVA: 0x01173817 File Offset: 0x01171A17
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x0603CC6F RID: 248943 RVA: 0x0117381C File Offset: 0x01171A1C
		public override bool ShouldActivate()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			if (ownerGameObject == null)
			{
				return false;
			}
			SnapInterpolationData capabilityData = ownerGameObject.GetCapabilityData<SnapInterpolationData>(typeof(SnapInterpolationData));
			return ((capabilityData != null) ? new bool?(capabilityData.Active) : null).GetValueOrDefault();
		}

		// Token: 0x0603CC70 RID: 248944 RVA: 0x01173868 File Offset: 0x01171A68
		public override bool ShouldDeactivate()
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			if (ownerGameObject == null)
			{
				return true;
			}
			SnapInterpolationData capabilityData = ownerGameObject.GetCapabilityData<SnapInterpolationData>(typeof(SnapInterpolationData));
			return !((capabilityData != null) ? new bool?(capabilityData.Active) : null).GetValueOrDefault();
		}

		// Token: 0x0603CC71 RID: 248945 RVA: 0x011738B4 File Offset: 0x01171AB4
		public override void OnActivated()
		{
		}

		// Token: 0x0603CC72 RID: 248946 RVA: 0x011738B6 File Offset: 0x01171AB6
		public override void OnDeactivated()
		{
		}

		// Token: 0x0603CC73 RID: 248947 RVA: 0x011738B8 File Offset: 0x01171AB8
		public override void TickActive(float deltaMilliseconds)
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			SnapInterpolationData snapInterpolationData = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<SnapInterpolationData>(typeof(SnapInterpolationData)) : null;
			if (snapInterpolationData == null || !snapInterpolationData.Active || snapInterpolationData.SetDistanceFunc == null)
			{
				return;
			}
			snapInterpolationData.Elapsed += deltaMilliseconds * 0.001f;
			float duration = snapInterpolationData.Duration;
			float num = (duration > 0f) ? MathUtils.Instance.Clamp(snapInterpolationData.Elapsed / duration, 0f, 1f) : 1f;
			float arg = MathUtils.Instance.Lerp(snapInterpolationData.StartDistance, snapInterpolationData.TargetDistance, num);
			snapInterpolationData.SetDistanceFunc(arg, false);
			if (num >= 1f)
			{
				snapInterpolationData.Active = false;
				snapInterpolationData.Elapsed = 0f;
			}
		}
	}
}

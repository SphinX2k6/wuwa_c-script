using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag.Capability
{
	// Token: 0x020071AE RID: 29102
	public class SnapInterpolationCapability : Capability
	{
		// Token: 0x06047370 RID: 291696 RVA: 0x012198D7 File Offset: 0x01217AD7
		[NullableContext(2)]
		public SnapInterpolationCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x06047371 RID: 291697 RVA: 0x012198E0 File Offset: 0x01217AE0
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

		// Token: 0x06047372 RID: 291698 RVA: 0x01219911 File Offset: 0x01217B11
		public override void Setup()
		{
		}

		// Token: 0x06047373 RID: 291699 RVA: 0x01219913 File Offset: 0x01217B13
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x06047374 RID: 291700 RVA: 0x01219918 File Offset: 0x01217B18
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

		// Token: 0x06047375 RID: 291701 RVA: 0x01219964 File Offset: 0x01217B64
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

		// Token: 0x06047376 RID: 291702 RVA: 0x012199B0 File Offset: 0x01217BB0
		public override void OnActivated()
		{
		}

		// Token: 0x06047377 RID: 291703 RVA: 0x012199B2 File Offset: 0x01217BB2
		public override void OnDeactivated()
		{
		}

		// Token: 0x06047378 RID: 291704 RVA: 0x012199B4 File Offset: 0x01217BB4
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

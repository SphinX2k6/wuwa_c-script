using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.LevelplayCapability
{
	// Token: 0x02005DAB RID: 23979
	[NullableContext(2)]
	[Nullable(0)]
	public class DragActorPlayCameraConfigDataComponent : CapabilityData
	{
		// Token: 0x0603A607 RID: 239111 RVA: 0x0107D1CF File Offset: 0x0107B3CF
		public DragActorPlayCameraConfigDataComponent(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0603A608 RID: 239112 RVA: 0x0107D1D8 File Offset: 0x0107B3D8
		public override void OnAdded()
		{
		}

		// Token: 0x0603A609 RID: 239113 RVA: 0x0107D1DA File Offset: 0x0107B3DA
		public override void OnRemoved()
		{
		}

		// Token: 0x0401EC2E RID: 125998
		public IFixedCameraConfig CameraConfig;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.LevelplayCapability
{
	// Token: 0x02006C32 RID: 27698
	[NullableContext(2)]
	[Nullable(0)]
	public class DragActorPlayCameraConfigDataComponent : CapabilityData
	{
		// Token: 0x060444AF RID: 279727 RVA: 0x010D327B File Offset: 0x010D147B
		public DragActorPlayCameraConfigDataComponent(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060444B0 RID: 279728 RVA: 0x010D3284 File Offset: 0x010D1484
		public override void OnAdded()
		{
		}

		// Token: 0x060444B1 RID: 279729 RVA: 0x010D3286 File Offset: 0x010D1486
		public override void OnRemoved()
		{
		}

		// Token: 0x0402398C RID: 145804
		public IFixedCameraConfig CameraConfig;
	}
}

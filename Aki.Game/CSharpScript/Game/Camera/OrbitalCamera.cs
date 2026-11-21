using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006454 RID: 25684
	[NullableContext(2)]
	[Nullable(0)]
	public class OrbitalCamera : Entity
	{
		// Token: 0x0603E637 RID: 255543 RVA: 0x01224378 File Offset: 0x01222578
		public OrbitalCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E638 RID: 255544 RVA: 0x01224382 File Offset: 0x01222582
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x170076AE RID: 30382
		// (get) Token: 0x0603E639 RID: 255545 RVA: 0x01224393 File Offset: 0x01222593
		// (set) Token: 0x0603E63A RID: 255546 RVA: 0x0122439B File Offset: 0x0122259B
		public SequenceCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x170076AF RID: 30383
		// (get) Token: 0x0603E63B RID: 255547 RVA: 0x012243A4 File Offset: 0x012225A4
		// (set) Token: 0x0603E63C RID: 255548 RVA: 0x012243AC File Offset: 0x012225AC
		public OrbitalCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x0603E63D RID: 255549 RVA: 0x012243B8 File Offset: 0x012225B8
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create OrbitalCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<SequenceCameraDisplayComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<OrbitalCameraPlayerComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x0603E63E RID: 255550 RVA: 0x0122442F File Offset: 0x0122262F
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SequenceCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<OrbitalCameraPlayerComponent>();
			return true;
		}

		// Token: 0x0603E63F RID: 255551 RVA: 0x0122444A File Offset: 0x0122264A
		protected override bool OnClear()
		{
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			return true;
		}
	}
}

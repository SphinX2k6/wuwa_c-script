using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D2 RID: 29394
	[NullableContext(2)]
	[Nullable(0)]
	public class OrbitalCamera : Entity
	{
		// Token: 0x06048228 RID: 295464 RVA: 0x01281AC4 File Offset: 0x0127FCC4
		public OrbitalCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x06048229 RID: 295465 RVA: 0x01281ACE File Offset: 0x0127FCCE
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F39 RID: 40761
		// (get) Token: 0x0604822A RID: 295466 RVA: 0x01281ADF File Offset: 0x0127FCDF
		// (set) Token: 0x0604822B RID: 295467 RVA: 0x01281AE7 File Offset: 0x0127FCE7
		public SequenceCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x17009F3A RID: 40762
		// (get) Token: 0x0604822C RID: 295468 RVA: 0x01281AF0 File Offset: 0x0127FCF0
		// (set) Token: 0x0604822D RID: 295469 RVA: 0x01281AF8 File Offset: 0x0127FCF8
		public OrbitalCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x0604822E RID: 295470 RVA: 0x01281B04 File Offset: 0x0127FD04
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

		// Token: 0x0604822F RID: 295471 RVA: 0x01281B7B File Offset: 0x0127FD7B
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SequenceCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<OrbitalCameraPlayerComponent>();
			return true;
		}

		// Token: 0x06048230 RID: 295472 RVA: 0x01281B96 File Offset: 0x0127FD96
		protected override bool OnClear()
		{
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			return true;
		}
	}
}

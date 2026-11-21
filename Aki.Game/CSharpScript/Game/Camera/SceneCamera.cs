using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006456 RID: 25686
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCamera : Entity
	{
		// Token: 0x0603E656 RID: 255574 RVA: 0x01224D7E File Offset: 0x01222F7E
		public SceneCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E657 RID: 255575 RVA: 0x01224D88 File Offset: 0x01222F88
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x170076B5 RID: 30389
		// (get) Token: 0x0603E658 RID: 255576 RVA: 0x01224D99 File Offset: 0x01222F99
		public AActor CameraActor
		{
			get
			{
				SceneCameraDisplayComponent displayComponent = this.DisplayComponent;
				if (displayComponent == null)
				{
					return null;
				}
				return displayComponent.CineCamera;
			}
		}

		// Token: 0x170076B6 RID: 30390
		// (get) Token: 0x0603E659 RID: 255577 RVA: 0x01224DAC File Offset: 0x01222FAC
		// (set) Token: 0x0603E65A RID: 255578 RVA: 0x01224DB4 File Offset: 0x01222FB4
		public SceneCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x170076B7 RID: 30391
		// (get) Token: 0x0603E65B RID: 255579 RVA: 0x01224DBD File Offset: 0x01222FBD
		// (set) Token: 0x0603E65C RID: 255580 RVA: 0x01224DC5 File Offset: 0x01222FC5
		public SceneCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x170076B8 RID: 30392
		// (get) Token: 0x0603E65D RID: 255581 RVA: 0x01224DCE File Offset: 0x01222FCE
		// (set) Token: 0x0603E65E RID: 255582 RVA: 0x01224DD6 File Offset: 0x01222FD6
		public SceneCameraInputComponent InputComponent { get; private set; }

		// Token: 0x0603E65F RID: 255583 RVA: 0x01224DE0 File Offset: 0x01222FE0
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create SceneCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<SceneCameraDisplayComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<SceneCameraPlayerComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<SceneCameraInputComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x0603E660 RID: 255584 RVA: 0x01224E72 File Offset: 0x01223072
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SceneCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<SceneCameraPlayerComponent>();
			this.InputComponent = base.GetComponent<SceneCameraInputComponent>();
			return true;
		}

		// Token: 0x0603E661 RID: 255585 RVA: 0x01224E99 File Offset: 0x01223099
		protected override bool OnClear()
		{
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			this.InputComponent = null;
			return true;
		}
	}
}

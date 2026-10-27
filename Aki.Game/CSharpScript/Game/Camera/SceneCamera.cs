using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D4 RID: 29396
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCamera : Entity
	{
		// Token: 0x06048242 RID: 295490 RVA: 0x01282596 File Offset: 0x01280796
		public SceneCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x06048243 RID: 295491 RVA: 0x012825A0 File Offset: 0x012807A0
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F3B RID: 40763
		// (get) Token: 0x06048244 RID: 295492 RVA: 0x012825B1 File Offset: 0x012807B1
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

		// Token: 0x17009F3C RID: 40764
		// (get) Token: 0x06048245 RID: 295493 RVA: 0x012825C4 File Offset: 0x012807C4
		// (set) Token: 0x06048246 RID: 295494 RVA: 0x012825CC File Offset: 0x012807CC
		public SceneCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x17009F3D RID: 40765
		// (get) Token: 0x06048247 RID: 295495 RVA: 0x012825D5 File Offset: 0x012807D5
		// (set) Token: 0x06048248 RID: 295496 RVA: 0x012825DD File Offset: 0x012807DD
		public SceneCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x17009F3E RID: 40766
		// (get) Token: 0x06048249 RID: 295497 RVA: 0x012825E6 File Offset: 0x012807E6
		// (set) Token: 0x0604824A RID: 295498 RVA: 0x012825EE File Offset: 0x012807EE
		public SceneCameraInputComponent InputComponent { get; private set; }

		// Token: 0x0604824B RID: 295499 RVA: 0x012825F8 File Offset: 0x012807F8
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

		// Token: 0x0604824C RID: 295500 RVA: 0x0128268A File Offset: 0x0128088A
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SceneCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<SceneCameraPlayerComponent>();
			this.InputComponent = base.GetComponent<SceneCameraInputComponent>();
			return true;
		}

		// Token: 0x0604824D RID: 295501 RVA: 0x012826B1 File Offset: 0x012808B1
		protected override bool OnClear()
		{
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			this.InputComponent = null;
			return true;
		}
	}
}

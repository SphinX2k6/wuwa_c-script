using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006450 RID: 25680
	[NullableContext(2)]
	[Nullable(0)]
	public class FreeCamera : Entity
	{
		// Token: 0x0603E5E8 RID: 255464 RVA: 0x01222396 File Offset: 0x01220596
		public FreeCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E5E9 RID: 255465 RVA: 0x012223A0 File Offset: 0x012205A0
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x170076A0 RID: 30368
		// (get) Token: 0x0603E5EA RID: 255466 RVA: 0x012223B1 File Offset: 0x012205B1
		// (set) Token: 0x0603E5EB RID: 255467 RVA: 0x012223B9 File Offset: 0x012205B9
		public FreeCameraLogicComponent LogicComponent { get; private set; }

		// Token: 0x170076A1 RID: 30369
		// (get) Token: 0x0603E5EC RID: 255468 RVA: 0x012223C2 File Offset: 0x012205C2
		// (set) Token: 0x0603E5ED RID: 255469 RVA: 0x012223CA File Offset: 0x012205CA
		public FreeCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x170076A2 RID: 30370
		// (get) Token: 0x0603E5EE RID: 255470 RVA: 0x012223D3 File Offset: 0x012205D3
		// (set) Token: 0x0603E5EF RID: 255471 RVA: 0x012223DB File Offset: 0x012205DB
		public FreeCameraInputComponent InputComponent { get; private set; }

		// Token: 0x0603E5F0 RID: 255472 RVA: 0x012223E4 File Offset: 0x012205E4
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create FreeCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<FreeCameraLogicComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<FreeCameraDisplayComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<FreeCameraInputComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x0603E5F1 RID: 255473 RVA: 0x01222476 File Offset: 0x01220676
		protected override bool OnStart()
		{
			this.LogicComponent = base.GetComponent<FreeCameraLogicComponent>();
			this.DisplayComponent = base.GetComponent<FreeCameraDisplayComponent>();
			this.InputComponent = base.GetComponent<FreeCameraInputComponent>();
			return true;
		}

		// Token: 0x0603E5F2 RID: 255474 RVA: 0x0122249D File Offset: 0x0122069D
		protected override bool OnClear()
		{
			this.LogicComponent = null;
			this.DisplayComponent = null;
			this.InputComponent = null;
			return true;
		}
	}
}

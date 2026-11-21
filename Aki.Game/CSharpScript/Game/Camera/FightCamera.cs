using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200644E RID: 25678
	[NullableContext(2)]
	[Nullable(0)]
	public class FightCamera : Entity
	{
		// Token: 0x0603E5D1 RID: 255441 RVA: 0x01221FB6 File Offset: 0x012201B6
		public FightCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E5D2 RID: 255442 RVA: 0x01221FC0 File Offset: 0x012201C0
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17007699 RID: 30361
		// (get) Token: 0x0603E5D3 RID: 255443 RVA: 0x01221FD1 File Offset: 0x012201D1
		// (set) Token: 0x0603E5D4 RID: 255444 RVA: 0x01221FD9 File Offset: 0x012201D9
		public FightCameraLogicComponent LogicComponent { get; private set; }

		// Token: 0x1700769A RID: 30362
		// (get) Token: 0x0603E5D5 RID: 255445 RVA: 0x01221FE2 File Offset: 0x012201E2
		// (set) Token: 0x0603E5D6 RID: 255446 RVA: 0x01221FEA File Offset: 0x012201EA
		public FightCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x0603E5D7 RID: 255447 RVA: 0x01221FF4 File Offset: 0x012201F4
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create FightCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<FightCameraLogicComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<FightCameraDisplayComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x0603E5D8 RID: 255448 RVA: 0x0122206B File Offset: 0x0122026B
		protected override bool OnStart()
		{
			this.LogicComponent = base.GetComponent<FightCameraLogicComponent>();
			this.DisplayComponent = base.GetComponent<FightCameraDisplayComponent>();
			return true;
		}

		// Token: 0x0603E5D9 RID: 255449 RVA: 0x01222086 File Offset: 0x01220286
		protected override bool OnClear()
		{
			this.LogicComponent = null;
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x0603E5DA RID: 255450 RVA: 0x01222098 File Offset: 0x01220298
		public override void Tick(float delta)
		{
			Stat stat;
			StatDefine.battleStat.TryGetValue("FightCameraTick", out stat);
			base.Tick(delta);
			Stat stat2;
			StatDefine.battleStat.TryGetValue("FightCameraTick", out stat2);
		}
	}
}

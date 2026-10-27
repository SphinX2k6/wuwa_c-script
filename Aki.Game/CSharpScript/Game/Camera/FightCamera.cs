using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072CC RID: 29388
	[NullableContext(2)]
	[Nullable(0)]
	public class FightCamera : Entity
	{
		// Token: 0x060481CE RID: 295374 RVA: 0x0127F4BA File Offset: 0x0127D6BA
		public FightCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x060481CF RID: 295375 RVA: 0x0127F4C4 File Offset: 0x0127D6C4
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F30 RID: 40752
		// (get) Token: 0x060481D0 RID: 295376 RVA: 0x0127F4D5 File Offset: 0x0127D6D5
		// (set) Token: 0x060481D1 RID: 295377 RVA: 0x0127F4DD File Offset: 0x0127D6DD
		public FightCameraLogicComponent LogicComponent { get; private set; }

		// Token: 0x17009F31 RID: 40753
		// (get) Token: 0x060481D2 RID: 295378 RVA: 0x0127F4E6 File Offset: 0x0127D6E6
		// (set) Token: 0x060481D3 RID: 295379 RVA: 0x0127F4EE File Offset: 0x0127D6EE
		public FightCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x060481D4 RID: 295380 RVA: 0x0127F4F8 File Offset: 0x0127D6F8
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

		// Token: 0x060481D5 RID: 295381 RVA: 0x0127F56F File Offset: 0x0127D76F
		protected override bool OnStart()
		{
			this.LogicComponent = base.GetComponent<FightCameraLogicComponent>();
			this.DisplayComponent = base.GetComponent<FightCameraDisplayComponent>();
			return true;
		}

		// Token: 0x060481D6 RID: 295382 RVA: 0x0127F58A File Offset: 0x0127D78A
		protected override bool OnClear()
		{
			this.LogicComponent = null;
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x060481D7 RID: 295383 RVA: 0x0127F59C File Offset: 0x0127D79C
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

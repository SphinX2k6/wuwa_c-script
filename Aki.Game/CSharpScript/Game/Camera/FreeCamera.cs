using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072CE RID: 29390
	[NullableContext(2)]
	[Nullable(0)]
	public class FreeCamera : Entity
	{
		// Token: 0x060481E1 RID: 295393 RVA: 0x0127F8A8 File Offset: 0x0127DAA8
		public FreeCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x060481E2 RID: 295394 RVA: 0x0127F8B2 File Offset: 0x0127DAB2
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F33 RID: 40755
		// (get) Token: 0x060481E3 RID: 295395 RVA: 0x0127F8C3 File Offset: 0x0127DAC3
		// (set) Token: 0x060481E4 RID: 295396 RVA: 0x0127F8CB File Offset: 0x0127DACB
		public FreeCameraLogicComponent LogicComponent { get; private set; }

		// Token: 0x17009F34 RID: 40756
		// (get) Token: 0x060481E5 RID: 295397 RVA: 0x0127F8D4 File Offset: 0x0127DAD4
		// (set) Token: 0x060481E6 RID: 295398 RVA: 0x0127F8DC File Offset: 0x0127DADC
		public FreeCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x17009F35 RID: 40757
		// (get) Token: 0x060481E7 RID: 295399 RVA: 0x0127F8E5 File Offset: 0x0127DAE5
		// (set) Token: 0x060481E8 RID: 295400 RVA: 0x0127F8ED File Offset: 0x0127DAED
		public FreeCameraInputComponent InputComponent { get; private set; }

		// Token: 0x060481E9 RID: 295401 RVA: 0x0127F8F8 File Offset: 0x0127DAF8
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

		// Token: 0x060481EA RID: 295402 RVA: 0x0127F98A File Offset: 0x0127DB8A
		protected override bool OnStart()
		{
			this.LogicComponent = base.GetComponent<FreeCameraLogicComponent>();
			this.DisplayComponent = base.GetComponent<FreeCameraDisplayComponent>();
			this.InputComponent = base.GetComponent<FreeCameraInputComponent>();
			return true;
		}

		// Token: 0x060481EB RID: 295403 RVA: 0x0127F9B1 File Offset: 0x0127DBB1
		protected override bool OnClear()
		{
			this.LogicComponent = null;
			this.DisplayComponent = null;
			this.InputComponent = null;
			return true;
		}
	}
}

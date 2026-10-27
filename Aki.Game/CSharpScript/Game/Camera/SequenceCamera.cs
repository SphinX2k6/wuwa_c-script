using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072DE RID: 29406
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceCamera : Entity
	{
		// Token: 0x0604829C RID: 295580 RVA: 0x012847F2 File Offset: 0x012829F2
		public SequenceCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0604829D RID: 295581 RVA: 0x012847FC File Offset: 0x012829FC
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F43 RID: 40771
		// (get) Token: 0x0604829E RID: 295582 RVA: 0x0128480D File Offset: 0x01282A0D
		// (set) Token: 0x0604829F RID: 295583 RVA: 0x01284815 File Offset: 0x01282A15
		public SequenceCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x17009F44 RID: 40772
		// (get) Token: 0x060482A0 RID: 295584 RVA: 0x0128481E File Offset: 0x01282A1E
		// (set) Token: 0x060482A1 RID: 295585 RVA: 0x01284826 File Offset: 0x01282A26
		public SequenceCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x060482A2 RID: 295586 RVA: 0x01284830 File Offset: 0x01282A30
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create SequenceCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<SequenceCameraDisplayComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<SequenceCameraPlayerComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x060482A3 RID: 295587 RVA: 0x012848A7 File Offset: 0x01282AA7
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SequenceCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<SequenceCameraPlayerComponent>();
			return true;
		}

		// Token: 0x060482A4 RID: 295588 RVA: 0x012848C2 File Offset: 0x01282AC2
		protected override bool OnClear()
		{
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			return true;
		}
	}
}

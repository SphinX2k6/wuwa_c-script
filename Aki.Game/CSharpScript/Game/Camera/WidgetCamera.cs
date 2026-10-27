using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072E3 RID: 29411
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCamera : Entity
	{
		// Token: 0x060482F9 RID: 295673 RVA: 0x01289718 File Offset: 0x01287918
		public WidgetCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x060482FA RID: 295674 RVA: 0x01289722 File Offset: 0x01287922
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x17009F47 RID: 40775
		// (get) Token: 0x060482FB RID: 295675 RVA: 0x01289733 File Offset: 0x01287933
		// (set) Token: 0x060482FC RID: 295676 RVA: 0x0128973B File Offset: 0x0128793B
		public WidgetCameraBlendComponent BlendComponent { get; private set; }

		// Token: 0x17009F48 RID: 40776
		// (get) Token: 0x060482FD RID: 295677 RVA: 0x01289744 File Offset: 0x01287944
		// (set) Token: 0x060482FE RID: 295678 RVA: 0x0128974C File Offset: 0x0128794C
		public WidgetCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x060482FF RID: 295679 RVA: 0x01289758 File Offset: 0x01287958
		protected override bool OnCreate(IEntityArgs args = null)
		{
			if (((args != null) ? args.GetP1<CameraModelInstance>() : null) == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create WidgetCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!base.AddComponent<WidgetCameraBlendComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<WidgetCameraDisplayComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x06048300 RID: 295680 RVA: 0x012897CF File Offset: 0x012879CF
		protected override bool OnStart()
		{
			this.BlendComponent = base.GetComponent<WidgetCameraBlendComponent>();
			this.DisplayComponent = base.GetComponent<WidgetCameraDisplayComponent>();
			return true;
		}

		// Token: 0x06048301 RID: 295681 RVA: 0x012897EA File Offset: 0x012879EA
		protected override bool OnClear()
		{
			this.BlendComponent = null;
			this.DisplayComponent = null;
			return true;
		}
	}
}

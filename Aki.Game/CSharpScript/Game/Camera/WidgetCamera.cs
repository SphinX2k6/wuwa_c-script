using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006466 RID: 25702
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCamera : Entity
	{
		// Token: 0x0603E73D RID: 255805 RVA: 0x0122C15C File Offset: 0x0122A35C
		public WidgetCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E73E RID: 255806 RVA: 0x0122C166 File Offset: 0x0122A366
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x170076DE RID: 30430
		// (get) Token: 0x0603E73F RID: 255807 RVA: 0x0122C177 File Offset: 0x0122A377
		// (set) Token: 0x0603E740 RID: 255808 RVA: 0x0122C17F File Offset: 0x0122A37F
		public WidgetCameraBlendComponent BlendComponent { get; private set; }

		// Token: 0x170076DF RID: 30431
		// (get) Token: 0x0603E741 RID: 255809 RVA: 0x0122C188 File Offset: 0x0122A388
		// (set) Token: 0x0603E742 RID: 255810 RVA: 0x0122C190 File Offset: 0x0122A390
		public WidgetCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x0603E743 RID: 255811 RVA: 0x0122C19C File Offset: 0x0122A39C
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

		// Token: 0x0603E744 RID: 255812 RVA: 0x0122C213 File Offset: 0x0122A413
		protected override bool OnStart()
		{
			this.BlendComponent = base.GetComponent<WidgetCameraBlendComponent>();
			this.DisplayComponent = base.GetComponent<WidgetCameraDisplayComponent>();
			return true;
		}

		// Token: 0x0603E745 RID: 255813 RVA: 0x0122C22E File Offset: 0x0122A42E
		protected override bool OnClear()
		{
			this.BlendComponent = null;
			this.DisplayComponent = null;
			return true;
		}
	}
}

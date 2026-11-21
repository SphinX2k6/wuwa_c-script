using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C5 RID: 14277
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelBackgroundAction : VisualNovelAction
	{
		// Token: 0x060252E6 RID: 152294 RVA: 0x00A7D2DA File Offset: 0x00A7B4DA
		public VisualNovelBackgroundAction(VisualNovelContext context, IVisualNovelBackgroundBase backgroundConfig) : base(context)
		{
			this.BackgroundConfig = backgroundConfig;
		}

		// Token: 0x060252E7 RID: 152295 RVA: 0x00A7D2EC File Offset: 0x00A7B4EC
		protected override UniTask ExecuteCoreAsync()
		{
			this.Background = base.Context.Scene.GetBackground();
			if (this.Background == null)
			{
				return UniTask.CompletedTask;
			}
			SetPlotMode plotMode = base.Context.Script.GetPlotMode();
			int? num;
			if (plotMode == null)
			{
				num = null;
			}
			else
			{
				IVisualNovelConfig visualNovelConfig = plotMode.VisualNovelConfig;
				num = ((visualNovelConfig != null) ? visualNovelConfig.InitialBackgroundId : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			IVisualNovelBackgroundBase backgroundConfig = this.BackgroundConfig;
			IVisualNovelBackgroundLoad visualNovelBackgroundLoad = backgroundConfig as IVisualNovelBackgroundLoad;
			UniTask result;
			if (visualNovelBackgroundLoad == null)
			{
				if (!(backgroundConfig is IVisualNovelBackgroundClean))
				{
					result = UniTask.CompletedTask;
				}
				else
				{
					result = this.Background.ApplyAsync(valueOrDefault);
				}
			}
			else
			{
				result = this.Background.ApplyAsync(visualNovelBackgroundLoad.BackgroundId);
			}
			return result;
		}

		// Token: 0x060252E8 RID: 152296 RVA: 0x00A7D3A6 File Offset: 0x00A7B5A6
		public override bool TryComplete()
		{
			if (!base.IsExecuting)
			{
				return false;
			}
			VisualNovelBackground background = this.Background;
			if (background != null)
			{
				background.FinishChange();
			}
			return true;
		}

		// Token: 0x060252E9 RID: 152297 RVA: 0x00A7D3C4 File Offset: 0x00A7B5C4
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				VisualNovelBackground background = this.Background;
				if (background == null)
				{
					return;
				}
				background.FinishChange();
			}
		}

		// Token: 0x04014910 RID: 84240
		private readonly IVisualNovelBackgroundBase BackgroundConfig;

		// Token: 0x04014911 RID: 84241
		[Nullable(2)]
		private VisualNovelBackground Background;
	}
}

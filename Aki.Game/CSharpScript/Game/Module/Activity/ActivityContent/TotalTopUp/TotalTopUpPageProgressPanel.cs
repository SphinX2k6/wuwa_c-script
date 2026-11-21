using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA3 RID: 20387
	public class TotalTopUpPageProgressPanel : UiPanelBase
	{
		// Token: 0x060331A1 RID: 209313 RVA: 0x00E52D44 File Offset: 0x00E50F44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x060331A2 RID: 209314 RVA: 0x00E52DE0 File Offset: 0x00E50FE0
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPageProgressPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPageProgressPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331A3 RID: 209315 RVA: 0x00E52E24 File Offset: 0x00E51024
		[NullableContext(1)]
		public void Refresh(TotalTopUpPageViewModel viewModel)
		{
			this.PageViewModel = viewModel;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(viewModel.CurrentScore.ToString(), true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(viewModel.NextScore.ToString(), true);
			}
			UUISprite sprite = base.GetSprite(2);
			float progressPercent = viewModel.ProgressPercent;
			if (sprite != null)
			{
				sprite.SetFillAmount(progressPercent);
			}
			bool flag = viewModel.ProgressPercent >= 1f;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x0401B21C RID: 111132
		[Nullable(2)]
		private TotalTopUpPageViewModel PageViewModel;

		// Token: 0x0401B21D RID: 111133
		[Nullable(2)]
		private TotalTopUpPageGetScoreBtnItem GetScoreBtn;

		// Token: 0x0200AC9E RID: 44190
		private class ENode
		{
			// Token: 0x04035652 RID: 218706
			public const int TextCurrentScore = 0;

			// Token: 0x04035653 RID: 218707
			public const int TextNextScore = 1;

			// Token: 0x04035654 RID: 218708
			public const int SpriteProgressBar = 2;

			// Token: 0x04035655 RID: 218709
			public const int BtnGetScore = 3;

			// Token: 0x04035656 RID: 218710
			public const int ItemProgressBar = 4;

			// Token: 0x04035657 RID: 218711
			public const int ItemFinished = 5;
		}
	}
}

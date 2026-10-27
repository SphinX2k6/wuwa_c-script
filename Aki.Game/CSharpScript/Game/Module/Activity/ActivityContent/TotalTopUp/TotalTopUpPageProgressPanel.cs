using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBC RID: 24508
	public class TotalTopUpPageProgressPanel : UiPanelBase
	{
		// Token: 0x0603E207 RID: 254471 RVA: 0x00F01088 File Offset: 0x00EFF288
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

		// Token: 0x0603E208 RID: 254472 RVA: 0x00F01124 File Offset: 0x00EFF324
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPageProgressPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPageProgressPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E209 RID: 254473 RVA: 0x00F01168 File Offset: 0x00EFF368
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

		// Token: 0x0402074A RID: 132938
		[Nullable(2)]
		private TotalTopUpPageViewModel PageViewModel;

		// Token: 0x0402074B RID: 132939
		[Nullable(2)]
		private TotalTopUpPageGetScoreBtnItem GetScoreBtn;

		// Token: 0x0200C293 RID: 49811
		private class ENode
		{
			// Token: 0x0403AC76 RID: 240758
			public const int TextCurrentScore = 0;

			// Token: 0x0403AC77 RID: 240759
			public const int TextNextScore = 1;

			// Token: 0x0403AC78 RID: 240760
			public const int SpriteProgressBar = 2;

			// Token: 0x0403AC79 RID: 240761
			public const int BtnGetScore = 3;

			// Token: 0x0403AC7A RID: 240762
			public const int ItemProgressBar = 4;

			// Token: 0x0403AC7B RID: 240763
			public const int ItemFinished = 5;
		}
	}
}

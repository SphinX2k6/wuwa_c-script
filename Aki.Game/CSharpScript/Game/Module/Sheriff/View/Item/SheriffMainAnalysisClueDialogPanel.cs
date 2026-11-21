using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1A RID: 15386
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainAnalysisClueDialogPanel : UiPanelBase
	{
		// Token: 0x060276C5 RID: 161477 RVA: 0x00B0DA78 File Offset: 0x00B0BC78
		public SheriffMainAnalysisClueDialogPanel(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x060276C6 RID: 161478 RVA: 0x00B0DA88 File Offset: 0x00B0BC88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnNextPage));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060276C7 RID: 161479 RVA: 0x00B0DC3C File Offset: 0x00B0BE3C
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.NextBtn = new ButtonItem(base.GetItem(7));
			this.NextBtn.SetFunction(new Action<int>(this.OnClickBtnRight));
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (playerGender == EPlayerGender.None)
			{
				return;
			}
			string resourceId = (playerGender == EPlayerGender.Male) ? "T_SkyEyeRoleMale" : "T_SkyEyeRoleFemale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x060276C8 RID: 161480 RVA: 0x00B0DCC8 File Offset: 0x00B0BEC8
		public void RefreshTitleText(string text)
		{
			base.GetText(3).ShowTextNew(text);
		}

		// Token: 0x060276C9 RID: 161481 RVA: 0x00B0DCD7 File Offset: 0x00B0BED7
		public void RefreshDialogText(string text)
		{
			base.GetText(4).ShowTextNew(text);
		}

		// Token: 0x060276CA RID: 161482 RVA: 0x00B0DCE8 File Offset: 0x00B0BEE8
		public void RefreshDialogPanel(EClueState state)
		{
			base.GetSprite(8).SetUIActive(state == EClueState.Success);
			base.GetItem(2).SetUIActive(state != EClueState.Success);
			base.GetItem(5).SetUIActive(state != EClueState.Success);
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == EClueState.Success);
			}
			ButtonItem nextBtn = this.NextBtn;
			if (nextBtn != null)
			{
				nextBtn.SetUiActive(state == EClueState.Conclusion);
			}
			UUIButtonComponent button2 = base.GetButton(6);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(state == EClueState.Fail);
			}
			if (state == EClueState.Conclusion)
			{
				UiManager.Instance.OpenView(EUiViewName.SheriffAnalysisResultPop, true, null);
				return;
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x060276CB RID: 161483 RVA: 0x00B0DDBC File Offset: 0x00B0BFBC
		public void RefreshNextBtnText(bool isEnding)
		{
			string textId = isEnding ? "Inference_Desc_21" : "Inference_Desc_12";
			this.NextBtn.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x060276CC RID: 161484 RVA: 0x00B0DDEA File Offset: 0x00B0BFEA
		public void SetNextQuestionIdOrEnding(ISheriffQuestionResultJsonConfig config)
		{
			this.QuestionConfig = config;
		}

		// Token: 0x060276CD RID: 161485 RVA: 0x00B0DDF3 File Offset: 0x00B0BFF3
		private void OnClickBtnLeft()
		{
			this.Proxy.DoAfterAnalysisClueLogic(true, null);
		}

		// Token: 0x060276CE RID: 161486 RVA: 0x00B0DE02 File Offset: 0x00B0C002
		private void OnClickBtnRight(int data)
		{
			this.Proxy.DoAfterAnalysisClueLogic(false, this.QuestionConfig);
		}

		// Token: 0x060276CF RID: 161487 RVA: 0x00B0DE16 File Offset: 0x00B0C016
		private void OnClickBtnNextPage()
		{
			Action refreshDialogCallback = this.RefreshDialogCallback;
			if (refreshDialogCallback == null)
			{
				return;
			}
			refreshDialogCallback();
		}

		// Token: 0x040157E8 RID: 88040
		protected SheriffMainProxy Proxy;

		// Token: 0x040157E9 RID: 88041
		[Nullable(2)]
		public Action RefreshDialogCallback;

		// Token: 0x040157EA RID: 88042
		[Nullable(2)]
		protected ButtonItem NextBtn;

		// Token: 0x040157EB RID: 88043
		[Nullable(2)]
		protected ISheriffQuestionResultJsonConfig QuestionConfig;

		// Token: 0x040157EC RID: 88044
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200983A RID: 38970
		[NullableContext(0)]
		private static class EDialogDefine
		{
			// Token: 0x0402F7AF RID: 194479
			public const int TexRole = 0;

			// Token: 0x0402F7B0 RID: 194480
			public const int BtnNextPage = 1;

			// Token: 0x0402F7B1 RID: 194481
			public const int PanelTitle = 2;

			// Token: 0x0402F7B2 RID: 194482
			public const int TxtTitle = 3;

			// Token: 0x0402F7B3 RID: 194483
			public const int TxtList = 4;

			// Token: 0x0402F7B4 RID: 194484
			public const int PanelBtn = 5;

			// Token: 0x0402F7B5 RID: 194485
			public const int BtnLeft = 6;

			// Token: 0x0402F7B6 RID: 194486
			public const int BtnRight = 7;

			// Token: 0x0402F7B7 RID: 194487
			public const int SpriteArrow = 8;
		}
	}
}

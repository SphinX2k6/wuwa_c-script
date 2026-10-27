using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C69 RID: 19561
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainAnalysisClueDialogPanel : UiPanelBase
	{
		// Token: 0x06032912 RID: 207122 RVA: 0x00BC8E14 File Offset: 0x00BC7014
		public SheriffMainAnalysisClueDialogPanel(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x06032913 RID: 207123 RVA: 0x00BC8E24 File Offset: 0x00BC7024
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

		// Token: 0x06032914 RID: 207124 RVA: 0x00BC8FD8 File Offset: 0x00BC71D8
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

		// Token: 0x06032915 RID: 207125 RVA: 0x00BC9064 File Offset: 0x00BC7264
		public void RefreshTitleText(string text)
		{
			base.GetText(3).ShowTextNew(text);
		}

		// Token: 0x06032916 RID: 207126 RVA: 0x00BC9073 File Offset: 0x00BC7273
		public void RefreshDialogText(string text)
		{
			base.GetText(4).ShowTextNew(text);
		}

		// Token: 0x06032917 RID: 207127 RVA: 0x00BC9084 File Offset: 0x00BC7284
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

		// Token: 0x06032918 RID: 207128 RVA: 0x00BC9158 File Offset: 0x00BC7358
		public void RefreshNextBtnText(bool isEnding)
		{
			string textId = isEnding ? "Inference_Desc_21" : "Inference_Desc_12";
			this.NextBtn.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x06032919 RID: 207129 RVA: 0x00BC9186 File Offset: 0x00BC7386
		public void SetNextQuestionIdOrEnding(ISheriffQuestionResultJsonConfig config)
		{
			this.QuestionConfig = config;
		}

		// Token: 0x0603291A RID: 207130 RVA: 0x00BC918F File Offset: 0x00BC738F
		private void OnClickBtnLeft()
		{
			this.Proxy.DoAfterAnalysisClueLogic(true, null);
		}

		// Token: 0x0603291B RID: 207131 RVA: 0x00BC919E File Offset: 0x00BC739E
		private void OnClickBtnRight(int data)
		{
			this.Proxy.DoAfterAnalysisClueLogic(false, this.QuestionConfig);
		}

		// Token: 0x0603291C RID: 207132 RVA: 0x00BC91B2 File Offset: 0x00BC73B2
		private void OnClickBtnNextPage()
		{
			Action refreshDialogCallback = this.RefreshDialogCallback;
			if (refreshDialogCallback == null)
			{
				return;
			}
			refreshDialogCallback();
		}

		// Token: 0x0401AE8B RID: 110219
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE8C RID: 110220
		[Nullable(2)]
		public Action RefreshDialogCallback;

		// Token: 0x0401AE8D RID: 110221
		[Nullable(2)]
		protected ButtonItem NextBtn;

		// Token: 0x0401AE8E RID: 110222
		[Nullable(2)]
		protected ISheriffQuestionResultJsonConfig QuestionConfig;

		// Token: 0x0401AE8F RID: 110223
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AE1C RID: 44572
		[NullableContext(0)]
		private static class EDialogDefine
		{
			// Token: 0x04034E0A RID: 216586
			public const int TexRole = 0;

			// Token: 0x04034E0B RID: 216587
			public const int BtnNextPage = 1;

			// Token: 0x04034E0C RID: 216588
			public const int PanelTitle = 2;

			// Token: 0x04034E0D RID: 216589
			public const int TxtTitle = 3;

			// Token: 0x04034E0E RID: 216590
			public const int TxtList = 4;

			// Token: 0x04034E0F RID: 216591
			public const int PanelBtn = 5;

			// Token: 0x04034E10 RID: 216592
			public const int BtnLeft = 6;

			// Token: 0x04034E11 RID: 216593
			public const int BtnRight = 7;

			// Token: 0x04034E12 RID: 216594
			public const int SpriteArrow = 8;
		}
	}
}

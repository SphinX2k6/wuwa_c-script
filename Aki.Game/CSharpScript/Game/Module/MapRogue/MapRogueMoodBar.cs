using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005605 RID: 22021
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueMoodBar : UiPanelBase
	{
		// Token: 0x060380C0 RID: 229568 RVA: 0x00D46098 File Offset: 0x00D44298
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnInfo))
			};
		}

		// Token: 0x060380C1 RID: 229569 RVA: 0x00D46185 File Offset: 0x00D44385
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x060380C2 RID: 229570 RVA: 0x00D461A8 File Offset: 0x00D443A8
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMoodBar.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMoodBar.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060380C3 RID: 229571 RVA: 0x00D461EC File Offset: 0x00D443EC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MapRogueMoodBar.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MapRogueMoodBar.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060380C4 RID: 229572 RVA: 0x00D46230 File Offset: 0x00D44430
		protected override UniTask OnHideAsyncImplementImplement()
		{
			MapRogueMoodBar.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<MapRogueMoodBar.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060380C5 RID: 229573 RVA: 0x00D46274 File Offset: 0x00D44474
		public void SetMoodRuleId(int ruleId)
		{
			RogueResMoodRule? moodRuleById = MapRogueConfig.Instance.GetMoodRuleById(ruleId);
			if (moodRuleById == null)
			{
				return;
			}
			EMoodRuleType type = (EMoodRuleType)moodRuleById.Value.Type;
			if (type == EMoodRuleType.Safe)
			{
				this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Light", false, null, false);
				return;
			}
			if (type != EMoodRuleType.Danger)
			{
				return;
			}
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("LightRed", false, null, false);
		}

		// Token: 0x060380C6 RID: 229574 RVA: 0x00D462E7 File Offset: 0x00D444E7
		public void SetLimit(int min, int max)
		{
			this.PanelBarL.SetLimit(min);
			this.PanelBarR.SetLimit(max);
		}

		// Token: 0x060380C7 RID: 229575 RVA: 0x00D46304 File Offset: 0x00D44504
		public void SetCurrentValue(int value)
		{
			base.GetText(6).SetText(value.ToString(), true);
			UUITexture texture = base.GetTexture(0);
			string path = (value >= 0) ? "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconPositive.T_RogueIconPositive" : "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconNegative.T_RogueIconNegative";
			base.SetTextureShowUntilLoaded(path, texture, null);
			this.PanelBarL.SetCurrentValue(value);
			this.PanelBarR.SetCurrentValue(value);
		}

		// Token: 0x060380C8 RID: 229576 RVA: 0x00D46360 File Offset: 0x00D44560
		public void ShowPreviewValue(int changeValue, int curValue)
		{
			MapRogueMoodBar.<>c__DisplayClass14_0 CS$<>8__locals1 = new MapRogueMoodBar.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.changeValue = changeValue;
			CS$<>8__locals1.curValue = curValue;
			if (CS$<>8__locals1.changeValue == 0)
			{
				return;
			}
			UiAsyncTask task = new UiAsyncTask("MapRogueMoodBar.ShowPreviewValue", delegate()
			{
				MapRogueMoodBar.<>c__DisplayClass14_0.<<ShowPreviewValue>b__0>d <<ShowPreviewValue>b__0>d;
				<<ShowPreviewValue>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ShowPreviewValue>b__0>d.<>4__this = CS$<>8__locals1;
				<<ShowPreviewValue>b__0>d.<>1__state = -1;
				<<ShowPreviewValue>b__0>d.<>t__builder.Start<MapRogueMoodBar.<>c__DisplayClass14_0.<<ShowPreviewValue>b__0>d>(ref <<ShowPreviewValue>b__0>d);
				return <<ShowPreviewValue>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060380C9 RID: 229577 RVA: 0x00D463B4 File Offset: 0x00D445B4
		public void ClosePreviewValue()
		{
			base.GetItem(1).SetUIActive(false);
			UUIText text = base.GetText(6);
			UUIItem uuiitem = text;
			bool bUseChangeColor = false;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.PanelBarL.ClosePreviewValue();
			this.PanelBarR.ClosePreviewValue();
		}

		// Token: 0x060380CA RID: 229578 RVA: 0x00D46401 File Offset: 0x00D44601
		private void OnClickBtnInfo()
		{
			HelpController.Instance.OpenHelpById(262);
		}

		// Token: 0x060380CB RID: 229579 RVA: 0x00D46414 File Offset: 0x00D44614
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length < 2)
			{
				return null;
			}
			UUIItem guideUiItem = base.GetGuideUiItem(configParams[1]);
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}

		// Token: 0x0401D757 RID: 120663
		private const string POSITIVE_TEXTURE_PATH = "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconPositive.T_RogueIconPositive";

		// Token: 0x0401D758 RID: 120664
		private const string NEGATIVE_TEXTURE_PATH = "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconNegative.T_RogueIconNegative";

		// Token: 0x0401D759 RID: 120665
		private const int MOOD_HELP_ID = 262;

		// Token: 0x0401D75A RID: 120666
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401D75B RID: 120667
		[Nullable(2)]
		protected PanelBar PanelBarL;

		// Token: 0x0401D75C RID: 120668
		[Nullable(2)]
		protected PanelBar PanelBarR;
	}
}

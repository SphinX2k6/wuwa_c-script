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
	// Token: 0x020045DB RID: 17883
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueMoodBar : UiPanelBase
	{
		// Token: 0x0602CFBE RID: 184254 RVA: 0x00C93DE0 File Offset: 0x00C91FE0
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

		// Token: 0x0602CFBF RID: 184255 RVA: 0x00C93ECD File Offset: 0x00C920CD
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0602CFC0 RID: 184256 RVA: 0x00C93EF0 File Offset: 0x00C920F0
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMoodBar.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMoodBar.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CFC1 RID: 184257 RVA: 0x00C93F34 File Offset: 0x00C92134
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MapRogueMoodBar.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MapRogueMoodBar.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602CFC2 RID: 184258 RVA: 0x00C93F78 File Offset: 0x00C92178
		protected override UniTask OnHideAsyncImplementImplement()
		{
			MapRogueMoodBar.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<MapRogueMoodBar.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602CFC3 RID: 184259 RVA: 0x00C93FBC File Offset: 0x00C921BC
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

		// Token: 0x0602CFC4 RID: 184260 RVA: 0x00C9402F File Offset: 0x00C9222F
		public void SetLimit(int min, int max)
		{
			this.PanelBarL.SetLimit(min);
			this.PanelBarR.SetLimit(max);
		}

		// Token: 0x0602CFC5 RID: 184261 RVA: 0x00C9404C File Offset: 0x00C9224C
		public void SetCurrentValue(int value)
		{
			base.GetText(6).SetText(value.ToString(), true);
			UUITexture texture = base.GetTexture(0);
			string path = (value >= 0) ? "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconPositive.T_RogueIconPositive" : "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconNegative.T_RogueIconNegative";
			base.SetTextureShowUntilLoaded(path, texture, null);
			this.PanelBarL.SetCurrentValue(value);
			this.PanelBarR.SetCurrentValue(value);
		}

		// Token: 0x0602CFC6 RID: 184262 RVA: 0x00C940A8 File Offset: 0x00C922A8
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

		// Token: 0x0602CFC7 RID: 184263 RVA: 0x00C940FC File Offset: 0x00C922FC
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

		// Token: 0x0602CFC8 RID: 184264 RVA: 0x00C94149 File Offset: 0x00C92349
		private void OnClickBtnInfo()
		{
			HelpController.Instance.OpenHelpById(262);
		}

		// Token: 0x0602CFC9 RID: 184265 RVA: 0x00C9415C File Offset: 0x00C9235C
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

		// Token: 0x040181E2 RID: 98786
		private const string POSITIVE_TEXTURE_PATH = "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconPositive.T_RogueIconPositive";

		// Token: 0x040181E3 RID: 98787
		private const string NEGATIVE_TEXTURE_PATH = "/Game/Aki/UI/UIResources/UiRogue/Image/RogueView/T_RogueIconNegative.T_RogueIconNegative";

		// Token: 0x040181E4 RID: 98788
		private const int MOOD_HELP_ID = 262;

		// Token: 0x040181E5 RID: 98789
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x040181E6 RID: 98790
		[Nullable(2)]
		protected PanelBar PanelBarL;

		// Token: 0x040181E7 RID: 98791
		[Nullable(2)]
		protected PanelBar PanelBarR;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x02005410 RID: 21520
	public class MenuScrollSettingSwitchItem : MenuScrollSettingBaseItem
	{
		// Token: 0x06037014 RID: 225300 RVA: 0x00D08944 File Offset: 0x00D06B44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIExtendToggleSpriteTransition))
			};
		}

		// Token: 0x06037015 RID: 225301 RVA: 0x00D08A22 File Offset: 0x00D06C22
		protected override void OnStart()
		{
			base.GetButton(3).SetCanClickWhenDisable(true);
			base.GetButton(2).SetCanClickWhenDisable(true);
			this.AddOptionsEvent();
		}

		// Token: 0x06037016 RID: 225302 RVA: 0x00D08A44 File Offset: 0x00D06C44
		protected override void OnClear()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
			base.GetButton(2).OnClickCallBack.Unbind();
			base.GetButton(3).OnClickCallBack.Unbind();
		}

		// Token: 0x06037017 RID: 225303 RVA: 0x00D08A77 File Offset: 0x00D06C77
		[NullableContext(1)]
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
			this.RefreshOptions();
			this.RefreshDetailText();
			this.RefreshDetailSpriteVisible();
			this.RefreshDetailSprite().Forget();
		}

		// Token: 0x06037018 RID: 225304 RVA: 0x00D08AA3 File Offset: 0x00D06CA3
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x06037019 RID: 225305 RVA: 0x00D08AC8 File Offset: 0x00D06CC8
		private void RefreshOptions()
		{
			base.GetRootItem().SetUIActive(true);
			int index = this.GetIndex();
			this.SetOptionsText(index);
			this.RefreshInteractionGroup(index, true);
		}

		// Token: 0x0603701A RID: 225306 RVA: 0x00D08AF7 File Offset: 0x00D06CF7
		private void AddOptionsEvent()
		{
			base.GetButton(2).OnClickCallBack.Bind(new Action(this.OnLeftClickCallback));
			base.GetButton(3).OnClickCallBack.Bind(new Action(this.OnRightClickCallback));
		}

		// Token: 0x0603701B RID: 225307 RVA: 0x00D08B34 File Offset: 0x00D06D34
		public override void SetInteractionActive(bool val)
		{
			int index = this.GetIndex();
			this.RefreshInteractionGroup(index, val);
		}

		// Token: 0x0603701C RID: 225308 RVA: 0x00D08B50 File Offset: 0x00D06D50
		private void SetOptionsText(int index)
		{
			if (!this.Data.GetEnable())
			{
				string disableOverrideText = this.Data.GetDisableOverrideText();
				if (disableOverrideText != null)
				{
					base.GetText(1).ShowTextNew(disableOverrideText);
					return;
				}
			}
			string key = this.Data.OptionsNameList[index];
			if (this.NeedImageQualityCustomSpecial())
			{
				key = "MenuConfig_5_OptionsName_4";
			}
			base.GetText(1).ShowTextNew(key);
			base.GetSprite(7).SetUIActive(this.Data.IsRecommendIndex(index));
		}

		// Token: 0x0603701D RID: 225309 RVA: 0x00D08BCC File Offset: 0x00D06DCC
		public void RefreshInteractionGroup(int index, bool active = true)
		{
			if (active)
			{
				base.GetButton(3).SetSelfInteractive(this.NeedImageQualityCustomSpecial() || index != this.Data.OptionsNameList.Count - 1);
				base.GetButton(2).SetSelfInteractive(this.NeedImageQualityCustomSpecial() || index != 0);
				return;
			}
			base.GetButton(3).SetSelfInteractive(false);
			base.GetButton(2).SetSelfInteractive(false);
		}

		// Token: 0x0603701E RID: 225310 RVA: 0x00D08C41 File Offset: 0x00D06E41
		private void OnLeftClickCallback()
		{
			if (base.GetItemClickLimit(base.GetButton(2)))
			{
				return;
			}
			this.ClickCallbackFromCheckIndex(-1);
		}

		// Token: 0x0603701F RID: 225311 RVA: 0x00D08C5A File Offset: 0x00D06E5A
		private void OnRightClickCallback()
		{
			if (base.GetItemClickLimit(base.GetButton(3)))
			{
				return;
			}
			this.ClickCallbackFromCheckIndex(1);
		}

		// Token: 0x06037020 RID: 225312 RVA: 0x00D08C74 File Offset: 0x00D06E74
		private void ClickCallbackFromCheckIndex(int index)
		{
			int index2 = (int)Math.Floor((double)((float)this.GetIndex() + (float)index));
			if (this.NeedImageQualityCustomSpecial())
			{
				if (index > 0)
				{
					index2 = 0;
				}
				else
				{
					index2 = this.Data.OptionsNameList.Count - 1;
				}
			}
			this.FireSaveMenuChange((float)this.Data.OptionsValueList[index2]);
		}

		// Token: 0x06037021 RID: 225313 RVA: 0x00D08CD3 File Offset: 0x00D06ED3
		private bool NeedImageQualityCustomSpecial()
		{
			return this.Data.FunctionId == EFunction.IMAGEQUALITY && MenuModel.Instance.IsImageQualityCustom;
		}

		// Token: 0x06037022 RID: 225314 RVA: 0x00D08CF0 File Offset: 0x00D06EF0
		protected unsafe int GetIndex()
		{
			MenuModel instance = MenuModel.Instance;
			int? num = (instance != null) ? instance.GetDataCacheOrCurValue(this.Data.FunctionId) : null;
			IReadOnlyList<int> optionsValueList = this.Data.OptionsValueList;
			int num2 = optionsValueList.IndexOf(num.Value);
			if (num2 < 0)
			{
				int optionsDefault = this.Data.OptionsDefault;
				int num3 = optionsValueList.IndexOf(optionsDefault);
				if (num3 < 0)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Menu;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "默认值不存在于可选值列表中，请策划策划策划检查配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", this.Data.FunctionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Default Value", optionsDefault);
					instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				num2 = num3;
			}
			return num2;
		}

		// Token: 0x06037023 RID: 225315 RVA: 0x00D08DC8 File Offset: 0x00D06FC8
		protected override void OnSetDetailVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.CanClickWhenDisable && !this.Data.GetEnable())
			{
				FColor color = bVisible ? FColor.FromHex("FFF7B6FF") : FColor.FromHex("FFFFFFFF");
				base.GetSprite(6).SetColor(color);
				base.GetUiExtendToggleSpriteTransition(8).TransitionState.UnDetermineUnHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(8).TransitionState.UnDetermineHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(8).TransitionState.UnDeterminePressedState.Color = color;
			}
		}

		// Token: 0x06037024 RID: 225316 RVA: 0x00D08E78 File Offset: 0x00D07078
		private void RefreshDetailText()
		{
			if (this.Data == null)
			{
				return;
			}
			if (!this.Data.HasDetailText())
			{
				return;
			}
			UUIText text = base.GetText(5);
			string detailTextId = this.Data.GetDetailTextId();
			LguiUtil.Instance.SetLocalTextNew(text, detailTextId, Array.Empty<object>());
		}

		// Token: 0x06037025 RID: 225317 RVA: 0x00D08EC1 File Offset: 0x00D070C1
		private void RefreshDetailSpriteVisible()
		{
			if (this.Data == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(6);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(this.Data.ShowHelpBtn());
		}

		// Token: 0x06037026 RID: 225318 RVA: 0x00D08EE8 File Offset: 0x00D070E8
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingSwitchItem.<RefreshDetailSprite>d__19 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingSwitchItem.<RefreshDetailSprite>d__19>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0200B6A8 RID: 46760
		private class EComponents
		{
			// Token: 0x0403756B RID: 226667
			public const int Title = 0;

			// Token: 0x0403756C RID: 226668
			public const int TitleName = 1;

			// Token: 0x0403756D RID: 226669
			public const int LeftBtn = 2;

			// Token: 0x0403756E RID: 226670
			public const int RightBtn = 3;

			// Token: 0x0403756F RID: 226671
			public const int DetailItem = 4;

			// Token: 0x04037570 RID: 226672
			public const int DetailText = 5;

			// Token: 0x04037571 RID: 226673
			public const int DetailSprite = 6;

			// Token: 0x04037572 RID: 226674
			public const int RecommendIcon = 7;

			// Token: 0x04037573 RID: 226675
			public const int DetailToggleTransition = 8;
		}
	}
}

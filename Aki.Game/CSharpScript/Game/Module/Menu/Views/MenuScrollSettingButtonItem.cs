using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x0200540A RID: 21514
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingButtonItem : MenuScrollSettingBaseItem
	{
		// Token: 0x06036FAE RID: 225198 RVA: 0x00D06A08 File Offset: 0x00D04C08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggleSpriteTransition))
			};
		}

		// Token: 0x06036FAF RID: 225199 RVA: 0x00D06ABA File Offset: 0x00D04CBA
		protected override void OnStart()
		{
			this.ButtonItem = new ButtonItem(base.GetItem(1));
			this.ButtonItem.GetBtn().SetCanClickWhenDisable(true);
			this.ButtonItem.SetFunction(new Action<int>(this.OnButtonClickCallback));
		}

		// Token: 0x06036FB0 RID: 225200 RVA: 0x00D06AF6 File Offset: 0x00D04CF6
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
		}

		// Token: 0x06036FB1 RID: 225201 RVA: 0x00D06B08 File Offset: 0x00D04D08
		private void OnButtonClickCallback(int _)
		{
			if (base.GetItemClickLimit(this.ButtonItem.GetBtn()))
			{
				return;
			}
			EUiViewName euiViewName = (EUiViewName)this.Data.ButtonViewName;
			if (euiViewName.ToString().Contains(this.AccountSettingPrefix))
			{
				int type;
				if (int.TryParse(euiViewName.ToString().Substring(this.AccountSettingPrefix.Length), out type))
				{
					ChannelController.Instance.ProcessAccountSetting((EChannelAccountSetting)type);
				}
				return;
			}
			Action action;
			if (MenuController.Instance.OpenViewFuncMap.TryGetValue(euiViewName, out action))
			{
				action();
				return;
			}
			UiManager.Instance.OpenView(euiViewName, new object[]
			{
				this.Data,
				new Action<int, float>(delegate(int functionId, float index)
				{
					this.ChangeButton(functionId, (int)index);
				})
			}, null);
		}

		// Token: 0x06036FB2 RID: 225202 RVA: 0x00D06BCC File Offset: 0x00D04DCC
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
			this.RefreshButton();
			this.RefreshDetailText();
			this.RefreshDetailSpriteVisible();
			this.RefreshDetailSprite().Forget();
			this.SetInteractionActive(data.GetEnable());
			this.Data.OnRefresh();
			this.RefreshRedDot();
		}

		// Token: 0x06036FB3 RID: 225203 RVA: 0x00D06C20 File Offset: 0x00D04E20
		protected void RefreshTitle()
		{
			if (this.Data.CustomTitleArgs != null && this.Data.CustomTitleArgs.Length != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.FunctionName, this.Data.CustomTitleArgs.ToArray<string>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.FunctionName, Array.Empty<object>());
		}

		// Token: 0x06036FB4 RID: 225204 RVA: 0x00D06C98 File Offset: 0x00D04E98
		private void RefreshButton()
		{
			base.GetRootItem().SetUIActive(true);
			if (!this.Data.GetEnable())
			{
				string disableOverrideText = this.Data.GetDisableOverrideText();
				if (disableOverrideText != null)
				{
					base.GetText(2).ShowTextNew(disableOverrideText);
					return;
				}
			}
			int targetConfig = MenuController.Instance.GetTargetConfig(this.Data.FunctionId);
			if (this.Data.FunctionId == EFunction.RESOLUTION)
			{
				this.SetButtonTextForResolution(targetConfig, false);
				return;
			}
			this.SetButtonText((this.Data.OptionsNameList.Count > targetConfig) ? this.Data.OptionsNameList[targetConfig] : null, targetConfig, false);
		}

		// Token: 0x06036FB5 RID: 225205 RVA: 0x00D06D38 File Offset: 0x00D04F38
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
			UUIText text = base.GetText(4);
			string detailTextId = this.Data.GetDetailTextId();
			LguiUtil.Instance.SetLocalTextNew(text, detailTextId, Array.Empty<object>());
		}

		// Token: 0x06036FB6 RID: 225206 RVA: 0x00D06D81 File Offset: 0x00D04F81
		private void RefreshDetailSpriteVisible()
		{
			if (this.Data == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(this.Data.ShowHelpBtn());
		}

		// Token: 0x06036FB7 RID: 225207 RVA: 0x00D06DA8 File Offset: 0x00D04FA8
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingButtonItem.<RefreshDetailSprite>d__13 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingButtonItem.<RefreshDetailSprite>d__13>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x06036FB8 RID: 225208 RVA: 0x00D06DEC File Offset: 0x00D04FEC
		private void ChangeButton(int functionId, int index)
		{
			if (this.Data == null)
			{
				return;
			}
			if (functionId != (int)this.Data.FunctionId)
			{
				return;
			}
			if (functionId == 6)
			{
				this.SetButtonTextForResolution(index, true);
				return;
			}
			if (functionId == 7)
			{
				this.FireSaveMenuChange((float)index);
				return;
			}
			this.SetButtonText(this.Data.OptionsNameList[index], index, true);
		}

		// Token: 0x06036FB9 RID: 225209 RVA: 0x00D06E4C File Offset: 0x00D0504C
		private void SetButtonTextForResolution(int index, bool fire = false)
		{
			string newText;
			if (MenuController.Instance.GetTargetConfig(EFunction.DISPLAYMODE) == 0)
			{
				FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
				newText = string.Format(this.ButtonResolutionFormatStr, viewportSize.X, viewportSize.Y);
			}
			else
			{
				FIntPoint resolutionByList = GameSettingsDeviceRender.Instance.GetResolutionByList(index);
				newText = string.Format(this.ButtonResolutionFormatStr, resolutionByList.X, resolutionByList.Y);
			}
			base.GetText(2).SetText(newText, true);
			if (fire)
			{
				this.FireSaveMenuChange((float)index);
			}
		}

		// Token: 0x06036FBA RID: 225210 RVA: 0x00D06EEC File Offset: 0x00D050EC
		[NullableContext(2)]
		public void SetButtonText(string value, int index, bool fire = false)
		{
			string buttonTextId = this.Data.ButtonTextId;
			UUIText text = base.GetText(2);
			if (!string.IsNullOrEmpty(buttonTextId))
			{
				text.ShowTextNew(buttonTextId);
			}
			else
			{
				text.ShowTextNew(value ?? "");
			}
			if (fire)
			{
				this.FireSaveMenuChange((float)index);
			}
		}

		// Token: 0x06036FBB RID: 225211 RVA: 0x00D06F3E File Offset: 0x00D0513E
		public override void SetInteractionActive(bool val)
		{
			this.ButtonItem.SetEnableClick(val && this.Data.GetButtonEnable());
		}

		// Token: 0x06036FBC RID: 225212 RVA: 0x00D06F5C File Offset: 0x00D0515C
		protected override void OnSetDetailVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
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
				base.GetSprite(5).SetColor(color);
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDetermineUnHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDetermineHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDeterminePressedState.Color = color;
			}
		}

		// Token: 0x06036FBD RID: 225213 RVA: 0x00D0700B File Offset: 0x00D0520B
		private void RefreshRedDot()
		{
			ButtonItem buttonItem = this.ButtonItem;
			if (buttonItem == null)
			{
				return;
			}
			buttonItem.SetRedDotVisible(this.Data.EnableRedDot);
		}

		// Token: 0x0401D028 RID: 118824
		private readonly string ButtonResolutionFormatStr = "{0}x{1}";

		// Token: 0x0401D029 RID: 118825
		private readonly string AccountSettingPrefix = "Account,";

		// Token: 0x0401D02A RID: 118826
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x0200B69A RID: 46746
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037527 RID: 226599
			public const int Title = 0;

			// Token: 0x04037528 RID: 226600
			public const int Button = 1;

			// Token: 0x04037529 RID: 226601
			public const int Name = 2;

			// Token: 0x0403752A RID: 226602
			public const int DetailItem = 3;

			// Token: 0x0403752B RID: 226603
			public const int DetailText = 4;

			// Token: 0x0403752C RID: 226604
			public const int DetailSprite = 5;

			// Token: 0x0403752D RID: 226605
			public const int DetailToggleTransition = 6;
		}
	}
}

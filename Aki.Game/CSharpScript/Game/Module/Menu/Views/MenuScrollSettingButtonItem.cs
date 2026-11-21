using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043ED RID: 17389
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingButtonItem : MenuScrollSettingBaseItem
	{
		// Token: 0x0602BEF7 RID: 179959 RVA: 0x00C55E28 File Offset: 0x00C54028
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

		// Token: 0x0602BEF8 RID: 179960 RVA: 0x00C55EDA File Offset: 0x00C540DA
		protected override void OnStart()
		{
			this.ButtonItem = new ButtonItem(base.GetItem(1));
			this.ButtonItem.GetBtn().SetCanClickWhenDisable(true);
			this.ButtonItem.SetFunction(new Action<int>(this.OnButtonClickCallback));
		}

		// Token: 0x0602BEF9 RID: 179961 RVA: 0x00C55F16 File Offset: 0x00C54116
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
		}

		// Token: 0x0602BEFA RID: 179962 RVA: 0x00C55F28 File Offset: 0x00C54128
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

		// Token: 0x0602BEFB RID: 179963 RVA: 0x00C55FEC File Offset: 0x00C541EC
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

		// Token: 0x0602BEFC RID: 179964 RVA: 0x00C56040 File Offset: 0x00C54240
		protected void RefreshTitle()
		{
			if (this.Data.CustomTitleArgs != null && this.Data.CustomTitleArgs.Length != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.FunctionName, this.Data.CustomTitleArgs);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.FunctionName, Array.Empty<object>());
		}

		// Token: 0x0602BEFD RID: 179965 RVA: 0x00C560B4 File Offset: 0x00C542B4
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

		// Token: 0x0602BEFE RID: 179966 RVA: 0x00C56154 File Offset: 0x00C54354
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

		// Token: 0x0602BEFF RID: 179967 RVA: 0x00C5619D File Offset: 0x00C5439D
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

		// Token: 0x0602BF00 RID: 179968 RVA: 0x00C561C4 File Offset: 0x00C543C4
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingButtonItem.<RefreshDetailSprite>d__13 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingButtonItem.<RefreshDetailSprite>d__13>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF01 RID: 179969 RVA: 0x00C56208 File Offset: 0x00C54408
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

		// Token: 0x0602BF02 RID: 179970 RVA: 0x00C56268 File Offset: 0x00C54468
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

		// Token: 0x0602BF03 RID: 179971 RVA: 0x00C56308 File Offset: 0x00C54508
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

		// Token: 0x0602BF04 RID: 179972 RVA: 0x00C5635A File Offset: 0x00C5455A
		public override void SetInteractionActive(bool val)
		{
			this.ButtonItem.SetEnableClick(val && this.Data.GetButtonEnable());
		}

		// Token: 0x0602BF05 RID: 179973 RVA: 0x00C56378 File Offset: 0x00C54578
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

		// Token: 0x0602BF06 RID: 179974 RVA: 0x00C56427 File Offset: 0x00C54627
		private void RefreshRedDot()
		{
			ButtonItem buttonItem = this.ButtonItem;
			if (buttonItem == null)
			{
				return;
			}
			buttonItem.SetRedDotVisible(this.Data.EnableRedDot);
		}

		// Token: 0x04017AC1 RID: 96961
		private readonly string ButtonResolutionFormatStr = "{0}x{1}";

		// Token: 0x04017AC2 RID: 96962
		private readonly string AccountSettingPrefix = "Account,";

		// Token: 0x04017AC3 RID: 96963
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x0200A0D2 RID: 41170
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04031F7C RID: 204668
			public const int Title = 0;

			// Token: 0x04031F7D RID: 204669
			public const int Button = 1;

			// Token: 0x04031F7E RID: 204670
			public const int Name = 2;

			// Token: 0x04031F7F RID: 204671
			public const int DetailItem = 3;

			// Token: 0x04031F80 RID: 204672
			public const int DetailText = 4;

			// Token: 0x04031F81 RID: 204673
			public const int DetailSprite = 5;

			// Token: 0x04031F82 RID: 204674
			public const int DetailToggleTransition = 6;
		}
	}
}

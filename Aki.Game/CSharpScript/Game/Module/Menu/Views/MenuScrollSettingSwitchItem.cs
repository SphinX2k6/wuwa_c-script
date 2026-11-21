using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F3 RID: 17395
	public class MenuScrollSettingSwitchItem : MenuScrollSettingBaseItem
	{
		// Token: 0x0602BF5D RID: 180061 RVA: 0x00C57D60 File Offset: 0x00C55F60
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

		// Token: 0x0602BF5E RID: 180062 RVA: 0x00C57E3E File Offset: 0x00C5603E
		protected override void OnStart()
		{
			base.GetButton(3).SetCanClickWhenDisable(true);
			base.GetButton(2).SetCanClickWhenDisable(true);
			this.AddOptionsEvent();
		}

		// Token: 0x0602BF5F RID: 180063 RVA: 0x00C57E60 File Offset: 0x00C56060
		protected override void OnClear()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
			base.GetButton(2).OnClickCallBack.Unbind();
			base.GetButton(3).OnClickCallBack.Unbind();
		}

		// Token: 0x0602BF60 RID: 180064 RVA: 0x00C57E93 File Offset: 0x00C56093
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

		// Token: 0x0602BF61 RID: 180065 RVA: 0x00C57EBF File Offset: 0x00C560BF
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x0602BF62 RID: 180066 RVA: 0x00C57EE4 File Offset: 0x00C560E4
		private void RefreshOptions()
		{
			base.GetRootItem().SetUIActive(true);
			int index = this.GetIndex();
			this.SetOptionsText(index);
			this.RefreshInteractionGroup(index, true);
		}

		// Token: 0x0602BF63 RID: 180067 RVA: 0x00C57F13 File Offset: 0x00C56113
		private void AddOptionsEvent()
		{
			base.GetButton(2).OnClickCallBack.Bind(new Action(this.OnLeftClickCallback));
			base.GetButton(3).OnClickCallBack.Bind(new Action(this.OnRightClickCallback));
		}

		// Token: 0x0602BF64 RID: 180068 RVA: 0x00C57F50 File Offset: 0x00C56150
		public override void SetInteractionActive(bool val)
		{
			int index = this.GetIndex();
			this.RefreshInteractionGroup(index, val);
		}

		// Token: 0x0602BF65 RID: 180069 RVA: 0x00C57F6C File Offset: 0x00C5616C
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

		// Token: 0x0602BF66 RID: 180070 RVA: 0x00C57FE8 File Offset: 0x00C561E8
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

		// Token: 0x0602BF67 RID: 180071 RVA: 0x00C5805D File Offset: 0x00C5625D
		private void OnLeftClickCallback()
		{
			if (base.GetItemClickLimit(base.GetButton(2)))
			{
				return;
			}
			this.ClickCallbackFromCheckIndex(-1);
		}

		// Token: 0x0602BF68 RID: 180072 RVA: 0x00C58076 File Offset: 0x00C56276
		private void OnRightClickCallback()
		{
			if (base.GetItemClickLimit(base.GetButton(3)))
			{
				return;
			}
			this.ClickCallbackFromCheckIndex(1);
		}

		// Token: 0x0602BF69 RID: 180073 RVA: 0x00C58090 File Offset: 0x00C56290
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

		// Token: 0x0602BF6A RID: 180074 RVA: 0x00C580EF File Offset: 0x00C562EF
		private bool NeedImageQualityCustomSpecial()
		{
			return this.Data.FunctionId == EFunction.IMAGEQUALITY && MenuModel.Instance.IsImageQualityCustom;
		}

		// Token: 0x0602BF6B RID: 180075 RVA: 0x00C5810C File Offset: 0x00C5630C
		protected unsafe int GetIndex()
		{
			MenuModel instance = MenuModel.Instance;
			int? num = (instance != null) ? instance.GetDataCacheOrCurValue(this.Data.FunctionId) : null;
			IReadOnlyList<int> optionsValueList = this.Data.OptionsValueList;
			int num2 = (num != null) ? optionsValueList.IndexOf(num.Value) : -1;
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

		// Token: 0x0602BF6C RID: 180076 RVA: 0x00C581F0 File Offset: 0x00C563F0
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

		// Token: 0x0602BF6D RID: 180077 RVA: 0x00C582A0 File Offset: 0x00C564A0
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

		// Token: 0x0602BF6E RID: 180078 RVA: 0x00C582E9 File Offset: 0x00C564E9
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

		// Token: 0x0602BF6F RID: 180079 RVA: 0x00C58310 File Offset: 0x00C56510
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingSwitchItem.<RefreshDetailSprite>d__19 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingSwitchItem.<RefreshDetailSprite>d__19>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0200A0E0 RID: 41184
		private class EComponents
		{
			// Token: 0x04031FC0 RID: 204736
			public const int Title = 0;

			// Token: 0x04031FC1 RID: 204737
			public const int TitleName = 1;

			// Token: 0x04031FC2 RID: 204738
			public const int LeftBtn = 2;

			// Token: 0x04031FC3 RID: 204739
			public const int RightBtn = 3;

			// Token: 0x04031FC4 RID: 204740
			public const int DetailItem = 4;

			// Token: 0x04031FC5 RID: 204741
			public const int DetailText = 5;

			// Token: 0x04031FC6 RID: 204742
			public const int DetailSprite = 6;

			// Token: 0x04031FC7 RID: 204743
			public const int RecommendIcon = 7;

			// Token: 0x04031FC8 RID: 204744
			public const int DetailToggleTransition = 8;
		}
	}
}

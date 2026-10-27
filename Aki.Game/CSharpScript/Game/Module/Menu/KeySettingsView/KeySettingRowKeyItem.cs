using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005467 RID: 21607
	public class KeySettingRowKeyItem : UiPanelBase
	{
		// Token: 0x0603725F RID: 225887 RVA: 0x00D12488 File Offset: 0x00D10688
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnKeySetButtonClicked)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnDisableButtonClicked))
			};
		}

		// Token: 0x06037260 RID: 225888 RVA: 0x00D125B9 File Offset: 0x00D107B9
		private void OnKeySetButtonClicked(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (this.KeySettingRowData == null)
			{
				return;
			}
			Action<KeySettingRowData, KeySettingRowKeyItem> onWaitInput = this.OnWaitInput;
			if (onWaitInput == null)
			{
				return;
			}
			onWaitInput(this.KeySettingRowData, this);
		}

		// Token: 0x06037261 RID: 225889 RVA: 0x00D125E0 File Offset: 0x00D107E0
		private void OnDisableButtonClicked()
		{
			if (this.KeySettingRowData == null)
			{
				return;
			}
			if (this.KeySettingRowData.IsBothAction())
			{
				return;
			}
			if (this.KeySettingRowData.OpenViewType != EKeySettingOpenViewType.None)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "按下清空按键按钮，清空此输入按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionOrAxisName", this.KeySettingRowData.GetActionOrAxisName());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.KeySettingRowData.DisableKey(this.InputControllerType);
			this.RefreshKeyNameText();
			InputSettings.Instance.SaveKeyMappings();
		}

		// Token: 0x06037262 RID: 225890 RVA: 0x00D12664 File Offset: 0x00D10864
		protected override void OnStart()
		{
			this.LoopSequencePlayer = new LevelSequencePlayer(base.GetItem(8));
		}

		// Token: 0x06037263 RID: 225891 RVA: 0x00D12678 File Offset: 0x00D10878
		protected override void OnBeforeDestroy()
		{
			this.ClearData();
			this.OnWaitInput = null;
			LevelSequencePlayer loopSequencePlayer = this.LoopSequencePlayer;
			if (loopSequencePlayer != null)
			{
				loopSequencePlayer.Clear();
			}
			this.LoopSequencePlayer = null;
		}

		// Token: 0x06037264 RID: 225892 RVA: 0x00D1269F File Offset: 0x00D1089F
		public void ClearData()
		{
			this.KeySettingRowData = null;
			this.InputControllerType = EInputControllerType.None;
		}

		// Token: 0x06037265 RID: 225893 RVA: 0x00D126AF File Offset: 0x00D108AF
		[NullableContext(1)]
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x06037266 RID: 225894 RVA: 0x00D126B8 File Offset: 0x00D108B8
		[NullableContext(1)]
		public void Refresh(KeySettingRowData keySettingRowData, EInputControllerType inputControllerType)
		{
			if (keySettingRowData.GetRowType() != EKeySettingRowType.KeySetting)
			{
				return;
			}
			this.KeySettingRowData = keySettingRowData;
			this.InputControllerType = inputControllerType;
			this.RefreshTitleText();
			this.RefreshKeyNameText();
			this.RefreshDetailText();
			this.RefreshLock();
			this.RefreshDisableButton();
			this.RefreshDetailItemVisible();
		}

		// Token: 0x06037267 RID: 225895 RVA: 0x00D126F8 File Offset: 0x00D108F8
		private void RefreshTitleText()
		{
			UUIText text = base.GetText(0);
			string settingName = this.KeySettingRowData.GetSettingName();
			if (StringUtils.IsEmpty(settingName))
			{
				text.SetText(this.KeySettingRowData.GetActionOrAxisName(), true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, settingName, Array.Empty<object>());
		}

		// Token: 0x06037268 RID: 225896 RVA: 0x00D12748 File Offset: 0x00D10948
		private unsafe void RefreshKeyNameText()
		{
			string buttonTextId = this.KeySettingRowData.ButtonTextId;
			if (buttonTextId != null && !StringUtils.IsBlank(buttonTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), buttonTextId, Array.Empty<object>());
				return;
			}
			string linkString = "+";
			List<string> bothActionName = this.KeySettingRowData.BothActionName;
			if (bothActionName != null && bothActionName.Count > 1)
			{
				linkString = "/";
			}
			string currentKeyNameRichText = this.KeySettingRowData.GetCurrentKeyNameRichText(this.InputControllerType, linkString);
			if (currentKeyNameRichText.Length <= 0)
			{
				InputCombinationActionBinding inputCombinationActionBinding = this.KeySettingRowData.FindCombinationActionBinding();
				InputCombinationAxisBinding combinationAxisBinding = this.KeySettingRowData.CombinationAxisBinding;
				InputActionBinding actionBinding = this.KeySettingRowData.ActionBinding;
				InputAxisBinding axisBinding = this.KeySettingRowData.AxisBinding;
				List<string> list = new List<string>();
				if (actionBinding != null)
				{
					actionBinding.GetKeyNameListByBindingType(list, this.KeySettingRowData.BindingType);
				}
				List<string> list2 = new List<string>();
				if (axisBinding != null)
				{
					axisBinding.GetKeyNameListByBindingType(list2, this.KeySettingRowData.BindingType);
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (inputCombinationActionBinding != null)
				{
					inputCombinationActionBinding.GetKeyMapByBindingType(dictionary, this.KeySettingRowData.BindingType);
				}
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				if (combinationAxisBinding != null)
				{
					combinationAxisBinding.GetKeyMap(dictionary2, this.KeySettingRowData.BindingType);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "刷新按键设置项时，按键名称为空";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionOrAxisName", this.KeySettingRowData.GetActionOrAxisName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsActionOrAxis", this.KeySettingRowData.IsActionOrAxis);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActionBindingKeys", list);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AxisBindingKeys", list2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("combinationActionBindingKeyMap", dictionary);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("combinationAxisBindingKeyMap", dictionary2);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "NoneText", Array.Empty<object>());
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(currentKeyNameRichText, true);
		}

		// Token: 0x06037269 RID: 225897 RVA: 0x00D12974 File Offset: 0x00D10B74
		private void RefreshDetailText()
		{
			if (this.KeySettingRowData.CanDisable)
			{
				UUISprite sprite = base.GetSprite(5);
				if (sprite == null)
				{
					return;
				}
				sprite.SetUIActive(false);
				return;
			}
			else
			{
				string detailTextId = this.KeySettingRowData.DetailTextId;
				if (!StringUtils.IsEmpty(detailTextId))
				{
					UUISprite sprite2 = base.GetSprite(5);
					if (sprite2 != null)
					{
						sprite2.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(4), detailTextId, Array.Empty<object>());
					return;
				}
				UUISprite sprite3 = base.GetSprite(5);
				if (sprite3 == null)
				{
					return;
				}
				sprite3.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603726A RID: 225898 RVA: 0x00D129F4 File Offset: 0x00D10BF4
		private void RefreshLock()
		{
			bool isLock = this.KeySettingRowData.IsLock;
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetUIActive(isLock);
			}
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!isLock);
		}

		// Token: 0x0603726B RID: 225899 RVA: 0x00D12A38 File Offset: 0x00D10C38
		private void RefreshDisableButton()
		{
			if (this.KeySettingRowData == null)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(9);
			AUIBaseActor auibaseActor = ((button != null) ? button.GetOwner() : null) as AUIBaseActor;
			UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			if (!this.KeySettingRowData.CanDisable)
			{
				uuiitem.SetUIActive(false);
				return;
			}
			if (this.KeySettingRowData.IsLock)
			{
				uuiitem.SetUIActive(false);
				return;
			}
			if (this.KeySettingRowData.IsBothAction())
			{
				uuiitem.SetUIActive(false);
				return;
			}
			if (this.KeySettingRowData.OpenViewType != EKeySettingOpenViewType.None)
			{
				uuiitem.SetUIActive(false);
				return;
			}
			uuiitem.SetUIActive(true);
		}

		// Token: 0x0603726C RID: 225900 RVA: 0x00D12AD3 File Offset: 0x00D10CD3
		private void RefreshDetailItemVisible()
		{
			if (this.KeySettingRowData == null)
			{
				this.SetDetailItemVisible(false);
				return;
			}
			this.SetDetailItemVisible(this.KeySettingRowData.IsExpandDetail);
		}

		// Token: 0x0603726D RID: 225901 RVA: 0x00D12AF8 File Offset: 0x00D10CF8
		public void SetSelected(bool bSelected)
		{
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(bSelected);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(!bSelected);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(bSelected);
			}
			if (bSelected)
			{
				this.LoopSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
				return;
			}
			this.LoopSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x0603726E RID: 225902 RVA: 0x00D12B8C File Offset: 0x00D10D8C
		public void SetDetailItemVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (this.KeySettingRowData == null)
			{
				item.SetUIActive(false);
				return;
			}
			if (StringUtils.IsEmpty(this.KeySettingRowData.DetailTextId))
			{
				item.SetUIActive(false);
				return;
			}
			item.SetUIActive(bVisible);
			this.KeySettingRowData.IsExpandDetail = bVisible;
		}

		// Token: 0x0401D180 RID: 119168
		[Nullable(2)]
		private KeySettingRowData KeySettingRowData;

		// Token: 0x0401D181 RID: 119169
		private EInputControllerType InputControllerType;

		// Token: 0x0401D182 RID: 119170
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem> OnWaitInput;

		// Token: 0x0401D183 RID: 119171
		[Nullable(2)]
		private LevelSequencePlayer LoopSequencePlayer;

		// Token: 0x0200B6E1 RID: 46817
		public class EChildType
		{
			// Token: 0x04037669 RID: 226921
			public const int TitleText = 0;

			// Token: 0x0403766A RID: 226922
			public const int KeySetToggle = 1;

			// Token: 0x0403766B RID: 226923
			public const int KeyNameText = 2;

			// Token: 0x0403766C RID: 226924
			public const int DetailItem = 3;

			// Token: 0x0403766D RID: 226925
			public const int DetailText = 4;

			// Token: 0x0403766E RID: 226926
			public const int DetailArrowSprite = 5;

			// Token: 0x0403766F RID: 226927
			public const int LockSprite = 6;

			// Token: 0x04037670 RID: 226928
			public const int SelectedSprite = 7;

			// Token: 0x04037671 RID: 226929
			public const int CursorItem = 8;

			// Token: 0x04037672 RID: 226930
			public const int DisableButton = 9;
		}
	}
}

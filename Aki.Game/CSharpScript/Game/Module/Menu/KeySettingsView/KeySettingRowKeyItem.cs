using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200444A RID: 17482
	public class KeySettingRowKeyItem : UiPanelBase
	{
		// Token: 0x0602C1A8 RID: 180648 RVA: 0x00C618A0 File Offset: 0x00C5FAA0
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

		// Token: 0x0602C1A9 RID: 180649 RVA: 0x00C619D1 File Offset: 0x00C5FBD1
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

		// Token: 0x0602C1AA RID: 180650 RVA: 0x00C619F8 File Offset: 0x00C5FBF8
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

		// Token: 0x0602C1AB RID: 180651 RVA: 0x00C61A7C File Offset: 0x00C5FC7C
		protected override void OnStart()
		{
			this.LoopSequencePlayer = new LevelSequencePlayer(base.GetItem(8));
		}

		// Token: 0x0602C1AC RID: 180652 RVA: 0x00C61A90 File Offset: 0x00C5FC90
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

		// Token: 0x0602C1AD RID: 180653 RVA: 0x00C61AB7 File Offset: 0x00C5FCB7
		public void ClearData()
		{
			this.KeySettingRowData = null;
			this.InputControllerType = EInputControllerType.None;
		}

		// Token: 0x0602C1AE RID: 180654 RVA: 0x00C61AC7 File Offset: 0x00C5FCC7
		[NullableContext(1)]
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x0602C1AF RID: 180655 RVA: 0x00C61AD0 File Offset: 0x00C5FCD0
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

		// Token: 0x0602C1B0 RID: 180656 RVA: 0x00C61B10 File Offset: 0x00C5FD10
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

		// Token: 0x0602C1B1 RID: 180657 RVA: 0x00C61B60 File Offset: 0x00C5FD60
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

		// Token: 0x0602C1B2 RID: 180658 RVA: 0x00C61D8C File Offset: 0x00C5FF8C
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

		// Token: 0x0602C1B3 RID: 180659 RVA: 0x00C61E0C File Offset: 0x00C6000C
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

		// Token: 0x0602C1B4 RID: 180660 RVA: 0x00C61E50 File Offset: 0x00C60050
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

		// Token: 0x0602C1B5 RID: 180661 RVA: 0x00C61EEB File Offset: 0x00C600EB
		private void RefreshDetailItemVisible()
		{
			if (this.KeySettingRowData == null)
			{
				this.SetDetailItemVisible(false);
				return;
			}
			this.SetDetailItemVisible(this.KeySettingRowData.IsExpandDetail);
		}

		// Token: 0x0602C1B6 RID: 180662 RVA: 0x00C61F10 File Offset: 0x00C60110
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

		// Token: 0x0602C1B7 RID: 180663 RVA: 0x00C61FA4 File Offset: 0x00C601A4
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

		// Token: 0x04017C19 RID: 97305
		[Nullable(2)]
		private KeySettingRowData KeySettingRowData;

		// Token: 0x04017C1A RID: 97306
		private EInputControllerType InputControllerType;

		// Token: 0x04017C1B RID: 97307
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem> OnWaitInput;

		// Token: 0x04017C1C RID: 97308
		[Nullable(2)]
		private LevelSequencePlayer LoopSequencePlayer;

		// Token: 0x0200A119 RID: 41241
		public class EChildType
		{
			// Token: 0x040320BE RID: 204990
			public const int TitleText = 0;

			// Token: 0x040320BF RID: 204991
			public const int KeySetToggle = 1;

			// Token: 0x040320C0 RID: 204992
			public const int KeyNameText = 2;

			// Token: 0x040320C1 RID: 204993
			public const int DetailItem = 3;

			// Token: 0x040320C2 RID: 204994
			public const int DetailText = 4;

			// Token: 0x040320C3 RID: 204995
			public const int DetailArrowSprite = 5;

			// Token: 0x040320C4 RID: 204996
			public const int LockSprite = 6;

			// Token: 0x040320C5 RID: 204997
			public const int SelectedSprite = 7;

			// Token: 0x040320C6 RID: 204998
			public const int CursorItem = 8;

			// Token: 0x040320C7 RID: 204999
			public const int DisableButton = 9;
		}
	}
}

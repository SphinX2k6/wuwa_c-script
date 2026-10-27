using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D60 RID: 23904
	[NullableContext(2)]
	[Nullable(0)]
	public class CombineKeyItem : KeyItemBase
	{
		// Token: 0x0603CAFE RID: 248574 RVA: 0x00E92484 File Offset: 0x00E90684
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CAFF RID: 248575 RVA: 0x00E9250E File Offset: 0x00E9070E
		public override void Reset()
		{
			base.Reset();
			this.SubKeyTexturePath = null;
		}

		// Token: 0x0603CB00 RID: 248576 RVA: 0x00E9251D File Offset: 0x00E9071D
		protected override void AddEvents()
		{
			base.AddEvents();
			EventSystem.Instance.Add(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
		}

		// Token: 0x0603CB01 RID: 248577 RVA: 0x00E92541 File Offset: 0x00E90741
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			EventSystem.Instance.Remove(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
		}

		// Token: 0x0603CB02 RID: 248578 RVA: 0x00E92565 File Offset: 0x00E90765
		private void OnSwitchInteractStateChanged()
		{
			if (Info.Instance.IsInGamepad() && (this.ActionName == "幻象1" || this.ActionName == "载具探索工具"))
			{
				this.RefreshAction(this.ActionName);
			}
		}

		// Token: 0x0603CB03 RID: 248579 RVA: 0x00E925A3 File Offset: 0x00E907A3
		protected override UUIText GetKeyText()
		{
			return null;
		}

		// Token: 0x0603CB04 RID: 248580 RVA: 0x00E925A6 File Offset: 0x00E907A6
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x0603CB05 RID: 248581 RVA: 0x00E925B0 File Offset: 0x00E907B0
		[NullableContext(1)]
		public override void RefreshAction(string actionName)
		{
			if (this.ActionName != actionName)
			{
				base.UnBindAction();
				this.ActionName = actionName;
				this.AxisName = null;
				base.BindAction();
			}
			if (this.CheckGamepadSwitchInteract())
			{
				return;
			}
			InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(this.ActionName);
			if (combinationActionBindingByActionName != null)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				combinationActionBindingByActionName.GetCurrentPlatformKeyNameMap(dictionary);
				using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						string key = keyValuePair.Key;
						string value = keyValuePair.Value;
						base.RefreshKey(InputSettings.Instance.GetKey(key));
						this.RefreshSubKey(InputSettings.Instance.GetKey(value));
						base.GetTexture(2).SetUIActive(true);
						base.GetText(1).SetUIActive(!this.IsHideMainKey);
						this.GetKeyTexture().SetUIActive(!this.IsHideMainKey);
						this.IsCombineKey = true;
						return;
					}
				}
			}
			this.IsCombineKey = false;
			base.GetTexture(2).SetUIActive(false);
			base.GetText(1).SetUIActive(false);
			this.GetKeyTexture().SetUIActive(!this.IsHideMainKey);
			if (InputSettingsManager.Instance.GetActionBinding(this.ActionName) != null)
			{
				base.RefreshAction(actionName);
			}
		}

		// Token: 0x0603CB06 RID: 248582 RVA: 0x00E92714 File Offset: 0x00E90914
		private bool CheckGamepadSwitchInteract()
		{
			if (Info.Instance.IsInGamepad() && (this.ActionName == "幻象1" || this.ActionName == "载具探索工具"))
			{
				SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
				if (gamepadData != null && gamepadData.SwitchInteractData.State == EGamepadSwitchInteractState.Explore)
				{
					InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName("通用交互");
					if (combinationActionBindingByActionName != null)
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						combinationActionBindingByActionName.GetCurrentPlatformKeyNameMap(dictionary);
						using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								KeyValuePair<string, string> keyValuePair = enumerator.Current;
								string key = keyValuePair.Key;
								string value = keyValuePair.Value;
								base.RefreshKey(InputSettings.Instance.GetKey(key));
								this.RefreshSubKey(InputSettings.Instance.GetKey(value));
								base.GetTexture(2).SetUIActive(true);
								base.GetText(1).SetUIActive(!this.IsHideMainKey);
								this.GetKeyTexture().SetUIActive(!this.IsHideMainKey);
								this.IsCombineKey = true;
								return true;
							}
						}
					}
					this.IsCombineKey = false;
					base.GetTexture(2).SetUIActive(false);
					base.GetText(1).SetUIActive(false);
					this.GetKeyTexture().SetUIActive(!this.IsHideMainKey);
					InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("通用交互");
					InputKey inputKey = (actionBinding != null) ? actionBinding.GetCurrentPlatformKey() : null;
					if (inputKey != null)
					{
						base.RefreshKey(inputKey);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603CB07 RID: 248583 RVA: 0x00E928B8 File Offset: 0x00E90AB8
		[NullableContext(1)]
		public void RefreshSubKey(InputKey key)
		{
			string keyName = key.GetKeyName();
			if (this.SubKeyName == keyName)
			{
				return;
			}
			string keyTexturePath = key.GetKeyIconPath();
			if (!string.IsNullOrEmpty(keyTexturePath))
			{
				UUITexture keyTexture = base.GetTexture(2);
				keyTexture.SetUIActive(false);
				this.SubKeyTexturePath = keyTexturePath;
				base.SetTextureByPath(keyTexturePath, keyTexture, null, delegate(bool _)
				{
					if (this.SubKeyTexturePath != keyTexturePath)
					{
						return;
					}
					keyTexture.SetSizeFromTexture();
					keyTexture.SetUIActive(true);
				});
			}
			this.SubKeyName = keyName;
		}

		// Token: 0x0603CB08 RID: 248584 RVA: 0x00E92954 File Offset: 0x00E90B54
		public void HideMainKey(bool bHide)
		{
			if (this.IsHideMainKey == bHide)
			{
				return;
			}
			this.IsHideMainKey = bHide;
			base.GetText(1).SetUIActive(!this.IsHideMainKey && this.IsCombineKey);
			this.GetKeyTexture().SetUIActive(!this.IsHideMainKey || !this.IsCombineKey);
		}

		// Token: 0x0603CB09 RID: 248585 RVA: 0x00E929B0 File Offset: 0x00E90BB0
		protected override void OnSetGray()
		{
			UUITexture texture = base.GetTexture(0);
			UUIItem uuiitem = texture;
			bool isGray = this.IsGray;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isGray, fcolor);
			UUITexture texture2 = base.GetTexture(2);
			UUIItem uuiitem2 = texture2;
			bool isGray2 = this.IsGray;
			fcolor = new FColor?(texture2.changeColor);
			uuiitem2.SetChangeColor(isGray2, fcolor);
		}

		// Token: 0x0603CB0A RID: 248586 RVA: 0x00E92A01 File Offset: 0x00E90C01
		public string GetKeyName()
		{
			return this.KeyName;
		}

		// Token: 0x0401F9DC RID: 129500
		[Nullable(1)]
		private string SubKeyName = string.Empty;

		// Token: 0x0401F9DD RID: 129501
		private string SubKeyTexturePath;

		// Token: 0x0401F9DE RID: 129502
		private bool IsHideMainKey;

		// Token: 0x0401F9DF RID: 129503
		private bool IsCombineKey;

		// Token: 0x0200C00F RID: 49167
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039F4E RID: 237390
			KeyTextureMain,
			// Token: 0x04039F4F RID: 237391
			AddText,
			// Token: 0x04039F50 RID: 237392
			KeyTextureSub
		}
	}
}

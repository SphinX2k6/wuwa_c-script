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
	// Token: 0x02004D42 RID: 19778
	[NullableContext(2)]
	[Nullable(0)]
	public class CombineKeyItem : KeyItemBase
	{
		// Token: 0x06031A59 RID: 203353 RVA: 0x00DE2C70 File Offset: 0x00DE0E70
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

		// Token: 0x06031A5A RID: 203354 RVA: 0x00DE2CFA File Offset: 0x00DE0EFA
		public override void Reset()
		{
			base.Reset();
			this.SubKeyTexturePath = null;
		}

		// Token: 0x06031A5B RID: 203355 RVA: 0x00DE2D09 File Offset: 0x00DE0F09
		protected override void AddEvents()
		{
			base.AddEvents();
			EventSystem.Instance.Add(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
		}

		// Token: 0x06031A5C RID: 203356 RVA: 0x00DE2D2D File Offset: 0x00DE0F2D
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			EventSystem.Instance.Remove(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
		}

		// Token: 0x06031A5D RID: 203357 RVA: 0x00DE2D51 File Offset: 0x00DE0F51
		private void OnSwitchInteractStateChanged()
		{
			if (Info.Instance.IsInGamepad() && (this.ActionName == "幻象1" || this.ActionName == "载具探索工具"))
			{
				this.RefreshAction(this.ActionName);
			}
		}

		// Token: 0x06031A5E RID: 203358 RVA: 0x00DE2D8F File Offset: 0x00DE0F8F
		protected override UUIText GetKeyText()
		{
			return null;
		}

		// Token: 0x06031A5F RID: 203359 RVA: 0x00DE2D92 File Offset: 0x00DE0F92
		protected override UUITexture GetKeyTexture()
		{
			return base.GetTexture(0);
		}

		// Token: 0x06031A60 RID: 203360 RVA: 0x00DE2D9C File Offset: 0x00DE0F9C
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

		// Token: 0x06031A61 RID: 203361 RVA: 0x00DE2F00 File Offset: 0x00DE1100
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

		// Token: 0x06031A62 RID: 203362 RVA: 0x00DE30A4 File Offset: 0x00DE12A4
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

		// Token: 0x06031A63 RID: 203363 RVA: 0x00DE3140 File Offset: 0x00DE1340
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

		// Token: 0x06031A64 RID: 203364 RVA: 0x00DE319C File Offset: 0x00DE139C
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

		// Token: 0x06031A65 RID: 203365 RVA: 0x00DE31ED File Offset: 0x00DE13ED
		public string GetKeyName()
		{
			return this.KeyName;
		}

		// Token: 0x0401A494 RID: 107668
		[Nullable(1)]
		private string SubKeyName = string.Empty;

		// Token: 0x0401A495 RID: 107669
		private string SubKeyTexturePath;

		// Token: 0x0401A496 RID: 107670
		private bool IsHideMainKey;

		// Token: 0x0401A497 RID: 107671
		private bool IsCombineKey;

		// Token: 0x0200AA15 RID: 43541
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034910 RID: 215312
			KeyTextureMain,
			// Token: 0x04034911 RID: 215313
			AddText,
			// Token: 0x04034912 RID: 215314
			KeyTextureSub
		}
	}
}

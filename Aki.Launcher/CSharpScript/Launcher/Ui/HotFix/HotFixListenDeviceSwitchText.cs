using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.PlayerInput;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DA RID: 218
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixListenDeviceSwitchText
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00039EFD File Offset: 0x000380FD
		public HotFixListenDeviceSwitchText(UUIText uiText, [Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})] Dictionary<string, ValueTuple<string, actionMappings>> gamepadDataMap)
		{
			this.UiText = uiText;
			this.GamepadDataMap = gamepadDataMap;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00039F2C File Offset: 0x0003812C
		private void SetGamepadText(string textId, actionMappings actionName)
		{
			EGamepadKey key;
			if (!HotPatchInputDefine.Instance.gamepadActionInputMap.TryGetValue(actionName.ToString(), out key))
			{
				return;
			}
			IKeyPath keyPath;
			if (!HotPatchInputDefine.Instance.gamepadKeyPathMap.TryGetValue(key, out keyPath))
			{
				return;
			}
			string text = null;
			if (InputDevice.Instance.IsXboxGamepad() && keyPath.XBox != null)
			{
				text = keyPath.XBox;
			}
			else if (InputDevice.Instance.IsPsGamepad())
			{
				text = keyPath.Ps;
			}
			if (text == null)
			{
				return;
			}
			this.UiText.SetRichText(true);
			HotFixManager.SetLocalText(this.UiText, textId, new string[]
			{
				"<texture=" + text + ">"
			});
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00039FD6 File Offset: 0x000381D6
		private void RefreshText(EInputControllerType a, EInputControllerType b)
		{
			if (this.CurrentTextId == null || this.CurrentTextId == "")
			{
				return;
			}
			this.SetLocalText(this.CurrentTextId, this.CurrentArgs.ToArray());
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0003A00A File Offset: 0x0003820A
		public void AddGamepadChange()
		{
			InputDevice.Instance.RegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.RefreshText));
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0003A022 File Offset: 0x00038222
		public void RemoveGamepadChange()
		{
			InputDevice.Instance.UnRegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.RefreshText));
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003A03C File Offset: 0x0003823C
		public void SetLocalText(string textId, params string[] args)
		{
			this.CurrentTextId = textId;
			this.CurrentArgs.Clear();
			this.CurrentArgs.AddRange(args);
			ValueTuple<string, actionMappings> valueTuple;
			if (!this.GamepadDataMap.TryGetValue(textId, out valueTuple) || !InputDevice.Instance.IsInGamepad())
			{
				HotFixManager.SetLocalText(this.UiText, textId, args);
				return;
			}
			this.SetGamepadText(valueTuple.Item1, valueTuple.Item2);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0003A0A3 File Offset: 0x000382A3
		public void SetEmptyText()
		{
			this.CurrentTextId = "";
			this.CurrentArgs.Clear();
			this.UiText.SetText("", true);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0003A0CC File Offset: 0x000382CC
		public void SetUiActive(bool isActive)
		{
			this.UiText.SetUIActive(isActive);
		}

		// Token: 0x0400042E RID: 1070
		protected string CurrentTextId = "";

		// Token: 0x0400042F RID: 1071
		protected List<string> CurrentArgs = new List<string>();

		// Token: 0x04000430 RID: 1072
		protected UUIText UiText;

		// Token: 0x04000431 RID: 1073
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		protected Dictionary<string, ValueTuple<string, actionMappings>> GamepadDataMap;
	}
}

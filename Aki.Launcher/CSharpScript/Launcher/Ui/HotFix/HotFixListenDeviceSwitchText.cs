using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.PlayerInput;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DD RID: 221
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixListenDeviceSwitchText
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x0003BA2D File Offset: 0x00039C2D
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

		// Token: 0x0600072C RID: 1836 RVA: 0x0003BA5C File Offset: 0x00039C5C
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

		// Token: 0x0600072D RID: 1837 RVA: 0x0003BB06 File Offset: 0x00039D06
		private void RefreshText(EInputControllerType a, EInputControllerType b)
		{
			if (this.CurrentTextId == null || this.CurrentTextId == "")
			{
				return;
			}
			this.SetLocalText(this.CurrentTextId, this.CurrentArgs.ToArray());
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003BB3A File Offset: 0x00039D3A
		public void AddGamepadChange()
		{
			InputDevice.Instance.RegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.RefreshText));
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003BB52 File Offset: 0x00039D52
		public void RemoveGamepadChange()
		{
			InputDevice.Instance.UnRegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.RefreshText));
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003BB6C File Offset: 0x00039D6C
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

		// Token: 0x06000731 RID: 1841 RVA: 0x0003BBD3 File Offset: 0x00039DD3
		public void SetEmptyText()
		{
			this.CurrentTextId = "";
			this.CurrentArgs.Clear();
			this.UiText.SetText("", true);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003BBFC File Offset: 0x00039DFC
		public void SetUiActive(bool isActive)
		{
			this.UiText.SetUIActive(isActive);
		}

		// Token: 0x0400045D RID: 1117
		protected string CurrentTextId = "";

		// Token: 0x0400045E RID: 1118
		protected List<string> CurrentArgs = new List<string>();

		// Token: 0x0400045F RID: 1119
		protected UUIText UiText;

		// Token: 0x04000460 RID: 1120
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

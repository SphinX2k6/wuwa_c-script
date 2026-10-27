using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D62 RID: 23906
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KeyItemBase : UiPanelBase
	{
		// Token: 0x0603CB11 RID: 248593 RVA: 0x00E92AA6 File Offset: 0x00E90CA6
		protected override void OnStartImplement()
		{
			this.AddEvents();
		}

		// Token: 0x0603CB12 RID: 248594 RVA: 0x00E92AAE File Offset: 0x00E90CAE
		protected override void OnBeforeDestroyImplement()
		{
			this.UnBindAction();
			this.RemoveEvents();
			this.Reset();
		}

		// Token: 0x0603CB13 RID: 248595 RVA: 0x00E92AC2 File Offset: 0x00E90CC2
		public virtual void Reset()
		{
			this.CustomKeyName = null;
			this.KeyName = null;
			this.ActionName = null;
			this.AxisName = null;
			this.KeyTexturePath = null;
		}

		// Token: 0x0603CB14 RID: 248596 RVA: 0x00E92AE7 File Offset: 0x00E90CE7
		public void SetCustomKeyName(string keyName)
		{
			this.CustomKeyName = keyName;
		}

		// Token: 0x0603CB15 RID: 248597 RVA: 0x00E92AF0 File Offset: 0x00E90CF0
		public virtual void RefreshAction(string actionName)
		{
			this.UnBindAction();
			this.ActionName = actionName;
			this.AxisName = null;
			if (!string.IsNullOrEmpty(this.CustomKeyName))
			{
				this.RefreshKey(InputSettings.Instance.GetKey(this.CustomKeyName));
			}
			else
			{
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(this.ActionName);
				if (actionBinding == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "[KeyItem]刷新按键图标时找不到对应Action";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", this.ActionName);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				InputKey currentPlatformKey = actionBinding.GetCurrentPlatformKey();
				if (currentPlatformKey == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "[KeyItem]刷新按键图标时Action没有对应按键";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actionName", this.ActionName);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				this.RefreshKey(currentPlatformKey);
			}
			this.BindAction();
		}

		// Token: 0x0603CB16 RID: 248598 RVA: 0x00E92BBC File Offset: 0x00E90DBC
		public virtual void RefreshAxis(string axisName)
		{
			this.UnBindAction();
			this.AxisName = axisName;
			this.ActionName = null;
			if (!string.IsNullOrEmpty(this.CustomKeyName))
			{
				this.RefreshKey(InputSettings.Instance.GetKey(this.CustomKeyName));
				return;
			}
			InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
			if (axisBinding == null)
			{
				return;
			}
			InputAxisKey currentPlatformKey = axisBinding.GetCurrentPlatformKey();
			if (currentPlatformKey == null)
			{
				return;
			}
			this.RefreshKey(currentPlatformKey.GetKey());
		}

		// Token: 0x0603CB17 RID: 248599 RVA: 0x00E92C28 File Offset: 0x00E90E28
		protected void BindAction()
		{
			if (!StringUtils.IsEmpty(this.ActionName))
			{
				InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActionInternal));
			}
		}

		// Token: 0x0603CB18 RID: 248600 RVA: 0x00E92C53 File Offset: 0x00E90E53
		protected void UnBindAction()
		{
			if (!StringUtils.IsEmpty(this.ActionName))
			{
				InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActionInternal));
			}
		}

		// Token: 0x0603CB19 RID: 248601 RVA: 0x00E92C80 File Offset: 0x00E90E80
		protected virtual void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Add(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}

		// Token: 0x0603CB1A RID: 248602 RVA: 0x00E92CE4 File Offset: 0x00E90EE4
		protected virtual void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Remove(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}

		// Token: 0x0603CB1B RID: 248603 RVA: 0x00E92D45 File Offset: 0x00E90F45
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (!StringUtils.IsEmpty(this.ActionName))
			{
				this.RefreshAction(this.ActionName);
				return;
			}
			if (!StringUtils.IsEmpty(this.AxisName))
			{
				this.RefreshAxis(this.AxisName);
			}
		}

		// Token: 0x0603CB1C RID: 248604 RVA: 0x00E92D7A File Offset: 0x00E90F7A
		private void OnActionKeyChanged(string actionName)
		{
			if (!StringUtils.IsEmpty(this.ActionName) && this.ActionName == actionName)
			{
				this.RefreshAction(this.ActionName);
			}
		}

		// Token: 0x0603CB1D RID: 248605 RVA: 0x00E92DA3 File Offset: 0x00E90FA3
		private void OnAxisKeyChanged(string axisName)
		{
			if (!StringUtils.IsEmpty(this.AxisName) && this.AxisName == axisName)
			{
				this.RefreshAxis(this.AxisName);
			}
		}

		// Token: 0x0603CB1E RID: 248606 RVA: 0x00E92DCC File Offset: 0x00E90FCC
		private void OnInputActionInternal(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.OnInputAction(actionName, actionType);
		}

		// Token: 0x0603CB1F RID: 248607 RVA: 0x00E92DD6 File Offset: 0x00E90FD6
		protected virtual void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType)
		{
		}

		// Token: 0x0603CB20 RID: 248608 RVA: 0x00E92DD8 File Offset: 0x00E90FD8
		public void RefreshKey(InputKey key)
		{
			string keyName = key.GetKeyName();
			string keyIconPath = key.GetKeyIconPath();
			if (this.KeyName == keyName && this.KeyTexturePath == keyIconPath)
			{
				return;
			}
			if (StringUtils.IsEmpty(keyIconPath))
			{
				this.SetKeyText(keyName);
			}
			else
			{
				this.SetKeyTexture(keyIconPath);
			}
			this.KeyName = keyName;
		}

		// Token: 0x0603CB21 RID: 248609 RVA: 0x00E92E30 File Offset: 0x00E91030
		public void RefreshKeyByName(string keyName)
		{
			InputKey key = InputSettings.Instance.GetKey(keyName);
			if (key == null)
			{
				return;
			}
			this.RefreshKey(key);
		}

		// Token: 0x0603CB22 RID: 248610 RVA: 0x00E92E54 File Offset: 0x00E91054
		public void SetKeyText(string keyName)
		{
			UUIText keyText = this.GetKeyText();
			UUITexture keyTexture = this.GetKeyTexture();
			if (keyTexture != null)
			{
				keyTexture.SetUIActive(false);
			}
			if (keyText != null)
			{
				if (StringUtils.IsEmpty(keyName))
				{
					keyText.SetUIActive(false);
					return;
				}
				keyText.SetText(keyName, true);
				keyText.SetUIActive(true);
			}
		}

		// Token: 0x0603CB23 RID: 248611 RVA: 0x00E92E9C File Offset: 0x00E9109C
		public void SetLocalText(string textTableId, params object[] args)
		{
			UUIText keyText = this.GetKeyText();
			UUITexture keyTexture = this.GetKeyTexture();
			if (keyTexture != null)
			{
				keyTexture.SetUIActive(false);
			}
			if (keyText != null)
			{
				if (StringUtils.IsEmpty(textTableId))
				{
					keyText.SetUIActive(false);
					return;
				}
				LguiUtil.Instance.SetLocalText(keyText, textTableId, args);
				keyText.SetUIActive(true);
			}
		}

		// Token: 0x0603CB24 RID: 248612 RVA: 0x00E92EEC File Offset: 0x00E910EC
		private void SetKeyTexture(string keyTexturePath)
		{
			UUIText keyText = this.GetKeyText();
			if (keyText != null)
			{
				keyText.SetUIActive(false);
			}
			UUITexture keyTexture = this.GetKeyTexture();
			if (keyTexture == null)
			{
				return;
			}
			keyTexture.SetUIActive(false);
			if (StringUtils.IsEmpty(keyTexturePath))
			{
				return;
			}
			this.KeyTexturePath = keyTexturePath;
			base.SetTextureByPath(keyTexturePath, keyTexture, null, delegate(bool _)
			{
				if (this.KeyTexturePath != keyTexturePath)
				{
					return;
				}
				keyTexture.SetSizeFromTexture();
				keyTexture.SetUIActive(true);
			});
		}

		// Token: 0x0603CB25 RID: 248613 RVA: 0x00E92F81 File Offset: 0x00E91181
		public void SetEnable(bool bEnable, bool bForce = false)
		{
			if (this.IsEnable == bEnable && !bForce)
			{
				return;
			}
			if (bEnable)
			{
				this.RootItem.SetAlpha(1f);
			}
			else
			{
				this.RootItem.SetAlpha(0.2f);
			}
			this.IsEnable = bEnable;
		}

		// Token: 0x0603CB26 RID: 248614 RVA: 0x00E92FBC File Offset: 0x00E911BC
		public void SetGray(bool bIsGray)
		{
			if (this.IsGray == bIsGray)
			{
				return;
			}
			this.IsGray = bIsGray;
			this.OnSetGray();
		}

		// Token: 0x0603CB27 RID: 248615 RVA: 0x00E92FD5 File Offset: 0x00E911D5
		protected virtual void OnSetGray()
		{
		}

		// Token: 0x0603CB28 RID: 248616
		[NullableContext(2)]
		protected abstract UUIText GetKeyText();

		// Token: 0x0603CB29 RID: 248617
		[NullableContext(2)]
		protected abstract UUITexture GetKeyTexture();

		// Token: 0x0401F9E0 RID: 129504
		[Nullable(2)]
		protected string ActionName;

		// Token: 0x0401F9E1 RID: 129505
		[Nullable(2)]
		protected string AxisName;

		// Token: 0x0401F9E2 RID: 129506
		[Nullable(2)]
		private string CustomKeyName;

		// Token: 0x0401F9E3 RID: 129507
		[Nullable(2)]
		protected string KeyName;

		// Token: 0x0401F9E4 RID: 129508
		[Nullable(2)]
		protected string KeyTexturePath;

		// Token: 0x0401F9E5 RID: 129509
		protected bool IsEnable;

		// Token: 0x0401F9E6 RID: 129510
		protected bool IsGray;

		// Token: 0x0401F9E7 RID: 129511
		private const float DISABLE_ALPHA = 0.2f;
	}
}

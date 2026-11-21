using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D44 RID: 19780
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KeyItemBase : UiPanelBase
	{
		// Token: 0x06031A6C RID: 203372 RVA: 0x00DE3292 File Offset: 0x00DE1492
		protected override void OnStartImplement()
		{
			this.AddEvents();
		}

		// Token: 0x06031A6D RID: 203373 RVA: 0x00DE329A File Offset: 0x00DE149A
		protected override void OnBeforeDestroyImplement()
		{
			this.UnBindAction();
			this.RemoveEvents();
			this.Reset();
		}

		// Token: 0x06031A6E RID: 203374 RVA: 0x00DE32AE File Offset: 0x00DE14AE
		public virtual void Reset()
		{
			this.CustomKeyName = null;
			this.KeyName = null;
			this.ActionName = null;
			this.AxisName = null;
			this.KeyTexturePath = null;
		}

		// Token: 0x06031A6F RID: 203375 RVA: 0x00DE32D3 File Offset: 0x00DE14D3
		public void SetCustomKeyName(string keyName)
		{
			this.CustomKeyName = keyName;
		}

		// Token: 0x06031A70 RID: 203376 RVA: 0x00DE32DC File Offset: 0x00DE14DC
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

		// Token: 0x06031A71 RID: 203377 RVA: 0x00DE33A8 File Offset: 0x00DE15A8
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

		// Token: 0x06031A72 RID: 203378 RVA: 0x00DE3414 File Offset: 0x00DE1614
		protected void BindAction()
		{
			if (!StringUtils.IsEmpty(this.ActionName))
			{
				InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActionInternal));
			}
		}

		// Token: 0x06031A73 RID: 203379 RVA: 0x00DE343F File Offset: 0x00DE163F
		protected void UnBindAction()
		{
			if (!StringUtils.IsEmpty(this.ActionName))
			{
				InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActionInternal));
			}
		}

		// Token: 0x06031A74 RID: 203380 RVA: 0x00DE346C File Offset: 0x00DE166C
		protected virtual void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Add(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}

		// Token: 0x06031A75 RID: 203381 RVA: 0x00DE34D0 File Offset: 0x00DE16D0
		protected virtual void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Remove(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}

		// Token: 0x06031A76 RID: 203382 RVA: 0x00DE3534 File Offset: 0x00DE1734
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
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

		// Token: 0x06031A77 RID: 203383 RVA: 0x00DE358A File Offset: 0x00DE178A
		private void OnActionKeyChanged(string actionName)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			if (!StringUtils.IsEmpty(this.ActionName) && this.ActionName == actionName)
			{
				this.RefreshAction(this.ActionName);
			}
		}

		// Token: 0x06031A78 RID: 203384 RVA: 0x00DE35C9 File Offset: 0x00DE17C9
		private void OnAxisKeyChanged(string axisName)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			if (!StringUtils.IsEmpty(this.AxisName) && this.AxisName == axisName)
			{
				this.RefreshAxis(this.AxisName);
			}
		}

		// Token: 0x06031A79 RID: 203385 RVA: 0x00DE3608 File Offset: 0x00DE1808
		private void OnInputActionInternal(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.OnInputAction(actionName, actionType);
		}

		// Token: 0x06031A7A RID: 203386 RVA: 0x00DE3612 File Offset: 0x00DE1812
		protected virtual void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType)
		{
		}

		// Token: 0x06031A7B RID: 203387 RVA: 0x00DE3614 File Offset: 0x00DE1814
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

		// Token: 0x06031A7C RID: 203388 RVA: 0x00DE366C File Offset: 0x00DE186C
		public void RefreshKeyByName(string keyName)
		{
			InputKey key = InputSettings.Instance.GetKey(keyName);
			if (key == null)
			{
				return;
			}
			this.RefreshKey(key);
		}

		// Token: 0x06031A7D RID: 203389 RVA: 0x00DE3690 File Offset: 0x00DE1890
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

		// Token: 0x06031A7E RID: 203390 RVA: 0x00DE36D8 File Offset: 0x00DE18D8
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

		// Token: 0x06031A7F RID: 203391 RVA: 0x00DE3728 File Offset: 0x00DE1928
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

		// Token: 0x06031A80 RID: 203392 RVA: 0x00DE37BD File Offset: 0x00DE19BD
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

		// Token: 0x06031A81 RID: 203393 RVA: 0x00DE37F8 File Offset: 0x00DE19F8
		public void SetGray(bool bIsGray)
		{
			if (this.IsGray == bIsGray)
			{
				return;
			}
			this.IsGray = bIsGray;
			this.OnSetGray();
		}

		// Token: 0x06031A82 RID: 203394 RVA: 0x00DE3811 File Offset: 0x00DE1A11
		protected virtual void OnSetGray()
		{
		}

		// Token: 0x06031A83 RID: 203395
		[NullableContext(2)]
		protected abstract UUIText GetKeyText();

		// Token: 0x06031A84 RID: 203396
		[NullableContext(2)]
		protected abstract UUITexture GetKeyTexture();

		// Token: 0x0401A498 RID: 107672
		[Nullable(2)]
		protected string ActionName;

		// Token: 0x0401A499 RID: 107673
		[Nullable(2)]
		protected string AxisName;

		// Token: 0x0401A49A RID: 107674
		[Nullable(2)]
		private string CustomKeyName;

		// Token: 0x0401A49B RID: 107675
		[Nullable(2)]
		protected string KeyName;

		// Token: 0x0401A49C RID: 107676
		[Nullable(2)]
		protected string KeyTexturePath;

		// Token: 0x0401A49D RID: 107677
		protected bool IsEnable;

		// Token: 0x0401A49E RID: 107678
		protected bool IsGray;

		// Token: 0x0401A49F RID: 107679
		private const float DISABLE_ALPHA = 0.2f;
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048EA RID: 18666
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KeyBaseComponent : UiPanelBase
	{
		// Token: 0x06030CFB RID: 199931
		protected abstract UUIText GetNameText();

		// Token: 0x06030CFC RID: 199932
		protected abstract UUITexture GetKeyTexture();

		// Token: 0x06030CFD RID: 199933
		protected abstract UUIItem GetLongPressItem();

		// Token: 0x06030CFE RID: 199934
		protected abstract UUIItem GetCircleItem();

		// Token: 0x06030CFF RID: 199935
		protected abstract UUIItem GetSquareItem();

		// Token: 0x06030D00 RID: 199936
		protected abstract UUITexture GetLongPressTipTexture();

		// Token: 0x06030D01 RID: 199937 RVA: 0x00B55D84 File Offset: 0x00B53F84
		protected override UniTask OnBeforeStartAsync()
		{
			KeyBaseComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KeyBaseComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030D02 RID: 199938 RVA: 0x00B55DC7 File Offset: 0x00B53FC7
		[NullableContext(2)]
		public void SetKeyName(string keyName)
		{
			this.KeyName = keyName;
		}

		// Token: 0x06030D03 RID: 199939 RVA: 0x00B55DD0 File Offset: 0x00B53FD0
		public void SetIsNeedLongPress(bool value)
		{
			this.IsNeedLongPress = value;
		}

		// Token: 0x06030D04 RID: 199940 RVA: 0x00B55DD9 File Offset: 0x00B53FD9
		[NullableContext(2)]
		public void RefreshKeyIcon(string keyName)
		{
			this.SetKeyName(keyName);
			this.SetKeyIcon(keyName);
		}

		// Token: 0x06030D05 RID: 199941 RVA: 0x00B55DEC File Offset: 0x00B53FEC
		public void RefreshNameText(string textId)
		{
			if (StringUtils.IsEmpty(textId))
			{
				this.SetNameTextVisible(false);
				return;
			}
			if (textId == "Hide")
			{
				this.SetNameTextVisible(false);
				return;
			}
			string hotKeyText = UiNavigationConfig.Instance.GetHotKeyText(textId);
			if (hotKeyText == null)
			{
				this.SetNameTextVisible(false);
				return;
			}
			this.SetNameTextById(hotKeyText);
			this.SetNameTextVisible(true);
		}

		// Token: 0x06030D06 RID: 199942 RVA: 0x00B55E43 File Offset: 0x00B54043
		[NullableContext(2)]
		private void SetKeyIcon(string keyName)
		{
			this.SetKeyIconAsync(keyName);
		}

		// Token: 0x06030D07 RID: 199943 RVA: 0x00B55E50 File Offset: 0x00B54050
		[NullableContext(2)]
		private UniTask SetKeyIconAsync(string keyName)
		{
			KeyBaseComponent.<SetKeyIconAsync>d__18 <SetKeyIconAsync>d__;
			<SetKeyIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetKeyIconAsync>d__.<>4__this = this;
			<SetKeyIconAsync>d__.keyName = keyName;
			<SetKeyIconAsync>d__.<>1__state = -1;
			<SetKeyIconAsync>d__.<>t__builder.Start<KeyBaseComponent.<SetKeyIconAsync>d__18>(ref <SetKeyIconAsync>d__);
			return <SetKeyIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030D08 RID: 199944 RVA: 0x00B55E9C File Offset: 0x00B5409C
		private void SetKeyIconVisible(bool bVisible)
		{
			UUITexture keyTexture = this.GetKeyTexture();
			if (keyTexture == null)
			{
				return;
			}
			keyTexture.SetUIActive(bVisible);
		}

		// Token: 0x06030D09 RID: 199945 RVA: 0x00B55EBC File Offset: 0x00B540BC
		public void SetNameTextById(string keyTextId)
		{
			if (this.IsForceSetText)
			{
				return;
			}
			UUIText nameText = this.GetNameText();
			if (nameText == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(nameText, keyTextId, Array.Empty<object>());
		}

		// Token: 0x06030D0A RID: 199946 RVA: 0x00B55EF0 File Offset: 0x00B540F0
		public void SetNameText(string keyText)
		{
			UUIText nameText = this.GetNameText();
			if (nameText == null)
			{
				return;
			}
			nameText.SetText(keyText, true);
		}

		// Token: 0x06030D0B RID: 199947 RVA: 0x00B55F10 File Offset: 0x00B54110
		public void SetNameTextForce(bool value)
		{
			this.IsForceSetText = value;
		}

		// Token: 0x06030D0C RID: 199948 RVA: 0x00B55F19 File Offset: 0x00B54119
		public bool GetIsForceSetText()
		{
			return this.IsForceSetText;
		}

		// Token: 0x06030D0D RID: 199949 RVA: 0x00B55F24 File Offset: 0x00B54124
		public void SetNameTextVisible(bool bVisible)
		{
			UUIText nameText = this.GetNameText();
			if (nameText == null)
			{
				return;
			}
			nameText.SetUIActive(bVisible);
		}

		// Token: 0x06030D0E RID: 199950 RVA: 0x00B55F44 File Offset: 0x00B54144
		private void SetLongPressItemVisible(bool bVisible)
		{
			UUIItem longPressItem = this.GetLongPressItem();
			if (longPressItem == null)
			{
				return;
			}
			if (longPressItem.bIsUIActive == bVisible)
			{
				return;
			}
			longPressItem.SetUIActive(bVisible);
		}

		// Token: 0x06030D0F RID: 199951 RVA: 0x00B55F6D File Offset: 0x00B5416D
		public void SetLongPressState(float percent)
		{
			this.SetLongPressPercent(percent);
			this.SetLongPressTipTextureActive(percent == 0f);
		}

		// Token: 0x06030D10 RID: 199952 RVA: 0x00B55F84 File Offset: 0x00B54184
		public void SetLongPressItemAlpha(float alpha)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(alpha);
		}

		// Token: 0x06030D11 RID: 199953 RVA: 0x00B55F97 File Offset: 0x00B54197
		private void SetLongPressPercent(float percent)
		{
			if (this.PcAndGamepad == null)
			{
				return;
			}
			this.PcAndGamepad.SetProgressPercent(percent);
		}

		// Token: 0x06030D12 RID: 199954 RVA: 0x00B55FB0 File Offset: 0x00B541B0
		private void SetLongPressTipTextureActive(bool active)
		{
			UUITexture longPressTipTexture = this.GetLongPressTipTexture();
			if (longPressTipTexture == null)
			{
				return;
			}
			longPressTipTexture.SetUIActive(active);
		}

		// Token: 0x06030D13 RID: 199955 RVA: 0x00B55FCF File Offset: 0x00B541CF
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			this.HotKeyType = hotKeyType;
		}

		// Token: 0x06030D14 RID: 199956 RVA: 0x00B55FD8 File Offset: 0x00B541D8
		public void RefreshPcAndGamepad()
		{
			if (this.IsNeedLongPress)
			{
				PcAndGamepadProgressBar pcAndGamepad = this.PcAndGamepad;
				if (pcAndGamepad == null)
				{
					return;
				}
				pcAndGamepad.RefreshProgressVisible();
			}
		}

		// Token: 0x06030D15 RID: 199957 RVA: 0x00B55FF2 File Offset: 0x00B541F2
		public override void SetActive(bool value)
		{
			base.SetActive(value);
			HotKeyTypeBase hotKeyType = this.HotKeyType;
			if (hotKeyType == null)
			{
				return;
			}
			hotKeyType.KeyItemNotifySetActive(value);
		}

		// Token: 0x0401A358 RID: 107352
		private bool IsForceSetText;

		// Token: 0x0401A359 RID: 107353
		[Nullable(2)]
		private HotKeyTypeBase HotKeyType;

		// Token: 0x0401A35A RID: 107354
		[Nullable(2)]
		private PcAndGamepadProgressBar PcAndGamepad;

		// Token: 0x0401A35B RID: 107355
		[Nullable(2)]
		private string KeyName;

		// Token: 0x0401A35C RID: 107356
		private bool IsNeedLongPress;

		// Token: 0x0401A35D RID: 107357
		private string KeyIconPath = "";
	}
}

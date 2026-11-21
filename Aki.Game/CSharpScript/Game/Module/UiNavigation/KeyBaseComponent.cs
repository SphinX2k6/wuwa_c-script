using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003861 RID: 14433
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KeyBaseComponent : UiPanelBase
	{
		// Token: 0x06025828 RID: 153640
		protected abstract UUIText GetNameText();

		// Token: 0x06025829 RID: 153641
		protected abstract UUITexture GetKeyTexture();

		// Token: 0x0602582A RID: 153642
		protected abstract UUIItem GetLongPressItem();

		// Token: 0x0602582B RID: 153643
		protected abstract UUIItem GetCircleItem();

		// Token: 0x0602582C RID: 153644
		protected abstract UUIItem GetSquareItem();

		// Token: 0x0602582D RID: 153645
		protected abstract UUITexture GetLongPressTipTexture();

		// Token: 0x0602582E RID: 153646 RVA: 0x00A90BF4 File Offset: 0x00A8EDF4
		protected override UniTask OnBeforeStartAsync()
		{
			KeyBaseComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KeyBaseComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602582F RID: 153647 RVA: 0x00A90C37 File Offset: 0x00A8EE37
		[NullableContext(2)]
		public void SetKeyName(string keyName)
		{
			this.KeyName = keyName;
		}

		// Token: 0x06025830 RID: 153648 RVA: 0x00A90C40 File Offset: 0x00A8EE40
		public void SetIsNeedLongPress(bool value)
		{
			this.IsNeedLongPress = value;
		}

		// Token: 0x06025831 RID: 153649 RVA: 0x00A90C49 File Offset: 0x00A8EE49
		[NullableContext(2)]
		public void RefreshKeyIcon(string keyName)
		{
			this.SetKeyName(keyName);
			this.SetKeyIcon(keyName);
		}

		// Token: 0x06025832 RID: 153650 RVA: 0x00A90C5C File Offset: 0x00A8EE5C
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

		// Token: 0x06025833 RID: 153651 RVA: 0x00A90CB3 File Offset: 0x00A8EEB3
		[NullableContext(2)]
		private void SetKeyIcon(string keyName)
		{
			this.SetKeyIconAsync(keyName);
		}

		// Token: 0x06025834 RID: 153652 RVA: 0x00A90CC0 File Offset: 0x00A8EEC0
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

		// Token: 0x06025835 RID: 153653 RVA: 0x00A90D0C File Offset: 0x00A8EF0C
		private void SetKeyIconVisible(bool bVisible)
		{
			UUITexture keyTexture = this.GetKeyTexture();
			if (keyTexture == null)
			{
				return;
			}
			keyTexture.SetUIActive(bVisible);
		}

		// Token: 0x06025836 RID: 153654 RVA: 0x00A90D2C File Offset: 0x00A8EF2C
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

		// Token: 0x06025837 RID: 153655 RVA: 0x00A90D60 File Offset: 0x00A8EF60
		public void SetNameText(string keyText)
		{
			UUIText nameText = this.GetNameText();
			if (nameText == null)
			{
				return;
			}
			nameText.SetText(keyText, true);
		}

		// Token: 0x06025838 RID: 153656 RVA: 0x00A90D80 File Offset: 0x00A8EF80
		public void SetNameTextForce(bool value)
		{
			this.IsForceSetText = value;
		}

		// Token: 0x06025839 RID: 153657 RVA: 0x00A90D89 File Offset: 0x00A8EF89
		public bool GetIsForceSetText()
		{
			return this.IsForceSetText;
		}

		// Token: 0x0602583A RID: 153658 RVA: 0x00A90D94 File Offset: 0x00A8EF94
		public void SetNameTextVisible(bool bVisible)
		{
			UUIText nameText = this.GetNameText();
			if (nameText == null)
			{
				return;
			}
			nameText.SetUIActive(bVisible);
		}

		// Token: 0x0602583B RID: 153659 RVA: 0x00A90DB4 File Offset: 0x00A8EFB4
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

		// Token: 0x0602583C RID: 153660 RVA: 0x00A90DDD File Offset: 0x00A8EFDD
		public void SetLongPressState(float percent)
		{
			this.SetLongPressPercent(percent);
			this.SetLongPressTipTextureActive(percent == 0f);
		}

		// Token: 0x0602583D RID: 153661 RVA: 0x00A90DF4 File Offset: 0x00A8EFF4
		public void SetLongPressItemAlpha(float alpha)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(alpha);
		}

		// Token: 0x0602583E RID: 153662 RVA: 0x00A90E07 File Offset: 0x00A8F007
		private void SetLongPressPercent(float percent)
		{
			if (this.PcAndGamepad == null)
			{
				return;
			}
			this.PcAndGamepad.SetProgressPercent(percent);
		}

		// Token: 0x0602583F RID: 153663 RVA: 0x00A90E20 File Offset: 0x00A8F020
		private void SetLongPressTipTextureActive(bool active)
		{
			UUITexture longPressTipTexture = this.GetLongPressTipTexture();
			if (longPressTipTexture == null)
			{
				return;
			}
			longPressTipTexture.SetUIActive(active);
		}

		// Token: 0x06025840 RID: 153664 RVA: 0x00A90E3F File Offset: 0x00A8F03F
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			this.HotKeyType = hotKeyType;
		}

		// Token: 0x06025841 RID: 153665 RVA: 0x00A90E48 File Offset: 0x00A8F048
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

		// Token: 0x06025842 RID: 153666 RVA: 0x00A90E62 File Offset: 0x00A8F062
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

		// Token: 0x04014BCB RID: 84939
		private bool IsForceSetText;

		// Token: 0x04014BCC RID: 84940
		[Nullable(2)]
		private HotKeyTypeBase HotKeyType;

		// Token: 0x04014BCD RID: 84941
		[Nullable(2)]
		private PcAndGamepadProgressBar PcAndGamepad;

		// Token: 0x04014BCE RID: 84942
		[Nullable(2)]
		private string KeyName;

		// Token: 0x04014BCF RID: 84943
		private bool IsNeedLongPress;

		// Token: 0x04014BD0 RID: 84944
		private string KeyIconPath = "";
	}
}

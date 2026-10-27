using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001953 RID: 6483
public class PlayerTitleItem : UiPanelBase
{
	// Token: 0x0600BD4B RID: 48459 RVA: 0x002ACDB8 File Offset: 0x002AAFB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action<EToggleState>(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BD4C RID: 48460 RVA: 0x002AD058 File Offset: 0x002AB258
	public void Refresh(int? playerTitleId, int? playerTitleStarLevel, int? sex)
	{
		if (playerTitleId == null || playerTitleId.Value == 0)
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		this.PlayerTitleConfig = InventoryConfig.Instance.GetPlayerTitleItemConfig(playerTitleId.Value);
		if (this.PlayerTitleConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), this.PlayerTitleConfig.Value.TitleName, Array.Empty<object>());
		string titleBgIcon = this.PlayerTitleConfig.Value.TitleBgIcon;
		if (!string.IsNullOrEmpty(titleBgIcon))
		{
			base.SetTextureByPath(titleBgIcon, base.GetTexture(0), null, null);
		}
		string selectedIcon = this.PlayerTitleConfig.Value.SelectedIcon;
		base.SetTextureByPath(selectedIcon, base.GetTexture(10), null, null);
		int titleStyle = this.PlayerTitleConfig.Value.TitleStyle;
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(16);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(1);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		if (titleStyle == 1)
		{
			int? num = sex;
			int num2 = 0;
			this.RefreshCommonTitle(num.GetValueOrDefault() == num2 & num != null);
		}
		else if (titleStyle == 2)
		{
			this.RefreshStarTitle(playerTitleStarLevel);
		}
		this.RefreshDecorate();
	}

	// Token: 0x0600BD4D RID: 48461 RVA: 0x002AD1BC File Offset: 0x002AB3BC
	public void RefreshCommonTitle(bool isFemale)
	{
		if (!string.IsNullOrEmpty((this.PlayerTitleConfig != null) ? this.PlayerTitleConfig.GetValueOrDefault().TitleIcon : null))
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.SetIconAndColor(this.PlayerTitleConfig.Value.TitleIcon, base.GetTexture(8));
		}
		if (!string.IsNullOrEmpty(this.PlayerTitleConfig.Value.RoleHeadIcon))
		{
			UUIItem item2 = base.GetItem(16);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			string path = this.PlayerTitleConfig.Value.RoleHeadIcon;
			if (isFemale)
			{
				path = this.PlayerTitleConfig.Value.FemaleRoleHeadIcon;
			}
			UUITexture roleHeadTexture = base.GetTexture(17);
			base.SetTextureByPath(path, roleHeadTexture, null, delegate(bool success)
			{
				if (success)
				{
					roleHeadTexture.SetSizeFromTexture();
				}
			});
		}
	}

	// Token: 0x0600BD4E RID: 48462 RVA: 0x002AD2B4 File Offset: 0x002AB4B4
	public void RefreshStarTitle(int? playerTitleStarLevel)
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.SetIconAndColor(this.PlayerTitleConfig.Value.TitleIcon, base.GetTexture(6));
		this.SetIconAndColor(this.PlayerTitleConfig.Value.StarTitleBgIcon, base.GetTexture(2));
		this.SetIconAndColor(this.PlayerTitleConfig.Value.StarTitleIcon, base.GetTexture(3));
		UUIText text = base.GetText(4);
		int valueOrDefault = playerTitleStarLevel.GetValueOrDefault();
		if (text != null)
		{
			this.PlayerTitleStarLevel = valueOrDefault;
			text.SetText(valueOrDefault.ToString(), true);
			text.SetColor(FColor.FromHex(PersonalDefine.playerTitleQualityToColor[this.PlayerTitleConfig.Value.TitleQuality]));
		}
	}

	// Token: 0x0600BD4F RID: 48463 RVA: 0x002AD384 File Offset: 0x002AB584
	public void RefreshDecorate()
	{
		string decorateLeftNiagara = this.PlayerTitleConfig.Value.DecorateLeftNiagara;
		UUINiagara uiNiagara = base.GetUiNiagara(13);
		if (!string.IsNullOrEmpty(decorateLeftNiagara))
		{
			base.SetNiagaraSystemByPath(decorateLeftNiagara, uiNiagara, null);
			uiNiagara.SetUIActive(true);
		}
		else
		{
			uiNiagara.SetUIActive(false);
		}
		string decorateRightNiagara = this.PlayerTitleConfig.Value.DecorateRightNiagara;
		UUINiagara uiNiagara2 = base.GetUiNiagara(14);
		if (!string.IsNullOrEmpty(decorateRightNiagara))
		{
			base.SetNiagaraSystemByPath(decorateRightNiagara, uiNiagara2, null);
			uiNiagara2.SetUIActive(true);
		}
		else
		{
			uiNiagara2.SetUIActive(false);
		}
		string decorateBgNiagara = this.PlayerTitleConfig.Value.DecorateBgNiagara;
		UUINiagara uiNiagara3 = base.GetUiNiagara(15);
		if (!string.IsNullOrEmpty(decorateBgNiagara))
		{
			base.SetNiagaraSystemByPath(decorateBgNiagara, uiNiagara3, null);
			uiNiagara3.SetUIActive(true);
			return;
		}
		uiNiagara3.SetUIActive(false);
	}

	// Token: 0x0600BD50 RID: 48464 RVA: 0x002AD454 File Offset: 0x002AB654
	[NullableContext(1)]
	private void SetIconAndColor(string iconPath, UUITexture iconItem)
	{
		base.SetTextureByPath(iconPath, iconItem, null, null);
		int titleQuality = this.PlayerTitleConfig.Value.TitleQuality;
		if (iconItem != null)
		{
			iconItem.SetColor(FColor.FromHex(PersonalDefine.playerTitleQualityToColor[titleQuality]));
		}
	}

	// Token: 0x0600BD51 RID: 48465 RVA: 0x002AD4A0 File Offset: 0x002AB6A0
	public void SetIsPreview(bool isPreview)
	{
		this.IsPreview = isPreview;
	}

	// Token: 0x0600BD52 RID: 48466 RVA: 0x002AD4AC File Offset: 0x002AB6AC
	private void OnBtnClick(EToggleState state)
	{
		if (!this.IsPreview)
		{
			UUIItem item = base.GetItem(11);
			string playerTitleInfoString = PersonalModel.Instance.GetPlayerTitleInfoString(this.PlayerTitleConfig.Value.Id, this.PlayerTitleStarLevel, false);
			string iconInTitleInfo = this.PlayerTitleConfig.Value.IconInTitleInfo;
			if (this.CanShowTip)
			{
				UiManager.Instance.OpenView(EUiViewName.PlayerTitleInfoTip, new PlayerTitleInfoTipParams
				{
					ItemForLocation = item,
					PlayerTitleInfoString = playerTitleInfoString,
					PlayerTitleInfoIcon = iconInTitleInfo
				}, delegate(bool isSuccess, int viewId)
				{
					PlayerTitleInfoTip playerTitleInfoTip = UiManager.Instance.GetViewByName(EUiViewName.PlayerTitleInfoTip) as PlayerTitleInfoTip;
					if (playerTitleInfoTip != null)
					{
						playerTitleInfoTip.BindCloseCallback(new Action(this.SetToggleState));
					}
				});
			}
			this.CallBack();
		}
	}

	// Token: 0x0600BD53 RID: 48467 RVA: 0x002AD54E File Offset: 0x002AB74E
	private void SetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(12);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04005565 RID: 21861
	private PlayerTitle? PlayerTitleConfig;

	// Token: 0x04005566 RID: 21862
	private bool IsPreview;

	// Token: 0x04005567 RID: 21863
	private int PlayerTitleStarLevel;

	// Token: 0x04005568 RID: 21864
	[Nullable(1)]
	public Action CallBack = delegate()
	{
	};

	// Token: 0x04005569 RID: 21865
	public bool CanShowTip = true;

	// Token: 0x02007EAF RID: 32431
	private class EPlayerTitleDefine
	{
		// Token: 0x040296A8 RID: 169640
		public const int TextureBg = 0;

		// Token: 0x040296A9 RID: 169641
		public const int PanelStarTitle = 1;

		// Token: 0x040296AA RID: 169642
		public const int TextureStarBg = 2;

		// Token: 0x040296AB RID: 169643
		public const int TextureStarSmallIcon = 3;

		// Token: 0x040296AC RID: 169644
		public const int TxtStarParam = 4;

		// Token: 0x040296AD RID: 169645
		public const int TextureStarIcon = 6;

		// Token: 0x040296AE RID: 169646
		public const int PanelComTitle = 7;

		// Token: 0x040296AF RID: 169647
		public const int TextureComIcon = 8;

		// Token: 0x040296B0 RID: 169648
		public const int TxtName = 9;

		// Token: 0x040296B1 RID: 169649
		public const int TextureSelected = 10;

		// Token: 0x040296B2 RID: 169650
		public const int PanelInfoTip = 11;

		// Token: 0x040296B3 RID: 169651
		public const int ToggleRoot = 12;

		// Token: 0x040296B4 RID: 169652
		public const int NiagaraDecorateLeft = 13;

		// Token: 0x040296B5 RID: 169653
		public const int NiagaraDecorateRight = 14;

		// Token: 0x040296B6 RID: 169654
		public const int NiagaraBg = 15;

		// Token: 0x040296B7 RID: 169655
		public const int ItemRoleHeadPanel = 16;

		// Token: 0x040296B8 RID: 169656
		public const int TextureRoleHead = 17;
	}
}

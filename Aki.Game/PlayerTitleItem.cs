using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E10 RID: 3600
public class PlayerTitleItem : UiPanelBase
{
	// Token: 0x0600914E RID: 37198 RVA: 0x002B7BFC File Offset: 0x002B5DFC
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

	// Token: 0x0600914F RID: 37199 RVA: 0x002B7E9C File Offset: 0x002B609C
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

	// Token: 0x06009150 RID: 37200 RVA: 0x002B8000 File Offset: 0x002B6200
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

	// Token: 0x06009151 RID: 37201 RVA: 0x002B80F8 File Offset: 0x002B62F8
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

	// Token: 0x06009152 RID: 37202 RVA: 0x002B81C8 File Offset: 0x002B63C8
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

	// Token: 0x06009153 RID: 37203 RVA: 0x002B8298 File Offset: 0x002B6498
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

	// Token: 0x06009154 RID: 37204 RVA: 0x002B82E4 File Offset: 0x002B64E4
	public void SetIsPreview(bool isPreview)
	{
		this.IsPreview = isPreview;
	}

	// Token: 0x06009155 RID: 37205 RVA: 0x002B82F0 File Offset: 0x002B64F0
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

	// Token: 0x06009156 RID: 37206 RVA: 0x002B8392 File Offset: 0x002B6592
	private void SetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(12);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04005612 RID: 22034
	private PlayerTitle? PlayerTitleConfig;

	// Token: 0x04005613 RID: 22035
	private bool IsPreview;

	// Token: 0x04005614 RID: 22036
	private int PlayerTitleStarLevel;

	// Token: 0x04005615 RID: 22037
	[Nullable(1)]
	public Action CallBack = delegate()
	{
	};

	// Token: 0x04005616 RID: 22038
	public bool CanShowTip = true;

	// Token: 0x0200703E RID: 28734
	private class EPlayerTitleDefine
	{
		// Token: 0x040249E5 RID: 149989
		public const int TextureBg = 0;

		// Token: 0x040249E6 RID: 149990
		public const int PanelStarTitle = 1;

		// Token: 0x040249E7 RID: 149991
		public const int TextureStarBg = 2;

		// Token: 0x040249E8 RID: 149992
		public const int TextureStarSmallIcon = 3;

		// Token: 0x040249E9 RID: 149993
		public const int TxtStarParam = 4;

		// Token: 0x040249EA RID: 149994
		public const int TextureStarIcon = 6;

		// Token: 0x040249EB RID: 149995
		public const int PanelComTitle = 7;

		// Token: 0x040249EC RID: 149996
		public const int TextureComIcon = 8;

		// Token: 0x040249ED RID: 149997
		public const int TxtName = 9;

		// Token: 0x040249EE RID: 149998
		public const int TextureSelected = 10;

		// Token: 0x040249EF RID: 149999
		public const int PanelInfoTip = 11;

		// Token: 0x040249F0 RID: 150000
		public const int ToggleRoot = 12;

		// Token: 0x040249F1 RID: 150001
		public const int NiagaraDecorateLeft = 13;

		// Token: 0x040249F2 RID: 150002
		public const int NiagaraDecorateRight = 14;

		// Token: 0x040249F3 RID: 150003
		public const int NiagaraBg = 15;

		// Token: 0x040249F4 RID: 150004
		public const int ItemRoleHeadPanel = 16;

		// Token: 0x040249F5 RID: 150005
		public const int TextureRoleHead = 17;
	}
}

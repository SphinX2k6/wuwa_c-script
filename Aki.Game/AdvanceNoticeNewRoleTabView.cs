using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200058B RID: 1419
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeNewRoleTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043D3 RID: 17363 RVA: 0x00176934 File Offset: 0x00174B34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUINiagara)),
			new ValueTuple<int, Type>(10, typeof(UUINiagara)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x00176A58 File Offset: 0x00174C58
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeNewRoleTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeNewRoleTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043D5 RID: 17365 RVA: 0x00176A9C File Offset: 0x00174C9C
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabCharacter advertisingTabCharacterById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCharacterById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabCharacterById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), advertisingTabCharacterById.GetWayTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), advertisingTabCharacterById.GetWayDescription, Array.Empty<object>());
		UUITexture texture = base.GetTexture(0);
		UUITexture texture2 = base.GetTexture(7);
		UUITexture texture3 = base.GetTexture(8);
		UUINiagara uiNiagara = base.GetUiNiagara(9);
		UUINiagara uiNiagara2 = base.GetUiNiagara(10);
		string path = string.Empty;
		if (advertisingTabCharacterById.Type == 1)
		{
			texture2.SetUIActive(false);
			texture3.SetUIActive(false);
			texture.SetUIActive(true);
			uiNiagara.SetUIActive(false);
			uiNiagara2.SetUIActive(false);
			this.CheckToSetTextureByPath(advertisingTabCharacterById.MainBgPic, texture);
			path = advertisingTabCharacterById.SpinePrefabResource;
		}
		else
		{
			texture2.SetUIActive(true);
			texture3.SetUIActive(true);
			texture.SetUIActive(true);
			this.CheckToSetTextureByPath(advertisingTabCharacterById.MainPic, texture2);
			this.CheckToSetTextureByPath(advertisingTabCharacterById.MainBgPic, texture);
			this.CheckToSetTextureByPath(advertisingTabCharacterById.MainPic, texture3);
			int qualityId = advertisingTabCharacterById.QualityId;
			uiNiagara.SetUIActive(qualityId == 4);
			uiNiagara2.SetUIActive(qualityId == 5);
			path = advertisingTabCharacterById.WeaponPrefabPath;
		}
		this.DetailItem.Refresh(currentSubTabId);
		this.ShowItem(currentSubTabId, advertisingTabCharacterById.Type, path).Forget();
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x00176C24 File Offset: 0x00174E24
	private void CheckToSetTextureByPath(string texturePath, UUITexture textureComp)
	{
		if (StringUtils.IsBlank(texturePath))
		{
			return;
		}
		base.SetTextureByPath(texturePath, textureComp, null, null);
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x00176C4C File Offset: 0x00174E4C
	private UniTask ShowItem(int id, int type, string path)
	{
		AdvanceNoticeNewRoleTabView.<ShowItem>d__8 <ShowItem>d__;
		<ShowItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowItem>d__.<>4__this = this;
		<ShowItem>d__.id = id;
		<ShowItem>d__.type = type;
		<ShowItem>d__.path = path;
		<ShowItem>d__.<>1__state = -1;
		<ShowItem>d__.<>t__builder.Start<AdvanceNoticeNewRoleTabView.<ShowItem>d__8>(ref <ShowItem>d__);
		return <ShowItem>d__.<>t__builder.Task;
	}

	// Token: 0x040034B1 RID: 13489
	[Nullable(2)]
	private AdvanceNoticeNewRoleDetailItem DetailItem;

	// Token: 0x040034B2 RID: 13490
	private readonly Dictionary<int, AdvanceNoticeItemView> AdvanceNoticeItemViewMap = new Dictionary<int, AdvanceNoticeItemView>();

	// Token: 0x040034B3 RID: 13491
	[Nullable(2)]
	private AdvanceNoticeItemView CurrentItem;

	// Token: 0x02006830 RID: 26672
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x04022594 RID: 140692
		BgTexture,
		// Token: 0x04022595 RID: 140693
		TitleDescText,
		// Token: 0x04022596 RID: 140694
		NameText,
		// Token: 0x04022597 RID: 140695
		ContentText,
		// Token: 0x04022598 RID: 140696
		DetailItem,
		// Token: 0x04022599 RID: 140697
		GetWayTitleText,
		// Token: 0x0402259A RID: 140698
		GetWayDescText,
		// Token: 0x0402259B RID: 140699
		ContentTexture,
		// Token: 0x0402259C RID: 140700
		ShadowTexture,
		// Token: 0x0402259D RID: 140701
		PurpleEffectNiagara,
		// Token: 0x0402259E RID: 140702
		GoldEffectNiagara,
		// Token: 0x0402259F RID: 140703
		PnlContent
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010D7 RID: 4311
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeNewRoleTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x0600703D RID: 28733 RVA: 0x0016DF78 File Offset: 0x0016C178
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

	// Token: 0x0600703E RID: 28734 RVA: 0x0016E09C File Offset: 0x0016C29C
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeNewRoleTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeNewRoleTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600703F RID: 28735 RVA: 0x0016E0E0 File Offset: 0x0016C2E0
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

	// Token: 0x06007040 RID: 28736 RVA: 0x0016E268 File Offset: 0x0016C468
	private void CheckToSetTextureByPath(string texturePath, UUITexture textureComp)
	{
		if (StringUtils.IsBlank(texturePath))
		{
			return;
		}
		base.SetTextureByPath(texturePath, textureComp, null, null);
	}

	// Token: 0x06007041 RID: 28737 RVA: 0x0016E290 File Offset: 0x0016C490
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

	// Token: 0x04003418 RID: 13336
	[Nullable(2)]
	private AdvanceNoticeNewRoleDetailItem DetailItem;

	// Token: 0x04003419 RID: 13337
	private readonly Dictionary<int, AdvanceNoticeItemView> AdvanceNoticeItemViewMap = new Dictionary<int, AdvanceNoticeItemView>();

	// Token: 0x0400341A RID: 13338
	[Nullable(2)]
	private AdvanceNoticeItemView CurrentItem;

	// Token: 0x0200769C RID: 30364
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402724B RID: 160331
		BgTexture,
		// Token: 0x0402724C RID: 160332
		TitleDescText,
		// Token: 0x0402724D RID: 160333
		NameText,
		// Token: 0x0402724E RID: 160334
		ContentText,
		// Token: 0x0402724F RID: 160335
		DetailItem,
		// Token: 0x04027250 RID: 160336
		GetWayTitleText,
		// Token: 0x04027251 RID: 160337
		GetWayDescText,
		// Token: 0x04027252 RID: 160338
		ContentTexture,
		// Token: 0x04027253 RID: 160339
		ShadowTexture,
		// Token: 0x04027254 RID: 160340
		PurpleEffectNiagara,
		// Token: 0x04027255 RID: 160341
		GoldEffectNiagara,
		// Token: 0x04027256 RID: 160342
		PnlContent
	}
}

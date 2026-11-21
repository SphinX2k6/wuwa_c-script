using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018BB RID: 6331
[NullableContext(1)]
[Nullable(0)]
public class PersonalHeadPhotoComponent : UiPanelBase
{
	// Token: 0x17001804 RID: 6148
	// (get) Token: 0x0600FA15 RID: 64021 RVA: 0x00491974 File Offset: 0x0048FB74
	[Nullable(2)]
	private PlayerHeadData CurSelectPlayerHead
	{
		[NullableContext(2)]
		get
		{
			int selectedGridIndex = this.ScrollView.GetGenericLayout().GetSelectedGridIndex();
			if (selectedGridIndex < 0 || selectedGridIndex >= this.PlayerHeadDataList.Count)
			{
				return null;
			}
			return this.PlayerHeadDataList[selectedGridIndex];
		}
	}

	// Token: 0x0600FA16 RID: 64022 RVA: 0x004919B4 File Offset: 0x0048FBB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600FA17 RID: 64023 RVA: 0x00491A24 File Offset: 0x0048FC24
	protected override void OnStart()
	{
		this.PlayerHeadDataList = PersonalModel.Instance.GetPlayerShowHeadDataList();
		this.ScrollView = new GenericScrollViewNew<PersonalRoleSmallItemGrid, PlayerHeadData>(base.GetScrollViewWithScrollbar(0), new Func<PersonalRoleSmallItemGrid>(this.CreateCardItem), null, false, null);
		this.AddEventListener();
	}

	// Token: 0x0600FA18 RID: 64024 RVA: 0x00491A60 File Offset: 0x0048FC60
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalHeadPhotoComponent.<OnBeforeShowAsyncImplement>d__7 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalHeadPhotoComponent.<OnBeforeShowAsyncImplement>d__7>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA19 RID: 64025 RVA: 0x00491AA3 File Offset: 0x0048FCA3
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600FA1A RID: 64026 RVA: 0x00491AAB File Offset: 0x0048FCAB
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnHeadIconChange, new Action<int>(this.RefreshView));
	}

	// Token: 0x0600FA1B RID: 64027 RVA: 0x00491AC9 File Offset: 0x0048FCC9
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHeadIconChange, new Action<int>(this.RefreshView));
	}

	// Token: 0x0600FA1C RID: 64028 RVA: 0x00491AE7 File Offset: 0x0048FCE7
	public void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeHeadPhotoRequest(this.CurSelectPlayerHead.Id);
	}

	// Token: 0x0600FA1D RID: 64029 RVA: 0x00491AFE File Offset: 0x0048FCFE
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x0600FA1E RID: 64030 RVA: 0x00491B08 File Offset: 0x0048FD08
	private void RefreshView(int roleId)
	{
		this.PlayerHeadDataList = this.GetSortedList();
		this.ScrollView.RefreshByData(this.PlayerHeadDataList, null, false);
		for (int i = 0; i < this.PlayerHeadDataList.Count; i++)
		{
			this.ScrollView.GetScrollItemByIndex(i).RefreshEquipHeadIconItem();
		}
		int index = 0;
		this.ScrollView.ScrollTo(this.ScrollView.GetItemByIndex(index), false);
		this.SelectByRoleId(this.PlayerHeadDataList[index]);
	}

	// Token: 0x0600FA1F RID: 64031 RVA: 0x00491B87 File Offset: 0x0048FD87
	private PersonalRoleSmallItemGrid CreateCardItem()
	{
		PersonalRoleSmallItemGrid personalRoleSmallItemGrid = new PersonalRoleSmallItemGrid();
		personalRoleSmallItemGrid.BindToggleClickCallBack(new Action<PlayerHeadData>(this.RoleItemToggleClick));
		return personalRoleSmallItemGrid;
	}

	// Token: 0x0600FA20 RID: 64032 RVA: 0x00491BA0 File Offset: 0x0048FDA0
	private void RoleItemToggleClick(PlayerHeadData playerHeadData)
	{
		this.SelectByRoleId(playerHeadData);
	}

	// Token: 0x0600FA21 RID: 64033 RVA: 0x00491BAC File Offset: 0x0048FDAC
	private void SelectByRoleId(PlayerHeadData playerHeadData)
	{
		int num = this.PlayerHeadDataList.FindIndex((PlayerHeadData data) => data == playerHeadData);
		GenericScrollViewNew<PersonalRoleSmallItemGrid, PlayerHeadData> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			GenericLayout<PersonalRoleSmallItemGrid, PlayerHeadData> genericLayout = scrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(num, false);
			}
		}
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.ScrollView.GetItemByIndex(num), true, false, false);
		int headPhotoId = PersonalModel.Instance.GetHeadPhotoId();
		bool arg = !playerHeadData.Lock && headPhotoId != playerHeadData.Id;
		if (this.RefreshConfirmBtn != null)
		{
			this.RefreshConfirmBtn(arg, headPhotoId == playerHeadData.Id);
		}
		UUITexture roleTexture = base.GetTexture(1);
		roleTexture.SetUIActive(false);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), roleTexture, delegate(bool _)
		{
			roleTexture.SetUIActive(true);
		});
		base.GetText(2).ShowTextNew(playerHeadData.GetName());
		UUIText text = base.GetText(3);
		text.SetUIActive(playerHeadData.Lock);
		LguiUtil.Instance.SetLocalTextNew(text, playerHeadData.Config.Tips, Array.Empty<object>());
	}

	// Token: 0x0600FA22 RID: 64034 RVA: 0x00491CF8 File Offset: 0x0048FEF8
	private List<PlayerHeadData> GetSortedList()
	{
		List<PlayerHeadData> list = new List<PlayerHeadData>(PersonalModel.Instance.GetPlayerShowHeadDataList());
		int num = list.FindIndex((PlayerHeadData data) => data.Id == PersonalModel.Instance.GetHeadPhotoId());
		if (num <= 0 || num >= list.Count)
		{
			return list;
		}
		PlayerHeadData value = list[num];
		for (int i = num; i > 0; i--)
		{
			list[i] = list[i - 1];
		}
		list[0] = value;
		return list;
	}

	// Token: 0x04008BF3 RID: 35827
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PersonalRoleSmallItemGrid, PlayerHeadData> ScrollView;

	// Token: 0x04008BF4 RID: 35828
	protected List<PlayerHeadData> PlayerHeadDataList = new List<PlayerHeadData>();

	// Token: 0x04008BF5 RID: 35829
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;
}

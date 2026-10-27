using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023D6 RID: 9174
[NullableContext(1)]
[Nullable(0)]
public class PersonalHeadPhotoComponent : UiPanelBase
{
	// Token: 0x170017CA RID: 6090
	// (get) Token: 0x06012563 RID: 75107 RVA: 0x00484468 File Offset: 0x00482668
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

	// Token: 0x06012564 RID: 75108 RVA: 0x004844A8 File Offset: 0x004826A8
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

	// Token: 0x06012565 RID: 75109 RVA: 0x00484518 File Offset: 0x00482718
	protected override void OnStart()
	{
		this.PlayerHeadDataList = PersonalModel.Instance.GetPlayerShowHeadDataList();
		this.ScrollView = new GenericScrollViewNew<PersonalRoleSmallItemGrid, PlayerHeadData>(base.GetScrollViewWithScrollbar(0), new Func<PersonalRoleSmallItemGrid>(this.CreateCardItem), null, false, null);
		this.AddEventListener();
	}

	// Token: 0x06012566 RID: 75110 RVA: 0x00484554 File Offset: 0x00482754
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalHeadPhotoComponent.<OnBeforeShowAsyncImplement>d__7 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalHeadPhotoComponent.<OnBeforeShowAsyncImplement>d__7>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06012567 RID: 75111 RVA: 0x00484597 File Offset: 0x00482797
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x06012568 RID: 75112 RVA: 0x0048459F File Offset: 0x0048279F
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnHeadIconChange, new Action<int>(this.RefreshView));
	}

	// Token: 0x06012569 RID: 75113 RVA: 0x004845BD File Offset: 0x004827BD
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHeadIconChange, new Action<int>(this.RefreshView));
	}

	// Token: 0x0601256A RID: 75114 RVA: 0x004845DB File Offset: 0x004827DB
	public void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeHeadPhotoRequest(this.CurSelectPlayerHead.Id);
	}

	// Token: 0x0601256B RID: 75115 RVA: 0x004845F2 File Offset: 0x004827F2
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x0601256C RID: 75116 RVA: 0x004845FC File Offset: 0x004827FC
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

	// Token: 0x0601256D RID: 75117 RVA: 0x0048467B File Offset: 0x0048287B
	private PersonalRoleSmallItemGrid CreateCardItem()
	{
		PersonalRoleSmallItemGrid personalRoleSmallItemGrid = new PersonalRoleSmallItemGrid();
		personalRoleSmallItemGrid.BindToggleClickCallBack(new Action<PlayerHeadData>(this.RoleItemToggleClick));
		return personalRoleSmallItemGrid;
	}

	// Token: 0x0601256E RID: 75118 RVA: 0x00484694 File Offset: 0x00482894
	private void RoleItemToggleClick(PlayerHeadData playerHeadData)
	{
		this.SelectByRoleId(playerHeadData);
	}

	// Token: 0x0601256F RID: 75119 RVA: 0x004846A0 File Offset: 0x004828A0
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

	// Token: 0x06012570 RID: 75120 RVA: 0x004847EC File Offset: 0x004829EC
	private List<PlayerHeadData> GetSortedList()
	{
		List<PlayerHeadData> list = PersonalModel.Instance.GetPlayerShowHeadDataList().ToList<PlayerHeadData>();
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

	// Token: 0x04008AAC RID: 35500
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PersonalRoleSmallItemGrid, PlayerHeadData> ScrollView;

	// Token: 0x04008AAD RID: 35501
	protected List<PlayerHeadData> PlayerHeadDataList = new List<PlayerHeadData>();

	// Token: 0x04008AAE RID: 35502
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;
}

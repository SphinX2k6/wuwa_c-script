using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D15 RID: 7445
[NullableContext(1)]
[Nullable(0)]
public class RoleListComponent : UiPanelBase
{
	// Token: 0x17001B7B RID: 7035
	// (get) Token: 0x060126E4 RID: 75492 RVA: 0x00572314 File Offset: 0x00570514
	public int CurSelectDataId
	{
		get
		{
			int selectedGridIndex = this.ScrollView.GetGenericLayout().GetSelectedGridIndex();
			if (this.DataList == null || selectedGridIndex < 0 || selectedGridIndex >= this.DataList.Count)
			{
				return 0;
			}
			return this.DataList[selectedGridIndex].RoleDataId;
		}
	}

	// Token: 0x060126E5 RID: 75493 RVA: 0x0057235F File Offset: 0x0057055F
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericScrollViewNew<RoleListItem, RoleListItemData> GetSelfScrollView()
	{
		return this.ScrollView;
	}

	// Token: 0x060126E6 RID: 75494 RVA: 0x00572367 File Offset: 0x00570567
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x060126E7 RID: 75495 RVA: 0x0057238C File Offset: 0x0057058C
	protected override void OnStart()
	{
		this.RoleViewAgent = (this.OpenParam as RoleViewAgent);
		if (this.RoleViewAgent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleViewAgent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RoleListComponent");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ScrollView = new GenericScrollViewNew<RoleListItem, RoleListItemData>(base.GetScrollViewWithScrollbar(0), new Func<RoleListItem>(this.InitRoleItem), null, false, null);
	}

	// Token: 0x060126E8 RID: 75496 RVA: 0x005723FF File Offset: 0x005705FF
	private RoleListItem InitRoleItem()
	{
		return new RoleListItem
		{
			ToggleCallBack = new Action<int>(this.OnRoleItemToggleCallBack),
			CanToggleExecuteChange = new Func<int, bool>(this.CanToggleExecuteChange)
		};
	}

	// Token: 0x060126E9 RID: 75497 RVA: 0x0057242A File Offset: 0x0057062A
	private bool CanToggleExecuteChange(int gridIndex)
	{
		return this.ScrollView.GetGenericLayout().GetSelectedGridIndex() != gridIndex && !UiCameraModel.Instance.IsPlayingAnimation();
	}

	// Token: 0x060126EA RID: 75498 RVA: 0x00572450 File Offset: 0x00570650
	private void OnRoleItemToggleCallBack(int gridIndex)
	{
		this.ScrollView.GetGenericLayout().SelectGridProxy(gridIndex, false);
		this.RoleViewAgent.SetCurSelectRoleId(this.CurSelectDataId);
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		RoleController.Instance.OnSelectedRoleChange(this.CurSelectDataId, curSelectRoleData.GetRoleSkinId());
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemChangeRole, this.CurSelectDataId);
	}

	// Token: 0x060126EB RID: 75499 RVA: 0x005724B8 File Offset: 0x005706B8
	public void UnBindRedDot()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.RoleSystemRoleList);
	}

	// Token: 0x060126EC RID: 75500 RVA: 0x005724C5 File Offset: 0x005706C5
	public void SetRoleSystemUiParams(IRoleSystemUiParams roleSystemUiParams)
	{
		this.RoleSystemUiParams = roleSystemUiParams;
	}

	// Token: 0x060126ED RID: 75501 RVA: 0x005724D0 File Offset: 0x005706D0
	public UniTask UpdateComponent(IReadOnlyList<int> roleList)
	{
		RoleListComponent.<UpdateComponent>d__15 <UpdateComponent>d__;
		<UpdateComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateComponent>d__.<>4__this = this;
		<UpdateComponent>d__.roleList = roleList;
		<UpdateComponent>d__.<>1__state = -1;
		<UpdateComponent>d__.<>t__builder.Start<RoleListComponent.<UpdateComponent>d__15>(ref <UpdateComponent>d__);
		return <UpdateComponent>d__.<>t__builder.Task;
	}

	// Token: 0x060126EE RID: 75502 RVA: 0x0057251C File Offset: 0x0057071C
	public int FindDisplayIndex(Predicate<int> match)
	{
		List<RoleListItemData> dataList = this.DataList;
		if (dataList == null)
		{
			return -1;
		}
		return dataList.FindIndex((RoleListItemData data) => match(data.RoleDataId));
	}

	// Token: 0x060126EF RID: 75503 RVA: 0x00572553 File Offset: 0x00570753
	public void RefreshVisibleItems()
	{
		GenericScrollViewNew<RoleListItem, RoleListItemData> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		GenericLayout<RoleListItem, RoleListItemData> genericLayout = scrollView.GetGenericLayout();
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.RefreshWithoutDataSync();
	}

	// Token: 0x060126F0 RID: 75504 RVA: 0x00572570 File Offset: 0x00570770
	public void SetCurSelection(int dataId)
	{
		int num = this.DataList.IndexOf((RoleListItemData a) => a.RoleDataId == dataId);
		if (num < 0 || num >= this.DataList.Count)
		{
			return;
		}
		this.OnRoleItemToggleCallBack(num);
		UUIItem itemByIndex = this.ScrollView.GetItemByIndex(num);
		if (itemByIndex != null)
		{
			this.ScrollView.ScrollTo(itemByIndex, false);
		}
	}

	// Token: 0x0400A081 RID: 41089
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<RoleListItem, RoleListItemData> ScrollView;

	// Token: 0x0400A082 RID: 41090
	[Nullable(2)]
	protected RoleViewAgent RoleViewAgent;

	// Token: 0x0400A083 RID: 41091
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<RoleListItemData> DataList;

	// Token: 0x0400A084 RID: 41092
	[Nullable(2)]
	protected IRoleSystemUiParams RoleSystemUiParams;

	// Token: 0x02008053 RID: 32851
	[NullableContext(0)]
	private enum ERoleListComponentDefine
	{
		// Token: 0x04029854 RID: 170068
		ScrollViewWithScrollbar
	}
}

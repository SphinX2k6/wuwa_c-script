using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200279B RID: 10139
[NullableContext(1)]
[Nullable(0)]
public class RoleListComponent : UiPanelBase
{
	// Token: 0x17001B24 RID: 6948
	// (get) Token: 0x06014D13 RID: 85267 RVA: 0x00548274 File Offset: 0x00546474
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

	// Token: 0x06014D14 RID: 85268 RVA: 0x005482BF File Offset: 0x005464BF
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

	// Token: 0x06014D15 RID: 85269 RVA: 0x005482C7 File Offset: 0x005464C7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x06014D16 RID: 85270 RVA: 0x005482EC File Offset: 0x005464EC
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

	// Token: 0x06014D17 RID: 85271 RVA: 0x0054835F File Offset: 0x0054655F
	private RoleListItem InitRoleItem()
	{
		return new RoleListItem
		{
			ToggleCallBack = new Action<int>(this.OnRoleItemToggleCallBack),
			CanToggleExecuteChange = new Func<int, bool>(this.CanToggleExecuteChange)
		};
	}

	// Token: 0x06014D18 RID: 85272 RVA: 0x0054838A File Offset: 0x0054658A
	private bool CanToggleExecuteChange(int gridIndex)
	{
		return this.ScrollView.GetGenericLayout().GetSelectedGridIndex() != gridIndex && !UiCameraAnimationManager.Instance.IsPlayingAnimation();
	}

	// Token: 0x06014D19 RID: 85273 RVA: 0x005483B0 File Offset: 0x005465B0
	private void OnRoleItemToggleCallBack(int gridIndex)
	{
		this.ScrollView.GetGenericLayout().SelectGridProxy(gridIndex, false);
		this.RoleViewAgent.SetCurSelectRoleId(this.CurSelectDataId);
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		RoleController.Instance.OnSelectedRoleChange(this.CurSelectDataId, curSelectRoleData.GetRoleSkinId());
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemChangeRole, this.CurSelectDataId);
	}

	// Token: 0x06014D1A RID: 85274 RVA: 0x00548418 File Offset: 0x00546618
	public void UnBindRedDot()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.RoleSystemRoleList);
	}

	// Token: 0x06014D1B RID: 85275 RVA: 0x00548425 File Offset: 0x00546625
	public void SetRoleSystemUiParams(IRoleSystemUiParams roleSystemUiParams)
	{
		this.RoleSystemUiParams = roleSystemUiParams;
	}

	// Token: 0x06014D1C RID: 85276 RVA: 0x00548430 File Offset: 0x00546630
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

	// Token: 0x06014D1D RID: 85277 RVA: 0x0054847C File Offset: 0x0054667C
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

	// Token: 0x04009CB3 RID: 40115
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<RoleListItem, RoleListItemData> ScrollView;

	// Token: 0x04009CB4 RID: 40116
	[Nullable(2)]
	protected RoleViewAgent RoleViewAgent;

	// Token: 0x04009CB5 RID: 40117
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<RoleListItemData> DataList;

	// Token: 0x04009CB6 RID: 40118
	[Nullable(2)]
	protected IRoleSystemUiParams RoleSystemUiParams;

	// Token: 0x02008E0F RID: 36367
	[NullableContext(0)]
	private enum ERoleListComponentDefine
	{
		// Token: 0x0402E17A RID: 188794
		ScrollViewWithScrollbar
	}
}

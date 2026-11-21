using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0D RID: 7437
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerVisionDetailView : UiViewBase
{
	// Token: 0x06012691 RID: 75409 RVA: 0x00570DB1 File Offset: 0x0056EFB1
	[NullableContext(1)]
	public RoleTowerVisionDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B78 RID: 7032
	// (get) Token: 0x06012692 RID: 75410 RVA: 0x00570DCC File Offset: 0x0056EFCC
	private new RoleTowerVisionDetailViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerVisionDetailViewParams;
		}
	}

	// Token: 0x06012693 RID: 75411 RVA: 0x00570DDC File Offset: 0x0056EFDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseMask))
		};
	}

	// Token: 0x06012694 RID: 75412 RVA: 0x00570E70 File Offset: 0x0056F070
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerVisionDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerVisionDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012695 RID: 75413 RVA: 0x00570EB3 File Offset: 0x0056F0B3
	protected override void OnBeforeShow()
	{
		RoleTowerVisionDetailViewParams openParam = this.OpenParam;
		this.CurVisionSlot = ((openParam != null) ? openParam.SelectSlot : 0);
		this.RefreshVision().Forget();
		this.RefreshTips();
	}

	// Token: 0x06012696 RID: 75414 RVA: 0x00570EE0 File Offset: 0x0056F0E0
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RoleTowerVisionDetailView.<OnBeforeShowAsyncImplementImplement>d__15 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RoleTowerVisionDetailView.<OnBeforeShowAsyncImplementImplement>d__15>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06012697 RID: 75415 RVA: 0x00570F24 File Offset: 0x0056F124
	private UniTask RefreshVision()
	{
		RoleTowerVisionDetailView.<RefreshVision>d__16 <RefreshVision>d__;
		<RefreshVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshVision>d__.<>4__this = this;
		<RefreshVision>d__.<>1__state = -1;
		<RefreshVision>d__.<>t__builder.Start<RoleTowerVisionDetailView.<RefreshVision>d__16>(ref <RefreshVision>d__);
		return <RefreshVision>d__.<>t__builder.Task;
	}

	// Token: 0x06012698 RID: 75416 RVA: 0x00570F68 File Offset: 0x0056F168
	private void SyncVisionSelection()
	{
		RoleTowerVisionHeadItem mainVisionItem = this.MainVisionItem;
		if (mainVisionItem != null)
		{
			mainVisionItem.SetChecked(this.IsItemSelected(this.MainVisionItem));
		}
		foreach (RoleTowerVisionHeadItem roleTowerVisionHeadItem in this.SubVisionItems)
		{
			roleTowerVisionHeadItem.SetChecked(this.IsItemSelected(roleTowerVisionHeadItem));
		}
	}

	// Token: 0x06012699 RID: 75417 RVA: 0x00570FE0 File Offset: 0x0056F1E0
	[NullableContext(1)]
	private bool IsItemSelected(RoleTowerVisionHeadItem item)
	{
		return item.GetCurrentData() != null && this.CurVisionSlot >= 0 && item.Slot == this.CurVisionSlot;
	}

	// Token: 0x0601269A RID: 75418 RVA: 0x00571004 File Offset: 0x0056F204
	private UniTask RefreshMainVision(RoleDataBase roleData, PhantomDataBase mainData)
	{
		RoleTowerVisionDetailView.<RefreshMainVision>d__19 <RefreshMainVision>d__;
		<RefreshMainVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMainVision>d__.<>4__this = this;
		<RefreshMainVision>d__.roleData = roleData;
		<RefreshMainVision>d__.mainData = mainData;
		<RefreshMainVision>d__.<>1__state = -1;
		<RefreshMainVision>d__.<>t__builder.Start<RoleTowerVisionDetailView.<RefreshMainVision>d__19>(ref <RefreshMainVision>d__);
		return <RefreshMainVision>d__.<>t__builder.Task;
	}

	// Token: 0x0601269B RID: 75419 RVA: 0x00571058 File Offset: 0x0056F258
	private UniTask RefreshSubVisions(RoleDataBase roleData, [TupleElementNames(new string[]
	{
		"Slot",
		"Data"
	})] [Nullable(new byte[]
	{
		1,
		0,
		1
	})] List<ValueTuple<int, PhantomDataBase>> subDatas)
	{
		RoleTowerVisionDetailView.<RefreshSubVisions>d__20 <RefreshSubVisions>d__;
		<RefreshSubVisions>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubVisions>d__.<>4__this = this;
		<RefreshSubVisions>d__.roleData = roleData;
		<RefreshSubVisions>d__.subDatas = subDatas;
		<RefreshSubVisions>d__.<>1__state = -1;
		<RefreshSubVisions>d__.<>t__builder.Start<RoleTowerVisionDetailView.<RefreshSubVisions>d__20>(ref <RefreshSubVisions>d__);
		return <RefreshSubVisions>d__.<>t__builder.Task;
	}

	// Token: 0x0601269C RID: 75420 RVA: 0x005710AC File Offset: 0x0056F2AC
	private void RefreshTips()
	{
		if (!this.DetailPanelReady || this.DetailPanel == null)
		{
			return;
		}
		if (this.IsCurRoleTrial())
		{
			this.DetailPanel.SetActive(false);
			return;
		}
		RoleTowerVisionDetailViewParams openParam = this.OpenParam;
		int roleId = (openParam != null) ? openParam.RoleId : 0;
		PhantomBattleData phantomBattleData = this.FindPhantomBySlot(roleId, this.CurVisionSlot);
		if (phantomBattleData == null)
		{
			this.DetailPanel.SetActive(false);
			return;
		}
		this.DetailPanel.SetActive(true);
		this.DetailPanel.Refresh(phantomBattleData, roleId);
	}

	// Token: 0x0601269D RID: 75421 RVA: 0x0057112C File Offset: 0x0056F32C
	private UniTask RefreshTipsAsync()
	{
		RoleTowerVisionDetailView.<RefreshTipsAsync>d__22 <RefreshTipsAsync>d__;
		<RefreshTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTipsAsync>d__.<>4__this = this;
		<RefreshTipsAsync>d__.<>1__state = -1;
		<RefreshTipsAsync>d__.<>t__builder.Start<RoleTowerVisionDetailView.<RefreshTipsAsync>d__22>(ref <RefreshTipsAsync>d__);
		return <RefreshTipsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601269E RID: 75422 RVA: 0x00571170 File Offset: 0x0056F370
	private bool IsCurRoleTrial()
	{
		RoleTowerModel instance = RoleTowerModel.Instance;
		RoleTowerVisionDetailViewParams openParam = this.OpenParam;
		RoleDataBase roleData = instance.GetRoleData((openParam != null) ? openParam.RoleId : 0);
		return roleData != null && roleData.IsTrialRole();
	}

	// Token: 0x0601269F RID: 75423 RVA: 0x005711A5 File Offset: 0x0056F3A5
	private PhantomBattleData FindPhantomBySlot(int roleId, int slot)
	{
		if (slot < 0)
		{
			return null;
		}
		RoleDataBase roleData = RoleTowerModel.Instance.GetRoleData(roleId);
		object obj;
		if (roleData == null)
		{
			obj = null;
		}
		else
		{
			RolePhantomData phantomData = roleData.GetPhantomData();
			obj = ((phantomData != null) ? phantomData.GetDataByIndex(slot) : null);
		}
		return obj as PhantomBattleData;
	}

	// Token: 0x060126A0 RID: 75424 RVA: 0x005711D8 File Offset: 0x0056F3D8
	private void OnClickVision(int slot)
	{
		if (this.IsCurRoleTrial())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerTrialRoleVisionLock", Array.Empty<object>());
			this.SyncVisionSelection();
			return;
		}
		bool flag = this.CurVisionSlot != slot;
		this.CurVisionSlot = slot;
		this.SyncVisionSelection();
		this.RefreshTips();
		if (flag)
		{
			base.PlaySequence("Switch", null, false);
		}
	}

	// Token: 0x060126A1 RID: 75425 RVA: 0x00571236 File Offset: 0x0056F436
	private void OnClickCloseMask()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400A063 RID: 41059
	[Nullable(1)]
	private const string MainVisionResourceId = "UiItem_VisionITogItem";

	// Token: 0x0400A064 RID: 41060
	[Nullable(1)]
	private const string SubVisionResourceId = "UiItem_VisionITogItemS";

	// Token: 0x0400A065 RID: 41061
	private RoleTowerVisionHeadItem MainVisionItem;

	// Token: 0x0400A066 RID: 41062
	[Nullable(1)]
	private readonly List<RoleTowerVisionHeadItem> SubVisionItems = new List<RoleTowerVisionHeadItem>();

	// Token: 0x0400A067 RID: 41063
	private bool VisionRefreshing;

	// Token: 0x0400A068 RID: 41064
	private int CurVisionSlot = -1;

	// Token: 0x0400A069 RID: 41065
	private RoleTowerVisionDetailInfoPanel DetailPanel;

	// Token: 0x0400A06A RID: 41066
	private bool DetailPanelReady;

	// Token: 0x02008040 RID: 32832
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297F2 RID: 169970
		public const int BtnCloseMask = 0;

		// Token: 0x040297F3 RID: 169971
		public const int PnlTopVision = 1;

		// Token: 0x040297F4 RID: 169972
		public const int PnlVisionList = 2;

		// Token: 0x040297F5 RID: 169973
		public const int UiItemItemTips = 3;
	}
}

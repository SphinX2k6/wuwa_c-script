using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002433 RID: 9267
public class PhantomBattleFettersObtainView : UiViewBase
{
	// Token: 0x0601295C RID: 76124 RVA: 0x00495658 File Offset: 0x00493858
	[NullableContext(1)]
	public PhantomBattleFettersObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601295D RID: 76125 RVA: 0x00495664 File Offset: 0x00493864
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClose))
		};
	}

	// Token: 0x0601295E RID: 76126 RVA: 0x004956CC File Offset: 0x004938CC
	[NullableContext(1)]
	private ILayoutItem<PhantomFettersObtainItem> InitFettersItem(object data, UUIItem item, int index)
	{
		PhantomFettersObtainItem phantomFettersObtainItem = new PhantomFettersObtainItem(item);
		phantomFettersObtainItem.Init();
		phantomFettersObtainItem.Update((IFettersObtainData)data);
		phantomFettersObtainItem.BindOnItemButtonClickedCallback(new Action<int>(this.OnOpenTrackView));
		return new LayoutItem<PhantomFettersObtainItem>
		{
			Key = index,
			Value = phantomFettersObtainItem
		};
	}

	// Token: 0x0601295F RID: 76127 RVA: 0x0049571C File Offset: 0x0049391C
	protected override void OnStart()
	{
		PhantomFetter fatterData = (PhantomFetter)this.OpenParam;
		this.FettersObtainScroll = new GenericScrollView<PhantomFettersObtainItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PhantomFettersObtainItem>(this.InitFettersItem), null);
		this.ShowFettersObtainView(fatterData);
	}

	// Token: 0x06012960 RID: 76128 RVA: 0x0049575B File Offset: 0x0049395B
	public void ShowFettersObtainView(PhantomFetter fatterData)
	{
		this.SetActive(true);
		this.FetterData = new PhantomFetter?(fatterData);
	}

	// Token: 0x06012961 RID: 76129 RVA: 0x00495770 File Offset: 0x00493970
	protected override void OnBeforeDestroy()
	{
		this.FettersObtainScroll.ClearChildren();
	}

	// Token: 0x06012962 RID: 76130 RVA: 0x00495780 File Offset: 0x00493980
	private void OnOpenTrackView(int id)
	{
		CalabashDevelopReward? calabashDevelopReward;
		AdventureGuideController.Instance.JumpToTargetView(EUiTabViewName.MonsterDetectView, (CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(id) != null) ? new int?(calabashDevelopReward.GetValueOrDefault().MonsterProbeId) : null, null);
	}

	// Token: 0x06012963 RID: 76131 RVA: 0x004957D4 File Offset: 0x004939D4
	private void OnClose()
	{
		PhantomBattleModel.Instance.CurrentSelectedFetter = new PhantomFetter?(this.FetterData.Value);
		base.CloseMe(null);
		EventSystem.Instance.Emit(EEventName.VisionFilterMonster);
		int? battleTeamFirstRoleId = RoleModel.Instance.GetBattleTeamFirstRoleId();
		if (battleTeamFirstRoleId == null)
		{
			return;
		}
		if (!UiManager.Instance.IsViewShow(EUiViewName.VisionEquipmentView))
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.PhantomBattleFettersView))
			{
				PhantomUtil.CloseAndOpenVisionEquipmentView(EUiViewName.PhantomBattleFettersView, battleTeamFirstRoleId.Value, -1);
				return;
			}
			PhantomUtil.OpenVisionEquipmentView(battleTeamFirstRoleId.Value, -1, null);
		}
	}

	// Token: 0x04008C07 RID: 35847
	private PhantomFetter? FetterData;

	// Token: 0x04008C08 RID: 35848
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<PhantomFettersObtainItem> FettersObtainScroll;

	// Token: 0x020089BA RID: 35258
	private enum EFettersObtainDefine
	{
		// Token: 0x0402CC03 RID: 183299
		ObtainScroll,
		// Token: 0x0402CC04 RID: 183300
		ConfirmButton
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001918 RID: 6424
public class PhantomBattleFettersObtainView : UiViewBase
{
	// Token: 0x0600FE12 RID: 65042 RVA: 0x004A2C24 File Offset: 0x004A0E24
	[NullableContext(1)]
	public PhantomBattleFettersObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE13 RID: 65043 RVA: 0x004A2C30 File Offset: 0x004A0E30
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

	// Token: 0x0600FE14 RID: 65044 RVA: 0x004A2C98 File Offset: 0x004A0E98
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

	// Token: 0x0600FE15 RID: 65045 RVA: 0x004A2CE8 File Offset: 0x004A0EE8
	protected override void OnStart()
	{
		PhantomFetter fatterData = (PhantomFetter)this.OpenParam;
		this.FettersObtainScroll = new GenericScrollView<PhantomFettersObtainItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PhantomFettersObtainItem>(this.InitFettersItem), null);
		this.ShowFettersObtainView(fatterData);
	}

	// Token: 0x0600FE16 RID: 65046 RVA: 0x004A2D27 File Offset: 0x004A0F27
	public void ShowFettersObtainView(PhantomFetter fatterData)
	{
		this.SetActive(true);
		this.FetterData = new PhantomFetter?(fatterData);
	}

	// Token: 0x0600FE17 RID: 65047 RVA: 0x004A2D3C File Offset: 0x004A0F3C
	protected override void OnBeforeDestroy()
	{
		this.FettersObtainScroll.ClearChildren();
	}

	// Token: 0x0600FE18 RID: 65048 RVA: 0x004A2D4C File Offset: 0x004A0F4C
	private void OnOpenTrackView(int id)
	{
		CalabashDevelopReward? calabashDevelopReward;
		AdventureGuideController.Instance.JumpToTargetView(EUiTabViewName.MonsterDetectView, (CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(id) != null) ? new int?(calabashDevelopReward.GetValueOrDefault().MonsterProbeId) : null, null);
	}

	// Token: 0x0600FE19 RID: 65049 RVA: 0x004A2DA0 File Offset: 0x004A0FA0
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

	// Token: 0x04008D4E RID: 36174
	private PhantomFetter? FetterData;

	// Token: 0x04008D4F RID: 36175
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<PhantomFettersObtainItem> FettersObtainScroll;

	// Token: 0x02007B41 RID: 31553
	private enum EFettersObtainDefine
	{
		// Token: 0x04027F19 RID: 163609
		ObtainScroll,
		// Token: 0x04027F1A RID: 163610
		ConfirmButton
	}
}

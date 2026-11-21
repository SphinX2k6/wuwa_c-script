using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AE4 RID: 2788
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerRecordPopupView : UiViewBase
{
	// Token: 0x0600738F RID: 29583 RVA: 0x0023B21B File Offset: 0x0023941B
	[NullableContext(1)]
	public WheelTowerRecordPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007390 RID: 29584 RVA: 0x0023B224 File Offset: 0x00239424
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCancel));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007391 RID: 29585 RVA: 0x0023B3B4 File Offset: 0x002395B4
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecordPopupView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecordPopupView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007392 RID: 29586 RVA: 0x0023B3F8 File Offset: 0x002395F8
	protected override void OnStart()
	{
		IWheelTowerRecordPopupViewData wheelTowerRecordPopupViewData = this.OpenParam as IWheelTowerRecordPopupViewData;
		if (wheelTowerRecordPopupViewData == null)
		{
			return;
		}
		this.ConfirmCallback = wheelTowerRecordPopupViewData.OnClickConfirm;
		this.CancelCallback = wheelTowerRecordPopupViewData.OnClickCancel;
		string id = wheelTowerRecordPopupViewData.IsEndless ? "WheelBattleMode_Endless" : "WheelBattleMode_Normal";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelTowerRecordPopup_Title", new <>z__ReadOnlyArray<object>(new object[]
		{
			ConfigMultiTextLang.GetLocalTextNew(id, null),
			wheelTowerRecordPopupViewData.Round.ToString()
		}));
		this.RefreshScoreLayout(wheelTowerRecordPopupViewData);
		WheelTowerRecordPopupView.TeamItem oldTeamItem = this.OldTeamItem;
		if (oldTeamItem != null)
		{
			oldTeamItem.Refresh(wheelTowerRecordPopupViewData.BeforeData.TeamRoleIdList, wheelTowerRecordPopupViewData.BeforeData.BuffId);
		}
		WheelTowerRecordPopupView.TeamItem newTeamItem = this.NewTeamItem;
		if (newTeamItem != null)
		{
			newTeamItem.Refresh(wheelTowerRecordPopupViewData.AfterData.TeamRoleIdList, wheelTowerRecordPopupViewData.AfterData.BuffId);
		}
		WheelTowerModel.Instance.BlockEndlessUnlockTips = false;
	}

	// Token: 0x06007393 RID: 29587 RVA: 0x0023B4E0 File Offset: 0x002396E0
	[NullableContext(1)]
	private void RefreshScoreLayout(IWheelTowerRecordPopupViewData data)
	{
		List<WheelTowerRecordPopupScoreItemData> data2 = new List<WheelTowerRecordPopupScoreItemData>
		{
			new WheelTowerRecordPopupScoreItemData
			{
				Title = "WheelTowerRecordPopupScore",
				ScoreOld = data.BeforeData.RoundScore,
				ScoreNew = data.AfterData.RoundScore,
				NeedScoreIcon = false
			},
			new WheelTowerRecordPopupScoreItemData
			{
				Title = "WheelTowerRecordPopupTotalScore",
				ScoreOld = data.BeforeData.TotalScore,
				ScoreNew = data.AfterData.TotalScore,
				NeedScoreIcon = true
			},
			new WheelTowerRecordPopupScoreItemData
			{
				Title = "WheelTowerRecordPopupScoreRecord",
				ScoreOld = data.BeforeData.ScoreRecord,
				ScoreNew = data.AfterData.ScoreRecord,
				NeedScoreIcon = true
			}
		};
		GenericLayout<WheelTowerRecordPopupView.ScoreItem, WheelTowerRecordPopupScoreItemData> scoreLayout = this.ScoreLayout;
		if (scoreLayout == null)
		{
			return;
		}
		scoreLayout.RefreshByData(data2, null, false);
	}

	// Token: 0x06007394 RID: 29588 RVA: 0x0023B5C3 File Offset: 0x002397C3
	private void OnClickCancel()
	{
		Action cancelCallback = this.CancelCallback;
		if (cancelCallback != null)
		{
			cancelCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x06007395 RID: 29589 RVA: 0x0023B5DD File Offset: 0x002397DD
	private void OnClickConfirm()
	{
		Action confirmCallback = this.ConfirmCallback;
		if (confirmCallback != null)
		{
			confirmCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x040048FE RID: 18686
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecordPopupView.ScoreItem, WheelTowerRecordPopupScoreItemData> ScoreLayout;

	// Token: 0x040048FF RID: 18687
	private WheelTowerRecordPopupView.TeamItem OldTeamItem;

	// Token: 0x04004900 RID: 18688
	private WheelTowerRecordPopupView.TeamItem NewTeamItem;

	// Token: 0x04004901 RID: 18689
	private Action ConfirmCallback;

	// Token: 0x04004902 RID: 18690
	private Action CancelCallback;

	// Token: 0x02006D7B RID: 28027
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class ScoreItem : GridProxyAbstract<WheelTowerRecordPopupScoreItemData>
	{
		// Token: 0x0603FC18 RID: 261144 RVA: 0x012A91B4 File Offset: 0x012A73B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FC19 RID: 261145 RVA: 0x012A9280 File Offset: 0x012A7480
		public override void Refresh(WheelTowerRecordPopupScoreItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(data.Title);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(data.ScoreOld.ToString(), true);
			}
			UUIText text3 = base.GetText(2);
			if (text3 != null)
			{
				text3.SetText(data.ScoreNew.ToString(), true);
			}
			if (!data.NeedScoreIcon)
			{
				return;
			}
			WheelTowerScoreItem wheelTowerScoreItem = new WheelTowerScoreItem(this, base.GetItem(3));
			EScoreLevel totalScoreLevel = WheelTowerModel.Instance.GetTotalScoreLevel(data.ScoreNew, null, null);
			wheelTowerScoreItem.Refresh(totalScoreLevel);
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(totalScoreLevel > EScoreLevel.A);
		}
	}

	// Token: 0x02006D7C RID: 28028
	[NullableContext(0)]
	private class TeamItem : UiPanelBase
	{
		// Token: 0x0603FC1B RID: 261147 RVA: 0x012A9344 File Offset: 0x012A7544
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FC1C RID: 261148 RVA: 0x012A93CE File Offset: 0x012A75CE
		protected override void OnStart()
		{
			this.RoleLayout = new GenericLayout<WheelTowerRecordPopupView.RoleGridItem, int>(base.GetHorizontalLayout(0), () => new WheelTowerRecordPopupView.RoleGridItem(), null, false, true);
		}

		// Token: 0x0603FC1D RID: 261149 RVA: 0x012A9404 File Offset: 0x012A7604
		[NullableContext(1)]
		public void Refresh(List<int> roleIdList, int buffId)
		{
			GenericLayout<WheelTowerRecordPopupView.RoleGridItem, int> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.RefreshByData(roleIdList, null, false);
			}
			NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(buffId);
			if (buffConfigById != null)
			{
				base.SetTextureShowUntilLoaded(buffConfigById.Value.Icon, base.GetTexture(2), null);
			}
		}

		// Token: 0x04023EA3 RID: 147107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<WheelTowerRecordPopupView.RoleGridItem, int> RoleLayout;
	}

	// Token: 0x02006D7D RID: 28029
	[NullableContext(0)]
	private class RoleGridItem : LoopScrollSmallItemGrid<int>
	{
		// Token: 0x0603FC1F RID: 261151 RVA: 0x012A945F File Offset: 0x012A765F
		protected override void OnStart()
		{
			base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		}

		// Token: 0x0603FC20 RID: 261152 RVA: 0x012A9488 File Offset: 0x012A7688
		protected override void OnRefresh(int roleId, bool isSelected, int gridIndex)
		{
			int num = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
			if (roleDataById == null)
			{
				return;
			}
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = roleDataById,
				ItemConfigId = new int?(num),
				SkinId = new int?(roleDataById.GetRoleConfig().SkinId),
				BottomText = roleDataById.GetName(null),
				ElementId = new int?(roleDataById.GetRoleConfig().ElementId)
			};
			base.SetUseFixedAsync(true);
			base.Apply<CharacterSmallItemGrid>(parameters);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CE0 RID: 7392
public class RoleTowerPauseView : UiViewBase
{
	// Token: 0x060124B8 RID: 74936 RVA: 0x0056538E File Offset: 0x0056358E
	[NullableContext(1)]
	public RoleTowerPauseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060124B9 RID: 74937 RVA: 0x00565398 File Offset: 0x00563598
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBuffLook)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickLook)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickRetry)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickSaveExit)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickSettleExit)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickSaveLeave))
		};
	}

	// Token: 0x060124BA RID: 74938 RVA: 0x005655A0 File Offset: 0x005637A0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerPauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerPauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060124BB RID: 74939 RVA: 0x005655E4 File Offset: 0x005637E4
	protected override void OnStart()
	{
		this.TeamLayout = new GenericLayout<RoleTowerPauseAvatarItem, int>(base.GetHorizontalLayout(3), () => new RoleTowerPauseAvatarItem(), null, false, true);
		this.StarLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(base.GetHorizontalLayout(6), () => new RoleTowerPauseStarItem(), null, false, true);
	}

	// Token: 0x060124BC RID: 74940 RVA: 0x0056565C File Offset: 0x0056385C
	protected override void OnBeforeShow()
	{
		this.RefreshOverview();
		this.RefreshTeam();
		this.RefreshStar();
		RoleTowerPauseTokenItem tokenItem = this.TokenItem;
		if (tokenItem != null)
		{
			tokenItem.Refresh();
		}
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(RoleTowerModel.Instance.GetEquipTokenId() > 0);
	}

	// Token: 0x060124BD RID: 74941 RVA: 0x005656B7 File Offset: 0x005638B7
	protected override void OnBeforeDestroy()
	{
		RoleTowerPauseTokenItem tokenItem = this.TokenItem;
		if (tokenItem != null)
		{
			tokenItem.Destroy(null);
		}
		this.TokenItem = null;
	}

	// Token: 0x060124BE RID: 74942 RVA: 0x005656D4 File Offset: 0x005638D4
	private void RefreshOverview()
	{
		RoleTowerModel.Instance.GetCurBattleFloorId();
		int currentFloorIndex = RoleTowerModel.Instance.GetCurrentFloorIndex();
		int levelTotalFloorCount = RoleTowerModel.Instance.GetLevelTotalFloorCount(RoleTowerModel.Instance.CurSelectLevel);
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (text != null)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentFloorIndex);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(levelTotalFloorCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(RoleTowerTimeUtil.Format(RoleTowerModel.Instance.GetDungeonRemainTime()), true);
		}
		UUIText text3 = base.GetText(8);
		if (text3 == null)
		{
			return;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Lv.");
		defaultInterpolatedStringHandler.AppendFormatted<int>(RoleTowerModel.Instance.GetCurEchoLevel());
		text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060124BF RID: 74943 RVA: 0x005657AC File Offset: 0x005639AC
	private void RefreshTeam()
	{
		List<int> list = new List<int>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				list.Add(slotRoleId);
			}
		}
		GenericLayout<RoleTowerPauseAvatarItem, int> teamLayout = this.TeamLayout;
		if (teamLayout == null)
		{
			return;
		}
		teamLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060124C0 RID: 74944 RVA: 0x00565810 File Offset: 0x00563A10
	private void RefreshStar()
	{
		int curTeamStar = RoleTowerModel.Instance.GetCurTeamStar();
		int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Main);
		int num = 0;
		if (slotRoleId > 0)
		{
			num = RoleTowerModel.Instance.GetStarCfgListByRole(slotRoleId).Count;
		}
		List<bool> list = new List<bool>();
		for (int i = 0; i < num; i++)
		{
			list.Add(i < curTeamStar);
		}
		GenericLayout<RoleTowerPauseStarItem, bool> starLayout = this.StarLayout;
		if (starLayout == null)
		{
			return;
		}
		starLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060124C1 RID: 74945 RVA: 0x00565880 File Offset: 0x00563A80
	private void OnClickBuffLook()
	{
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		if (equipTokenId <= 0)
		{
			return;
		}
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(equipTokenId);
		if (tokenCfg == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(tokenCfg.Value.ItemId, true, null, true);
	}

	// Token: 0x060124C2 RID: 74946 RVA: 0x005658CF File Offset: 0x00563ACF
	private void OnClickLook()
	{
		RoleTowerModel.Instance.OpenStarEchoView(ERoleTowerStarEchoTab.Star, false);
	}

	// Token: 0x060124C3 RID: 74947 RVA: 0x005658DD File Offset: 0x00563ADD
	private void OnClickRetry()
	{
		RoleTowerModel.Instance.ConfirmStageRetry(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x060124C4 RID: 74948 RVA: 0x005658F5 File Offset: 0x00563AF5
	private void OnClickSaveExit()
	{
		RoleTowerModel.Instance.OpenCheckPointView();
		base.CloseMe(null);
	}

	// Token: 0x060124C5 RID: 74949 RVA: 0x00565908 File Offset: 0x00563B08
	private void OnClickSettleExit()
	{
		RoleTowerModel.Instance.ConfirmSettleExit(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x060124C6 RID: 74950 RVA: 0x00565920 File Offset: 0x00563B20
	private void OnClickSaveLeave()
	{
		RoleTowerModel.Instance.OpenSaveExitConfirmView(false);
	}

	// Token: 0x04009FA6 RID: 40870
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseAvatarItem, int> TeamLayout;

	// Token: 0x04009FA7 RID: 40871
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarLayout;

	// Token: 0x04009FA8 RID: 40872
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04009FA9 RID: 40873
	[Nullable(2)]
	private RoleTowerPauseTokenItem TokenItem;

	// Token: 0x02007FDC RID: 32732
	private static class EChildType
	{
		// Token: 0x040295D3 RID: 169427
		public const int TxtLevelValue = 0;

		// Token: 0x040295D4 RID: 169428
		public const int TxtRemainTime = 1;

		// Token: 0x040295D5 RID: 169429
		public const int BtnBuffLook = 2;

		// Token: 0x040295D6 RID: 169430
		public const int PnlTeamLayout = 3;

		// Token: 0x040295D7 RID: 169431
		public const int UiItemRoleAvatarBtn = 4;

		// Token: 0x040295D8 RID: 169432
		public const int BtnLook = 5;

		// Token: 0x040295D9 RID: 169433
		public const int PnlStar = 6;

		// Token: 0x040295DA RID: 169434
		public const int UiItemStarNow = 7;

		// Token: 0x040295DB RID: 169435
		public const int TxtVisionLevel = 8;

		// Token: 0x040295DC RID: 169436
		public const int UiItemRestar = 9;

		// Token: 0x040295DD RID: 169437
		public const int UiItemSaveCurr = 10;

		// Token: 0x040295DE RID: 169438
		public const int UiItemExit = 11;

		// Token: 0x040295DF RID: 169439
		public const int UiItemCaption = 12;

		// Token: 0x040295E0 RID: 169440
		public const int UiItemToken = 13;

		// Token: 0x040295E1 RID: 169441
		public const int BtnSaveLeave = 14;
	}
}

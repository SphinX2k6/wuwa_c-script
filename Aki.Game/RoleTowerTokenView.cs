using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0B RID: 7435
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerTokenView : UiViewBase
{
	// Token: 0x0601266F RID: 75375 RVA: 0x00570270 File Offset: 0x0056E470
	public RoleTowerTokenView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B76 RID: 7030
	// (get) Token: 0x06012670 RID: 75376 RVA: 0x00570284 File Offset: 0x0056E484
	[Nullable(2)]
	private new RoleTowerTokenViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as RoleTowerTokenViewParams;
		}
	}

	// Token: 0x17001B77 RID: 7031
	// (get) Token: 0x06012671 RID: 75377 RVA: 0x00570291 File Offset: 0x0056E491
	private ERoleTowerTokenViewMode Mode
	{
		get
		{
			RoleTowerTokenViewParams openParam = this.OpenParam;
			if (openParam == null)
			{
				return ERoleTowerTokenViewMode.Codex;
			}
			return openParam.Mode;
		}
	}

	// Token: 0x06012672 RID: 75378 RVA: 0x005702A4 File Offset: 0x0056E4A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012673 RID: 75379 RVA: 0x0057032C File Offset: 0x0056E52C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerTokenView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerTokenView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012674 RID: 75380 RVA: 0x00570370 File Offset: 0x0056E570
	protected override void OnBeforeDestroy()
	{
		if (this.Mode != ERoleTowerTokenViewMode.Codex)
		{
			RoleTowerModel.Instance.ClearAllTokenNew();
		}
		if (this.RedDotDelayHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RedDotDelayHandle);
			this.RedDotDelayHandle = null;
		}
		GenericScrollViewNew<RoleTowerTokenZoneItem, RoleTowerTokenZoneItemData> scrollView = this.ScrollView;
		if (scrollView != null)
		{
			scrollView.UnBindScrollValueChange();
		}
		ItemTipsWithButtonComponent tipsComponent = this.TipsComponent;
		if (tipsComponent != null)
		{
			tipsComponent.Destroy(null);
		}
		this.TipsComponent = null;
		this.Caption = null;
	}

	// Token: 0x06012675 RID: 75381 RVA: 0x005703E1 File Offset: 0x0056E5E1
	private void OnScrollValueChange(FVector2D _)
	{
		this.RefreshNextPageRedDot();
	}

	// Token: 0x06012676 RID: 75382 RVA: 0x005703EC File Offset: 0x0056E5EC
	private void RefreshNextPageRedDot()
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.HasNewTokenBelow());
	}

	// Token: 0x06012677 RID: 75383 RVA: 0x00570414 File Offset: 0x0056E614
	private bool HasNewTokenBelow()
	{
		if (this.ScrollView == null)
		{
			return false;
		}
		for (int i = 0; i < this.ZoneList.Count; i++)
		{
			List<RoleTowerTokenItemData> tokenList = this.ZoneList[i].TokenList;
			for (int j = 0; j < tokenList.Count; j++)
			{
				if (this.IsNewTagVisible(tokenList[j]))
				{
					RoleTowerTokenZoneItem scrollItemByIndex = this.ScrollView.GetScrollItemByIndex(i);
					UUIItem uuiitem = (scrollItemByIndex != null) ? scrollItemByIndex.GetTokenUiItemByIndex(j) : null;
					if (uuiitem == null || this.ScrollView.IsItemInViewport(uuiitem, 0.1f) == EOutOfBoundsType.OutOfEnd)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06012678 RID: 75384 RVA: 0x005704A7 File Offset: 0x0056E6A7
	private bool IsNewTagVisible(RoleTowerTokenItemData data)
	{
		if (data.Mode != ERoleTowerTokenViewMode.Codex && !data.IsRecommend)
		{
			RoleTowerTokenData tokenState = RoleTowerModel.Instance.GetTokenState(data.TokenId);
			return tokenState != null && tokenState.IsNew;
		}
		return false;
	}

	// Token: 0x06012679 RID: 75385 RVA: 0x005704D8 File Offset: 0x0056E6D8
	private void BuildZoneList()
	{
		bool isCodex = this.Mode == ERoleTowerTokenViewMode.Codex;
		HashSet<int> recommendTokenSet = this.GetRecommendTokenSet();
		this.ZoneList = new List<RoleTowerTokenZoneItemData>();
		Comparison<RoleTowerTokenItemData> <>9__0;
		foreach (RoleTowerTokenZone roleTowerTokenZone in RoleTowerModel.Instance.GetTokenZoneCfgList())
		{
			IEnumerable<RoleTowerToken> tokenCfgListByZone = RoleTowerModel.Instance.GetTokenCfgListByZone(roleTowerTokenZone.Id);
			List<RoleTowerTokenItemData> list = new List<RoleTowerTokenItemData>();
			foreach (RoleTowerToken roleTowerToken in tokenCfgListByZone)
			{
				list.Add(new RoleTowerTokenItemData
				{
					TokenId = roleTowerToken.Id,
					Mode = this.Mode,
					IsRecommend = (!isCodex && recommendTokenSet.Contains(roleTowerToken.Id))
				});
			}
			List<RoleTowerTokenItemData> list2 = list;
			Comparison<RoleTowerTokenItemData> comparison;
			if ((comparison = <>9__0) == null)
			{
				comparison = (<>9__0 = delegate(RoleTowerTokenItemData a, RoleTowerTokenItemData b)
				{
					if (!isCodex)
					{
						int tokenCount = RoleTowerModel.Instance.GetTokenCount(a.TokenId);
						int tokenCount2 = RoleTowerModel.Instance.GetTokenCount(b.TokenId);
						int num = (tokenCount <= 0) ? 1 : 0;
						int num2 = (tokenCount2 <= 0) ? 1 : 0;
						if (num != num2)
						{
							return num - num2;
						}
					}
					return a.TokenId - b.TokenId;
				});
			}
			list2.Sort(comparison);
			if (list.Count > 0)
			{
				this.ZoneList.Add(new RoleTowerTokenZoneItemData
				{
					ZoneId = roleTowerTokenZone.Id,
					Title = roleTowerTokenZone.Title,
					TokenList = list
				});
			}
		}
	}

	// Token: 0x0601267A RID: 75386 RVA: 0x0057065C File Offset: 0x0056E85C
	private HashSet<int> GetRecommendTokenSet()
	{
		HashSet<int> hashSet = new HashSet<int>();
		if (this.Mode == ERoleTowerTokenViewMode.Codex)
		{
			return hashSet;
		}
		RoleTowerModel instance = RoleTowerModel.Instance;
		RoleTowerTokenViewParams openParam = this.OpenParam;
		RoleTowerStage? stageCfgByFloor = instance.GetStageCfgByFloor((openParam != null) ? openParam.FloorId : 0);
		if (stageCfgByFloor == null)
		{
			return hashSet;
		}
		for (int i = 0; i < stageCfgByFloor.Value.RecommendTokenIdsLength; i++)
		{
			hashSet.Add(stageCfgByFloor.Value.RecommendTokenIds(i));
		}
		return hashSet;
	}

	// Token: 0x0601267B RID: 75387 RVA: 0x005706D4 File Offset: 0x0056E8D4
	[NullableContext(2)]
	private RoleTowerTokenItemData FindDefaultSelect(int jumpId)
	{
		RoleTowerTokenItemData roleTowerTokenItemData = null;
		foreach (RoleTowerTokenZoneItemData roleTowerTokenZoneItemData in this.ZoneList)
		{
			foreach (RoleTowerTokenItemData roleTowerTokenItemData2 in roleTowerTokenZoneItemData.TokenList)
			{
				if (roleTowerTokenItemData == null)
				{
					roleTowerTokenItemData = roleTowerTokenItemData2;
				}
				if (jumpId > 0 && roleTowerTokenItemData2.TokenId == jumpId)
				{
					return roleTowerTokenItemData2;
				}
			}
		}
		return roleTowerTokenItemData;
	}

	// Token: 0x0601267C RID: 75388 RVA: 0x00570778 File Offset: 0x0056E978
	private RoleTowerTokenZoneItem CreateZoneItem()
	{
		return new RoleTowerTokenZoneItem
		{
			OnItemClickCallback = new Action<RoleTowerTokenItemData>(this.OnItemClick)
		};
	}

	// Token: 0x0601267D RID: 75389 RVA: 0x00570794 File Offset: 0x0056E994
	private void OnItemClick(RoleTowerTokenItemData data)
	{
		bool flag = this.SelectedData == null;
		bool flag2 = !flag && this.SelectedData != data;
		foreach (RoleTowerTokenZoneItemData roleTowerTokenZoneItemData in this.ZoneList)
		{
			foreach (RoleTowerTokenItemData roleTowerTokenItemData in roleTowerTokenZoneItemData.TokenList)
			{
				roleTowerTokenItemData.IsSelected = (roleTowerTokenItemData == data);
			}
		}
		this.SelectedData = data;
		this.RefreshTips(data);
		this.RefreshEquipButton(data);
		RoleTowerTokenData tokenState = RoleTowerModel.Instance.GetTokenState(data.TokenId);
		if (!flag && tokenState != null && tokenState.IsNew)
		{
			tokenState.IsNew = false;
			this.RefreshNextPageRedDot();
		}
		GenericScrollViewNew<RoleTowerTokenZoneItem, RoleTowerTokenZoneItemData> scrollView = this.ScrollView;
		List<RoleTowerTokenZoneItem> list = (scrollView != null) ? scrollView.GetScrollItemList() : null;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i].UpdateTokenInfo();
				list[i].UpdateTokenSelected();
			}
		}
		if (flag2)
		{
			base.PlaySequence("Switch", null, false);
		}
	}

	// Token: 0x0601267E RID: 75390 RVA: 0x005708D8 File Offset: 0x0056EAD8
	private void RefreshTips(RoleTowerTokenItemData data)
	{
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(data.TokenId);
		if (tokenCfg == null)
		{
			return;
		}
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(tokenCfg.Value.ItemId, null, null);
		if (tipsDataById == null)
		{
			return;
		}
		bool flag = this.Mode == ERoleTowerTokenViewMode.Codex;
		int tokenId = data.TokenId;
		TipsMaterialData tipsMaterialData = tipsDataById as TipsMaterialData;
		if (tipsMaterialData != null)
		{
			tipsMaterialData.Num = RoleTowerModel.Instance.GetTokenCount(tokenId);
		}
		this.TipsComponent.RefreshTips(tipsDataById);
		this.TipsComponent.SetTipsNumShow(!flag);
		this.TipsComponent.SetVisible(true);
	}

	// Token: 0x0601267F RID: 75391 RVA: 0x0057097C File Offset: 0x0056EB7C
	private void RefreshEquipButton(RoleTowerTokenItemData data)
	{
		this.TipsComponent.ClearButtonList();
		this.TipsComponent.SetLockStateVisible(false);
		if (this.Mode == ERoleTowerTokenViewMode.Codex)
		{
			return;
		}
		if (RoleTowerModel.Instance.GetEquipTokenId() > 0 && data.TokenId == RoleTowerModel.Instance.GetEquipTokenId())
		{
			this.TipsComponent.RefreshButton(this.BuildUnequipButtons());
			return;
		}
		if (RoleTowerModel.Instance.IsOutOfBattleNoSave())
		{
			if (!RoleTowerModel.Instance.CanEquipToken(data.TokenId))
			{
				this.TipsComponent.SetLockStateVisible(true);
				this.TipsComponent.SetLockStateData(new ItemTipsLockStateData
				{
					TipsTextKey = "RoleTowerTokenCannotEquip_Text"
				});
				return;
			}
			this.TipsComponent.RefreshButton(this.BuildEquipButtons());
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoleTowerTokenViewConfirmBtn");
			return;
		}
		else
		{
			if (RoleTowerModel.Instance.GetTokenCount(data.TokenId) <= 0)
			{
				this.TipsComponent.SetLockStateVisible(true);
				this.TipsComponent.SetLockStateData(new ItemTipsLockStateData
				{
					TipsTextKey = "RoleTowerTokenNotEnough_Text"
				});
				return;
			}
			this.TipsComponent.RefreshButton(this.BuildEquipButtons());
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoleTowerTokenViewConfirmBtn");
			return;
		}
	}

	// Token: 0x06012680 RID: 75392 RVA: 0x00570AA9 File Offset: 0x0056ECA9
	private List<IButtonInfo> BuildEquipButtons()
	{
		return new List<IButtonInfo>
		{
			new ButtonInfo
			{
				Function = new Action<int>(this.OnClickEquip),
				Text = "RoleTowerEquipToken_Text",
				Index = 0
			}
		};
	}

	// Token: 0x06012681 RID: 75393 RVA: 0x00570ADF File Offset: 0x0056ECDF
	private void OnClickEquip(int _)
	{
		if (this.SelectedData == null)
		{
			return;
		}
		if (!RoleTowerModel.Instance.CanEquipToken(this.SelectedData.TokenId))
		{
			return;
		}
		RoleTowerModel.Instance.SetEquipToken(this.SelectedData.TokenId);
		base.CloseMe(null);
	}

	// Token: 0x06012682 RID: 75394 RVA: 0x00570B1E File Offset: 0x0056ED1E
	private List<IButtonInfo> BuildUnequipButtons()
	{
		return new List<IButtonInfo>
		{
			new ButtonInfo
			{
				Function = new Action<int>(this.OnClickUnequip),
				Text = "RoleTowerUnequipToken_Text",
				Index = 0
			}
		};
	}

	// Token: 0x06012683 RID: 75395 RVA: 0x00570B54 File Offset: 0x0056ED54
	private void OnClickUnequip(int _)
	{
		RoleTowerModel.Instance.SetEquipToken(0);
		base.CloseMe(null);
	}

	// Token: 0x0400A055 RID: 41045
	private const int EquipBtnIndex = 0;

	// Token: 0x0400A056 RID: 41046
	private const float NextPageRedDotTolerance = 0.1f;

	// Token: 0x0400A057 RID: 41047
	private const int NextPageRedDotDelayMs = 100;

	// Token: 0x0400A058 RID: 41048
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400A059 RID: 41049
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerTokenZoneItem, RoleTowerTokenZoneItemData> ScrollView;

	// Token: 0x0400A05A RID: 41050
	[Nullable(2)]
	private ItemTipsWithButtonComponent TipsComponent;

	// Token: 0x0400A05B RID: 41051
	[Nullable(2)]
	private RoleTowerTokenItemData SelectedData;

	// Token: 0x0400A05C RID: 41052
	private List<RoleTowerTokenZoneItemData> ZoneList = new List<RoleTowerTokenZoneItemData>();

	// Token: 0x0400A05D RID: 41053
	[Nullable(2)]
	private TimerHandle RedDotDelayHandle;

	// Token: 0x0200803A RID: 32826
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297DB RID: 169947
		public const int UiItemCaption = 0;

		// Token: 0x040297DC RID: 169948
		public const int ZoneScroll = 1;

		// Token: 0x040297DD RID: 169949
		public const int UiItemZone = 2;

		// Token: 0x040297DE RID: 169950
		public const int UiItemTips = 3;

		// Token: 0x040297DF RID: 169951
		public const int NextPageRedDotItem = 4;
	}
}

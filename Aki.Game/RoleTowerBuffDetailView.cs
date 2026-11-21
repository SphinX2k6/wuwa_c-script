using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CCA RID: 7370
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerBuffDetailView : UiViewBase
{
	// Token: 0x060123FA RID: 74746 RVA: 0x005614DB File Offset: 0x0055F6DB
	public RoleTowerBuffDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B6C RID: 7020
	// (get) Token: 0x060123FB RID: 74747 RVA: 0x005614EF File Offset: 0x0055F6EF
	[Nullable(2)]
	private new RoleTowerBuffDetailViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as RoleTowerBuffDetailViewParams;
		}
	}

	// Token: 0x060123FC RID: 74748 RVA: 0x005614FC File Offset: 0x0055F6FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickLeft)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickRight))
		};
	}

	// Token: 0x060123FD RID: 74749 RVA: 0x005615EC File Offset: 0x0055F7EC
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerBuffDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerBuffDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060123FE RID: 74750 RVA: 0x0056162F File Offset: 0x0055F82F
	protected override void OnStart()
	{
		this.BuffList = new GenericScrollViewNew<RoleTowerBuffDetailItem, RoleTowerBuffDetailItemData>(base.GetScrollViewWithScrollbar(3), new Func<RoleTowerBuffDetailItem>(this.CreateItem), null, false, null);
	}

	// Token: 0x060123FF RID: 74751 RVA: 0x00561654 File Offset: 0x0055F854
	protected override void OnBeforeShow()
	{
		this.CollectTokenIds();
		RoleTowerBuffDetailViewParams openParam = this.OpenParam;
		this.CurTokenId = ((openParam != null) ? openParam.SelectTokenId : 0);
		if (!this.TokenIds.Contains(this.CurTokenId))
		{
			this.CurTokenId = ((this.TokenIds.Count > 0) ? this.TokenIds[0] : 0);
		}
		bool uiactive = this.TokenIds.Count > 1;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(uiactive);
			}
		}
		UUIButtonComponent button2 = base.GetButton(5);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(uiactive);
			}
		}
		this.RefreshList();
		this.RefreshDetail();
	}

	// Token: 0x06012400 RID: 74752 RVA: 0x0056171C File Offset: 0x0055F91C
	private void CollectTokenIds()
	{
		this.TokenIds.Clear();
		foreach (RoleTowerTokenCount roleTowerTokenCount in RoleTowerModel.Instance.GetLastSettleGainTokens())
		{
			if (RoleTowerModel.Instance.GetTokenCfg(roleTowerTokenCount.TokenId) != null && !this.TokenIds.Contains(roleTowerTokenCount.TokenId))
			{
				this.TokenIds.Add(roleTowerTokenCount.TokenId);
			}
		}
		RoleTowerBuffDetailViewParams openParam = this.OpenParam;
		int num = (openParam != null) ? openParam.SelectTokenId : 0;
		if (this.TokenIds.Count == 0 && num > 0)
		{
			this.TokenIds.Add(num);
		}
	}

	// Token: 0x06012401 RID: 74753 RVA: 0x005617E0 File Offset: 0x0055F9E0
	private RoleTowerBuffDetailItem CreateItem()
	{
		RoleTowerBuffDetailItem roleTowerBuffDetailItem = new RoleTowerBuffDetailItem();
		roleTowerBuffDetailItem.SetClickCallback(new Action<int>(this.OnClickToken));
		return roleTowerBuffDetailItem;
	}

	// Token: 0x06012402 RID: 74754 RVA: 0x005617FC File Offset: 0x0055F9FC
	private void RefreshList()
	{
		List<RoleTowerBuffDetailItemData> list = new List<RoleTowerBuffDetailItemData>();
		foreach (int num in this.TokenIds)
		{
			list.Add(new RoleTowerBuffDetailItemData
			{
				TokenId = num,
				IsSelected = (num == this.CurTokenId)
			});
		}
		GenericScrollViewNew<RoleTowerBuffDetailItem, RoleTowerBuffDetailItemData> buffList = this.BuffList;
		if (buffList == null)
		{
			return;
		}
		buffList.RefreshByData(list, new Action(this.RefreshContentAlign), false);
	}

	// Token: 0x06012403 RID: 74755 RVA: 0x00561890 File Offset: 0x0055FA90
	private void RefreshContentAlign()
	{
		if (this.BuffList == null)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		UActorComponent uactorComponent;
		if (scrollViewWithScrollbar == null)
		{
			uactorComponent = null;
		}
		else
		{
			AUIBaseActor content = scrollViewWithScrollbar.GetContent();
			uactorComponent = ((content != null) ? content.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
		}
		UActorComponent uactorComponent2 = uactorComponent;
		ELGUILayoutAlignmentType align = this.BuffList.IsExpand ? ELGUILayoutAlignmentType.MiddleLeft : ELGUILayoutAlignmentType.MiddleCenter;
		UUIHorizontalLayout uuihorizontalLayout = uactorComponent2 as UUIHorizontalLayout;
		if (uuihorizontalLayout != null)
		{
			uuihorizontalLayout.SetAlign(align);
			return;
		}
		UUIGridLayout uuigridLayout = uactorComponent2 as UUIGridLayout;
		if (uuigridLayout == null)
		{
			return;
		}
		uuigridLayout.SetAlign(align);
	}

	// Token: 0x06012404 RID: 74756 RVA: 0x00561908 File Offset: 0x0055FB08
	private void RefreshDetail()
	{
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(this.CurTokenId);
		if (tokenCfg == null || this.TipsContent == null)
		{
			ItemTipsComponentContentComponent tipsContent = this.TipsContent;
			if (tipsContent == null)
			{
				return;
			}
			tipsContent.SetActive(false);
			return;
		}
		else
		{
			ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(tokenCfg.Value.ItemId, null, null);
			if (tipsDataById == null)
			{
				this.TipsContent.SetActive(false);
				return;
			}
			TipsMaterialData tipsMaterialData = tipsDataById as TipsMaterialData;
			if (tipsMaterialData != null)
			{
				tipsMaterialData.Num = RoleTowerModel.Instance.GetTokenCount(this.CurTokenId);
			}
			this.TipsContent.Refresh(tipsDataById);
			this.TipsContent.SetTipsNumShow(true);
			return;
		}
	}

	// Token: 0x06012405 RID: 74757 RVA: 0x005619B1 File Offset: 0x0055FBB1
	private void OnClickToken(int tokenId)
	{
		this.CurTokenId = tokenId;
		this.RefreshList();
		this.RefreshDetail();
	}

	// Token: 0x06012406 RID: 74758 RVA: 0x005619C6 File Offset: 0x0055FBC6
	private void OnClickLeft()
	{
		this.ShiftSelect(-1);
	}

	// Token: 0x06012407 RID: 74759 RVA: 0x005619CF File Offset: 0x0055FBCF
	private void OnClickRight()
	{
		this.ShiftSelect(1);
	}

	// Token: 0x06012408 RID: 74760 RVA: 0x005619D8 File Offset: 0x0055FBD8
	private void ShiftSelect(int delta)
	{
		if (this.TokenIds.Count == 0)
		{
			return;
		}
		int num = Math.Max(0, this.TokenIds.IndexOf(this.CurTokenId));
		num = (num + delta + this.TokenIds.Count) % this.TokenIds.Count;
		this.CurTokenId = this.TokenIds[num];
		this.RefreshList();
		this.RefreshDetail();
	}

	// Token: 0x06012409 RID: 74761 RVA: 0x00561A45 File Offset: 0x0055FC45
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009F6E RID: 40814
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerBuffDetailItem, RoleTowerBuffDetailItemData> BuffList;

	// Token: 0x04009F6F RID: 40815
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsContent;

	// Token: 0x04009F70 RID: 40816
	private int CurTokenId;

	// Token: 0x04009F71 RID: 40817
	private readonly List<int> TokenIds = new List<int>();

	// Token: 0x02007FBA RID: 32698
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402952C RID: 169260
		public const int BtnClose = 0;

		// Token: 0x0402952D RID: 169261
		public const int UiItemItemTips = 1;

		// Token: 0x0402952E RID: 169262
		public const int BtnLeft = 2;

		// Token: 0x0402952F RID: 169263
		public const int BuffItemScroll = 3;

		// Token: 0x04029530 RID: 169264
		public const int UiItemItemBaseB = 4;

		// Token: 0x04029531 RID: 169265
		public const int BtnRight = 5;
	}
}

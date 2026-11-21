using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001CDE RID: 7390
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerMonsterSelectView : UiViewBase
{
	// Token: 0x060124A4 RID: 74916 RVA: 0x00564CB6 File Offset: 0x00562EB6
	[NullableContext(1)]
	public RoleTowerMonsterSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B70 RID: 7024
	// (get) Token: 0x060124A5 RID: 74917 RVA: 0x00564CBF File Offset: 0x00562EBF
	private new RoleTowerMonsterSelectViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerMonsterSelectViewParams;
		}
	}

	// Token: 0x060124A6 RID: 74918 RVA: 0x00564CCC File Offset: 0x00562ECC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBack))
		};
	}

	// Token: 0x060124A7 RID: 74919 RVA: 0x00564D60 File Offset: 0x00562F60
	protected override void OnStart()
	{
		this.CardLayout = new GenericLayout<RoleTowerMonsterSelectItem, RoleTowerMonsterSelectData>(base.GetHorizontalLayout(2), new Func<RoleTowerMonsterSelectItem>(this.CreateCard), null, false, true);
		this.MonsterListAnim = (base.GetHorizontalLayout(2).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
	}

	// Token: 0x060124A8 RID: 74920 RVA: 0x00564DB4 File Offset: 0x00562FB4
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		UUIInturnAnimController monsterListAnim = this.MonsterListAnim;
		if (monsterListAnim != null)
		{
			monsterListAnim.Play("", -1, false);
		}
		return UniTask.CompletedTask;
	}

	// Token: 0x060124A9 RID: 74921 RVA: 0x00564DD3 File Offset: 0x00562FD3
	protected override void OnBeforeShow()
	{
		this.CurSelectBranchId = 0;
		this.RefreshCards();
	}

	// Token: 0x060124AA RID: 74922 RVA: 0x00564DE2 File Offset: 0x00562FE2
	[NullableContext(1)]
	private RoleTowerMonsterSelectItem CreateCard()
	{
		RoleTowerMonsterSelectItem roleTowerMonsterSelectItem = new RoleTowerMonsterSelectItem();
		roleTowerMonsterSelectItem.SetConfirmCallback(new Action<int>(this.OnCardConfirm));
		return roleTowerMonsterSelectItem;
	}

	// Token: 0x060124AB RID: 74923 RVA: 0x00564DFC File Offset: 0x00562FFC
	private void RefreshCards()
	{
		IReadOnlyList<ValueTuple<int, int>> curBranchOptions = RoleTowerModel.Instance.GetCurBranchOptions();
		this.RefreshTitle(curBranchOptions);
		List<RoleTowerMonsterSelectData> list = new List<RoleTowerMonsterSelectData>();
		foreach (ValueTuple<int, int> valueTuple in curBranchOptions)
		{
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			list.Add(new RoleTowerMonsterSelectData
			{
				BranchId = item,
				FloorId = item2,
				IsSelected = (item == this.CurSelectBranchId)
			});
		}
		GenericLayout<RoleTowerMonsterSelectItem, RoleTowerMonsterSelectData> cardLayout = this.CardLayout;
		if (cardLayout == null)
		{
			return;
		}
		cardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060124AC RID: 74924 RVA: 0x00564EA0 File Offset: 0x005630A0
	private void RefreshTitle([TupleElementNames(new string[]
	{
		"branchId",
		"floorId"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] IReadOnlyList<ValueTuple<int, int>> options)
	{
		RoleTowerFloor? roleTowerFloor;
		int num = (options.Count > 0) ? ((RoleTowerModel.Instance.GetFloorCfg(options[0].Item2) != null) ? roleTowerFloor.GetValueOrDefault().FloorIndex : 0) : 0;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PrefabTextItem_239132332_Text", new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x060124AD RID: 74925 RVA: 0x00564F0D File Offset: 0x0056310D
	private void OnCardConfirm(int branchId)
	{
		if (branchId <= 0)
		{
			return;
		}
		this.CurSelectBranchId = branchId;
		RoleTowerMonsterSelectViewParams openParam = this.OpenParam;
		if (openParam != null)
		{
			Action<int> onConfirm = openParam.OnConfirm;
			if (onConfirm != null)
			{
				onConfirm(branchId);
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x060124AE RID: 74926 RVA: 0x00564F3F File Offset: 0x0056313F
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009FA1 RID: 40865
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerMonsterSelectItem, RoleTowerMonsterSelectData> CardLayout;

	// Token: 0x04009FA2 RID: 40866
	private UUIInturnAnimController MonsterListAnim;

	// Token: 0x04009FA3 RID: 40867
	private int CurSelectBranchId;

	// Token: 0x02007FDA RID: 32730
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040295C4 RID: 169412
		public const int UiItemBackBtn = 0;

		// Token: 0x040295C5 RID: 169413
		public const int TxtTitle = 1;

		// Token: 0x040295C6 RID: 169414
		public const int PnlMonsterItem = 2;

		// Token: 0x040295C7 RID: 169415
		public const int UiItemMonsterInfoGroup = 3;
	}
}

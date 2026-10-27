using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A4 RID: 10660
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerCoverItem : UiPanelBase
{
	// Token: 0x0601619C RID: 90524 RVA: 0x00596878 File Offset: 0x00594A78
	public UniTask Init(UUIItem item)
	{
		ShipTowerCoverItem.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerCoverItem.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601619D RID: 90525 RVA: 0x005968C4 File Offset: 0x00594AC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x0601619E RID: 90526 RVA: 0x00596978 File Offset: 0x00594B78
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCoverItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCoverItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601619F RID: 90527 RVA: 0x005969BC File Offset: 0x00594BBC
	public void UpdateData(ShipTowerStageData data, bool isCover = false)
	{
		this.ItemData = data;
		this.IsCover = isCover;
		List<int> data2;
		List<int> data3;
		ShipTowerBuffData shipTowerBuffData;
		ShipTowerBuffData shipTowerBuffData2;
		if (this.IsCover)
		{
			data2 = data.TeamDataList[0].GetRoleIdListEdit();
			data3 = data.TeamDataList[1].GetRoleIdListEdit();
			shipTowerBuffData = data.TeamDataList[0].BuffDataEdit;
			shipTowerBuffData2 = data.TeamDataList[1].BuffDataEdit;
			this.BtnConfirm.SetShowText("ConfirmBox_132_ButtonText_1");
		}
		else
		{
			this.BtnConfirm.SetShowText("ConfirmBox_132_ButtonText_0");
			data2 = data.TeamDataList[0].GetRoleIdList();
			data3 = data.TeamDataList[1].GetRoleIdList();
			shipTowerBuffData = data.TeamDataList[0].BuffData;
			shipTowerBuffData2 = data.TeamDataList[1].BuffData;
		}
		this.LayoutRoleList1.RefreshByData(data2, null, false);
		this.LayoutRoleList2.RefreshByData(data3, null, false);
		this.BuffItem1.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = shipTowerBuffData,
			ItemConfigId = new int?((shipTowerBuffData != null) ? shipTowerBuffData.ItemId : 1)
		});
		this.BuffItem2.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = shipTowerBuffData2,
			ItemConfigId = new int?((shipTowerBuffData2 != null) ? shipTowerBuffData2.ItemId : 1)
		});
		int score = this.IsCover ? data.NewChallengeScore : data.CurrentScore;
		base.GetText(4).SetText(score.ToString(), true);
		UUITexture texture = base.GetTexture(5);
		string stageGradeResIdByStageId = ShipTowerModel.Instance.GetStageGradeResIdByStageId(data.Id, score);
		texture.SetUIActive(stageGradeResIdByStageId != null);
		if (stageGradeResIdByStageId != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(stageGradeResIdByStageId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
	}

	// Token: 0x060161A0 RID: 90528 RVA: 0x00596B85 File Offset: 0x00594D85
	private void OnBtnConfirmClick()
	{
		Action<ShipTowerStageData, bool> confirmCallback = this.ConfirmCallback;
		if (confirmCallback == null)
		{
			return;
		}
		confirmCallback(this.ItemData, this.IsCover);
	}

	// Token: 0x060161A1 RID: 90529 RVA: 0x00596BA3 File Offset: 0x00594DA3
	private ShipTowerCoverRoleItem CreateRoleItem()
	{
		return new ShipTowerCoverRoleItem();
	}

	// Token: 0x060161A2 RID: 90530 RVA: 0x00596BAA File Offset: 0x00594DAA
	private void OnClickBuff(MediumItemGridExtendCallback param)
	{
	}

	// Token: 0x0400A4B8 RID: 42168
	private ShipTowerStageData ItemData;

	// Token: 0x0400A4B9 RID: 42169
	private bool IsCover;

	// Token: 0x0400A4BA RID: 42170
	private ButtonItem BtnConfirm;

	// Token: 0x0400A4BB RID: 42171
	private GenericLayout<ShipTowerCoverRoleItem, int> LayoutRoleList1;

	// Token: 0x0400A4BC RID: 42172
	private GenericLayout<ShipTowerCoverRoleItem, int> LayoutRoleList2;

	// Token: 0x0400A4BD RID: 42173
	private SmallItemGrid BuffItem1;

	// Token: 0x0400A4BE RID: 42174
	private SmallItemGrid BuffItem2;

	// Token: 0x0400A4BF RID: 42175
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerStageData, bool> ConfirmCallback;

	// Token: 0x02008FB0 RID: 36784
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E895 RID: 190613
		public const int HLayoutRoleList1 = 0;

		// Token: 0x0402E896 RID: 190614
		public const int HLayoutRoleList2 = 1;

		// Token: 0x0402E897 RID: 190615
		public const int ItemBuff1 = 2;

		// Token: 0x0402E898 RID: 190616
		public const int ItemBuff2 = 3;

		// Token: 0x0402E899 RID: 190617
		public const int TxtScore = 4;

		// Token: 0x0402E89A RID: 190618
		public const int TextureGrade = 5;

		// Token: 0x0402E89B RID: 190619
		public const int ItemConfirm = 6;
	}
}

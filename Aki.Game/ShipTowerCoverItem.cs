using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F1F RID: 7967
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerCoverItem : UiPanelBase
{
	// Token: 0x06013BA2 RID: 80802 RVA: 0x005C1838 File Offset: 0x005BFA38
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

	// Token: 0x06013BA3 RID: 80803 RVA: 0x005C1884 File Offset: 0x005BFA84
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

	// Token: 0x06013BA4 RID: 80804 RVA: 0x005C1938 File Offset: 0x005BFB38
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCoverItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCoverItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BA5 RID: 80805 RVA: 0x005C197C File Offset: 0x005BFB7C
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

	// Token: 0x06013BA6 RID: 80806 RVA: 0x005C1B45 File Offset: 0x005BFD45
	private void OnBtnConfirmClick()
	{
		Action<ShipTowerStageData, bool> confirmCallback = this.ConfirmCallback;
		if (confirmCallback == null)
		{
			return;
		}
		confirmCallback(this.ItemData, this.IsCover);
	}

	// Token: 0x06013BA7 RID: 80807 RVA: 0x005C1B63 File Offset: 0x005BFD63
	private ShipTowerCoverRoleItem CreateRoleItem()
	{
		return new ShipTowerCoverRoleItem();
	}

	// Token: 0x06013BA8 RID: 80808 RVA: 0x005C1B6A File Offset: 0x005BFD6A
	private void OnClickBuff(MediumItemGridExtendCallback param)
	{
	}

	// Token: 0x0400A8A2 RID: 43170
	private ShipTowerStageData ItemData;

	// Token: 0x0400A8A3 RID: 43171
	private bool IsCover;

	// Token: 0x0400A8A4 RID: 43172
	private ButtonItem BtnConfirm;

	// Token: 0x0400A8A5 RID: 43173
	private GenericLayout<ShipTowerCoverRoleItem, int> LayoutRoleList1;

	// Token: 0x0400A8A6 RID: 43174
	private GenericLayout<ShipTowerCoverRoleItem, int> LayoutRoleList2;

	// Token: 0x0400A8A7 RID: 43175
	private SmallItemGrid BuffItem1;

	// Token: 0x0400A8A8 RID: 43176
	private SmallItemGrid BuffItem2;

	// Token: 0x0400A8A9 RID: 43177
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerStageData, bool> ConfirmCallback;

	// Token: 0x020081F9 RID: 33273
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029F94 RID: 171924
		public const int HLayoutRoleList1 = 0;

		// Token: 0x04029F95 RID: 171925
		public const int HLayoutRoleList2 = 1;

		// Token: 0x04029F96 RID: 171926
		public const int ItemBuff1 = 2;

		// Token: 0x04029F97 RID: 171927
		public const int ItemBuff2 = 3;

		// Token: 0x04029F98 RID: 171928
		public const int TxtScore = 4;

		// Token: 0x04029F99 RID: 171929
		public const int TextureGrade = 5;

		// Token: 0x04029F9A RID: 171930
		public const int ItemConfirm = 6;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023DE RID: 9182
[NullableContext(2)]
[Nullable(0)]
public class PersonalPlayerTitlePreviewComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x060125B1 RID: 75185 RVA: 0x00486014 File Offset: 0x00484214
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x060125B2 RID: 75186 RVA: 0x00486138 File Offset: 0x00484338
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitlePreviewComponent.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitlePreviewComponent.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125B3 RID: 75187 RVA: 0x0048617B File Offset: 0x0048437B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060125B4 RID: 75188 RVA: 0x0048618E File Offset: 0x0048438E
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x060125B5 RID: 75189 RVA: 0x00486198 File Offset: 0x00484398
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x060125B6 RID: 75190 RVA: 0x004861C8 File Offset: 0x004843C8
	public UniTask PlayCloseSequence()
	{
		PersonalPlayerTitlePreviewComponent.<PlayCloseSequence>d__10 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PersonalPlayerTitlePreviewComponent.<PlayCloseSequence>d__10>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060125B7 RID: 75191 RVA: 0x0048620C File Offset: 0x0048440C
	public void Refresh(int titleId)
	{
		PlayerTitle? playerTitleItemConfig = InventoryConfig.Instance.GetPlayerTitleItemConfig(titleId);
		int curCardId = PersonalModel.Instance.GetCurCardId();
		BackgroundCard? cardItemConfig = InventoryConfig.Instance.GetCardItemConfig(curCardId);
		int value = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto).Value;
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(value, true);
		base.GetText(0).ShowTextNew(playerTitleItemConfig.Value.Description);
		if (playerTitleItemConfig.Value.IsShowProgress)
		{
			PersonalPlayerTitleData playerTitleData = PersonalModel.Instance.GetPlayerTitleData(playerTitleItemConfig.Value.Id);
			int? num = (playerTitleData != null) ? playerTitleData.CurProgress : null;
			PersonalPlayerTitleData playerTitleData2 = PersonalModel.Instance.GetPlayerTitleData(playerTitleItemConfig.Value.Id);
			int? num2 = (playerTitleData2 != null) ? playerTitleData2.TargetProgress : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), playerTitleItemConfig.Value.ItemAccess, new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
		}
		else
		{
			base.GetText(1).ShowTextNew(playerTitleItemConfig.Value.ItemAccess);
		}
		base.GetText(2).ShowTextNew(playerTitleItemConfig.Value.TitleName);
		base.GetText(7).SetText(FunctionModel.Instance.GetPlayerName(), true);
		base.GetText(9).SetText(FunctionModel.Instance.GetPlayerName(), true);
		base.SetTextureShowUntilLoaded(cardItemConfig.Value.FunctionViewCardPath, base.GetTexture(3), null);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(4), null);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(5), null);
		base.SetTextureShowUntilLoaded(cardItemConfig.Value.LongCardPath, base.GetTexture(6), null);
		this.RefreshPlayerTitle(playerTitleItemConfig.Value);
	}

	// Token: 0x060125B8 RID: 75192 RVA: 0x00486410 File Offset: 0x00484610
	private void RefreshPlayerTitle(PlayerTitle titleConfig)
	{
		PlayerTitleItem itemTitleInMid = this.ItemTitleInMid;
		if (itemTitleInMid != null)
		{
			itemTitleInMid.Refresh(new int?(titleConfig.Id), new int?(PersonalModel.Instance.GetPlayerTitleStarLevel(titleConfig.Id)), new int?(PersonalModel.Instance.GetSex()));
		}
		PlayerTitleItem itemTitleInRight = this.ItemTitleInRight;
		if (itemTitleInRight != null)
		{
			itemTitleInRight.Refresh(new int?(titleConfig.Id), new int?(PersonalModel.Instance.GetPlayerTitleStarLevel(titleConfig.Id)), new int?(PersonalModel.Instance.GetSex()));
		}
		PlayerTitleItem itemTitleInList = this.ItemTitleInList;
		if (itemTitleInList == null)
		{
			return;
		}
		itemTitleInList.Refresh(new int?(titleConfig.Id), new int?(PersonalModel.Instance.GetPlayerTitleStarLevel(titleConfig.Id)), new int?(PersonalModel.Instance.GetSex()));
	}

	// Token: 0x04008ADB RID: 35547
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008ADC RID: 35548
	private PlayerTitleItem ItemTitleInMid;

	// Token: 0x04008ADD RID: 35549
	private PlayerTitleItem ItemTitleInRight;

	// Token: 0x04008ADE RID: 35550
	private PlayerTitleItem ItemTitleInList;

	// Token: 0x02008982 RID: 35202
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CAF2 RID: 183026
		TxtDesc,
		// Token: 0x0402CAF3 RID: 183027
		TxtGetWay,
		// Token: 0x0402CAF4 RID: 183028
		TxtTitleName,
		// Token: 0x0402CAF5 RID: 183029
		TexCard,
		// Token: 0x0402CAF6 RID: 183030
		TexRole,
		// Token: 0x0402CAF7 RID: 183031
		TexRoleInList,
		// Token: 0x0402CAF8 RID: 183032
		TexCardInList,
		// Token: 0x0402CAF9 RID: 183033
		TxtPlayerNameInList,
		// Token: 0x0402CAFA RID: 183034
		ItemTitleInMid,
		// Token: 0x0402CAFB RID: 183035
		TxtPlayerNameInMid,
		// Token: 0x0402CAFC RID: 183036
		ItemTitleInRight,
		// Token: 0x0402CAFD RID: 183037
		ItemTitleInList
	}
}

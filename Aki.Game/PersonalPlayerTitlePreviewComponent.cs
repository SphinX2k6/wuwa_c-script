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

// Token: 0x020018C3 RID: 6339
[NullableContext(2)]
[Nullable(0)]
public class PersonalPlayerTitlePreviewComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0600FA63 RID: 64099 RVA: 0x00493520 File Offset: 0x00491720
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

	// Token: 0x0600FA64 RID: 64100 RVA: 0x00493644 File Offset: 0x00491844
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitlePreviewComponent.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitlePreviewComponent.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA65 RID: 64101 RVA: 0x00493687 File Offset: 0x00491887
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600FA66 RID: 64102 RVA: 0x0049369A File Offset: 0x0049189A
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x0600FA67 RID: 64103 RVA: 0x004936A4 File Offset: 0x004918A4
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600FA68 RID: 64104 RVA: 0x004936D4 File Offset: 0x004918D4
	public UniTask PlayCloseSequence()
	{
		PersonalPlayerTitlePreviewComponent.<PlayCloseSequence>d__10 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PersonalPlayerTitlePreviewComponent.<PlayCloseSequence>d__10>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA69 RID: 64105 RVA: 0x00493718 File Offset: 0x00491918
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

	// Token: 0x0600FA6A RID: 64106 RVA: 0x0049391C File Offset: 0x00491B1C
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

	// Token: 0x04008C22 RID: 35874
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008C23 RID: 35875
	private PlayerTitleItem ItemTitleInMid;

	// Token: 0x04008C24 RID: 35876
	private PlayerTitleItem ItemTitleInRight;

	// Token: 0x04008C25 RID: 35877
	private PlayerTitleItem ItemTitleInList;

	// Token: 0x02007B0B RID: 31499
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027E0D RID: 163341
		TxtDesc,
		// Token: 0x04027E0E RID: 163342
		TxtGetWay,
		// Token: 0x04027E0F RID: 163343
		TxtTitleName,
		// Token: 0x04027E10 RID: 163344
		TexCard,
		// Token: 0x04027E11 RID: 163345
		TexRole,
		// Token: 0x04027E12 RID: 163346
		TexRoleInList,
		// Token: 0x04027E13 RID: 163347
		TexCardInList,
		// Token: 0x04027E14 RID: 163348
		TxtPlayerNameInList,
		// Token: 0x04027E15 RID: 163349
		ItemTitleInMid,
		// Token: 0x04027E16 RID: 163350
		TxtPlayerNameInMid,
		// Token: 0x04027E17 RID: 163351
		ItemTitleInRight,
		// Token: 0x04027E18 RID: 163352
		ItemTitleInList
	}
}

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

// Token: 0x020018B2 RID: 6322
public class PersonalCardPreviewComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0600F9E1 RID: 63969 RVA: 0x00490AB4 File Offset: 0x0048ECB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x0600F9E2 RID: 63970 RVA: 0x00490B92 File Offset: 0x0048ED92
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F9E3 RID: 63971 RVA: 0x00490BA5 File Offset: 0x0048EDA5
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x0600F9E4 RID: 63972 RVA: 0x00490BB0 File Offset: 0x0048EDB0
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600F9E5 RID: 63973 RVA: 0x00490BE0 File Offset: 0x0048EDE0
	public UniTask PlayCloseSequence()
	{
		PersonalCardPreviewComponent.<PlayCloseSequence>d__7 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PersonalCardPreviewComponent.<PlayCloseSequence>d__7>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600F9E6 RID: 63974 RVA: 0x00490C24 File Offset: 0x0048EE24
	[NullableContext(1)]
	public void Refresh(ItemTipsData data)
	{
		this.CurrentData = (data as TipsCardData);
		BackgroundCard? cardItemConfig = InventoryConfig.Instance.GetCardItemConfig(this.CurrentData.ConfigId);
		if (cardItemConfig == null)
		{
			return;
		}
		base.GetText(3).ShowTextNew(cardItemConfig.Value.Title);
		base.GetText(1).ShowTextNew(cardItemConfig.Value.AttributesDescription);
		base.GetText(2).ShowTextNew(cardItemConfig.Value.Tips);
		base.SetTextureShowUntilLoaded(cardItemConfig.Value.CardPath, base.GetTexture(0), null);
		base.SetTextureShowUntilLoaded(cardItemConfig.Value.FunctionViewCardPath, base.GetTexture(4), null);
		base.SetTextureShowUntilLoaded(cardItemConfig.Value.LongCardPath, base.GetTexture(7), null);
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById == null)
		{
			return;
		}
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(numberPropById.Value, true);
		if (playerHeadData == null)
		{
			return;
		}
		UUITexture roleHeadTexture = base.GetTexture(5);
		roleHeadTexture.SetUIActive(false);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), roleHeadTexture, delegate(bool _)
		{
			roleHeadTexture.SetUIActive(true);
		});
		UUITexture roleFriendHeadTexture = base.GetTexture(6);
		roleFriendHeadTexture.SetUIActive(false);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), roleFriendHeadTexture, delegate(bool _)
		{
			roleFriendHeadTexture.SetUIActive(true);
		});
		base.GetText(8).SetText(FunctionModel.Instance.GetPlayerName(), true);
	}

	// Token: 0x0600F9E7 RID: 63975 RVA: 0x00490DC3 File Offset: 0x0048EFC3
	public override void SetActive(bool visibility)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(visibility);
	}

	// Token: 0x04008BC5 RID: 35781
	[Nullable(2)]
	private TipsCardData CurrentData;

	// Token: 0x04008BC6 RID: 35782
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007AF9 RID: 31481
	private enum EComponent
	{
		// Token: 0x04027DBC RID: 163260
		CardTexture,
		// Token: 0x04027DBD RID: 163261
		CardDescText,
		// Token: 0x04027DBE RID: 163262
		CardTipsText,
		// Token: 0x04027DBF RID: 163263
		CardName,
		// Token: 0x04027DC0 RID: 163264
		RoleHeadCardTexture,
		// Token: 0x04027DC1 RID: 163265
		RoleHeadTexture,
		// Token: 0x04027DC2 RID: 163266
		RoleFriendHeadTexture,
		// Token: 0x04027DC3 RID: 163267
		LongCardTexture,
		// Token: 0x04027DC4 RID: 163268
		PlayerNameText
	}
}

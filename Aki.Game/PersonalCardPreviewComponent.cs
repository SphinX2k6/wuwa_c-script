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

// Token: 0x020023CD RID: 9165
public class PersonalCardPreviewComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0601252F RID: 75055 RVA: 0x004835B4 File Offset: 0x004817B4
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

	// Token: 0x06012530 RID: 75056 RVA: 0x00483692 File Offset: 0x00481892
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06012531 RID: 75057 RVA: 0x004836A5 File Offset: 0x004818A5
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x06012532 RID: 75058 RVA: 0x004836B0 File Offset: 0x004818B0
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x06012533 RID: 75059 RVA: 0x004836E0 File Offset: 0x004818E0
	public UniTask PlayCloseSequence()
	{
		PersonalCardPreviewComponent.<PlayCloseSequence>d__7 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PersonalCardPreviewComponent.<PlayCloseSequence>d__7>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06012534 RID: 75060 RVA: 0x00483724 File Offset: 0x00481924
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

	// Token: 0x06012535 RID: 75061 RVA: 0x004838C3 File Offset: 0x00481AC3
	public override void SetActive(bool visibility)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(visibility);
	}

	// Token: 0x04008A7E RID: 35454
	[Nullable(2)]
	private TipsCardData CurrentData;

	// Token: 0x04008A7F RID: 35455
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008970 RID: 35184
	private enum EComponent
	{
		// Token: 0x0402CAA1 RID: 182945
		CardTexture,
		// Token: 0x0402CAA2 RID: 182946
		CardDescText,
		// Token: 0x0402CAA3 RID: 182947
		CardTipsText,
		// Token: 0x0402CAA4 RID: 182948
		CardName,
		// Token: 0x0402CAA5 RID: 182949
		RoleHeadCardTexture,
		// Token: 0x0402CAA6 RID: 182950
		RoleHeadTexture,
		// Token: 0x0402CAA7 RID: 182951
		RoleFriendHeadTexture,
		// Token: 0x0402CAA8 RID: 182952
		LongCardTexture,
		// Token: 0x0402CAA9 RID: 182953
		PlayerNameText
	}
}

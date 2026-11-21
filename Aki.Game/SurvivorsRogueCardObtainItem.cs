using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200204F RID: 8271
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueCardObtainItem : SurvivorsRogueCardScrollItemBase<GoodsDetail>
{
	// Token: 0x06014737 RID: 83767 RVA: 0x005F7E14 File Offset: 0x005F6014
	public override UniTask RefreshAsync(GoodsDetail data, bool isSelected, int gridIndex)
	{
		SurvivorsRogueCardObtainItem.<RefreshAsync>d__1 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.isSelected = isSelected;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueCardObtainItem.<RefreshAsync>d__1>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014738 RID: 83768 RVA: 0x005F7E70 File Offset: 0x005F6070
	private UniTask RefreshRoleLv(Aki.Protocol.SurvivorsGainData gainData, int gridIndex)
	{
		SurvivorsRogueCardObtainItem.<RefreshRoleLv>d__2 <RefreshRoleLv>d__;
		<RefreshRoleLv>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleLv>d__.<>4__this = this;
		<RefreshRoleLv>d__.gainData = gainData;
		<RefreshRoleLv>d__.gridIndex = gridIndex;
		<RefreshRoleLv>d__.<>1__state = -1;
		<RefreshRoleLv>d__.<>t__builder.Start<SurvivorsRogueCardObtainItem.<RefreshRoleLv>d__2>(ref <RefreshRoleLv>d__);
		return <RefreshRoleLv>d__.<>t__builder.Task;
	}

	// Token: 0x06014739 RID: 83769 RVA: 0x005F7EC4 File Offset: 0x005F60C4
	private UniTask RefreshWeaponLv(Aki.Protocol.SurvivorsGainData gainData, int gridIndex)
	{
		SurvivorsRogueCardObtainItem.<RefreshWeaponLv>d__3 <RefreshWeaponLv>d__;
		<RefreshWeaponLv>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWeaponLv>d__.<>4__this = this;
		<RefreshWeaponLv>d__.gainData = gainData;
		<RefreshWeaponLv>d__.gridIndex = gridIndex;
		<RefreshWeaponLv>d__.<>1__state = -1;
		<RefreshWeaponLv>d__.<>t__builder.Start<SurvivorsRogueCardObtainItem.<RefreshWeaponLv>d__3>(ref <RefreshWeaponLv>d__);
		return <RefreshWeaponLv>d__.<>t__builder.Task;
	}

	// Token: 0x0601473A RID: 83770 RVA: 0x005F7F18 File Offset: 0x005F6118
	private UniTask RefreshNewWeapon(Aki.Protocol.SurvivorsGainData gainData, int gridIndex)
	{
		SurvivorsRogueCardObtainItem.<RefreshNewWeapon>d__4 <RefreshNewWeapon>d__;
		<RefreshNewWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNewWeapon>d__.<>4__this = this;
		<RefreshNewWeapon>d__.gainData = gainData;
		<RefreshNewWeapon>d__.gridIndex = gridIndex;
		<RefreshNewWeapon>d__.<>1__state = -1;
		<RefreshNewWeapon>d__.<>t__builder.Start<SurvivorsRogueCardObtainItem.<RefreshNewWeapon>d__4>(ref <RefreshNewWeapon>d__);
		return <RefreshNewWeapon>d__.<>t__builder.Task;
	}

	// Token: 0x0601473B RID: 83771 RVA: 0x005F7F6C File Offset: 0x005F616C
	private UniTask RefreshNewItem(Aki.Protocol.SurvivorsGainData gainData, int gridIndex)
	{
		SurvivorsRogueCardObtainItem.<RefreshNewItem>d__5 <RefreshNewItem>d__;
		<RefreshNewItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNewItem>d__.<>4__this = this;
		<RefreshNewItem>d__.gainData = gainData;
		<RefreshNewItem>d__.gridIndex = gridIndex;
		<RefreshNewItem>d__.<>1__state = -1;
		<RefreshNewItem>d__.<>t__builder.Start<SurvivorsRogueCardObtainItem.<RefreshNewItem>d__5>(ref <RefreshNewItem>d__);
		return <RefreshNewItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601473C RID: 83772 RVA: 0x005F7FBF File Offset: 0x005F61BF
	public override void OnSelected(bool fireEvent)
	{
		base.SetSelected(true, fireEvent, false);
	}

	// Token: 0x0601473D RID: 83773 RVA: 0x005F7FCA File Offset: 0x005F61CA
	public override void OnDeselected(bool fireEvent)
	{
		base.SetSelected(false, fireEvent, false);
	}

	// Token: 0x0601473E RID: 83774 RVA: 0x005F7FD5 File Offset: 0x005F61D5
	public override object GetKey(GoodsDetail data, int gridIndex)
	{
		return data.SurvivorsGainData.IncId;
	}

	// Token: 0x0400AD82 RID: 44418
	protected GoodsDetail GoodData;
}

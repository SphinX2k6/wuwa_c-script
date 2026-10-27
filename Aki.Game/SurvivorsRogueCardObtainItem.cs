using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AD3 RID: 10963
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueCardObtainItem : SurvivorsRogueCardScrollItemBase<GoodsDetail>
{
	// Token: 0x06016D06 RID: 93446 RVA: 0x005CB2C0 File Offset: 0x005C94C0
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

	// Token: 0x06016D07 RID: 93447 RVA: 0x005CB31C File Offset: 0x005C951C
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

	// Token: 0x06016D08 RID: 93448 RVA: 0x005CB370 File Offset: 0x005C9570
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

	// Token: 0x06016D09 RID: 93449 RVA: 0x005CB3C4 File Offset: 0x005C95C4
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

	// Token: 0x06016D0A RID: 93450 RVA: 0x005CB418 File Offset: 0x005C9618
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

	// Token: 0x06016D0B RID: 93451 RVA: 0x005CB46B File Offset: 0x005C966B
	public override void OnSelected(bool fireEvent)
	{
		base.SetSelected(true, fireEvent, false);
	}

	// Token: 0x06016D0C RID: 93452 RVA: 0x005CB476 File Offset: 0x005C9676
	public override void OnDeselected(bool fireEvent)
	{
		base.SetSelected(false, fireEvent, false);
	}

	// Token: 0x06016D0D RID: 93453 RVA: 0x005CB481 File Offset: 0x005C9681
	public override object GetKey(GoodsDetail data, int gridIndex)
	{
		return data.SurvivorsGainData.IncId;
	}

	// Token: 0x0400A97C RID: 43388
	protected GoodsDetail GoodData;
}

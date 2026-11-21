using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020020D9 RID: 8409
internal class CardScrollItem : SurvivorsRogueCardScrollItemBase<int>
{
	// Token: 0x06014A73 RID: 84595 RVA: 0x00604D0C File Offset: 0x00602F0C
	public override UniTask RefreshAsync(int weaponId, bool isSelected, int gridIndex)
	{
		CardScrollItem.<RefreshAsync>d__0 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.weaponId = weaponId;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<CardScrollItem.<RefreshAsync>d__0>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A74 RID: 84596 RVA: 0x00604D57 File Offset: 0x00602F57
	protected override bool OnCanExecuteChange()
	{
		return false;
	}
}

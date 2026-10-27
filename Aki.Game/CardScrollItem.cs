using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002B5D RID: 11101
internal class CardScrollItem : SurvivorsRogueCardScrollItemBase<int>
{
	// Token: 0x06017042 RID: 94274 RVA: 0x005D81A4 File Offset: 0x005D63A4
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

	// Token: 0x06017043 RID: 94275 RVA: 0x005D81EF File Offset: 0x005D63EF
	protected override bool OnCanExecuteChange()
	{
		return false;
	}
}

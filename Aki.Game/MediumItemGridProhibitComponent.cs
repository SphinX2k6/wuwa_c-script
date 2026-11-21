using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000DE0 RID: 3552
public class MediumItemGridProhibitComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600906E RID: 36974 RVA: 0x002B537E File Offset: 0x002B357E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemLock";
	}

	// Token: 0x0600906F RID: 36975 RVA: 0x002B5388 File Offset: 0x002B3588
	public UniTask PlayUnlockAnim()
	{
		MediumItemGridProhibitComponent.<PlayUnlockAnim>d__1 <PlayUnlockAnim>d__;
		<PlayUnlockAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayUnlockAnim>d__.<>4__this = this;
		<PlayUnlockAnim>d__.<>1__state = -1;
		<PlayUnlockAnim>d__.<>t__builder.Start<MediumItemGridProhibitComponent.<PlayUnlockAnim>d__1>(ref <PlayUnlockAnim>d__);
		return <PlayUnlockAnim>d__.<>t__builder.Task;
	}
}

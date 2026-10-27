using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001927 RID: 6439
public class MediumItemGridProhibitComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC84 RID: 48260 RVA: 0x002AAC22 File Offset: 0x002A8E22
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemLock";
	}

	// Token: 0x0600BC85 RID: 48261 RVA: 0x002AAC2C File Offset: 0x002A8E2C
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

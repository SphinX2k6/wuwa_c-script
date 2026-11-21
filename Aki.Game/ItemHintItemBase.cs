using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020014D0 RID: 5328
[NullableContext(2)]
[Nullable(0)]
public abstract class ItemHintItemBase<T> : SliderItem
{
	// Token: 0x0600D53B RID: 54587 RVA: 0x003F5F6D File Offset: 0x003F416D
	public void SetShiftData([Nullable(new byte[]
	{
		1,
		2
	})] Func<T> shiftData)
	{
		this.ShiftData = shiftData;
	}

	// Token: 0x0600D53C RID: 54588 RVA: 0x003F5F78 File Offset: 0x003F4178
	public override UniTask AsyncLoadUiResource()
	{
		ItemHintItemBase<T>.<AsyncLoadUiResource>d__3 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemHintItemBase<T>.<AsyncLoadUiResource>d__3>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x0600D53D RID: 54589 RVA: 0x003F5FBB File Offset: 0x003F41BB
	protected virtual UniTask OnRefresh(T data)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x040077A6 RID: 30630
	protected T Data;

	// Token: 0x040077A7 RID: 30631
	protected Func<T> ShiftData;
}

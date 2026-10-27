using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001FFD RID: 8189
[NullableContext(2)]
[Nullable(0)]
public abstract class ItemHintItemBase<T> : SliderItem
{
	// Token: 0x060100D3 RID: 65747 RVA: 0x003E9975 File Offset: 0x003E7B75
	public void SetShiftData([Nullable(new byte[]
	{
		1,
		2
	})] Func<T> shiftData)
	{
		this.ShiftData = shiftData;
	}

	// Token: 0x060100D4 RID: 65748 RVA: 0x003E9980 File Offset: 0x003E7B80
	public override UniTask AsyncLoadUiResource()
	{
		ItemHintItemBase<T>.<AsyncLoadUiResource>d__3 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemHintItemBase<T>.<AsyncLoadUiResource>d__3>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x060100D5 RID: 65749 RVA: 0x003E99C3 File Offset: 0x003E7BC3
	protected virtual UniTask OnRefresh(T data)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x040076BD RID: 30397
	protected T Data;

	// Token: 0x040076BE RID: 30398
	protected Func<T> ShiftData;
}

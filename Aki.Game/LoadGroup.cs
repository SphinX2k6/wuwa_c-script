using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200353C RID: 13628
[NullableContext(1)]
[Nullable(0)]
public class LoadGroup
{
	// Token: 0x17002978 RID: 10616
	// (get) Token: 0x0601DF02 RID: 122626 RVA: 0x00863B83 File Offset: 0x00861D83
	public string Name { get; }

	// Token: 0x0601DF03 RID: 122627 RVA: 0x00863B8B File Offset: 0x00861D8B
	public LoadGroup(string name)
	{
		this.Name = name;
	}

	// Token: 0x0601DF04 RID: 122628 RVA: 0x00863BB0 File Offset: 0x00861DB0
	[NullableContext(0)]
	public UniTask<bool> Run()
	{
		LoadGroup.<Run>d__6 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<LoadGroup.<Run>d__6>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x0601DF05 RID: 122629 RVA: 0x00863BF3 File Offset: 0x00861DF3
	[NullableContext(2)]
	public bool Add([Nullable(1)] string name, Func<bool> beforeHandle, [Nullable(new byte[]
	{
		1,
		0
	})] Func<UniTask<bool>> handle, Action<bool> afterHandle)
	{
		this.Handles.Add(new ValueTuple<string, Func<bool>, Func<UniTask<bool>>, Action<bool>>(name, beforeHandle, handle, afterHandle));
		return true;
	}

	// Token: 0x0400EB26 RID: 60198
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<UniTask<bool>> Promises = new List<UniTask<bool>>();

	// Token: 0x0400EB27 RID: 60199
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		2,
		1,
		0,
		2
	})]
	private readonly List<ValueTuple<string, Func<bool>, Func<UniTask<bool>>, Action<bool>>> Handles = new List<ValueTuple<string, Func<bool>, Func<UniTask<bool>>, Action<bool>>>();
}

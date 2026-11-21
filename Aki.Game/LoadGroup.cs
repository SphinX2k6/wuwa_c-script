using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AB1 RID: 10929
[NullableContext(1)]
[Nullable(0)]
public class LoadGroup
{
	// Token: 0x17002D11 RID: 11537
	// (get) Token: 0x0601BC2A RID: 113706 RVA: 0x0088B7BB File Offset: 0x008899BB
	public string Name { get; }

	// Token: 0x0601BC2B RID: 113707 RVA: 0x0088B7C3 File Offset: 0x008899C3
	public LoadGroup(string name)
	{
		this.Name = name;
	}

	// Token: 0x0601BC2C RID: 113708 RVA: 0x0088B7E8 File Offset: 0x008899E8
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

	// Token: 0x0601BC2D RID: 113709 RVA: 0x0088B82B File Offset: 0x00889A2B
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

	// Token: 0x0400EFE3 RID: 61411
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<UniTask<bool>> Promises = new List<UniTask<bool>>();

	// Token: 0x0400EFE4 RID: 61412
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

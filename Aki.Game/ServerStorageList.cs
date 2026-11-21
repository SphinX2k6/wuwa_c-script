using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02002A0F RID: 10767
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ServerStorageList : ServerStorageContainerEntry<List<int>>
{
	// Token: 0x0601B1F6 RID: 111094 RVA: 0x00852F30 File Offset: 0x00851130
	public ServerStorageList(EClientStorageSystemIdType key) : base(key)
	{
	}

	// Token: 0x0601B1F7 RID: 111095 RVA: 0x00852F39 File Offset: 0x00851139
	protected override List<int> CreateContainer()
	{
		return new List<int>();
	}

	// Token: 0x0601B1F8 RID: 111096 RVA: 0x00852F40 File Offset: 0x00851140
	public unsafe override void Serialize(ClientStorageInfo info)
	{
		if (info.ListData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ServerStorage;
			ELogAuthor author = ELogAuthor.BB;
			string message = "ServerStorageList Serialize error, Proto_ListData is null";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		List<int> container = base.GetContainer();
		container.Clear();
		container.AddRange(info.ListData.Data);
	}

	// Token: 0x0601B1F9 RID: 111097 RVA: 0x00852FD4 File Offset: 0x008511D4
	[NullableContext(2)]
	public override ClientStorageInfo Deserialize()
	{
		List<int> container = base.GetContainer();
		ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
		clientStorageInfo.ListData = new ClientStorageListData
		{
			Data = 
			{
				container
			}
		};
		return clientStorageInfo;
	}

	// Token: 0x0601B1FA RID: 111098 RVA: 0x0085300A File Offset: 0x0085120A
	public void Add(int value)
	{
		if (this.Has(value))
		{
			return;
		}
		base.GetContainer().Add(value);
		base.MarkDirty();
	}

	// Token: 0x0601B1FB RID: 111099 RVA: 0x00853028 File Offset: 0x00851228
	public void Remove(int value)
	{
		List<int> container = base.GetContainer();
		int num = container.IndexOf(value);
		if (num == -1)
		{
			return;
		}
		container.RemoveAt(num);
		base.MarkDirty();
	}

	// Token: 0x0601B1FC RID: 111100 RVA: 0x00853056 File Offset: 0x00851256
	public bool Has(int value)
	{
		return base.GetContainer().Contains(value);
	}

	// Token: 0x0601B1FD RID: 111101 RVA: 0x00853064 File Offset: 0x00851264
	public int Size()
	{
		return base.GetContainer().Count;
	}
}

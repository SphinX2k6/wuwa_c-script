using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200349B RID: 13467
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ServerStorageList : ServerStorageContainerEntry<List<int>>
{
	// Token: 0x0601D4FA RID: 120058 RVA: 0x0082BCCC File Offset: 0x00829ECC
	public ServerStorageList(EClientStorageSystemIdType key) : base(key)
	{
	}

	// Token: 0x0601D4FB RID: 120059 RVA: 0x0082BCD5 File Offset: 0x00829ED5
	protected override List<int> CreateContainer()
	{
		return new List<int>();
	}

	// Token: 0x0601D4FC RID: 120060 RVA: 0x0082BCDC File Offset: 0x00829EDC
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

	// Token: 0x0601D4FD RID: 120061 RVA: 0x0082BD70 File Offset: 0x00829F70
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

	// Token: 0x0601D4FE RID: 120062 RVA: 0x0082BDA6 File Offset: 0x00829FA6
	public void Add(int value)
	{
		if (this.Has(value))
		{
			return;
		}
		base.GetContainer().Add(value);
		base.MarkDirty();
	}

	// Token: 0x0601D4FF RID: 120063 RVA: 0x0082BDC4 File Offset: 0x00829FC4
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

	// Token: 0x0601D500 RID: 120064 RVA: 0x0082BDF2 File Offset: 0x00829FF2
	public bool Has(int value)
	{
		return base.GetContainer().Contains(value);
	}

	// Token: 0x0601D501 RID: 120065 RVA: 0x0082BE00 File Offset: 0x0082A000
	public int Size()
	{
		return base.GetContainer().Count;
	}
}

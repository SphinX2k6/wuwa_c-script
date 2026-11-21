using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034B5 RID: 13493
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ServerStorageSet : ServerStorageContainerEntry<HashSet<int>>
	{
		// Token: 0x060225C1 RID: 140737 RVA: 0x009BBBC1 File Offset: 0x009B9DC1
		public ServerStorageSet(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x060225C2 RID: 140738 RVA: 0x009BBBCA File Offset: 0x009B9DCA
		protected override HashSet<int> CreateContainer()
		{
			return new HashSet<int>();
		}

		// Token: 0x060225C3 RID: 140739 RVA: 0x009BBBD4 File Offset: 0x009B9DD4
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.SetData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageSet Serialize error, Proto_SetData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			HashSet<int> container = base.GetContainer();
			container.Clear();
			foreach (int item in info.SetData.Data)
			{
				container.Add(item);
			}
		}

		// Token: 0x060225C4 RID: 140740 RVA: 0x009BBCA0 File Offset: 0x009B9EA0
		[NullableContext(2)]
		public override ClientStorageInfo Deserialize()
		{
			HashSet<int> container = base.GetContainer();
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.SetData = new ClientStorageSetData();
			foreach (int item in container)
			{
				clientStorageInfo.SetData.Data.Add(item);
			}
			return clientStorageInfo;
		}

		// Token: 0x060225C5 RID: 140741 RVA: 0x009BBD18 File Offset: 0x009B9F18
		public void Add(int value)
		{
			if (this.Has(value))
			{
				return;
			}
			base.GetContainer().Add(value);
			base.MarkDirty();
		}

		// Token: 0x060225C6 RID: 140742 RVA: 0x009BBD37 File Offset: 0x009B9F37
		public void Remove(int value)
		{
			if (!this.Has(value))
			{
				return;
			}
			base.GetContainer().Remove(value);
			base.MarkDirty();
		}

		// Token: 0x060225C7 RID: 140743 RVA: 0x009BBD56 File Offset: 0x009B9F56
		public bool Has(int value)
		{
			return base.GetContainer().Contains(value);
		}

		// Token: 0x060225C8 RID: 140744 RVA: 0x009BBD64 File Offset: 0x009B9F64
		public int Size()
		{
			return base.GetContainer().Count;
		}

		// Token: 0x060225C9 RID: 140745 RVA: 0x009BBD74 File Offset: 0x009B9F74
		public void Overwrite(HashSet<int> values)
		{
			HashSet<int> container = base.GetContainer();
			container.Clear();
			foreach (int item in values)
			{
				container.Add(item);
			}
			base.MarkDirty();
		}
	}
}

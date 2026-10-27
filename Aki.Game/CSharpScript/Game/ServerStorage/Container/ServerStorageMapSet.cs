using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x0200458B RID: 17803
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ServerStorageMapSet : ServerStorageContainerEntry<Dictionary<int, HashSet<int>>>
	{
		// Token: 0x0602DECC RID: 188108 RVA: 0x00A8F5B9 File Offset: 0x00A8D7B9
		public ServerStorageMapSet(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DECD RID: 188109 RVA: 0x00A8F5C2 File Offset: 0x00A8D7C2
		protected override Dictionary<int, HashSet<int>> CreateContainer()
		{
			return new Dictionary<int, HashSet<int>>();
		}

		// Token: 0x0602DECE RID: 188110 RVA: 0x00A8F5CC File Offset: 0x00A8D7CC
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.MapListData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageMapSet Serialize error, Proto_MapListData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Dictionary<int, HashSet<int>> container = base.GetContainer();
			container.Clear();
			foreach (KeyValuePair<int, ClientStorageListData> keyValuePair in info.MapListData.Data)
			{
				ClientStorageListData value = keyValuePair.Value;
				if (((value != null) ? value.Data : null) != null)
				{
					int key = keyValuePair.Key;
					container[key] = new HashSet<int>(keyValuePair.Value.Data);
				}
			}
		}

		// Token: 0x0602DECF RID: 188111 RVA: 0x00A8F6C4 File Offset: 0x00A8D8C4
		[NullableContext(2)]
		public override ClientStorageInfo Deserialize()
		{
			Dictionary<int, HashSet<int>> container = base.GetContainer();
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.MapListData = new ClientStorageMapListData();
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in container)
			{
				int key = keyValuePair.Key;
				ClientStorageListData clientStorageListData = new ClientStorageListData();
				clientStorageInfo.MapListData.Data[key] = clientStorageListData;
				foreach (int item in keyValuePair.Value)
				{
					clientStorageListData.Data.Add(item);
				}
			}
			return clientStorageInfo;
		}

		// Token: 0x0602DED0 RID: 188112 RVA: 0x00A8F798 File Offset: 0x00A8D998
		public void Add(int key, int value1)
		{
			Dictionary<int, HashSet<int>> container = base.GetContainer();
			HashSet<int> hashSet;
			if (!container.TryGetValue(key, out hashSet))
			{
				container[key] = new HashSet<int>
				{
					value1
				};
				base.MarkDirty();
				return;
			}
			if (hashSet.Contains(value1))
			{
				return;
			}
			hashSet.Add(value1);
			base.MarkDirty();
		}

		// Token: 0x0602DED1 RID: 188113 RVA: 0x00A8F7EC File Offset: 0x00A8D9EC
		public void Remove(int key, int value1)
		{
			Dictionary<int, HashSet<int>> container = base.GetContainer();
			HashSet<int> hashSet;
			if (!container.TryGetValue(key, out hashSet))
			{
				return;
			}
			hashSet.Remove(value1);
			if (hashSet.Count == 0)
			{
				container.Remove(key);
			}
			base.MarkDirty();
		}

		// Token: 0x0602DED2 RID: 188114 RVA: 0x00A8F82C File Offset: 0x00A8DA2C
		public bool Has(int key, int value1)
		{
			HashSet<int> hashSet;
			return base.GetContainer().TryGetValue(key, out hashSet) && hashSet.Contains(value1);
		}

		// Token: 0x0602DED3 RID: 188115 RVA: 0x00A8F852 File Offset: 0x00A8DA52
		public int Size()
		{
			return base.GetContainer().Count;
		}
	}
}

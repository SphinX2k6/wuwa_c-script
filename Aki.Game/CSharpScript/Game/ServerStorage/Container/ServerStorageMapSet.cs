using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034B3 RID: 13491
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ServerStorageMapSet : ServerStorageContainerEntry<Dictionary<int, HashSet<int>>>
	{
		// Token: 0x060225B6 RID: 140726 RVA: 0x009BB7D9 File Offset: 0x009B99D9
		public ServerStorageMapSet(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x060225B7 RID: 140727 RVA: 0x009BB7E2 File Offset: 0x009B99E2
		protected override Dictionary<int, HashSet<int>> CreateContainer()
		{
			return new Dictionary<int, HashSet<int>>();
		}

		// Token: 0x060225B8 RID: 140728 RVA: 0x009BB7EC File Offset: 0x009B99EC
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

		// Token: 0x060225B9 RID: 140729 RVA: 0x009BB8E4 File Offset: 0x009B9AE4
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

		// Token: 0x060225BA RID: 140730 RVA: 0x009BB9B8 File Offset: 0x009B9BB8
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

		// Token: 0x060225BB RID: 140731 RVA: 0x009BBA0C File Offset: 0x009B9C0C
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

		// Token: 0x060225BC RID: 140732 RVA: 0x009BBA4C File Offset: 0x009B9C4C
		public bool Has(int key, int value1)
		{
			HashSet<int> hashSet;
			return base.GetContainer().TryGetValue(key, out hashSet) && hashSet.Contains(value1);
		}

		// Token: 0x060225BD RID: 140733 RVA: 0x009BBA72 File Offset: 0x009B9C72
		public int Size()
		{
			return base.GetContainer().Count;
		}
	}
}

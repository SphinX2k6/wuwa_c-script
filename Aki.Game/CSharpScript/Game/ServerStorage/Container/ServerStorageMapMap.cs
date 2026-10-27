using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x0200458A RID: 17802
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ServerStorageMapMap : ServerStorageContainerEntry<Dictionary<int, Dictionary<int, int>>>
	{
		// Token: 0x0602DEC4 RID: 188100 RVA: 0x00A8F284 File Offset: 0x00A8D484
		public ServerStorageMapMap(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DEC5 RID: 188101 RVA: 0x00A8F28D File Offset: 0x00A8D48D
		protected override Dictionary<int, Dictionary<int, int>> CreateContainer()
		{
			return new Dictionary<int, Dictionary<int, int>>();
		}

		// Token: 0x0602DEC6 RID: 188102 RVA: 0x00A8F294 File Offset: 0x00A8D494
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.MapMapData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageMapMap Serialize error, Proto_MapMapData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Dictionary<int, Dictionary<int, int>> container = base.GetContainer();
			container.Clear();
			foreach (KeyValuePair<int, ClientStorageMapData> keyValuePair in info.MapMapData.Data)
			{
				ClientStorageMapData value = keyValuePair.Value;
				if (((value != null) ? value.Data : null) != null)
				{
					int key = keyValuePair.Key;
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					foreach (KeyValuePair<int, int> keyValuePair2 in keyValuePair.Value.Data)
					{
						int key2 = keyValuePair2.Key;
						dictionary[key2] = keyValuePair2.Value;
					}
					container[key] = dictionary;
				}
			}
		}

		// Token: 0x0602DEC7 RID: 188103 RVA: 0x00A8F3E4 File Offset: 0x00A8D5E4
		[NullableContext(2)]
		public override ClientStorageInfo Deserialize()
		{
			Dictionary<int, Dictionary<int, int>> container = base.GetContainer();
			if (container.Count == 0)
			{
				return null;
			}
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.MapMapData = new ClientStorageMapMapData();
			foreach (KeyValuePair<int, Dictionary<int, int>> keyValuePair in container)
			{
				MapField<int, ClientStorageMapData> data = clientStorageInfo.MapMapData.Data;
				ClientStorageMapData clientStorageMapData;
				if (!data.TryGetValue(keyValuePair.Key, out clientStorageMapData))
				{
					clientStorageMapData = new ClientStorageMapData();
					data[keyValuePair.Key] = clientStorageMapData;
				}
				foreach (KeyValuePair<int, int> keyValuePair2 in keyValuePair.Value)
				{
					clientStorageMapData.Data[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
			return clientStorageInfo;
		}

		// Token: 0x0602DEC8 RID: 188104 RVA: 0x00A8F4E8 File Offset: 0x00A8D6E8
		public void Set(int key, int innerKey, int value)
		{
			Dictionary<int, Dictionary<int, int>> container = base.GetContainer();
			Dictionary<int, int> dictionary;
			if (!container.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<int, int>();
				container[key] = dictionary;
			}
			int num;
			if (dictionary.TryGetValue(innerKey, out num) && num == value)
			{
				return;
			}
			dictionary[innerKey] = value;
			base.MarkDirty();
		}

		// Token: 0x0602DEC9 RID: 188105 RVA: 0x00A8F534 File Offset: 0x00A8D734
		public void Remove(int outerKey, int innerKey)
		{
			Dictionary<int, Dictionary<int, int>> container = base.GetContainer();
			Dictionary<int, int> dictionary;
			if (!container.TryGetValue(outerKey, out dictionary))
			{
				return;
			}
			if (!dictionary.Remove(innerKey))
			{
				return;
			}
			if (dictionary.Count == 0)
			{
				container.Remove(outerKey);
			}
			base.MarkDirty();
		}

		// Token: 0x0602DECA RID: 188106 RVA: 0x00A8F574 File Offset: 0x00A8D774
		public int? Get(int outerKey, int innerKey)
		{
			Dictionary<int, int> dictionary;
			int value;
			if (base.GetContainer().TryGetValue(outerKey, out dictionary) && dictionary.TryGetValue(innerKey, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0602DECB RID: 188107 RVA: 0x00A8F5AC File Offset: 0x00A8D7AC
		public int Size()
		{
			return base.GetContainer().Count;
		}
	}
}

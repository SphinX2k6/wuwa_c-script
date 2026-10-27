using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x02004589 RID: 17801
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ServerStorageMap : ServerStorageContainerEntry<Dictionary<int, int>>
	{
		// Token: 0x0602DEBA RID: 188090 RVA: 0x00A8F00D File Offset: 0x00A8D20D
		public ServerStorageMap(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DEBB RID: 188091 RVA: 0x00A8F016 File Offset: 0x00A8D216
		protected override Dictionary<int, int> CreateContainer()
		{
			return new Dictionary<int, int>();
		}

		// Token: 0x0602DEBC RID: 188092 RVA: 0x00A8F020 File Offset: 0x00A8D220
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.MapData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageMapData Serialize error, Proto_MapData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Dictionary<int, int> container = base.GetContainer();
			container.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in info.MapData.Data)
			{
				int key = keyValuePair.Key;
				container[key] = keyValuePair.Value;
			}
		}

		// Token: 0x0602DEBD RID: 188093 RVA: 0x00A8F0FC File Offset: 0x00A8D2FC
		[NullableContext(2)]
		public override ClientStorageInfo Deserialize()
		{
			Dictionary<int, int> container = base.GetContainer();
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.MapData = new ClientStorageMapData();
			foreach (KeyValuePair<int, int> keyValuePair in container)
			{
				clientStorageInfo.MapData.Data.Add(keyValuePair.Key, keyValuePair.Value);
			}
			return clientStorageInfo;
		}

		// Token: 0x0602DEBE RID: 188094 RVA: 0x00A8F180 File Offset: 0x00A8D380
		public void Set(int key, int value)
		{
			Dictionary<int, int> container = base.GetContainer();
			int num;
			if (container.TryGetValue(key, out num) && num == value)
			{
				return;
			}
			container[key] = value;
			base.MarkDirty();
		}

		// Token: 0x0602DEBF RID: 188095 RVA: 0x00A8F1B2 File Offset: 0x00A8D3B2
		public void Delete(int key)
		{
			if (!base.GetContainer().Remove(key))
			{
				return;
			}
			base.MarkDirty();
		}

		// Token: 0x0602DEC0 RID: 188096 RVA: 0x00A8F1CC File Offset: 0x00A8D3CC
		public int? Get(int key)
		{
			int value;
			if (base.GetContainer().TryGetValue(key, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0602DEC1 RID: 188097 RVA: 0x00A8F1F9 File Offset: 0x00A8D3F9
		public bool Has(int key)
		{
			return base.GetContainer().ContainsKey(key);
		}

		// Token: 0x0602DEC2 RID: 188098 RVA: 0x00A8F207 File Offset: 0x00A8D407
		public int Size()
		{
			return base.GetContainer().Count;
		}

		// Token: 0x0602DEC3 RID: 188099 RVA: 0x00A8F214 File Offset: 0x00A8D414
		public void Overwrite(Dictionary<int, int> values)
		{
			Dictionary<int, int> container = base.GetContainer();
			container.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in values)
			{
				container[keyValuePair.Key] = keyValuePair.Value;
			}
			base.MarkDirty();
		}
	}
}

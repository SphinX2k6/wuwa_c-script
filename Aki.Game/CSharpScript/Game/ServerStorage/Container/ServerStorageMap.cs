using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034B1 RID: 13489
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ServerStorageMap : ServerStorageContainerEntry<Dictionary<int, int>>
	{
		// Token: 0x060225A4 RID: 140708 RVA: 0x009BB22D File Offset: 0x009B942D
		public ServerStorageMap(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x060225A5 RID: 140709 RVA: 0x009BB236 File Offset: 0x009B9436
		protected override Dictionary<int, int> CreateContainer()
		{
			return new Dictionary<int, int>();
		}

		// Token: 0x060225A6 RID: 140710 RVA: 0x009BB240 File Offset: 0x009B9440
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

		// Token: 0x060225A7 RID: 140711 RVA: 0x009BB31C File Offset: 0x009B951C
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

		// Token: 0x060225A8 RID: 140712 RVA: 0x009BB3A0 File Offset: 0x009B95A0
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

		// Token: 0x060225A9 RID: 140713 RVA: 0x009BB3D2 File Offset: 0x009B95D2
		public void Delete(int key)
		{
			if (!base.GetContainer().Remove(key))
			{
				return;
			}
			base.MarkDirty();
		}

		// Token: 0x060225AA RID: 140714 RVA: 0x009BB3EC File Offset: 0x009B95EC
		public int? Get(int key)
		{
			int value;
			if (base.GetContainer().TryGetValue(key, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060225AB RID: 140715 RVA: 0x009BB419 File Offset: 0x009B9619
		public bool Has(int key)
		{
			return base.GetContainer().ContainsKey(key);
		}

		// Token: 0x060225AC RID: 140716 RVA: 0x009BB427 File Offset: 0x009B9627
		public int Size()
		{
			return base.GetContainer().Count;
		}

		// Token: 0x060225AD RID: 140717 RVA: 0x009BB434 File Offset: 0x009B9634
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

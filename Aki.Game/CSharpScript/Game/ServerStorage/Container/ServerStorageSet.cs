using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x0200458D RID: 17805
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ServerStorageSet : ServerStorageContainerEntry<HashSet<int>>
	{
		// Token: 0x0602DED7 RID: 188119 RVA: 0x00A8F9A1 File Offset: 0x00A8DBA1
		public ServerStorageSet(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DED8 RID: 188120 RVA: 0x00A8F9AA File Offset: 0x00A8DBAA
		protected override HashSet<int> CreateContainer()
		{
			return new HashSet<int>();
		}

		// Token: 0x0602DED9 RID: 188121 RVA: 0x00A8F9B4 File Offset: 0x00A8DBB4
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

		// Token: 0x0602DEDA RID: 188122 RVA: 0x00A8FA80 File Offset: 0x00A8DC80
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

		// Token: 0x0602DEDB RID: 188123 RVA: 0x00A8FAF8 File Offset: 0x00A8DCF8
		public void Add(int value)
		{
			if (this.Has(value))
			{
				return;
			}
			base.GetContainer().Add(value);
			base.MarkDirty();
		}

		// Token: 0x0602DEDC RID: 188124 RVA: 0x00A8FB17 File Offset: 0x00A8DD17
		public void Remove(int value)
		{
			if (!this.Has(value))
			{
				return;
			}
			base.GetContainer().Remove(value);
			base.MarkDirty();
		}

		// Token: 0x0602DEDD RID: 188125 RVA: 0x00A8FB36 File Offset: 0x00A8DD36
		public bool Has(int value)
		{
			return base.GetContainer().Contains(value);
		}

		// Token: 0x0602DEDE RID: 188126 RVA: 0x00A8FB44 File Offset: 0x00A8DD44
		public int Size()
		{
			return base.GetContainer().Count;
		}

		// Token: 0x0602DEDF RID: 188127 RVA: 0x00A8FB54 File Offset: 0x00A8DD54
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

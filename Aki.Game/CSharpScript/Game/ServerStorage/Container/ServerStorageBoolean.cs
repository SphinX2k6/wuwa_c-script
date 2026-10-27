using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x02004585 RID: 17797
	public class ServerStorageBoolean : ServerStorageValueEntry<bool?>
	{
		// Token: 0x0602DEAD RID: 188077 RVA: 0x00A8ED38 File Offset: 0x00A8CF38
		public ServerStorageBoolean(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DEAE RID: 188078 RVA: 0x00A8ED44 File Offset: 0x00A8CF44
		[NullableContext(1)]
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.BoolData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageBoolean Serialize error, Proto_BoolData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.Data = new bool?(info.BoolData.Data);
		}

		// Token: 0x0602DEAF RID: 188079 RVA: 0x00A8EDD0 File Offset: 0x00A8CFD0
		[NullableContext(2)]
		public unsafe override ClientStorageInfo Deserialize()
		{
			if (this.Data == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageBoolean Deserialize error, Data is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", this.Data);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.BoolData = new ClientStorageBoolData
			{
				Data = this.Data.Value
			};
			return clientStorageInfo;
		}
	}
}

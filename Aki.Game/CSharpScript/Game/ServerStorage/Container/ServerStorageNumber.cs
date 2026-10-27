using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x0200458C RID: 17804
	public class ServerStorageNumber : ServerStorageValueEntry<int?>
	{
		// Token: 0x0602DED4 RID: 188116 RVA: 0x00A8F85F File Offset: 0x00A8DA5F
		public ServerStorageNumber(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DED5 RID: 188117 RVA: 0x00A8F868 File Offset: 0x00A8DA68
		[NullableContext(1)]
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.IntData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageNumber Serialize error, Proto_IntData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.Data = new int?(info.IntData.Data);
		}

		// Token: 0x0602DED6 RID: 188118 RVA: 0x00A8F8F4 File Offset: 0x00A8DAF4
		[NullableContext(2)]
		public unsafe override ClientStorageInfo Deserialize()
		{
			if (this.Data == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageNumber Deserialize error, Data is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", this.Data);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.IntData = new ClientStorageIntData
			{
				Data = this.Data.Value
			};
			return clientStorageInfo;
		}
	}
}

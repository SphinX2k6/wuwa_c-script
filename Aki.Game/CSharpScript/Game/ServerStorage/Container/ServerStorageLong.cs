using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x02004588 RID: 17800
	public class ServerStorageLong : ServerStorageValueEntry<long?>
	{
		// Token: 0x0602DEB7 RID: 188087 RVA: 0x00A8EEC8 File Offset: 0x00A8D0C8
		public ServerStorageLong(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0602DEB8 RID: 188088 RVA: 0x00A8EED4 File Offset: 0x00A8D0D4
		[NullableContext(1)]
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.LongData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageLong Serialize error, Proto_LongData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.Data = new long?(info.LongData.Data);
		}

		// Token: 0x0602DEB9 RID: 188089 RVA: 0x00A8EF60 File Offset: 0x00A8D160
		[NullableContext(2)]
		public unsafe override ClientStorageInfo Deserialize()
		{
			if (this.Data == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageLong Deserialize error, Data is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", this.Data);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.LongData = new ClientStorageLongData
			{
				Data = this.Data.Value
			};
			return clientStorageInfo;
		}
	}
}

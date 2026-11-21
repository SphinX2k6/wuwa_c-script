using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034B6 RID: 13494
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ServerStorageString : ServerStorageValueEntry<string>
	{
		// Token: 0x060225CA RID: 140746 RVA: 0x009BBDD8 File Offset: 0x009B9FD8
		public ServerStorageString(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x060225CB RID: 140747 RVA: 0x009BBDE4 File Offset: 0x009B9FE4
		public unsafe override void Serialize(ClientStorageInfo info)
		{
			if (info.StringData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageString Serialize error, Proto_StringData is null";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", this.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", info);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.Data = info.StringData.Data;
		}

		// Token: 0x060225CC RID: 140748 RVA: 0x009BBE6C File Offset: 0x009BA06C
		[NullableContext(2)]
		public override ClientStorageInfo Deserialize()
		{
			if (this.Data == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorageString Deserialize error, Data is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", this.Key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			ClientStorageInfo clientStorageInfo = ServerStorageUtil.CreateDefaultStorageInfo((int)this.Key);
			clientStorageInfo.StringData = new ClientStorageStringData
			{
				Data = this.Data
			};
			return clientStorageInfo;
		}
	}
}

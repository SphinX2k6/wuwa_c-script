using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Common.Proxy
{
	// Token: 0x02000020 RID: 32
	public interface IDeserializeConfigProxy
	{
		// Token: 0x0600014C RID: 332
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		DeserializeConfigResult<string> ParseStringRange(byte[] buffer, int begin, int size, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x0600014D RID: 333
		DeserializeConfigResult<int> ParseInt([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x0600014E RID: 334
		DeserializeConfigResult<float> ParseFloat([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x0600014F RID: 335
		DeserializeConfigResult<long> ParseBigInt([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x06000150 RID: 336
		DeserializeConfigResult<bool> ParseBoolean([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x06000151 RID: 337
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		DeserializeConfigResult<string> ParseString(byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);
	}
}

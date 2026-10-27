using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Common.Proxy
{
	// Token: 0x0200001F RID: 31
	public interface IDeserializeConfigProxy
	{
		// Token: 0x060000DF RID: 223
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

		// Token: 0x060000E0 RID: 224
		DeserializeConfigResult<int> ParseInt([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x060000E1 RID: 225
		DeserializeConfigResult<float> ParseFloat([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x060000E2 RID: 226
		DeserializeConfigResult<long> ParseBigInt([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x060000E3 RID: 227
		DeserializeConfigResult<bool> ParseBoolean([Nullable(1)] byte[] buffer, int startIndex = 0, [ParamCollection] [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x060000E4 RID: 228
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

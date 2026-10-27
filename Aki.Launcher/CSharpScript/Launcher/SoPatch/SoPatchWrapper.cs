using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x0200010A RID: 266
	public class SoPatchWrapper
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x0003F85C File Offset: 0x0003DA5C
		[NullableContext(1)]
		[return: TupleElementNames(new string[]
		{
			"IsSuccess",
			"Message"
		})]
		[return: Nullable(new byte[]
		{
			0,
			0,
			1
		})]
		public static UniTask<ValueTuple<bool, string>> LoadPatch(string patch)
		{
			SoPatchWrapper.<LoadPatch>d__0 <LoadPatch>d__;
			<LoadPatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, string>>.Create();
			<LoadPatch>d__.patch = patch;
			<LoadPatch>d__.<>1__state = -1;
			<LoadPatch>d__.<>t__builder.Start<SoPatchWrapper.<LoadPatch>d__0>(ref <LoadPatch>d__);
			return <LoadPatch>d__.<>t__builder.Task;
		}
	}
}

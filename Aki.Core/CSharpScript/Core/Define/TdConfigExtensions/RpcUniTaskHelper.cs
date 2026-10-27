using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000141 RID: 321
	[NullableContext(2)]
	[Nullable(0)]
	public static class RpcUniTaskHelper
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x00036490 File Offset: 0x00034690
		public static bool IsPending(object result)
		{
			bool flag = result is UniTask || result is UniTask<object>;
			if (flag)
			{
				return true;
			}
			if (result == null)
			{
				return false;
			}
			Type type = result.GetType();
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(UniTask<>);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000364E4 File Offset: 0x000346E4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<object> Await(object result)
		{
			RpcUniTaskHelper.<Await>d__2 <Await>d__;
			<Await>d__.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
			<Await>d__.result = result;
			<Await>d__.<>1__state = -1;
			<Await>d__.<>t__builder.Start<RpcUniTaskHelper.<Await>d__2>(ref <Await>d__);
			return <Await>d__.<>t__builder.Task;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00036528 File Offset: 0x00034728
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<object> AwaitGeneric(object uniTask)
		{
			Type type = uniTask.GetType().GetGenericArguments()[0];
			return (UniTask<object>)RpcUniTaskHelper.AwaitGenericMethod.MakeGenericMethod(new Type[]
			{
				type
			}).Invoke(null, new object[]
			{
				uniTask
			});
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0003656C File Offset: 0x0003476C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<object> AwaitGenericImpl<T>([Nullable(new byte[]
		{
			0,
			1
		})] UniTask<T> task)
		{
			RpcUniTaskHelper.<AwaitGenericImpl>d__4<T> <AwaitGenericImpl>d__;
			<AwaitGenericImpl>d__.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
			<AwaitGenericImpl>d__.task = task;
			<AwaitGenericImpl>d__.<>1__state = -1;
			<AwaitGenericImpl>d__.<>t__builder.Start<RpcUniTaskHelper.<AwaitGenericImpl>d__4<T>>(ref <AwaitGenericImpl>d__);
			return <AwaitGenericImpl>d__.<>t__builder.Task;
		}

		// Token: 0x040006E0 RID: 1760
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly MethodInfo AwaitGenericMethod = typeof(RpcUniTaskHelper).GetMethod("AwaitGenericImpl", BindingFlags.Static | BindingFlags.NonPublic);
	}
}

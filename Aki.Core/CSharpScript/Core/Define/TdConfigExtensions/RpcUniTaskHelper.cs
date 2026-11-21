using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000145 RID: 325
	[NullableContext(2)]
	[Nullable(0)]
	public static class RpcUniTaskHelper
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x00037010 File Offset: 0x00035210
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x00037064 File Offset: 0x00035264
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

		// Token: 0x06000B94 RID: 2964 RVA: 0x000370A8 File Offset: 0x000352A8
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

		// Token: 0x06000B95 RID: 2965 RVA: 0x000370EC File Offset: 0x000352EC
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

		// Token: 0x040006EE RID: 1774
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly MethodInfo AwaitGenericMethod = typeof(RpcUniTaskHelper).GetMethod("AwaitGenericImpl", BindingFlags.Static | BindingFlags.NonPublic);
	}
}

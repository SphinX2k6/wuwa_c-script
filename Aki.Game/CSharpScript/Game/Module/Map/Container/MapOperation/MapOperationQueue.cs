using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Container.MapOperation
{
	// Token: 0x02005595 RID: 21909
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MapOperationQueue
	{
		// Token: 0x06037D78 RID: 228728 RVA: 0x00D3C4F4 File Offset: 0x00D3A6F4
		public static void Run(IMapOperation op)
		{
			MapOperationQueue.<>c__DisplayClass1_0 CS$<>8__locals1 = new MapOperationQueue.<>c__DisplayClass1_0();
			CS$<>8__locals1.op = op;
			UiAsyncTask task = new UiAsyncTask("MapOperationQueue." + CS$<>8__locals1.op.OpName, delegate()
			{
				MapOperationQueue.<>c__DisplayClass1_0.<<Run>b__0>d <<Run>b__0>d;
				<<Run>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Run>b__0>d.<>4__this = CS$<>8__locals1;
				<<Run>b__0>d.<>1__state = -1;
				<<Run>b__0>d.<>t__builder.Start<MapOperationQueue.<>c__DisplayClass1_0.<<Run>b__0>d>(ref <<Run>b__0>d);
				return <<Run>b__0>d.<>t__builder.Task;
			}, null);
			MapOperationQueue.AsyncTaskManager.RunTask(task);
		}

		// Token: 0x06037D79 RID: 228729 RVA: 0x00D3C544 File Offset: 0x00D3A744
		public static void RunMapMark(IMapMarkOperation op)
		{
			if (op.OpName == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int?>(op.MarkId);
				defaultInterpolatedStringHandler.AppendLiteral(".");
				defaultInterpolatedStringHandler.AppendFormatted<EMarkType>(op.MarkType);
				op.OpName = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			MapOperationQueue.Run(op);
		}

		// Token: 0x06037D7A RID: 228730 RVA: 0x00D3C59F File Offset: 0x00D3A79F
		public static void Clear()
		{
			MapOperationQueue.AsyncTaskManager.CancelAllTask();
		}

		// Token: 0x0401D573 RID: 120179
		private static readonly UiAsyncTaskManager AsyncTaskManager = new UiAsyncTaskManager();
	}
}

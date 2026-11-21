using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Container.MapOperation
{
	// Token: 0x0200456B RID: 17771
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class MapOperationQueue
	{
		// Token: 0x0602CC76 RID: 183414 RVA: 0x00C8A23C File Offset: 0x00C8843C
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

		// Token: 0x0602CC77 RID: 183415 RVA: 0x00C8A28C File Offset: 0x00C8848C
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

		// Token: 0x0602CC78 RID: 183416 RVA: 0x00C8A2E7 File Offset: 0x00C884E7
		public static void Clear()
		{
			MapOperationQueue.AsyncTaskManager.CancelAllTask();
		}

		// Token: 0x04017FFE RID: 98302
		private static readonly UiAsyncTaskManager AsyncTaskManager = new UiAsyncTaskManager();
	}
}

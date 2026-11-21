using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2E RID: 15150
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGridColumn
	{
		// Token: 0x06026F34 RID: 159540 RVA: 0x00AE6B21 File Offset: 0x00AE4D21
		public TetrisGridColumn(SlidingBlocksGameData gameData, double columnIndex)
		{
		}

		// Token: 0x06026F35 RID: 159541 RVA: 0x00AE6B50 File Offset: 0x00AE4D50
		public void Clear()
		{
			foreach (KeyValuePair<double, Mino> keyValuePair in this.MinoDataMap)
			{
				SlidingBlocksUtil.DestroyCube(keyValuePair.Value.CubeActor);
			}
			this.MinoDataMap.Clear();
		}

		// Token: 0x06026F36 RID: 159542 RVA: 0x00AE6BBC File Offset: 0x00AE4DBC
		public unsafe bool AddData(double y, Mino minoData)
		{
			if (this.MinoDataMap.TryAdd(y, minoData))
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SlidingBlocks;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "AddColumnFailed:重复添加";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("x", this.ColumnIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("y", y);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x06026F37 RID: 159543 RVA: 0x00AE6C40 File Offset: 0x00AE4E40
		public bool RemoveData(double y)
		{
			return this.MinoDataMap.Remove(y);
		}

		// Token: 0x06026F38 RID: 159544 RVA: 0x00AE6C50 File Offset: 0x00AE4E50
		public bool CheckOccupied(double y)
		{
			double key = SlidingBlocksUtil.MapToHalfInteger(y);
			return this.MinoDataMap.ContainsKey(key);
		}

		// Token: 0x06026F39 RID: 159545 RVA: 0x00AE6C70 File Offset: 0x00AE4E70
		public double FindUnoccupiedGrid(double y)
		{
			double num = SlidingBlocksUtil.MapToHalfInteger(y);
			bool flag = true;
			while (flag)
			{
				flag = this.MinoDataMap.ContainsKey(num);
				num -= 1.0;
			}
			return num + 1.0;
		}

		// Token: 0x06026F3A RID: 159546 RVA: 0x00AE6CB4 File Offset: 0x00AE4EB4
		public UniTask TryFall(List<double> clearLineIndexArr)
		{
			TetrisGridColumn.<TryFall>d__10 <TryFall>d__;
			<TryFall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryFall>d__.<>4__this = this;
			<TryFall>d__.clearLineIndexArr = clearLineIndexArr;
			<TryFall>d__.<>1__state = -1;
			<TryFall>d__.<>t__builder.Start<TetrisGridColumn.<TryFall>d__10>(ref <TryFall>d__);
			return <TryFall>d__.<>t__builder.Task;
		}

		// Token: 0x06026F3B RID: 159547 RVA: 0x00AE6D00 File Offset: 0x00AE4F00
		private UniTask SingleMinoTryFall(Mino mino, double targetY)
		{
			TetrisGridColumn.<SingleMinoTryFall>d__11 <SingleMinoTryFall>d__;
			<SingleMinoTryFall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SingleMinoTryFall>d__.<>4__this = this;
			<SingleMinoTryFall>d__.mino = mino;
			<SingleMinoTryFall>d__.targetY = targetY;
			<SingleMinoTryFall>d__.<>1__state = -1;
			<SingleMinoTryFall>d__.<>t__builder.Start<TetrisGridColumn.<SingleMinoTryFall>d__11>(ref <SingleMinoTryFall>d__);
			return <SingleMinoTryFall>d__.<>t__builder.Task;
		}

		// Token: 0x06026F3C RID: 159548 RVA: 0x00AE6D54 File Offset: 0x00AE4F54
		public void DrawDebug(FLinearColor color)
		{
			foreach (KeyValuePair<double, Mino> keyValuePair in this.MinoDataMap)
			{
				UObject world = GlobalData.World;
				FVectorDouble textLocation = keyValuePair.Value.CubeActor.D_K2_GetActorLocation();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("x:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(keyValuePair.Value.Coord.X, "F2");
				UKismetSystemLibrary.D_DrawDebugString(world, textLocation, defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(color), 0f);
			}
		}

		// Token: 0x04015470 RID: 87152
		private readonly Dictionary<double, Mino> MinoDataMap = new Dictionary<double, Mino>();

		// Token: 0x04015471 RID: 87153
		private readonly Dictionary<Mino, int> RecordFallStep = new Dictionary<Mino, int>();

		// Token: 0x04015472 RID: 87154
		public readonly SlidingBlocksGameData GameData = gameData;

		// Token: 0x04015473 RID: 87155
		public readonly double ColumnIndex = columnIndex;
	}
}

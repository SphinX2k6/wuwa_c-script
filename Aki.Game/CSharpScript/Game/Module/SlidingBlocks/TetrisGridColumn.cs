using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B84 RID: 19332
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGridColumn
	{
		// Token: 0x060321A3 RID: 205219 RVA: 0x00BA2995 File Offset: 0x00BA0B95
		public TetrisGridColumn(SlidingBlocksGameData gameData, double columnIndex)
		{
		}

		// Token: 0x060321A4 RID: 205220 RVA: 0x00BA29C4 File Offset: 0x00BA0BC4
		public void Clear()
		{
			foreach (KeyValuePair<double, Mino> keyValuePair in this.MinoDataMap)
			{
				SlidingBlocksUtil.DestroyCube(keyValuePair.Value.CubeActor);
			}
			this.MinoDataMap.Clear();
		}

		// Token: 0x060321A5 RID: 205221 RVA: 0x00BA2A30 File Offset: 0x00BA0C30
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

		// Token: 0x060321A6 RID: 205222 RVA: 0x00BA2AB4 File Offset: 0x00BA0CB4
		public bool RemoveData(double y)
		{
			return this.MinoDataMap.Remove(y);
		}

		// Token: 0x060321A7 RID: 205223 RVA: 0x00BA2AC4 File Offset: 0x00BA0CC4
		public bool CheckOccupied(double y)
		{
			double key = SlidingBlocksUtil.MapToHalfInteger(y);
			return this.MinoDataMap.ContainsKey(key);
		}

		// Token: 0x060321A8 RID: 205224 RVA: 0x00BA2AE4 File Offset: 0x00BA0CE4
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

		// Token: 0x060321A9 RID: 205225 RVA: 0x00BA2B28 File Offset: 0x00BA0D28
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

		// Token: 0x060321AA RID: 205226 RVA: 0x00BA2B74 File Offset: 0x00BA0D74
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

		// Token: 0x060321AB RID: 205227 RVA: 0x00BA2BC8 File Offset: 0x00BA0DC8
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

		// Token: 0x0401AB1C RID: 109340
		private readonly Dictionary<double, Mino> MinoDataMap = new Dictionary<double, Mino>();

		// Token: 0x0401AB1D RID: 109341
		private readonly Dictionary<Mino, int> RecordFallStep = new Dictionary<Mino, int>();

		// Token: 0x0401AB1E RID: 109342
		public readonly SlidingBlocksGameData GameData = gameData;

		// Token: 0x0401AB1F RID: 109343
		public readonly double ColumnIndex = columnIndex;
	}
}

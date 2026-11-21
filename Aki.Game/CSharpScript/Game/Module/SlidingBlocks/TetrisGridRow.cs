using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2F RID: 15151
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGridRow
	{
		// Token: 0x06026F3D RID: 159549 RVA: 0x00AE6E00 File Offset: 0x00AE5000
		public TetrisGridRow(SlidingBlocksGameData gameData, double rowIndex, double rowSize)
		{
		}

		// Token: 0x06026F3E RID: 159550 RVA: 0x00AE6E33 File Offset: 0x00AE5033
		public void Clear()
		{
			this.MinoDataMap.Clear();
		}

		// Token: 0x06026F3F RID: 159551 RVA: 0x00AE6E40 File Offset: 0x00AE5040
		public bool AddData(double x, Mino minoData)
		{
			this.MinoDataMap[x] = minoData;
			return true;
		}

		// Token: 0x06026F40 RID: 159552 RVA: 0x00AE6E50 File Offset: 0x00AE5050
		public bool RemoveData(double x)
		{
			return this.MinoDataMap.Remove(x);
		}

		// Token: 0x06026F41 RID: 159553 RVA: 0x00AE6E5E File Offset: 0x00AE505E
		public bool CheckCanLineClear()
		{
			return (double)this.MinoDataMap.Count >= this.RowSize;
		}

		// Token: 0x06026F42 RID: 159554 RVA: 0x00AE6E78 File Offset: 0x00AE5078
		public UniTask TryExecuteLineClear(SlidingBlocksGameData gameData)
		{
			TetrisGridRow.<TryExecuteLineClear>d__10 <TryExecuteLineClear>d__;
			<TryExecuteLineClear>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryExecuteLineClear>d__.<>4__this = this;
			<TryExecuteLineClear>d__.gameData = gameData;
			<TryExecuteLineClear>d__.<>1__state = -1;
			<TryExecuteLineClear>d__.<>t__builder.Start<TetrisGridRow.<TryExecuteLineClear>d__10>(ref <TryExecuteLineClear>d__);
			return <TryExecuteLineClear>d__.<>t__builder.Task;
		}

		// Token: 0x06026F43 RID: 159555 RVA: 0x00AE6EC3 File Offset: 0x00AE50C3
		public bool CheckEmpty()
		{
			return this.MinoDataMap.Count == 0;
		}

		// Token: 0x06026F44 RID: 159556 RVA: 0x00AE6ED4 File Offset: 0x00AE50D4
		[NullableContext(0)]
		private UniTask<int> SpawnLineClearEffect()
		{
			TetrisGridRow.<SpawnLineClearEffect>d__12 <SpawnLineClearEffect>d__;
			<SpawnLineClearEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<SpawnLineClearEffect>d__.<>4__this = this;
			<SpawnLineClearEffect>d__.<>1__state = -1;
			<SpawnLineClearEffect>d__.<>t__builder.Start<TetrisGridRow.<SpawnLineClearEffect>d__12>(ref <SpawnLineClearEffect>d__);
			return <SpawnLineClearEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06026F45 RID: 159557 RVA: 0x00AE6F18 File Offset: 0x00AE5118
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<ItemMaterialControllerActorData> LoadCubeDestroyEffectAsync([Nullable(2)] string path, Action<ItemMaterialControllerActorData> callback)
		{
			TetrisGridRow.<LoadCubeDestroyEffectAsync>d__13 <LoadCubeDestroyEffectAsync>d__;
			<LoadCubeDestroyEffectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ItemMaterialControllerActorData>.Create();
			<LoadCubeDestroyEffectAsync>d__.path = path;
			<LoadCubeDestroyEffectAsync>d__.callback = callback;
			<LoadCubeDestroyEffectAsync>d__.<>1__state = -1;
			<LoadCubeDestroyEffectAsync>d__.<>t__builder.Start<TetrisGridRow.<LoadCubeDestroyEffectAsync>d__13>(ref <LoadCubeDestroyEffectAsync>d__);
			return <LoadCubeDestroyEffectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026F46 RID: 159558 RVA: 0x00AE6F64 File Offset: 0x00AE5164
		public void DrawDebug(FLinearColor color)
		{
			foreach (KeyValuePair<double, Mino> keyValuePair in this.MinoDataMap)
			{
				Mino value = keyValuePair.Value;
				UObject world = GlobalData.World;
				FVectorDouble textLocation = value.CubeActor.D_K2_GetActorLocation();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\n\ny:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(value.Coord.Y, "F2");
				UKismetSystemLibrary.D_DrawDebugString(world, textLocation, defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(color), 0f);
			}
		}

		// Token: 0x04015474 RID: 87156
		private readonly Dictionary<double, Mino> MinoDataMap = new Dictionary<double, Mino>();

		// Token: 0x04015475 RID: 87157
		private readonly Dictionary<double, int> MinoMaterialDataMap = new Dictionary<double, int>();

		// Token: 0x04015476 RID: 87158
		public readonly SlidingBlocksGameData GameData = gameData;

		// Token: 0x04015477 RID: 87159
		public readonly double RowIndex = rowIndex;

		// Token: 0x04015478 RID: 87160
		public readonly double RowSize = rowSize;
	}
}

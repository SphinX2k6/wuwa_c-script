using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B85 RID: 19333
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGridRow
	{
		// Token: 0x060321AD RID: 205229 RVA: 0x00BA2C9D File Offset: 0x00BA0E9D
		public TetrisGridRow(SlidingBlocksGameData gameData, double rowIndex, double rowSize)
		{
		}

		// Token: 0x060321AE RID: 205230 RVA: 0x00BA2CD0 File Offset: 0x00BA0ED0
		public void Clear()
		{
			this.MinoDataMap.Clear();
		}

		// Token: 0x060321AF RID: 205231 RVA: 0x00BA2CDD File Offset: 0x00BA0EDD
		public bool AddData(double x, Mino minoData)
		{
			this.MinoDataMap[x] = minoData;
			return true;
		}

		// Token: 0x060321B0 RID: 205232 RVA: 0x00BA2CED File Offset: 0x00BA0EED
		public bool RemoveData(double x)
		{
			return this.MinoDataMap.Remove(x);
		}

		// Token: 0x060321B1 RID: 205233 RVA: 0x00BA2CFB File Offset: 0x00BA0EFB
		public bool CheckCanLineClear()
		{
			return (double)this.MinoDataMap.Count >= this.RowSize;
		}

		// Token: 0x060321B2 RID: 205234 RVA: 0x00BA2D14 File Offset: 0x00BA0F14
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

		// Token: 0x060321B3 RID: 205235 RVA: 0x00BA2D5F File Offset: 0x00BA0F5F
		public bool CheckEmpty()
		{
			return this.MinoDataMap.Count == 0;
		}

		// Token: 0x060321B4 RID: 205236 RVA: 0x00BA2D70 File Offset: 0x00BA0F70
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

		// Token: 0x060321B5 RID: 205237 RVA: 0x00BA2DB4 File Offset: 0x00BA0FB4
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

		// Token: 0x060321B6 RID: 205238 RVA: 0x00BA2E00 File Offset: 0x00BA1000
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

		// Token: 0x0401AB20 RID: 109344
		private readonly Dictionary<double, Mino> MinoDataMap = new Dictionary<double, Mino>();

		// Token: 0x0401AB21 RID: 109345
		private readonly Dictionary<double, int> MinoMaterialDataMap = new Dictionary<double, int>();

		// Token: 0x0401AB22 RID: 109346
		public readonly SlidingBlocksGameData GameData = gameData;

		// Token: 0x0401AB23 RID: 109347
		public readonly double RowIndex = rowIndex;

		// Token: 0x0401AB24 RID: 109348
		public readonly double RowSize = rowSize;
	}
}

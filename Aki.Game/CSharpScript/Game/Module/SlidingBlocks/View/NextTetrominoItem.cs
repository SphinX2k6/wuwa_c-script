using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B3B RID: 15163
	[NullableContext(1)]
	[Nullable(0)]
	public class NextTetrominoItem : UiPanelBase
	{
		// Token: 0x06026FA3 RID: 159651 RVA: 0x00AE944C File Offset: 0x00AE764C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026FA4 RID: 159652 RVA: 0x00AE94B8 File Offset: 0x00AE76B8
		protected override UniTask OnBeforeStartAsync()
		{
			NextTetrominoItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NextTetrominoItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026FA5 RID: 159653 RVA: 0x00AE94FC File Offset: 0x00AE76FC
		public void OnTick(float delta)
		{
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			if (gameData.CurSpawnTetrominoList == null)
			{
				return;
			}
			if (gameData.CurSpawnTetrominoListIndex >= gameData.CurSpawnTetrominoList.Count)
			{
				return;
			}
			ITetrominoConfig tetrominoConfig = gameData.CurSpawnTetrominoList[gameData.CurSpawnTetrominoListIndex];
			SlidingBlocksDefine.ETetrominoType? curShowTetromino = this.CurShowTetromino;
			SlidingBlocksDefine.ETetrominoType type = tetrominoConfig.Type;
			if (curShowTetromino.GetValueOrDefault() == type & curShowTetromino != null)
			{
				return;
			}
			this.CurShowTetromino = new SlidingBlocksDefine.ETetrominoType?(tetrominoConfig.Type);
			this.CurShowTetrominoBoard = new SlidingBlocksDefine.ETetrominoBorad?((SlidingBlocksDefine.ETetrominoBorad)tetrominoConfig.Board.BoardSize.X);
			this.ChangePreviewTetromino(tetrominoConfig).Forget();
		}

		// Token: 0x06026FA6 RID: 159654 RVA: 0x00AE95A0 File Offset: 0x00AE77A0
		private UniTask ChangePreviewTetromino(ITetrominoConfig nextTetromino)
		{
			NextTetrominoItem.<ChangePreviewTetromino>d__7 <ChangePreviewTetromino>d__;
			<ChangePreviewTetromino>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangePreviewTetromino>d__.<>4__this = this;
			<ChangePreviewTetromino>d__.nextTetromino = nextTetromino;
			<ChangePreviewTetromino>d__.<>1__state = -1;
			<ChangePreviewTetromino>d__.<>t__builder.Start<NextTetrominoItem.<ChangePreviewTetromino>d__7>(ref <ChangePreviewTetromino>d__);
			return <ChangePreviewTetromino>d__.<>t__builder.Task;
		}

		// Token: 0x06026FA7 RID: 159655 RVA: 0x00AE95EC File Offset: 0x00AE77EC
		private UniTask AddMinoItem(string styleName, double x, double y)
		{
			NextTetrominoItem.<AddMinoItem>d__8 <AddMinoItem>d__;
			<AddMinoItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddMinoItem>d__.<>4__this = this;
			<AddMinoItem>d__.styleName = styleName;
			<AddMinoItem>d__.x = x;
			<AddMinoItem>d__.y = y;
			<AddMinoItem>d__.<>1__state = -1;
			<AddMinoItem>d__.<>t__builder.Start<NextTetrominoItem.<AddMinoItem>d__8>(ref <AddMinoItem>d__);
			return <AddMinoItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401549F RID: 87199
		private SlidingBlocksDefine.ETetrominoType? CurShowTetromino;

		// Token: 0x040154A0 RID: 87200
		private SlidingBlocksDefine.ETetrominoBorad? CurShowTetrominoBoard;

		// Token: 0x040154A1 RID: 87201
		private readonly List<PreviewMinoItem> PreviewMinoItems = new List<PreviewMinoItem>();

		// Token: 0x020097B9 RID: 38841
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x0402F546 RID: 193862
			GridNode,
			// Token: 0x0402F547 RID: 193863
			GridItem
		}
	}
}

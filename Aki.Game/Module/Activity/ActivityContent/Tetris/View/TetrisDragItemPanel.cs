using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC6 RID: 12230
	[NullableContext(2)]
	[Nullable(0)]
	public class TetrisDragItemPanel : UiPanelBase
	{
		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0601D087 RID: 118919 RVA: 0x008DE368 File Offset: 0x008DC568
		public bool IsRotating
		{
			get
			{
				return this.CurrentRotationInfo != null;
			}
		}

		// Token: 0x0601D088 RID: 118920 RVA: 0x008DE378 File Offset: 0x008DC578
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D089 RID: 118921 RVA: 0x008DE404 File Offset: 0x008DC604
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisDragItemPanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisDragItemPanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D08A RID: 118922 RVA: 0x008DE448 File Offset: 0x008DC648
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			TetrisSetting? setting = ActivityTetrisConfig.Instance.GetSetting("RotationLength");
			if (setting != null)
			{
				float rotationLength = setting.GetValueOrDefault().RotationLength;
				this.RotationLength = rotationLength;
			}
		}

		// Token: 0x0601D08B RID: 118923 RVA: 0x008DE496 File Offset: 0x008DC696
		protected override void OnBeforeDestroy()
		{
			this.StopRotation();
			this.OnRotationFinished = null;
			this.ListItems.Clear();
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D08C RID: 118924 RVA: 0x008DE4C8 File Offset: 0x008DC6C8
		private void SetNumberOfGridItems(int count)
		{
			if (this.CurrentGridItemCount < count)
			{
				for (int i = this.CurrentGridItemCount; i < count; i++)
				{
					this.ListItems[i].SetUiActive(true);
				}
				this.CurrentGridItemCount = count;
				return;
			}
			if (this.CurrentGridItemCount > count)
			{
				for (int j = count; j < this.CurrentGridItemCount; j++)
				{
					this.ListItems[j].SetUiActive(false);
				}
				this.CurrentGridItemCount = count;
			}
		}

		// Token: 0x0601D08D RID: 118925 RVA: 0x008DE53C File Offset: 0x008DC73C
		public void RefreshView(BlockInstance data)
		{
			if (data == null)
			{
				return;
			}
			this.SetNumberOfGridItems(data.Offsets.Length);
			int boundRectWidth = data.BoundRectWidth;
			int boundRectHeight = data.BoundRectHeight;
			for (int i = 0; i < data.Offsets.Length; i++)
			{
				TetrisBoardGridPanel tetrisBoardGridPanel = this.ListItems[i];
				UUIItem rootItem = tetrisBoardGridPanel.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetAnchorOffset(TetrisUtils.GetRotatedAnchorOffset(data.Offsets[i], boundRectWidth, boundRectHeight, this.GridWidth, this.GridHeight, data.Rotation));
					ValueTuple<EGemType, EBombType> cellAttachmentTypes = data.GetCellAttachmentTypes(i);
					EGemType item = cellAttachmentTypes.Item1;
					EBombType item2 = cellAttachmentTypes.Item2;
					tetrisBoardGridPanel.Refresh(new TetrisCellData
					{
						Type = ECellType.Normal,
						ColorId = data.ColorId,
						GemType = item,
						BombType = item2
					});
				}
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetAnchorOffsetX(TetrisUtils.GetRotateHotkeyAnchorOffsetX(boundRectWidth, boundRectHeight, this.GridWidth, data.Rotation));
			}
			this.ViewSequencePlayer.PlayLevelSequenceByName("Pick", false, null, false);
		}

		// Token: 0x0601D08E RID: 118926 RVA: 0x008DE650 File Offset: 0x008DC850
		[NullableContext(1)]
		private UniTask CreateShape(UUIItem itemTemplate, UUIItem list)
		{
			TetrisDragItemPanel.<CreateShape>d__18 <CreateShape>d__;
			<CreateShape>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShape>d__.<>4__this = this;
			<CreateShape>d__.itemTemplate = itemTemplate;
			<CreateShape>d__.list = list;
			<CreateShape>d__.<>1__state = -1;
			<CreateShape>d__.<>t__builder.Start<TetrisDragItemPanel.<CreateShape>d__18>(ref <CreateShape>d__);
			return <CreateShape>d__.<>t__builder.Task;
		}

		// Token: 0x0601D08F RID: 118927 RVA: 0x008DE6A4 File Offset: 0x008DC8A4
		public void SetHotkeyVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(visible);
			}
		}

		// Token: 0x0601D090 RID: 118928 RVA: 0x008DE6C4 File Offset: 0x008DC8C4
		public void StartRotation(BlockInstance data)
		{
			if (data == null)
			{
				return;
			}
			if (this.RotationLength > 0f)
			{
				ETetrisRotation previousRotation = data.PreviousRotation;
				FVector2D[] array = new FVector2D[data.Offsets.Length];
				this.SetNumberOfGridItems(data.Offsets.Length);
				int boundRectWidth = data.BoundRectWidth;
				int boundRectHeight = data.BoundRectHeight;
				for (int i = 0; i < data.Offsets.Length; i++)
				{
					TetrisBoardGridPanel tetrisBoardGridPanel = this.ListItems[i];
					UUIItem rootItem = tetrisBoardGridPanel.GetRootItem();
					if (rootItem != null)
					{
						array[i] = TetrisUtils.GetRotatedAnchorOffset(data.Offsets[i], boundRectWidth, boundRectHeight, this.GridWidth, this.GridHeight, previousRotation);
						rootItem.SetAnchorOffset(array[i]);
						ValueTuple<EGemType, EBombType> cellAttachmentTypes = data.GetCellAttachmentTypes(i);
						EGemType item = cellAttachmentTypes.Item1;
						EBombType item2 = cellAttachmentTypes.Item2;
						tetrisBoardGridPanel.Refresh(new TetrisCellData
						{
							Type = ECellType.Normal,
							ColorId = data.ColorId,
							GemType = item,
							BombType = item2
						});
					}
				}
				bool isInTouch = Info.Instance.IsInTouch();
				this.CurrentRotationInfo = new TetrisDragItemPanel.RotationInfo(array, TetrisUtils.GetRotateHotkeyAnchorOffsetX(boundRectWidth, boundRectHeight, this.GridWidth, previousRotation), TetrisUtils.GetRotateHotkeyAnchorOffsetX(boundRectWidth, boundRectHeight, this.GridWidth, data.Rotation), isInTouch, TetrisUtils.GetRotateCentreOffset(boundRectWidth, boundRectHeight, this.GridWidth, this.GridHeight, previousRotation), TetrisUtils.GetRotateCentreOffset(boundRectWidth, boundRectHeight, this.GridWidth, this.GridHeight, data.Rotation), 0f);
				return;
			}
			this.RefreshView(data);
			Action onRotationFinished = this.OnRotationFinished;
			if (onRotationFinished == null)
			{
				return;
			}
			onRotationFinished();
		}

		// Token: 0x0601D091 RID: 118929 RVA: 0x008DE84F File Offset: 0x008DCA4F
		public void StopRotation()
		{
			this.CurrentRotationInfo = null;
		}

		// Token: 0x0601D092 RID: 118930 RVA: 0x008DE858 File Offset: 0x008DCA58
		public void HandleRotation(float delta, FVector2D currentDragPosition)
		{
			TetrisDragItemPanel.RotationInfo currentRotationInfo = this.CurrentRotationInfo;
			if (currentRotationInfo != null)
			{
				currentRotationInfo.TimeElapsed += delta;
				bool flag = currentRotationInfo.TimeElapsed < this.RotationLength;
				float num;
				if (flag)
				{
					num = currentRotationInfo.TimeElapsed / this.RotationLength;
					num = ((num < 0.5f) ? (MathF.Pow(num * 2f, 4f) * 0.5f) : ((1f - MathF.Pow(2f - num * 2f, 4f)) * 0.5f + 0.5f));
				}
				else
				{
					num = 1f;
				}
				for (int i = 0; i < currentRotationInfo.StartingOffsets.Length; i++)
				{
					UUIItem rootItem = this.ListItems[i].GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetAnchorOffset(TetrisUtils.RotatePosition(currentRotationInfo.StartingOffsets[i], num));
					}
				}
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					float anchorOffsetX = FMath.Lerp<float>(this.CurrentRotationInfo.StartingHotkeyAnchorOffsetX, this.CurrentRotationInfo.EndingHotkeyAnchorOffsetX, num);
					item.SetAnchorOffsetX(anchorOffsetX);
				}
				if (this.CurrentRotationInfo.IsInTouch && !currentDragPosition.ContainsNaN())
				{
					UUIItem rootItem2 = base.GetRootItem();
					if (rootItem2 != null)
					{
						float num2 = FMath.Lerp<float>(this.CurrentRotationInfo.StartingCentreOffset.X, this.CurrentRotationInfo.EndingCentreOffset.X, num);
						float num3 = FMath.Lerp<float>(this.CurrentRotationInfo.StartingCentreOffset.Y, this.CurrentRotationInfo.EndingCentreOffset.Y, num);
						FVector2D anchorOffset = new FVector2D(currentDragPosition.X + num2, currentDragPosition.Y + num3);
						rootItem2.SetAnchorOffset(anchorOffset);
					}
				}
				if (!flag)
				{
					this.CurrentRotationInfo = null;
					Action onRotationFinished = this.OnRotationFinished;
					if (onRotationFinished == null)
					{
						return;
					}
					onRotationFinished();
				}
			}
		}

		// Token: 0x0400F48F RID: 62607
		[Nullable(1)]
		private readonly List<TetrisBoardGridPanel> ListItems = new List<TetrisBoardGridPanel>();

		// Token: 0x0400F490 RID: 62608
		private float GridWidth;

		// Token: 0x0400F491 RID: 62609
		private float GridHeight;

		// Token: 0x0400F492 RID: 62610
		private int CurrentGridItemCount;

		// Token: 0x0400F493 RID: 62611
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F494 RID: 62612
		private float RotationLength;

		// Token: 0x0400F495 RID: 62613
		private TetrisDragItemPanel.RotationInfo CurrentRotationInfo;

		// Token: 0x0400F496 RID: 62614
		public Action OnRotationFinished;

		// Token: 0x02008C4E RID: 35918
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C67C RID: 181884
			public const int GridItem = 0;

			// Token: 0x0402C67D RID: 181885
			public const int List = 1;

			// Token: 0x0402C67E RID: 181886
			public const int PnlHotkey = 2;
		}

		// Token: 0x02008C4F RID: 35919
		[NullableContext(1)]
		[Nullable(0)]
		private class RotationInfo
		{
			// Token: 0x06042CDF RID: 273631 RVA: 0x013DE8FE File Offset: 0x013DCAFE
			public RotationInfo(FVector2D[] startingOffsets, float startingHotkeyAnchorOffsetX, float endingHotkeyAnchorOffsetX, bool isInTouch, FVector2D startingCentreOffset, FVector2D endingCentreOffset, float timeElapsed = 0f)
			{
			}

			// Token: 0x0402C67F RID: 181887
			public readonly FVector2D[] StartingOffsets = startingOffsets;

			// Token: 0x0402C680 RID: 181888
			public readonly float StartingHotkeyAnchorOffsetX = startingHotkeyAnchorOffsetX;

			// Token: 0x0402C681 RID: 181889
			public readonly float EndingHotkeyAnchorOffsetX = endingHotkeyAnchorOffsetX;

			// Token: 0x0402C682 RID: 181890
			public readonly bool IsInTouch = isInTouch;

			// Token: 0x0402C683 RID: 181891
			public readonly FVector2D StartingCentreOffset = startingCentreOffset;

			// Token: 0x0402C684 RID: 181892
			public readonly FVector2D EndingCentreOffset = endingCentreOffset;

			// Token: 0x0402C685 RID: 181893
			public float TimeElapsed = timeElapsed;
		}
	}
}

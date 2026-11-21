using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005525 RID: 21797
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractItemBlock : UiPanelBase
	{
		// Token: 0x060360B4 RID: 221364 RVA: 0x00F163C8 File Offset: 0x00F145C8
		public DockyardInteractItemBlock(int itemId, IPanelPos startPos, int rotateType, float gridWidth)
		{
			this.ItemId = itemId;
			this.StartPos = startPos;
			this.RotateType = rotateType;
			this.GridWidth = gridWidth;
		}

		// Token: 0x060360B5 RID: 221365 RVA: 0x00F16438 File Offset: 0x00F14638
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as DockyardInteractPanelModel);
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060360B6 RID: 221366 RVA: 0x00F164D4 File Offset: 0x00F146D4
		private void InitDrag()
		{
			UUIDraggableComponent draggable = base.GetDraggable(2);
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		}

		// Token: 0x060360B7 RID: 221367 RVA: 0x00F1652C File Offset: 0x00F1472C
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.ItemData != null)
			{
				DockyardInteractPanelModel parentModel = this.ParentModel;
				if (parentModel == null)
				{
					return;
				}
				parentModel.DragClick(this.ItemData, this.StartPos);
			}
		}

		// Token: 0x060360B8 RID: 221368 RVA: 0x00F16552 File Offset: 0x00F14752
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (this.ItemData != null)
			{
				DockyardInteractPanelModel parentModel = this.ParentModel;
				if (parentModel == null)
				{
					return;
				}
				parentModel.DragBegin(this.ItemData, this.StartPos);
			}
		}

		// Token: 0x060360B9 RID: 221369 RVA: 0x00F16578 File Offset: 0x00F14778
		private void InitValidData()
		{
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(this.ItemId);
			IntArray[] array = FishingConfig.Instance.GetFishingShapeConfig(fishingItemConfig.Value.Shap).FillState();
			this.ShapeLength.RowIndex = array.Length;
			this.ShapeLength.ColIndex = array[0].ArrayIntLength;
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].ArrayIntLength; j++)
				{
					if (array[i].ArrayInt(j) == 1)
					{
						num = ((num == -1) ? i : Math.Min(num, i));
						num2 = ((num2 == -1) ? i : Math.Max(num2, i));
						num3 = ((num3 == -1) ? j : Math.Min(num3, j));
						num4 = ((num4 == -1) ? j : Math.Max(num4, j));
					}
				}
			}
			this.ValidStartPos.ColIndex = num3;
			this.ValidStartPos.RowIndex = num;
			for (int k = 0; k < num2 - num + 1; k++)
			{
				this.ValidDoublyList.Add(new List<int>());
				for (int l = 0; l < num4 - num3 + 1; l++)
				{
					int item = array[k + num].ArrayInt(l + num3);
					this.ValidDoublyList[k].Add(item);
				}
			}
		}

		// Token: 0x060360BA RID: 221370 RVA: 0x00F166FC File Offset: 0x00F148FC
		private UniTask InitTexture()
		{
			DockyardInteractItemBlock.<InitTexture>d__16 <InitTexture>d__;
			<InitTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTexture>d__.<>4__this = this;
			<InitTexture>d__.<>1__state = -1;
			<InitTexture>d__.<>t__builder.Start<DockyardInteractItemBlock.<InitTexture>d__16>(ref <InitTexture>d__);
			return <InitTexture>d__.<>t__builder.Task;
		}

		// Token: 0x060360BB RID: 221371 RVA: 0x00F16740 File Offset: 0x00F14940
		private void InitTargetId()
		{
			List<List<int>> list = DockyardPanelUtil.RotateOriginalPosData(this.ValidDoublyList, (FishingItemRotate)this.RotateType);
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list[i].Count; j++)
				{
					if (list[i][j] == 1)
					{
						IPanelPos interactPosByPos = this.ParentModel.GetInteractPosByPos(i + this.StartPos.RowIndex, j + this.StartPos.ColIndex);
						this.ParentModel.GetInteractGridData(interactPosByPos).SetTargetId(this.ItemId);
					}
				}
			}
		}

		// Token: 0x060360BC RID: 221372 RVA: 0x00F167D4 File Offset: 0x00F149D4
		private void RefreshFinish()
		{
			List<List<int>> list = new List<List<int>>();
			if (this.ItemData != null)
			{
				list = DockyardPanelUtil.RotateOriginalPosData(this.ItemData.ValidDoublyList, (FishingItemRotate)this.RotateType);
			}
			List<List<int>> list2 = DockyardPanelUtil.RotateOriginalPosData(this.ValidDoublyList, (FishingItemRotate)this.RotateType);
			for (int i = 0; i < list2.Count; i++)
			{
				for (int j = 0; j < list2[i].Count; j++)
				{
					IPanelPos interactPosByPos = this.ParentModel.GetInteractPosByPos(i + this.StartPos.RowIndex, j + this.StartPos.ColIndex);
					DockyardInteractGridData interactGridData = this.ParentModel.GetInteractGridData(interactPosByPos);
					if (list.Count > 0)
					{
						int num = list[i][j];
						interactGridData.IsFinish = (num == 1);
					}
					else
					{
						interactGridData.IsFinish = false;
					}
				}
			}
		}

		// Token: 0x060360BD RID: 221373 RVA: 0x00F168A8 File Offset: 0x00F14AA8
		private void InitTextureTransform(UUITexture texture)
		{
			float width = (float)this.ValidDoublyList[0].Count * this.GridWidth;
			texture.SetWidth(width);
			float height = (float)this.ValidDoublyList.Count * this.GridWidth;
			texture.SetHeight(height);
			Vector2D vector2D = DockyardPanelUtil.CalculateOriginalPivot(this.ShapeLength.RowIndex, this.ShapeLength.ColIndex);
			if (texture != null)
			{
				texture.SetPivot(vector2D.ToUeVector2D(false));
			}
			int num = this.RotateType * -90;
			FRotator frotator = new FRotator(0f, (float)num, 0f);
			texture.SetUIRelativeRotation(frotator);
		}

		// Token: 0x060360BE RID: 221374 RVA: 0x00F16944 File Offset: 0x00F14B44
		private void InitRootItemTransform()
		{
			float inX = (float)(this.ValidStartPos.ColIndex + this.StartPos.ColIndex) * this.GridWidth;
			float num = (float)(this.ValidStartPos.RowIndex + this.StartPos.RowIndex) * this.GridWidth;
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(new FVector2D(inX, -num));
		}

		// Token: 0x060360BF RID: 221375 RVA: 0x00F169A9 File Offset: 0x00F14BA9
		private void InitOther()
		{
			this.ChangeTextureActive(false);
		}

		// Token: 0x060360C0 RID: 221376 RVA: 0x00F169B4 File Offset: 0x00F14BB4
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardInteractItemBlock.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardInteractItemBlock.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060360C1 RID: 221377 RVA: 0x00F169F7 File Offset: 0x00F14BF7
		private void ChangeTextureActive(bool realTextureActive)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(realTextureActive);
			}
			UUITexture texture2 = base.GetTexture(0);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(!realTextureActive);
		}

		// Token: 0x060360C2 RID: 221378 RVA: 0x00F16A21 File Offset: 0x00F14C21
		public void SetItemData(DockyardItemBlockOriginalData itemData)
		{
			this.ItemData = itemData;
			this.RefreshFinish();
			this.ChangeTextureActive(itemData != null);
		}

		// Token: 0x060360C3 RID: 221379 RVA: 0x00F16A3A File Offset: 0x00F14C3A
		public bool CheckIsTarget(int itemId, int rowIndex, int colIndex, int rotateType)
		{
			return this.ItemId == itemId && rowIndex == this.StartPos.RowIndex && colIndex == this.StartPos.ColIndex && rotateType == this.RotateType;
		}

		// Token: 0x0401C8A6 RID: 116902
		private List<List<int>> ValidDoublyList = new List<List<int>>();

		// Token: 0x0401C8A7 RID: 116903
		public readonly IPanelPos ValidStartPos = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x0401C8A8 RID: 116904
		private DockyardInteractPanelModel ParentModel;

		// Token: 0x0401C8A9 RID: 116905
		public DockyardItemBlockOriginalData ItemData;

		// Token: 0x0401C8AA RID: 116906
		private readonly IPanelPos ShapeLength = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x0401C8AB RID: 116907
		public int ItemId;

		// Token: 0x0401C8AC RID: 116908
		public IPanelPos StartPos;

		// Token: 0x0401C8AD RID: 116909
		public readonly int RotateType;

		// Token: 0x0401C8AE RID: 116910
		protected float GridWidth;

		// Token: 0x0200B187 RID: 45447
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E3C RID: 224828
			public const int Texture = 0;

			// Token: 0x04036E3D RID: 224829
			public const int RealTexture = 1;

			// Token: 0x04036E3E RID: 224830
			public const int DraggableItem = 2;
		}
	}
}

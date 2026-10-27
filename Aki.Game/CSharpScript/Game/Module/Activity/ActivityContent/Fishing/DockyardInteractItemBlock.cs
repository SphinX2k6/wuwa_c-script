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
	// Token: 0x020065A7 RID: 26023
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractItemBlock : UiPanelBase
	{
		// Token: 0x060413EF RID: 267247 RVA: 0x00FCF3C4 File Offset: 0x00FCD5C4
		public DockyardInteractItemBlock(int itemId, IPanelPos startPos, int rotateType, float gridWidth)
		{
			this.ItemId = itemId;
			this.StartPos = startPos;
			this.RotateType = rotateType;
			this.GridWidth = gridWidth;
		}

		// Token: 0x060413F0 RID: 267248 RVA: 0x00FCF434 File Offset: 0x00FCD634
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

		// Token: 0x060413F1 RID: 267249 RVA: 0x00FCF4D0 File Offset: 0x00FCD6D0
		private void InitDrag()
		{
			UUIDraggableComponent draggable = base.GetDraggable(2);
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
		}

		// Token: 0x060413F2 RID: 267250 RVA: 0x00FCF528 File Offset: 0x00FCD728
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

		// Token: 0x060413F3 RID: 267251 RVA: 0x00FCF54E File Offset: 0x00FCD74E
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

		// Token: 0x060413F4 RID: 267252 RVA: 0x00FCF574 File Offset: 0x00FCD774
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

		// Token: 0x060413F5 RID: 267253 RVA: 0x00FCF6F8 File Offset: 0x00FCD8F8
		private UniTask InitTexture()
		{
			DockyardInteractItemBlock.<InitTexture>d__16 <InitTexture>d__;
			<InitTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTexture>d__.<>4__this = this;
			<InitTexture>d__.<>1__state = -1;
			<InitTexture>d__.<>t__builder.Start<DockyardInteractItemBlock.<InitTexture>d__16>(ref <InitTexture>d__);
			return <InitTexture>d__.<>t__builder.Task;
		}

		// Token: 0x060413F6 RID: 267254 RVA: 0x00FCF73C File Offset: 0x00FCD93C
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

		// Token: 0x060413F7 RID: 267255 RVA: 0x00FCF7D0 File Offset: 0x00FCD9D0
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

		// Token: 0x060413F8 RID: 267256 RVA: 0x00FCF8A4 File Offset: 0x00FCDAA4
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

		// Token: 0x060413F9 RID: 267257 RVA: 0x00FCF940 File Offset: 0x00FCDB40
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

		// Token: 0x060413FA RID: 267258 RVA: 0x00FCF9A5 File Offset: 0x00FCDBA5
		private void InitOther()
		{
			this.ChangeTextureActive(false);
		}

		// Token: 0x060413FB RID: 267259 RVA: 0x00FCF9B0 File Offset: 0x00FCDBB0
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardInteractItemBlock.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardInteractItemBlock.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060413FC RID: 267260 RVA: 0x00FCF9F3 File Offset: 0x00FCDBF3
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

		// Token: 0x060413FD RID: 267261 RVA: 0x00FCFA1D File Offset: 0x00FCDC1D
		public void SetItemData(DockyardItemBlockOriginalData itemData)
		{
			this.ItemData = itemData;
			this.RefreshFinish();
			this.ChangeTextureActive(itemData != null);
		}

		// Token: 0x060413FE RID: 267262 RVA: 0x00FCFA36 File Offset: 0x00FCDC36
		public bool CheckIsTarget(int itemId, int rowIndex, int colIndex, int rotateType)
		{
			return this.ItemId == itemId && rowIndex == this.StartPos.RowIndex && colIndex == this.StartPos.ColIndex && rotateType == this.RotateType;
		}

		// Token: 0x04021F75 RID: 139125
		private List<List<int>> ValidDoublyList = new List<List<int>>();

		// Token: 0x04021F76 RID: 139126
		public readonly IPanelPos ValidStartPos = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x04021F77 RID: 139127
		private DockyardInteractPanelModel ParentModel;

		// Token: 0x04021F78 RID: 139128
		public DockyardItemBlockOriginalData ItemData;

		// Token: 0x04021F79 RID: 139129
		private readonly IPanelPos ShapeLength = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x04021F7A RID: 139130
		public int ItemId;

		// Token: 0x04021F7B RID: 139131
		public IPanelPos StartPos;

		// Token: 0x04021F7C RID: 139132
		public readonly int RotateType;

		// Token: 0x04021F7D RID: 139133
		protected float GridWidth;

		// Token: 0x0200C7A2 RID: 51106
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C4EB RID: 247019
			public const int Texture = 0;

			// Token: 0x0403C4EC RID: 247020
			public const int RealTexture = 1;

			// Token: 0x0403C4ED RID: 247021
			public const int DraggableItem = 2;
		}
	}
}

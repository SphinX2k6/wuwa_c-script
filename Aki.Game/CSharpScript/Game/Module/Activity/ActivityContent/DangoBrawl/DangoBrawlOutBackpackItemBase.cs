using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006829 RID: 26665
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackItemBase : DangoBrawlItemViewBase
	{
		// Token: 0x17009745 RID: 38725
		// (get) Token: 0x060428AE RID: 272558 RVA: 0x0102BB2B File Offset: 0x01029D2B
		public DangoBrawlOutBackpackItemData MyItemData
		{
			get
			{
				return this.ItemData as DangoBrawlOutBackpackItemData;
			}
		}

		// Token: 0x17009746 RID: 38726
		// (get) Token: 0x060428AF RID: 272559 RVA: 0x0102BB38 File Offset: 0x01029D38
		protected UUITexture TexIcon
		{
			get
			{
				return base.GetTexture(2);
			}
		}

		// Token: 0x17009747 RID: 38727
		// (get) Token: 0x060428B0 RID: 272560 RVA: 0x0102BB41 File Offset: 0x01029D41
		protected UUITexture TexIconMask
		{
			get
			{
				return base.GetTexture(3);
			}
		}

		// Token: 0x060428B1 RID: 272561 RVA: 0x0102BB4A File Offset: 0x01029D4A
		protected override void OnStart()
		{
			base.OnStart();
			this.BindClickCallbacks();
			this.SetFrameVisible(false);
		}

		// Token: 0x060428B2 RID: 272562 RVA: 0x0102BB5F File Offset: 0x01029D5F
		protected override void OnBeforeDestroy()
		{
			this.UnbindClickCallbacks();
			base.OnBeforeDestroy();
		}

		// Token: 0x060428B3 RID: 272563 RVA: 0x0102BB6D File Offset: 0x01029D6D
		[NullableContext(1)]
		public void BindExData(DangoBrawlOutBackpackItemData itemData, float gridSize, Vector2D offset)
		{
			this.ItemData = itemData;
			this.OutGridSize = gridSize;
			this.GridSize = (int)gridSize;
			this.Offset.FromUeVector2D(offset);
		}

		// Token: 0x060428B4 RID: 272564 RVA: 0x0102BB91 File Offset: 0x01029D91
		public void BindTouchInput(DangoBrawlOutBackpackTouchInput touchInput)
		{
			this.TouchInput = touchInput;
		}

		// Token: 0x060428B5 RID: 272565 RVA: 0x0102BB9A File Offset: 0x01029D9A
		public override void ResetOnInit()
		{
			this.IsSelected = false;
			this.SetFrameVisible(false);
			this.ApplyIconScale(1f);
			this.SetItemActive(false);
			this.TouchInput = null;
		}

		// Token: 0x060428B6 RID: 272566 RVA: 0x0102BBC4 File Offset: 0x01029DC4
		public void ApplyIconScale(float scale)
		{
			this.IconScaleVector.Set((double)scale, (double)scale, (double)scale);
			FVector relativeScale3D = this.IconScaleVector.ToUeVectorOld();
			List<UUITexture> list = new List<UUITexture>();
			this.CollectIconTextures(list);
			foreach (UUITexture uuitexture in list)
			{
				if (uuitexture != null)
				{
					uuitexture.SetRelativeScale3D(relativeScale3D);
				}
			}
		}

		// Token: 0x060428B7 RID: 272567 RVA: 0x0102BC40 File Offset: 0x01029E40
		public override void SetSelected(bool selected)
		{
			if (!this.CanSelect)
			{
				return;
			}
			bool isSelected = this.IsSelected;
			this.IsSelected = selected;
			if (selected != isSelected)
			{
				this.StopSelectSequence(selected ? "Unselected" : "Drop");
			}
			this.SetFrameVisible(selected);
			if (selected)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetAsLastHierarchy();
				}
				if (!isSelected)
				{
					UiSequencePlayer sequencePlayer = this.SequencePlayer;
					if (sequencePlayer == null)
					{
						return;
					}
					sequencePlayer.PlaySequencePurely("Drop", false, false);
					return;
				}
			}
			else if (isSelected)
			{
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.PlaySequencePurely("Unselected", false, false);
			}
		}

		// Token: 0x060428B8 RID: 272568 RVA: 0x0102BCCD File Offset: 0x01029ECD
		[NullableContext(1)]
		private void StopSelectSequence(string sequenceName)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey(sequenceName, false, true);
		}

		// Token: 0x060428B9 RID: 272569 RVA: 0x0102BCE2 File Offset: 0x01029EE2
		public void SetCanSelect(bool canSelect)
		{
			this.CanSelect = canSelect;
		}

		// Token: 0x060428BA RID: 272570 RVA: 0x0102BCEB File Offset: 0x01029EEB
		public void SetAutoSetPosition(bool canSetPosition)
		{
			this.AutoSetPosition = canSetPosition;
		}

		// Token: 0x060428BB RID: 272571 RVA: 0x0102BCF4 File Offset: 0x01029EF4
		public void SetItemActive(bool active)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(active);
		}

		// Token: 0x060428BC RID: 272572 RVA: 0x0102BD07 File Offset: 0x01029F07
		private void SetFrameVisible(bool visible)
		{
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060428BD RID: 272573 RVA: 0x0102BD1C File Offset: 0x01029F1C
		public virtual void RefreshView()
		{
			DangoBrawlOutBackpackItemData myItemData = this.MyItemData;
			if (myItemData == null)
			{
				return;
			}
			this.RefreshIcon();
			base.RefreshBoundSize(myItemData.Rotate);
			base.ApplyRotationToPnlRotate(myItemData.Rotate);
			this.RefreshPosition();
			base.RefreshShadow(myItemData.Rotate);
		}

		// Token: 0x060428BE RID: 272574 RVA: 0x0102BD64 File Offset: 0x01029F64
		protected override void RefreshIcon()
		{
			DangoBrawlOutBackpackItemData myItemData = this.MyItemData;
			if (myItemData == null)
			{
				return;
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(myItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			int loadId = myItemData.MyConfigId;
			string iconRaycast = dangoBrawlItemById.Value.IconRaycast;
			if (loadId == this.LastIconConfigId && iconRaycast == this.LastRaycastPath)
			{
				return;
			}
			if (string.IsNullOrEmpty(iconRaycast))
			{
				return;
			}
			List<UUITexture> textures = new List<UUITexture>();
			this.CollectIconTextures(textures);
			if (textures.Count == 0)
			{
				return;
			}
			this.SetIconTexturesActive(false);
			this.LastIconConfigId = loadId;
			this.LastRaycastPath = iconRaycast;
			ResourceSystem.Instance.LoadAsync<ULGUIVertsData>(iconRaycast, delegate([Nullable(2)] ULGUIVertsData vertsData, string _)
			{
				if (vertsData == null || !vertsData.IsValid() || this.MyItemData == null || loadId != this.MyItemData.MyConfigId)
				{
					return;
				}
				string path = (vertsData.SourceAsset == null) ? "" : vertsData.SourceAsset.GetPathName();
				foreach (UUITexture uuitexture in textures)
				{
					if (uuitexture != null && uuitexture.IsValid())
					{
						UUITexture target = uuitexture;
						this.SetTextureByPath(path, target, null, delegate(bool suc)
						{
							if (!suc || this.MyItemData == null || loadId != this.MyItemData.MyConfigId)
							{
								return;
							}
							UUITexture target = target;
							if (target != null)
							{
								target.SetSizeFromTexture();
							}
							UUITexture target2 = target;
							if (target2 == null)
							{
								return;
							}
							target2.SetUIActive(true);
						});
					}
				}
				UUIDraggableComponent draggableComponent = this.DraggableComponent;
				object obj;
				if (draggableComponent == null)
				{
					obj = null;
				}
				else
				{
					AActor owner = draggableComponent.GetOwner();
					obj = ((owner != null) ? owner.GetComponentByClass(UUIRaycastRangeComponent.StaticClass()) : null);
				}
				UUIRaycastRangeComponent uuiraycastRangeComponent = obj as UUIRaycastRangeComponent;
				if (uuiraycastRangeComponent == null)
				{
					return;
				}
				uuiraycastRangeComponent.SetVertsData(vertsData);
			}, 100, "js_undefined");
		}

		// Token: 0x060428BF RID: 272575 RVA: 0x0102BE48 File Offset: 0x0102A048
		private void SetIconTexturesActive(bool active)
		{
			List<UUITexture> list = new List<UUITexture>();
			this.CollectIconTextures(list);
			foreach (UUITexture uuitexture in list)
			{
				if (uuitexture != null)
				{
					uuitexture.SetUIActive(active);
				}
			}
		}

		// Token: 0x060428C0 RID: 272576 RVA: 0x0102BEA8 File Offset: 0x0102A0A8
		protected override void RefreshPosition()
		{
			DangoBrawlOutBackpackItemData myItemData = this.MyItemData;
			if (myItemData == null || !this.AutoSetPosition || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			PanelPos leftTopPos = myItemData.LeftTopPos;
			this.Position.Set((double)((float)leftTopPos.ColIndex * this.OutGridSize) + this.Offset.X, (double)((float)(-(float)leftTopPos.RowIndex) * this.OutGridSize) + this.Offset.Y);
			this.RootItem.SetAnchorOffset(this.Position.ToUeVector2D(false));
		}

		// Token: 0x060428C1 RID: 272577 RVA: 0x0102BF3D File Offset: 0x0102A13D
		protected override bool EnableFloatAnim()
		{
			return true;
		}

		// Token: 0x060428C2 RID: 272578 RVA: 0x0102BF40 File Offset: 0x0102A140
		private void BindClickCallbacks()
		{
			UUIDraggableComponent draggableComponent = base.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			draggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		}

		// Token: 0x060428C3 RID: 272579 RVA: 0x0102BFA0 File Offset: 0x0102A1A0
		private void UnbindClickCallbacks()
		{
			UUIDraggableComponent draggableComponent = base.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			draggableComponent.OnPointerDownCallBack.Unbind();
			draggableComponent.OnPointerUpCallBack.Unbind();
			draggableComponent.OnPointerCancelCallBack.Unbind();
		}

		// Token: 0x060428C4 RID: 272580 RVA: 0x0102BFD9 File Offset: 0x0102A1D9
		private void OnPointerDown(ULGUIPointerEventData data)
		{
			if (!Info.Instance.IsInTouch())
			{
				return;
			}
			DangoBrawlOutBackpackTouchInput touchInput = this.TouchInput;
			if (touchInput == null)
			{
				return;
			}
			touchInput.OnPointerDown(this, data);
		}

		// Token: 0x060428C5 RID: 272581 RVA: 0x0102BFFC File Offset: 0x0102A1FC
		private void OnPointerUp(ULGUIPointerEventData data)
		{
			if (this.MyItemData == null || !this.CanSelect || !this.IsValidPointerUp(data))
			{
				return;
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAsLastHierarchy();
			}
			this.SetFrameVisible(true);
			Action<DangoBrawlOutBackpackItemBase> onClickItem = this.OnClickItem;
			if (onClickItem == null)
			{
				return;
			}
			onClickItem(this);
		}

		// Token: 0x060428C6 RID: 272582 RVA: 0x0102C04C File Offset: 0x0102A24C
		private bool IsValidPointerUp(ULGUIPointerEventData data)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				return this.IsValidMousePointerUp(data);
			}
			return !Info.Instance.IsInTouch() || this.IsValidTouchPointerUp(data);
		}

		// Token: 0x060428C7 RID: 272583 RVA: 0x0102C077 File Offset: 0x0102A277
		private bool IsValidMousePointerUp(ULGUIPointerEventData data)
		{
			return data == null || data.mouseButtonType != EMouseButtonType.Right;
		}

		// Token: 0x060428C8 RID: 272584 RVA: 0x0102C08A File Offset: 0x0102A28A
		private bool IsValidTouchPointerUp(ULGUIPointerEventData data)
		{
			DangoBrawlOutBackpackTouchInput touchInput = this.TouchInput;
			return touchInput == null || touchInput.TryAcceptPointerUp(this, data);
		}

		// Token: 0x04022AA7 RID: 141991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlOutBackpackItemBase> OnClickItem;

		// Token: 0x04022AA8 RID: 141992
		protected bool CanSelect = true;

		// Token: 0x04022AA9 RID: 141993
		protected bool AutoSetPosition = true;

		// Token: 0x04022AAA RID: 141994
		protected bool IsSelected;

		// Token: 0x04022AAB RID: 141995
		[Nullable(1)]
		protected Vector2D Position = Vector2D.Create();

		// Token: 0x04022AAC RID: 141996
		[Nullable(1)]
		protected Vector2D Offset = Vector2D.Create();

		// Token: 0x04022AAD RID: 141997
		protected float OutGridSize;

		// Token: 0x04022AAE RID: 141998
		[Nullable(1)]
		private readonly global::Vector IconScaleVector = global::Vector.Create();

		// Token: 0x04022AAF RID: 141999
		private int LastIconConfigId;

		// Token: 0x04022AB0 RID: 142000
		private string LastRaycastPath;

		// Token: 0x04022AB1 RID: 142001
		private DangoBrawlOutBackpackTouchInput TouchInput;
	}
}

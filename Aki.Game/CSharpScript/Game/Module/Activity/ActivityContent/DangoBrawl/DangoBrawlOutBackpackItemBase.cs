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
	// Token: 0x02005779 RID: 22393
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackItemBase : DangoBrawlItemViewBase
	{
		// Token: 0x17006A86 RID: 27270
		// (get) Token: 0x06037402 RID: 226306 RVA: 0x00F6D067 File Offset: 0x00F6B267
		public DangoBrawlOutBackpackItemData MyItemData
		{
			get
			{
				return this.ItemData as DangoBrawlOutBackpackItemData;
			}
		}

		// Token: 0x17006A87 RID: 27271
		// (get) Token: 0x06037403 RID: 226307 RVA: 0x00F6D074 File Offset: 0x00F6B274
		protected UUITexture TexIcon
		{
			get
			{
				return base.GetTexture(2);
			}
		}

		// Token: 0x17006A88 RID: 27272
		// (get) Token: 0x06037404 RID: 226308 RVA: 0x00F6D07D File Offset: 0x00F6B27D
		protected UUITexture TexIconMask
		{
			get
			{
				return base.GetTexture(3);
			}
		}

		// Token: 0x06037405 RID: 226309 RVA: 0x00F6D086 File Offset: 0x00F6B286
		protected override void OnStart()
		{
			base.OnStart();
			this.BindClickCallbacks();
			this.SetFrameVisible(false);
		}

		// Token: 0x06037406 RID: 226310 RVA: 0x00F6D09B File Offset: 0x00F6B29B
		protected override void OnBeforeDestroy()
		{
			this.UnbindClickCallbacks();
			base.OnBeforeDestroy();
		}

		// Token: 0x06037407 RID: 226311 RVA: 0x00F6D0A9 File Offset: 0x00F6B2A9
		[NullableContext(1)]
		public void BindExData(DangoBrawlOutBackpackItemData itemData, float gridSize, Vector2D offset)
		{
			this.ItemData = itemData;
			this.OutGridSize = gridSize;
			this.GridSize = (int)gridSize;
			this.Offset.FromUeVector2D(offset);
		}

		// Token: 0x06037408 RID: 226312 RVA: 0x00F6D0CD File Offset: 0x00F6B2CD
		public void BindTouchInput(DangoBrawlOutBackpackTouchInput touchInput)
		{
			this.TouchInput = touchInput;
		}

		// Token: 0x06037409 RID: 226313 RVA: 0x00F6D0D6 File Offset: 0x00F6B2D6
		public override void ResetOnInit()
		{
			this.IsSelected = false;
			this.SetFrameVisible(false);
			this.ApplyIconScale(1f);
			this.SetItemActive(false);
			this.TouchInput = null;
		}

		// Token: 0x0603740A RID: 226314 RVA: 0x00F6D100 File Offset: 0x00F6B300
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

		// Token: 0x0603740B RID: 226315 RVA: 0x00F6D17C File Offset: 0x00F6B37C
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

		// Token: 0x0603740C RID: 226316 RVA: 0x00F6D209 File Offset: 0x00F6B409
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

		// Token: 0x0603740D RID: 226317 RVA: 0x00F6D21E File Offset: 0x00F6B41E
		public void SetCanSelect(bool canSelect)
		{
			this.CanSelect = canSelect;
		}

		// Token: 0x0603740E RID: 226318 RVA: 0x00F6D227 File Offset: 0x00F6B427
		public void SetAutoSetPosition(bool canSetPosition)
		{
			this.AutoSetPosition = canSetPosition;
		}

		// Token: 0x0603740F RID: 226319 RVA: 0x00F6D230 File Offset: 0x00F6B430
		public void SetItemActive(bool active)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(active);
		}

		// Token: 0x06037410 RID: 226320 RVA: 0x00F6D243 File Offset: 0x00F6B443
		private void SetFrameVisible(bool visible)
		{
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06037411 RID: 226321 RVA: 0x00F6D258 File Offset: 0x00F6B458
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

		// Token: 0x06037412 RID: 226322 RVA: 0x00F6D2A0 File Offset: 0x00F6B4A0
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

		// Token: 0x06037413 RID: 226323 RVA: 0x00F6D384 File Offset: 0x00F6B584
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

		// Token: 0x06037414 RID: 226324 RVA: 0x00F6D3E4 File Offset: 0x00F6B5E4
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

		// Token: 0x06037415 RID: 226325 RVA: 0x00F6D479 File Offset: 0x00F6B679
		protected override bool EnableFloatAnim()
		{
			return true;
		}

		// Token: 0x06037416 RID: 226326 RVA: 0x00F6D47C File Offset: 0x00F6B67C
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

		// Token: 0x06037417 RID: 226327 RVA: 0x00F6D4DC File Offset: 0x00F6B6DC
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

		// Token: 0x06037418 RID: 226328 RVA: 0x00F6D515 File Offset: 0x00F6B715
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

		// Token: 0x06037419 RID: 226329 RVA: 0x00F6D538 File Offset: 0x00F6B738
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

		// Token: 0x0603741A RID: 226330 RVA: 0x00F6D588 File Offset: 0x00F6B788
		private bool IsValidPointerUp(ULGUIPointerEventData data)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				return this.IsValidMousePointerUp(data);
			}
			return !Info.Instance.IsInTouch() || this.IsValidTouchPointerUp(data);
		}

		// Token: 0x0603741B RID: 226331 RVA: 0x00F6D5B3 File Offset: 0x00F6B7B3
		private bool IsValidMousePointerUp(ULGUIPointerEventData data)
		{
			return data == null || data.mouseButtonType != EMouseButtonType.Right;
		}

		// Token: 0x0603741C RID: 226332 RVA: 0x00F6D5C6 File Offset: 0x00F6B7C6
		private bool IsValidTouchPointerUp(ULGUIPointerEventData data)
		{
			DangoBrawlOutBackpackTouchInput touchInput = this.TouchInput;
			return touchInput == null || touchInput.TryAcceptPointerUp(this, data);
		}

		// Token: 0x0401D304 RID: 119556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlOutBackpackItemBase> OnClickItem;

		// Token: 0x0401D305 RID: 119557
		protected bool CanSelect = true;

		// Token: 0x0401D306 RID: 119558
		protected bool AutoSetPosition = true;

		// Token: 0x0401D307 RID: 119559
		protected bool IsSelected;

		// Token: 0x0401D308 RID: 119560
		[Nullable(1)]
		protected Vector2D Position = Vector2D.Create();

		// Token: 0x0401D309 RID: 119561
		[Nullable(1)]
		protected Vector2D Offset = Vector2D.Create();

		// Token: 0x0401D30A RID: 119562
		protected float OutGridSize;

		// Token: 0x0401D30B RID: 119563
		[Nullable(1)]
		private readonly global::Vector IconScaleVector = global::Vector.Create();

		// Token: 0x0401D30C RID: 119564
		private int LastIconConfigId;

		// Token: 0x0401D30D RID: 119565
		private string LastRaycastPath;

		// Token: 0x0401D30E RID: 119566
		private DangoBrawlOutBackpackTouchInput TouchInput;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views
{
	// Token: 0x02005795 RID: 22421
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DangoBrawlItemViewBase : UiPanelBase
	{
		// Token: 0x17006A92 RID: 27282
		// (get) Token: 0x0603754A RID: 226634 RVA: 0x00F74428 File Offset: 0x00F72628
		[Nullable(2)]
		protected UUIExtendToggle Toggle
		{
			[NullableContext(2)]
			get
			{
				return base.GetExtendToggle(7);
			}
		}

		// Token: 0x17006A93 RID: 27283
		// (get) Token: 0x0603754B RID: 226635 RVA: 0x00F74431 File Offset: 0x00F72631
		[Nullable(2)]
		protected UUIDraggableComponent DraggableComponent
		{
			[NullableContext(2)]
			get
			{
				return base.GetDraggable(1);
			}
		}

		// Token: 0x17006A94 RID: 27284
		// (get) Token: 0x0603754C RID: 226636 RVA: 0x00F7443A File Offset: 0x00F7263A
		public int Uid
		{
			get
			{
				DangoBrawlItemBase itemData = this.ItemData;
				if (itemData == null)
				{
					return -1;
				}
				return itemData.MyUid;
			}
		}

		// Token: 0x17006A95 RID: 27285
		// (get) Token: 0x0603754D RID: 226637 RVA: 0x00F7444D File Offset: 0x00F7264D
		public int ConfigId
		{
			get
			{
				DangoBrawlItemBase itemData = this.ItemData;
				if (itemData == null)
				{
					return -1;
				}
				return itemData.MyConfigId;
			}
		}

		// Token: 0x0603754E RID: 226638 RVA: 0x00F74460 File Offset: 0x00F72660
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603754F RID: 226639 RVA: 0x00F7458F File Offset: 0x00F7278F
		protected override void OnStart()
		{
			this.BindBaseEvents();
			this.InitSequencePlayer();
		}

		// Token: 0x06037550 RID: 226640 RVA: 0x00F7459D File Offset: 0x00F7279D
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x06037551 RID: 226641 RVA: 0x00F745AC File Offset: 0x00F727AC
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnStartSequenceEvent));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x06037552 RID: 226642 RVA: 0x00F74606 File Offset: 0x00F72806
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06037553 RID: 226643 RVA: 0x00F74620 File Offset: 0x00F72820
		private void BindBaseEvents()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnter));
				extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPointerExit));
			}
		}

		// Token: 0x06037554 RID: 226644 RVA: 0x00F74668 File Offset: 0x00F72868
		private void UnBindEvents()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Unbind();
				extendToggle.OnPointExitCallBack.Unbind();
			}
		}

		// Token: 0x06037555 RID: 226645 RVA: 0x00F74696 File Offset: 0x00F72896
		protected virtual float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBackpackScale;
		}

		// Token: 0x06037556 RID: 226646 RVA: 0x00F7469F File Offset: 0x00F7289F
		protected virtual bool EnableFloatAnim()
		{
			return true;
		}

		// Token: 0x06037557 RID: 226647 RVA: 0x00F746A2 File Offset: 0x00F728A2
		public virtual void BindData(ActivityDangoBrawlData actData, DangoBrawlItemBase itemData, int gridSize = 0)
		{
			this.ActData = actData;
			this.ItemData = itemData;
			this.GridSize = gridSize;
		}

		// Token: 0x06037558 RID: 226648 RVA: 0x00F746B9 File Offset: 0x00F728B9
		public virtual void SetSelected(bool selected)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(selected);
			}
			if (selected)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetAsLastHierarchy();
			}
		}

		// Token: 0x06037559 RID: 226649 RVA: 0x00F746E1 File Offset: 0x00F728E1
		public virtual void ResetOnInit()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x0603755A RID: 226650 RVA: 0x00F746F4 File Offset: 0x00F728F4
		protected void RefreshBoundSize(EDangoBrawlRotate rotate)
		{
			if (this.RootItem == null || !this.RootItem.IsValid() || this.GridSize <= 0 || this.ItemData == null)
			{
				return;
			}
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(this.ItemData.MyConfigId, rotate));
			int item = boundSize.Item1;
			int item2 = boundSize.Item2;
			this.RootItem.SetWidth((float)(item2 * this.GridSize));
			this.RootItem.SetHeight((float)(item * this.GridSize));
		}

		// Token: 0x0603755B RID: 226651 RVA: 0x00F74774 File Offset: 0x00F72974
		protected void RefreshShadow(EDangoBrawlRotate rotate)
		{
			UUITexture texture = base.GetTexture(2);
			object obj;
			if (texture == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = texture.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIEffectShadow.StaticClass()) : null);
			}
			UUIEffectShadow uuieffectShadow = obj as UUIEffectShadow;
			if (uuieffectShadow == null || !uuieffectShadow.IsValid())
			{
				return;
			}
			uuieffectShadow.shadowOffset = DangoBrawlUtil.GetShadowOffset(rotate);
		}

		// Token: 0x0603755C RID: 226652 RVA: 0x00F747C8 File Offset: 0x00F729C8
		protected void ApplyRotationToPnlRotate(EDangoBrawlRotate val)
		{
			UUIItem item = base.GetItem(5);
			if (item == null || !item.IsValid() || this.ItemData == null)
			{
				return;
			}
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(this.ItemData.MyConfigId, EDangoBrawlRotate.Direction0));
			int item2 = boundSize.Item1;
			int item3 = boundSize.Item2;
			if (item2 <= 0 || item3 <= 0)
			{
				return;
			}
			int num = ((EDangoBrawlRotate)DangoBrawlConst.DangoBrawlRotateAngle.Length > val) ? DangoBrawlConst.DangoBrawlRotateAngle[(int)val] : 0;
			UUIItem uuiitem = item;
			FRotator frotator = new FRotator(0f, (float)num, 0f);
			uuiitem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0603755D RID: 226653 RVA: 0x00F74850 File Offset: 0x00F72A50
		protected virtual void RefreshPosition()
		{
			if (this.RootItem != null && this.RootItem.IsValid())
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = this.ItemData as DangoBrawlBackpackItemData;
				if (dangoBrawlBackpackItemData != null)
				{
					PanelPos myLeftTopPos = dangoBrawlBackpackItemData.MyLeftTopPos;
					this.Location.X = (float)(myLeftTopPos.ColIndex * this.GridSize);
					this.Location.Y = (float)(-(float)myLeftTopPos.RowIndex * this.GridSize);
					this.Location.Z = 0f;
					this.RootItem.SetUIRelativeLocation(this.Location);
					return;
				}
			}
		}

		// Token: 0x0603755E RID: 226654 RVA: 0x00F748E0 File Offset: 0x00F72AE0
		protected virtual void RefreshIcon()
		{
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			List<UUITexture> textures = new List<UUITexture>();
			this.CollectIconTextures(textures);
			if (textures.Count == 0)
			{
				return;
			}
			int loadId = this.ItemData.MyConfigId;
			float iconScale = this.GetIconScale(dangoBrawlItemById.Value);
			string iconRaycast = dangoBrawlItemById.Value.IconRaycast;
			foreach (UUITexture uuitexture in textures)
			{
				if (uuitexture != null)
				{
					uuitexture.SetRelativeScale3D(new FVector(iconScale, iconScale, iconScale));
				}
			}
			if (string.IsNullOrEmpty(iconRaycast))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<ULGUIVertsData>(iconRaycast, delegate([Nullable(2)] ULGUIVertsData vertsData, string _)
			{
				if (vertsData == null || !vertsData.IsValid() || loadId != this.ItemData.MyConfigId)
				{
					return;
				}
				string path = (vertsData.SourceAsset == null) ? "" : vertsData.SourceAsset.GetPathName();
				foreach (UUITexture uuitexture2 in textures)
				{
					if (uuitexture2 != null && uuitexture2.IsValid())
					{
						UUITexture target = uuitexture2;
						this.SetTextureByPath(path, target, null, delegate(bool suc)
						{
							if (!suc || loadId != this.ItemData.MyConfigId)
							{
								return;
							}
							UUITexture target = target;
							if (target == null)
							{
								return;
							}
							target.SetSizeFromTexture();
						});
					}
				}
				UUIDraggableComponent draggable = this.GetDraggable(1);
				object obj;
				if (draggable == null)
				{
					obj = null;
				}
				else
				{
					AActor owner = draggable.GetOwner();
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

		// Token: 0x0603755F RID: 226655 RVA: 0x00F749EC File Offset: 0x00F72BEC
		[NullableContext(2)]
		protected virtual void RefreshQualityFx(UUIItem fxType1, UUIItem fxType2, UUINiagara qualityFx)
		{
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(this.ItemData.MyConfigId);
			int num = (itemConfigById != null) ? itemConfigById.GetValueOrDefault().Quality : 0;
			int num2 = (itemConfigById != null) ? itemConfigById.GetValueOrDefault().UINiagaraType : 0;
			bool flag = num2 == 1;
			bool flag2 = num2 == 2;
			bool uiactive = !flag && !flag2 && num >= 5;
			if (fxType1 != null)
			{
				fxType1.SetUIActive(flag);
			}
			if (fxType2 != null)
			{
				fxType2.SetUIActive(flag2);
			}
			if (qualityFx != null)
			{
				qualityFx.SetUIActive(uiactive);
			}
			if (qualityFx != null)
			{
				qualityFx.SetRelativeScale3D(DangoBrawlUtil.GetFxScale(this.ItemData.MyConfigId, EDangoBrawlRotate.Direction0));
			}
			if (qualityFx != null)
			{
				bool bUseChangeColor = num >= 6;
				FColor? fcolor = new FColor?(qualityFx.changeColor);
				qualityFx.SetChangeColor(bUseChangeColor, fcolor);
			}
		}

		// Token: 0x06037560 RID: 226656 RVA: 0x00F74ABC File Offset: 0x00F72CBC
		protected virtual void CollectIconTextures(List<UUITexture> textures)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				textures.Add(texture);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 != null)
			{
				textures.Add(texture2);
			}
		}

		// Token: 0x06037561 RID: 226657 RVA: 0x00F74AED File Offset: 0x00F72CED
		protected virtual void OnStartSequenceEvent(string sequenceName)
		{
		}

		// Token: 0x06037562 RID: 226658 RVA: 0x00F74AEF File Offset: 0x00F72CEF
		protected virtual void OnEndSequenceEvent(string sequenceName)
		{
		}

		// Token: 0x06037563 RID: 226659 RVA: 0x00F74AF1 File Offset: 0x00F72CF1
		protected virtual void OnPointerEnter(EToggleState _)
		{
			if (!this.EnableFloatAnim())
			{
				return;
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("FloatIn", false, false);
		}

		// Token: 0x06037564 RID: 226660 RVA: 0x00F74B13 File Offset: 0x00F72D13
		protected virtual void OnPointerExit(EToggleState _)
		{
			if (!this.EnableFloatAnim())
			{
				return;
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("FloatOut", false, false);
		}

		// Token: 0x0401D395 RID: 119701
		protected ActivityDangoBrawlData ActData;

		// Token: 0x0401D396 RID: 119702
		protected DangoBrawlItemBase ItemData;

		// Token: 0x0401D397 RID: 119703
		protected int GridSize;

		// Token: 0x0401D398 RID: 119704
		protected FVector Location = new FVector(0f, 0f, 0f);

		// Token: 0x0401D399 RID: 119705
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0200B3D4 RID: 46036
		[NullableContext(0)]
		protected enum EBaseComponents
		{
			// Token: 0x040379C1 RID: 227777
			Dragable = 1,
			// Token: 0x040379C2 RID: 227778
			Icon,
			// Token: 0x040379C3 RID: 227779
			IconMask,
			// Token: 0x040379C4 RID: 227780
			PnlOffset,
			// Token: 0x040379C5 RID: 227781
			PnlRotate,
			// Token: 0x040379C6 RID: 227782
			PnlFrame,
			// Token: 0x040379C7 RID: 227783
			Toggle,
			// Token: 0x040379C8 RID: 227784
			ItemSellFx
		}
	}
}

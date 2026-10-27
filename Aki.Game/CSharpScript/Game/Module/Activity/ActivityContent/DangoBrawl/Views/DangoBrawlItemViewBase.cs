using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views
{
	// Token: 0x02006845 RID: 26693
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DangoBrawlItemViewBase : UiPanelBase
	{
		// Token: 0x17009751 RID: 38737
		// (get) Token: 0x060429F6 RID: 272886 RVA: 0x01032F1C File Offset: 0x0103111C
		[Nullable(2)]
		protected UUIExtendToggle Toggle
		{
			[NullableContext(2)]
			get
			{
				return base.GetExtendToggle(7);
			}
		}

		// Token: 0x17009752 RID: 38738
		// (get) Token: 0x060429F7 RID: 272887 RVA: 0x01032F25 File Offset: 0x01031125
		[Nullable(2)]
		protected UUIDraggableComponent DraggableComponent
		{
			[NullableContext(2)]
			get
			{
				return base.GetDraggable(1);
			}
		}

		// Token: 0x17009753 RID: 38739
		// (get) Token: 0x060429F8 RID: 272888 RVA: 0x01032F2E File Offset: 0x0103112E
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

		// Token: 0x17009754 RID: 38740
		// (get) Token: 0x060429F9 RID: 272889 RVA: 0x01032F41 File Offset: 0x01031141
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

		// Token: 0x060429FA RID: 272890 RVA: 0x01032F54 File Offset: 0x01031154
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

		// Token: 0x060429FB RID: 272891 RVA: 0x01033083 File Offset: 0x01031283
		protected override void OnStart()
		{
			this.BindBaseEvents();
			this.InitSequencePlayer();
		}

		// Token: 0x060429FC RID: 272892 RVA: 0x01033091 File Offset: 0x01031291
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x060429FD RID: 272893 RVA: 0x010330A0 File Offset: 0x010312A0
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

		// Token: 0x060429FE RID: 272894 RVA: 0x010330FA File Offset: 0x010312FA
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060429FF RID: 272895 RVA: 0x01033114 File Offset: 0x01031314
		private void BindBaseEvents()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnter));
				extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPointerExit));
			}
		}

		// Token: 0x06042A00 RID: 272896 RVA: 0x0103315C File Offset: 0x0103135C
		private void UnBindEvents()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Unbind();
				extendToggle.OnPointExitCallBack.Unbind();
			}
		}

		// Token: 0x06042A01 RID: 272897 RVA: 0x0103318A File Offset: 0x0103138A
		protected virtual float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBackpackScale;
		}

		// Token: 0x06042A02 RID: 272898 RVA: 0x01033193 File Offset: 0x01031393
		protected virtual bool EnableFloatAnim()
		{
			return true;
		}

		// Token: 0x06042A03 RID: 272899 RVA: 0x01033196 File Offset: 0x01031396
		public virtual void BindData(ActivityDangoBrawlData actData, DangoBrawlItemBase itemData, int gridSize = 0)
		{
			this.ActData = actData;
			this.ItemData = itemData;
			this.GridSize = gridSize;
		}

		// Token: 0x06042A04 RID: 272900 RVA: 0x010331AD File Offset: 0x010313AD
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

		// Token: 0x06042A05 RID: 272901 RVA: 0x010331D5 File Offset: 0x010313D5
		public virtual void ResetOnInit()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06042A06 RID: 272902 RVA: 0x010331E8 File Offset: 0x010313E8
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

		// Token: 0x06042A07 RID: 272903 RVA: 0x01033268 File Offset: 0x01031468
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

		// Token: 0x06042A08 RID: 272904 RVA: 0x010332BC File Offset: 0x010314BC
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

		// Token: 0x06042A09 RID: 272905 RVA: 0x01033344 File Offset: 0x01031544
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

		// Token: 0x06042A0A RID: 272906 RVA: 0x010333D4 File Offset: 0x010315D4
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

		// Token: 0x06042A0B RID: 272907 RVA: 0x010334E0 File Offset: 0x010316E0
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

		// Token: 0x06042A0C RID: 272908 RVA: 0x010335B0 File Offset: 0x010317B0
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

		// Token: 0x06042A0D RID: 272909 RVA: 0x010335E1 File Offset: 0x010317E1
		protected virtual void OnStartSequenceEvent(string sequenceName)
		{
		}

		// Token: 0x06042A0E RID: 272910 RVA: 0x010335E3 File Offset: 0x010317E3
		protected virtual void OnEndSequenceEvent(string sequenceName)
		{
		}

		// Token: 0x06042A0F RID: 272911 RVA: 0x010335E5 File Offset: 0x010317E5
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

		// Token: 0x06042A10 RID: 272912 RVA: 0x01033607 File Offset: 0x01031807
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

		// Token: 0x04022B38 RID: 142136
		protected ActivityDangoBrawlData ActData;

		// Token: 0x04022B39 RID: 142137
		protected DangoBrawlItemBase ItemData;

		// Token: 0x04022B3A RID: 142138
		protected int GridSize;

		// Token: 0x04022B3B RID: 142139
		protected FVector Location = new FVector(0f, 0f, 0f);

		// Token: 0x04022B3C RID: 142140
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0200CA08 RID: 51720
		[NullableContext(0)]
		protected enum EBaseComponents
		{
			// Token: 0x0403D0D8 RID: 250072
			Dragable = 1,
			// Token: 0x0403D0D9 RID: 250073
			Icon,
			// Token: 0x0403D0DA RID: 250074
			IconMask,
			// Token: 0x0403D0DB RID: 250075
			PnlOffset,
			// Token: 0x0403D0DC RID: 250076
			PnlRotate,
			// Token: 0x0403D0DD RID: 250077
			PnlFrame,
			// Token: 0x0403D0DE RID: 250078
			Toggle,
			// Token: 0x0403D0DF RID: 250079
			ItemSellFx
		}
	}
}

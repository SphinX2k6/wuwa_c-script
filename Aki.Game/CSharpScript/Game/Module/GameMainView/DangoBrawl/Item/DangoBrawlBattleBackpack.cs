using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A09 RID: 23049
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpack : DangoBrawlItemViewBase
	{
		// Token: 0x17008BC4 RID: 35780
		// (get) Token: 0x0603A6FC RID: 239356 RVA: 0x00DE7208 File Offset: 0x00DE5408
		[Nullable(2)]
		public DangoBrawlBackpackItemData MyItemData
		{
			[NullableContext(2)]
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x0603A6FD RID: 239357 RVA: 0x00DE7215 File Offset: 0x00DE5415
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
		}

		// Token: 0x0603A6FE RID: 239358 RVA: 0x00DE7258 File Offset: 0x00DE5458
		public void RefreshOnShow(DangoBrawlNormalBagItemInfo info)
		{
			DangoBrawlBackPackItemServerData serverData = new DangoBrawlBackPackItemServerData(info);
			this.RefreshOnShow(new DangoBrawlBackpackItemData(serverData));
		}

		// Token: 0x0603A6FF RID: 239359 RVA: 0x00DE7278 File Offset: 0x00DE5478
		public void RefreshOnShow(DangoBrawlBackpackItemData itemData)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPrevSequence(false, true);
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			if (activityDangoBrawlData == null)
			{
				return;
			}
			this.BindData(activityDangoBrawlData, itemData, 136);
			this.RefreshView();
		}

		// Token: 0x0603A700 RID: 239360 RVA: 0x00DE72D3 File Offset: 0x00DE54D3
		public void BindData(ActivityDangoBrawlData actData, DangoBrawlBackpackItemData itemData, int gridSize = 0)
		{
			base.BindData(actData, itemData, gridSize);
		}

		// Token: 0x0603A701 RID: 239361 RVA: 0x00DE72E0 File Offset: 0x00DE54E0
		public virtual void RefreshView()
		{
			DangoBrawlBackpackItemData myItemData = this.MyItemData;
			EDangoBrawlRotate edangoBrawlRotate = (myItemData != null) ? myItemData.MyRotation : EDangoBrawlRotate.Direction0;
			this.RefreshIcon();
			base.RefreshBoundSize(edangoBrawlRotate);
			this.RefreshRotation(edangoBrawlRotate);
			base.RefreshShadow(edangoBrawlRotate);
			this.RefreshPosition();
		}

		// Token: 0x0603A702 RID: 239362 RVA: 0x00DE7321 File Offset: 0x00DE5521
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.BindClickCallbacks();
		}

		// Token: 0x0603A703 RID: 239363 RVA: 0x00DE7355 File Offset: 0x00DE5555
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnbindClickCallbacks();
		}

		// Token: 0x0603A704 RID: 239364 RVA: 0x00DE7364 File Offset: 0x00DE5564
		public void OnItemEffectShow(DangoBrawlItemUIEffectData data)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPrevSequence(false, true);
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemData.MyConfigId);
			string text = (dangoBrawlItemById != null) ? dangoBrawlItemById.GetValueOrDefault().UIAnimSeqName : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlayOrReplaySequenceByName(text, false, null);
		}

		// Token: 0x0603A705 RID: 239365 RVA: 0x00DE73DC File Offset: 0x00DE55DC
		private void BindClickCallbacks()
		{
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable == null)
			{
				return;
			}
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		}

		// Token: 0x0603A706 RID: 239366 RVA: 0x00DE7424 File Offset: 0x00DE5624
		private void UnbindClickCallbacks()
		{
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable == null)
			{
				return;
			}
			draggable.OnPointerUpCallBack.Unbind();
			draggable.OnPointerCancelCallBack.Unbind();
		}

		// Token: 0x0603A707 RID: 239367 RVA: 0x00DE7453 File Offset: 0x00DE5653
		[NullableContext(2)]
		private void OnPointerUp(ULGUIPointerEventData data)
		{
			if (this.ItemData == null)
			{
				return;
			}
			Action<DangoBrawlBattleBackpack> onClickItem = this.OnClickItem;
			if (onClickItem == null)
			{
				return;
			}
			onClickItem(this);
		}

		// Token: 0x0603A708 RID: 239368 RVA: 0x00DE746F File Offset: 0x00DE566F
		protected virtual void RefreshRotation(EDangoBrawlRotate val)
		{
			base.ApplyRotationToPnlRotate(val);
		}

		// Token: 0x0603A709 RID: 239369 RVA: 0x00DE7478 File Offset: 0x00DE5678
		protected override float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBattleScale;
		}

		// Token: 0x0603A70A RID: 239370 RVA: 0x00DE7484 File Offset: 0x00DE5684
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			UUITexture texture = base.GetTexture(10);
			if (texture != null)
			{
				textures.Add(texture);
			}
			UUITexture texture2 = base.GetTexture(11);
			if (texture2 != null)
			{
				textures.Add(texture2);
			}
		}

		// Token: 0x0603A70B RID: 239371 RVA: 0x00DE74BE File Offset: 0x00DE56BE
		public UUIItem GetCenterItem()
		{
			return this.RootItem;
		}

		// Token: 0x0401E738 RID: 124728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlBattleBackpack> OnClickItem;

		// Token: 0x0200BC64 RID: 48228
		[NullableContext(0)]
		protected enum EComponents
		{
			// Token: 0x04038D73 RID: 232819
			SprIconMask03 = 10,
			// Token: 0x04038D74 RID: 232820
			SprIconMask02
		}
	}
}

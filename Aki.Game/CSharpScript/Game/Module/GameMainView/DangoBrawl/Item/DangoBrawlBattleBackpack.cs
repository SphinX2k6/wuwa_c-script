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
	// Token: 0x020049E5 RID: 18917
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpack : DangoBrawlItemViewBase
	{
		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x0602F645 RID: 194117 RVA: 0x00D3778B File Offset: 0x00D3598B
		[Nullable(2)]
		public DangoBrawlBackpackItemData MyItemData
		{
			[NullableContext(2)]
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x0602F646 RID: 194118 RVA: 0x00D37798 File Offset: 0x00D35998
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
		}

		// Token: 0x0602F647 RID: 194119 RVA: 0x00D377D8 File Offset: 0x00D359D8
		public void RefreshOnShow(DangoBrawlNormalBagItemInfo info)
		{
			DangoBrawlBackPackItemServerData serverData = new DangoBrawlBackPackItemServerData(info);
			this.RefreshOnShow(new DangoBrawlBackpackItemData(serverData));
		}

		// Token: 0x0602F648 RID: 194120 RVA: 0x00D377F8 File Offset: 0x00D359F8
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

		// Token: 0x0602F649 RID: 194121 RVA: 0x00D37853 File Offset: 0x00D35A53
		public void BindData(ActivityDangoBrawlData actData, DangoBrawlBackpackItemData itemData, int gridSize = 0)
		{
			base.BindData(actData, itemData, gridSize);
		}

		// Token: 0x0602F64A RID: 194122 RVA: 0x00D37860 File Offset: 0x00D35A60
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

		// Token: 0x0602F64B RID: 194123 RVA: 0x00D378A1 File Offset: 0x00D35AA1
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

		// Token: 0x0602F64C RID: 194124 RVA: 0x00D378D5 File Offset: 0x00D35AD5
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnbindClickCallbacks();
		}

		// Token: 0x0602F64D RID: 194125 RVA: 0x00D378E4 File Offset: 0x00D35AE4
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

		// Token: 0x0602F64E RID: 194126 RVA: 0x00D3795C File Offset: 0x00D35B5C
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

		// Token: 0x0602F64F RID: 194127 RVA: 0x00D379A4 File Offset: 0x00D35BA4
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

		// Token: 0x0602F650 RID: 194128 RVA: 0x00D379D3 File Offset: 0x00D35BD3
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

		// Token: 0x0602F651 RID: 194129 RVA: 0x00D379EF File Offset: 0x00D35BEF
		protected virtual void RefreshRotation(EDangoBrawlRotate val)
		{
			base.ApplyRotationToPnlRotate(val);
		}

		// Token: 0x0602F652 RID: 194130 RVA: 0x00D379F8 File Offset: 0x00D35BF8
		protected override float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBattleScale;
		}

		// Token: 0x0602F653 RID: 194131 RVA: 0x00D37A04 File Offset: 0x00D35C04
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

		// Token: 0x0602F654 RID: 194132 RVA: 0x00D37A3E File Offset: 0x00D35C3E
		public UUIItem GetCenterItem()
		{
			return this.RootItem;
		}

		// Token: 0x040191DF RID: 102879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlBattleBackpack> OnClickItem;

		// Token: 0x0200A66D RID: 42605
		[NullableContext(0)]
		protected enum EComponents
		{
			// Token: 0x0403373F RID: 210751
			SprIconMask03 = 10,
			// Token: 0x04033740 RID: 210752
			SprIconMask02
		}
	}
}

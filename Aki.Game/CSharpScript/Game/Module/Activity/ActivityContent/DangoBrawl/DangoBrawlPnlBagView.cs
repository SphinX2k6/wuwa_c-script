using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005744 RID: 22340
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBagView : DangoBrawlViewItemBase
	{
		// Token: 0x17006A52 RID: 27218
		// (get) Token: 0x060370BB RID: 225467 RVA: 0x00F5CD12 File Offset: 0x00F5AF12
		private DangoBrawlBackpackItemData BagItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x17006A53 RID: 27219
		// (get) Token: 0x060370BC RID: 225468 RVA: 0x00F5CD1F File Offset: 0x00F5AF1F
		private DangoBrawlBenchItemData BenchItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBenchItemData;
			}
		}

		// Token: 0x17006A54 RID: 27220
		// (get) Token: 0x060370BD RID: 225469 RVA: 0x00F5CD2C File Offset: 0x00F5AF2C
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(11);
			}
		}

		// Token: 0x17006A55 RID: 27221
		// (get) Token: 0x060370BE RID: 225470 RVA: 0x00F5CD36 File Offset: 0x00F5AF36
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x060370BF RID: 225471 RVA: 0x00F5CD40 File Offset: 0x00F5AF40
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
		}

		// Token: 0x060370C0 RID: 225472 RVA: 0x00F5CDC4 File Offset: 0x00F5AFC4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBagView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBagView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060370C1 RID: 225473 RVA: 0x00F5CE07 File Offset: 0x00F5B007
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
		}

		// Token: 0x060370C2 RID: 225474 RVA: 0x00F5CE47 File Offset: 0x00F5B047
		protected override EDangoBrawlRotate GetBoundRotate()
		{
			if (this.BagItemData != null)
			{
				return this.BagItemData.MyRotation;
			}
			DangoBrawlBenchItemData benchItemData = this.BenchItemData;
			if (benchItemData == null)
			{
				return EDangoBrawlRotate.Direction0;
			}
			return benchItemData.MyRotation;
		}

		// Token: 0x060370C3 RID: 225475 RVA: 0x00F5CE70 File Offset: 0x00F5B070
		public override void RefreshView()
		{
			base.RefreshView();
			EDangoBrawlRotate boundRotate = this.GetBoundRotate();
			this.RefreshRotation(boundRotate);
			if (base.ShouldLayoutInGrid())
			{
				this.RefreshBagPosition();
			}
			this.RefreshMobileTips();
		}

		// Token: 0x060370C4 RID: 225476 RVA: 0x00F5CEA5 File Offset: 0x00F5B0A5
		[NullableContext(1)]
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			if (this.SprIconMask02 != null)
			{
				textures.Add(this.SprIconMask02);
			}
			if (this.SprIconMask03 != null)
			{
				textures.Add(this.SprIconMask03);
			}
		}

		// Token: 0x060370C5 RID: 225477 RVA: 0x00F5CED6 File Offset: 0x00F5B0D6
		protected override void RefreshRotation(EDangoBrawlRotate val)
		{
			this.RefreshPosFromRotate(val);
		}

		// Token: 0x060370C6 RID: 225478 RVA: 0x00F5CEE0 File Offset: 0x00F5B0E0
		private void InitFxScale()
		{
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(this.ItemData.MyConfigId, this.GetBoundRotate()));
			int item = boundSize.Item1;
			int item2 = boundSize.Item2;
			FVector relativeScale3D = new FVector((float)item2 * 0.5f, (float)item * 0.5f, 1f);
			UUIItem item3 = base.GetItem(12);
			if (item3 == null)
			{
				return;
			}
			item3.SetRelativeScale3D(relativeScale3D);
		}

		// Token: 0x060370C7 RID: 225479 RVA: 0x00F5CF44 File Offset: 0x00F5B144
		private void RefreshBagPosition()
		{
			if (this.BagItemData == null || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			PanelPos myLeftTopPos = this.BagItemData.MyLeftTopPos;
			this.RootItem.SetUIRelativeLocation(new FVector((float)(myLeftTopPos.ColIndex * this.GridSize), (float)(-(float)myLeftTopPos.RowIndex * this.GridSize), 0f));
		}

		// Token: 0x060370C8 RID: 225480 RVA: 0x00F5CFB0 File Offset: 0x00F5B1B0
		private void RefreshMobileTips()
		{
			DangoBrawlTouchController touch = base.Touch;
			EInputPlatform? einputPlatform = (touch != null) ? new EInputPlatform?(touch.GetInputPlatform()) : null;
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			EInputPlatform? einputPlatform2 = einputPlatform;
			EInputPlatform einputPlatform3 = EInputPlatform.Mobile;
			bool uiactive;
			if (einputPlatform2.GetValueOrDefault() == einputPlatform3 & einputPlatform2 != null)
			{
				InteractionStateMachine fsm = base.Fsm;
				if (fsm != null && fsm.CheckIsInState(base.Uid, EInteractionState.Holding))
				{
					DangoBrawlOperationDispatcher operations = base.Operations;
					uiactive = (operations != null && operations.CanExecute(EDangoBrawlOptionType.Confim, -1));
					goto IL_77;
				}
			}
			uiactive = false;
			IL_77:
			item.SetUIActive(uiactive);
		}

		// Token: 0x060370C9 RID: 225481 RVA: 0x00F5D039 File Offset: 0x00F5B239
		protected override void PlayLayerModeSequence(bool isIn)
		{
		}

		// Token: 0x060370CA RID: 225482 RVA: 0x00F5D03C File Offset: 0x00F5B23C
		protected override void OnPointerEnter(EToggleState _)
		{
			DangoBrawlTouchController touch = base.Touch;
			EInputPlatform? einputPlatform = (touch != null) ? new EInputPlatform?(touch.GetInputPlatform()) : null;
			EInputPlatform einputPlatform2 = EInputPlatform.Mobile;
			if (einputPlatform.GetValueOrDefault() == einputPlatform2 & einputPlatform != null)
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockHoverEffect())
			{
				return;
			}
			base.OnPointerEnter(_);
		}

		// Token: 0x060370CB RID: 225483 RVA: 0x00F5D08F File Offset: 0x00F5B28F
		protected override void OnPointerExit(EToggleState _)
		{
			base.OnPointerExit(_);
		}

		// Token: 0x060370CC RID: 225484 RVA: 0x00F5D098 File Offset: 0x00F5B298
		public override void OnDragSourceBegin()
		{
			base.OnDragSourceBegin();
			this.RefreshMobileTips();
		}

		// Token: 0x060370CD RID: 225485 RVA: 0x00F5D0A6 File Offset: 0x00F5B2A6
		public override void OnDragSourceEnd()
		{
			base.OnDragSourceEnd();
			this.RefreshMobileTips();
		}

		// Token: 0x060370CE RID: 225486 RVA: 0x00F5D0B4 File Offset: 0x00F5B2B4
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x060370CF RID: 225487 RVA: 0x00F5D0BC File Offset: 0x00F5B2BC
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x0200B320 RID: 45856
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037582 RID: 226690
			PnlMobileSwitch = 9,
			// Token: 0x04037583 RID: 226691
			SprIconMask03,
			// Token: 0x04037584 RID: 226692
			SprIconMask02,
			// Token: 0x04037585 RID: 226693
			ItemBenchDropFx
		}
	}
}

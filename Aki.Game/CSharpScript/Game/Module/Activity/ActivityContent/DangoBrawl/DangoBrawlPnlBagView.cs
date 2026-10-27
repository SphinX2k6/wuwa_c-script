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
	// Token: 0x020067F4 RID: 26612
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBagView : DangoBrawlViewItemBase
	{
		// Token: 0x17009711 RID: 38673
		// (get) Token: 0x06042566 RID: 271718 RVA: 0x0101B7CE File Offset: 0x010199CE
		private DangoBrawlBackpackItemData BagItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x17009712 RID: 38674
		// (get) Token: 0x06042567 RID: 271719 RVA: 0x0101B7DB File Offset: 0x010199DB
		private DangoBrawlBenchItemData BenchItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBenchItemData;
			}
		}

		// Token: 0x17009713 RID: 38675
		// (get) Token: 0x06042568 RID: 271720 RVA: 0x0101B7E8 File Offset: 0x010199E8
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(11);
			}
		}

		// Token: 0x17009714 RID: 38676
		// (get) Token: 0x06042569 RID: 271721 RVA: 0x0101B7F2 File Offset: 0x010199F2
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x0604256A RID: 271722 RVA: 0x0101B7FC File Offset: 0x010199FC
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
		}

		// Token: 0x0604256B RID: 271723 RVA: 0x0101B880 File Offset: 0x01019A80
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBagView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBagView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604256C RID: 271724 RVA: 0x0101B8C3 File Offset: 0x01019AC3
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
		}

		// Token: 0x0604256D RID: 271725 RVA: 0x0101B903 File Offset: 0x01019B03
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

		// Token: 0x0604256E RID: 271726 RVA: 0x0101B92C File Offset: 0x01019B2C
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

		// Token: 0x0604256F RID: 271727 RVA: 0x0101B961 File Offset: 0x01019B61
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

		// Token: 0x06042570 RID: 271728 RVA: 0x0101B992 File Offset: 0x01019B92
		protected override void RefreshRotation(EDangoBrawlRotate val)
		{
			this.RefreshPosFromRotate(val);
		}

		// Token: 0x06042571 RID: 271729 RVA: 0x0101B99C File Offset: 0x01019B9C
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

		// Token: 0x06042572 RID: 271730 RVA: 0x0101BA00 File Offset: 0x01019C00
		private void RefreshBagPosition()
		{
			if (this.BagItemData == null || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			PanelPos myLeftTopPos = this.BagItemData.MyLeftTopPos;
			this.RootItem.SetUIRelativeLocation(new FVector((float)(myLeftTopPos.ColIndex * this.GridSize), (float)(-(float)myLeftTopPos.RowIndex * this.GridSize), 0f));
		}

		// Token: 0x06042573 RID: 271731 RVA: 0x0101BA6C File Offset: 0x01019C6C
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

		// Token: 0x06042574 RID: 271732 RVA: 0x0101BAF5 File Offset: 0x01019CF5
		protected override void PlayLayerModeSequence(bool isIn)
		{
		}

		// Token: 0x06042575 RID: 271733 RVA: 0x0101BAF8 File Offset: 0x01019CF8
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

		// Token: 0x06042576 RID: 271734 RVA: 0x0101BB4B File Offset: 0x01019D4B
		protected override void OnPointerExit(EToggleState _)
		{
			base.OnPointerExit(_);
		}

		// Token: 0x06042577 RID: 271735 RVA: 0x0101BB54 File Offset: 0x01019D54
		public override void OnDragSourceBegin()
		{
			base.OnDragSourceBegin();
			this.RefreshMobileTips();
		}

		// Token: 0x06042578 RID: 271736 RVA: 0x0101BB62 File Offset: 0x01019D62
		public override void OnDragSourceEnd()
		{
			base.OnDragSourceEnd();
			this.RefreshMobileTips();
		}

		// Token: 0x06042579 RID: 271737 RVA: 0x0101BB70 File Offset: 0x01019D70
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x0604257A RID: 271738 RVA: 0x0101BB78 File Offset: 0x01019D78
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x0200C953 RID: 51539
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CC95 RID: 248981
			PnlMobileSwitch = 9,
			// Token: 0x0403CC96 RID: 248982
			SprIconMask03,
			// Token: 0x0403CC97 RID: 248983
			SprIconMask02,
			// Token: 0x0403CC98 RID: 248984
			ItemBenchDropFx
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF1 RID: 19697
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class RoleVisionCommonItem : UiPanelBase
	{
		// Token: 0x06032E07 RID: 208391 RVA: 0x00BDBDBE File Offset: 0x00BD9FBE
		[NullableContext(1)]
		public RoleVisionCommonItem(UUIItem uiItem, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData, bool needRedDot = false, bool needShowOccupyDetail = false, ERoleViewSource source = ERoleViewSource.Normal)
		{
			this.CurrentIndex = new EPhantomItemIndex?(index);
			this.SourceItem = uiItem;
			this.RoleData = roleData;
			this.NeedRedDot = needRedDot;
			this.NeedShowOccupyDetail = needShowOccupyDetail;
			this.Source = source;
		}

		// Token: 0x06032E08 RID: 208392 RVA: 0x00BDBDF8 File Offset: 0x00BD9FF8
		public UniTask Init()
		{
			RoleVisionCommonItem.<Init>d__10 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoleVisionCommonItem.<Init>d__10>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06032E09 RID: 208393 RVA: 0x00BDBE3B File Offset: 0x00BDA03B
		public void OnDragItemDragBegin(int _)
		{
			this.OnDragBegin();
		}

		// Token: 0x06032E0A RID: 208394 RVA: 0x00BDBE43 File Offset: 0x00BDA043
		public void OnDragItemDragEnd(int _)
		{
			this.OnDragEnd();
		}

		// Token: 0x06032E0B RID: 208395 RVA: 0x00BDBE4B File Offset: 0x00BDA04B
		protected virtual void OnDragBegin()
		{
		}

		// Token: 0x06032E0C RID: 208396 RVA: 0x00BDBE4D File Offset: 0x00BDA04D
		protected virtual void OnDragEnd()
		{
		}

		// Token: 0x06032E0D RID: 208397 RVA: 0x00BDBE4F File Offset: 0x00BDA04F
		public void SetShowType(int type)
		{
			this.ShowType = type;
		}

		// Token: 0x06032E0E RID: 208398 RVA: 0x00BDBE58 File Offset: 0x00BDA058
		public void ResetPosition()
		{
			this.OnResetPosition();
		}

		// Token: 0x06032E0F RID: 208399 RVA: 0x00BDBE60 File Offset: 0x00BDA060
		protected virtual void OnResetPosition()
		{
		}

		// Token: 0x06032E10 RID: 208400 RVA: 0x00BDBE62 File Offset: 0x00BDA062
		public void SetAnimationState(bool state)
		{
			this.AnimationState = state;
			this.OnChangeAnimationState();
		}

		// Token: 0x06032E11 RID: 208401 RVA: 0x00BDBE71 File Offset: 0x00BDA071
		protected virtual void OnChangeAnimationState()
		{
		}

		// Token: 0x06032E12 RID: 208402 RVA: 0x00BDBE73 File Offset: 0x00BDA073
		public int GetCurrentIndex()
		{
			return (int)this.CurrentIndex.Value;
		}

		// Token: 0x17007DAC RID: 32172
		// (get) Token: 0x06032E13 RID: 208403 RVA: 0x00BDBE80 File Offset: 0x00BDA080
		[Nullable(1)]
		protected Action<EToggleState> OnClickVision
		{
			[NullableContext(1)]
			get
			{
				return delegate(EToggleState toggleState)
				{
				};
			}
		}

		// Token: 0x06032E14 RID: 208404 RVA: 0x00BDBEA1 File Offset: 0x00BDA0A1
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06032E15 RID: 208405 RVA: 0x00BDBEA9 File Offset: 0x00BDA0A9
		public virtual void SetAniLightState(bool state)
		{
		}

		// Token: 0x06032E16 RID: 208406 RVA: 0x00BDBEAB File Offset: 0x00BDA0AB
		public void UpdateItem(PhantomDataBase data, RoleDataBase roleData)
		{
			this.CurrentData = data;
			this.RoleData = (roleData ?? this.RoleData);
			this.RefreshPlusItem(data);
			this.RefreshIcon(data);
			this.RefreshQuality(data);
			this.OnUpdateItem(data);
		}

		// Token: 0x06032E17 RID: 208407 RVA: 0x00BDBEE4 File Offset: 0x00BDA0E4
		private void RefreshIcon(PhantomDataBase data)
		{
			this.GetVisionTextureComponent().SetUIActive(data != null);
			if (data == null)
			{
				return;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.GetConfigId(true));
			base.SetTextureByPath(itemConfigData.IconMiddle, this.GetVisionTextureComponent(), new EUiViewName?(EUiViewName.VisionEquipmentView), null);
		}

		// Token: 0x06032E18 RID: 208408 RVA: 0x00BDBF33 File Offset: 0x00BDA133
		private void RefreshQuality(PhantomDataBase data)
		{
			this.GetVisionQualitySprite().SetUIActive(data != null);
		}

		// Token: 0x06032E19 RID: 208409 RVA: 0x00BDBF44 File Offset: 0x00BDA144
		[NullableContext(1)]
		public void PlaySequence(string sequence)
		{
			this.OnPlaySequence(sequence);
		}

		// Token: 0x06032E1A RID: 208410 RVA: 0x00BDBF4D File Offset: 0x00BDA14D
		[NullableContext(1)]
		protected virtual void OnPlaySequence(string sequence)
		{
		}

		// Token: 0x06032E1B RID: 208411 RVA: 0x00BDBF4F File Offset: 0x00BDA14F
		private void RefreshPlusItem(PhantomDataBase data)
		{
		}

		// Token: 0x06032E1C RID: 208412 RVA: 0x00BDBF51 File Offset: 0x00BDA151
		public void SetSelected()
		{
			this.OnSelected();
		}

		// Token: 0x06032E1D RID: 208413 RVA: 0x00BDBF59 File Offset: 0x00BDA159
		protected virtual void OnSelected()
		{
		}

		// Token: 0x06032E1E RID: 208414 RVA: 0x00BDBF5B File Offset: 0x00BDA15B
		public void SetUnSelected()
		{
			this.OnUnSelected();
		}

		// Token: 0x06032E1F RID: 208415 RVA: 0x00BDBF63 File Offset: 0x00BDA163
		protected virtual void OnUnSelected()
		{
		}

		// Token: 0x06032E20 RID: 208416 RVA: 0x00BDBF65 File Offset: 0x00BDA165
		protected virtual void OnUpdateItem(PhantomDataBase data)
		{
		}

		// Token: 0x06032E21 RID: 208417 RVA: 0x00BDBF67 File Offset: 0x00BDA167
		public void OnUnOverlay(int _)
		{
			this.OnItemUnOverlay();
		}

		// Token: 0x06032E22 RID: 208418 RVA: 0x00BDBF6F File Offset: 0x00BDA16F
		protected virtual void OnItemUnOverlay()
		{
		}

		// Token: 0x06032E23 RID: 208419 RVA: 0x00BDBF71 File Offset: 0x00BDA171
		public void OnOverlay(int _)
		{
			this.OnItemOverlay();
		}

		// Token: 0x06032E24 RID: 208420 RVA: 0x00BDBF79 File Offset: 0x00BDA179
		public void OnScrollToScrollView(int _)
		{
			this.OnScrollToScrollViewEvent();
		}

		// Token: 0x06032E25 RID: 208421 RVA: 0x00BDBF81 File Offset: 0x00BDA181
		protected virtual void OnScrollToScrollViewEvent()
		{
		}

		// Token: 0x06032E26 RID: 208422 RVA: 0x00BDBF83 File Offset: 0x00BDA183
		public void OnRemoveFromScrollView(int _)
		{
			this.OnRemoveFromScrollViewEvent();
		}

		// Token: 0x06032E27 RID: 208423 RVA: 0x00BDBF8B File Offset: 0x00BDA18B
		protected virtual void OnRemoveFromScrollViewEvent()
		{
		}

		// Token: 0x06032E28 RID: 208424 RVA: 0x00BDBF8D File Offset: 0x00BDA18D
		protected virtual void OnItemOverlay()
		{
		}

		// Token: 0x06032E29 RID: 208425 RVA: 0x00BDBF8F File Offset: 0x00BDA18F
		protected override void OnBeforeDestroy()
		{
			this.OnBeforeClearComponent();
		}

		// Token: 0x06032E2A RID: 208426 RVA: 0x00BDBF97 File Offset: 0x00BDA197
		public void SetToggleState(EToggleState state, bool fireEvent = false, bool ignoreAniState = false)
		{
			if (this.GetSelectToggle().ToggleState != state)
			{
				this.GetSelectToggle().SetToggleStateForce(state, fireEvent, ignoreAniState, false);
			}
		}

		// Token: 0x06032E2B RID: 208427 RVA: 0x00BDBFB6 File Offset: 0x00BDA1B6
		protected virtual void OnBeforeClearComponent()
		{
		}

		// Token: 0x06032E2C RID: 208428
		protected abstract UUITexture GetVisionTextureComponent();

		// Token: 0x06032E2D RID: 208429
		protected abstract UUISprite GetVisionQualitySprite();

		// Token: 0x06032E2E RID: 208430
		protected abstract UUIItem GetVisionCostItem();

		// Token: 0x06032E2F RID: 208431
		protected abstract UUIText GetVisionCostText();

		// Token: 0x06032E30 RID: 208432
		public abstract UUIDraggableComponent GetDragComponent();

		// Token: 0x06032E31 RID: 208433
		protected abstract UUIExtendToggle GetSelectToggle();

		// Token: 0x06032E32 RID: 208434
		protected abstract UUIItem GetPlusItem();

		// Token: 0x0401B106 RID: 110854
		protected bool AnimationState;

		// Token: 0x0401B107 RID: 110855
		protected EPhantomItemIndex? CurrentIndex;

		// Token: 0x0401B108 RID: 110856
		protected PhantomDataBase CurrentData;

		// Token: 0x0401B109 RID: 110857
		protected RoleDataBase RoleData;

		// Token: 0x0401B10A RID: 110858
		protected int ShowType;

		// Token: 0x0401B10B RID: 110859
		private readonly UUIItem SourceItem;

		// Token: 0x0401B10C RID: 110860
		protected bool NeedRedDot;

		// Token: 0x0401B10D RID: 110861
		protected bool NeedShowOccupyDetail;

		// Token: 0x0401B10E RID: 110862
		protected ERoleViewSource Source;
	}
}

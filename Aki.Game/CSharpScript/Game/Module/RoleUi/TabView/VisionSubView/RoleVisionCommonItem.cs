using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA3 RID: 15523
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class RoleVisionCommonItem : UiPanelBase
	{
		// Token: 0x06027BE2 RID: 162786 RVA: 0x00B216C6 File Offset: 0x00B1F8C6
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

		// Token: 0x06027BE3 RID: 162787 RVA: 0x00B21700 File Offset: 0x00B1F900
		public UniTask Init()
		{
			RoleVisionCommonItem.<Init>d__10 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoleVisionCommonItem.<Init>d__10>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06027BE4 RID: 162788 RVA: 0x00B21743 File Offset: 0x00B1F943
		public void OnDragItemDragBegin(int _)
		{
			this.OnDragBegin();
		}

		// Token: 0x06027BE5 RID: 162789 RVA: 0x00B2174B File Offset: 0x00B1F94B
		public void OnDragItemDragEnd(int _)
		{
			this.OnDragEnd();
		}

		// Token: 0x06027BE6 RID: 162790 RVA: 0x00B21753 File Offset: 0x00B1F953
		protected virtual void OnDragBegin()
		{
		}

		// Token: 0x06027BE7 RID: 162791 RVA: 0x00B21755 File Offset: 0x00B1F955
		protected virtual void OnDragEnd()
		{
		}

		// Token: 0x06027BE8 RID: 162792 RVA: 0x00B21757 File Offset: 0x00B1F957
		public void SetShowType(int type)
		{
			this.ShowType = type;
		}

		// Token: 0x06027BE9 RID: 162793 RVA: 0x00B21760 File Offset: 0x00B1F960
		public void ResetPosition()
		{
			this.OnResetPosition();
		}

		// Token: 0x06027BEA RID: 162794 RVA: 0x00B21768 File Offset: 0x00B1F968
		protected virtual void OnResetPosition()
		{
		}

		// Token: 0x06027BEB RID: 162795 RVA: 0x00B2176A File Offset: 0x00B1F96A
		public void SetAnimationState(bool state)
		{
			this.AnimationState = state;
			this.OnChangeAnimationState();
		}

		// Token: 0x06027BEC RID: 162796 RVA: 0x00B21779 File Offset: 0x00B1F979
		protected virtual void OnChangeAnimationState()
		{
		}

		// Token: 0x06027BED RID: 162797 RVA: 0x00B2177B File Offset: 0x00B1F97B
		public int GetCurrentIndex()
		{
			return (int)this.CurrentIndex.Value;
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x06027BEE RID: 162798 RVA: 0x00B21788 File Offset: 0x00B1F988
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

		// Token: 0x06027BEF RID: 162799 RVA: 0x00B217A9 File Offset: 0x00B1F9A9
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06027BF0 RID: 162800 RVA: 0x00B217B1 File Offset: 0x00B1F9B1
		public virtual void SetAniLightState(bool state)
		{
		}

		// Token: 0x06027BF1 RID: 162801 RVA: 0x00B217B3 File Offset: 0x00B1F9B3
		public void UpdateItem(PhantomDataBase data, RoleDataBase roleData)
		{
			this.CurrentData = data;
			this.RoleData = (roleData ?? this.RoleData);
			this.RefreshPlusItem(data);
			this.RefreshIcon(data);
			this.RefreshQuality(data);
			this.OnUpdateItem(data);
		}

		// Token: 0x06027BF2 RID: 162802 RVA: 0x00B217EC File Offset: 0x00B1F9EC
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

		// Token: 0x06027BF3 RID: 162803 RVA: 0x00B2183B File Offset: 0x00B1FA3B
		private void RefreshQuality(PhantomDataBase data)
		{
			this.GetVisionQualitySprite().SetUIActive(data != null);
		}

		// Token: 0x06027BF4 RID: 162804 RVA: 0x00B2184C File Offset: 0x00B1FA4C
		[NullableContext(1)]
		public void PlaySequence(string sequence)
		{
			this.OnPlaySequence(sequence);
		}

		// Token: 0x06027BF5 RID: 162805 RVA: 0x00B21855 File Offset: 0x00B1FA55
		[NullableContext(1)]
		protected virtual void OnPlaySequence(string sequence)
		{
		}

		// Token: 0x06027BF6 RID: 162806 RVA: 0x00B21857 File Offset: 0x00B1FA57
		private void RefreshPlusItem(PhantomDataBase data)
		{
		}

		// Token: 0x06027BF7 RID: 162807 RVA: 0x00B21859 File Offset: 0x00B1FA59
		public void SetSelected()
		{
			this.OnSelected();
		}

		// Token: 0x06027BF8 RID: 162808 RVA: 0x00B21861 File Offset: 0x00B1FA61
		protected virtual void OnSelected()
		{
		}

		// Token: 0x06027BF9 RID: 162809 RVA: 0x00B21863 File Offset: 0x00B1FA63
		public void SetUnSelected()
		{
			this.OnUnSelected();
		}

		// Token: 0x06027BFA RID: 162810 RVA: 0x00B2186B File Offset: 0x00B1FA6B
		protected virtual void OnUnSelected()
		{
		}

		// Token: 0x06027BFB RID: 162811 RVA: 0x00B2186D File Offset: 0x00B1FA6D
		protected virtual void OnUpdateItem(PhantomDataBase data)
		{
		}

		// Token: 0x06027BFC RID: 162812 RVA: 0x00B2186F File Offset: 0x00B1FA6F
		public void OnUnOverlay(int _)
		{
			this.OnItemUnOverlay();
		}

		// Token: 0x06027BFD RID: 162813 RVA: 0x00B21877 File Offset: 0x00B1FA77
		protected virtual void OnItemUnOverlay()
		{
		}

		// Token: 0x06027BFE RID: 162814 RVA: 0x00B21879 File Offset: 0x00B1FA79
		public void OnOverlay(int _)
		{
			this.OnItemOverlay();
		}

		// Token: 0x06027BFF RID: 162815 RVA: 0x00B21881 File Offset: 0x00B1FA81
		public void OnScrollToScrollView(int _)
		{
			this.OnScrollToScrollViewEvent();
		}

		// Token: 0x06027C00 RID: 162816 RVA: 0x00B21889 File Offset: 0x00B1FA89
		protected virtual void OnScrollToScrollViewEvent()
		{
		}

		// Token: 0x06027C01 RID: 162817 RVA: 0x00B2188B File Offset: 0x00B1FA8B
		public void OnRemoveFromScrollView(int _)
		{
			this.OnRemoveFromScrollViewEvent();
		}

		// Token: 0x06027C02 RID: 162818 RVA: 0x00B21893 File Offset: 0x00B1FA93
		protected virtual void OnRemoveFromScrollViewEvent()
		{
		}

		// Token: 0x06027C03 RID: 162819 RVA: 0x00B21895 File Offset: 0x00B1FA95
		protected virtual void OnItemOverlay()
		{
		}

		// Token: 0x06027C04 RID: 162820 RVA: 0x00B21897 File Offset: 0x00B1FA97
		protected override void OnBeforeDestroy()
		{
			this.OnBeforeClearComponent();
		}

		// Token: 0x06027C05 RID: 162821 RVA: 0x00B2189F File Offset: 0x00B1FA9F
		public void SetToggleState(EToggleState state, bool fireEvent = false, bool ignoreAniState = false)
		{
			if (this.GetSelectToggle().ToggleState != state)
			{
				this.GetSelectToggle().SetToggleStateForce(state, fireEvent, ignoreAniState, false);
			}
		}

		// Token: 0x06027C06 RID: 162822 RVA: 0x00B218BE File Offset: 0x00B1FABE
		protected virtual void OnBeforeClearComponent()
		{
		}

		// Token: 0x06027C07 RID: 162823
		protected abstract UUITexture GetVisionTextureComponent();

		// Token: 0x06027C08 RID: 162824
		protected abstract UUISprite GetVisionQualitySprite();

		// Token: 0x06027C09 RID: 162825
		protected abstract UUIItem GetVisionCostItem();

		// Token: 0x06027C0A RID: 162826
		protected abstract UUIText GetVisionCostText();

		// Token: 0x06027C0B RID: 162827
		public abstract UUIDraggableComponent GetDragComponent();

		// Token: 0x06027C0C RID: 162828
		protected abstract UUIExtendToggle GetSelectToggle();

		// Token: 0x06027C0D RID: 162829
		protected abstract UUIItem GetPlusItem();

		// Token: 0x04015A8B RID: 88715
		protected bool AnimationState;

		// Token: 0x04015A8C RID: 88716
		protected EPhantomItemIndex? CurrentIndex;

		// Token: 0x04015A8D RID: 88717
		protected PhantomDataBase CurrentData;

		// Token: 0x04015A8E RID: 88718
		protected RoleDataBase RoleData;

		// Token: 0x04015A8F RID: 88719
		protected int ShowType;

		// Token: 0x04015A90 RID: 88720
		private readonly UUIItem SourceItem;

		// Token: 0x04015A91 RID: 88721
		protected bool NeedRedDot;

		// Token: 0x04015A92 RID: 88722
		protected bool NeedShowOccupyDetail;

		// Token: 0x04015A93 RID: 88723
		protected ERoleViewSource Source;
	}
}

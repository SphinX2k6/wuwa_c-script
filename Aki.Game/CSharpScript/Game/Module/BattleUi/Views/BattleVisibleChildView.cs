using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CDC RID: 23772
	public class BattleVisibleChildView : BattleChildView
	{
		// Token: 0x0603C277 RID: 246391 RVA: 0x00E666B4 File Offset: 0x00E648B4
		protected void InitChildType(EBattleUiChild childType = EBattleUiChild.Common)
		{
			this.ChildType = childType;
			if (this.ChildType == EBattleUiChild.Ignore)
			{
				this.BaseVisible = true;
				this.InnerVisibleState = 1;
				return;
			}
			this.ChildViewData = BattleUiModel.Instance.ChildViewData;
			this.BaseVisible = this.ChildViewData.GetChildVisible(childType);
			this.InnerVisibleState = 1;
			this.ChildViewData.AddCallback(childType, new Action(this.OnBattleUiChildVisibleChanged));
		}

		// Token: 0x0603C278 RID: 246392 RVA: 0x00E66724 File Offset: 0x00E64924
		public virtual void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			this.IsEnable = true;
			this.SetVisibleInner(0, true);
			bool visible = this.GetVisible();
			if (visible || !checkVisible)
			{
				this.SetActive(visible);
			}
			if (visible)
			{
				this.OnShowBattleChildView();
			}
		}

		// Token: 0x0603C279 RID: 246393 RVA: 0x00E6675D File Offset: 0x00E6495D
		public virtual void HideBattleVisibleChildView()
		{
			this.IsEnable = false;
			bool visible = this.GetVisible();
			this.SetVisibleInner(0, false);
			this.SetActive(this.GetVisible());
			if (visible)
			{
				this.OnHideBattleChildView();
			}
		}

		// Token: 0x0603C27A RID: 246394 RVA: 0x00E66788 File Offset: 0x00E64988
		public override void Reset()
		{
			this.SetVisibleInner(0, false);
			if (this.ChildViewData != null)
			{
				this.ChildViewData.RemoveCallback(this.ChildType, new Action(this.OnBattleUiChildVisibleChanged));
				this.ChildViewData = null;
			}
			base.Reset();
		}

		// Token: 0x0603C27B RID: 246395 RVA: 0x00E667C4 File Offset: 0x00E649C4
		public void ClearChildViewData()
		{
			if (this.ChildViewData != null)
			{
				this.ChildViewData.RemoveCallback(this.ChildType, new Action(this.OnBattleUiChildVisibleChanged));
				this.ChildViewData = null;
			}
		}

		// Token: 0x0603C27C RID: 246396 RVA: 0x00E667F4 File Offset: 0x00E649F4
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x0603C27D RID: 246397 RVA: 0x00E6682E File Offset: 0x00E64A2E
		private void OnBattleUiChildVisibleChanged()
		{
			this.NotifyVisibleChanged();
		}

		// Token: 0x0603C27E RID: 246398 RVA: 0x00E66838 File Offset: 0x00E64A38
		private void NotifyVisibleChanged()
		{
			if (this.ChildViewData == null)
			{
				return;
			}
			bool visible = this.GetVisible();
			this.BaseVisible = this.ChildViewData.GetChildVisible(this.ChildType);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603C27F RID: 246399 RVA: 0x00E66874 File Offset: 0x00E64A74
		public void SetVisible(int visibleReason, bool bVisible)
		{
			bool visible = this.GetVisible();
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603C280 RID: 246400 RVA: 0x00E66898 File Offset: 0x00E64A98
		private void CheckVisibleChange(bool oldVisible)
		{
			if (!this.IsEnable)
			{
				return;
			}
			bool visible = this.GetVisible();
			if (oldVisible == visible)
			{
				return;
			}
			this.SetActive(visible);
			if (visible)
			{
				this.OnShowBattleChildView();
				return;
			}
			this.OnHideBattleChildView();
		}

		// Token: 0x0603C281 RID: 246401 RVA: 0x00E668D1 File Offset: 0x00E64AD1
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x0603C282 RID: 246402 RVA: 0x00E668E6 File Offset: 0x00E64AE6
		public bool GetVisible()
		{
			return this.BaseVisible && this.InnerVisibleState == 0;
		}

		// Token: 0x0603C283 RID: 246403 RVA: 0x00E668FB File Offset: 0x00E64AFB
		protected override void OnShowBattleChildView()
		{
		}

		// Token: 0x0603C284 RID: 246404 RVA: 0x00E668FD File Offset: 0x00E64AFD
		protected override void OnHideBattleChildView()
		{
		}

		// Token: 0x0401F5C0 RID: 128448
		[Nullable(2)]
		protected BattleUiChildViewData ChildViewData;

		// Token: 0x0401F5C1 RID: 128449
		protected EBattleUiChild ChildType;

		// Token: 0x0401F5C2 RID: 128450
		protected bool BaseVisible;

		// Token: 0x0401F5C3 RID: 128451
		protected bool IsEnable;

		// Token: 0x0401F5C4 RID: 128452
		protected int InnerVisibleState;
	}
}

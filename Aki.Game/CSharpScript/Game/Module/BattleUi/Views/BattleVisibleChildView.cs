using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBE RID: 19646
	public class BattleVisibleChildView : BattleChildView
	{
		// Token: 0x060311CD RID: 201165 RVA: 0x00DB6C68 File Offset: 0x00DB4E68
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

		// Token: 0x060311CE RID: 201166 RVA: 0x00DB6CD8 File Offset: 0x00DB4ED8
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

		// Token: 0x060311CF RID: 201167 RVA: 0x00DB6D11 File Offset: 0x00DB4F11
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

		// Token: 0x060311D0 RID: 201168 RVA: 0x00DB6D3C File Offset: 0x00DB4F3C
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

		// Token: 0x060311D1 RID: 201169 RVA: 0x00DB6D78 File Offset: 0x00DB4F78
		public void ClearChildViewData()
		{
			if (this.ChildViewData != null)
			{
				this.ChildViewData.RemoveCallback(this.ChildType, new Action(this.OnBattleUiChildVisibleChanged));
				this.ChildViewData = null;
			}
		}

		// Token: 0x060311D2 RID: 201170 RVA: 0x00DB6DA8 File Offset: 0x00DB4FA8
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x060311D3 RID: 201171 RVA: 0x00DB6DE2 File Offset: 0x00DB4FE2
		private void OnBattleUiChildVisibleChanged()
		{
			this.NotifyVisibleChanged();
		}

		// Token: 0x060311D4 RID: 201172 RVA: 0x00DB6DEC File Offset: 0x00DB4FEC
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

		// Token: 0x060311D5 RID: 201173 RVA: 0x00DB6E28 File Offset: 0x00DB5028
		public void SetVisible(int visibleReason, bool bVisible)
		{
			bool visible = this.GetVisible();
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x060311D6 RID: 201174 RVA: 0x00DB6E4C File Offset: 0x00DB504C
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

		// Token: 0x060311D7 RID: 201175 RVA: 0x00DB6E85 File Offset: 0x00DB5085
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x060311D8 RID: 201176 RVA: 0x00DB6E9A File Offset: 0x00DB509A
		public bool GetVisible()
		{
			return this.BaseVisible && this.InnerVisibleState == 0;
		}

		// Token: 0x060311D9 RID: 201177 RVA: 0x00DB6EAF File Offset: 0x00DB50AF
		protected override void OnShowBattleChildView()
		{
		}

		// Token: 0x060311DA RID: 201178 RVA: 0x00DB6EB1 File Offset: 0x00DB50B1
		protected override void OnHideBattleChildView()
		{
		}

		// Token: 0x0401A079 RID: 106617
		[Nullable(2)]
		protected BattleUiChildViewData ChildViewData;

		// Token: 0x0401A07A RID: 106618
		protected EBattleUiChild ChildType;

		// Token: 0x0401A07B RID: 106619
		protected bool BaseVisible;

		// Token: 0x0401A07C RID: 106620
		protected bool IsEnable;

		// Token: 0x0401A07D RID: 106621
		protected int InnerVisibleState;
	}
}

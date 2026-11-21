using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450B RID: 17675
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemTopRightIconHandle : MarkItemComponentHandle<MarkPanelBase>
	{
		// Token: 0x0602C9E3 RID: 182755 RVA: 0x00C85046 File Offset: 0x00C83246
		public MarkItemTopRightIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9E4 RID: 182756 RVA: 0x00C8504F File Offset: 0x00C8324F
		protected override void OnInit()
		{
			this.Context.MarkItem.TopRightIconPath = UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
			base.Update();
			base.ApplyModified();
		}

		// Token: 0x0602C9E5 RID: 182757 RVA: 0x00C8507C File Offset: 0x00C8327C
		protected override void OnUpdate()
		{
			MarkItem markItem = this.Context.MarkItem;
			bool flag = MapModel.Instance.IsMarkDisable(markItem.MarkId, markItem.IsMarkDisabled());
			string markTopRightIconPath = MarkItemDataUtil.GetMarkTopRightIconPath(markItem.MarkId, markItem.MarkType, flag, !flag && markItem.IsGamePlayFinishWithReward);
			if (!string.IsNullOrEmpty(markTopRightIconPath))
			{
				base.SetVisible(true);
				markItem.TopRightIconPath = markTopRightIconPath;
				this.Context.SetSpriteByPathAction(markTopRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				return;
			}
			base.SetVisible(false);
		}

		// Token: 0x0602C9E6 RID: 182758 RVA: 0x00C85110 File Offset: 0x00C83310
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItem.ShowTopRightIcon = active;
		}

		// Token: 0x0602C9E7 RID: 182759 RVA: 0x00C85123 File Offset: 0x00C83323
		public override void ResetVisibleState()
		{
			base.ResetVisibleState();
			base.MarkVisibleDirty();
		}

		// Token: 0x0602C9E8 RID: 182760 RVA: 0x00C85134 File Offset: 0x00C83334
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				this.Context.TopRightIconSprite.SetUIActive(visible);
				EventSystem.Instance.Emit(EEventName.OnMarkTopRightIconUpdate);
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005539 RID: 21817
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemTopRightIconHandle : MarkItemComponentHandle<MarkPanelBase>
	{
		// Token: 0x06037B13 RID: 228115 RVA: 0x00D374F3 File Offset: 0x00D356F3
		public MarkItemTopRightIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B14 RID: 228116 RVA: 0x00D374FC File Offset: 0x00D356FC
		protected override void OnInit()
		{
			this.Context.MarkItemEntity.Resource.TopRightIconPath = UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
			base.Update();
			base.ApplyModified();
		}

		// Token: 0x06037B15 RID: 228117 RVA: 0x00D37530 File Offset: 0x00D35730
		protected override void OnUpdate()
		{
			MarkItemEntity markItemEntity = this.Context.MarkItemEntity;
			MarkGamePlayComponent gamePlay = markItemEntity.GamePlay;
			bool isDisable = gamePlay.IsDisable;
			string markTopRightIconPath = MarkItemDataUtil.GetMarkTopRightIconPath(gamePlay.MarkId, gamePlay.MarkType, isDisable, !isDisable && gamePlay.IsFinish);
			if (!string.IsNullOrEmpty(markTopRightIconPath))
			{
				base.SetVisible(true);
				markItemEntity.Resource.TopRightIconPath = markTopRightIconPath;
				this.Context.SetSpriteByPathAction(markTopRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				return;
			}
			base.SetVisible(false);
		}

		// Token: 0x06037B16 RID: 228118 RVA: 0x00D375C1 File Offset: 0x00D357C1
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.TopRightIcon, active);
		}

		// Token: 0x06037B17 RID: 228119 RVA: 0x00D375DC File Offset: 0x00D357DC
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.TopRightIcon))
			{
				bool uiactive = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.TopRightIcon, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.TopRightIcon);
				this.Context.TopRightIconSprite.SetUIActive(uiactive);
				EventSystem.Instance.Emit(EEventName.OnMarkTopRightIconUpdate);
			}
		}
	}
}

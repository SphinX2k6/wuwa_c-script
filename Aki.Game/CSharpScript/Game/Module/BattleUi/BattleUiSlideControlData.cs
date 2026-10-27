using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA0 RID: 23712
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSlideControlData
	{
		// Token: 0x0603BEA1 RID: 245409 RVA: 0x00E50F20 File Offset: 0x00E4F120
		public void OnPress(UUIItem item, float x, float y)
		{
			this.CurItem = item;
			this.Position.Set((double)x, (double)y);
			this.SetVisible(true);
			this.TouchBeginPos.Set(0.0, 0.0);
			this.TouchMoveDir.Set(0.0, 0.0);
		}

		// Token: 0x0603BEA2 RID: 245410 RVA: 0x00E50F84 File Offset: 0x00E4F184
		public void OnRelease(UUIItem item)
		{
			if (this.CurItem != item)
			{
				return;
			}
			this.CurItem = null;
			this.SetVisible(false);
			this.TouchBeginPos.Set(0.0, 0.0);
			this.TouchMoveDir.Set(0.0, 0.0);
		}

		// Token: 0x0603BEA3 RID: 245411 RVA: 0x00E50FE4 File Offset: 0x00E4F1E4
		public void OnTouch(InputDistributeDefine.ITouchData touchData)
		{
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchBegin)
			{
				this.TouchBeginPos.Set(touchData.TouchPosition.X, touchData.TouchPosition.Y);
				this.TouchMoveDir.Set(0.0, 0.0);
				this.TouchId = touchData.TouchId;
				return;
			}
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
			{
				this.TouchMoveDir.Set(touchData.TouchPosition.X - this.TouchBeginPos.X, touchData.TouchPosition.Y - this.TouchBeginPos.Y);
			}
		}

		// Token: 0x0603BEA4 RID: 245412 RVA: 0x00E51086 File Offset: 0x00E4F286
		public void Preload()
		{
		}

		// Token: 0x0603BEA5 RID: 245413 RVA: 0x00E51088 File Offset: 0x00E4F288
		public void ForceStop()
		{
			this.SetVisible(false);
			this.CurItem = null;
		}

		// Token: 0x0603BEA6 RID: 245414 RVA: 0x00E51098 File Offset: 0x00E4F298
		public bool GetVisible()
		{
			return this.Visible;
		}

		// Token: 0x0603BEA7 RID: 245415 RVA: 0x00E510A0 File Offset: 0x00E4F2A0
		public void SetVisible(bool visible)
		{
			this.Visible = visible;
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiSlideControlVisibleChanged, visible);
		}

		// Token: 0x0401F41F RID: 128031
		private bool Visible;

		// Token: 0x0401F420 RID: 128032
		public readonly Vector2D Position = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401F421 RID: 128033
		[Nullable(2)]
		private UUIItem CurItem;

		// Token: 0x0401F422 RID: 128034
		private readonly Vector2D TouchBeginPos = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401F423 RID: 128035
		public Vector2D TouchMoveDir = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401F424 RID: 128036
		public int TouchId = -1;
	}
}

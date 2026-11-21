using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C82 RID: 19586
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSlideControlData
	{
		// Token: 0x06030DF4 RID: 200180 RVA: 0x00DA15C0 File Offset: 0x00D9F7C0
		public void OnPress(UUIItem item, float x, float y)
		{
			this.CurItem = item;
			this.Position.Set((double)x, (double)y);
			this.SetVisible(true);
			this.TouchBeginPos.Set(0.0, 0.0);
			this.TouchMoveDir.Set(0.0, 0.0);
		}

		// Token: 0x06030DF5 RID: 200181 RVA: 0x00DA1624 File Offset: 0x00D9F824
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

		// Token: 0x06030DF6 RID: 200182 RVA: 0x00DA1684 File Offset: 0x00D9F884
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

		// Token: 0x06030DF7 RID: 200183 RVA: 0x00DA1726 File Offset: 0x00D9F926
		public void Preload()
		{
		}

		// Token: 0x06030DF8 RID: 200184 RVA: 0x00DA1728 File Offset: 0x00D9F928
		public void ForceStop()
		{
			this.SetVisible(false);
			this.CurItem = null;
		}

		// Token: 0x06030DF9 RID: 200185 RVA: 0x00DA1738 File Offset: 0x00D9F938
		public bool GetVisible()
		{
			return this.Visible;
		}

		// Token: 0x06030DFA RID: 200186 RVA: 0x00DA1740 File Offset: 0x00D9F940
		public void SetVisible(bool visible)
		{
			this.Visible = visible;
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiSlideControlVisibleChanged, visible);
		}

		// Token: 0x04019ED8 RID: 106200
		private bool Visible;

		// Token: 0x04019ED9 RID: 106201
		public readonly Vector2D Position = Vector2D.Create(0.0, 0.0);

		// Token: 0x04019EDA RID: 106202
		[Nullable(2)]
		private UUIItem CurItem;

		// Token: 0x04019EDB RID: 106203
		private readonly Vector2D TouchBeginPos = Vector2D.Create(0.0, 0.0);

		// Token: 0x04019EDC RID: 106204
		public Vector2D TouchMoveDir = Vector2D.Create(0.0, 0.0);

		// Token: 0x04019EDD RID: 106205
		public int TouchId = -1;
	}
}

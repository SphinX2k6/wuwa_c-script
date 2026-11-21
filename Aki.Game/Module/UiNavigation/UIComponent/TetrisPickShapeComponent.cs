using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;

namespace Aki.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02002F96 RID: 12182
	public class TetrisPickShapeComponent : HotKeyComponent
	{
		// Token: 0x0601CE4D RID: 118349 RVA: 0x008D40C0 File Offset: 0x008D22C0
		public TetrisPickShapeComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0601CE4E RID: 118350 RVA: 0x008D40CC File Offset: 0x008D22CC
		protected override void OnPress(HotKeyMap config)
		{
			string bindButtonTag = config.BindButtonTag;
			if (bindButtonTag == "tagCube1")
			{
				EventSystem.Instance.Emit<int>(EEventName.TetrisPickShape, 0);
				return;
			}
			if (bindButtonTag == "tagCube2")
			{
				EventSystem.Instance.Emit<int>(EEventName.TetrisPickShape, 1);
				return;
			}
			if (bindButtonTag == "tagCube3")
			{
				EventSystem.Instance.Emit<int>(EEventName.TetrisPickShape, 2);
				return;
			}
			if (!(bindButtonTag == "tagCube4"))
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.TetrisPickShape, 3);
		}
	}
}

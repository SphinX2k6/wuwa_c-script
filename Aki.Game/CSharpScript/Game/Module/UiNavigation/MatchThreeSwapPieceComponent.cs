using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200390F RID: 14607
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeSwapPieceComponent : HotKeyComponent
	{
		// Token: 0x06025C60 RID: 154720 RVA: 0x00A9E77B File Offset: 0x00A9C97B
		public MatchThreeSwapPieceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C61 RID: 154721 RVA: 0x00A9E784 File Offset: 0x00A9C984
		protected override void OnInit()
		{
			string axisName = base.GetAxisName();
			if (StringUtils.IsEmpty(axisName))
			{
				this.AxisConsumed = false;
				return;
			}
			float axisValue = InputDistributeModel.Instance.GetAxisValue(axisName);
			this.AxisConsumed = (Math.Abs(axisValue) > 0.2f);
		}

		// Token: 0x06025C62 RID: 154722 RVA: 0x00A9E7C7 File Offset: 0x00A9C9C7
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025C63 RID: 154723 RVA: 0x00A9E7D4 File Offset: 0x00A9C9D4
		protected override void OnInputAxis(string axisName, float value)
		{
			float num = Math.Abs(value);
			if (num <= 0.2f)
			{
				this.AxisConsumed = false;
				return;
			}
			if (this.AxisConsumed || num < 0.6f)
			{
				return;
			}
			ELGUINavigationDirection p;
			if (axisName == "UiScroll1")
			{
				if (value > 0f)
				{
					p = ELGUINavigationDirection.Down;
				}
				else
				{
					p = ELGUINavigationDirection.Up;
				}
			}
			else
			{
				if (!(axisName == "UiScroll2"))
				{
					return;
				}
				if (value > 0f)
				{
					p = ELGUINavigationDirection.Right;
				}
				else
				{
					p = ELGUINavigationDirection.Left;
				}
			}
			this.AxisConsumed = true;
			EventSystem.Instance.Emit<ELGUINavigationDirection>(EEventName.MatchThreeSwapPieceInput, p);
		}

		// Token: 0x06025C64 RID: 154724 RVA: 0x00A9E85C File Offset: 0x00A9CA5C
		protected override void OnClear()
		{
			this.AxisConsumed = false;
		}

		// Token: 0x06025C65 RID: 154725 RVA: 0x00A9E865 File Offset: 0x00A9CA65
		protected override void OnFinishInputAxis(string axisName)
		{
			this.AxisConsumed = false;
		}

		// Token: 0x04014D1F RID: 85279
		private const float AXIS_TRIGGER_THRESHOLD = 0.6f;

		// Token: 0x04014D20 RID: 85280
		private const float AXIS_RELEASE_THRESHOLD = 0.2f;

		// Token: 0x04014D21 RID: 85281
		private bool AxisConsumed;
	}
}

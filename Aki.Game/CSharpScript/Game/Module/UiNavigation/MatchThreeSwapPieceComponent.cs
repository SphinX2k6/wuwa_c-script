using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004995 RID: 18837
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeSwapPieceComponent : HotKeyComponent
	{
		// Token: 0x0603112A RID: 201002 RVA: 0x00B6382B File Offset: 0x00B61A2B
		public MatchThreeSwapPieceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603112B RID: 201003 RVA: 0x00B63834 File Offset: 0x00B61A34
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

		// Token: 0x0603112C RID: 201004 RVA: 0x00B63877 File Offset: 0x00B61A77
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x0603112D RID: 201005 RVA: 0x00B63884 File Offset: 0x00B61A84
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

		// Token: 0x0603112E RID: 201006 RVA: 0x00B6390C File Offset: 0x00B61B0C
		protected override void OnClear()
		{
			this.AxisConsumed = false;
		}

		// Token: 0x0603112F RID: 201007 RVA: 0x00B63915 File Offset: 0x00B61B15
		protected override void OnFinishInputAxis(string axisName)
		{
			this.AxisConsumed = false;
		}

		// Token: 0x0401A4AD RID: 107693
		private const float AXIS_TRIGGER_THRESHOLD = 0.6f;

		// Token: 0x0401A4AE RID: 107694
		private const float AXIS_RELEASE_THRESHOLD = 0.2f;

		// Token: 0x0401A4AF RID: 107695
		private bool AxisConsumed;
	}
}

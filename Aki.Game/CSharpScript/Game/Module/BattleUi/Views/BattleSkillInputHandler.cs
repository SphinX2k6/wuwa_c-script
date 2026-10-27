using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE8 RID: 23784
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillInputHandler : IInputHandler
	{
		// Token: 0x0603C2F1 RID: 246513 RVA: 0x00E6851C File Offset: 0x00E6671C
		[NullableContext(1)]
		public void InitCallback(Action<EInputAction> pressCallback, Action<EInputAction> releaseCallback)
		{
			this.PressCallback = pressCallback;
			this.ReleaseCallback = releaseCallback;
		}

		// Token: 0x0603C2F2 RID: 246514 RVA: 0x00E6852C File Offset: 0x00E6672C
		public void SetActionType(EInputAction actionType)
		{
			this.InputFilter.Actions.Clear();
			this.InputFilter.Actions.Add(actionType);
		}

		// Token: 0x0603C2F3 RID: 246515 RVA: 0x00E68550 File Offset: 0x00E66750
		public void AddActionTypes(List<EInputAction> actionTypes)
		{
			if (actionTypes != null)
			{
				foreach (EInputAction item in actionTypes)
				{
					this.InputFilter.Actions.Add(item);
				}
			}
		}

		// Token: 0x0603C2F4 RID: 246516 RVA: 0x00E685AC File Offset: 0x00E667AC
		public int GetPriority()
		{
			return 1;
		}

		// Token: 0x0603C2F5 RID: 246517 RVA: 0x00E685AF File Offset: 0x00E667AF
		[NullableContext(1)]
		public InputFilter GetInputFilter()
		{
			return this.InputFilter;
		}

		// Token: 0x0603C2F6 RID: 246518 RVA: 0x00E685B7 File Offset: 0x00E667B7
		public void HandlePressEvent(EInputAction action, float time)
		{
			Action<EInputAction> pressCallback = this.PressCallback;
			if (pressCallback == null)
			{
				return;
			}
			pressCallback(action);
		}

		// Token: 0x0603C2F7 RID: 246519 RVA: 0x00E685CA File Offset: 0x00E667CA
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			Action<EInputAction> releaseCallback = this.ReleaseCallback;
			if (releaseCallback == null)
			{
				return;
			}
			releaseCallback(action);
		}

		// Token: 0x0603C2F8 RID: 246520 RVA: 0x00E685DD File Offset: 0x00E667DD
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x0603C2F9 RID: 246521 RVA: 0x00E685DF File Offset: 0x00E667DF
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x0603C2FA RID: 246522 RVA: 0x00E685E1 File Offset: 0x00E667E1
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x0603C2FB RID: 246523 RVA: 0x00E685E3 File Offset: 0x00E667E3
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x0603C2FC RID: 246524 RVA: 0x00E685E5 File Offset: 0x00E667E5
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0603C2FD RID: 246525 RVA: 0x00E685E7 File Offset: 0x00E667E7
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0401F5FA RID: 128506
		public InputFilter InputFilter = new InputFilter(Array.Empty<EInputAction>(), null, null, null);

		// Token: 0x0401F5FB RID: 128507
		private Action<EInputAction> PressCallback;

		// Token: 0x0401F5FC RID: 128508
		private Action<EInputAction> ReleaseCallback;
	}
}

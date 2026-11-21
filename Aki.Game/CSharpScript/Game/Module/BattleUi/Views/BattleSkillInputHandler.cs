using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CCA RID: 19658
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillInputHandler : IInputHandler
	{
		// Token: 0x06031247 RID: 201287 RVA: 0x00DB8AD0 File Offset: 0x00DB6CD0
		[NullableContext(1)]
		public void InitCallback(Action<EInputAction> pressCallback, Action<EInputAction> releaseCallback)
		{
			this.PressCallback = pressCallback;
			this.ReleaseCallback = releaseCallback;
		}

		// Token: 0x06031248 RID: 201288 RVA: 0x00DB8AE0 File Offset: 0x00DB6CE0
		public void SetActionType(EInputAction actionType)
		{
			this.InputFilter.Actions.Clear();
			this.InputFilter.Actions.Add(actionType);
		}

		// Token: 0x06031249 RID: 201289 RVA: 0x00DB8B04 File Offset: 0x00DB6D04
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

		// Token: 0x0603124A RID: 201290 RVA: 0x00DB8B60 File Offset: 0x00DB6D60
		public int GetPriority()
		{
			return 1;
		}

		// Token: 0x0603124B RID: 201291 RVA: 0x00DB8B63 File Offset: 0x00DB6D63
		[NullableContext(1)]
		public InputFilter GetInputFilter()
		{
			return this.InputFilter;
		}

		// Token: 0x0603124C RID: 201292 RVA: 0x00DB8B6B File Offset: 0x00DB6D6B
		public void HandlePressEvent(EInputAction action, float time)
		{
			Action<EInputAction> pressCallback = this.PressCallback;
			if (pressCallback == null)
			{
				return;
			}
			pressCallback(action);
		}

		// Token: 0x0603124D RID: 201293 RVA: 0x00DB8B7E File Offset: 0x00DB6D7E
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			Action<EInputAction> releaseCallback = this.ReleaseCallback;
			if (releaseCallback == null)
			{
				return;
			}
			releaseCallback(action);
		}

		// Token: 0x0603124E RID: 201294 RVA: 0x00DB8B91 File Offset: 0x00DB6D91
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x0603124F RID: 201295 RVA: 0x00DB8B93 File Offset: 0x00DB6D93
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x06031250 RID: 201296 RVA: 0x00DB8B95 File Offset: 0x00DB6D95
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x06031251 RID: 201297 RVA: 0x00DB8B97 File Offset: 0x00DB6D97
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x06031252 RID: 201298 RVA: 0x00DB8B99 File Offset: 0x00DB6D99
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x06031253 RID: 201299 RVA: 0x00DB8B9B File Offset: 0x00DB6D9B
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0401A0B3 RID: 106675
		public InputFilter InputFilter = new InputFilter(Array.Empty<EInputAction>(), null, null, null);

		// Token: 0x0401A0B4 RID: 106676
		private Action<EInputAction> PressCallback;

		// Token: 0x0401A0B5 RID: 106677
		private Action<EInputAction> ReleaseCallback;
	}
}

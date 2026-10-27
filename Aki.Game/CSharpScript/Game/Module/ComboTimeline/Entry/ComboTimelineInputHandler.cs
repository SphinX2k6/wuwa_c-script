using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02005B9A RID: 23450
	[NullableContext(1)]
	[Nullable(0)]
	public class ComboTimelineInputHandler : IInputHandler
	{
		// Token: 0x0603B50B RID: 242955 RVA: 0x00E22C13 File Offset: 0x00E20E13
		public ComboTimelineInputHandler(Action<EInputAction> onPress, Action<EInputAction> onRelease)
		{
			this.OnPress = onPress;
			this.OnRelease = onRelease;
		}

		// Token: 0x0603B50C RID: 242956 RVA: 0x00E22C3C File Offset: 0x00E20E3C
		public int GetPriority()
		{
			return 100000;
		}

		// Token: 0x0603B50D RID: 242957 RVA: 0x00E22C43 File Offset: 0x00E20E43
		public InputFilter GetInputFilter()
		{
			return this.Filter;
		}

		// Token: 0x0603B50E RID: 242958 RVA: 0x00E22C4B File Offset: 0x00E20E4B
		public void HandlePressEvent(EInputAction action, float time)
		{
			this.OnPress(action);
		}

		// Token: 0x0603B50F RID: 242959 RVA: 0x00E22C59 File Offset: 0x00E20E59
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			this.OnRelease(action);
		}

		// Token: 0x0603B510 RID: 242960 RVA: 0x00E22C67 File Offset: 0x00E20E67
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x0603B511 RID: 242961 RVA: 0x00E22C69 File Offset: 0x00E20E69
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x0603B512 RID: 242962 RVA: 0x00E22C6B File Offset: 0x00E20E6B
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x0603B513 RID: 242963 RVA: 0x00E22C6D File Offset: 0x00E20E6D
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x0603B514 RID: 242964 RVA: 0x00E22C6F File Offset: 0x00E20E6F
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0603B515 RID: 242965 RVA: 0x00E22C71 File Offset: 0x00E20E71
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0401EEAC RID: 126636
		private readonly InputFilter Filter = new InputFilter(ComboTimelineDefine.recordedInputActions, null, null, null);

		// Token: 0x0401EEAD RID: 126637
		private readonly Action<EInputAction> OnPress;

		// Token: 0x0401EEAE RID: 126638
		private readonly Action<EInputAction> OnRelease;
	}
}

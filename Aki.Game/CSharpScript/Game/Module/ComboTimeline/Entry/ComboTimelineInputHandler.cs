using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02004B7A RID: 19322
	[NullableContext(1)]
	[Nullable(0)]
	public class ComboTimelineInputHandler : IInputHandler
	{
		// Token: 0x06030458 RID: 197720 RVA: 0x00D73163 File Offset: 0x00D71363
		public ComboTimelineInputHandler(Action<EInputAction> onPress, Action<EInputAction> onRelease)
		{
			this.OnPress = onPress;
			this.OnRelease = onRelease;
		}

		// Token: 0x06030459 RID: 197721 RVA: 0x00D7318C File Offset: 0x00D7138C
		public int GetPriority()
		{
			return 100000;
		}

		// Token: 0x0603045A RID: 197722 RVA: 0x00D73193 File Offset: 0x00D71393
		public InputFilter GetInputFilter()
		{
			return this.Filter;
		}

		// Token: 0x0603045B RID: 197723 RVA: 0x00D7319B File Offset: 0x00D7139B
		public void HandlePressEvent(EInputAction action, float time)
		{
			this.OnPress(action);
		}

		// Token: 0x0603045C RID: 197724 RVA: 0x00D731A9 File Offset: 0x00D713A9
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			this.OnRelease(action);
		}

		// Token: 0x0603045D RID: 197725 RVA: 0x00D731B7 File Offset: 0x00D713B7
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x0603045E RID: 197726 RVA: 0x00D731B9 File Offset: 0x00D713B9
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x0603045F RID: 197727 RVA: 0x00D731BB File Offset: 0x00D713BB
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x06030460 RID: 197728 RVA: 0x00D731BD File Offset: 0x00D713BD
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x06030461 RID: 197729 RVA: 0x00D731BF File Offset: 0x00D713BF
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x06030462 RID: 197730 RVA: 0x00D731C1 File Offset: 0x00D713C1
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0401995D RID: 104797
		private readonly InputFilter Filter = new InputFilter(ComboTimelineDefine.recordedInputActions, null, null, null);

		// Token: 0x0401995E RID: 104798
		private readonly Action<EInputAction> OnPress;

		// Token: 0x0401995F RID: 104799
		private readonly Action<EInputAction> OnRelease;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200619C RID: 24988
	[NullableContext(1)]
	public interface ITouchUiEditView
	{
		// Token: 0x0603BF4E RID: 245582
		UUIItem GetAttachRoot();

		// Token: 0x0603BF4F RID: 245583
		[NullableContext(2)]
		UUISliderComponent GetScaleSlider();
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200701B RID: 28699
	[NullableContext(1)]
	public interface ITouchUiEditView
	{
		// Token: 0x06045D98 RID: 286104
		UUIItem GetAttachRoot();

		// Token: 0x06045D99 RID: 286105
		[NullableContext(2)]
		UUISliderComponent GetScaleSlider();
	}
}

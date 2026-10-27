using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046D8 RID: 18136
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameViewInfo
	{
		// Token: 0x0602EC97 RID: 191639 RVA: 0x00AD53BF File Offset: 0x00AD35BF
		public UiPopFrameViewInfo(string resourceId, TUiBehaviourPopTypeCtor ctor)
		{
		}

		// Token: 0x04019746 RID: 104262
		public string ResourceId = resourceId;

		// Token: 0x04019747 RID: 104263
		public TUiBehaviourPopTypeCtor Ctor = ctor;
	}
}

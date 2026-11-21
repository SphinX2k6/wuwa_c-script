using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003608 RID: 13832
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameViewInfo
	{
		// Token: 0x060233D1 RID: 144337 RVA: 0x00A02E63 File Offset: 0x00A01063
		public UiPopFrameViewInfo(string resourceId, TUiBehaviourPopTypeCtor ctor)
		{
		}

		// Token: 0x04013DE4 RID: 81380
		public string ResourceId = resourceId;

		// Token: 0x04013DE5 RID: 81381
		public TUiBehaviourPopTypeCtor Ctor = ctor;
	}
}

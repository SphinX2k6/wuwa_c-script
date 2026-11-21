using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D2 RID: 22994
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolUnlockItemPopupParam : ConditionGroupData
	{
		// Token: 0x06038A97 RID: 232087 RVA: 0x00FDB83E File Offset: 0x00FD9A3E
		public SolarSchoolUnlockItemPopupParam(int conditionGroupId, [Nullable(1)] List<IActivityConditionData> dataList, string titleId, Action closeCallback) : base(conditionGroupId, dataList, titleId, false)
		{
			this.CloseCallback = closeCallback;
		}

		// Token: 0x0401DD5F RID: 122207
		public Action CloseCallback;
	}
}

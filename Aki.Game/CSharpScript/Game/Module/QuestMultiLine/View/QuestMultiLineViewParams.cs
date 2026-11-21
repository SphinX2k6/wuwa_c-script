using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02003F78 RID: 16248
	public class QuestMultiLineViewParams
	{
		// Token: 0x04016608 RID: 91656
		[Nullable(1)]
		public List<QuestMultiLineTimePointData> TimePoints;

		// Token: 0x04016609 RID: 91657
		public int ShowTimePointId;

		// Token: 0x0401660A RID: 91658
		public bool PlayTimePointComponentAnim;
	}
}

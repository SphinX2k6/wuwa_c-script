using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02004FAF RID: 20399
	public class QuestMultiLineViewParams
	{
		// Token: 0x0401BC33 RID: 113715
		[Nullable(1)]
		public List<QuestMultiLineTimePointData> TimePoints;

		// Token: 0x0401BC34 RID: 113716
		public int ShowTimePointId;

		// Token: 0x0401BC35 RID: 113717
		public bool PlayTimePointComponentAnim;
	}
}

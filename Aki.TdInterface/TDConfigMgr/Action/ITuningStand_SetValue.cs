using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224E RID: 8782
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand_SetValue
	{
		// Token: 0x040072B1 RID: 29361
		public ESimpleGameplayType Type;

		// Token: 0x040072B2 RID: 29362
		public ETuningStandVisualType VisualType;

		// Token: 0x040072B3 RID: 29363
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITuningStandBubbleConfig> BubbleConfig;

		// Token: 0x040072B4 RID: 29364
		public string GuidancePath;

		// Token: 0x040072B5 RID: 29365
		public string MusicScorePath;

		// Token: 0x040072B6 RID: 29366
		public string NoteSequence;

		// Token: 0x040072B7 RID: 29367
		public string CompleteMusic;

		// Token: 0x040072B8 RID: 29368
		[Nullable(0)]
		public ITuningStandGridBoard BoardConfig;
	}
}

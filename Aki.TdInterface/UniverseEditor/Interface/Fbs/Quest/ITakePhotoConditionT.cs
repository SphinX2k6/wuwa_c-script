using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004602 RID: 17922
	public class ITakePhotoConditionT
	{
		// Token: 0x17007D61 RID: 32097
		// (get) Token: 0x0601A344 RID: 107332 RVA: 0x003BB770 File Offset: 0x003B9970
		// (set) Token: 0x0601A345 RID: 107333 RVA: 0x003BB778 File Offset: 0x003B9978
		public EChildQuest Type { get; set; }

		// Token: 0x17007D62 RID: 32098
		// (get) Token: 0x0601A346 RID: 107334 RVA: 0x003BB781 File Offset: 0x003B9981
		// (set) Token: 0x0601A347 RID: 107335 RVA: 0x003BB789 File Offset: 0x003B9989
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007D63 RID: 32099
		// (get) Token: 0x0601A348 RID: 107336 RVA: 0x003BB792 File Offset: 0x003B9992
		// (set) Token: 0x0601A349 RID: 107337 RVA: 0x003BB79A File Offset: 0x003B999A
		public ITakePhotoTimeConditionT TimeCondition { get; set; }

		// Token: 0x17007D64 RID: 32100
		// (get) Token: 0x0601A34A RID: 107338 RVA: 0x003BB7A3 File Offset: 0x003B99A3
		// (set) Token: 0x0601A34B RID: 107339 RVA: 0x003BB7AB File Offset: 0x003B99AB
		public ITakePhotoPosConditionT PosCondition { get; set; }

		// Token: 0x17007D65 RID: 32101
		// (get) Token: 0x0601A34C RID: 107340 RVA: 0x003BB7B4 File Offset: 0x003B99B4
		// (set) Token: 0x0601A34D RID: 107341 RVA: 0x003BB7BC File Offset: 0x003B99BC
		public List<IPhotoTargetT> PhotoTargets { get; set; }

		// Token: 0x0601A34E RID: 107342 RVA: 0x003BB7C5 File Offset: 0x003B99C5
		public ITakePhotoConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TimeCondition = null;
			this.PosCondition = null;
			this.PhotoTargets = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006042 RID: 24642
	public class ITargetGearGroupSuccessContdionT
	{
		// Token: 0x1700B6E8 RID: 46824
		// (get) Token: 0x06029996 RID: 170390 RVA: 0x005ADD86 File Offset: 0x005ABF86
		// (set) Token: 0x06029997 RID: 170391 RVA: 0x005ADD8E File Offset: 0x005ABF8E
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x06029998 RID: 170392 RVA: 0x005ADD97 File Offset: 0x005ABF97
		public ITargetGearGroupSuccessContdionT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}

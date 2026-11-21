using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF6 RID: 11510
	public class RoverRogueActivate : ActionParams
	{
		// Token: 0x0600FBFA RID: 64506 RVA: 0x0024763B File Offset: 0x0024583B
		public static RoverRogueActivate Create(IRoverRogueActivate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueActivate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x0600FBFB RID: 64507 RVA: 0x0024765A File Offset: 0x0024585A
		public virtual ERoverRogueActivateType InteractType
		{
			get
			{
				return (ERoverRogueActivateType)this.Instance.InteractType;
			}
		}

		// Token: 0x0400899E RID: 35230
		private IRoverRogueActivate Instance;
	}
}

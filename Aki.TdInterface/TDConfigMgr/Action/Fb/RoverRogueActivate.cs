using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A09 RID: 10761
	public class RoverRogueActivate : ActionParams
	{
		// Token: 0x0600ED63 RID: 60771 RVA: 0x00229CB7 File Offset: 0x00227EB7
		[NullableContext(1)]
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

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x0600ED64 RID: 60772 RVA: 0x00229CD6 File Offset: 0x00227ED6
		public virtual ERoverRogueActivateType InteractType
		{
			get
			{
				return (ERoverRogueActivateType)this.Instance.InteractType;
			}
		}

		// Token: 0x040082AD RID: 33453
		private IRoverRogueActivate Instance;
	}
}

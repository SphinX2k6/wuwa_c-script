using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADF RID: 10975
	public class IMechStuntClimbFly : IMechStuntConfigType
	{
		// Token: 0x0600F1A0 RID: 61856 RVA: 0x0023551E File Offset: 0x0023371E
		public static IMechStuntClimbFly Create(IMechStuntClimbFly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x0023553D File Offset: 0x0023373D
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084AF RID: 33967
		private IMechStuntClimbFly Instance;
	}
}

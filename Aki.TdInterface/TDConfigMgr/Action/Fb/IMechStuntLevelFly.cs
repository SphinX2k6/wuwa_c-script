using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE0 RID: 10976
	public class IMechStuntLevelFly : IMechStuntConfigType
	{
		// Token: 0x0600F1A3 RID: 61859 RVA: 0x00235552 File Offset: 0x00233752
		public static IMechStuntLevelFly Create(IMechStuntLevelFly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntLevelFly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x0600F1A4 RID: 61860 RVA: 0x00235571 File Offset: 0x00233771
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084B0 RID: 33968
		private IMechStuntLevelFly Instance;
	}
}

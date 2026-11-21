using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE2 RID: 10978
	public class IMechStuntWater : IMechStuntConfigType
	{
		// Token: 0x0600F1A9 RID: 61865 RVA: 0x002355BA File Offset: 0x002337BA
		public static IMechStuntWater Create(IMechStuntWater? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x0600F1AA RID: 61866 RVA: 0x002355D9 File Offset: 0x002337D9
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084B2 RID: 33970
		private IMechStuntWater Instance;
	}
}

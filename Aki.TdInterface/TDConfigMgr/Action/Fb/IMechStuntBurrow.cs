using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE3 RID: 10979
	public class IMechStuntBurrow : IMechStuntConfigType
	{
		// Token: 0x0600F1AC RID: 61868 RVA: 0x002355EE File Offset: 0x002337EE
		public static IMechStuntBurrow Create(IMechStuntBurrow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x0600F1AD RID: 61869 RVA: 0x0023560D File Offset: 0x0023380D
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084B3 RID: 33971
		private IMechStuntBurrow Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002900 RID: 10496
	public class IAwakePosType
	{
		// Token: 0x0600E983 RID: 59779 RVA: 0x00227ACB File Offset: 0x00225CCB
		public static IAwakePosType Create(IAwakePosType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAwakePosType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x0600E984 RID: 59780 RVA: 0x00227AEA File Offset: 0x00225CEA
		public virtual EAwakePosType Type
		{
			get
			{
				return (EAwakePosType)this.Instance.Type;
			}
		}

		// Token: 0x040080B0 RID: 32944
		private IAwakePosType Instance;
	}
}

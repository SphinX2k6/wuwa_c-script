using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD9 RID: 11737
	public class IResetPosType
	{
		// Token: 0x0600FF68 RID: 65384 RVA: 0x0024CDA4 File Offset: 0x0024AFA4
		public static IResetPosType Create(IResetPosType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x0600FF69 RID: 65385 RVA: 0x0024CDC3 File Offset: 0x0024AFC3
		public virtual EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x04008B71 RID: 35697
		private IResetPosType Instance;
	}
}

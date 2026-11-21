using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C86 RID: 11398
	public class IOpenSystemBoardWithReturnType
	{
		// Token: 0x0600FA48 RID: 64072 RVA: 0x00244F80 File Offset: 0x00243180
		public static IOpenSystemBoardWithReturnType Create(IOpenSystemBoardWithReturnType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x0600FA49 RID: 64073 RVA: 0x00244F9F File Offset: 0x0024319F
		public virtual ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040088BA RID: 35002
		private IOpenSystemBoardWithReturnType Instance;
	}
}

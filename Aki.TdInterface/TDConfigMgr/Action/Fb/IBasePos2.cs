using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025DE RID: 9694
	public class IBasePos2
	{
		// Token: 0x0600D9E6 RID: 55782 RVA: 0x00207E07 File Offset: 0x00206007
		[NullableContext(1)]
		public static IBasePos2 Create(IBasePos2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBasePos2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x0600D9E7 RID: 55783 RVA: 0x00207E26 File Offset: 0x00206026
		public virtual EPos2 Type
		{
			get
			{
				return (EPos2)this.Instance.Type;
			}
		}

		// Token: 0x04007904 RID: 30980
		private IBasePos2 Instance;
	}
}

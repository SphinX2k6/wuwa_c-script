using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3B RID: 2875
	public class IInteractPlayerDiractionType
	{
		// Token: 0x060041C6 RID: 16838 RVA: 0x000A7779 File Offset: 0x000A5979
		public static IInteractPlayerDiractionType Create(IInteractPlayerDiractionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000A7798 File Offset: 0x000A5998
		public virtual EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x0400246E RID: 9326
		private IInteractPlayerDiractionType Instance;
	}
}

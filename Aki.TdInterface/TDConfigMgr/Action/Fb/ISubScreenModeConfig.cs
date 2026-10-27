using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279B RID: 10139
	public class ISubScreenModeConfig
	{
		// Token: 0x0600E1A8 RID: 57768 RVA: 0x00215892 File Offset: 0x00213A92
		[NullableContext(1)]
		public static ISubScreenModeConfig Create(ISubScreenModeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x002158B1 File Offset: 0x00213AB1
		public virtual ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04007D23 RID: 32035
		private ISubScreenModeConfig Instance;
	}
}

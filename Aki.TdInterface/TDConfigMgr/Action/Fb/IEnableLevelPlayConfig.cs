using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276B RID: 10091
	public class IEnableLevelPlayConfig
	{
		// Token: 0x0600E0C0 RID: 57536 RVA: 0x002136BB File Offset: 0x002118BB
		[NullableContext(1)]
		public static IEnableLevelPlayConfig Create(IEnableLevelPlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableLevelPlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x002136DA File Offset: 0x002118DA
		public virtual int LevelPlayId
		{
			get
			{
				return this.Instance.LevelPlayId;
			}
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x0600E0C2 RID: 57538 RVA: 0x002136E7 File Offset: 0x002118E7
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04007C73 RID: 31859
		private IEnableLevelPlayConfig Instance;
	}
}

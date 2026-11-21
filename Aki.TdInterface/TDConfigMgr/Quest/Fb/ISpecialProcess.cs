using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001525 RID: 5413
	public class ISpecialProcess
	{
		// Token: 0x06007A81 RID: 31361 RVA: 0x00124372 File Offset: 0x00122572
		public static ISpecialProcess Create(ISpecialProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x00124391 File Offset: 0x00122591
		public virtual ESpecialProcess Type
		{
			get
			{
				return (ESpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x04004693 RID: 18067
		private ISpecialProcess Instance;
	}
}

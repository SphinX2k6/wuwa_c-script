using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291F RID: 10527
	public class IWriteLetterConfig
	{
		// Token: 0x0600E9F9 RID: 59897 RVA: 0x002289F2 File Offset: 0x00226BF2
		public static IWriteLetterConfig Create(IWriteLetterConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetterConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x0600E9FA RID: 59898 RVA: 0x00228A11 File Offset: 0x00226C11
		public virtual int LetterId
		{
			get
			{
				return this.Instance.LetterId;
			}
		}

		// Token: 0x040080FB RID: 33019
		private IWriteLetterConfig Instance;
	}
}

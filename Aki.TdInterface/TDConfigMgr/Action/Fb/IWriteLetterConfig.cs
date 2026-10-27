using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265B RID: 9819
	public class IWriteLetterConfig
	{
		// Token: 0x0600DC1D RID: 56349 RVA: 0x0020C11A File Offset: 0x0020A31A
		[NullableContext(1)]
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

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x0600DC1E RID: 56350 RVA: 0x0020C139 File Offset: 0x0020A339
		public virtual int LetterId
		{
			get
			{
				return this.Instance.LetterId;
			}
		}

		// Token: 0x04007A59 RID: 31321
		private IWriteLetterConfig Instance;
	}
}

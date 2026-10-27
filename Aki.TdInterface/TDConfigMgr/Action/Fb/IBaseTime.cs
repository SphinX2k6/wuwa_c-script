using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025DD RID: 9693
	public class IBaseTime
	{
		// Token: 0x0600D9E2 RID: 55778 RVA: 0x00207DC6 File Offset: 0x00205FC6
		[NullableContext(1)]
		public static IBaseTime Create(IBaseTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x0600D9E3 RID: 55779 RVA: 0x00207DE5 File Offset: 0x00205FE5
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x0600D9E4 RID: 55780 RVA: 0x00207DF2 File Offset: 0x00205FF2
		public virtual int Minute
		{
			get
			{
				return this.Instance.Minute;
			}
		}

		// Token: 0x04007903 RID: 30979
		private IBaseTime Instance;
	}
}

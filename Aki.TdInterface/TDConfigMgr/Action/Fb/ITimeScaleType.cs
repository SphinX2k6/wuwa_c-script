using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A1 RID: 10145
	public class ITimeScaleType
	{
		// Token: 0x0600E0B3 RID: 57523 RVA: 0x00210FEE File Offset: 0x0020F1EE
		public static ITimeScaleType Create(ITimeScaleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600E0B4 RID: 57524 RVA: 0x0021100D File Offset: 0x0020F20D
		public virtual ETimeScaleType Type
		{
			get
			{
				return (ETimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x04007A33 RID: 31283
		private ITimeScaleType Instance;
	}
}

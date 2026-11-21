using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9E RID: 11166
	public class IResetPlayerFocusType
	{
		// Token: 0x0600F61E RID: 63006 RVA: 0x0023DBF5 File Offset: 0x0023BDF5
		public static IResetPlayerFocusType Create(IResetPlayerFocusType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x0600F61F RID: 63007 RVA: 0x0023DC14 File Offset: 0x0023BE14
		public virtual EResetPlayerFocusType Type
		{
			get
			{
				return (EResetPlayerFocusType)this.Instance.Type;
			}
		}

		// Token: 0x040086F6 RID: 34550
		private IResetPlayerFocusType Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A2 RID: 10146
	public class ISetGlobalTimeScaleType
	{
		// Token: 0x0600E0B6 RID: 57526 RVA: 0x00211022 File Offset: 0x0020F222
		public static ISetGlobalTimeScaleType Create(ISetGlobalTimeScaleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600E0B7 RID: 57527 RVA: 0x00211041 File Offset: 0x0020F241
		public virtual ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x04007A34 RID: 31284
		private ISetGlobalTimeScaleType Instance;
	}
}

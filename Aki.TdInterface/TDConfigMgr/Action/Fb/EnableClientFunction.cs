using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1A RID: 11290
	public class EnableClientFunction : ActionParams
	{
		// Token: 0x0600F878 RID: 63608 RVA: 0x00241E5D File Offset: 0x0024005D
		public static EnableClientFunction Create(IEnableClientFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableClientFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x0600F879 RID: 63609 RVA: 0x00241E7C File Offset: 0x0024007C
		public virtual EEnableClientFunctionType Type
		{
			get
			{
				return (EEnableClientFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x040087F2 RID: 34802
		private IEnableClientFunction Instance;
	}
}

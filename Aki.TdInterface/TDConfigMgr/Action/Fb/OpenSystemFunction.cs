using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292B RID: 10539
	public class OpenSystemFunction : ActionParams
	{
		// Token: 0x0600EA48 RID: 59976 RVA: 0x0022945D File Offset: 0x0022765D
		public static OpenSystemFunction Create(IOpenSystemFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x0022947C File Offset: 0x0022767C
		public virtual int FunctionId
		{
			get
			{
				return this.Instance.FunctionId;
			}
		}

		// Token: 0x0400812B RID: 33067
		private IOpenSystemFunction Instance;
	}
}

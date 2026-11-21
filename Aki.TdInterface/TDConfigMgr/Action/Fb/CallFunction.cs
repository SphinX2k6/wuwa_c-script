using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C6 RID: 10438
	public class CallFunction : ActionParams
	{
		// Token: 0x0600E86F RID: 59503 RVA: 0x00225ACD File Offset: 0x00223CCD
		public static CallFunction Create(ICallFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x0600E870 RID: 59504 RVA: 0x00225AEC File Offset: 0x00223CEC
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x0400800C RID: 32780
		private ICallFunction Instance;
	}
}

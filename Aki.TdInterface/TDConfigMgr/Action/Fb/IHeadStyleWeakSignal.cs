using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AB RID: 10155
	public class IHeadStyleWeakSignal : IHeadStyle
	{
		// Token: 0x0600E0D7 RID: 57559 RVA: 0x002112B6 File Offset: 0x0020F4B6
		public static IHeadStyleWeakSignal Create(IHeadStyleWeakSignal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x002112D5 File Offset: 0x0020F4D5
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A41 RID: 31297
		private IHeadStyleWeakSignal Instance;
	}
}

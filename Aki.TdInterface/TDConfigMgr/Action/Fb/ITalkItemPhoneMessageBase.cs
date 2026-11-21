using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FC RID: 10236
	public class ITalkItemPhoneMessageBase
	{
		// Token: 0x0600E329 RID: 58153 RVA: 0x00217C65 File Offset: 0x00215E65
		public static ITalkItemPhoneMessageBase Create(ITalkItemPhoneMessageBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x0600E32A RID: 58154 RVA: 0x00217C84 File Offset: 0x00215E84
		public virtual EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x04007C1E RID: 31774
		private ITalkItemPhoneMessageBase Instance;
	}
}

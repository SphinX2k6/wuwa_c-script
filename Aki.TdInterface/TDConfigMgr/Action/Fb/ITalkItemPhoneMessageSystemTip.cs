using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002800 RID: 10240
	public class ITalkItemPhoneMessageSystemTip : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600E339 RID: 58169 RVA: 0x00217DC0 File Offset: 0x00215FC0
		public static ITalkItemPhoneMessageSystemTip Create(ITalkItemPhoneMessageSystemTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageSystemTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0600E33A RID: 58170 RVA: 0x00217DDF File Offset: 0x00215FDF
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x04007C22 RID: 31778
		private ITalkItemPhoneMessageSystemTip Instance;
	}
}

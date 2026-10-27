using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002557 RID: 9559
	public class ITalkItemPhoneMessageSystemTip : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600D5CF RID: 54735 RVA: 0x001FC1C4 File Offset: 0x001FA3C4
		[NullableContext(1)]
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

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x001FC1E3 File Offset: 0x001FA3E3
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x040075C5 RID: 30149
		private ITalkItemPhoneMessageSystemTip Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002553 RID: 9555
	public class ITalkItemPhoneMessageBase
	{
		// Token: 0x0600D5BF RID: 54719 RVA: 0x001FC069 File Offset: 0x001FA269
		[NullableContext(1)]
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

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x001FC088 File Offset: 0x001FA288
		public virtual EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x040075C1 RID: 30145
		private ITalkItemPhoneMessageBase Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC2 RID: 10946
	public class IPhoneSystemInteractBase
	{
		// Token: 0x0600F033 RID: 61491 RVA: 0x0022E30E File Offset: 0x0022C50E
		[NullableContext(1)]
		public static IPhoneSystemInteractBase Create(IPhoneSystemInteractBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneSystemInteractBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x0600F034 RID: 61492 RVA: 0x0022E32D File Offset: 0x0022C52D
		public virtual EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x0400841E RID: 33822
		private IPhoneSystemInteractBase Instance;
	}
}

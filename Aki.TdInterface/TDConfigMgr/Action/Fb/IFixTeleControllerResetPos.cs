using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024DE RID: 9438
	public class IFixTeleControllerResetPos : ActionParams
	{
		// Token: 0x0600D2B6 RID: 53942 RVA: 0x001F416A File Offset: 0x001F236A
		[NullableContext(1)]
		public static IFixTeleControllerResetPos Create(IFixTeleControllerResetPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixTeleControllerResetPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600D2B7 RID: 53943 RVA: 0x001F4189 File Offset: 0x001F2389
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x04007394 RID: 29588
		private IFixTeleControllerResetPos Instance;
	}
}

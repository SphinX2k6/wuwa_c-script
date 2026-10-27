using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AF RID: 10671
	public class ISetTeleControlConfig
	{
		// Token: 0x0600EC14 RID: 60436 RVA: 0x00227E67 File Offset: 0x00226067
		[NullableContext(1)]
		public static ISetTeleControlConfig Create(ISetTeleControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x0600EC15 RID: 60437 RVA: 0x00227E86 File Offset: 0x00226086
		public virtual ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x0600EC16 RID: 60438 RVA: 0x00227E93 File Offset: 0x00226093
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008201 RID: 33281
		private ISetTeleControlConfig Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1E RID: 2846
	[NullableContext(1)]
	[Nullable(0)]
	public class IPetalGrabEvent
	{
		// Token: 0x060041BC RID: 16828 RVA: 0x000A8A7A File Offset: 0x000A6C7A
		public static IPetalGrabEvent Create(IPetalGrabEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x000A8A99 File Offset: 0x000A6C99
		public virtual EPetalGrabEventType EventType
		{
			get
			{
				return (EPetalGrabEventType)this.Instance.EventType;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x000A8AA6 File Offset: 0x000A6CA6
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002511 RID: 9489
		private IPetalGrabEvent Instance;
	}
}

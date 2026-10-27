using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002693 RID: 9875
	public class ITeleportTransitionInDigitalScreen : ITeleportTransitionType
	{
		// Token: 0x0600DD15 RID: 56597 RVA: 0x0020DC16 File Offset: 0x0020BE16
		[NullableContext(1)]
		public static ITeleportTransitionInDigitalScreen Create(ITeleportTransitionInDigitalScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x0020DC35 File Offset: 0x0020BE35
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x0600DD17 RID: 56599 RVA: 0x0020DC42 File Offset: 0x0020BE42
		public virtual int ConfigId
		{
			get
			{
				return this.Instance.ConfigId;
			}
		}

		// Token: 0x04007ACD RID: 31437
		private ITeleportTransitionInDigitalScreen Instance;
	}
}

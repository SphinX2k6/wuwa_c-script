using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F3 RID: 10739
	public class IAddOrSubAlertValue : ISetAlertValueType
	{
		// Token: 0x0600ED16 RID: 60694 RVA: 0x002296FC File Offset: 0x002278FC
		[NullableContext(1)]
		public static IAddOrSubAlertValue Create(IAddOrSubAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x0600ED17 RID: 60695 RVA: 0x0022971B File Offset: 0x0022791B
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x0600ED18 RID: 60696 RVA: 0x00229728 File Offset: 0x00227928
		public virtual float DeltaValue
		{
			get
			{
				return this.Instance.DeltaValue;
			}
		}

		// Token: 0x0400828D RID: 33421
		private IAddOrSubAlertValue Instance;
	}
}

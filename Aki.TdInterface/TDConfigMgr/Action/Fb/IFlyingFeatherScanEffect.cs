using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3C RID: 10812
	public class IFlyingFeatherScanEffect : ISpecificScanEffect
	{
		// Token: 0x0600EE1A RID: 60954 RVA: 0x0022AE96 File Offset: 0x00229096
		[NullableContext(1)]
		public static IFlyingFeatherScanEffect Create(IFlyingFeatherScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeatherScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x0600EE1B RID: 60955 RVA: 0x0022AEB5 File Offset: 0x002290B5
		public override ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x0600EE1C RID: 60956 RVA: 0x0022AEC2 File Offset: 0x002290C2
		public virtual int TriggerPosEntityId
		{
			get
			{
				return this.Instance.TriggerPosEntityId;
			}
		}

		// Token: 0x04008308 RID: 33544
		private IFlyingFeatherScanEffect Instance;
	}
}

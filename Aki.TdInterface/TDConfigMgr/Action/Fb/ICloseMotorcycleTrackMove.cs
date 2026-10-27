using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E6 RID: 10470
	public class ICloseMotorcycleTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600E8A1 RID: 59553 RVA: 0x00222392 File Offset: 0x00220592
		[NullableContext(1)]
		public static ICloseMotorcycleTrackMove Create(ICloseMotorcycleTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseMotorcycleTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x002223B1 File Offset: 0x002205B1
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x0600E8A3 RID: 59555 RVA: 0x002223C0 File Offset: 0x002205C0
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x04008070 RID: 32880
		private ICloseMotorcycleTrackMove Instance;
	}
}

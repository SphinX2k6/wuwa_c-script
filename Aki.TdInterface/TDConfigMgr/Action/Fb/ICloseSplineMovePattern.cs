using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E4 RID: 10468
	public class ICloseSplineMovePattern
	{
		// Token: 0x0600E899 RID: 59545 RVA: 0x002222BA File Offset: 0x002204BA
		[NullableContext(1)]
		public static ICloseSplineMovePattern Create(ICloseSplineMovePattern? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x0600E89A RID: 59546 RVA: 0x002222D9 File Offset: 0x002204D9
		public virtual ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x0600E89B RID: 59547 RVA: 0x002222E8 File Offset: 0x002204E8
		public virtual float? GravitySwitchAngularVelocity
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

		// Token: 0x0400806E RID: 32878
		private ICloseSplineMovePattern Instance;
	}
}

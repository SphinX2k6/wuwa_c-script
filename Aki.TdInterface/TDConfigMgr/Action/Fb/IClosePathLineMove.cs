using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E7 RID: 10471
	public class IClosePathLineMove : ICloseSplineMovePattern
	{
		// Token: 0x0600E8A5 RID: 59557 RVA: 0x002223FE File Offset: 0x002205FE
		[NullableContext(1)]
		public static IClosePathLineMove Create(IClosePathLineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClosePathLineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x0022241D File Offset: 0x0022061D
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x0600E8A7 RID: 59559 RVA: 0x0022242C File Offset: 0x0022062C
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

		// Token: 0x04008071 RID: 32881
		private IClosePathLineMove Instance;
	}
}

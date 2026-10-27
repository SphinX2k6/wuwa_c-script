using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E9 RID: 10473
	public class ICloseSlideTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600E8AD RID: 59565 RVA: 0x002224D6 File Offset: 0x002206D6
		[NullableContext(1)]
		public static ICloseSlideTrackMove Create(ICloseSlideTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSlideTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x0600E8AE RID: 59566 RVA: 0x002224F5 File Offset: 0x002206F5
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x00222504 File Offset: 0x00220704
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

		// Token: 0x04008073 RID: 32883
		private ICloseSlideTrackMove Instance;
	}
}

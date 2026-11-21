using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBF RID: 11199
	public class IClosePathLineMove : ICloseSplineMovePattern
	{
		// Token: 0x0600F6E6 RID: 63206 RVA: 0x0023F5B6 File Offset: 0x0023D7B6
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

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x0600F6E7 RID: 63207 RVA: 0x0023F5D5 File Offset: 0x0023D7D5
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x0600F6E8 RID: 63208 RVA: 0x0023F5E4 File Offset: 0x0023D7E4
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

		// Token: 0x04008735 RID: 34613
		private IClosePathLineMove Instance;
	}
}

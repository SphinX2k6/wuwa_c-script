using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1F RID: 11295
	public class IClientDisableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600F88C RID: 63628 RVA: 0x00242022 File Offset: 0x00240222
		public static IClientDisableAllPlayerOperation Create(IClientDisableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientDisableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x0600F88D RID: 63629 RVA: 0x00242041 File Offset: 0x00240241
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x0600F88E RID: 63630 RVA: 0x00242050 File Offset: 0x00240250
		public virtual EDisplayModeInPlayerOp? DisplayMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EDisplayModeInPlayerOp?((EDisplayModeInPlayerOp)this.Instance.DisplayMode);
			}
		}

		// Token: 0x040087F7 RID: 34807
		private IClientDisableAllPlayerOperation Instance;
	}
}

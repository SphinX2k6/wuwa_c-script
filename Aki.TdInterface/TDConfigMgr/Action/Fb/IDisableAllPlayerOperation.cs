using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1D RID: 11293
	public class IDisableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600F884 RID: 63620 RVA: 0x00241F4A File Offset: 0x0024014A
		public static IDisableAllPlayerOperation Create(IDisableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x0600F885 RID: 63621 RVA: 0x00241F69 File Offset: 0x00240169
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x0600F886 RID: 63622 RVA: 0x00241F78 File Offset: 0x00240178
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

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x0600F887 RID: 63623 RVA: 0x00241FB0 File Offset: 0x002401B0
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsUiFadeEffect);
			}
		}

		// Token: 0x040087F5 RID: 34805
		private IDisableAllPlayerOperation Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293D RID: 10557
	public class IClientDisableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600EA21 RID: 59937 RVA: 0x00224A42 File Offset: 0x00222C42
		[NullableContext(1)]
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

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x0600EA22 RID: 59938 RVA: 0x00224A61 File Offset: 0x00222C61
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x00224A70 File Offset: 0x00222C70
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

		// Token: 0x0400811B RID: 33051
		private IClientDisableAllPlayerOperation Instance;
	}
}

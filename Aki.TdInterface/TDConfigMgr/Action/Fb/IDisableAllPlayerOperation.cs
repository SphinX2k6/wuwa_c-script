using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293B RID: 10555
	public class IDisableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600EA19 RID: 59929 RVA: 0x0022496A File Offset: 0x00222B6A
		[NullableContext(1)]
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

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x0600EA1A RID: 59930 RVA: 0x00224989 File Offset: 0x00222B89
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x00224998 File Offset: 0x00222B98
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

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x0600EA1C RID: 59932 RVA: 0x002249D0 File Offset: 0x00222BD0
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

		// Token: 0x04008119 RID: 33049
		private IDisableAllPlayerOperation Instance;
	}
}

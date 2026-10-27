using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002831 RID: 10289
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveTypeCustomSpeed : ILiftMoveType
	{
		// Token: 0x0600E428 RID: 58408 RVA: 0x00219832 File Offset: 0x00217A32
		public static ILiftMoveTypeCustomSpeed Create(ILiftMoveTypeCustomSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x0600E429 RID: 58409 RVA: 0x00219851 File Offset: 0x00217A51
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x0600E42A RID: 58410 RVA: 0x0021985E File Offset: 0x00217A5E
		public virtual float TotalTime
		{
			get
			{
				return this.Instance.TotalTime;
			}
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x0021986B File Offset: 0x00217A6B
		public virtual string TimePathCurve
		{
			get
			{
				return this.Instance.TimePathCurve;
			}
		}

		// Token: 0x04007E3F RID: 32319
		private ILiftMoveTypeCustomSpeed Instance;
	}
}

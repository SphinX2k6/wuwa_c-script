using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002915 RID: 10517
	public class ILinearOverRangeCameraShake : ICameraShakeConfig
	{
		// Token: 0x0600E96F RID: 59759 RVA: 0x00223939 File Offset: 0x00221B39
		[NullableContext(1)]
		public static ILinearOverRangeCameraShake Create(ILinearOverRangeCameraShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinearOverRangeCameraShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x0600E970 RID: 59760 RVA: 0x00223958 File Offset: 0x00221B58
		public override ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x0600E971 RID: 59761 RVA: 0x00223965 File Offset: 0x00221B65
		public virtual int CenterEntityId
		{
			get
			{
				return this.Instance.CenterEntityId;
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x0600E972 RID: 59762 RVA: 0x00223972 File Offset: 0x00221B72
		public virtual int MinRange
		{
			get
			{
				return this.Instance.MinRange;
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x0022397F File Offset: 0x00221B7F
		public virtual int MaxRange
		{
			get
			{
				return this.Instance.MaxRange;
			}
		}

		// Token: 0x040080D9 RID: 32985
		private ILinearOverRangeCameraShake Instance;
	}
}

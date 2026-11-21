using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF1 RID: 11249
	public class ILinearOverRangeCameraShake : ICameraShakeConfig
	{
		// Token: 0x0600F7C1 RID: 63425 RVA: 0x00240C91 File Offset: 0x0023EE91
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

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x0600F7C2 RID: 63426 RVA: 0x00240CB0 File Offset: 0x0023EEB0
		public override ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x0600F7C3 RID: 63427 RVA: 0x00240CBD File Offset: 0x0023EEBD
		public virtual int CenterEntityId
		{
			get
			{
				return this.Instance.CenterEntityId;
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x0600F7C4 RID: 63428 RVA: 0x00240CCA File Offset: 0x0023EECA
		public virtual int MinRange
		{
			get
			{
				return this.Instance.MinRange;
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x0600F7C5 RID: 63429 RVA: 0x00240CD7 File Offset: 0x0023EED7
		public virtual int MaxRange
		{
			get
			{
				return this.Instance.MaxRange;
			}
		}

		// Token: 0x040087A7 RID: 34727
		private ILinearOverRangeCameraShake Instance;
	}
}

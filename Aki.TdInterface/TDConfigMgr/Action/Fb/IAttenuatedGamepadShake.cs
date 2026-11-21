using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF6 RID: 11254
	public class IAttenuatedGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600F7DA RID: 63450 RVA: 0x00240E8D File Offset: 0x0023F08D
		public static IAttenuatedGamepadShake Create(IAttenuatedGamepadShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttenuatedGamepadShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x0600F7DB RID: 63451 RVA: 0x00240EAC File Offset: 0x0023F0AC
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x0600F7DC RID: 63452 RVA: 0x00240EB9 File Offset: 0x0023F0B9
		public virtual int CenterEntity
		{
			get
			{
				return this.Instance.CenterEntity;
			}
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x0600F7DD RID: 63453 RVA: 0x00240EC6 File Offset: 0x0023F0C6
		public virtual bool IsFollowEntityMovement
		{
			get
			{
				return this.Instance.IsFollowEntityMovement;
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x00240ED3 File Offset: 0x0023F0D3
		public virtual string ForceFeedbackAttenuation
		{
			get
			{
				return this.Instance.ForceFeedbackAttenuation;
			}
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x0600F7DF RID: 63455 RVA: 0x00240EE0 File Offset: 0x0023F0E0
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x0600F7E0 RID: 63456 RVA: 0x00240EED File Offset: 0x0023F0ED
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x040087AE RID: 34734
		private IAttenuatedGamepadShake Instance;
	}
}

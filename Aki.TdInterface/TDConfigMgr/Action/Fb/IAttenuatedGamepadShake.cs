using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291A RID: 10522
	[NullableContext(1)]
	[Nullable(0)]
	public class IAttenuatedGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600E988 RID: 59784 RVA: 0x00223B35 File Offset: 0x00221D35
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

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x0600E989 RID: 59785 RVA: 0x00223B54 File Offset: 0x00221D54
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x0600E98A RID: 59786 RVA: 0x00223B61 File Offset: 0x00221D61
		public virtual int CenterEntity
		{
			get
			{
				return this.Instance.CenterEntity;
			}
		}

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x00223B6E File Offset: 0x00221D6E
		public virtual bool IsFollowEntityMovement
		{
			get
			{
				return this.Instance.IsFollowEntityMovement;
			}
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x0600E98C RID: 59788 RVA: 0x00223B7B File Offset: 0x00221D7B
		public virtual string ForceFeedbackAttenuation
		{
			get
			{
				return this.Instance.ForceFeedbackAttenuation;
			}
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x00223B88 File Offset: 0x00221D88
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x0600E98E RID: 59790 RVA: 0x00223B95 File Offset: 0x00221D95
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x040080E0 RID: 32992
		private IAttenuatedGamepadShake Instance;
	}
}

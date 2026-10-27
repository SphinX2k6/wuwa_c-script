using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D7 RID: 10199
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorBounce : ILeisureInteractType
	{
		// Token: 0x0600E2B0 RID: 58032 RVA: 0x00217633 File Offset: 0x00215833
		[NullableContext(1)]
		public static IMotorBounce Create(IMotorBounce? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorBounce
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x00217652 File Offset: 0x00215852
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x0600E2B2 RID: 58034 RVA: 0x0021765F File Offset: 0x0021585F
		public virtual int Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x0021766C File Offset: 0x0021586C
		public virtual float? Time
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Time);
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x0600E2B4 RID: 58036 RVA: 0x002176A2 File Offset: 0x002158A2
		public virtual string MotionCurve
		{
			get
			{
				return this.Instance.MotionCurve;
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x002176B0 File Offset: 0x002158B0
		public virtual EMotorBounceSkillType? SkillType
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EMotorBounceSkillType?((EMotorBounceSkillType)this.Instance.SkillType);
			}
		}

		// Token: 0x04007DA9 RID: 32169
		private IMotorBounce Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAA RID: 10922
	public class IMotorBounce : ILeisureInteractType
	{
		// Token: 0x0600F0D4 RID: 61652 RVA: 0x00234467 File Offset: 0x00232667
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

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x0600F0D5 RID: 61653 RVA: 0x00234486 File Offset: 0x00232686
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x00234493 File Offset: 0x00232693
		public virtual int Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x0600F0D7 RID: 61655 RVA: 0x002344A0 File Offset: 0x002326A0
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

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x0600F0D8 RID: 61656 RVA: 0x002344D6 File Offset: 0x002326D6
		[Nullable(2)]
		public virtual string MotionCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.MotionCurve;
			}
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x0600F0D9 RID: 61657 RVA: 0x002344E4 File Offset: 0x002326E4
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

		// Token: 0x04008464 RID: 33892
		private IMotorBounce Instance;
	}
}

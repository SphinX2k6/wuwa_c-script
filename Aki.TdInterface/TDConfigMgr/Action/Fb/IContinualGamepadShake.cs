using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002919 RID: 10521
	[NullableContext(2)]
	[Nullable(0)]
	public class IContinualGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600E981 RID: 59777 RVA: 0x00223AA3 File Offset: 0x00221CA3
		[NullableContext(1)]
		public static IContinualGamepadShake Create(IContinualGamepadShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IContinualGamepadShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x0600E982 RID: 59778 RVA: 0x00223AC2 File Offset: 0x00221CC2
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x0600E983 RID: 59779 RVA: 0x00223AD0 File Offset: 0x00221CD0
		public virtual bool? IsIgnoreTimeDilation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsIgnoreTimeDilation);
			}
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x0600E984 RID: 59780 RVA: 0x00223B06 File Offset: 0x00221D06
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x0600E985 RID: 59781 RVA: 0x00223B13 File Offset: 0x00221D13
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x0600E986 RID: 59782 RVA: 0x00223B20 File Offset: 0x00221D20
		public virtual string GamepadShakeTag
		{
			get
			{
				return this.Instance.GamepadShakeTag;
			}
		}

		// Token: 0x040080DF RID: 32991
		private IContinualGamepadShake Instance;
	}
}

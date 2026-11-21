using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF5 RID: 11253
	public class IContinualGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600F7D3 RID: 63443 RVA: 0x00240DFB File Offset: 0x0023EFFB
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

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x0600F7D4 RID: 63444 RVA: 0x00240E1A File Offset: 0x0023F01A
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x0600F7D5 RID: 63445 RVA: 0x00240E28 File Offset: 0x0023F028
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

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x0600F7D6 RID: 63446 RVA: 0x00240E5E File Offset: 0x0023F05E
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x0600F7D7 RID: 63447 RVA: 0x00240E6B File Offset: 0x0023F06B
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x0600F7D8 RID: 63448 RVA: 0x00240E78 File Offset: 0x0023F078
		[Nullable(2)]
		public virtual string GamepadShakeTag
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.GamepadShakeTag;
			}
		}

		// Token: 0x040087AD RID: 34733
		private IContinualGamepadShake Instance;
	}
}

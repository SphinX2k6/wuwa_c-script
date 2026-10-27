using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D97 RID: 3479
	public class ISlopeSlidePerform : ISlidePerformType
	{
		// Token: 0x06004F1A RID: 20250 RVA: 0x000C421F File Offset: 0x000C241F
		[NullableContext(1)]
		public static ISlopeSlidePerform Create(ISlopeSlidePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlopeSlidePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x000C423E File Offset: 0x000C243E
		public override ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x000C424C File Offset: 0x000C244C
		public virtual int? TriggerLandingDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TriggerLandingDistance);
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x000C4284 File Offset: 0x000C2484
		public virtual int? FallbackLandingPointId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FallbackLandingPointId);
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x000C42BC File Offset: 0x000C24BC
		public virtual bool? IsAllowJump
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAllowJump);
			}
		}

		// Token: 0x04002D74 RID: 11636
		private ISlopeSlidePerform Instance;
	}
}

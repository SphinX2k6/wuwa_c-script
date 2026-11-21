using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002987 RID: 10631
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture : IEnableSubLevelTransitionType
	{
		// Token: 0x0600EBC9 RID: 60361 RVA: 0x0022B9DD File Offset: 0x00229BDD
		[NullableContext(0)]
		public static IEnableSubLevelTransitionWithSceneCapture Create(IEnableSubLevelTransitionWithSceneCapture? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionWithSceneCapture
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x0600EBCA RID: 60362 RVA: 0x0022B9FC File Offset: 0x00229BFC
		public override EEnableSubLevelTransitionType Type
		{
			get
			{
				return (EEnableSubLevelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x0600EBCB RID: 60363 RVA: 0x0022BA09 File Offset: 0x00229C09
		public virtual string SceneCaptureEffect
		{
			get
			{
				return this.Instance.SceneCaptureEffect;
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x0600EBCC RID: 60364 RVA: 0x0022BA16 File Offset: 0x00229C16
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x0600EBCD RID: 60365 RVA: 0x0022BA23 File Offset: 0x00229C23
		public virtual string ScreenEffectLoop
		{
			get
			{
				return this.Instance.ScreenEffectLoop;
			}
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x0600EBCE RID: 60366 RVA: 0x0022BA30 File Offset: 0x00229C30
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x0600EBCF RID: 60367 RVA: 0x0022BA68 File Offset: 0x00229C68
		public virtual bool? IsAllowInput
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAllowInput);
			}
		}

		// Token: 0x040081D9 RID: 33241
		private IEnableSubLevelTransitionWithSceneCapture Instance;
	}
}

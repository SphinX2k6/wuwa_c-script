using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002786 RID: 10118
	public class IFlowTemplateBlurTransitionEffect : IFlowTemplateTransitionEffect
	{
		// Token: 0x0600E141 RID: 57665 RVA: 0x00214892 File Offset: 0x00212A92
		[NullableContext(1)]
		public static IFlowTemplateBlurTransitionEffect Create(IFlowTemplateBlurTransitionEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateBlurTransitionEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x0600E142 RID: 57666 RVA: 0x002148B1 File Offset: 0x00212AB1
		public override EFlowTemplateTransitionEffectType Type
		{
			get
			{
				return (EFlowTemplateTransitionEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x0600E143 RID: 57667 RVA: 0x002148BE File Offset: 0x00212ABE
		public virtual float Aperture
		{
			get
			{
				return this.Instance.Aperture;
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x0600E144 RID: 57668 RVA: 0x002148CB File Offset: 0x00212ACB
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x0600E145 RID: 57669 RVA: 0x002148D8 File Offset: 0x00212AD8
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x04007CD0 RID: 31952
		private IFlowTemplateBlurTransitionEffect Instance;
	}
}

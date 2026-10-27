using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9B RID: 6811
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTemplateBlurTransitionEffect : IFlowTemplateTransitionEffect
	{
		// Token: 0x06009214 RID: 37396 RVA: 0x00153CB8 File Offset: 0x00151EB8
		private IFlowTemplateBlurTransitionEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTemplateBlurTransitionEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTemplateBlurTransitionEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTemplateBlurTransitionEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00153CF0 File Offset: 0x00151EF0
		public static IFlowTemplateBlurTransitionEffect Create([Nullable(2)] IFlowTemplateBlurTransitionEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateBlurTransitionEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00153D03 File Offset: 0x00151F03
		public static IFlowTemplateBlurTransitionEffect CreateFromSetValue([Nullable(2)] IFlowTemplateBlurTransitionEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTemplateBlurTransitionEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00153D16 File Offset: 0x00151F16
		public new IFlowTemplateBlurTransitionEffect_SetValue ToSetValue()
		{
			return new IFlowTemplateBlurTransitionEffect_SetValue
			{
				Type = this.Type,
				Aperture = this.Aperture,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x06009218 RID: 37400 RVA: 0x00153D4D File Offset: 0x00151F4D
		// (set) Token: 0x06009219 RID: 37401 RVA: 0x00153D78 File Offset: 0x00151F78
		public override EFlowTemplateTransitionEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFlowTemplateTransitionEffectType.Blur;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600921A RID: 37402 RVA: 0x00153D86 File Offset: 0x00151F86
		// (set) Token: 0x0600921B RID: 37403 RVA: 0x00153DB5 File Offset: 0x00151FB5
		public virtual float Aperture
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Aperture;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Aperture;
			}
			set
			{
				this.GetOrCreatePoco().Aperture = value;
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600921C RID: 37404 RVA: 0x00153DC3 File Offset: 0x00151FC3
		// (set) Token: 0x0600921D RID: 37405 RVA: 0x00153DF2 File Offset: 0x00151FF2
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600921E RID: 37406 RVA: 0x00153E00 File Offset: 0x00152000
		// (set) Token: 0x0600921F RID: 37407 RVA: 0x00153E2F File Offset: 0x0015202F
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x04005A00 RID: 23040
		[Nullable(2)]
		protected new IFlowTemplateBlurTransitionEffect FbInstance;

		// Token: 0x04005A01 RID: 23041
		[Nullable(2)]
		protected new IFlowTemplateBlurTransitionEffect_SetValue PocoInterface;
	}
}

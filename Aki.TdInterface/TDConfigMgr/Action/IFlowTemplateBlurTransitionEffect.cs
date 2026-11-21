using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C34 RID: 7220
	public class IFlowTemplateBlurTransitionEffect : IFlowTemplateTransitionEffect
	{
		// Token: 0x06009994 RID: 39316 RVA: 0x00163EA4 File Offset: 0x001620A4
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

		// Token: 0x06009995 RID: 39317 RVA: 0x00163EDC File Offset: 0x001620DC
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

		// Token: 0x06009996 RID: 39318 RVA: 0x00163EEF File Offset: 0x001620EF
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

		// Token: 0x06009997 RID: 39319 RVA: 0x00163F02 File Offset: 0x00162102
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

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x00163F39 File Offset: 0x00162139
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x00163F64 File Offset: 0x00162164
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

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00163F72 File Offset: 0x00162172
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x00163FA1 File Offset: 0x001621A1
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

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x00163FAF File Offset: 0x001621AF
		// (set) Token: 0x0600999D RID: 39325 RVA: 0x00163FDE File Offset: 0x001621DE
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

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600999E RID: 39326 RVA: 0x00163FEC File Offset: 0x001621EC
		// (set) Token: 0x0600999F RID: 39327 RVA: 0x0016401B File Offset: 0x0016221B
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

		// Token: 0x04005E70 RID: 24176
		[Nullable(2)]
		protected new IFlowTemplateBlurTransitionEffect FbInstance;

		// Token: 0x04005E71 RID: 24177
		[Nullable(2)]
		protected new IFlowTemplateBlurTransitionEffect_SetValue PocoInterface;
	}
}

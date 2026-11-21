using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077D RID: 1917
	public class ISlopeSlidePerform : ISlidePerformType
	{
		// Token: 0x060028F4 RID: 10484 RVA: 0x0006CB7C File Offset: 0x0006AD7C
		private ISlopeSlidePerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlopeSlidePerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlopeSlidePerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlopeSlidePerform_SetValue());
			}
			return result;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0006CBB4 File Offset: 0x0006ADB4
		public static ISlopeSlidePerform Create([Nullable(2)] ISlopeSlidePerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlopeSlidePerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0006CBC7 File Offset: 0x0006ADC7
		public static ISlopeSlidePerform CreateFromSetValue([Nullable(2)] ISlopeSlidePerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlopeSlidePerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0006CBDA File Offset: 0x0006ADDA
		public new ISlopeSlidePerform_SetValue ToSetValue()
		{
			return new ISlopeSlidePerform_SetValue
			{
				Type = this.Type,
				TriggerLandingDistance = this.TriggerLandingDistance,
				FallbackLandingPointId = this.FallbackLandingPointId,
				IsAllowJump = this.IsAllowJump
			};
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0006CC11 File Offset: 0x0006AE11
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x0006CC3C File Offset: 0x0006AE3C
		public override ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x0006CC4C File Offset: 0x0006AE4C
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x0006CC86 File Offset: 0x0006AE86
		public virtual int? TriggerLandingDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerLandingDistance;
				}
				ISlopeSlidePerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TriggerLandingDistance;
			}
			set
			{
				this.GetOrCreatePoco().TriggerLandingDistance = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x0006CC94 File Offset: 0x0006AE94
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x0006CCCE File Offset: 0x0006AECE
		public virtual int? FallbackLandingPointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackLandingPointId;
				}
				ISlopeSlidePerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FallbackLandingPointId;
			}
			set
			{
				this.GetOrCreatePoco().FallbackLandingPointId = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x0006CCDC File Offset: 0x0006AEDC
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x0006CD16 File Offset: 0x0006AF16
		public virtual bool? IsAllowJump
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAllowJump;
				}
				ISlopeSlidePerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAllowJump;
			}
			set
			{
				this.GetOrCreatePoco().IsAllowJump = value;
			}
		}

		// Token: 0x04001BC6 RID: 7110
		[Nullable(2)]
		protected new ISlopeSlidePerform FbInstance;

		// Token: 0x04001BC7 RID: 7111
		[Nullable(2)]
		protected new ISlopeSlidePerform_SetValue PocoInterface;
	}
}

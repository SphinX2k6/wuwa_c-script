using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006DC RID: 1756
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlopeSlidePerform : ISlidePerformType
	{
		// Token: 0x060025D4 RID: 9684 RVA: 0x00065B0C File Offset: 0x00063D0C
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

		// Token: 0x060025D5 RID: 9685 RVA: 0x00065B44 File Offset: 0x00063D44
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

		// Token: 0x060025D6 RID: 9686 RVA: 0x00065B57 File Offset: 0x00063D57
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

		// Token: 0x060025D7 RID: 9687 RVA: 0x00065B6A File Offset: 0x00063D6A
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x00065BA1 File Offset: 0x00063DA1
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x00065BCC File Offset: 0x00063DCC
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x00065BDC File Offset: 0x00063DDC
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x00065C16 File Offset: 0x00063E16
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x00065C24 File Offset: 0x00063E24
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x00065C5E File Offset: 0x00063E5E
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x00065C6C File Offset: 0x00063E6C
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x00065CA6 File Offset: 0x00063EA6
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

		// Token: 0x040019C7 RID: 6599
		[Nullable(2)]
		protected new ISlopeSlidePerform FbInstance;

		// Token: 0x040019C8 RID: 6600
		[Nullable(2)]
		protected new ISlopeSlidePerform_SetValue PocoInterface;
	}
}

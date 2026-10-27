using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB4 RID: 7348
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x06009DBD RID: 40381 RVA: 0x00169234 File Offset: 0x00167434
		private IOpenTraceSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenTraceSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenTraceSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenTraceSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x0016926C File Offset: 0x0016746C
		public static IOpenTraceSpline Create([Nullable(2)] IOpenTraceSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenTraceSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0016927F File Offset: 0x0016747F
		public static IOpenTraceSpline CreateFromSetValue([Nullable(2)] IOpenTraceSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenTraceSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x00169292 File Offset: 0x00167492
		public new IOpenTraceSpline_SetValue ToSetValue()
		{
			return new IOpenTraceSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				Duration = this.Duration
			};
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x001692BD File Offset: 0x001674BD
		// (set) Token: 0x06009DC2 RID: 40386 RVA: 0x001692E8 File Offset: 0x001674E8
		public override ETraceSplineOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETraceSplineOptionType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x001692F6 File Offset: 0x001674F6
		// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x00169321 File Offset: 0x00167521
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x0016932F File Offset: 0x0016752F
		// (set) Token: 0x06009DC6 RID: 40390 RVA: 0x0016935E File Offset: 0x0016755E
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04005F74 RID: 24436
		[Nullable(2)]
		protected new IOpenTraceSpline FbInstance;

		// Token: 0x04005F75 RID: 24437
		[Nullable(2)]
		protected new IOpenTraceSpline_SetValue PocoInterface;
	}
}

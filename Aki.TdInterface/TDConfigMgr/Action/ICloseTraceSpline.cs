using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EE RID: 6382
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x060088CF RID: 35023 RVA: 0x00143594 File Offset: 0x00141794
		private ICloseTraceSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseTraceSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseTraceSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseTraceSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x001435CC File Offset: 0x001417CC
		public static ICloseTraceSpline Create([Nullable(2)] ICloseTraceSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseTraceSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x001435DF File Offset: 0x001417DF
		public static ICloseTraceSpline CreateFromSetValue([Nullable(2)] ICloseTraceSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseTraceSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x001435F2 File Offset: 0x001417F2
		public new ICloseTraceSpline_SetValue ToSetValue()
		{
			return new ICloseTraceSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x00143611 File Offset: 0x00141811
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x0014363C File Offset: 0x0014183C
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

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x0014364A File Offset: 0x0014184A
		// (set) Token: 0x060088D6 RID: 35030 RVA: 0x00143675 File Offset: 0x00141875
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

		// Token: 0x040055D4 RID: 21972
		[Nullable(2)]
		protected new ICloseTraceSpline FbInstance;

		// Token: 0x040055D5 RID: 21973
		[Nullable(2)]
		protected new ICloseTraceSpline_SetValue PocoInterface;
	}
}

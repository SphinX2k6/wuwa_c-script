using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A79 RID: 6777
	public class ICloseTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x06008FFD RID: 36861 RVA: 0x00152E94 File Offset: 0x00151094
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

		// Token: 0x06008FFE RID: 36862 RVA: 0x00152ECC File Offset: 0x001510CC
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

		// Token: 0x06008FFF RID: 36863 RVA: 0x00152EDF File Offset: 0x001510DF
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

		// Token: 0x06009000 RID: 36864 RVA: 0x00152EF2 File Offset: 0x001510F2
		public new ICloseTraceSpline_SetValue ToSetValue()
		{
			return new ICloseTraceSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x06009001 RID: 36865 RVA: 0x00152F11 File Offset: 0x00151111
		// (set) Token: 0x06009002 RID: 36866 RVA: 0x00152F3C File Offset: 0x0015113C
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

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x06009003 RID: 36867 RVA: 0x00152F4A File Offset: 0x0015114A
		// (set) Token: 0x06009004 RID: 36868 RVA: 0x00152F75 File Offset: 0x00151175
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

		// Token: 0x04005A24 RID: 23076
		[Nullable(2)]
		protected new ICloseTraceSpline FbInstance;

		// Token: 0x04005A25 RID: 23077
		[Nullable(2)]
		protected new ICloseTraceSpline_SetValue PocoInterface;
	}
}

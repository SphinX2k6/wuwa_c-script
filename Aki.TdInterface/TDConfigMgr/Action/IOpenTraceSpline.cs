using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EBB RID: 7867
	public class IOpenTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x0600A76B RID: 42859 RVA: 0x0017CE94 File Offset: 0x0017B094
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

		// Token: 0x0600A76C RID: 42860 RVA: 0x0017CECC File Offset: 0x0017B0CC
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

		// Token: 0x0600A76D RID: 42861 RVA: 0x0017CEDF File Offset: 0x0017B0DF
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

		// Token: 0x0600A76E RID: 42862 RVA: 0x0017CEF2 File Offset: 0x0017B0F2
		public new IOpenTraceSpline_SetValue ToSetValue()
		{
			return new IOpenTraceSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				Duration = this.Duration
			};
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x0017CF1D File Offset: 0x0017B11D
		// (set) Token: 0x0600A770 RID: 42864 RVA: 0x0017CF48 File Offset: 0x0017B148
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

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600A771 RID: 42865 RVA: 0x0017CF56 File Offset: 0x0017B156
		// (set) Token: 0x0600A772 RID: 42866 RVA: 0x0017CF81 File Offset: 0x0017B181
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

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600A773 RID: 42867 RVA: 0x0017CF8F File Offset: 0x0017B18F
		// (set) Token: 0x0600A774 RID: 42868 RVA: 0x0017CFBE File Offset: 0x0017B1BE
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

		// Token: 0x040064D0 RID: 25808
		[Nullable(2)]
		protected new IOpenTraceSpline FbInstance;

		// Token: 0x040064D1 RID: 25809
		[Nullable(2)]
		protected new IOpenTraceSpline_SetValue PocoInterface;
	}
}

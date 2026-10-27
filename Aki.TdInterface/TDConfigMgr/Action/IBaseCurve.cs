using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017F8 RID: 6136
	[NullableContext(2)]
	[Nullable(0)]
	public class IBaseCurve
	{
		// Token: 0x060083C7 RID: 33735 RVA: 0x0013A6C8 File Offset: 0x001388C8
		[NullableContext(1)]
		private IBaseCurve_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBaseCurve 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBaseCurve_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBaseCurve_SetValue());
			}
			return result;
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0013A700 File Offset: 0x00138900
		[NullableContext(1)]
		public static IBaseCurve Create([Nullable(2)] IBaseCurve instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseCurve
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x0013A713 File Offset: 0x00138913
		[NullableContext(1)]
		public static IBaseCurve CreateFromSetValue([Nullable(2)] IBaseCurve_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBaseCurve
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0013A726 File Offset: 0x00138926
		[NullableContext(1)]
		public IBaseCurve_SetValue ToSetValue()
		{
			return new IBaseCurve_SetValue
			{
				Type = this.Type,
				N = this.N,
				CurveAsset = this.CurveAsset
			};
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x060083CB RID: 33739 RVA: 0x0013A751 File Offset: 0x00138951
		// (set) Token: 0x060083CC RID: 33740 RVA: 0x0013A77C File Offset: 0x0013897C
		public virtual EBaseCurveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EBaseCurveType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x060083CD RID: 33741 RVA: 0x0013A78A File Offset: 0x0013898A
		// (set) Token: 0x060083CE RID: 33742 RVA: 0x0013A7B9 File Offset: 0x001389B9
		public virtual float N
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.N;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.N;
			}
			set
			{
				this.GetOrCreatePoco().N = value;
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x060083CF RID: 33743 RVA: 0x0013A7C7 File Offset: 0x001389C7
		// (set) Token: 0x060083D0 RID: 33744 RVA: 0x0013A7EE File Offset: 0x001389EE
		public virtual string CurveAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CurveAsset;
				}
				IBaseCurve_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CurveAsset;
			}
			set
			{
				this.GetOrCreatePoco().CurveAsset = value;
			}
		}

		// Token: 0x0400538B RID: 21387
		protected IBaseCurve FbInstance;

		// Token: 0x0400538C RID: 21388
		protected IBaseCurve_SetValue PocoInterface;
	}
}

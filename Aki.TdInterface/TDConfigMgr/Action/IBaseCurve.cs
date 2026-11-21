using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001981 RID: 6529
	public class IBaseCurve
	{
		// Token: 0x06008AE3 RID: 35555 RVA: 0x00149DB0 File Offset: 0x00147FB0
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

		// Token: 0x06008AE4 RID: 35556 RVA: 0x00149DE8 File Offset: 0x00147FE8
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

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00149DFB File Offset: 0x00147FFB
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

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00149E0E File Offset: 0x0014800E
		public IBaseCurve_SetValue ToSetValue()
		{
			return new IBaseCurve_SetValue
			{
				Type = this.Type,
				N = this.N,
				CurveAsset = this.CurveAsset
			};
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x06008AE7 RID: 35559 RVA: 0x00149E39 File Offset: 0x00148039
		// (set) Token: 0x06008AE8 RID: 35560 RVA: 0x00149E64 File Offset: 0x00148064
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

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x00149E72 File Offset: 0x00148072
		// (set) Token: 0x06008AEA RID: 35562 RVA: 0x00149EA1 File Offset: 0x001480A1
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

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x00149EAF File Offset: 0x001480AF
		// (set) Token: 0x06008AEC RID: 35564 RVA: 0x00149ED6 File Offset: 0x001480D6
		[Nullable(2)]
		public virtual string CurveAsset
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CurveAsset = value;
			}
		}

		// Token: 0x040057D3 RID: 22483
		[Nullable(2)]
		protected IBaseCurve FbInstance;

		// Token: 0x040057D4 RID: 22484
		[Nullable(2)]
		protected IBaseCurve_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B9 RID: 697
	[NullableContext(1)]
	[Nullable(0)]
	public class IDirectionFill : IFillType
	{
		// Token: 0x06000D0F RID: 3343 RVA: 0x000314EC File Offset: 0x0002F6EC
		private IDirectionFill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDirectionFill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDirectionFill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDirectionFill_SetValue());
			}
			return result;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00031524 File Offset: 0x0002F724
		public static IDirectionFill Create([Nullable(2)] IDirectionFill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDirectionFill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00031537 File Offset: 0x0002F737
		public static IDirectionFill CreateFromSetValue([Nullable(2)] IDirectionFill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDirectionFill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0003154C File Offset: 0x0002F74C
		public new IDirectionFill_SetValue ToSetValue()
		{
			return new IDirectionFill_SetValue
			{
				Type = this.Type,
				W = this.W,
				S = this.S,
				A = this.A,
				D = this.D
			};
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0003159A File Offset: 0x0002F79A
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x000315C5 File Offset: 0x0002F7C5
		public override EFillType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFillType.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000315D3 File Offset: 0x0002F7D3
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x000315FE File Offset: 0x0002F7FE
		public virtual bool W
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.W;
				}
				return this.PocoInterface != null && this.PocoInterface.W;
			}
			set
			{
				this.GetOrCreatePoco().W = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0003160C File Offset: 0x0002F80C
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00031637 File Offset: 0x0002F837
		public virtual bool S
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.S;
				}
				return this.PocoInterface != null && this.PocoInterface.S;
			}
			set
			{
				this.GetOrCreatePoco().S = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00031645 File Offset: 0x0002F845
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00031670 File Offset: 0x0002F870
		public virtual bool A
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.A;
				}
				return this.PocoInterface != null && this.PocoInterface.A;
			}
			set
			{
				this.GetOrCreatePoco().A = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0003167E File Offset: 0x0002F87E
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x000316A9 File Offset: 0x0002F8A9
		public virtual bool D
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.D;
				}
				return this.PocoInterface != null && this.PocoInterface.D;
			}
			set
			{
				this.GetOrCreatePoco().D = value;
			}
		}

		// Token: 0x04000BF6 RID: 3062
		[Nullable(2)]
		protected new IDirectionFill FbInstance;

		// Token: 0x04000BF7 RID: 3063
		[Nullable(2)]
		protected new IDirectionFill_SetValue PocoInterface;
	}
}

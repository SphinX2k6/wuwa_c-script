using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000300 RID: 768
	public class IDirectionFill : IFillType
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x00034420 File Offset: 0x00032620
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

		// Token: 0x06000E40 RID: 3648 RVA: 0x00034458 File Offset: 0x00032658
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

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003446B File Offset: 0x0003266B
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

		// Token: 0x06000E42 RID: 3650 RVA: 0x00034480 File Offset: 0x00032680
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000344CE File Offset: 0x000326CE
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000344F9 File Offset: 0x000326F9
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00034507 File Offset: 0x00032707
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00034532 File Offset: 0x00032732
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00034540 File Offset: 0x00032740
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0003456B File Offset: 0x0003276B
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00034579 File Offset: 0x00032779
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000345A4 File Offset: 0x000327A4
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000345B2 File Offset: 0x000327B2
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x000345DD File Offset: 0x000327DD
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

		// Token: 0x04000CE0 RID: 3296
		[Nullable(2)]
		protected new IDirectionFill FbInstance;

		// Token: 0x04000CE1 RID: 3297
		[Nullable(2)]
		protected new IDirectionFill_SetValue PocoInterface;
	}
}

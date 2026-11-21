using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D7 RID: 983
	public class IFixedAngleItem
	{
		// Token: 0x0600134D RID: 4941 RVA: 0x0003F274 File Offset: 0x0003D474
		private IFixedAngleItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedAngleItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedAngleItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedAngleItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0003F2AC File Offset: 0x0003D4AC
		public static IFixedAngleItem Create([Nullable(2)] IFixedAngleItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedAngleItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0003F2BF File Offset: 0x0003D4BF
		public static IFixedAngleItem CreateFromSetValue([Nullable(2)] IFixedAngleItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedAngleItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0003F2D2 File Offset: 0x0003D4D2
		public IFixedAngleItem_SetValue ToSetValue()
		{
			return new IFixedAngleItem_SetValue
			{
				InitAngle = this.InitAngle,
				TargetAngle = this.TargetAngle,
				RotateAngle = this.RotateAngle
			};
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0003F2FD File Offset: 0x0003D4FD
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0003F328 File Offset: 0x0003D528
		public virtual int InitAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitAngle;
			}
			set
			{
				this.GetOrCreatePoco().InitAngle = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0003F336 File Offset: 0x0003D536
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x0003F361 File Offset: 0x0003D561
		public virtual int TargetAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetAngle;
			}
			set
			{
				this.GetOrCreatePoco().TargetAngle = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0003F36F File Offset: 0x0003D56F
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x0003F39A File Offset: 0x0003D59A
		public virtual int RotateAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotateAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RotateAngle;
			}
			set
			{
				this.GetOrCreatePoco().RotateAngle = value;
			}
		}

		// Token: 0x04000F93 RID: 3987
		[Nullable(2)]
		protected IFixedAngleItem FbInstance;

		// Token: 0x04000F94 RID: 3988
		[Nullable(2)]
		protected IFixedAngleItem_SetValue PocoInterface;
	}
}

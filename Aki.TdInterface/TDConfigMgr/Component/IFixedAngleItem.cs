using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200038E RID: 910
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedAngleItem
	{
		// Token: 0x06001209 RID: 4617 RVA: 0x0003BF90 File Offset: 0x0003A190
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

		// Token: 0x0600120A RID: 4618 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
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

		// Token: 0x0600120B RID: 4619 RVA: 0x0003BFDB File Offset: 0x0003A1DB
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

		// Token: 0x0600120C RID: 4620 RVA: 0x0003BFEE File Offset: 0x0003A1EE
		public IFixedAngleItem_SetValue ToSetValue()
		{
			return new IFixedAngleItem_SetValue
			{
				InitAngle = this.InitAngle,
				TargetAngle = this.TargetAngle,
				RotateAngle = this.RotateAngle
			};
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0003C019 File Offset: 0x0003A219
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0003C044 File Offset: 0x0003A244
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0003C052 File Offset: 0x0003A252
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0003C07D File Offset: 0x0003A27D
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0003C08B File Offset: 0x0003A28B
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0003C0B6 File Offset: 0x0003A2B6
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

		// Token: 0x04000E9C RID: 3740
		[Nullable(2)]
		protected IFixedAngleItem FbInstance;

		// Token: 0x04000E9D RID: 3741
		[Nullable(2)]
		protected IFixedAngleItem_SetValue PocoInterface;
	}
}

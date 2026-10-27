using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C6 RID: 966
	[NullableContext(1)]
	[Nullable(0)]
	public class IFreeAngleItem
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0003F024 File Offset: 0x0003D224
		private IFreeAngleItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFreeAngleItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFreeAngleItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFreeAngleItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003F05C File Offset: 0x0003D25C
		public static IFreeAngleItem Create([Nullable(2)] IFreeAngleItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreeAngleItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003F06F File Offset: 0x0003D26F
		public static IFreeAngleItem CreateFromSetValue([Nullable(2)] IFreeAngleItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFreeAngleItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0003F082 File Offset: 0x0003D282
		public IFreeAngleItem_SetValue ToSetValue()
		{
			return new IFreeAngleItem_SetValue
			{
				InitAngle = this.InitAngle,
				TargetAngle = this.TargetAngle
			};
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0003F0A1 File Offset: 0x0003D2A1
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0003F0CC File Offset: 0x0003D2CC
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0003F0DA File Offset: 0x0003D2DA
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0003F105 File Offset: 0x0003D305
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

		// Token: 0x04000F73 RID: 3955
		[Nullable(2)]
		protected IFreeAngleItem FbInstance;

		// Token: 0x04000F74 RID: 3956
		[Nullable(2)]
		protected IFreeAngleItem_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000411 RID: 1041
	public class IFreeAngleItem
	{
		// Token: 0x060014B1 RID: 5297 RVA: 0x000425C4 File Offset: 0x000407C4
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

		// Token: 0x060014B2 RID: 5298 RVA: 0x000425FC File Offset: 0x000407FC
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

		// Token: 0x060014B3 RID: 5299 RVA: 0x0004260F File Offset: 0x0004080F
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

		// Token: 0x060014B4 RID: 5300 RVA: 0x00042622 File Offset: 0x00040822
		public IFreeAngleItem_SetValue ToSetValue()
		{
			return new IFreeAngleItem_SetValue
			{
				InitAngle = this.InitAngle,
				TargetAngle = this.TargetAngle
			};
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00042641 File Offset: 0x00040841
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0004266C File Offset: 0x0004086C
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0004267A File Offset: 0x0004087A
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x000426A5 File Offset: 0x000408A5
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

		// Token: 0x04001074 RID: 4212
		[Nullable(2)]
		protected IFreeAngleItem FbInstance;

		// Token: 0x04001075 RID: 4213
		[Nullable(2)]
		protected IFreeAngleItem_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000324 RID: 804
	public class IDynamicAttachTarget : IAttachTarget
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x00036510 File Offset: 0x00034710
		private IDynamicAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00036548 File Offset: 0x00034748
		public static IDynamicAttachTarget Create([Nullable(2)] IDynamicAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0003655B File Offset: 0x0003475B
		public static IDynamicAttachTarget CreateFromSetValue([Nullable(2)] IDynamicAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0003656E File Offset: 0x0003476E
		public new IDynamicAttachTarget_SetValue ToSetValue()
		{
			return new IDynamicAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00036581 File Offset: 0x00034781
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x000365AC File Offset: 0x000347AC
		public override EAttachType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachType.Actor;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000D69 RID: 3433
		[Nullable(2)]
		protected new IDynamicAttachTarget FbInstance;

		// Token: 0x04000D6A RID: 3434
		[Nullable(2)]
		protected new IDynamicAttachTarget_SetValue PocoInterface;
	}
}

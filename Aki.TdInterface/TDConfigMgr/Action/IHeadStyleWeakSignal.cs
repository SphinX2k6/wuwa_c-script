using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF7 RID: 6903
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyleWeakSignal : IHeadStyle
	{
		// Token: 0x060093DA RID: 37850 RVA: 0x00156CCC File Offset: 0x00154ECC
		private IHeadStyleWeakSignal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleWeakSignal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleWeakSignal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleWeakSignal_SetValue());
			}
			return result;
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x00156D04 File Offset: 0x00154F04
		public static IHeadStyleWeakSignal Create([Nullable(2)] IHeadStyleWeakSignal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x00156D17 File Offset: 0x00154F17
		public static IHeadStyleWeakSignal CreateFromSetValue([Nullable(2)] IHeadStyleWeakSignal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00156D2A File Offset: 0x00154F2A
		public new IHeadStyleWeakSignal_SetValue ToSetValue()
		{
			return new IHeadStyleWeakSignal_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x060093DE RID: 37854 RVA: 0x00156D3D File Offset: 0x00154F3D
		// (set) Token: 0x060093DF RID: 37855 RVA: 0x00156D68 File Offset: 0x00154F68
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AC5 RID: 23237
		[Nullable(2)]
		protected new IHeadStyleWeakSignal FbInstance;

		// Token: 0x04005AC6 RID: 23238
		[Nullable(2)]
		protected new IHeadStyleWeakSignal_SetValue PocoInterface;
	}
}

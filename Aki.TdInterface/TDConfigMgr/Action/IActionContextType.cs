using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001756 RID: 5974
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionContextType
	{
		// Token: 0x06007E79 RID: 32377 RVA: 0x0012EDFC File Offset: 0x0012CFFC
		private IActionContextType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionContextType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionContextType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionContextType_SetValue());
			}
			return result;
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x0012EE34 File Offset: 0x0012D034
		public static IActionContextType Create([Nullable(2)] IActionContextType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionContextType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0012EE47 File Offset: 0x0012D047
		public static IActionContextType CreateFromSetValue([Nullable(2)] IActionContextType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionContextType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0012EE5A File Offset: 0x0012D05A
		public IActionContextType_SetValue ToSetValue()
		{
			return new IActionContextType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x06007E7D RID: 32381 RVA: 0x0012EE6D File Offset: 0x0012D06D
		// (set) Token: 0x06007E7E RID: 32382 RVA: 0x0012EE98 File Offset: 0x0012D098
		public virtual TActionContextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return TActionContextType.commonBt;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400508D RID: 20621
		[Nullable(2)]
		protected IActionContextType FbInstance;

		// Token: 0x0400508E RID: 20622
		[Nullable(2)]
		protected IActionContextType_SetValue PocoInterface;
	}
}

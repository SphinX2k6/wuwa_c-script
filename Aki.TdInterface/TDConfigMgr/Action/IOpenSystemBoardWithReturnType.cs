using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB9 RID: 7865
	public class IOpenSystemBoardWithReturnType
	{
		// Token: 0x0600A763 RID: 42851 RVA: 0x0017CDD8 File Offset: 0x0017AFD8
		private IOpenSystemBoardWithReturnType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSystemBoardWithReturnType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSystemBoardWithReturnType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSystemBoardWithReturnType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x0017CE10 File Offset: 0x0017B010
		public static IOpenSystemBoardWithReturnType Create([Nullable(2)] IOpenSystemBoardWithReturnType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x0017CE23 File Offset: 0x0017B023
		public static IOpenSystemBoardWithReturnType CreateFromSetValue([Nullable(2)] IOpenSystemBoardWithReturnType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x0017CE36 File Offset: 0x0017B036
		public IOpenSystemBoardWithReturnType_SetValue ToSetValue()
		{
			return new IOpenSystemBoardWithReturnType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600A767 RID: 42855 RVA: 0x0017CE49 File Offset: 0x0017B049
		// (set) Token: 0x0600A768 RID: 42856 RVA: 0x0017CE74 File Offset: 0x0017B074
		public virtual ESystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemType.Shop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064CD RID: 25805
		[Nullable(2)]
		protected IOpenSystemBoardWithReturnType FbInstance;

		// Token: 0x040064CE RID: 25806
		[Nullable(2)]
		protected IOpenSystemBoardWithReturnType_SetValue PocoInterface;
	}
}

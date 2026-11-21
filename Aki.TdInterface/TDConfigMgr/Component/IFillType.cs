using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003CB RID: 971
	public class IFillType
	{
		// Token: 0x06001315 RID: 4885 RVA: 0x0003EC7C File Offset: 0x0003CE7C
		private IFillType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFillType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFillType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFillType_SetValue());
			}
			return result;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		public static IFillType Create([Nullable(2)] IFillType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFillType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003ECC7 File Offset: 0x0003CEC7
		public static IFillType CreateFromSetValue([Nullable(2)] IFillType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFillType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003ECDA File Offset: 0x0003CEDA
		public IFillType_SetValue ToSetValue()
		{
			return new IFillType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0003ECED File Offset: 0x0003CEED
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0003ED18 File Offset: 0x0003CF18
		public virtual EFillType Type
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

		// Token: 0x04000F79 RID: 3961
		[Nullable(2)]
		protected IFillType FbInstance;

		// Token: 0x04000F7A RID: 3962
		[Nullable(2)]
		protected IFillType_SetValue PocoInterface;
	}
}

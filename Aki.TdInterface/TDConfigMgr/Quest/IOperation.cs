using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200115B RID: 4443
	public class IOperation
	{
		// Token: 0x0600624A RID: 25162 RVA: 0x000EC9B8 File Offset: 0x000EABB8
		private IOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x000EC9F0 File Offset: 0x000EABF0
		public static IOperation Create([Nullable(2)] IOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x000ECA03 File Offset: 0x000EAC03
		public static IOperation CreateFromSetValue([Nullable(2)] IOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x000ECA16 File Offset: 0x000EAC16
		public IOperation_SetValue ToSetValue()
		{
			return new IOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600624E RID: 25166 RVA: 0x000ECA29 File Offset: 0x000EAC29
		// (set) Token: 0x0600624F RID: 25167 RVA: 0x000ECA54 File Offset: 0x000EAC54
		public virtual EOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOperation.DisableHLOD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003ACF RID: 15055
		[Nullable(2)]
		protected IOperation FbInstance;

		// Token: 0x04003AD0 RID: 15056
		[Nullable(2)]
		protected IOperation_SetValue PocoInterface;
	}
}

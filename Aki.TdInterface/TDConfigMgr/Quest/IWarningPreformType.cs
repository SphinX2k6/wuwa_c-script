using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200134A RID: 4938
	public class IWarningPreformType
	{
		// Token: 0x06006F23 RID: 28451 RVA: 0x00107BE0 File Offset: 0x00105DE0
		private IWarningPreformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWarningPreformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWarningPreformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWarningPreformType_SetValue());
			}
			return result;
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00107C18 File Offset: 0x00105E18
		public static IWarningPreformType Create([Nullable(2)] IWarningPreformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00107C2B File Offset: 0x00105E2B
		public static IWarningPreformType CreateFromSetValue([Nullable(2)] IWarningPreformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00107C3E File Offset: 0x00105E3E
		public IWarningPreformType_SetValue ToSetValue()
		{
			return new IWarningPreformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x00107C51 File Offset: 0x00105E51
		// (set) Token: 0x06006F28 RID: 28456 RVA: 0x00107C7C File Offset: 0x00105E7C
		public virtual EWarningPreformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400422C RID: 16940
		[Nullable(2)]
		protected IWarningPreformType FbInstance;

		// Token: 0x0400422D RID: 16941
		[Nullable(2)]
		protected IWarningPreformType_SetValue PocoInterface;
	}
}

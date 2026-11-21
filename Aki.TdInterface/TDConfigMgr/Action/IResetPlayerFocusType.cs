using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC3 RID: 8131
	public class IResetPlayerFocusType
	{
		// Token: 0x0600ACCD RID: 44237 RVA: 0x00186750 File Offset: 0x00184950
		private IResetPlayerFocusType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPlayerFocusType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPlayerFocusType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPlayerFocusType_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x00186788 File Offset: 0x00184988
		public static IResetPlayerFocusType Create([Nullable(2)] IResetPlayerFocusType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x0018679B File Offset: 0x0018499B
		public static IResetPlayerFocusType CreateFromSetValue([Nullable(2)] IResetPlayerFocusType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x001867AE File Offset: 0x001849AE
		public IResetPlayerFocusType_SetValue ToSetValue()
		{
			return new IResetPlayerFocusType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600ACD1 RID: 44241 RVA: 0x001867C1 File Offset: 0x001849C1
		// (set) Token: 0x0600ACD2 RID: 44242 RVA: 0x001867EC File Offset: 0x001849EC
		public virtual EResetPlayerFocusType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400673F RID: 26431
		[Nullable(2)]
		protected IResetPlayerFocusType FbInstance;

		// Token: 0x04006740 RID: 26432
		[Nullable(2)]
		protected IResetPlayerFocusType_SetValue PocoInterface;
	}
}

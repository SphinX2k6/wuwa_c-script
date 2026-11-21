using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000529 RID: 1321
	public class ILookAtTargetBase
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x0004E314 File Offset: 0x0004C514
		private ILookAtTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0004E34C File Offset: 0x0004C54C
		public static ILookAtTargetBase Create([Nullable(2)] ILookAtTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004E35F File Offset: 0x0004C55F
		public static ILookAtTargetBase CreateFromSetValue([Nullable(2)] ILookAtTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0004E372 File Offset: 0x0004C572
		public ILookAtTargetBase_SetValue ToSetValue()
		{
			return new ILookAtTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0004E385 File Offset: 0x0004C585
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public virtual ELookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001395 RID: 5013
		[Nullable(2)]
		protected ILookAtTargetBase FbInstance;

		// Token: 0x04001396 RID: 5014
		[Nullable(2)]
		protected ILookAtTargetBase_SetValue PocoInterface;
	}
}

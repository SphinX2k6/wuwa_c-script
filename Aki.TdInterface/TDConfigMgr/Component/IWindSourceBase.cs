using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088C RID: 2188
	public class IWindSourceBase
	{
		// Token: 0x06002F31 RID: 12081 RVA: 0x00079C14 File Offset: 0x00077E14
		private IWindSourceBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindSourceBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindSourceBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindSourceBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00079C4C File Offset: 0x00077E4C
		public static IWindSourceBase Create([Nullable(2)] IWindSourceBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindSourceBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00079C5F File Offset: 0x00077E5F
		public static IWindSourceBase CreateFromSetValue([Nullable(2)] IWindSourceBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindSourceBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00079C72 File Offset: 0x00077E72
		public IWindSourceBase_SetValue ToSetValue()
		{
			return new IWindSourceBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x00079C85 File Offset: 0x00077E85
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x00079CB0 File Offset: 0x00077EB0
		public virtual EWindSourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWindSourceType.Directional;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001F3A RID: 7994
		[Nullable(2)]
		protected IWindSourceBase FbInstance;

		// Token: 0x04001F3B RID: 7995
		[Nullable(2)]
		protected IWindSourceBase_SetValue PocoInterface;
	}
}

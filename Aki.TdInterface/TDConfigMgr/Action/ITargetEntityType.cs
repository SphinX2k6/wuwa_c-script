using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C9 RID: 8649
	public class ITargetEntityType
	{
		// Token: 0x0600BC8A RID: 48266 RVA: 0x001B4790 File Offset: 0x001B2990
		private ITargetEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x001B47C8 File Offset: 0x001B29C8
		public static ITargetEntityType Create([Nullable(2)] ITargetEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x001B47DB File Offset: 0x001B29DB
		public static ITargetEntityType CreateFromSetValue([Nullable(2)] ITargetEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x001B47EE File Offset: 0x001B29EE
		public ITargetEntityType_SetValue ToSetValue()
		{
			return new ITargetEntityType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x001B4801 File Offset: 0x001B2A01
		// (set) Token: 0x0600BC8F RID: 48271 RVA: 0x001B482C File Offset: 0x001B2A2C
		public virtual ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007152 RID: 29010
		[Nullable(2)]
		protected ITargetEntityType FbInstance;

		// Token: 0x04007153 RID: 29011
		[Nullable(2)]
		protected ITargetEntityType_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004EE RID: 1262
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechHookConfigType
	{
		// Token: 0x060019A8 RID: 6568 RVA: 0x0004B9C8 File Offset: 0x00049BC8
		private IMechHookConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechHookConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechHookConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechHookConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0004BA00 File Offset: 0x00049C00
		public static IMechHookConfigType Create([Nullable(2)] IMechHookConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0004BA13 File Offset: 0x00049C13
		public static IMechHookConfigType CreateFromSetValue([Nullable(2)] IMechHookConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechHookConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0004BA26 File Offset: 0x00049C26
		public IMechHookConfigType_SetValue ToSetValue()
		{
			return new IMechHookConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0004BA39 File Offset: 0x00049C39
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0004BA64 File Offset: 0x00049C64
		public virtual EMechHookConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechHookConfigType.BurrowHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012C8 RID: 4808
		[Nullable(2)]
		protected IMechHookConfigType FbInstance;

		// Token: 0x040012C9 RID: 4809
		[Nullable(2)]
		protected IMechHookConfigType_SetValue PocoInterface;
	}
}

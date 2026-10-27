using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000327 RID: 807
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchConfig
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x00037AB0 File Offset: 0x00035CB0
		private IEntityMatchConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00037AE8 File Offset: 0x00035CE8
		public static IEntityMatchConfig Create([Nullable(2)] IEntityMatchConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00037AFB File Offset: 0x00035CFB
		public static IEntityMatchConfig CreateFromSetValue([Nullable(2)] IEntityMatchConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00037B0E File Offset: 0x00035D0E
		public IEntityMatchConfig_SetValue ToSetValue()
		{
			return new IEntityMatchConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00037B21 File Offset: 0x00035D21
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00037B4C File Offset: 0x00035D4C
		public virtual EEntityMatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityMatchType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000D7B RID: 3451
		[Nullable(2)]
		protected IEntityMatchConfig FbInstance;

		// Token: 0x04000D7C RID: 3452
		[Nullable(2)]
		protected IEntityMatchConfig_SetValue PocoInterface;
	}
}

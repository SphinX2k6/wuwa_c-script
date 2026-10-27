using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000325 RID: 805
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchAllCharacter : IEntityMatchConfig
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x000379F4 File Offset: 0x00035BF4
		private IEntityMatchAllCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchAllCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchAllCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchAllCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00037A2C File Offset: 0x00035C2C
		public static IEntityMatchAllCharacter Create([Nullable(2)] IEntityMatchAllCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchAllCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00037A3F File Offset: 0x00035C3F
		public static IEntityMatchAllCharacter CreateFromSetValue([Nullable(2)] IEntityMatchAllCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchAllCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00037A52 File Offset: 0x00035C52
		public new IEntityMatchAllCharacter_SetValue ToSetValue()
		{
			return new IEntityMatchAllCharacter_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00037A65 File Offset: 0x00035C65
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00037A90 File Offset: 0x00035C90
		public override EEntityMatchType Type
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

		// Token: 0x04000D78 RID: 3448
		[Nullable(2)]
		protected new IEntityMatchAllCharacter FbInstance;

		// Token: 0x04000D79 RID: 3449
		[Nullable(2)]
		protected new IEntityMatchAllCharacter_SetValue PocoInterface;
	}
}

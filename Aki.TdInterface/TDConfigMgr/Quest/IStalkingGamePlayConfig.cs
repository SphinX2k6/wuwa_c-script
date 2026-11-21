using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001278 RID: 4728
	public class IStalkingGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06006A71 RID: 27249 RVA: 0x000FE924 File Offset: 0x000FCB24
		private IStalkingGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStalkingGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStalkingGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStalkingGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x000FE95C File Offset: 0x000FCB5C
		public static IStalkingGamePlayConfig Create([Nullable(2)] IStalkingGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x000FE96F File Offset: 0x000FCB6F
		public static IStalkingGamePlayConfig CreateFromSetValue([Nullable(2)] IStalkingGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x000FE982 File Offset: 0x000FCB82
		public new IStalkingGamePlayConfig_SetValue ToSetValue()
		{
			return new IStalkingGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x000FE995 File Offset: 0x000FCB95
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x000FE9C0 File Offset: 0x000FCBC0
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003FA6 RID: 16294
		[Nullable(2)]
		protected new IStalkingGamePlayConfig FbInstance;

		// Token: 0x04003FA7 RID: 16295
		[Nullable(2)]
		protected new IStalkingGamePlayConfig_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DEA RID: 7658
	[NullableContext(1)]
	[Nullable(0)]
	public class IScreenType
	{
		// Token: 0x0600A3EB RID: 41963 RVA: 0x00173FB0 File Offset: 0x001721B0
		private IScreenType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IScreenType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IScreenType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IScreenType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x00173FE8 File Offset: 0x001721E8
		public static IScreenType Create([Nullable(2)] IScreenType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScreenType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x00173FFB File Offset: 0x001721FB
		public static IScreenType CreateFromSetValue([Nullable(2)] IScreenType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IScreenType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x0017400E File Offset: 0x0017220E
		public IScreenType_SetValue ToSetValue()
		{
			return new IScreenType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x00174021 File Offset: 0x00172221
		// (set) Token: 0x0600A3F0 RID: 41968 RVA: 0x0017404C File Offset: 0x0017224C
		public virtual EScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EScreenType.Main;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006238 RID: 25144
		[Nullable(2)]
		protected IScreenType FbInstance;

		// Token: 0x04006239 RID: 25145
		[Nullable(2)]
		protected IScreenType_SetValue PocoInterface;
	}
}

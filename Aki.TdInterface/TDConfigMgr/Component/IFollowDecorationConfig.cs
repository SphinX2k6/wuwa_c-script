using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003EF RID: 1007
	public class IFollowDecorationConfig
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x00040854 File Offset: 0x0003EA54
		private IFollowDecorationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowDecorationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowDecorationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowDecorationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0004088C File Offset: 0x0003EA8C
		public static IFollowDecorationConfig Create([Nullable(2)] IFollowDecorationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0004089F File Offset: 0x0003EA9F
		public static IFollowDecorationConfig CreateFromSetValue([Nullable(2)] IFollowDecorationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000408B2 File Offset: 0x0003EAB2
		public IFollowDecorationConfig_SetValue ToSetValue()
		{
			return new IFollowDecorationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x000408C5 File Offset: 0x0003EAC5
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x000408F0 File Offset: 0x0003EAF0
		public virtual EFollowDecorationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowDecorationType.Chair;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000FF0 RID: 4080
		[Nullable(2)]
		protected IFollowDecorationConfig FbInstance;

		// Token: 0x04000FF1 RID: 4081
		[Nullable(2)]
		protected IFollowDecorationConfig_SetValue PocoInterface;
	}
}

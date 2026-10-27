using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066A RID: 1642
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshContent
	{
		// Token: 0x0600231C RID: 8988 RVA: 0x00060284 File Offset: 0x0005E484
		private IRefreshContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshContent_SetValue());
			}
			return result;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000602BC File Offset: 0x0005E4BC
		public static IRefreshContent Create([Nullable(2)] IRefreshContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000602CF File Offset: 0x0005E4CF
		public static IRefreshContent CreateFromSetValue([Nullable(2)] IRefreshContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x000602E2 File Offset: 0x0005E4E2
		public IRefreshContent_SetValue ToSetValue()
		{
			return new IRefreshContent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000602F5 File Offset: 0x0005E4F5
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x00060320 File Offset: 0x0005E520
		public virtual ERefreshContent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshContent.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001852 RID: 6226
		[Nullable(2)]
		protected IRefreshContent FbInstance;

		// Token: 0x04001853 RID: 6227
		[Nullable(2)]
		protected IRefreshContent_SetValue PocoInterface;
	}
}

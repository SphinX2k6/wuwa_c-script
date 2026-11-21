using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001983 RID: 6531
	public class IBasePos2
	{
		// Token: 0x06008AEF RID: 35567 RVA: 0x00149EF4 File Offset: 0x001480F4
		private IBasePos2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBasePos2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBasePos2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBasePos2_SetValue());
			}
			return result;
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00149F2C File Offset: 0x0014812C
		public static IBasePos2 Create([Nullable(2)] IBasePos2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBasePos2
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00149F3F File Offset: 0x0014813F
		public static IBasePos2 CreateFromSetValue([Nullable(2)] IBasePos2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBasePos2
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x00149F52 File Offset: 0x00148152
		public IBasePos2_SetValue ToSetValue()
		{
			return new IBasePos2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x06008AF3 RID: 35571 RVA: 0x00149F65 File Offset: 0x00148165
		// (set) Token: 0x06008AF4 RID: 35572 RVA: 0x00149F90 File Offset: 0x00148190
		public virtual EPos2 Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPos2.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040057D8 RID: 22488
		[Nullable(2)]
		protected IBasePos2 FbInstance;

		// Token: 0x040057D9 RID: 22489
		[Nullable(2)]
		protected IBasePos2_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225C RID: 8796
	public class IUiStyleBaseOfLevelD
	{
		// Token: 0x0600BFAE RID: 49070 RVA: 0x001BA360 File Offset: 0x001B8560
		private IUiStyleBaseOfLevelD_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiStyleBaseOfLevelD 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiStyleBaseOfLevelD_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiStyleBaseOfLevelD_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x001BA398 File Offset: 0x001B8598
		public static IUiStyleBaseOfLevelD Create([Nullable(2)] IUiStyleBaseOfLevelD instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x001BA3AB File Offset: 0x001B85AB
		public static IUiStyleBaseOfLevelD CreateFromSetValue([Nullable(2)] IUiStyleBaseOfLevelD_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x001BA3BE File Offset: 0x001B85BE
		public IUiStyleBaseOfLevelD_SetValue ToSetValue()
		{
			return new IUiStyleBaseOfLevelD_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x001BA3D1 File Offset: 0x001B85D1
		// (set) Token: 0x0600BFB3 RID: 49075 RVA: 0x001BA3FC File Offset: 0x001B85FC
		public virtual EUiStyleTypeOfLevelD Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040072D0 RID: 29392
		[Nullable(2)]
		protected IUiStyleBaseOfLevelD FbInstance;

		// Token: 0x040072D1 RID: 29393
		[Nullable(2)]
		protected IUiStyleBaseOfLevelD_SetValue PocoInterface;
	}
}

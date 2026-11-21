using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BE RID: 446
	public class IAddBuffMode
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00023C98 File Offset: 0x00021E98
		private IAddBuffMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddBuffMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddBuffMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddBuffMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00023CD0 File Offset: 0x00021ED0
		public static IAddBuffMode Create([Nullable(2)] IAddBuffMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddBuffMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00023CE3 File Offset: 0x00021EE3
		public static IAddBuffMode CreateFromSetValue([Nullable(2)] IAddBuffMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddBuffMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00023CF6 File Offset: 0x00021EF6
		public IAddBuffMode_SetValue ToSetValue()
		{
			return new IAddBuffMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00023D09 File Offset: 0x00021F09
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00023D34 File Offset: 0x00021F34
		public virtual EBuffProducerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBuffProducerMode.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000874 RID: 2164
		[Nullable(2)]
		protected IAddBuffMode FbInstance;

		// Token: 0x04000875 RID: 2165
		[Nullable(2)]
		protected IAddBuffMode_SetValue PocoInterface;
	}
}

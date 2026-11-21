using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA5 RID: 7589
	public class IMapConfig
	{
		// Token: 0x0600A117 RID: 41239 RVA: 0x00171490 File Offset: 0x0016F690
		private IMapConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMapConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMapConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMapConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x001714C8 File Offset: 0x0016F6C8
		public static IMapConfig Create([Nullable(2)] IMapConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMapConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x001714DB File Offset: 0x0016F6DB
		public static IMapConfig CreateFromSetValue([Nullable(2)] IMapConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMapConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x001714EE File Offset: 0x0016F6EE
		public IMapConfig_SetValue ToSetValue()
		{
			return new IMapConfig_SetValue
			{
				ExpandAreaTerminal = this.ExpandAreaTerminal
			};
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A11B RID: 41243 RVA: 0x00171501 File Offset: 0x0016F701
		// (set) Token: 0x0600A11C RID: 41244 RVA: 0x0017152C File Offset: 0x0016F72C
		public virtual bool ExpandAreaTerminal
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExpandAreaTerminal;
				}
				return this.PocoInterface != null && this.PocoInterface.ExpandAreaTerminal;
			}
			set
			{
				this.GetOrCreatePoco().ExpandAreaTerminal = value;
			}
		}

		// Token: 0x040061DF RID: 25055
		[Nullable(2)]
		protected IMapConfig FbInstance;

		// Token: 0x040061E0 RID: 25056
		[Nullable(2)]
		protected IMapConfig_SetValue PocoInterface;
	}
}

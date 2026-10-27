using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBE RID: 7102
	[NullableContext(1)]
	[Nullable(0)]
	public class IMapConfig
	{
		// Token: 0x06009813 RID: 38931 RVA: 0x0015E9D0 File Offset: 0x0015CBD0
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

		// Token: 0x06009814 RID: 38932 RVA: 0x0015EA08 File Offset: 0x0015CC08
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

		// Token: 0x06009815 RID: 38933 RVA: 0x0015EA1B File Offset: 0x0015CC1B
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

		// Token: 0x06009816 RID: 38934 RVA: 0x0015EA2E File Offset: 0x0015CC2E
		public IMapConfig_SetValue ToSetValue()
		{
			return new IMapConfig_SetValue
			{
				ExpandAreaTerminal = this.ExpandAreaTerminal
			};
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x06009817 RID: 38935 RVA: 0x0015EA41 File Offset: 0x0015CC41
		// (set) Token: 0x06009818 RID: 38936 RVA: 0x0015EA6C File Offset: 0x0015CC6C
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

		// Token: 0x04005CCA RID: 23754
		[Nullable(2)]
		protected IMapConfig FbInstance;

		// Token: 0x04005CCB RID: 23755
		[Nullable(2)]
		protected IMapConfig_SetValue PocoInterface;
	}
}

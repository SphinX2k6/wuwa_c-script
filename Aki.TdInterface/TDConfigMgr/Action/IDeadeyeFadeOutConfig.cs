using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B01 RID: 6913
	public class IDeadeyeFadeOutConfig
	{
		// Token: 0x060092D9 RID: 37593 RVA: 0x00157D38 File Offset: 0x00155F38
		private IDeadeyeFadeOutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeFadeOutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeFadeOutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeFadeOutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x00157D70 File Offset: 0x00155F70
		public static IDeadeyeFadeOutConfig Create([Nullable(2)] IDeadeyeFadeOutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x00157D83 File Offset: 0x00155F83
		public static IDeadeyeFadeOutConfig CreateFromSetValue([Nullable(2)] IDeadeyeFadeOutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x00157D96 File Offset: 0x00155F96
		public IDeadeyeFadeOutConfig_SetValue ToSetValue()
		{
			return new IDeadeyeFadeOutConfig_SetValue
			{
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x00157DA9 File Offset: 0x00155FA9
		// (set) Token: 0x060092DE RID: 37598 RVA: 0x00157DD8 File Offset: 0x00155FD8
		public virtual float TransitionTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionTime;
			}
			set
			{
				this.GetOrCreatePoco().TransitionTime = value;
			}
		}

		// Token: 0x04005B66 RID: 23398
		[Nullable(2)]
		protected IDeadeyeFadeOutConfig FbInstance;

		// Token: 0x04005B67 RID: 23399
		[Nullable(2)]
		protected IDeadeyeFadeOutConfig_SetValue PocoInterface;
	}
}

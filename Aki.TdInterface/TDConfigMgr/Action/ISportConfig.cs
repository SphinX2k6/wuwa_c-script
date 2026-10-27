using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EAB RID: 7851
	[NullableContext(1)]
	[Nullable(0)]
	public class ISportConfig
	{
		// Token: 0x0600A7F2 RID: 42994 RVA: 0x0017B578 File Offset: 0x00179778
		private ISportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x0017B5B0 File Offset: 0x001797B0
		public static ISportConfig Create([Nullable(2)] ISportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x0017B5C3 File Offset: 0x001797C3
		public static ISportConfig CreateFromSetValue([Nullable(2)] ISportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x0017B5D6 File Offset: 0x001797D6
		public ISportConfig_SetValue ToSetValue()
		{
			return new ISportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x0017B5E9 File Offset: 0x001797E9
		// (set) Token: 0x0600A7F7 RID: 42999 RVA: 0x0017B614 File Offset: 0x00179814
		public virtual ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006419 RID: 25625
		[Nullable(2)]
		protected ISportConfig FbInstance;

		// Token: 0x0400641A RID: 25626
		[Nullable(2)]
		protected ISportConfig_SetValue PocoInterface;
	}
}

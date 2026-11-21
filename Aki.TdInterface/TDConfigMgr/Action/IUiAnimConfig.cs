using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002255 RID: 8789
	[NullableContext(2)]
	[Nullable(0)]
	public class IUiAnimConfig
	{
		// Token: 0x0600BF92 RID: 49042 RVA: 0x001BA040 File Offset: 0x001B8240
		[NullableContext(0)]
		private IUiAnimConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiAnimConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiAnimConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiAnimConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x001BA078 File Offset: 0x001B8278
		[NullableContext(0)]
		public static IUiAnimConfig Create([Nullable(2)] IUiAnimConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x001BA08B File Offset: 0x001B828B
		[NullableContext(0)]
		public static IUiAnimConfig CreateFromSetValue([Nullable(2)] IUiAnimConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x001BA09E File Offset: 0x001B829E
		[NullableContext(0)]
		public IUiAnimConfig_SetValue ToSetValue()
		{
			return new IUiAnimConfig_SetValue
			{
				UiStartAnimName = this.UiStartAnimName,
				UiEndAnimName = this.UiEndAnimName
			};
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600BF96 RID: 49046 RVA: 0x001BA0BD File Offset: 0x001B82BD
		// (set) Token: 0x0600BF97 RID: 49047 RVA: 0x001BA0E4 File Offset: 0x001B82E4
		public virtual string UiStartAnimName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStartAnimName;
				}
				IUiAnimConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiStartAnimName;
			}
			set
			{
				this.GetOrCreatePoco().UiStartAnimName = value;
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600BF98 RID: 49048 RVA: 0x001BA0F2 File Offset: 0x001B82F2
		// (set) Token: 0x0600BF99 RID: 49049 RVA: 0x001BA119 File Offset: 0x001B8319
		public virtual string UiEndAnimName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiEndAnimName;
				}
				IUiAnimConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiEndAnimName;
			}
			set
			{
				this.GetOrCreatePoco().UiEndAnimName = value;
			}
		}

		// Token: 0x040072C6 RID: 29382
		protected IUiAnimConfig FbInstance;

		// Token: 0x040072C7 RID: 29383
		protected IUiAnimConfig_SetValue PocoInterface;
	}
}

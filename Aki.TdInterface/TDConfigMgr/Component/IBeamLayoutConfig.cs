using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001F1 RID: 497
	[NullableContext(1)]
	[Nullable(0)]
	public class IBeamLayoutConfig
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00026380 File Offset: 0x00024580
		private IBeamLayoutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBeamLayoutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBeamLayoutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBeamLayoutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000263B8 File Offset: 0x000245B8
		public static IBeamLayoutConfig Create([Nullable(2)] IBeamLayoutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000263CB File Offset: 0x000245CB
		public static IBeamLayoutConfig CreateFromSetValue([Nullable(2)] IBeamLayoutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000263DE File Offset: 0x000245DE
		public IBeamLayoutConfig_SetValue ToSetValue()
		{
			return new IBeamLayoutConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000263F1 File Offset: 0x000245F1
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0002641C File Offset: 0x0002461C
		public virtual EBeamLayoutType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBeamLayoutType.BeamWall;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008FB RID: 2299
		[Nullable(2)]
		protected IBeamLayoutConfig FbInstance;

		// Token: 0x040008FC RID: 2300
		[Nullable(2)]
		protected IBeamLayoutConfig_SetValue PocoInterface;
	}
}

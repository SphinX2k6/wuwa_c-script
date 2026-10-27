using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D3 RID: 723
	[NullableContext(1)]
	[Nullable(0)]
	public class IDrawConfig
	{
		// Token: 0x06000DC7 RID: 3527 RVA: 0x00032F08 File Offset: 0x00031108
		private IDrawConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDrawConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDrawConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDrawConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00032F40 File Offset: 0x00031140
		public static IDrawConfig Create([Nullable(2)] IDrawConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDrawConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00032F53 File Offset: 0x00031153
		public static IDrawConfig CreateFromSetValue([Nullable(2)] IDrawConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDrawConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00032F68 File Offset: 0x00031168
		public IDrawConfig_SetValue ToSetValue()
		{
			return new IDrawConfig_SetValue
			{
				DrawDelay = this.DrawDelay,
				DrawTime = this.DrawTime,
				DrawAlignTime = this.DrawAlignTime,
				DrawAlignHeight = this.DrawAlignHeight,
				DrawCameraShake = this.DrawCameraShake
			};
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00032FB6 File Offset: 0x000311B6
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00032FE1 File Offset: 0x000311E1
		public virtual int DrawDelay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DrawDelay;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DrawDelay;
			}
			set
			{
				this.GetOrCreatePoco().DrawDelay = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00032FEF File Offset: 0x000311EF
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x0003301A File Offset: 0x0003121A
		public virtual int DrawTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DrawTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DrawTime;
			}
			set
			{
				this.GetOrCreatePoco().DrawTime = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00033028 File Offset: 0x00031228
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00033053 File Offset: 0x00031253
		public virtual int DrawAlignTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DrawAlignTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DrawAlignTime;
			}
			set
			{
				this.GetOrCreatePoco().DrawAlignTime = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00033061 File Offset: 0x00031261
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0003308C File Offset: 0x0003128C
		public virtual int DrawAlignHeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DrawAlignHeight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DrawAlignHeight;
			}
			set
			{
				this.GetOrCreatePoco().DrawAlignHeight = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0003309A File Offset: 0x0003129A
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x000330C5 File Offset: 0x000312C5
		public virtual string DrawCameraShake
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DrawCameraShake;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DrawCameraShake;
			}
			set
			{
				this.GetOrCreatePoco().DrawCameraShake = value;
			}
		}

		// Token: 0x04000C65 RID: 3173
		[Nullable(2)]
		protected IDrawConfig FbInstance;

		// Token: 0x04000C66 RID: 3174
		[Nullable(2)]
		protected IDrawConfig_SetValue PocoInterface;
	}
}

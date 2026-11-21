using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200031A RID: 794
	public class IDrawConfig
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x00035E3C File Offset: 0x0003403C
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

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00035E74 File Offset: 0x00034074
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

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00035E87 File Offset: 0x00034087
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

		// Token: 0x06000EFA RID: 3834 RVA: 0x00035E9C File Offset: 0x0003409C
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00035EEA File Offset: 0x000340EA
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00035F15 File Offset: 0x00034115
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00035F23 File Offset: 0x00034123
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00035F4E File Offset: 0x0003414E
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00035F5C File Offset: 0x0003415C
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00035F87 File Offset: 0x00034187
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00035F95 File Offset: 0x00034195
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00035FC0 File Offset: 0x000341C0
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00035FCE File Offset: 0x000341CE
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00035FF9 File Offset: 0x000341F9
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

		// Token: 0x04000D4F RID: 3407
		[Nullable(2)]
		protected IDrawConfig FbInstance;

		// Token: 0x04000D50 RID: 3408
		[Nullable(2)]
		protected IDrawConfig_SetValue PocoInterface;
	}
}

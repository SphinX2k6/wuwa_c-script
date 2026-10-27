using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0A RID: 6666
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityControlConfig
	{
		// Token: 0x06008ECB RID: 36555 RVA: 0x0014DC30 File Offset: 0x0014BE30
		private IEntityControlConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityControlConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityControlConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityControlConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0014DC68 File Offset: 0x0014BE68
		public static IEntityControlConfig Create([Nullable(2)] IEntityControlConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityControlConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x0014DC7B File Offset: 0x0014BE7B
		public static IEntityControlConfig CreateFromSetValue([Nullable(2)] IEntityControlConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityControlConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x0014DC8E File Offset: 0x0014BE8E
		public IEntityControlConfig_SetValue ToSetValue()
		{
			return new IEntityControlConfig_SetValue
			{
				IsControlPlayer = this.IsControlPlayer,
				HideSkipButton = this.HideSkipButton,
				CameraMode = this.CameraMode
			};
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x06008ECF RID: 36559 RVA: 0x0014DCBC File Offset: 0x0014BEBC
		// (set) Token: 0x06008ED0 RID: 36560 RVA: 0x0014DCF6 File Offset: 0x0014BEF6
		public virtual bool? IsControlPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsControlPlayer;
				}
				IEntityControlConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsControlPlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsControlPlayer = value;
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x0014DD04 File Offset: 0x0014BF04
		// (set) Token: 0x06008ED2 RID: 36562 RVA: 0x0014DD3E File Offset: 0x0014BF3E
		public virtual bool? HideSkipButton
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideSkipButton;
				}
				IEntityControlConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideSkipButton;
			}
			set
			{
				this.GetOrCreatePoco().HideSkipButton = value;
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x06008ED3 RID: 36563 RVA: 0x0014DD4C File Offset: 0x0014BF4C
		// (set) Token: 0x06008ED4 RID: 36564 RVA: 0x0014DD86 File Offset: 0x0014BF86
		public virtual EEntityControlCameraMode? CameraMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraMode;
				}
				IEntityControlConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraMode;
			}
			set
			{
				this.GetOrCreatePoco().CameraMode = value;
			}
		}

		// Token: 0x04005870 RID: 22640
		[Nullable(2)]
		protected IEntityControlConfig FbInstance;

		// Token: 0x04005871 RID: 22641
		[Nullable(2)]
		protected IEntityControlConfig_SetValue PocoInterface;
	}
}

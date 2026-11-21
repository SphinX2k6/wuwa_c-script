using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9D RID: 7069
	public class IEntityControlConfig
	{
		// Token: 0x0600962D RID: 38445 RVA: 0x0015DAA0 File Offset: 0x0015BCA0
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

		// Token: 0x0600962E RID: 38446 RVA: 0x0015DAD8 File Offset: 0x0015BCD8
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

		// Token: 0x0600962F RID: 38447 RVA: 0x0015DAEB File Offset: 0x0015BCEB
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

		// Token: 0x06009630 RID: 38448 RVA: 0x0015DAFE File Offset: 0x0015BCFE
		public IEntityControlConfig_SetValue ToSetValue()
		{
			return new IEntityControlConfig_SetValue
			{
				IsControlPlayer = this.IsControlPlayer,
				HideSkipButton = this.HideSkipButton,
				CameraMode = this.CameraMode
			};
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06009631 RID: 38449 RVA: 0x0015DB2C File Offset: 0x0015BD2C
		// (set) Token: 0x06009632 RID: 38450 RVA: 0x0015DB66 File Offset: 0x0015BD66
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

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06009633 RID: 38451 RVA: 0x0015DB74 File Offset: 0x0015BD74
		// (set) Token: 0x06009634 RID: 38452 RVA: 0x0015DBAE File Offset: 0x0015BDAE
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

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06009635 RID: 38453 RVA: 0x0015DBBC File Offset: 0x0015BDBC
		// (set) Token: 0x06009636 RID: 38454 RVA: 0x0015DBF6 File Offset: 0x0015BDF6
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

		// Token: 0x04005CD2 RID: 23762
		[Nullable(2)]
		protected IEntityControlConfig FbInstance;

		// Token: 0x04005CD3 RID: 23763
		[Nullable(2)]
		protected IEntityControlConfig_SetValue PocoInterface;
	}
}

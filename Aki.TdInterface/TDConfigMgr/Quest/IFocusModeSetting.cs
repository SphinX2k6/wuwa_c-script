using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010C3 RID: 4291
	public class IFocusModeSetting
	{
		// Token: 0x06005EC4 RID: 24260 RVA: 0x000E586C File Offset: 0x000E3A6C
		private IFocusModeSetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusModeSetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusModeSetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusModeSetting_SetValue());
			}
			return result;
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x000E58A4 File Offset: 0x000E3AA4
		public static IFocusModeSetting Create([Nullable(2)] IFocusModeSetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusModeSetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x000E58B7 File Offset: 0x000E3AB7
		public static IFocusModeSetting CreateFromSetValue([Nullable(2)] IFocusModeSetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusModeSetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x000E58CA File Offset: 0x000E3ACA
		public IFocusModeSetting_SetValue ToSetValue()
		{
			return new IFocusModeSetting_SetValue
			{
				CanOpenFocusMode = this.CanOpenFocusMode,
				IsFocusModeInherit = this.IsFocusModeInherit,
				CanAcceptInFocusMode = this.CanAcceptInFocusMode,
				IsFocusModeWhiteList = this.IsFocusModeWhiteList
			};
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x000E5904 File Offset: 0x000E3B04
		// (set) Token: 0x06005EC9 RID: 24265 RVA: 0x000E593E File Offset: 0x000E3B3E
		public virtual bool? CanOpenFocusMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanOpenFocusMode;
				}
				IFocusModeSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanOpenFocusMode;
			}
			set
			{
				this.GetOrCreatePoco().CanOpenFocusMode = value;
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x000E594C File Offset: 0x000E3B4C
		// (set) Token: 0x06005ECB RID: 24267 RVA: 0x000E5986 File Offset: 0x000E3B86
		public virtual bool? IsFocusModeInherit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFocusModeInherit;
				}
				IFocusModeSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFocusModeInherit;
			}
			set
			{
				this.GetOrCreatePoco().IsFocusModeInherit = value;
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x000E5994 File Offset: 0x000E3B94
		// (set) Token: 0x06005ECD RID: 24269 RVA: 0x000E59CE File Offset: 0x000E3BCE
		public virtual bool? CanAcceptInFocusMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanAcceptInFocusMode;
				}
				IFocusModeSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanAcceptInFocusMode;
			}
			set
			{
				this.GetOrCreatePoco().CanAcceptInFocusMode = value;
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x000E59DC File Offset: 0x000E3BDC
		// (set) Token: 0x06005ECF RID: 24271 RVA: 0x000E5A16 File Offset: 0x000E3C16
		public virtual bool? IsFocusModeWhiteList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFocusModeWhiteList;
				}
				IFocusModeSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFocusModeWhiteList;
			}
			set
			{
				this.GetOrCreatePoco().IsFocusModeWhiteList = value;
			}
		}

		// Token: 0x040038E6 RID: 14566
		[Nullable(2)]
		protected IFocusModeSetting FbInstance;

		// Token: 0x040038E7 RID: 14567
		[Nullable(2)]
		protected IFocusModeSetting_SetValue PocoInterface;
	}
}

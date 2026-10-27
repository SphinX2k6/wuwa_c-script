using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F99 RID: 3993
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusModeSetting
	{
		// Token: 0x060058F2 RID: 22770 RVA: 0x000D8E44 File Offset: 0x000D7044
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

		// Token: 0x060058F3 RID: 22771 RVA: 0x000D8E7C File Offset: 0x000D707C
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

		// Token: 0x060058F4 RID: 22772 RVA: 0x000D8E8F File Offset: 0x000D708F
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

		// Token: 0x060058F5 RID: 22773 RVA: 0x000D8EA2 File Offset: 0x000D70A2
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

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x000D8EDC File Offset: 0x000D70DC
		// (set) Token: 0x060058F7 RID: 22775 RVA: 0x000D8F16 File Offset: 0x000D7116
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

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x000D8F24 File Offset: 0x000D7124
		// (set) Token: 0x060058F9 RID: 22777 RVA: 0x000D8F5E File Offset: 0x000D715E
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

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x000D8F6C File Offset: 0x000D716C
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x000D8FA6 File Offset: 0x000D71A6
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

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x000D8FEE File Offset: 0x000D71EE
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

		// Token: 0x040035B6 RID: 13750
		[Nullable(2)]
		protected IFocusModeSetting FbInstance;

		// Token: 0x040035B7 RID: 13751
		[Nullable(2)]
		protected IFocusModeSetting_SetValue PocoInterface;
	}
}

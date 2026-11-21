using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000304 RID: 772
	public class IDollComboCameraConfig
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00034770 File Offset: 0x00032970
		private IDollComboCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollComboCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollComboCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollComboCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000347A8 File Offset: 0x000329A8
		public static IDollComboCameraConfig Create([Nullable(2)] IDollComboCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollComboCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000347BB File Offset: 0x000329BB
		public static IDollComboCameraConfig CreateFromSetValue([Nullable(2)] IDollComboCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollComboCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000347CE File Offset: 0x000329CE
		public IDollComboCameraConfig_SetValue ToSetValue()
		{
			return new IDollComboCameraConfig_SetValue
			{
				ComboId = this.ComboId,
				PosAndRot = this.PosAndRot
			};
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000347ED File Offset: 0x000329ED
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00034818 File Offset: 0x00032A18
		public virtual int ComboId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ComboId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ComboId;
			}
			set
			{
				this.GetOrCreatePoco().ComboId = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00034828 File Offset: 0x00032A28
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00034889 File Offset: 0x00032A89
		public virtual PosAndRot PosAndRot
		{
			get
			{
				if (this._PosAndRotInited)
				{
					return this._PosAndRotCache;
				}
				this._PosAndRotInited = true;
				if (this.FbInstance != null)
				{
					this._PosAndRotCache = PosAndRot.Create(this.FbInstance.PosAndRot);
				}
				else
				{
					IDollComboCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._PosAndRotCache = ((pocoInterface != null) ? pocoInterface.PosAndRot : null);
				}
				return this._PosAndRotCache;
			}
			set
			{
				this.GetOrCreatePoco().PosAndRot = value;
				this._PosAndRotInited = false;
			}
		}

		// Token: 0x04000CED RID: 3309
		[Nullable(2)]
		protected IDollComboCameraConfig FbInstance;

		// Token: 0x04000CEE RID: 3310
		[Nullable(2)]
		protected IDollComboCameraConfig_SetValue PocoInterface;

		// Token: 0x04000CEF RID: 3311
		private PosAndRot _PosAndRotCache;

		// Token: 0x04000CF0 RID: 3312
		private bool _PosAndRotInited;
	}
}

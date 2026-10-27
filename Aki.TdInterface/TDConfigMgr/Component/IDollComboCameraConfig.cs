using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BD RID: 701
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollComboCameraConfig
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x0003183C File Offset: 0x0002FA3C
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

		// Token: 0x06000D2A RID: 3370 RVA: 0x00031874 File Offset: 0x0002FA74
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

		// Token: 0x06000D2B RID: 3371 RVA: 0x00031887 File Offset: 0x0002FA87
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x0003189A File Offset: 0x0002FA9A
		public IDollComboCameraConfig_SetValue ToSetValue()
		{
			return new IDollComboCameraConfig_SetValue
			{
				ComboId = this.ComboId,
				PosAndRot = this.PosAndRot
			};
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000318B9 File Offset: 0x0002FAB9
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000318E4 File Offset: 0x0002FAE4
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000318F4 File Offset: 0x0002FAF4
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00031955 File Offset: 0x0002FB55
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

		// Token: 0x04000C03 RID: 3075
		[Nullable(2)]
		protected IDollComboCameraConfig FbInstance;

		// Token: 0x04000C04 RID: 3076
		[Nullable(2)]
		protected IDollComboCameraConfig_SetValue PocoInterface;

		// Token: 0x04000C05 RID: 3077
		private PosAndRot _PosAndRotCache;

		// Token: 0x04000C06 RID: 3078
		private bool _PosAndRotInited;
	}
}

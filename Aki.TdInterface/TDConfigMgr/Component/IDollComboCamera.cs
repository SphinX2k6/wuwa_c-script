using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000302 RID: 770
	public class IDollComboCamera
	{
		// Token: 0x06000E4F RID: 3663 RVA: 0x000345FC File Offset: 0x000327FC
		private IDollComboCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollComboCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollComboCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollComboCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00034634 File Offset: 0x00032834
		public static IDollComboCamera Create([Nullable(2)] IDollComboCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollComboCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00034647 File Offset: 0x00032847
		public static IDollComboCamera CreateFromSetValue([Nullable(2)] IDollComboCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollComboCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0003465A File Offset: 0x0003285A
		public IDollComboCamera_SetValue ToSetValue()
		{
			return new IDollComboCamera_SetValue
			{
				Fov = this.Fov,
				ComboCameras = this.ComboCameras
			};
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00034679 File Offset: 0x00032879
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x000346A8 File Offset: 0x000328A8
		public virtual float Fov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fov;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Fov;
			}
			set
			{
				this.GetOrCreatePoco().Fov = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000346B8 File Offset: 0x000328B8
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0003474B File Offset: 0x0003294B
		public virtual List<IDollComboCameraConfig> ComboCameras
		{
			get
			{
				if (this._ComboCamerasInited)
				{
					return this._ComboCamerasCache;
				}
				this._ComboCamerasInited = true;
				if (this.FbInstance != null)
				{
					List<IDollComboCameraConfig> comboCameras = this.FbInstance.ComboCameras;
					if (comboCameras != null)
					{
						this._ComboCamerasCache = new List<IDollComboCameraConfig>(comboCameras.Count);
						for (int i = 0; i < comboCameras.Count; i++)
						{
							this._ComboCamerasCache.Add(IDollComboCameraConfig.Create(comboCameras[i]));
						}
					}
				}
				else
				{
					IDollComboCamera_SetValue pocoInterface = this.PocoInterface;
					this._ComboCamerasCache = ((pocoInterface != null) ? pocoInterface.ComboCameras : null);
				}
				return this._ComboCamerasCache;
			}
			set
			{
				this.GetOrCreatePoco().ComboCameras = value;
				this._ComboCamerasInited = false;
			}
		}

		// Token: 0x04000CE7 RID: 3303
		[Nullable(2)]
		protected IDollComboCamera FbInstance;

		// Token: 0x04000CE8 RID: 3304
		[Nullable(2)]
		protected IDollComboCamera_SetValue PocoInterface;

		// Token: 0x04000CE9 RID: 3305
		private List<IDollComboCameraConfig> _ComboCamerasCache;

		// Token: 0x04000CEA RID: 3306
		private bool _ComboCamerasInited;
	}
}

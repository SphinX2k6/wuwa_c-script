using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BB RID: 699
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollComboCamera
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x000316C8 File Offset: 0x0002F8C8
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

		// Token: 0x06000D20 RID: 3360 RVA: 0x00031700 File Offset: 0x0002F900
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

		// Token: 0x06000D21 RID: 3361 RVA: 0x00031713 File Offset: 0x0002F913
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

		// Token: 0x06000D22 RID: 3362 RVA: 0x00031726 File Offset: 0x0002F926
		public IDollComboCamera_SetValue ToSetValue()
		{
			return new IDollComboCamera_SetValue
			{
				Fov = this.Fov,
				ComboCameras = this.ComboCameras
			};
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00031745 File Offset: 0x0002F945
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00031774 File Offset: 0x0002F974
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00031784 File Offset: 0x0002F984
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00031817 File Offset: 0x0002FA17
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

		// Token: 0x04000BFD RID: 3069
		[Nullable(2)]
		protected IDollComboCamera FbInstance;

		// Token: 0x04000BFE RID: 3070
		[Nullable(2)]
		protected IDollComboCamera_SetValue PocoInterface;

		// Token: 0x04000BFF RID: 3071
		private List<IDollComboCameraConfig> _ComboCamerasCache;

		// Token: 0x04000C00 RID: 3072
		private bool _ComboCamerasInited;
	}
}

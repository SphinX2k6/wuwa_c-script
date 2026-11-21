using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002005 RID: 8197
	public class ISceneUiSubtitleConfig
	{
		// Token: 0x0600AE11 RID: 44561 RVA: 0x00188A3C File Offset: 0x00186C3C
		private ISceneUiSubtitleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x00188A74 File Offset: 0x00186C74
		public static ISceneUiSubtitleConfig Create([Nullable(2)] ISceneUiSubtitleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x00188A87 File Offset: 0x00186C87
		public static ISceneUiSubtitleConfig CreateFromSetValue([Nullable(2)] ISceneUiSubtitleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x00188A9A File Offset: 0x00186C9A
		public ISceneUiSubtitleConfig_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleConfig_SetValue
			{
				Position = this.Position,
				LockFacingCamera = this.LockFacingCamera,
				IsOccluded = this.IsOccluded,
				LocalizationConfig = this.LocalizationConfig
			};
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x00188AD1 File Offset: 0x00186CD1
		// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x00188AF8 File Offset: 0x00186CF8
		public virtual ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Position;
				}
				ISceneUiSubtitleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Position;
			}
			set
			{
				this.GetOrCreatePoco().Position = value;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x00188B08 File Offset: 0x00186D08
		// (set) Token: 0x0600AE18 RID: 44568 RVA: 0x00188B42 File Offset: 0x00186D42
		public virtual bool? LockFacingCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockFacingCamera;
				}
				ISceneUiSubtitleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LockFacingCamera;
			}
			set
			{
				this.GetOrCreatePoco().LockFacingCamera = value;
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x00188B50 File Offset: 0x00186D50
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x00188B8A File Offset: 0x00186D8A
		public virtual bool? IsOccluded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOccluded;
				}
				ISceneUiSubtitleConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOccluded;
			}
			set
			{
				this.GetOrCreatePoco().IsOccluded = value;
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x00188B98 File Offset: 0x00186D98
		// (set) Token: 0x0600AE1C RID: 44572 RVA: 0x00188BF9 File Offset: 0x00186DF9
		[Nullable(2)]
		public virtual ISceneUiSubtitleLocalizationConfig LocalizationConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._LocalizationConfigInited)
				{
					return this._LocalizationConfigCache;
				}
				this._LocalizationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._LocalizationConfigCache = ISceneUiSubtitleLocalizationConfig.Create(this.FbInstance.LocalizationConfig);
				}
				else
				{
					ISceneUiSubtitleConfig_SetValue pocoInterface = this.PocoInterface;
					this._LocalizationConfigCache = ((pocoInterface != null) ? pocoInterface.LocalizationConfig : null);
				}
				return this._LocalizationConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().LocalizationConfig = value;
				this._LocalizationConfigInited = false;
			}
		}

		// Token: 0x040067CE RID: 26574
		[Nullable(2)]
		protected ISceneUiSubtitleConfig FbInstance;

		// Token: 0x040067CF RID: 26575
		[Nullable(2)]
		protected ISceneUiSubtitleConfig_SetValue PocoInterface;

		// Token: 0x040067D0 RID: 26576
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x040067D1 RID: 26577
		private bool _LocalizationConfigInited;
	}
}

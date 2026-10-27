using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEC RID: 7404
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig
	{
		// Token: 0x06009EE5 RID: 40677 RVA: 0x0016B340 File Offset: 0x00169540
		[NullableContext(1)]
		private IPhotographConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x0016B378 File Offset: 0x00169578
		[NullableContext(1)]
		public static IPhotographConfig Create([Nullable(2)] IPhotographConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x0016B38B File Offset: 0x0016958B
		[NullableContext(1)]
		public static IPhotographConfig CreateFromSetValue([Nullable(2)] IPhotographConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x0016B39E File Offset: 0x0016959E
		[NullableContext(1)]
		public IPhotographConfig_SetValue ToSetValue()
		{
			return new IPhotographConfig_SetValue
			{
				PhotoTargets = this.PhotoTargets,
				PlayerPerform = this.PlayerPerform,
				CameraParams = this.CameraParams
			};
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x0016B3C9 File Offset: 0x001695C9
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x0016B3F0 File Offset: 0x001695F0
		public virtual List<int> PhotoTargets
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhotoTargets;
				}
				IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PhotoTargets;
			}
			set
			{
				this.GetOrCreatePoco().PhotoTargets = value;
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x0016B400 File Offset: 0x00169600
		// (set) Token: 0x06009EEC RID: 40684 RVA: 0x0016B461 File Offset: 0x00169661
		public virtual IPhotographPlayerPerform PlayerPerform
		{
			get
			{
				if (this._PlayerPerformInited)
				{
					return this._PlayerPerformCache;
				}
				this._PlayerPerformInited = true;
				if (this.FbInstance != null)
				{
					this._PlayerPerformCache = IPhotographPlayerPerform.Create(this.FbInstance.PlayerPerform);
				}
				else
				{
					IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
					this._PlayerPerformCache = ((pocoInterface != null) ? pocoInterface.PlayerPerform : null);
				}
				return this._PlayerPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().PlayerPerform = value;
				this._PlayerPerformInited = false;
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x06009EED RID: 40685 RVA: 0x0016B478 File Offset: 0x00169678
		// (set) Token: 0x06009EEE RID: 40686 RVA: 0x0016B4D9 File Offset: 0x001696D9
		public virtual IPhotographCameraParams CameraParams
		{
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				if (this.FbInstance != null)
				{
					this._CameraParamsCache = IPhotographCameraParams.Create(this.FbInstance.CameraParams);
				}
				else
				{
					IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
					this._CameraParamsCache = ((pocoInterface != null) ? pocoInterface.CameraParams : null);
				}
				return this._CameraParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().CameraParams = value;
				this._CameraParamsInited = false;
			}
		}

		// Token: 0x04005FF8 RID: 24568
		protected IPhotographConfig FbInstance;

		// Token: 0x04005FF9 RID: 24569
		protected IPhotographConfig_SetValue PocoInterface;

		// Token: 0x04005FFA RID: 24570
		[Nullable(1)]
		private IPhotographPlayerPerform _PlayerPerformCache;

		// Token: 0x04005FFB RID: 24571
		private bool _PlayerPerformInited;

		// Token: 0x04005FFC RID: 24572
		[Nullable(1)]
		private IPhotographCameraParams _CameraParamsCache;

		// Token: 0x04005FFD RID: 24573
		private bool _CameraParamsInited;
	}
}

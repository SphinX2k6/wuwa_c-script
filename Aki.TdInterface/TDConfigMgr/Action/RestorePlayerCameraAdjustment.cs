using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CC RID: 9164
	[NullableContext(2)]
	[Nullable(0)]
	public class RestorePlayerCameraAdjustment : ActionParams
	{
		// Token: 0x0600C7BE RID: 51134 RVA: 0x001C9278 File Offset: 0x001C7478
		[NullableContext(0)]
		private RestorePlayerCameraAdjustment_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RestorePlayerCameraAdjustment 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RestorePlayerCameraAdjustment_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RestorePlayerCameraAdjustment_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x001C92B0 File Offset: 0x001C74B0
		[NullableContext(0)]
		public static RestorePlayerCameraAdjustment Create([Nullable(2)] RestorePlayerCameraAdjustment instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePlayerCameraAdjustment
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7C0 RID: 51136 RVA: 0x001C92C3 File Offset: 0x001C74C3
		[NullableContext(0)]
		public static RestorePlayerCameraAdjustment CreateFromSetValue([Nullable(2)] RestorePlayerCameraAdjustment_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RestorePlayerCameraAdjustment
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x001C92D6 File Offset: 0x001C74D6
		[NullableContext(0)]
		public RestorePlayerCameraAdjustment_SetValue ToSetValue()
		{
			return new RestorePlayerCameraAdjustment_SetValue
			{
				ResetFocus = this.ResetFocus,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600C7C2 RID: 51138 RVA: 0x001C92F8 File Offset: 0x001C74F8
		// (set) Token: 0x0600C7C3 RID: 51139 RVA: 0x001C9359 File Offset: 0x001C7559
		public virtual IResetFocusConfig ResetFocus
		{
			get
			{
				if (this._ResetFocusInited)
				{
					return this._ResetFocusCache;
				}
				this._ResetFocusInited = true;
				if (this.FbInstance != null)
				{
					this._ResetFocusCache = IResetFocusConfig.Create(this.FbInstance.ResetFocus);
				}
				else
				{
					RestorePlayerCameraAdjustment_SetValue pocoInterface = this.PocoInterface;
					this._ResetFocusCache = ((pocoInterface != null) ? pocoInterface.ResetFocus : null);
				}
				return this._ResetFocusCache;
			}
			set
			{
				this.GetOrCreatePoco().ResetFocus = value;
				this._ResetFocusInited = false;
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600C7C4 RID: 51140 RVA: 0x001C936E File Offset: 0x001C756E
		// (set) Token: 0x0600C7C5 RID: 51141 RVA: 0x001C9395 File Offset: 0x001C7595
		public virtual string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				RestorePlayerCameraAdjustment_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x0400769F RID: 30367
		protected new RestorePlayerCameraAdjustment FbInstance;

		// Token: 0x040076A0 RID: 30368
		protected RestorePlayerCameraAdjustment_SetValue PocoInterface;

		// Token: 0x040076A1 RID: 30369
		[Nullable(0)]
		private IResetFocusConfig _ResetFocusCache;

		// Token: 0x040076A2 RID: 30370
		private bool _ResetFocusInited;
	}
}

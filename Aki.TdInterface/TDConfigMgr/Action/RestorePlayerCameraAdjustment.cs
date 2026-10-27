using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216B RID: 8555
	[NullableContext(2)]
	[Nullable(0)]
	public class RestorePlayerCameraAdjustment : ActionParams
	{
		// Token: 0x0600BC30 RID: 48176 RVA: 0x001B20C4 File Offset: 0x001B02C4
		[NullableContext(1)]
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

		// Token: 0x0600BC31 RID: 48177 RVA: 0x001B20FC File Offset: 0x001B02FC
		[NullableContext(1)]
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

		// Token: 0x0600BC32 RID: 48178 RVA: 0x001B210F File Offset: 0x001B030F
		[NullableContext(1)]
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

		// Token: 0x0600BC33 RID: 48179 RVA: 0x001B2122 File Offset: 0x001B0322
		[NullableContext(1)]
		public RestorePlayerCameraAdjustment_SetValue ToSetValue()
		{
			return new RestorePlayerCameraAdjustment_SetValue
			{
				ResetFocus = this.ResetFocus,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600BC34 RID: 48180 RVA: 0x001B2144 File Offset: 0x001B0344
		// (set) Token: 0x0600BC35 RID: 48181 RVA: 0x001B21A5 File Offset: 0x001B03A5
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

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x001B21BA File Offset: 0x001B03BA
		// (set) Token: 0x0600BC37 RID: 48183 RVA: 0x001B21E1 File Offset: 0x001B03E1
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

		// Token: 0x0400706A RID: 28778
		protected new RestorePlayerCameraAdjustment FbInstance;

		// Token: 0x0400706B RID: 28779
		protected RestorePlayerCameraAdjustment_SetValue PocoInterface;

		// Token: 0x0400706C RID: 28780
		[Nullable(1)]
		private IResetFocusConfig _ResetFocusCache;

		// Token: 0x0400706D RID: 28781
		private bool _ResetFocusInited;
	}
}

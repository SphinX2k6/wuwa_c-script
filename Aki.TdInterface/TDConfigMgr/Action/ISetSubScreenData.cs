using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E46 RID: 7750
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetSubScreenData
	{
		// Token: 0x0600A5D1 RID: 42449 RVA: 0x001777B8 File Offset: 0x001759B8
		private ISetSubScreenData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetSubScreenData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetSubScreenData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetSubScreenData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x001777F0 File Offset: 0x001759F0
		public static ISetSubScreenData Create([Nullable(2)] ISetSubScreenData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSubScreenData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x00177803 File Offset: 0x00175A03
		public static ISetSubScreenData CreateFromSetValue([Nullable(2)] ISetSubScreenData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetSubScreenData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x00177816 File Offset: 0x00175A16
		public ISetSubScreenData_SetValue ToSetValue()
		{
			return new ISetSubScreenData_SetValue
			{
				TargetScreen = this.TargetScreen,
				TargetSubScreenConfig = this.TargetSubScreenConfig,
				Transition = this.Transition
			};
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600A5D5 RID: 42453 RVA: 0x00177841 File Offset: 0x00175A41
		// (set) Token: 0x0600A5D6 RID: 42454 RVA: 0x00177868 File Offset: 0x00175A68
		public virtual IScreenType TargetScreen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetScreen;
				}
				ISetSubScreenData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetScreen;
			}
			set
			{
				this.GetOrCreatePoco().TargetScreen = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600A5D7 RID: 42455 RVA: 0x00177878 File Offset: 0x00175A78
		// (set) Token: 0x0600A5D8 RID: 42456 RVA: 0x001778D9 File Offset: 0x00175AD9
		public virtual ISubScreenConfig TargetSubScreenConfig
		{
			get
			{
				if (this._TargetSubScreenConfigInited)
				{
					return this._TargetSubScreenConfigCache;
				}
				this._TargetSubScreenConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TargetSubScreenConfigCache = ISubScreenConfig.Create(this.FbInstance.TargetSubScreenConfig);
				}
				else
				{
					ISetSubScreenData_SetValue pocoInterface = this.PocoInterface;
					this._TargetSubScreenConfigCache = ((pocoInterface != null) ? pocoInterface.TargetSubScreenConfig : null);
				}
				return this._TargetSubScreenConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetSubScreenConfig = value;
				this._TargetSubScreenConfigInited = false;
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600A5D9 RID: 42457 RVA: 0x001778F0 File Offset: 0x00175AF0
		// (set) Token: 0x0600A5DA RID: 42458 RVA: 0x00177951 File Offset: 0x00175B51
		public virtual ISubScreenTransition Transition
		{
			get
			{
				if (this._TransitionInited)
				{
					return this._TransitionCache;
				}
				this._TransitionInited = true;
				if (this.FbInstance != null)
				{
					this._TransitionCache = ISubScreenTransition.Create(this.FbInstance.Transition);
				}
				else
				{
					ISetSubScreenData_SetValue pocoInterface = this.PocoInterface;
					this._TransitionCache = ((pocoInterface != null) ? pocoInterface.Transition : null);
				}
				return this._TransitionCache;
			}
			set
			{
				this.GetOrCreatePoco().Transition = value;
				this._TransitionInited = false;
			}
		}

		// Token: 0x0400631D RID: 25373
		[Nullable(2)]
		protected ISetSubScreenData FbInstance;

		// Token: 0x0400631E RID: 25374
		[Nullable(2)]
		protected ISetSubScreenData_SetValue PocoInterface;

		// Token: 0x0400631F RID: 25375
		private ISubScreenConfig _TargetSubScreenConfigCache;

		// Token: 0x04006320 RID: 25376
		private bool _TargetSubScreenConfigInited;

		// Token: 0x04006321 RID: 25377
		private ISubScreenTransition _TransitionCache;

		// Token: 0x04006322 RID: 25378
		private bool _TransitionInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200207B RID: 8315
	public class ISetSubScreenData
	{
		// Token: 0x0600B089 RID: 45193 RVA: 0x0018D4B8 File Offset: 0x0018B6B8
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

		// Token: 0x0600B08A RID: 45194 RVA: 0x0018D4F0 File Offset: 0x0018B6F0
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

		// Token: 0x0600B08B RID: 45195 RVA: 0x0018D503 File Offset: 0x0018B703
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

		// Token: 0x0600B08C RID: 45196 RVA: 0x0018D516 File Offset: 0x0018B716
		public ISetSubScreenData_SetValue ToSetValue()
		{
			return new ISetSubScreenData_SetValue
			{
				TargetScreen = this.TargetScreen,
				TargetSubScreenConfig = this.TargetSubScreenConfig,
				Transition = this.Transition
			};
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x0018D541 File Offset: 0x0018B741
		// (set) Token: 0x0600B08E RID: 45198 RVA: 0x0018D568 File Offset: 0x0018B768
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

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600B08F RID: 45199 RVA: 0x0018D578 File Offset: 0x0018B778
		// (set) Token: 0x0600B090 RID: 45200 RVA: 0x0018D5D9 File Offset: 0x0018B7D9
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

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x0018D5F0 File Offset: 0x0018B7F0
		// (set) Token: 0x0600B092 RID: 45202 RVA: 0x0018D651 File Offset: 0x0018B851
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

		// Token: 0x04006901 RID: 26881
		[Nullable(2)]
		protected ISetSubScreenData FbInstance;

		// Token: 0x04006902 RID: 26882
		[Nullable(2)]
		protected ISetSubScreenData_SetValue PocoInterface;

		// Token: 0x04006903 RID: 26883
		private ISubScreenConfig _TargetSubScreenConfigCache;

		// Token: 0x04006904 RID: 26884
		private bool _TargetSubScreenConfigInited;

		// Token: 0x04006905 RID: 26885
		private ISubScreenTransition _TransitionCache;

		// Token: 0x04006906 RID: 26886
		private bool _TransitionInited;
	}
}

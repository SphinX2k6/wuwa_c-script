using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200150D RID: 5389
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseFlowTemplate : ActionParams
	{
		// Token: 0x06007A78 RID: 31352 RVA: 0x00124664 File Offset: 0x00122864
		private CloseFlowTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CloseFlowTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CloseFlowTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CloseFlowTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x0012469C File Offset: 0x0012289C
		public static CloseFlowTemplate Create([Nullable(2)] CloseFlowTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseFlowTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x001246AF File Offset: 0x001228AF
		public static CloseFlowTemplate CreateFromSetValue([Nullable(2)] CloseFlowTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CloseFlowTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x001246C2 File Offset: 0x001228C2
		public CloseFlowTemplate_SetValue ToSetValue()
		{
			return new CloseFlowTemplate_SetValue
			{
				IsResetPosition = this.IsResetPosition,
				EndState = this.EndState,
				ExitFilmAspectRatio = this.ExitFilmAspectRatio
			};
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x001246ED File Offset: 0x001228ED
		// (set) Token: 0x06007A7D RID: 31357 RVA: 0x00124718 File Offset: 0x00122918
		public virtual bool IsResetPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetPosition;
				}
				return this.PocoInterface != null && this.PocoInterface.IsResetPosition;
			}
			set
			{
				this.GetOrCreatePoco().IsResetPosition = value;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x00124728 File Offset: 0x00122928
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x00124789 File Offset: 0x00122989
		[Nullable(2)]
		public virtual IEndState EndState
		{
			[NullableContext(2)]
			get
			{
				if (this._EndStateInited)
				{
					return this._EndStateCache;
				}
				this._EndStateInited = true;
				if (this.FbInstance != null)
				{
					this._EndStateCache = IEndState.Create(this.FbInstance.EndState);
				}
				else
				{
					CloseFlowTemplate_SetValue pocoInterface = this.PocoInterface;
					this._EndStateCache = ((pocoInterface != null) ? pocoInterface.EndState : null);
				}
				return this._EndStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EndState = value;
				this._EndStateInited = false;
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x001247A0 File Offset: 0x001229A0
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x001247DA File Offset: 0x001229DA
		public virtual bool? ExitFilmAspectRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitFilmAspectRatio;
				}
				CloseFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitFilmAspectRatio;
			}
			set
			{
				this.GetOrCreatePoco().ExitFilmAspectRatio = value;
			}
		}

		// Token: 0x040046F0 RID: 18160
		[Nullable(2)]
		protected new CloseFlowTemplate FbInstance;

		// Token: 0x040046F1 RID: 18161
		[Nullable(2)]
		protected CloseFlowTemplate_SetValue PocoInterface;

		// Token: 0x040046F2 RID: 18162
		private IEndState _EndStateCache;

		// Token: 0x040046F3 RID: 18163
		private bool _EndStateInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001668 RID: 5736
	public class CloseFlowTemplate : ActionParams
	{
		// Token: 0x0600814B RID: 33099 RVA: 0x00133344 File Offset: 0x00131544
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

		// Token: 0x0600814C RID: 33100 RVA: 0x0013337C File Offset: 0x0013157C
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

		// Token: 0x0600814D RID: 33101 RVA: 0x0013338F File Offset: 0x0013158F
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

		// Token: 0x0600814E RID: 33102 RVA: 0x001333A2 File Offset: 0x001315A2
		public CloseFlowTemplate_SetValue ToSetValue()
		{
			return new CloseFlowTemplate_SetValue
			{
				IsResetPosition = this.IsResetPosition,
				EndState = this.EndState,
				ExitFilmAspectRatio = this.ExitFilmAspectRatio
			};
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600814F RID: 33103 RVA: 0x001333CD File Offset: 0x001315CD
		// (set) Token: 0x06008150 RID: 33104 RVA: 0x001333F8 File Offset: 0x001315F8
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

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x06008151 RID: 33105 RVA: 0x00133408 File Offset: 0x00131608
		// (set) Token: 0x06008152 RID: 33106 RVA: 0x00133469 File Offset: 0x00131669
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

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06008153 RID: 33107 RVA: 0x00133480 File Offset: 0x00131680
		// (set) Token: 0x06008154 RID: 33108 RVA: 0x001334BA File Offset: 0x001316BA
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

		// Token: 0x04004A8F RID: 19087
		[Nullable(2)]
		protected new CloseFlowTemplate FbInstance;

		// Token: 0x04004A90 RID: 19088
		[Nullable(2)]
		protected CloseFlowTemplate_SetValue PocoInterface;

		// Token: 0x04004A91 RID: 19089
		private IEndState _EndStateCache;

		// Token: 0x04004A92 RID: 19090
		private bool _EndStateInited;
	}
}

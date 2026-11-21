using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002483 RID: 9347
	public class StartFlowTemplate : ActionParams
	{
		// Token: 0x0600CB5A RID: 52058 RVA: 0x001CFE30 File Offset: 0x001CE030
		private StartFlowTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StartFlowTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StartFlowTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StartFlowTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x001CFE68 File Offset: 0x001CE068
		public static StartFlowTemplate Create([Nullable(2)] StartFlowTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartFlowTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x001CFE7B File Offset: 0x001CE07B
		public static StartFlowTemplate CreateFromSetValue([Nullable(2)] StartFlowTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StartFlowTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x001CFE8E File Offset: 0x001CE08E
		public StartFlowTemplate_SetValue ToSetValue()
		{
			return new StartFlowTemplate_SetValue
			{
				TemplateMode = this.TemplateMode,
				TargetPos = this.TargetPos,
				ActorIdArray = this.ActorIdArray,
				TalkerIds = this.TalkerIds
			};
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600CB5E RID: 52062 RVA: 0x001CFEC8 File Offset: 0x001CE0C8
		// (set) Token: 0x0600CB5F RID: 52063 RVA: 0x001CFF29 File Offset: 0x001CE129
		public virtual IFlowTemplateMode TemplateMode
		{
			get
			{
				if (this._TemplateModeInited)
				{
					return this._TemplateModeCache;
				}
				this._TemplateModeInited = true;
				if (this.FbInstance != null)
				{
					this._TemplateModeCache = IFlowTemplateMode.Create(this.FbInstance.TemplateMode);
				}
				else
				{
					StartFlowTemplate_SetValue pocoInterface = this.PocoInterface;
					this._TemplateModeCache = ((pocoInterface != null) ? pocoInterface.TemplateMode : null);
				}
				return this._TemplateModeCache;
			}
			set
			{
				this.GetOrCreatePoco().TemplateMode = value;
				this._TemplateModeInited = false;
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x001CFF40 File Offset: 0x001CE140
		// (set) Token: 0x0600CB61 RID: 52065 RVA: 0x001CFFA1 File Offset: 0x001CE1A1
		public virtual PosA TargetPos
		{
			get
			{
				if (this._TargetPosInited)
				{
					return this._TargetPosCache;
				}
				this._TargetPosInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPosCache = PosA.Create(this.FbInstance.TargetPos);
				}
				else
				{
					StartFlowTemplate_SetValue pocoInterface = this.PocoInterface;
					this._TargetPosCache = ((pocoInterface != null) ? pocoInterface.TargetPos : null);
				}
				return this._TargetPosCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPos = value;
				this._TargetPosInited = false;
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600CB62 RID: 52066 RVA: 0x001CFFB6 File Offset: 0x001CE1B6
		// (set) Token: 0x0600CB63 RID: 52067 RVA: 0x001CFFDD File Offset: 0x001CE1DD
		public virtual List<int> ActorIdArray
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIdArray;
				}
				StartFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActorIdArray;
			}
			set
			{
				this.GetOrCreatePoco().ActorIdArray = value;
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600CB64 RID: 52068 RVA: 0x001CFFEB File Offset: 0x001CE1EB
		// (set) Token: 0x0600CB65 RID: 52069 RVA: 0x001D0012 File Offset: 0x001CE212
		[Nullable(2)]
		public virtual List<int> TalkerIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkerIds;
				}
				StartFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkerIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TalkerIds = value;
			}
		}

		// Token: 0x04007888 RID: 30856
		[Nullable(2)]
		protected new StartFlowTemplate FbInstance;

		// Token: 0x04007889 RID: 30857
		[Nullable(2)]
		protected StartFlowTemplate_SetValue PocoInterface;

		// Token: 0x0400788A RID: 30858
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x0400788B RID: 30859
		private bool _TemplateModeInited;

		// Token: 0x0400788C RID: 30860
		private PosA _TargetPosCache;

		// Token: 0x0400788D RID: 30861
		private bool _TargetPosInited;
	}
}

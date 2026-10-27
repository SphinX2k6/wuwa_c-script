using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002218 RID: 8728
	[NullableContext(1)]
	[Nullable(0)]
	public class StartFlowTemplate : ActionParams
	{
		// Token: 0x0600BF9C RID: 49052 RVA: 0x001B8764 File Offset: 0x001B6964
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

		// Token: 0x0600BF9D RID: 49053 RVA: 0x001B879C File Offset: 0x001B699C
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

		// Token: 0x0600BF9E RID: 49054 RVA: 0x001B87AF File Offset: 0x001B69AF
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

		// Token: 0x0600BF9F RID: 49055 RVA: 0x001B87C2 File Offset: 0x001B69C2
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

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600BFA0 RID: 49056 RVA: 0x001B87FC File Offset: 0x001B69FC
		// (set) Token: 0x0600BFA1 RID: 49057 RVA: 0x001B885D File Offset: 0x001B6A5D
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

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600BFA2 RID: 49058 RVA: 0x001B8874 File Offset: 0x001B6A74
		// (set) Token: 0x0600BFA3 RID: 49059 RVA: 0x001B88D5 File Offset: 0x001B6AD5
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

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600BFA4 RID: 49060 RVA: 0x001B88EA File Offset: 0x001B6AEA
		// (set) Token: 0x0600BFA5 RID: 49061 RVA: 0x001B8911 File Offset: 0x001B6B11
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

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600BFA6 RID: 49062 RVA: 0x001B891F File Offset: 0x001B6B1F
		// (set) Token: 0x0600BFA7 RID: 49063 RVA: 0x001B8946 File Offset: 0x001B6B46
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

		// Token: 0x0400723E RID: 29246
		[Nullable(2)]
		protected new StartFlowTemplate FbInstance;

		// Token: 0x0400723F RID: 29247
		[Nullable(2)]
		protected StartFlowTemplate_SetValue PocoInterface;

		// Token: 0x04007240 RID: 29248
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x04007241 RID: 29249
		private bool _TemplateModeInited;

		// Token: 0x04007242 RID: 29250
		private PosA _TargetPosCache;

		// Token: 0x04007243 RID: 29251
		private bool _TargetPosInited;
	}
}

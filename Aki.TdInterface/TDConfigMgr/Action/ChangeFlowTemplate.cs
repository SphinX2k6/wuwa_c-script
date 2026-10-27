using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D4 RID: 5332
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate : ActionParams
	{
		// Token: 0x06007960 RID: 31072 RVA: 0x00122870 File Offset: 0x00120A70
		[NullableContext(1)]
		private ChangeFlowTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeFlowTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeFlowTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeFlowTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x001228A8 File Offset: 0x00120AA8
		[NullableContext(1)]
		public static ChangeFlowTemplate Create([Nullable(2)] ChangeFlowTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeFlowTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x001228BB File Offset: 0x00120ABB
		[NullableContext(1)]
		public static ChangeFlowTemplate CreateFromSetValue([Nullable(2)] ChangeFlowTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeFlowTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x001228CE File Offset: 0x00120ACE
		[NullableContext(1)]
		public ChangeFlowTemplate_SetValue ToSetValue()
		{
			return new ChangeFlowTemplate_SetValue
			{
				TemplateMode = this.TemplateMode,
				TargetPos = this.TargetPos,
				ActorIdArray = this.ActorIdArray,
				TalkerIds = this.TalkerIds
			};
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x06007964 RID: 31076 RVA: 0x00122908 File Offset: 0x00120B08
		// (set) Token: 0x06007965 RID: 31077 RVA: 0x00122969 File Offset: 0x00120B69
		[Nullable(1)]
		public virtual IFlowTemplateMode TemplateMode
		{
			[NullableContext(1)]
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
					ChangeFlowTemplate_SetValue pocoInterface = this.PocoInterface;
					this._TemplateModeCache = ((pocoInterface != null) ? pocoInterface.TemplateMode : null);
				}
				return this._TemplateModeCache;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().TemplateMode = value;
				this._TemplateModeInited = false;
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x06007966 RID: 31078 RVA: 0x00122980 File Offset: 0x00120B80
		// (set) Token: 0x06007967 RID: 31079 RVA: 0x001229E1 File Offset: 0x00120BE1
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
					ChangeFlowTemplate_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x06007968 RID: 31080 RVA: 0x001229F6 File Offset: 0x00120BF6
		// (set) Token: 0x06007969 RID: 31081 RVA: 0x00122A1D File Offset: 0x00120C1D
		public virtual List<int> ActorIdArray
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIdArray;
				}
				ChangeFlowTemplate_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x00122A2B File Offset: 0x00120C2B
		// (set) Token: 0x0600796B RID: 31083 RVA: 0x00122A52 File Offset: 0x00120C52
		public virtual List<int> TalkerIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkerIds;
				}
				ChangeFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TalkerIds;
			}
			set
			{
				this.GetOrCreatePoco().TalkerIds = value;
			}
		}

		// Token: 0x0400466F RID: 18031
		protected new ChangeFlowTemplate FbInstance;

		// Token: 0x04004670 RID: 18032
		protected ChangeFlowTemplate_SetValue PocoInterface;

		// Token: 0x04004671 RID: 18033
		[Nullable(1)]
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x04004672 RID: 18034
		private bool _TemplateModeInited;

		// Token: 0x04004673 RID: 18035
		[Nullable(1)]
		private PosA _TargetPosCache;

		// Token: 0x04004674 RID: 18036
		private bool _TargetPosInited;
	}
}

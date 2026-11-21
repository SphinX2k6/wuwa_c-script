using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200162D RID: 5677
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate : ActionParams
	{
		// Token: 0x0600802D RID: 32813 RVA: 0x001314BC File Offset: 0x0012F6BC
		[NullableContext(0)]
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

		// Token: 0x0600802E RID: 32814 RVA: 0x001314F4 File Offset: 0x0012F6F4
		[NullableContext(0)]
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

		// Token: 0x0600802F RID: 32815 RVA: 0x00131507 File Offset: 0x0012F707
		[NullableContext(0)]
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

		// Token: 0x06008030 RID: 32816 RVA: 0x0013151A File Offset: 0x0012F71A
		[NullableContext(0)]
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

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x06008031 RID: 32817 RVA: 0x00131554 File Offset: 0x0012F754
		// (set) Token: 0x06008032 RID: 32818 RVA: 0x001315B5 File Offset: 0x0012F7B5
		[Nullable(0)]
		public virtual IFlowTemplateMode TemplateMode
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().TemplateMode = value;
				this._TemplateModeInited = false;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06008033 RID: 32819 RVA: 0x001315CC File Offset: 0x0012F7CC
		// (set) Token: 0x06008034 RID: 32820 RVA: 0x0013162D File Offset: 0x0012F82D
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

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x00131642 File Offset: 0x0012F842
		// (set) Token: 0x06008036 RID: 32822 RVA: 0x00131669 File Offset: 0x0012F869
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

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x00131677 File Offset: 0x0012F877
		// (set) Token: 0x06008038 RID: 32824 RVA: 0x0013169E File Offset: 0x0012F89E
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

		// Token: 0x04004A0A RID: 18954
		protected new ChangeFlowTemplate FbInstance;

		// Token: 0x04004A0B RID: 18955
		protected ChangeFlowTemplate_SetValue PocoInterface;

		// Token: 0x04004A0C RID: 18956
		[Nullable(0)]
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x04004A0D RID: 18957
		private bool _TemplateModeInited;

		// Token: 0x04004A0E RID: 18958
		[Nullable(0)]
		private PosA _TargetPosCache;

		// Token: 0x04004A0F RID: 18959
		private bool _TargetPosInited;
	}
}

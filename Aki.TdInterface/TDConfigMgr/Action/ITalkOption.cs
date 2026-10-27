using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F68 RID: 8040
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption
	{
		// Token: 0x0600B0DC RID: 45276 RVA: 0x0019CFD4 File Offset: 0x0019B1D4
		[NullableContext(1)]
		private ITalkOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x0019D00C File Offset: 0x0019B20C
		[NullableContext(1)]
		public static ITalkOption Create([Nullable(2)] ITalkOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x0019D01F File Offset: 0x0019B21F
		[NullableContext(1)]
		public static ITalkOption CreateFromSetValue([Nullable(2)] ITalkOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x0019D034 File Offset: 0x0019B234
		[NullableContext(1)]
		public ITalkOption_SetValue ToSetValue()
		{
			return new ITalkOption_SetValue
			{
				TidTalkOption = this.TidTalkOption,
				TextId = this.TextId,
				PlotLineId = this.PlotLineId,
				PlotLineKey = this.PlotLineKey,
				Icon = this.Icon,
				ChangeIcon = this.ChangeIcon,
				ReadMarkEnabled = this.ReadMarkEnabled,
				Actions = this.Actions,
				OptionStyle = this.OptionStyle,
				PreCondition = this.PreCondition,
				_folded = this._Folded,
				_editFlag = this._EditFlag,
				OptionLockTip = this.OptionLockTip,
				TypeParams = this.TypeParams,
				HiddenOption = this.HiddenOption,
				EdOptionComment = this.EdOptionComment
			};
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600B0E0 RID: 45280 RVA: 0x0019D106 File Offset: 0x0019B306
		// (set) Token: 0x0600B0E1 RID: 45281 RVA: 0x0019D12D File Offset: 0x0019B32D
		public virtual string TidTalkOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTalkOption;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTalkOption;
			}
			set
			{
				this.GetOrCreatePoco().TidTalkOption = value;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600B0E2 RID: 45282 RVA: 0x0019D13C File Offset: 0x0019B33C
		// (set) Token: 0x0600B0E3 RID: 45283 RVA: 0x0019D176 File Offset: 0x0019B376
		public virtual int? TextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextId;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextId;
			}
			set
			{
				this.GetOrCreatePoco().TextId = value;
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600B0E4 RID: 45284 RVA: 0x0019D184 File Offset: 0x0019B384
		// (set) Token: 0x0600B0E5 RID: 45285 RVA: 0x0019D1BE File Offset: 0x0019B3BE
		public virtual int? PlotLineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineId;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineId;
			}
			set
			{
				this.GetOrCreatePoco().PlotLineId = value;
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600B0E6 RID: 45286 RVA: 0x0019D1CC File Offset: 0x0019B3CC
		// (set) Token: 0x0600B0E7 RID: 45287 RVA: 0x0019D1F3 File Offset: 0x0019B3F3
		public virtual string PlotLineKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineKey;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineKey;
			}
			set
			{
				this.GetOrCreatePoco().PlotLineKey = value;
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600B0E8 RID: 45288 RVA: 0x0019D204 File Offset: 0x0019B404
		// (set) Token: 0x0600B0E9 RID: 45289 RVA: 0x0019D23E File Offset: 0x0019B43E
		public virtual int? Icon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Icon;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Icon;
			}
			set
			{
				this.GetOrCreatePoco().Icon = value;
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x0019D24C File Offset: 0x0019B44C
		// (set) Token: 0x0600B0EB RID: 45291 RVA: 0x0019D2AD File Offset: 0x0019B4AD
		public virtual IChangeIcon ChangeIcon
		{
			get
			{
				if (this._ChangeIconInited)
				{
					return this._ChangeIconCache;
				}
				this._ChangeIconInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeIconCache = IChangeIcon.Create(this.FbInstance.ChangeIcon);
				}
				else
				{
					ITalkOption_SetValue pocoInterface = this.PocoInterface;
					this._ChangeIconCache = ((pocoInterface != null) ? pocoInterface.ChangeIcon : null);
				}
				return this._ChangeIconCache;
			}
			set
			{
				this.GetOrCreatePoco().ChangeIcon = value;
				this._ChangeIconInited = false;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600B0EC RID: 45292 RVA: 0x0019D2C4 File Offset: 0x0019B4C4
		// (set) Token: 0x0600B0ED RID: 45293 RVA: 0x0019D2FE File Offset: 0x0019B4FE
		public virtual bool? ReadMarkEnabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReadMarkEnabled;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReadMarkEnabled;
			}
			set
			{
				this.GetOrCreatePoco().ReadMarkEnabled = value;
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600B0EE RID: 45294 RVA: 0x0019D30C File Offset: 0x0019B50C
		// (set) Token: 0x0600B0EF RID: 45295 RVA: 0x0019D39F File Offset: 0x0019B59F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					ITalkOption_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x0019D3B4 File Offset: 0x0019B5B4
		// (set) Token: 0x0600B0F1 RID: 45297 RVA: 0x0019D3EE File Offset: 0x0019B5EE
		public virtual ETalkOptionStyle? OptionStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionStyle;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionStyle;
			}
			set
			{
				this.GetOrCreatePoco().OptionStyle = value;
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600B0F2 RID: 45298 RVA: 0x0019D3FC File Offset: 0x0019B5FC
		// (set) Token: 0x0600B0F3 RID: 45299 RVA: 0x0019D423 File Offset: 0x0019B623
		public virtual ITalkOptionPreConditionBase PreCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreCondition;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PreCondition;
			}
			set
			{
				this.GetOrCreatePoco().PreCondition = value;
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x0019D434 File Offset: 0x0019B634
		// (set) Token: 0x0600B0F5 RID: 45301 RVA: 0x0019D46E File Offset: 0x0019B66E
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._folded;
			}
			set
			{
				this.GetOrCreatePoco()._folded = value;
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600B0F6 RID: 45302 RVA: 0x0019D47C File Offset: 0x0019B67C
		// (set) Token: 0x0600B0F7 RID: 45303 RVA: 0x0019D4B6 File Offset: 0x0019B6B6
		public virtual EEditFlag? _EditFlag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._EditFlag;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._editFlag;
			}
			set
			{
				this.GetOrCreatePoco()._editFlag = value;
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600B0F8 RID: 45304 RVA: 0x0019D4C4 File Offset: 0x0019B6C4
		// (set) Token: 0x0600B0F9 RID: 45305 RVA: 0x0019D525 File Offset: 0x0019B725
		public virtual IOptionLockTip OptionLockTip
		{
			get
			{
				if (this._OptionLockTipInited)
				{
					return this._OptionLockTipCache;
				}
				this._OptionLockTipInited = true;
				if (this.FbInstance != null)
				{
					this._OptionLockTipCache = IOptionLockTip.Create(this.FbInstance.OptionLockTip);
				}
				else
				{
					ITalkOption_SetValue pocoInterface = this.PocoInterface;
					this._OptionLockTipCache = ((pocoInterface != null) ? pocoInterface.OptionLockTip : null);
				}
				return this._OptionLockTipCache;
			}
			set
			{
				this.GetOrCreatePoco().OptionLockTip = value;
				this._OptionLockTipInited = false;
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x0019D53A File Offset: 0x0019B73A
		// (set) Token: 0x0600B0FB RID: 45307 RVA: 0x0019D561 File Offset: 0x0019B761
		public virtual ITalkOptionParamType TypeParams
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TypeParams;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TypeParams;
			}
			set
			{
				this.GetOrCreatePoco().TypeParams = value;
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600B0FC RID: 45308 RVA: 0x0019D570 File Offset: 0x0019B770
		// (set) Token: 0x0600B0FD RID: 45309 RVA: 0x0019D5AA File Offset: 0x0019B7AA
		public virtual bool? HiddenOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HiddenOption;
				}
				ITalkOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HiddenOption;
			}
			set
			{
				this.GetOrCreatePoco().HiddenOption = value;
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600B0FE RID: 45310 RVA: 0x0019D5B8 File Offset: 0x0019B7B8
		// (set) Token: 0x0600B0FF RID: 45311 RVA: 0x0019D5CF File Offset: 0x0019B7CF
		public virtual string EdOptionComment
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdOptionComment;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdOptionComment = value;
			}
		}

		// Token: 0x04006B07 RID: 27399
		protected ITalkOption FbInstance;

		// Token: 0x04006B08 RID: 27400
		protected ITalkOption_SetValue PocoInterface;

		// Token: 0x04006B09 RID: 27401
		[Nullable(1)]
		private IChangeIcon _ChangeIconCache;

		// Token: 0x04006B0A RID: 27402
		private bool _ChangeIconInited;

		// Token: 0x04006B0B RID: 27403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006B0C RID: 27404
		private bool _ActionsInited;

		// Token: 0x04006B0D RID: 27405
		[Nullable(1)]
		private IOptionLockTip _OptionLockTipCache;

		// Token: 0x04006B0E RID: 27406
		private bool _OptionLockTipInited;
	}
}

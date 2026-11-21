using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A3 RID: 8611
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption
	{
		// Token: 0x0600BBB6 RID: 48054 RVA: 0x001B2F28 File Offset: 0x001B1128
		[NullableContext(0)]
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

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x001B2F60 File Offset: 0x001B1160
		[NullableContext(0)]
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

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x001B2F73 File Offset: 0x001B1173
		[NullableContext(0)]
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

		// Token: 0x0600BBB9 RID: 48057 RVA: 0x001B2F88 File Offset: 0x001B1188
		[NullableContext(0)]
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

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x001B305A File Offset: 0x001B125A
		// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x001B3081 File Offset: 0x001B1281
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

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x001B3090 File Offset: 0x001B1290
		// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x001B30CA File Offset: 0x001B12CA
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

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x001B30D8 File Offset: 0x001B12D8
		// (set) Token: 0x0600BBBF RID: 48063 RVA: 0x001B3112 File Offset: 0x001B1312
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

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600BBC0 RID: 48064 RVA: 0x001B3120 File Offset: 0x001B1320
		// (set) Token: 0x0600BBC1 RID: 48065 RVA: 0x001B3147 File Offset: 0x001B1347
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

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x001B3158 File Offset: 0x001B1358
		// (set) Token: 0x0600BBC3 RID: 48067 RVA: 0x001B3192 File Offset: 0x001B1392
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

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x001B31A0 File Offset: 0x001B13A0
		// (set) Token: 0x0600BBC5 RID: 48069 RVA: 0x001B3201 File Offset: 0x001B1401
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

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x001B3218 File Offset: 0x001B1418
		// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x001B3252 File Offset: 0x001B1452
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

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x001B3260 File Offset: 0x001B1460
		// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x001B32F3 File Offset: 0x001B14F3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x001B3308 File Offset: 0x001B1508
		// (set) Token: 0x0600BBCB RID: 48075 RVA: 0x001B3342 File Offset: 0x001B1542
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

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x001B3350 File Offset: 0x001B1550
		// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x001B3377 File Offset: 0x001B1577
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

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x001B3388 File Offset: 0x001B1588
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x001B33C2 File Offset: 0x001B15C2
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

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600BBD0 RID: 48080 RVA: 0x001B33D0 File Offset: 0x001B15D0
		// (set) Token: 0x0600BBD1 RID: 48081 RVA: 0x001B340A File Offset: 0x001B160A
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

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600BBD2 RID: 48082 RVA: 0x001B3418 File Offset: 0x001B1618
		// (set) Token: 0x0600BBD3 RID: 48083 RVA: 0x001B3479 File Offset: 0x001B1679
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

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x001B348E File Offset: 0x001B168E
		// (set) Token: 0x0600BBD5 RID: 48085 RVA: 0x001B34B5 File Offset: 0x001B16B5
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

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600BBD6 RID: 48086 RVA: 0x001B34C4 File Offset: 0x001B16C4
		// (set) Token: 0x0600BBD7 RID: 48087 RVA: 0x001B34FE File Offset: 0x001B16FE
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

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x001B350C File Offset: 0x001B170C
		// (set) Token: 0x0600BBD9 RID: 48089 RVA: 0x001B3523 File Offset: 0x001B1723
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

		// Token: 0x040070EF RID: 28911
		protected ITalkOption FbInstance;

		// Token: 0x040070F0 RID: 28912
		protected ITalkOption_SetValue PocoInterface;

		// Token: 0x040070F1 RID: 28913
		[Nullable(0)]
		private IChangeIcon _ChangeIconCache;

		// Token: 0x040070F2 RID: 28914
		private bool _ChangeIconInited;

		// Token: 0x040070F3 RID: 28915
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040070F4 RID: 28916
		private bool _ActionsInited;

		// Token: 0x040070F5 RID: 28917
		[Nullable(0)]
		private IOptionLockTip _OptionLockTipCache;

		// Token: 0x040070F6 RID: 28918
		private bool _OptionLockTipInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C1 RID: 10177
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption
	{
		// Token: 0x0600E12E RID: 57646 RVA: 0x00211ACA File Offset: 0x0020FCCA
		[NullableContext(0)]
		public static ITalkOption Create(ITalkOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600E12F RID: 57647 RVA: 0x00211AE9 File Offset: 0x0020FCE9
		public virtual string TidTalkOption
		{
			get
			{
				return this.Instance.TidTalkOption;
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600E130 RID: 57648 RVA: 0x00211AF8 File Offset: 0x0020FCF8
		public virtual int? TextId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TextId);
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600E131 RID: 57649 RVA: 0x00211B30 File Offset: 0x0020FD30
		public virtual int? PlotLineId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PlotLineId);
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600E132 RID: 57650 RVA: 0x00211B66 File Offset: 0x0020FD66
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x00211B74 File Offset: 0x0020FD74
		public virtual int? Icon
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Icon);
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600E134 RID: 57652 RVA: 0x00211BAA File Offset: 0x0020FDAA
		public virtual IChangeIcon ChangeIcon
		{
			get
			{
				if (this._ChangeIconInited)
				{
					return this._ChangeIconCache;
				}
				this._ChangeIconInited = true;
				this._ChangeIconCache = IChangeIcon.Create(this.Instance.ChangeIcon);
				return this._ChangeIconCache;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600E135 RID: 57653 RVA: 0x00211BE0 File Offset: 0x0020FDE0
		public virtual bool? ReadMarkEnabled
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ReadMarkEnabled);
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600E136 RID: 57654 RVA: 0x00211C18 File Offset: 0x0020FE18
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
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600E137 RID: 57655 RVA: 0x00211C94 File Offset: 0x0020FE94
		public virtual ETalkOptionStyle? OptionStyle
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new ETalkOptionStyle?((ETalkOptionStyle)this.Instance.OptionStyle);
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600E138 RID: 57656 RVA: 0x00211CCB File Offset: 0x0020FECB
		[Nullable(0)]
		public virtual ITalkOptionPreConditionBase PreCondition
		{
			[NullableContext(0)]
			get
			{
				if (this._PreConditionInited)
				{
					return this._PreConditionCache;
				}
				this._PreConditionInited = true;
				this._PreConditionCache = ActionReadHelper.ReadITalkOption_PreCondition(this.Instance);
				return this._PreConditionCache;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600E139 RID: 57657 RVA: 0x00211CFC File Offset: 0x0020FEFC
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600E13A RID: 57658 RVA: 0x00211D34 File Offset: 0x0020FF34
		public virtual EEditFlag? _EditFlag
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new EEditFlag?((EEditFlag)this.Instance._EditFlag);
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600E13B RID: 57659 RVA: 0x00211D6E File Offset: 0x0020FF6E
		public virtual IOptionLockTip OptionLockTip
		{
			get
			{
				if (this._OptionLockTipInited)
				{
					return this._OptionLockTipCache;
				}
				this._OptionLockTipInited = true;
				this._OptionLockTipCache = IOptionLockTip.Create(this.Instance.OptionLockTip);
				return this._OptionLockTipCache;
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x00211DA2 File Offset: 0x0020FFA2
		[Nullable(0)]
		public virtual ITalkOptionParamType TypeParams
		{
			[NullableContext(0)]
			get
			{
				if (this._TypeParamsInited)
				{
					return this._TypeParamsCache;
				}
				this._TypeParamsInited = true;
				this._TypeParamsCache = ActionReadHelper.ReadITalkOption_TypeParams(this.Instance);
				return this._TypeParamsCache;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600E13D RID: 57661 RVA: 0x00211DD4 File Offset: 0x0020FFD4
		public virtual bool? HiddenOption
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HiddenOption);
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600E13E RID: 57662 RVA: 0x00211E0E File Offset: 0x0021000E
		public virtual string EdOptionComment
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007A65 RID: 31333
		private ITalkOption Instance;

		// Token: 0x04007A66 RID: 31334
		private IChangeIcon _ChangeIconCache;

		// Token: 0x04007A67 RID: 31335
		private bool _ChangeIconInited;

		// Token: 0x04007A68 RID: 31336
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007A69 RID: 31337
		private bool _ActionsInited;

		// Token: 0x04007A6A RID: 31338
		[Nullable(0)]
		private ITalkOptionPreConditionBase _PreConditionCache;

		// Token: 0x04007A6B RID: 31339
		private bool _PreConditionInited;

		// Token: 0x04007A6C RID: 31340
		private IOptionLockTip _OptionLockTipCache;

		// Token: 0x04007A6D RID: 31341
		private bool _OptionLockTipInited;

		// Token: 0x04007A6E RID: 31342
		[Nullable(0)]
		private ITalkOptionParamType _TypeParamsCache;

		// Token: 0x04007A6F RID: 31343
		private bool _TypeParamsInited;
	}
}

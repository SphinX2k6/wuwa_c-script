using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251A RID: 9498
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption
	{
		// Token: 0x0600D3CE RID: 54222 RVA: 0x001F606A File Offset: 0x001F426A
		[NullableContext(1)]
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

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x001F6089 File Offset: 0x001F4289
		public virtual string TidTalkOption
		{
			get
			{
				return this.Instance.TidTalkOption;
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600D3D0 RID: 54224 RVA: 0x001F6098 File Offset: 0x001F4298
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

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x001F60D0 File Offset: 0x001F42D0
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

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600D3D2 RID: 54226 RVA: 0x001F6106 File Offset: 0x001F4306
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600D3D3 RID: 54227 RVA: 0x001F6114 File Offset: 0x001F4314
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

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600D3D4 RID: 54228 RVA: 0x001F614A File Offset: 0x001F434A
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

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600D3D5 RID: 54229 RVA: 0x001F6180 File Offset: 0x001F4380
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

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600D3D6 RID: 54230 RVA: 0x001F61B8 File Offset: 0x001F43B8
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

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600D3D7 RID: 54231 RVA: 0x001F6234 File Offset: 0x001F4434
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

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0600D3D8 RID: 54232 RVA: 0x001F626B File Offset: 0x001F446B
		[Nullable(1)]
		public virtual ITalkOptionPreConditionBase PreCondition
		{
			[NullableContext(1)]
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

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0600D3D9 RID: 54233 RVA: 0x001F629C File Offset: 0x001F449C
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

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600D3DA RID: 54234 RVA: 0x001F62D4 File Offset: 0x001F44D4
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

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x001F630E File Offset: 0x001F450E
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

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600D3DC RID: 54236 RVA: 0x001F6342 File Offset: 0x001F4542
		[Nullable(1)]
		public virtual ITalkOptionParamType TypeParams
		{
			[NullableContext(1)]
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

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600D3DD RID: 54237 RVA: 0x001F6374 File Offset: 0x001F4574
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

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600D3DE RID: 54238 RVA: 0x001F63AE File Offset: 0x001F45AE
		public virtual string EdOptionComment
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007410 RID: 29712
		private ITalkOption Instance;

		// Token: 0x04007411 RID: 29713
		private IChangeIcon _ChangeIconCache;

		// Token: 0x04007412 RID: 29714
		private bool _ChangeIconInited;

		// Token: 0x04007413 RID: 29715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007414 RID: 29716
		private bool _ActionsInited;

		// Token: 0x04007415 RID: 29717
		[Nullable(1)]
		private ITalkOptionPreConditionBase _PreConditionCache;

		// Token: 0x04007416 RID: 29718
		private bool _PreConditionInited;

		// Token: 0x04007417 RID: 29719
		private IOptionLockTip _OptionLockTipCache;

		// Token: 0x04007418 RID: 29720
		private bool _OptionLockTipInited;

		// Token: 0x04007419 RID: 29721
		[Nullable(1)]
		private ITalkOptionParamType _TypeParamsCache;

		// Token: 0x0400741A RID: 29722
		private bool _TypeParamsInited;
	}
}

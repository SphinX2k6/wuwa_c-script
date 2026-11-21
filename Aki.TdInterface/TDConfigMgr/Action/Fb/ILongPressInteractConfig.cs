using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D9 RID: 10457
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig
	{
		// Token: 0x0600E8B6 RID: 59574 RVA: 0x00226115 File Offset: 0x00224315
		[NullableContext(0)]
		public static ILongPressInteractConfig Create(ILongPressInteractConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x0600E8B7 RID: 59575 RVA: 0x00226134 File Offset: 0x00224334
		public virtual float PressDuration
		{
			get
			{
				return this.Instance.PressDuration;
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x0600E8B8 RID: 59576 RVA: 0x00226141 File Offset: 0x00224341
		public virtual ILongPressEffectConfig PressEffect
		{
			get
			{
				if (this._PressEffectInited)
				{
					return this._PressEffectCache;
				}
				this._PressEffectInited = true;
				this._PressEffectCache = ILongPressEffectConfig.Create(this.Instance.PressEffect);
				return this._PressEffectCache;
			}
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x0600E8B9 RID: 59577 RVA: 0x00226175 File Offset: 0x00224375
		[Nullable(0)]
		public virtual ILongPressInteractStyleConfig Style
		{
			[NullableContext(0)]
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ActionReadHelper.ReadILongPressInteractConfig_Style(this.Instance);
				return this._StyleCache;
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x0600E8BA RID: 59578 RVA: 0x002261A4 File Offset: 0x002243A4
		public virtual bool? ResetFromCurrentProgress
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ResetFromCurrentProgress);
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x0600E8BB RID: 59579 RVA: 0x002261DA File Offset: 0x002243DA
		public virtual ILongPressButtonActionMapping LongPressButtonActionMapping
		{
			get
			{
				if (this._LongPressButtonActionMappingInited)
				{
					return this._LongPressButtonActionMappingCache;
				}
				this._LongPressButtonActionMappingInited = true;
				this._LongPressButtonActionMappingCache = ILongPressButtonActionMapping.Create(this.Instance.LongPressButtonActionMapping);
				return this._LongPressButtonActionMappingCache;
			}
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x0600E8BC RID: 59580 RVA: 0x00226210 File Offset: 0x00224410
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> LongPressStartActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LongPressStartActionsInited)
				{
					return this._LongPressStartActionsCache;
				}
				this._LongPressStartActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int longPressStartActionsLength = this.Instance.LongPressStartActionsLength;
				this._LongPressStartActionsCache = new List<ActionInfo>(longPressStartActionsLength);
				for (int i = 0; i < longPressStartActionsLength; i++)
				{
					this._LongPressStartActionsCache.Add(ActionInfo.Create(this.Instance.LongPressStartActions(i)));
				}
				return this._LongPressStartActionsCache;
			}
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x0600E8BD RID: 59581 RVA: 0x0022628C File Offset: 0x0022448C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> LongPressInterruptedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LongPressInterruptedActionsInited)
				{
					return this._LongPressInterruptedActionsCache;
				}
				this._LongPressInterruptedActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int longPressInterruptedActionsLength = this.Instance.LongPressInterruptedActionsLength;
				this._LongPressInterruptedActionsCache = new List<ActionInfo>(longPressInterruptedActionsLength);
				for (int i = 0; i < longPressInterruptedActionsLength; i++)
				{
					this._LongPressInterruptedActionsCache.Add(ActionInfo.Create(this.Instance.LongPressInterruptedActions(i)));
				}
				return this._LongPressInterruptedActionsCache;
			}
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x0600E8BE RID: 59582 RVA: 0x00226308 File Offset: 0x00224508
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> LongPressSuccessActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LongPressSuccessActionsInited)
				{
					return this._LongPressSuccessActionsCache;
				}
				this._LongPressSuccessActionsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int longPressSuccessActionsLength = this.Instance.LongPressSuccessActionsLength;
				this._LongPressSuccessActionsCache = new List<ActionInfo>(longPressSuccessActionsLength);
				for (int i = 0; i < longPressSuccessActionsLength; i++)
				{
					this._LongPressSuccessActionsCache.Add(ActionInfo.Create(this.Instance.LongPressSuccessActions(i)));
				}
				return this._LongPressSuccessActionsCache;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x0600E8BF RID: 59583 RVA: 0x00226384 File Offset: 0x00224584
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ILongPressProgressAction> LongPressProgressActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LongPressProgressActionsInited)
				{
					return this._LongPressProgressActionsCache;
				}
				this._LongPressProgressActionsInited = true;
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int longPressProgressActionsLength = this.Instance.LongPressProgressActionsLength;
				this._LongPressProgressActionsCache = new List<ILongPressProgressAction>(longPressProgressActionsLength);
				for (int i = 0; i < longPressProgressActionsLength; i++)
				{
					this._LongPressProgressActionsCache.Add(ILongPressProgressAction.Create(this.Instance.LongPressProgressActions(i)));
				}
				return this._LongPressProgressActionsCache;
			}
		}

		// Token: 0x0400802B RID: 32811
		private ILongPressInteractConfig Instance;

		// Token: 0x0400802C RID: 32812
		private ILongPressEffectConfig _PressEffectCache;

		// Token: 0x0400802D RID: 32813
		private bool _PressEffectInited;

		// Token: 0x0400802E RID: 32814
		[Nullable(0)]
		private ILongPressInteractStyleConfig _StyleCache;

		// Token: 0x0400802F RID: 32815
		private bool _StyleInited;

		// Token: 0x04008030 RID: 32816
		private ILongPressButtonActionMapping _LongPressButtonActionMappingCache;

		// Token: 0x04008031 RID: 32817
		private bool _LongPressButtonActionMappingInited;

		// Token: 0x04008032 RID: 32818
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressStartActionsCache;

		// Token: 0x04008033 RID: 32819
		private bool _LongPressStartActionsInited;

		// Token: 0x04008034 RID: 32820
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressInterruptedActionsCache;

		// Token: 0x04008035 RID: 32821
		private bool _LongPressInterruptedActionsInited;

		// Token: 0x04008036 RID: 32822
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressSuccessActionsCache;

		// Token: 0x04008037 RID: 32823
		private bool _LongPressSuccessActionsInited;

		// Token: 0x04008038 RID: 32824
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ILongPressProgressAction> _LongPressProgressActionsCache;

		// Token: 0x04008039 RID: 32825
		private bool _LongPressProgressActionsInited;
	}
}

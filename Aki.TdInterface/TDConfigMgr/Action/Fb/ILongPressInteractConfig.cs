using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002619 RID: 9753
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig
	{
		// Token: 0x0600DAE9 RID: 56041 RVA: 0x002099C1 File Offset: 0x00207BC1
		[NullableContext(1)]
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

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0600DAEA RID: 56042 RVA: 0x002099E0 File Offset: 0x00207BE0
		public virtual float PressDuration
		{
			get
			{
				return this.Instance.PressDuration;
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0600DAEB RID: 56043 RVA: 0x002099ED File Offset: 0x00207BED
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

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0600DAEC RID: 56044 RVA: 0x00209A21 File Offset: 0x00207C21
		[Nullable(1)]
		public virtual ILongPressInteractStyleConfig Style
		{
			[NullableContext(1)]
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

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00209A50 File Offset: 0x00207C50
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

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x0600DAEE RID: 56046 RVA: 0x00209A86 File Offset: 0x00207C86
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

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0600DAEF RID: 56047 RVA: 0x00209ABC File Offset: 0x00207CBC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> LongPressStartActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0600DAF0 RID: 56048 RVA: 0x00209B38 File Offset: 0x00207D38
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> LongPressInterruptedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x00209BB4 File Offset: 0x00207DB4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> LongPressSuccessActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0600DAF2 RID: 56050 RVA: 0x00209C30 File Offset: 0x00207E30
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ILongPressProgressAction> LongPressProgressActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04007991 RID: 31121
		private ILongPressInteractConfig Instance;

		// Token: 0x04007992 RID: 31122
		private ILongPressEffectConfig _PressEffectCache;

		// Token: 0x04007993 RID: 31123
		private bool _PressEffectInited;

		// Token: 0x04007994 RID: 31124
		[Nullable(1)]
		private ILongPressInteractStyleConfig _StyleCache;

		// Token: 0x04007995 RID: 31125
		private bool _StyleInited;

		// Token: 0x04007996 RID: 31126
		private ILongPressButtonActionMapping _LongPressButtonActionMappingCache;

		// Token: 0x04007997 RID: 31127
		private bool _LongPressButtonActionMappingInited;

		// Token: 0x04007998 RID: 31128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressStartActionsCache;

		// Token: 0x04007999 RID: 31129
		private bool _LongPressStartActionsInited;

		// Token: 0x0400799A RID: 31130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressInterruptedActionsCache;

		// Token: 0x0400799B RID: 31131
		private bool _LongPressInterruptedActionsInited;

		// Token: 0x0400799C RID: 31132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressSuccessActionsCache;

		// Token: 0x0400799D RID: 31133
		private bool _LongPressSuccessActionsInited;

		// Token: 0x0400799E RID: 31134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILongPressProgressAction> _LongPressProgressActionsCache;

		// Token: 0x0400799F RID: 31135
		private bool _LongPressProgressActionsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D87 RID: 7559
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig
	{
		// Token: 0x0600A06F RID: 41071 RVA: 0x0016FE18 File Offset: 0x0016E018
		[NullableContext(0)]
		private ILongPressInteractConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x0016FE50 File Offset: 0x0016E050
		[NullableContext(0)]
		public static ILongPressInteractConfig Create([Nullable(2)] ILongPressInteractConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x0016FE63 File Offset: 0x0016E063
		[NullableContext(0)]
		public static ILongPressInteractConfig CreateFromSetValue([Nullable(2)] ILongPressInteractConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x0016FE78 File Offset: 0x0016E078
		[NullableContext(0)]
		public ILongPressInteractConfig_SetValue ToSetValue()
		{
			return new ILongPressInteractConfig_SetValue
			{
				PressDuration = this.PressDuration,
				PressEffect = this.PressEffect,
				Style = this.Style,
				ResetFromCurrentProgress = this.ResetFromCurrentProgress,
				LongPressButtonActionMapping = this.LongPressButtonActionMapping,
				LongPressStartActions = this.LongPressStartActions,
				LongPressInterruptedActions = this.LongPressInterruptedActions,
				LongPressSuccessActions = this.LongPressSuccessActions,
				LongPressProgressActions = this.LongPressProgressActions
			};
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A073 RID: 41075 RVA: 0x0016FEF6 File Offset: 0x0016E0F6
		// (set) Token: 0x0600A074 RID: 41076 RVA: 0x0016FF25 File Offset: 0x0016E125
		public virtual float PressDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PressDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PressDuration;
			}
			set
			{
				this.GetOrCreatePoco().PressDuration = value;
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A075 RID: 41077 RVA: 0x0016FF34 File Offset: 0x0016E134
		// (set) Token: 0x0600A076 RID: 41078 RVA: 0x0016FF95 File Offset: 0x0016E195
		public virtual ILongPressEffectConfig PressEffect
		{
			get
			{
				if (this._PressEffectInited)
				{
					return this._PressEffectCache;
				}
				this._PressEffectInited = true;
				if (this.FbInstance != null)
				{
					this._PressEffectCache = ILongPressEffectConfig.Create(this.FbInstance.PressEffect);
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._PressEffectCache = ((pocoInterface != null) ? pocoInterface.PressEffect : null);
				}
				return this._PressEffectCache;
			}
			set
			{
				this.GetOrCreatePoco().PressEffect = value;
				this._PressEffectInited = false;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x0016FFAA File Offset: 0x0016E1AA
		// (set) Token: 0x0600A078 RID: 41080 RVA: 0x0016FFD1 File Offset: 0x0016E1D1
		public virtual ILongPressInteractStyleConfig Style
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Style;
			}
			set
			{
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x0016FFE0 File Offset: 0x0016E1E0
		// (set) Token: 0x0600A07A RID: 41082 RVA: 0x0017001A File Offset: 0x0016E21A
		public virtual bool? ResetFromCurrentProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetFromCurrentProgress;
				}
				ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetFromCurrentProgress;
			}
			set
			{
				this.GetOrCreatePoco().ResetFromCurrentProgress = value;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A07B RID: 41083 RVA: 0x00170028 File Offset: 0x0016E228
		// (set) Token: 0x0600A07C RID: 41084 RVA: 0x00170089 File Offset: 0x0016E289
		public virtual ILongPressButtonActionMapping LongPressButtonActionMapping
		{
			get
			{
				if (this._LongPressButtonActionMappingInited)
				{
					return this._LongPressButtonActionMappingCache;
				}
				this._LongPressButtonActionMappingInited = true;
				if (this.FbInstance != null)
				{
					this._LongPressButtonActionMappingCache = ILongPressButtonActionMapping.Create(this.FbInstance.LongPressButtonActionMapping);
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._LongPressButtonActionMappingCache = ((pocoInterface != null) ? pocoInterface.LongPressButtonActionMapping : null);
				}
				return this._LongPressButtonActionMappingCache;
			}
			set
			{
				this.GetOrCreatePoco().LongPressButtonActionMapping = value;
				this._LongPressButtonActionMappingInited = false;
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x001700A0 File Offset: 0x0016E2A0
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x00170133 File Offset: 0x0016E333
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
				if (this.FbInstance != null)
				{
					List<ActionInfo> longPressStartActions = this.FbInstance.LongPressStartActions;
					if (longPressStartActions != null)
					{
						this._LongPressStartActionsCache = new List<ActionInfo>(longPressStartActions.Count);
						for (int i = 0; i < longPressStartActions.Count; i++)
						{
							this._LongPressStartActionsCache.Add(ActionInfo.Create(longPressStartActions[i]));
						}
					}
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._LongPressStartActionsCache = ((pocoInterface != null) ? pocoInterface.LongPressStartActions : null);
				}
				return this._LongPressStartActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LongPressStartActions = value;
				this._LongPressStartActionsInited = false;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A07F RID: 41087 RVA: 0x00170148 File Offset: 0x0016E348
		// (set) Token: 0x0600A080 RID: 41088 RVA: 0x001701DB File Offset: 0x0016E3DB
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
				if (this.FbInstance != null)
				{
					List<ActionInfo> longPressInterruptedActions = this.FbInstance.LongPressInterruptedActions;
					if (longPressInterruptedActions != null)
					{
						this._LongPressInterruptedActionsCache = new List<ActionInfo>(longPressInterruptedActions.Count);
						for (int i = 0; i < longPressInterruptedActions.Count; i++)
						{
							this._LongPressInterruptedActionsCache.Add(ActionInfo.Create(longPressInterruptedActions[i]));
						}
					}
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._LongPressInterruptedActionsCache = ((pocoInterface != null) ? pocoInterface.LongPressInterruptedActions : null);
				}
				return this._LongPressInterruptedActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LongPressInterruptedActions = value;
				this._LongPressInterruptedActionsInited = false;
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x001701F0 File Offset: 0x0016E3F0
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x00170283 File Offset: 0x0016E483
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
				if (this.FbInstance != null)
				{
					List<ActionInfo> longPressSuccessActions = this.FbInstance.LongPressSuccessActions;
					if (longPressSuccessActions != null)
					{
						this._LongPressSuccessActionsCache = new List<ActionInfo>(longPressSuccessActions.Count);
						for (int i = 0; i < longPressSuccessActions.Count; i++)
						{
							this._LongPressSuccessActionsCache.Add(ActionInfo.Create(longPressSuccessActions[i]));
						}
					}
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._LongPressSuccessActionsCache = ((pocoInterface != null) ? pocoInterface.LongPressSuccessActions : null);
				}
				return this._LongPressSuccessActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LongPressSuccessActions = value;
				this._LongPressSuccessActionsInited = false;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x00170298 File Offset: 0x0016E498
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x0017032B File Offset: 0x0016E52B
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
				if (this.FbInstance != null)
				{
					List<ILongPressProgressAction> longPressProgressActions = this.FbInstance.LongPressProgressActions;
					if (longPressProgressActions != null)
					{
						this._LongPressProgressActionsCache = new List<ILongPressProgressAction>(longPressProgressActions.Count);
						for (int i = 0; i < longPressProgressActions.Count; i++)
						{
							this._LongPressProgressActionsCache.Add(ILongPressProgressAction.Create(longPressProgressActions[i]));
						}
					}
				}
				else
				{
					ILongPressInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._LongPressProgressActionsCache = ((pocoInterface != null) ? pocoInterface.LongPressProgressActions : null);
				}
				return this._LongPressProgressActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LongPressProgressActions = value;
				this._LongPressProgressActionsInited = false;
			}
		}

		// Token: 0x0400617E RID: 24958
		protected ILongPressInteractConfig FbInstance;

		// Token: 0x0400617F RID: 24959
		protected ILongPressInteractConfig_SetValue PocoInterface;

		// Token: 0x04006180 RID: 24960
		[Nullable(0)]
		private ILongPressEffectConfig _PressEffectCache;

		// Token: 0x04006181 RID: 24961
		private bool _PressEffectInited;

		// Token: 0x04006182 RID: 24962
		[Nullable(0)]
		private ILongPressButtonActionMapping _LongPressButtonActionMappingCache;

		// Token: 0x04006183 RID: 24963
		private bool _LongPressButtonActionMappingInited;

		// Token: 0x04006184 RID: 24964
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressStartActionsCache;

		// Token: 0x04006185 RID: 24965
		private bool _LongPressStartActionsInited;

		// Token: 0x04006186 RID: 24966
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressInterruptedActionsCache;

		// Token: 0x04006187 RID: 24967
		private bool _LongPressInterruptedActionsInited;

		// Token: 0x04006188 RID: 24968
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LongPressSuccessActionsCache;

		// Token: 0x04006189 RID: 24969
		private bool _LongPressSuccessActionsInited;

		// Token: 0x0400618A RID: 24970
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ILongPressProgressAction> _LongPressProgressActionsCache;

		// Token: 0x0400618B RID: 24971
		private bool _LongPressProgressActionsInited;
	}
}

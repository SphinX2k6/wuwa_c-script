using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA0 RID: 7072
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig
	{
		// Token: 0x0600976B RID: 38763 RVA: 0x0015D358 File Offset: 0x0015B558
		[NullableContext(1)]
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

		// Token: 0x0600976C RID: 38764 RVA: 0x0015D390 File Offset: 0x0015B590
		[NullableContext(1)]
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

		// Token: 0x0600976D RID: 38765 RVA: 0x0015D3A3 File Offset: 0x0015B5A3
		[NullableContext(1)]
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

		// Token: 0x0600976E RID: 38766 RVA: 0x0015D3B8 File Offset: 0x0015B5B8
		[NullableContext(1)]
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

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x0015D436 File Offset: 0x0015B636
		// (set) Token: 0x06009770 RID: 38768 RVA: 0x0015D465 File Offset: 0x0015B665
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

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x06009771 RID: 38769 RVA: 0x0015D474 File Offset: 0x0015B674
		// (set) Token: 0x06009772 RID: 38770 RVA: 0x0015D4D5 File Offset: 0x0015B6D5
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

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x06009773 RID: 38771 RVA: 0x0015D4EA File Offset: 0x0015B6EA
		// (set) Token: 0x06009774 RID: 38772 RVA: 0x0015D511 File Offset: 0x0015B711
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

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x06009775 RID: 38773 RVA: 0x0015D520 File Offset: 0x0015B720
		// (set) Token: 0x06009776 RID: 38774 RVA: 0x0015D55A File Offset: 0x0015B75A
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

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x06009777 RID: 38775 RVA: 0x0015D568 File Offset: 0x0015B768
		// (set) Token: 0x06009778 RID: 38776 RVA: 0x0015D5C9 File Offset: 0x0015B7C9
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

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x0015D5E0 File Offset: 0x0015B7E0
		// (set) Token: 0x0600977A RID: 38778 RVA: 0x0015D673 File Offset: 0x0015B873
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LongPressStartActions = value;
				this._LongPressStartActionsInited = false;
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x0015D688 File Offset: 0x0015B888
		// (set) Token: 0x0600977C RID: 38780 RVA: 0x0015D71B File Offset: 0x0015B91B
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LongPressInterruptedActions = value;
				this._LongPressInterruptedActionsInited = false;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x0015D730 File Offset: 0x0015B930
		// (set) Token: 0x0600977E RID: 38782 RVA: 0x0015D7C3 File Offset: 0x0015B9C3
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LongPressSuccessActions = value;
				this._LongPressSuccessActionsInited = false;
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x0015D7D8 File Offset: 0x0015B9D8
		// (set) Token: 0x06009780 RID: 38784 RVA: 0x0015D86B File Offset: 0x0015BA6B
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LongPressProgressActions = value;
				this._LongPressProgressActionsInited = false;
			}
		}

		// Token: 0x04005C69 RID: 23657
		protected ILongPressInteractConfig FbInstance;

		// Token: 0x04005C6A RID: 23658
		protected ILongPressInteractConfig_SetValue PocoInterface;

		// Token: 0x04005C6B RID: 23659
		[Nullable(1)]
		private ILongPressEffectConfig _PressEffectCache;

		// Token: 0x04005C6C RID: 23660
		private bool _PressEffectInited;

		// Token: 0x04005C6D RID: 23661
		[Nullable(1)]
		private ILongPressButtonActionMapping _LongPressButtonActionMappingCache;

		// Token: 0x04005C6E RID: 23662
		private bool _LongPressButtonActionMappingInited;

		// Token: 0x04005C6F RID: 23663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressStartActionsCache;

		// Token: 0x04005C70 RID: 23664
		private bool _LongPressStartActionsInited;

		// Token: 0x04005C71 RID: 23665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressInterruptedActionsCache;

		// Token: 0x04005C72 RID: 23666
		private bool _LongPressInterruptedActionsInited;

		// Token: 0x04005C73 RID: 23667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LongPressSuccessActionsCache;

		// Token: 0x04005C74 RID: 23668
		private bool _LongPressSuccessActionsInited;

		// Token: 0x04005C75 RID: 23669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILongPressProgressAction> _LongPressProgressActionsCache;

		// Token: 0x04005C76 RID: 23670
		private bool _LongPressProgressActionsInited;
	}
}

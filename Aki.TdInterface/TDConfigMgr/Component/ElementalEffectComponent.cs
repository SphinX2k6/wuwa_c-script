using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000CE RID: 206
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalEffectComponent : IComponentBase
	{
		// Token: 0x06000382 RID: 898 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		private ElementalEffectComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ElementalEffectComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ElementalEffectComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ElementalEffectComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001C008 File Offset: 0x0001A208
		public static ElementalEffectComponent Create([Nullable(2)] ElementalEffectComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalEffectComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001C01B File Offset: 0x0001A21B
		public static ElementalEffectComponent CreateFromSetValue([Nullable(2)] ElementalEffectComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ElementalEffectComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001C030 File Offset: 0x0001A230
		public new ElementalEffectComponent_SetValue ToSetValue()
		{
			return new ElementalEffectComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MatchConfig = this.MatchConfig,
				Range = this.Range,
				OnActiveEffectActions = this.OnActiveEffectActions,
				OnLoseEffectActions = this.OnLoseEffectActions
			};
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0001C08C File Offset: 0x0001A28C
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0001C0C6 File Offset: 0x0001A2C6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ElementalEffectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0001C0FE File Offset: 0x0001A2FE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001C10C File Offset: 0x0001A30C
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0001C133 File Offset: 0x0001A333
		public virtual IElementalMatchBase MatchConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MatchConfig;
				}
				ElementalEffectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MatchConfig;
			}
			set
			{
				this.GetOrCreatePoco().MatchConfig = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0001C141 File Offset: 0x0001A341
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0001C168 File Offset: 0x0001A368
		public virtual IElementalRangeTypeBase Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				ElementalEffectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001C178 File Offset: 0x0001A378
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0001C20B File Offset: 0x0001A40B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IElementalMatchActions> OnActiveEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnActiveEffectActionsInited)
				{
					return this._OnActiveEffectActionsCache;
				}
				this._OnActiveEffectActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IElementalMatchActions> onActiveEffectActions = this.FbInstance.OnActiveEffectActions;
					if (onActiveEffectActions != null)
					{
						this._OnActiveEffectActionsCache = new List<IElementalMatchActions>(onActiveEffectActions.Count);
						for (int i = 0; i < onActiveEffectActions.Count; i++)
						{
							this._OnActiveEffectActionsCache.Add(IElementalMatchActions.Create(onActiveEffectActions[i]));
						}
					}
				}
				else
				{
					ElementalEffectComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnActiveEffectActionsCache = ((pocoInterface != null) ? pocoInterface.OnActiveEffectActions : null);
				}
				return this._OnActiveEffectActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OnActiveEffectActions = value;
				this._OnActiveEffectActionsInited = false;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001C220 File Offset: 0x0001A420
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0001C2B3 File Offset: 0x0001A4B3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IElementalMatchActions> OnLoseEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnLoseEffectActionsInited)
				{
					return this._OnLoseEffectActionsCache;
				}
				this._OnLoseEffectActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IElementalMatchActions> onLoseEffectActions = this.FbInstance.OnLoseEffectActions;
					if (onLoseEffectActions != null)
					{
						this._OnLoseEffectActionsCache = new List<IElementalMatchActions>(onLoseEffectActions.Count);
						for (int i = 0; i < onLoseEffectActions.Count; i++)
						{
							this._OnLoseEffectActionsCache.Add(IElementalMatchActions.Create(onLoseEffectActions[i]));
						}
					}
				}
				else
				{
					ElementalEffectComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnLoseEffectActionsCache = ((pocoInterface != null) ? pocoInterface.OnLoseEffectActions : null);
				}
				return this._OnLoseEffectActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OnLoseEffectActions = value;
				this._OnLoseEffectActionsInited = false;
			}
		}

		// Token: 0x04000486 RID: 1158
		[Nullable(2)]
		protected new ElementalEffectComponent FbInstance;

		// Token: 0x04000487 RID: 1159
		[Nullable(2)]
		protected new ElementalEffectComponent_SetValue PocoInterface;

		// Token: 0x04000488 RID: 1160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IElementalMatchActions> _OnActiveEffectActionsCache;

		// Token: 0x04000489 RID: 1161
		private bool _OnActiveEffectActionsInited;

		// Token: 0x0400048A RID: 1162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IElementalMatchActions> _OnLoseEffectActionsCache;

		// Token: 0x0400048B RID: 1163
		private bool _OnLoseEffectActionsInited;
	}
}

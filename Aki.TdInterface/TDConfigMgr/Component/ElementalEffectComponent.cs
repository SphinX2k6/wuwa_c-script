using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D6 RID: 214
	public class ElementalEffectComponent : IComponentBase
	{
		// Token: 0x06000386 RID: 902 RVA: 0x0001C944 File Offset: 0x0001AB44
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

		// Token: 0x06000387 RID: 903 RVA: 0x0001C97C File Offset: 0x0001AB7C
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

		// Token: 0x06000388 RID: 904 RVA: 0x0001C98F File Offset: 0x0001AB8F
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

		// Token: 0x06000389 RID: 905 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001CA00 File Offset: 0x0001AC00
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0001CA3A File Offset: 0x0001AC3A
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0001CA48 File Offset: 0x0001AC48
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0001CA72 File Offset: 0x0001AC72
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001CA80 File Offset: 0x0001AC80
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0001CAA7 File Offset: 0x0001ACA7
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001CAB5 File Offset: 0x0001ACB5
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0001CADC File Offset: 0x0001ACDC
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0001CB7F File Offset: 0x0001AD7F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IElementalMatchActions> OnActiveEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().OnActiveEffectActions = value;
				this._OnActiveEffectActionsInited = false;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001CB94 File Offset: 0x0001AD94
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0001CC27 File Offset: 0x0001AE27
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IElementalMatchActions> OnLoseEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().OnLoseEffectActions = value;
				this._OnLoseEffectActionsInited = false;
			}
		}

		// Token: 0x040004AA RID: 1194
		[Nullable(2)]
		protected new ElementalEffectComponent FbInstance;

		// Token: 0x040004AB RID: 1195
		[Nullable(2)]
		protected new ElementalEffectComponent_SetValue PocoInterface;

		// Token: 0x040004AC RID: 1196
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IElementalMatchActions> _OnActiveEffectActionsCache;

		// Token: 0x040004AD RID: 1197
		private bool _OnActiveEffectActionsInited;

		// Token: 0x040004AE RID: 1198
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IElementalMatchActions> _OnLoseEffectActionsCache;

		// Token: 0x040004AF RID: 1199
		private bool _OnLoseEffectActionsInited;
	}
}

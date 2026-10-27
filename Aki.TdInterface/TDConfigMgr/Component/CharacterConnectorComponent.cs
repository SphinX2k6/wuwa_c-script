using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterConnectorComponent : IComponentBase
	{
		// Token: 0x06000208 RID: 520 RVA: 0x000188F0 File Offset: 0x00016AF0
		private CharacterConnectorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CharacterConnectorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CharacterConnectorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CharacterConnectorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00018928 File Offset: 0x00016B28
		public static CharacterConnectorComponent Create([Nullable(2)] CharacterConnectorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CharacterConnectorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001893B File Offset: 0x00016B3B
		public static CharacterConnectorComponent CreateFromSetValue([Nullable(2)] CharacterConnectorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CharacterConnectorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001894E File Offset: 0x00016B4E
		public new CharacterConnectorComponent_SetValue ToSetValue()
		{
			return new CharacterConnectorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LogicType = this.LogicType
			};
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0001897C File Offset: 0x00016B7C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000189B6 File Offset: 0x00016BB6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CharacterConnectorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000189C4 File Offset: 0x00016BC4
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000189EE File Offset: 0x00016BEE
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000189FC File Offset: 0x00016BFC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00018A5D File Offset: 0x00016C5D
		public virtual ICharacterConnectorRange LogicType
		{
			get
			{
				if (this._LogicTypeInited)
				{
					return this._LogicTypeCache;
				}
				this._LogicTypeInited = true;
				if (this.FbInstance != null)
				{
					this._LogicTypeCache = ICharacterConnectorRange.Create(this.FbInstance.LogicType);
				}
				else
				{
					CharacterConnectorComponent_SetValue pocoInterface = this.PocoInterface;
					this._LogicTypeCache = ((pocoInterface != null) ? pocoInterface.LogicType : null);
				}
				return this._LogicTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().LogicType = value;
				this._LogicTypeInited = false;
			}
		}

		// Token: 0x0400014C RID: 332
		[Nullable(2)]
		protected new CharacterConnectorComponent FbInstance;

		// Token: 0x0400014D RID: 333
		[Nullable(2)]
		protected new CharacterConnectorComponent_SetValue PocoInterface;

		// Token: 0x0400014E RID: 334
		private ICharacterConnectorRange _LogicTypeCache;

		// Token: 0x0400014F RID: 335
		private bool _LogicTypeInited;
	}
}

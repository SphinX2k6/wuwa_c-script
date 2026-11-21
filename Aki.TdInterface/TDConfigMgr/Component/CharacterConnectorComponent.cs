using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003A RID: 58
	public class CharacterConnectorComponent : IComponentBase
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00019264 File Offset: 0x00017464
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

		// Token: 0x0600020D RID: 525 RVA: 0x0001929C File Offset: 0x0001749C
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

		// Token: 0x0600020E RID: 526 RVA: 0x000192AF File Offset: 0x000174AF
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

		// Token: 0x0600020F RID: 527 RVA: 0x000192C2 File Offset: 0x000174C2
		public new CharacterConnectorComponent_SetValue ToSetValue()
		{
			return new CharacterConnectorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LogicType = this.LogicType
			};
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000192F0 File Offset: 0x000174F0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0001932A File Offset: 0x0001752A
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00019338 File Offset: 0x00017538
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00019362 File Offset: 0x00017562
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00019370 File Offset: 0x00017570
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000193D1 File Offset: 0x000175D1
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

		// Token: 0x04000151 RID: 337
		[Nullable(2)]
		protected new CharacterConnectorComponent FbInstance;

		// Token: 0x04000152 RID: 338
		[Nullable(2)]
		protected new CharacterConnectorComponent_SetValue PocoInterface;

		// Token: 0x04000153 RID: 339
		private ICharacterConnectorRange _LogicTypeCache;

		// Token: 0x04000154 RID: 340
		private bool _LogicTypeInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2B RID: 3371
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterConnectorComponent : IComponentBase
	{
		// Token: 0x06004CEC RID: 19692 RVA: 0x000BF6DE File Offset: 0x000BD8DE
		public static CharacterConnectorComponent Create(ICharacterConnectorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CharacterConnectorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x000BF700 File Offset: 0x000BD900
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x000BF738 File Offset: 0x000BD938
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06004CEF RID: 19695 RVA: 0x000BF74E File Offset: 0x000BD94E
		public virtual ICharacterConnectorRange LogicType
		{
			get
			{
				if (this._LogicTypeInited)
				{
					return this._LogicTypeCache;
				}
				this._LogicTypeInited = true;
				this._LogicTypeCache = ICharacterConnectorRange.Create(this.Instance.LogicType);
				return this._LogicTypeCache;
			}
		}

		// Token: 0x04002C0A RID: 11274
		private ICharacterConnectorComponent Instance;

		// Token: 0x04002C0B RID: 11275
		[Nullable(2)]
		private ICharacterConnectorRange _LogicTypeCache;

		// Token: 0x04002C0C RID: 11276
		private bool _LogicTypeInited;
	}
}

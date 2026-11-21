using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E25 RID: 3621
	public class CharacterConnectorComponent : IComponentBase
	{
		// Token: 0x06005208 RID: 21000 RVA: 0x000CAE22 File Offset: 0x000C9022
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x000CAE44 File Offset: 0x000C9044
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x000CAE7C File Offset: 0x000C907C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x000CAE92 File Offset: 0x000C9092
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

		// Token: 0x04002ECA RID: 11978
		private ICharacterConnectorComponent Instance;

		// Token: 0x04002ECB RID: 11979
		[Nullable(2)]
		private ICharacterConnectorRange _LogicTypeCache;

		// Token: 0x04002ECC RID: 11980
		private bool _LogicTypeInited;
	}
}

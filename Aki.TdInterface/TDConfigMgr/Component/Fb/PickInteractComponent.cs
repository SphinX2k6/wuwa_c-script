using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D34 RID: 3380
	[NullableContext(1)]
	[Nullable(0)]
	public class PickInteractComponent : IComponentBase
	{
		// Token: 0x06004D20 RID: 19744 RVA: 0x000BFEFC File Offset: 0x000BE0FC
		public static PickInteractComponent Create(IPickInteractComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PickInteractComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x000BFF1C File Offset: 0x000BE11C
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

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06004D22 RID: 19746 RVA: 0x000BFF54 File Offset: 0x000BE154
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x000BFF6A File Offset: 0x000BE16A
		public virtual IChessmanPickInteraction PickInteractType
		{
			get
			{
				if (this._PickInteractTypeInited)
				{
					return this._PickInteractTypeCache;
				}
				this._PickInteractTypeInited = true;
				this._PickInteractTypeCache = IChessmanPickInteraction.Create(this.Instance.PickInteractType);
				return this._PickInteractTypeCache;
			}
		}

		// Token: 0x04002C35 RID: 11317
		private IPickInteractComponent Instance;

		// Token: 0x04002C36 RID: 11318
		[Nullable(2)]
		private IChessmanPickInteraction _PickInteractTypeCache;

		// Token: 0x04002C37 RID: 11319
		private bool _PickInteractTypeInited;
	}
}

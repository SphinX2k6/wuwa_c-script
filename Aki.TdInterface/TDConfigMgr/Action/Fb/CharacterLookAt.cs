using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200262E RID: 9774
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterLookAt : ActionParams
	{
		// Token: 0x0600DB56 RID: 56150 RVA: 0x0020A777 File Offset: 0x00208977
		public static CharacterLookAt Create(ICharacterLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CharacterLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0600DB57 RID: 56151 RVA: 0x0020A796 File Offset: 0x00208996
		public virtual int CharEntityId
		{
			get
			{
				return this.Instance.CharEntityId;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0600DB58 RID: 56152 RVA: 0x0020A7A3 File Offset: 0x002089A3
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadCharacterLookAt_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x040079D6 RID: 31190
		private ICharacterLookAt Instance;

		// Token: 0x040079D7 RID: 31191
		private ICharacterLookAtData _TargetCache;

		// Token: 0x040079D8 RID: 31192
		private bool _TargetInited;
	}
}

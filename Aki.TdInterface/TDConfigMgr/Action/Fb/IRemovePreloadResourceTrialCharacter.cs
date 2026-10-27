using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E6 RID: 10726
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadResourceTrialCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600ECE4 RID: 60644 RVA: 0x002292DF File Offset: 0x002274DF
		public static IRemovePreloadResourceTrialCharacter Create(IRemovePreloadResourceTrialCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceTrialCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x0600ECE5 RID: 60645 RVA: 0x002292FE File Offset: 0x002274FE
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x0600ECE6 RID: 60646 RVA: 0x0022930C File Offset: 0x0022750C
		public virtual List<int> CharacterGroup
		{
			get
			{
				if (this._CharacterGroupInited)
				{
					return this._CharacterGroupCache;
				}
				this._CharacterGroupInited = true;
				int characterGroupLength = this.Instance.CharacterGroupLength;
				this._CharacterGroupCache = new List<int>(characterGroupLength);
				for (int i = 0; i < characterGroupLength; i++)
				{
					this._CharacterGroupCache.Add(this.Instance.CharacterGroup(i));
				}
				return this._CharacterGroupCache;
			}
		}

		// Token: 0x04008276 RID: 33398
		private IRemovePreloadResourceTrialCharacter Instance;

		// Token: 0x04008277 RID: 33399
		private List<int> _CharacterGroupCache;

		// Token: 0x04008278 RID: 33400
		private bool _CharacterGroupInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7F RID: 2943
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterPreDependOnPreceding : ISpawnMonsterPreConditonType
	{
		// Token: 0x060043BE RID: 17342 RVA: 0x000AC74E File Offset: 0x000AA94E
		public static ISpawnMonsterPreDependOnPreceding Create(ISpawnMonsterPreDependOnPreceding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x000AC76D File Offset: 0x000AA96D
		public override ESpawnMonsterPreCondition Type
		{
			get
			{
				return (ESpawnMonsterPreCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x000AC77C File Offset: 0x000AA97C
		public virtual List<int> Ids
		{
			get
			{
				if (this._IdsInited)
				{
					return this._IdsCache;
				}
				this._IdsInited = true;
				int idsLength = this.Instance.IdsLength;
				this._IdsCache = new List<int>(idsLength);
				for (int i = 0; i < idsLength; i++)
				{
					this._IdsCache.Add(this.Instance.Ids(i));
				}
				return this._IdsCache;
			}
		}

		// Token: 0x04002630 RID: 9776
		private ISpawnMonsterPreDependOnPreceding Instance;

		// Token: 0x04002631 RID: 9777
		private List<int> _IdsCache;

		// Token: 0x04002632 RID: 9778
		private bool _IdsInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145D RID: 5213
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityGroup
	{
		// Token: 0x06007678 RID: 30328 RVA: 0x0011AEF4 File Offset: 0x001190F4
		public static IRecallEntityGroup Create(IRecallEntityGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x06007679 RID: 30329 RVA: 0x0011AF13 File Offset: 0x00119113
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x0011AF20 File Offset: 0x00119120
		public virtual string Source
		{
			get
			{
				return this.Instance.Source;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600767B RID: 30331 RVA: 0x0011AF2D File Offset: 0x0011912D
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x0011AF3C File Offset: 0x0011913C
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x040044CB RID: 17611
		private IRecallEntityGroup Instance;

		// Token: 0x040044CC RID: 17612
		private List<int> _EntitiesCache;

		// Token: 0x040044CD RID: 17613
		private bool _EntitiesInited;
	}
}

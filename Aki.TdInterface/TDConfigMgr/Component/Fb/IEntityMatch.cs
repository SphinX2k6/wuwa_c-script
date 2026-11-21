using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B93 RID: 2963
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityMatch
	{
		// Token: 0x060043BC RID: 17340 RVA: 0x000ABBC6 File Offset: 0x000A9DC6
		[NullableContext(0)]
		public static IEntityMatch Create(IEntityMatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x000ABBE8 File Offset: 0x000A9DE8
		public virtual bool? AllCharacter
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AllCharacter);
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x000ABC20 File Offset: 0x000A9E20
		public virtual bool? OnlyPlayer
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyPlayer);
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x000ABC58 File Offset: 0x000A9E58
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityCategory> Categories
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._CategoriesInited)
				{
					return this._CategoriesCache;
				}
				this._CategoriesInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int categoriesLength = this.Instance.CategoriesLength;
				this._CategoriesCache = new List<IEntityCategory>(categoriesLength);
				for (int i = 0; i < categoriesLength; i++)
				{
					this._CategoriesCache.Add(IEntityCategory.Create(this.Instance.Categories(i)));
				}
				return this._CategoriesCache;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x000ABCD4 File Offset: 0x000A9ED4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x000ABD4C File Offset: 0x000A9F4C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityState> States
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StatesInited)
				{
					return this._StatesCache;
				}
				this._StatesInited = true;
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int statesLength = this.Instance.StatesLength;
				this._StatesCache = new List<IEntityState>(statesLength);
				for (int i = 0; i < statesLength; i++)
				{
					this._StatesCache.Add(IEntityState.Create(this.Instance.States(i)));
				}
				return this._StatesCache;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x000ABDC8 File Offset: 0x000A9FC8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> PerformanceStates
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._PerformanceStatesInited)
				{
					return this._PerformanceStatesCache;
				}
				this._PerformanceStatesInited = true;
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				int performanceStatesLength = this.Instance.PerformanceStatesLength;
				this._PerformanceStatesCache = new List<string>(performanceStatesLength);
				for (int i = 0; i < performanceStatesLength; i++)
				{
					this._PerformanceStatesCache.Add(this.Instance.PerformanceStates(i));
				}
				return this._PerformanceStatesCache;
			}
		}

		// Token: 0x04002570 RID: 9584
		private IEntityMatch Instance;

		// Token: 0x04002571 RID: 9585
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityCategory> _CategoriesCache;

		// Token: 0x04002572 RID: 9586
		private bool _CategoriesInited;

		// Token: 0x04002573 RID: 9587
		private List<int> _EntityIdsCache;

		// Token: 0x04002574 RID: 9588
		private bool _EntityIdsInited;

		// Token: 0x04002575 RID: 9589
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityState> _StatesCache;

		// Token: 0x04002576 RID: 9590
		private bool _StatesInited;

		// Token: 0x04002577 RID: 9591
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _PerformanceStatesCache;

		// Token: 0x04002578 RID: 9592
		private bool _PerformanceStatesInited;
	}
}

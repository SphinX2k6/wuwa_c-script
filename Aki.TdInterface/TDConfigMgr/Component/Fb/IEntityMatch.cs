using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC9 RID: 2761
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityMatch
	{
		// Token: 0x06003F92 RID: 16274 RVA: 0x000A25D2 File Offset: 0x000A07D2
		[NullableContext(1)]
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

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x000A25F4 File Offset: 0x000A07F4
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

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x000A262C File Offset: 0x000A082C
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x000A2664 File Offset: 0x000A0864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityCategory> Categories
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x000A26E0 File Offset: 0x000A08E0
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x000A2758 File Offset: 0x000A0958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityState> States
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x000A27D4 File Offset: 0x000A09D4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> PerformanceStates
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002354 RID: 9044
		private IEntityMatch Instance;

		// Token: 0x04002355 RID: 9045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityCategory> _CategoriesCache;

		// Token: 0x04002356 RID: 9046
		private bool _CategoriesInited;

		// Token: 0x04002357 RID: 9047
		private List<int> _EntityIdsCache;

		// Token: 0x04002358 RID: 9048
		private bool _EntityIdsInited;

		// Token: 0x04002359 RID: 9049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityState> _StatesCache;

		// Token: 0x0400235A RID: 9050
		private bool _StatesInited;

		// Token: 0x0400235B RID: 9051
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _PerformanceStatesCache;

		// Token: 0x0400235C RID: 9052
		private bool _PerformanceStatesInited;
	}
}

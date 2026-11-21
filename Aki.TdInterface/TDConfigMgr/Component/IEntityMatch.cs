using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036A RID: 874
	public class IEntityMatch
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x0003A6A4 File Offset: 0x000388A4
		private IEntityMatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatch_SetValue());
			}
			return result;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0003A6DC File Offset: 0x000388DC
		public static IEntityMatch Create([Nullable(2)] IEntityMatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0003A6EF File Offset: 0x000388EF
		public static IEntityMatch CreateFromSetValue([Nullable(2)] IEntityMatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0003A704 File Offset: 0x00038904
		public IEntityMatch_SetValue ToSetValue()
		{
			return new IEntityMatch_SetValue
			{
				AllCharacter = this.AllCharacter,
				OnlyPlayer = this.OnlyPlayer,
				Categories = this.Categories,
				EntityIds = this.EntityIds,
				States = this.States,
				PerformanceStates = this.PerformanceStates
			};
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0003A760 File Offset: 0x00038960
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x0003A79A File Offset: 0x0003899A
		public virtual bool? AllCharacter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AllCharacter;
				}
				IEntityMatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AllCharacter;
			}
			set
			{
				this.GetOrCreatePoco().AllCharacter = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0003A7A8 File Offset: 0x000389A8
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x0003A7E2 File Offset: 0x000389E2
		public virtual bool? OnlyPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyPlayer;
				}
				IEntityMatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyPlayer;
			}
			set
			{
				this.GetOrCreatePoco().OnlyPlayer = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0003A7F0 File Offset: 0x000389F0
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x0003A883 File Offset: 0x00038A83
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
				if (this.FbInstance != null)
				{
					List<IEntityCategory> categories = this.FbInstance.Categories;
					if (categories != null)
					{
						this._CategoriesCache = new List<IEntityCategory>(categories.Count);
						for (int i = 0; i < categories.Count; i++)
						{
							this._CategoriesCache.Add(IEntityCategory.Create(categories[i]));
						}
					}
				}
				else
				{
					IEntityMatch_SetValue pocoInterface = this.PocoInterface;
					this._CategoriesCache = ((pocoInterface != null) ? pocoInterface.Categories : null);
				}
				return this._CategoriesCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Categories = value;
				this._CategoriesInited = false;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0003A898 File Offset: 0x00038A98
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x0003A8BF File Offset: 0x00038ABF
		[Nullable(2)]
		public virtual List<int> EntityIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IEntityMatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0003A8D0 File Offset: 0x00038AD0
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x0003A963 File Offset: 0x00038B63
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
				if (this.FbInstance != null)
				{
					List<IEntityState> states = this.FbInstance.States;
					if (states != null)
					{
						this._StatesCache = new List<IEntityState>(states.Count);
						for (int i = 0; i < states.Count; i++)
						{
							this._StatesCache.Add(IEntityState.Create(states[i]));
						}
					}
				}
				else
				{
					IEntityMatch_SetValue pocoInterface = this.PocoInterface;
					this._StatesCache = ((pocoInterface != null) ? pocoInterface.States : null);
				}
				return this._StatesCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().States = value;
				this._StatesInited = false;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0003A978 File Offset: 0x00038B78
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x0003A99F File Offset: 0x00038B9F
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceStates;
				}
				IEntityMatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformanceStates;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().PerformanceStates = value;
			}
		}

		// Token: 0x04000E57 RID: 3671
		[Nullable(2)]
		protected IEntityMatch FbInstance;

		// Token: 0x04000E58 RID: 3672
		[Nullable(2)]
		protected IEntityMatch_SetValue PocoInterface;

		// Token: 0x04000E59 RID: 3673
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityCategory> _CategoriesCache;

		// Token: 0x04000E5A RID: 3674
		private bool _CategoriesInited;

		// Token: 0x04000E5B RID: 3675
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityState> _StatesCache;

		// Token: 0x04000E5C RID: 3676
		private bool _StatesInited;
	}
}

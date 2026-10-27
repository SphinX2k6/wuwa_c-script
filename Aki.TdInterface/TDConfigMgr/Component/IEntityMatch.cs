using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000323 RID: 803
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityMatch
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x000376D8 File Offset: 0x000358D8
		[NullableContext(1)]
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00037710 File Offset: 0x00035910
		[NullableContext(1)]
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

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00037723 File Offset: 0x00035923
		[NullableContext(1)]
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

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00037738 File Offset: 0x00035938
		[NullableContext(1)]
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00037794 File Offset: 0x00035994
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x000377CE File Offset: 0x000359CE
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000377DC File Offset: 0x000359DC
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00037816 File Offset: 0x00035A16
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00037824 File Offset: 0x00035A24
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x000378B7 File Offset: 0x00035AB7
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Categories = value;
				this._CategoriesInited = false;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000378CC File Offset: 0x00035ACC
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x000378F3 File Offset: 0x00035AF3
		public virtual List<int> EntityIds
		{
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
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00037904 File Offset: 0x00035B04
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00037997 File Offset: 0x00035B97
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().States = value;
				this._StatesInited = false;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000379AC File Offset: 0x00035BAC
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x000379D3 File Offset: 0x00035BD3
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().PerformanceStates = value;
			}
		}

		// Token: 0x04000D6C RID: 3436
		protected IEntityMatch FbInstance;

		// Token: 0x04000D6D RID: 3437
		protected IEntityMatch_SetValue PocoInterface;

		// Token: 0x04000D6E RID: 3438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityCategory> _CategoriesCache;

		// Token: 0x04000D6F RID: 3439
		private bool _CategoriesInited;

		// Token: 0x04000D70 RID: 3440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityState> _StatesCache;

		// Token: 0x04000D71 RID: 3441
		private bool _StatesInited;
	}
}

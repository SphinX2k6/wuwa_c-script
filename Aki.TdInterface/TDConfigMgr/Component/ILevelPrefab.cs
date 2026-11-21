using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000519 RID: 1305
	public class ILevelPrefab : IModelConfig
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x0004D730 File Offset: 0x0004B930
		private ILevelPrefab_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPrefab 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPrefab_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPrefab_SetValue());
			}
			return result;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0004D768 File Offset: 0x0004B968
		public static ILevelPrefab Create([Nullable(2)] ILevelPrefab instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPrefab
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0004D77B File Offset: 0x0004B97B
		public static ILevelPrefab CreateFromSetValue([Nullable(2)] ILevelPrefab_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPrefab
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004D790 File Offset: 0x0004B990
		public new ILevelPrefab_SetValue ToSetValue()
		{
			return new ILevelPrefab_SetValue
			{
				Type = this.Type,
				BlueprintPath = this.BlueprintPath,
				PrefabPath = this.PrefabPath,
				NameOffsetZ = this.NameOffsetZ,
				PrefabStateList = this.PrefabStateList,
				EffectStateList = this.EffectStateList
			};
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0004D7EA File Offset: 0x0004B9EA
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0004D815 File Offset: 0x0004BA15
		public override EModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModelType.LevelPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0004D823 File Offset: 0x0004BA23
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0004D84E File Offset: 0x0004BA4E
		public virtual ELevelPrefabBpType BlueprintPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlueprintPath;
				}
				if (this.PocoInterface == null)
				{
					return ELevelPrefabBpType.Item;
				}
				return this.PocoInterface.BlueprintPath;
			}
			set
			{
				this.GetOrCreatePoco().BlueprintPath = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0004D85C File Offset: 0x0004BA5C
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0004D887 File Offset: 0x0004BA87
		public virtual string PrefabPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PrefabPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PrefabPath;
			}
			set
			{
				this.GetOrCreatePoco().PrefabPath = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0004D898 File Offset: 0x0004BA98
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0004D8D2 File Offset: 0x0004BAD2
		public virtual int? NameOffsetZ
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NameOffsetZ;
				}
				ILevelPrefab_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NameOffsetZ;
			}
			set
			{
				this.GetOrCreatePoco().NameOffsetZ = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0004D973 File Offset: 0x0004BB73
		public virtual List<IPrefabStateConfig> PrefabStateList
		{
			get
			{
				if (this._PrefabStateListInited)
				{
					return this._PrefabStateListCache;
				}
				this._PrefabStateListInited = true;
				if (this.FbInstance != null)
				{
					List<IPrefabStateConfig> prefabStateList = this.FbInstance.PrefabStateList;
					if (prefabStateList != null)
					{
						this._PrefabStateListCache = new List<IPrefabStateConfig>(prefabStateList.Count);
						for (int i = 0; i < prefabStateList.Count; i++)
						{
							this._PrefabStateListCache.Add(IPrefabStateConfig.Create(prefabStateList[i]));
						}
					}
				}
				else
				{
					ILevelPrefab_SetValue pocoInterface = this.PocoInterface;
					this._PrefabStateListCache = ((pocoInterface != null) ? pocoInterface.PrefabStateList : null);
				}
				return this._PrefabStateListCache;
			}
			set
			{
				this.GetOrCreatePoco().PrefabStateList = value;
				this._PrefabStateListInited = false;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0004D988 File Offset: 0x0004BB88
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0004DA1B File Offset: 0x0004BC1B
		public virtual List<IPrefabEffectConfig> EffectStateList
		{
			get
			{
				if (this._EffectStateListInited)
				{
					return this._EffectStateListCache;
				}
				this._EffectStateListInited = true;
				if (this.FbInstance != null)
				{
					List<IPrefabEffectConfig> effectStateList = this.FbInstance.EffectStateList;
					if (effectStateList != null)
					{
						this._EffectStateListCache = new List<IPrefabEffectConfig>(effectStateList.Count);
						for (int i = 0; i < effectStateList.Count; i++)
						{
							this._EffectStateListCache.Add(IPrefabEffectConfig.Create(effectStateList[i]));
						}
					}
				}
				else
				{
					ILevelPrefab_SetValue pocoInterface = this.PocoInterface;
					this._EffectStateListCache = ((pocoInterface != null) ? pocoInterface.EffectStateList : null);
				}
				return this._EffectStateListCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectStateList = value;
				this._EffectStateListInited = false;
			}
		}

		// Token: 0x04001366 RID: 4966
		[Nullable(2)]
		protected new ILevelPrefab FbInstance;

		// Token: 0x04001367 RID: 4967
		[Nullable(2)]
		protected new ILevelPrefab_SetValue PocoInterface;

		// Token: 0x04001368 RID: 4968
		private List<IPrefabStateConfig> _PrefabStateListCache;

		// Token: 0x04001369 RID: 4969
		private bool _PrefabStateListInited;

		// Token: 0x0400136A RID: 4970
		private List<IPrefabEffectConfig> _EffectStateListCache;

		// Token: 0x0400136B RID: 4971
		private bool _EffectStateListInited;
	}
}

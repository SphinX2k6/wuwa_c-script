using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C0 RID: 1216
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPrefab : IModelConfig
	{
		// Token: 0x060018A6 RID: 6310 RVA: 0x000499E8 File Offset: 0x00047BE8
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

		// Token: 0x060018A7 RID: 6311 RVA: 0x00049A20 File Offset: 0x00047C20
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

		// Token: 0x060018A8 RID: 6312 RVA: 0x00049A33 File Offset: 0x00047C33
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

		// Token: 0x060018A9 RID: 6313 RVA: 0x00049A48 File Offset: 0x00047C48
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00049AA2 File Offset: 0x00047CA2
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x00049ACD File Offset: 0x00047CCD
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00049ADB File Offset: 0x00047CDB
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00049B06 File Offset: 0x00047D06
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00049B14 File Offset: 0x00047D14
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00049B3F File Offset: 0x00047D3F
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00049B50 File Offset: 0x00047D50
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00049B8A File Offset: 0x00047D8A
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00049B98 File Offset: 0x00047D98
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00049C2B File Offset: 0x00047E2B
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00049C40 File Offset: 0x00047E40
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00049CD3 File Offset: 0x00047ED3
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

		// Token: 0x04001244 RID: 4676
		[Nullable(2)]
		protected new ILevelPrefab FbInstance;

		// Token: 0x04001245 RID: 4677
		[Nullable(2)]
		protected new ILevelPrefab_SetValue PocoInterface;

		// Token: 0x04001246 RID: 4678
		private List<IPrefabStateConfig> _PrefabStateListCache;

		// Token: 0x04001247 RID: 4679
		private bool _PrefabStateListInited;

		// Token: 0x04001248 RID: 4680
		private List<IPrefabEffectConfig> _EffectStateListCache;

		// Token: 0x04001249 RID: 4681
		private bool _EffectStateListInited;
	}
}

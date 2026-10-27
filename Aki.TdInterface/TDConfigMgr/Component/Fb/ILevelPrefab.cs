using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE0 RID: 3296
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPrefab : IModelConfig
	{
		// Token: 0x06004B4C RID: 19276 RVA: 0x000BC204 File Offset: 0x000BA404
		public static ILevelPrefab Create(ILevelPrefab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPrefab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x000BC223 File Offset: 0x000BA423
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x000BC230 File Offset: 0x000BA430
		public virtual ELevelPrefabBpType BlueprintPath
		{
			get
			{
				return (ELevelPrefabBpType)this.Instance.BlueprintPath;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004B4F RID: 19279 RVA: 0x000BC23D File Offset: 0x000BA43D
		public virtual string PrefabPath
		{
			get
			{
				return this.Instance.PrefabPath;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x000BC24C File Offset: 0x000BA44C
		public virtual int? NameOffsetZ
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.NameOffsetZ);
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x000BC284 File Offset: 0x000BA484
		public virtual List<IPrefabStateConfig> PrefabStateList
		{
			get
			{
				if (this._PrefabStateListInited)
				{
					return this._PrefabStateListCache;
				}
				this._PrefabStateListInited = true;
				int prefabStateListLength = this.Instance.PrefabStateListLength;
				this._PrefabStateListCache = new List<IPrefabStateConfig>(prefabStateListLength);
				for (int i = 0; i < prefabStateListLength; i++)
				{
					this._PrefabStateListCache.Add(IPrefabStateConfig.Create(this.Instance.PrefabStateList(i)));
				}
				return this._PrefabStateListCache;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x000BC2F0 File Offset: 0x000BA4F0
		public virtual List<IPrefabEffectConfig> EffectStateList
		{
			get
			{
				if (this._EffectStateListInited)
				{
					return this._EffectStateListCache;
				}
				this._EffectStateListInited = true;
				int effectStateListLength = this.Instance.EffectStateListLength;
				this._EffectStateListCache = new List<IPrefabEffectConfig>(effectStateListLength);
				for (int i = 0; i < effectStateListLength; i++)
				{
					this._EffectStateListCache.Add(IPrefabEffectConfig.Create(this.Instance.EffectStateList(i)));
				}
				return this._EffectStateListCache;
			}
		}

		// Token: 0x04002B13 RID: 11027
		private ILevelPrefab Instance;

		// Token: 0x04002B14 RID: 11028
		private List<IPrefabStateConfig> _PrefabStateListCache;

		// Token: 0x04002B15 RID: 11029
		private bool _PrefabStateListInited;

		// Token: 0x04002B16 RID: 11030
		private List<IPrefabEffectConfig> _EffectStateListCache;

		// Token: 0x04002B17 RID: 11031
		private bool _EffectStateListInited;
	}
}

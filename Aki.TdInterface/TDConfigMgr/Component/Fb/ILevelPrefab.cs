using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD7 RID: 3543
	public class ILevelPrefab : IModelConfig
	{
		// Token: 0x06005054 RID: 20564 RVA: 0x000C7602 File Offset: 0x000C5802
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

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x000C7621 File Offset: 0x000C5821
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x000C762E File Offset: 0x000C582E
		public virtual ELevelPrefabBpType BlueprintPath
		{
			get
			{
				return (ELevelPrefabBpType)this.Instance.BlueprintPath;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x000C763B File Offset: 0x000C583B
		public virtual string PrefabPath
		{
			get
			{
				return this.Instance.PrefabPath;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x000C7648 File Offset: 0x000C5848
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

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x000C7680 File Offset: 0x000C5880
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

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x000C76EC File Offset: 0x000C58EC
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

		// Token: 0x04002DC8 RID: 11720
		private ILevelPrefab Instance;

		// Token: 0x04002DC9 RID: 11721
		private List<IPrefabStateConfig> _PrefabStateListCache;

		// Token: 0x04002DCA RID: 11722
		private bool _PrefabStateListInited;

		// Token: 0x04002DCB RID: 11723
		private List<IPrefabEffectConfig> _EffectStateListCache;

		// Token: 0x04002DCC RID: 11724
		private bool _EffectStateListInited;
	}
}

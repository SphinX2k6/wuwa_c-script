using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D72 RID: 3442
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelPrefabPerformComponent : IComponentBase
	{
		// Token: 0x06004E54 RID: 20052 RVA: 0x000C25DE File Offset: 0x000C07DE
		[NullableContext(1)]
		public static LevelPrefabPerformComponent Create(ILevelPrefabPerformComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelPrefabPerformComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x000C2600 File Offset: 0x000C0800
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x000C2638 File Offset: 0x000C0838
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x000C2650 File Offset: 0x000C0850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITowardEntityConfig> TowardEntity
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._TowardEntityInited)
				{
					return this._TowardEntityCache;
				}
				this._TowardEntityInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int towardEntityLength = this.Instance.TowardEntityLength;
				this._TowardEntityCache = new List<ITowardEntityConfig>(towardEntityLength);
				for (int i = 0; i < towardEntityLength; i++)
				{
					this._TowardEntityCache.Add(ITowardEntityConfig.Create(this.Instance.TowardEntity(i)));
				}
				return this._TowardEntityCache;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06004E58 RID: 20056 RVA: 0x000C26CA File Offset: 0x000C08CA
		public virtual ILevelPrefabParamsConfig PrefabParams
		{
			get
			{
				if (this._PrefabParamsInited)
				{
					return this._PrefabParamsCache;
				}
				this._PrefabParamsInited = true;
				this._PrefabParamsCache = ILevelPrefabParamsConfig.Create(this.Instance.PrefabParams);
				return this._PrefabParamsCache;
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x000C2700 File Offset: 0x000C0900
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPrefabCompTransform> CompTransform
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._CompTransformInited)
				{
					return this._CompTransformCache;
				}
				this._CompTransformInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int compTransformLength = this.Instance.CompTransformLength;
				this._CompTransformCache = new List<IPrefabCompTransform>(compTransformLength);
				for (int i = 0; i < compTransformLength; i++)
				{
					this._CompTransformCache.Add(IPrefabCompTransform.Create(this.Instance.CompTransform(i)));
				}
				return this._CompTransformCache;
			}
		}

		// Token: 0x04002CF1 RID: 11505
		private ILevelPrefabPerformComponent Instance;

		// Token: 0x04002CF2 RID: 11506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITowardEntityConfig> _TowardEntityCache;

		// Token: 0x04002CF3 RID: 11507
		private bool _TowardEntityInited;

		// Token: 0x04002CF4 RID: 11508
		private ILevelPrefabParamsConfig _PrefabParamsCache;

		// Token: 0x04002CF5 RID: 11509
		private bool _PrefabParamsInited;

		// Token: 0x04002CF6 RID: 11510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPrefabCompTransform> _CompTransformCache;

		// Token: 0x04002CF7 RID: 11511
		private bool _CompTransformInited;
	}
}

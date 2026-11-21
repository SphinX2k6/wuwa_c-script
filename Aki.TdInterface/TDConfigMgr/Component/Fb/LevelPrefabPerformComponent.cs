using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E6E RID: 3694
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelPrefabPerformComponent : IComponentBase
	{
		// Token: 0x06005379 RID: 21369 RVA: 0x000CDE2E File Offset: 0x000CC02E
		[NullableContext(0)]
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

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x000CDE50 File Offset: 0x000CC050
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

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x000CDE88 File Offset: 0x000CC088
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x000CDEA0 File Offset: 0x000CC0A0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITowardEntityConfig> TowardEntity
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x000CDF1A File Offset: 0x000CC11A
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

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x000CDF50 File Offset: 0x000CC150
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPrefabCompTransform> CompTransform
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002FB7 RID: 12215
		private ILevelPrefabPerformComponent Instance;

		// Token: 0x04002FB8 RID: 12216
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITowardEntityConfig> _TowardEntityCache;

		// Token: 0x04002FB9 RID: 12217
		private bool _TowardEntityInited;

		// Token: 0x04002FBA RID: 12218
		private ILevelPrefabParamsConfig _PrefabParamsCache;

		// Token: 0x04002FBB RID: 12219
		private bool _PrefabParamsInited;

		// Token: 0x04002FBC RID: 12220
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPrefabCompTransform> _CompTransformCache;

		// Token: 0x04002FBD RID: 12221
		private bool _CompTransformInited;
	}
}

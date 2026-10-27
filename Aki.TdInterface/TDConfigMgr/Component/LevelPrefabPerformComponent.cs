using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000825 RID: 2085
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPrefabPerformComponent : IComponentBase
	{
		// Token: 0x06002D5D RID: 11613 RVA: 0x00075810 File Offset: 0x00073A10
		private LevelPrefabPerformComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevelPrefabPerformComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevelPrefabPerformComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevelPrefabPerformComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00075848 File Offset: 0x00073A48
		public static LevelPrefabPerformComponent Create([Nullable(2)] LevelPrefabPerformComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelPrefabPerformComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x0007585B File Offset: 0x00073A5B
		public static LevelPrefabPerformComponent CreateFromSetValue([Nullable(2)] LevelPrefabPerformComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevelPrefabPerformComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00075870 File Offset: 0x00073A70
		public new LevelPrefabPerformComponent_SetValue ToSetValue()
		{
			return new LevelPrefabPerformComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TowardEntity = this.TowardEntity,
				PrefabParams = this.PrefabParams,
				CompTransform = this.CompTransform
			};
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000758C0 File Offset: 0x00073AC0
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x000758FA File Offset: 0x00073AFA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevelPrefabPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00075908 File Offset: 0x00073B08
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x00075932 File Offset: 0x00073B32
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00075940 File Offset: 0x00073B40
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000759D3 File Offset: 0x00073BD3
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
				if (this.FbInstance != null)
				{
					List<ITowardEntityConfig> towardEntity = this.FbInstance.TowardEntity;
					if (towardEntity != null)
					{
						this._TowardEntityCache = new List<ITowardEntityConfig>(towardEntity.Count);
						for (int i = 0; i < towardEntity.Count; i++)
						{
							this._TowardEntityCache.Add(ITowardEntityConfig.Create(towardEntity[i]));
						}
					}
				}
				else
				{
					LevelPrefabPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._TowardEntityCache = ((pocoInterface != null) ? pocoInterface.TowardEntity : null);
				}
				return this._TowardEntityCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().TowardEntity = value;
				this._TowardEntityInited = false;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000759E8 File Offset: 0x00073BE8
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00075A49 File Offset: 0x00073C49
		[Nullable(2)]
		public virtual ILevelPrefabParamsConfig PrefabParams
		{
			[NullableContext(2)]
			get
			{
				if (this._PrefabParamsInited)
				{
					return this._PrefabParamsCache;
				}
				this._PrefabParamsInited = true;
				if (this.FbInstance != null)
				{
					this._PrefabParamsCache = ILevelPrefabParamsConfig.Create(this.FbInstance.PrefabParams);
				}
				else
				{
					LevelPrefabPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._PrefabParamsCache = ((pocoInterface != null) ? pocoInterface.PrefabParams : null);
				}
				return this._PrefabParamsCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PrefabParams = value;
				this._PrefabParamsInited = false;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00075A60 File Offset: 0x00073C60
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00075AF3 File Offset: 0x00073CF3
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
				if (this.FbInstance != null)
				{
					List<IPrefabCompTransform> compTransform = this.FbInstance.CompTransform;
					if (compTransform != null)
					{
						this._CompTransformCache = new List<IPrefabCompTransform>(compTransform.Count);
						for (int i = 0; i < compTransform.Count; i++)
						{
							this._CompTransformCache.Add(IPrefabCompTransform.Create(compTransform[i]));
						}
					}
				}
				else
				{
					LevelPrefabPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._CompTransformCache = ((pocoInterface != null) ? pocoInterface.CompTransform : null);
				}
				return this._CompTransformCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().CompTransform = value;
				this._CompTransformInited = false;
			}
		}

		// Token: 0x04001E04 RID: 7684
		[Nullable(2)]
		protected new LevelPrefabPerformComponent FbInstance;

		// Token: 0x04001E05 RID: 7685
		[Nullable(2)]
		protected new LevelPrefabPerformComponent_SetValue PocoInterface;

		// Token: 0x04001E06 RID: 7686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITowardEntityConfig> _TowardEntityCache;

		// Token: 0x04001E07 RID: 7687
		private bool _TowardEntityInited;

		// Token: 0x04001E08 RID: 7688
		private ILevelPrefabParamsConfig _PrefabParamsCache;

		// Token: 0x04001E09 RID: 7689
		private bool _PrefabParamsInited;

		// Token: 0x04001E0A RID: 7690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPrefabCompTransform> _CompTransformCache;

		// Token: 0x04001E0B RID: 7691
		private bool _CompTransformInited;
	}
}

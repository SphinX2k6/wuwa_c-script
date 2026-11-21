using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C8 RID: 2248
	public class LevelPrefabPerformComponent : IComponentBase
	{
		// Token: 0x0600308D RID: 12429 RVA: 0x0007CB74 File Offset: 0x0007AD74
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

		// Token: 0x0600308E RID: 12430 RVA: 0x0007CBAC File Offset: 0x0007ADAC
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

		// Token: 0x0600308F RID: 12431 RVA: 0x0007CBBF File Offset: 0x0007ADBF
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

		// Token: 0x06003090 RID: 12432 RVA: 0x0007CBD4 File Offset: 0x0007ADD4
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0007CC24 File Offset: 0x0007AE24
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x0007CC5E File Offset: 0x0007AE5E
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0007CC6C File Offset: 0x0007AE6C
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x0007CC96 File Offset: 0x0007AE96
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x0007CCA4 File Offset: 0x0007AEA4
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x0007CD37 File Offset: 0x0007AF37
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().TowardEntity = value;
				this._TowardEntityInited = false;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x0007CD4C File Offset: 0x0007AF4C
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x0007CDAD File Offset: 0x0007AFAD
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x0007CE57 File Offset: 0x0007B057
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().CompTransform = value;
				this._CompTransformInited = false;
			}
		}

		// Token: 0x04002010 RID: 8208
		[Nullable(2)]
		protected new LevelPrefabPerformComponent FbInstance;

		// Token: 0x04002011 RID: 8209
		[Nullable(2)]
		protected new LevelPrefabPerformComponent_SetValue PocoInterface;

		// Token: 0x04002012 RID: 8210
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITowardEntityConfig> _TowardEntityCache;

		// Token: 0x04002013 RID: 8211
		private bool _TowardEntityInited;

		// Token: 0x04002014 RID: 8212
		private ILevelPrefabParamsConfig _PrefabParamsCache;

		// Token: 0x04002015 RID: 8213
		private bool _PrefabParamsInited;

		// Token: 0x04002016 RID: 8214
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPrefabCompTransform> _CompTransformCache;

		// Token: 0x04002017 RID: 8215
		private bool _CompTransformInited;
	}
}

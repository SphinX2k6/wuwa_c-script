using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000275 RID: 629
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceInitiator
	{
		// Token: 0x06000B7D RID: 2941 RVA: 0x0002E034 File Offset: 0x0002C234
		private IConnectorPathAdvanceInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002E06C File Offset: 0x0002C26C
		public static IConnectorPathAdvanceInitiator Create([Nullable(2)] IConnectorPathAdvanceInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0002E07F File Offset: 0x0002C27F
		public static IConnectorPathAdvanceInitiator CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002E094 File Offset: 0x0002C294
		public IConnectorPathAdvanceInitiator_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceInitiator_SetValue
			{
				ActiveState = this.ActiveState,
				Paths = this.Paths,
				TargetEntity = this.TargetEntity,
				AdvanceSpeed = this.AdvanceSpeed,
				VisualType = this.VisualType,
				VisualConfig = this.VisualConfig,
				KeepConditions = this.KeepConditions
			};
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0002E0FA File Offset: 0x0002C2FA
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0002E125 File Offset: 0x0002C325
		public virtual string ActiveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActiveState;
			}
			set
			{
				this.GetOrCreatePoco().ActiveState = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002E133 File Offset: 0x0002C333
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0002E15A File Offset: 0x0002C35A
		public virtual List<int> Paths
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Paths;
				}
				IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Paths;
			}
			set
			{
				this.GetOrCreatePoco().Paths = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002E168 File Offset: 0x0002C368
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0002E193 File Offset: 0x0002C393
		public virtual int TargetEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntity = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002E1A1 File Offset: 0x0002C3A1
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public virtual float AdvanceSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AdvanceSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AdvanceSpeed;
			}
			set
			{
				this.GetOrCreatePoco().AdvanceSpeed = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002E1DE File Offset: 0x0002C3DE
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0002E209 File Offset: 0x0002C409
		public virtual EConnectorPathAdvanceVisualType VisualType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualType;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return this.PocoInterface.VisualType;
			}
			set
			{
				this.GetOrCreatePoco().VisualType = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002E218 File Offset: 0x0002C418
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0002E279 File Offset: 0x0002C479
		[Nullable(2)]
		public virtual IConnectorPathAdvanceVasePlantVisual VisualConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._VisualConfigInited)
				{
					return this._VisualConfigCache;
				}
				this._VisualConfigInited = true;
				if (this.FbInstance != null)
				{
					this._VisualConfigCache = IConnectorPathAdvanceVasePlantVisual.Create(this.FbInstance.VisualConfig);
				}
				else
				{
					IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
					this._VisualConfigCache = ((pocoInterface != null) ? pocoInterface.VisualConfig : null);
				}
				return this._VisualConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VisualConfig = value;
				this._VisualConfigInited = false;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002E290 File Offset: 0x0002C490
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0002E323 File Offset: 0x0002C523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._KeepConditionsInited)
				{
					return this._KeepConditionsCache;
				}
				this._KeepConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IDynamicEntityMatch> keepConditions = this.FbInstance.KeepConditions;
					if (keepConditions != null)
					{
						this._KeepConditionsCache = new List<IDynamicEntityMatch>(keepConditions.Count);
						for (int i = 0; i < keepConditions.Count; i++)
						{
							this._KeepConditionsCache.Add(IDynamicEntityMatch.Create(keepConditions[i]));
						}
					}
				}
				else
				{
					IConnectorPathAdvanceInitiator_SetValue pocoInterface = this.PocoInterface;
					this._KeepConditionsCache = ((pocoInterface != null) ? pocoInterface.KeepConditions : null);
				}
				return this._KeepConditionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().KeepConditions = value;
				this._KeepConditionsInited = false;
			}
		}

		// Token: 0x04000B17 RID: 2839
		[Nullable(2)]
		protected IConnectorPathAdvanceInitiator FbInstance;

		// Token: 0x04000B18 RID: 2840
		[Nullable(2)]
		protected IConnectorPathAdvanceInitiator_SetValue PocoInterface;

		// Token: 0x04000B19 RID: 2841
		private IConnectorPathAdvanceVasePlantVisual _VisualConfigCache;

		// Token: 0x04000B1A RID: 2842
		private bool _VisualConfigInited;

		// Token: 0x04000B1B RID: 2843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000B1C RID: 2844
		private bool _KeepConditionsInited;
	}
}

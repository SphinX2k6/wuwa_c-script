using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000849 RID: 2121
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent : IComponentBase
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x000784C0 File Offset: 0x000766C0
		[NullableContext(1)]
		private NpcPerformComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NpcPerformComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NpcPerformComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NpcPerformComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000784F8 File Offset: 0x000766F8
		[NullableContext(1)]
		public static NpcPerformComponent Create([Nullable(2)] NpcPerformComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NpcPerformComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x0007850B File Offset: 0x0007670B
		[NullableContext(1)]
		public static NpcPerformComponent CreateFromSetValue([Nullable(2)] NpcPerformComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NpcPerformComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00078520 File Offset: 0x00076720
		[NullableContext(1)]
		public new NpcPerformComponent_SetValue ToSetValue()
		{
			return new NpcPerformComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SpecialNpcPerformConfig = this.SpecialNpcPerformConfig,
				IsStare = this.IsStare,
				NpcHitShow = this.NpcHitShow,
				IsShowStrike = this.IsShowStrike,
				NpcBumpShow = this.NpcBumpShow,
				ShowOnAwake = this.ShowOnAwake,
				ShowOnStandby = this.ShowOnStandby,
				ShowOnInteract = this.ShowOnInteract,
				ConditionalShowOnInteracts = this.ConditionalShowOnInteracts,
				ShowOnUiInteract = this.ShowOnUiInteract,
				ShowOnRideInVehicle = this.ShowOnRideInVehicle,
				NpcMonsterClosePerform = this.NpcMonsterClosePerform,
				NpcPerformState = this.NpcPerformState,
				DeathInteract = this.DeathInteract,
				FixedPosition = this.FixedPosition,
				DefaultAbpState = this.DefaultAbpState,
				DefaultFaceExpressionId = this.DefaultFaceExpressionId,
				DefaultPerform = this.DefaultPerform,
				NpcSpecialMarks = this.NpcSpecialMarks
			};
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00078630 File Offset: 0x00076830
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x0007866A File Offset: 0x0007686A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00078678 File Offset: 0x00076878
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x000786A2 File Offset: 0x000768A2
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000786B0 File Offset: 0x000768B0
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x00078711 File Offset: 0x00076911
		public virtual IBaseRoleNpcPerform SpecialNpcPerformConfig
		{
			get
			{
				if (this._SpecialNpcPerformConfigInited)
				{
					return this._SpecialNpcPerformConfigCache;
				}
				this._SpecialNpcPerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SpecialNpcPerformConfigCache = IBaseRoleNpcPerform.Create(this.FbInstance.SpecialNpcPerformConfig);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._SpecialNpcPerformConfigCache = ((pocoInterface != null) ? pocoInterface.SpecialNpcPerformConfig : null);
				}
				return this._SpecialNpcPerformConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SpecialNpcPerformConfig = value;
				this._SpecialNpcPerformConfigInited = false;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00078726 File Offset: 0x00076926
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00078751 File Offset: 0x00076951
		public virtual bool IsStare
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsStare;
				}
				return this.PocoInterface != null && this.PocoInterface.IsStare;
			}
			set
			{
				this.GetOrCreatePoco().IsStare = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00078760 File Offset: 0x00076960
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x000787C1 File Offset: 0x000769C1
		public virtual INpcHitShow NpcHitShow
		{
			get
			{
				if (this._NpcHitShowInited)
				{
					return this._NpcHitShowCache;
				}
				this._NpcHitShowInited = true;
				if (this.FbInstance != null)
				{
					this._NpcHitShowCache = INpcHitShow.Create(this.FbInstance.NpcHitShow);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._NpcHitShowCache = ((pocoInterface != null) ? pocoInterface.NpcHitShow : null);
				}
				return this._NpcHitShowCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcHitShow = value;
				this._NpcHitShowInited = false;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x000787D6 File Offset: 0x000769D6
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00078801 File Offset: 0x00076A01
		public virtual bool IsShowStrike
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsShowStrike;
				}
				return this.PocoInterface != null && this.PocoInterface.IsShowStrike;
			}
			set
			{
				this.GetOrCreatePoco().IsShowStrike = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00078810 File Offset: 0x00076A10
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x00078871 File Offset: 0x00076A71
		public virtual INpcBumpShow NpcBumpShow
		{
			get
			{
				if (this._NpcBumpShowInited)
				{
					return this._NpcBumpShowCache;
				}
				this._NpcBumpShowInited = true;
				if (this.FbInstance != null)
				{
					this._NpcBumpShowCache = INpcBumpShow.Create(this.FbInstance.NpcBumpShow);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._NpcBumpShowCache = ((pocoInterface != null) ? pocoInterface.NpcBumpShow : null);
				}
				return this._NpcBumpShowCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcBumpShow = value;
				this._NpcBumpShowInited = false;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00078888 File Offset: 0x00076A88
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x000788E9 File Offset: 0x00076AE9
		public virtual INpcAwakeShow ShowOnAwake
		{
			get
			{
				if (this._ShowOnAwakeInited)
				{
					return this._ShowOnAwakeCache;
				}
				this._ShowOnAwakeInited = true;
				if (this.FbInstance != null)
				{
					this._ShowOnAwakeCache = INpcAwakeShow.Create(this.FbInstance.ShowOnAwake);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._ShowOnAwakeCache = ((pocoInterface != null) ? pocoInterface.ShowOnAwake : null);
				}
				return this._ShowOnAwakeCache;
			}
			set
			{
				this.GetOrCreatePoco().ShowOnAwake = value;
				this._ShowOnAwakeInited = false;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x000788FE File Offset: 0x00076AFE
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00078925 File Offset: 0x00076B25
		public virtual INpcStandbyShowMode ShowOnStandby
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowOnStandby;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowOnStandby;
			}
			set
			{
				this.GetOrCreatePoco().ShowOnStandby = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00078934 File Offset: 0x00076B34
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x00078995 File Offset: 0x00076B95
		public virtual INpcPerformOnInteract ShowOnInteract
		{
			get
			{
				if (this._ShowOnInteractInited)
				{
					return this._ShowOnInteractCache;
				}
				this._ShowOnInteractInited = true;
				if (this.FbInstance != null)
				{
					this._ShowOnInteractCache = INpcPerformOnInteract.Create(this.FbInstance.ShowOnInteract);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._ShowOnInteractCache = ((pocoInterface != null) ? pocoInterface.ShowOnInteract : null);
				}
				return this._ShowOnInteractCache;
			}
			set
			{
				this.GetOrCreatePoco().ShowOnInteract = value;
				this._ShowOnInteractInited = false;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x000789AC File Offset: 0x00076BAC
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00078A3F File Offset: 0x00076C3F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IConditionalNpcPerformOnInteract> ConditionalShowOnInteracts
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ConditionalShowOnInteractsInited)
				{
					return this._ConditionalShowOnInteractsCache;
				}
				this._ConditionalShowOnInteractsInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionalNpcPerformOnInteract> conditionalShowOnInteracts = this.FbInstance.ConditionalShowOnInteracts;
					if (conditionalShowOnInteracts != null)
					{
						this._ConditionalShowOnInteractsCache = new List<IConditionalNpcPerformOnInteract>(conditionalShowOnInteracts.Count);
						for (int i = 0; i < conditionalShowOnInteracts.Count; i++)
						{
							this._ConditionalShowOnInteractsCache.Add(IConditionalNpcPerformOnInteract.Create(conditionalShowOnInteracts[i]));
						}
					}
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._ConditionalShowOnInteractsCache = ((pocoInterface != null) ? pocoInterface.ConditionalShowOnInteracts : null);
				}
				return this._ConditionalShowOnInteractsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ConditionalShowOnInteracts = value;
				this._ConditionalShowOnInteractsInited = false;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00078A54 File Offset: 0x00076C54
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00078A7B File Offset: 0x00076C7B
		public virtual INpcUiInteractType ShowOnUiInteract
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowOnUiInteract;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowOnUiInteract;
			}
			set
			{
				this.GetOrCreatePoco().ShowOnUiInteract = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00078A89 File Offset: 0x00076C89
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00078AB0 File Offset: 0x00076CB0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<INpcRideInVehiclePerformType> ShowOnRideInVehicle
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
					return this.FbInstance.ShowOnRideInVehicle;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowOnRideInVehicle;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ShowOnRideInVehicle = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00078AC0 File Offset: 0x00076CC0
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00078B21 File Offset: 0x00076D21
		public virtual INpcPerformOnMonsterCloseby NpcMonsterClosePerform
		{
			get
			{
				if (this._NpcMonsterClosePerformInited)
				{
					return this._NpcMonsterClosePerformCache;
				}
				this._NpcMonsterClosePerformInited = true;
				if (this.FbInstance != null)
				{
					this._NpcMonsterClosePerformCache = INpcPerformOnMonsterCloseby.Create(this.FbInstance.NpcMonsterClosePerform);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._NpcMonsterClosePerformCache = ((pocoInterface != null) ? pocoInterface.NpcMonsterClosePerform : null);
				}
				return this._NpcMonsterClosePerformCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcMonsterClosePerform = value;
				this._NpcMonsterClosePerformInited = false;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x00078B38 File Offset: 0x00076D38
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00078B99 File Offset: 0x00076D99
		public virtual INpcPerformState NpcPerformState
		{
			get
			{
				if (this._NpcPerformStateInited)
				{
					return this._NpcPerformStateCache;
				}
				this._NpcPerformStateInited = true;
				if (this.FbInstance != null)
				{
					this._NpcPerformStateCache = INpcPerformState.Create(this.FbInstance.NpcPerformState);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._NpcPerformStateCache = ((pocoInterface != null) ? pocoInterface.NpcPerformState : null);
				}
				return this._NpcPerformStateCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcPerformState = value;
				this._NpcPerformStateInited = false;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00078BB0 File Offset: 0x00076DB0
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00078C11 File Offset: 0x00076E11
		public virtual INpcDeathInteract DeathInteract
		{
			get
			{
				if (this._DeathInteractInited)
				{
					return this._DeathInteractCache;
				}
				this._DeathInteractInited = true;
				if (this.FbInstance != null)
				{
					this._DeathInteractCache = INpcDeathInteract.Create(this.FbInstance.DeathInteract);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._DeathInteractCache = ((pocoInterface != null) ? pocoInterface.DeathInteract : null);
				}
				return this._DeathInteractCache;
			}
			set
			{
				this.GetOrCreatePoco().DeathInteract = value;
				this._DeathInteractInited = false;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00078C28 File Offset: 0x00076E28
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00078C62 File Offset: 0x00076E62
		public virtual bool? FixedPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FixedPosition;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FixedPosition;
			}
			set
			{
				this.GetOrCreatePoco().FixedPosition = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00078C70 File Offset: 0x00076E70
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00078C97 File Offset: 0x00076E97
		public virtual string DefaultAbpState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultAbpState;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DefaultAbpState;
			}
			set
			{
				this.GetOrCreatePoco().DefaultAbpState = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00078CA8 File Offset: 0x00076EA8
		// (set) Token: 0x06002EBA RID: 11962 RVA: 0x00078CE2 File Offset: 0x00076EE2
		public virtual int? DefaultFaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultFaceExpressionId;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DefaultFaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().DefaultFaceExpressionId = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00078CF0 File Offset: 0x00076EF0
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x00078D51 File Offset: 0x00076F51
		public virtual INpcDefaultPerform DefaultPerform
		{
			get
			{
				if (this._DefaultPerformInited)
				{
					return this._DefaultPerformCache;
				}
				this._DefaultPerformInited = true;
				if (this.FbInstance != null)
				{
					this._DefaultPerformCache = INpcDefaultPerform.Create(this.FbInstance.DefaultPerform);
				}
				else
				{
					NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._DefaultPerformCache = ((pocoInterface != null) ? pocoInterface.DefaultPerform : null);
				}
				return this._DefaultPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().DefaultPerform = value;
				this._DefaultPerformInited = false;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00078D66 File Offset: 0x00076F66
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00078D8D File Offset: 0x00076F8D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<INpcSpecialMarkBase> NpcSpecialMarks
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
					return this.FbInstance.NpcSpecialMarks;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NpcSpecialMarks;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().NpcSpecialMarks = value;
			}
		}

		// Token: 0x04001EB8 RID: 7864
		protected new NpcPerformComponent FbInstance;

		// Token: 0x04001EB9 RID: 7865
		protected new NpcPerformComponent_SetValue PocoInterface;

		// Token: 0x04001EBA RID: 7866
		[Nullable(1)]
		private IBaseRoleNpcPerform _SpecialNpcPerformConfigCache;

		// Token: 0x04001EBB RID: 7867
		private bool _SpecialNpcPerformConfigInited;

		// Token: 0x04001EBC RID: 7868
		[Nullable(1)]
		private INpcHitShow _NpcHitShowCache;

		// Token: 0x04001EBD RID: 7869
		private bool _NpcHitShowInited;

		// Token: 0x04001EBE RID: 7870
		[Nullable(1)]
		private INpcBumpShow _NpcBumpShowCache;

		// Token: 0x04001EBF RID: 7871
		private bool _NpcBumpShowInited;

		// Token: 0x04001EC0 RID: 7872
		[Nullable(1)]
		private INpcAwakeShow _ShowOnAwakeCache;

		// Token: 0x04001EC1 RID: 7873
		private bool _ShowOnAwakeInited;

		// Token: 0x04001EC2 RID: 7874
		[Nullable(1)]
		private INpcPerformOnInteract _ShowOnInteractCache;

		// Token: 0x04001EC3 RID: 7875
		private bool _ShowOnInteractInited;

		// Token: 0x04001EC4 RID: 7876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionalNpcPerformOnInteract> _ConditionalShowOnInteractsCache;

		// Token: 0x04001EC5 RID: 7877
		private bool _ConditionalShowOnInteractsInited;

		// Token: 0x04001EC6 RID: 7878
		[Nullable(1)]
		private INpcPerformOnMonsterCloseby _NpcMonsterClosePerformCache;

		// Token: 0x04001EC7 RID: 7879
		private bool _NpcMonsterClosePerformInited;

		// Token: 0x04001EC8 RID: 7880
		[Nullable(1)]
		private INpcPerformState _NpcPerformStateCache;

		// Token: 0x04001EC9 RID: 7881
		private bool _NpcPerformStateInited;

		// Token: 0x04001ECA RID: 7882
		[Nullable(1)]
		private INpcDeathInteract _DeathInteractCache;

		// Token: 0x04001ECB RID: 7883
		private bool _DeathInteractInited;

		// Token: 0x04001ECC RID: 7884
		[Nullable(1)]
		private INpcDefaultPerform _DefaultPerformCache;

		// Token: 0x04001ECD RID: 7885
		private bool _DefaultPerformInited;
	}
}

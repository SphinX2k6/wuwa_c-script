using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EC RID: 2284
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent : IComponentBase
	{
		// Token: 0x060031C7 RID: 12743 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		[NullableContext(0)]
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

		// Token: 0x060031C8 RID: 12744 RVA: 0x0007F91C File Offset: 0x0007DB1C
		[NullableContext(0)]
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

		// Token: 0x060031C9 RID: 12745 RVA: 0x0007F92F File Offset: 0x0007DB2F
		[NullableContext(0)]
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

		// Token: 0x060031CA RID: 12746 RVA: 0x0007F944 File Offset: 0x0007DB44
		[NullableContext(0)]
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
				NpcSpecialMarks = this.NpcSpecialMarks,
				ExtraMovementAbilities = this.ExtraMovementAbilities
			};
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x0007FA60 File Offset: 0x0007DC60
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x0007FA9A File Offset: 0x0007DC9A
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0007FAA8 File Offset: 0x0007DCA8
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x0007FAD2 File Offset: 0x0007DCD2
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x0007FAE0 File Offset: 0x0007DCE0
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x0007FB41 File Offset: 0x0007DD41
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

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x0007FB56 File Offset: 0x0007DD56
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x0007FB81 File Offset: 0x0007DD81
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

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x0007FB90 File Offset: 0x0007DD90
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x0007FBF1 File Offset: 0x0007DDF1
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x0007FC06 File Offset: 0x0007DE06
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x0007FC31 File Offset: 0x0007DE31
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

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x0007FC40 File Offset: 0x0007DE40
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0007FCA1 File Offset: 0x0007DEA1
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x0007FCB8 File Offset: 0x0007DEB8
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x0007FD19 File Offset: 0x0007DF19
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x0007FD2E File Offset: 0x0007DF2E
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x0007FD55 File Offset: 0x0007DF55
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

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x0007FD64 File Offset: 0x0007DF64
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x0007FDC5 File Offset: 0x0007DFC5
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

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x0007FDDC File Offset: 0x0007DFDC
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x0007FE6F File Offset: 0x0007E06F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IConditionalNpcPerformOnInteract> ConditionalShowOnInteracts
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().ConditionalShowOnInteracts = value;
				this._ConditionalShowOnInteractsInited = false;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0007FE84 File Offset: 0x0007E084
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x0007FEAB File Offset: 0x0007E0AB
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

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0007FEB9 File Offset: 0x0007E0B9
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x0007FEE0 File Offset: 0x0007E0E0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<INpcRideInVehiclePerformType> ShowOnRideInVehicle
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().ShowOnRideInVehicle = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0007FEF0 File Offset: 0x0007E0F0
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x0007FF51 File Offset: 0x0007E151
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0007FF68 File Offset: 0x0007E168
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x0007FFC9 File Offset: 0x0007E1C9
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x0007FFE0 File Offset: 0x0007E1E0
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x00080041 File Offset: 0x0007E241
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

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x00080058 File Offset: 0x0007E258
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x00080092 File Offset: 0x0007E292
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x000800A0 File Offset: 0x0007E2A0
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x000800C7 File Offset: 0x0007E2C7
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x000800D8 File Offset: 0x0007E2D8
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x00080112 File Offset: 0x0007E312
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x00080120 File Offset: 0x0007E320
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x00080181 File Offset: 0x0007E381
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

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x00080196 File Offset: 0x0007E396
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x000801BD File Offset: 0x0007E3BD
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<INpcSpecialMarkBase> NpcSpecialMarks
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().NpcSpecialMarks = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000801CB File Offset: 0x0007E3CB
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x000801F2 File Offset: 0x0007E3F2
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExtraMovementAbilities;
				}
				NpcPerformComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExtraMovementAbilities;
			}
			set
			{
				this.GetOrCreatePoco().ExtraMovementAbilities = value;
			}
		}

		// Token: 0x040020C7 RID: 8391
		protected new NpcPerformComponent FbInstance;

		// Token: 0x040020C8 RID: 8392
		protected new NpcPerformComponent_SetValue PocoInterface;

		// Token: 0x040020C9 RID: 8393
		[Nullable(0)]
		private IBaseRoleNpcPerform _SpecialNpcPerformConfigCache;

		// Token: 0x040020CA RID: 8394
		private bool _SpecialNpcPerformConfigInited;

		// Token: 0x040020CB RID: 8395
		[Nullable(0)]
		private INpcHitShow _NpcHitShowCache;

		// Token: 0x040020CC RID: 8396
		private bool _NpcHitShowInited;

		// Token: 0x040020CD RID: 8397
		[Nullable(0)]
		private INpcBumpShow _NpcBumpShowCache;

		// Token: 0x040020CE RID: 8398
		private bool _NpcBumpShowInited;

		// Token: 0x040020CF RID: 8399
		[Nullable(0)]
		private INpcAwakeShow _ShowOnAwakeCache;

		// Token: 0x040020D0 RID: 8400
		private bool _ShowOnAwakeInited;

		// Token: 0x040020D1 RID: 8401
		[Nullable(0)]
		private INpcPerformOnInteract _ShowOnInteractCache;

		// Token: 0x040020D2 RID: 8402
		private bool _ShowOnInteractInited;

		// Token: 0x040020D3 RID: 8403
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionalNpcPerformOnInteract> _ConditionalShowOnInteractsCache;

		// Token: 0x040020D4 RID: 8404
		private bool _ConditionalShowOnInteractsInited;

		// Token: 0x040020D5 RID: 8405
		[Nullable(0)]
		private INpcPerformOnMonsterCloseby _NpcMonsterClosePerformCache;

		// Token: 0x040020D6 RID: 8406
		private bool _NpcMonsterClosePerformInited;

		// Token: 0x040020D7 RID: 8407
		[Nullable(0)]
		private INpcPerformState _NpcPerformStateCache;

		// Token: 0x040020D8 RID: 8408
		private bool _NpcPerformStateInited;

		// Token: 0x040020D9 RID: 8409
		[Nullable(0)]
		private INpcDeathInteract _DeathInteractCache;

		// Token: 0x040020DA RID: 8410
		private bool _DeathInteractInited;

		// Token: 0x040020DB RID: 8411
		[Nullable(0)]
		private INpcDefaultPerform _DefaultPerformCache;

		// Token: 0x040020DC RID: 8412
		private bool _DefaultPerformInited;
	}
}

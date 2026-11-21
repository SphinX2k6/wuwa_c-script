using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA3 RID: 3235
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent : IComponentBase
	{
		// Token: 0x060049E8 RID: 18920 RVA: 0x000BA1B1 File Offset: 0x000B83B1
		[NullableContext(0)]
		public static NpcPerformComponent Create(INpcPerformComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NpcPerformComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x000BA1D0 File Offset: 0x000B83D0
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000BA208 File Offset: 0x000B8408
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x060049EB RID: 18923 RVA: 0x000BA21E File Offset: 0x000B841E
		public virtual IBaseRoleNpcPerform SpecialNpcPerformConfig
		{
			get
			{
				if (this._SpecialNpcPerformConfigInited)
				{
					return this._SpecialNpcPerformConfigCache;
				}
				this._SpecialNpcPerformConfigInited = true;
				this._SpecialNpcPerformConfigCache = IBaseRoleNpcPerform.Create(this.Instance.SpecialNpcPerformConfig);
				return this._SpecialNpcPerformConfigCache;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x000BA252 File Offset: 0x000B8452
		public virtual bool IsStare
		{
			get
			{
				return this.Instance.IsStare;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x000BA25F File Offset: 0x000B845F
		public virtual INpcHitShow NpcHitShow
		{
			get
			{
				if (this._NpcHitShowInited)
				{
					return this._NpcHitShowCache;
				}
				this._NpcHitShowInited = true;
				this._NpcHitShowCache = INpcHitShow.Create(this.Instance.NpcHitShow);
				return this._NpcHitShowCache;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x000BA293 File Offset: 0x000B8493
		public virtual bool IsShowStrike
		{
			get
			{
				return this.Instance.IsShowStrike;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x000BA2A0 File Offset: 0x000B84A0
		public virtual INpcBumpShow NpcBumpShow
		{
			get
			{
				if (this._NpcBumpShowInited)
				{
					return this._NpcBumpShowCache;
				}
				this._NpcBumpShowInited = true;
				this._NpcBumpShowCache = INpcBumpShow.Create(this.Instance.NpcBumpShow);
				return this._NpcBumpShowCache;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x000BA2D4 File Offset: 0x000B84D4
		public virtual INpcAwakeShow ShowOnAwake
		{
			get
			{
				if (this._ShowOnAwakeInited)
				{
					return this._ShowOnAwakeCache;
				}
				this._ShowOnAwakeInited = true;
				this._ShowOnAwakeCache = INpcAwakeShow.Create(this.Instance.ShowOnAwake);
				return this._ShowOnAwakeCache;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x000BA308 File Offset: 0x000B8508
		[Nullable(0)]
		public virtual INpcStandbyShowMode ShowOnStandby
		{
			[NullableContext(0)]
			get
			{
				if (this._ShowOnStandbyInited)
				{
					return this._ShowOnStandbyCache;
				}
				this._ShowOnStandbyInited = true;
				this._ShowOnStandbyCache = ComponentReadHelper.ReadNpcPerformComponent_ShowOnStandby(this.Instance);
				return this._ShowOnStandbyCache;
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x000BA337 File Offset: 0x000B8537
		public virtual INpcPerformOnInteract ShowOnInteract
		{
			get
			{
				if (this._ShowOnInteractInited)
				{
					return this._ShowOnInteractCache;
				}
				this._ShowOnInteractInited = true;
				this._ShowOnInteractCache = INpcPerformOnInteract.Create(this.Instance.ShowOnInteract);
				return this._ShowOnInteractCache;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x000BA36C File Offset: 0x000B856C
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int conditionalShowOnInteractsLength = this.Instance.ConditionalShowOnInteractsLength;
				this._ConditionalShowOnInteractsCache = new List<IConditionalNpcPerformOnInteract>(conditionalShowOnInteractsLength);
				for (int i = 0; i < conditionalShowOnInteractsLength; i++)
				{
					this._ConditionalShowOnInteractsCache.Add(IConditionalNpcPerformOnInteract.Create(this.Instance.ConditionalShowOnInteracts(i)));
				}
				return this._ConditionalShowOnInteractsCache;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x000BA3E6 File Offset: 0x000B85E6
		[Nullable(0)]
		public virtual INpcUiInteractType ShowOnUiInteract
		{
			[NullableContext(0)]
			get
			{
				if (this._ShowOnUiInteractInited)
				{
					return this._ShowOnUiInteractCache;
				}
				this._ShowOnUiInteractInited = true;
				this._ShowOnUiInteractCache = ComponentReadHelper.ReadNpcPerformComponent_ShowOnUiInteract(this.Instance);
				return this._ShowOnUiInteractCache;
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x000BA415 File Offset: 0x000B8615
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
				if (this._ShowOnRideInVehicleInited)
				{
					return this._ShowOnRideInVehicleCache;
				}
				this._ShowOnRideInVehicleInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				this._ShowOnRideInVehicleCache = ComponentReadHelper.ReadNpcPerformComponent_ShowOnRideInVehicle(this.Instance);
				return this._ShowOnRideInVehicleCache;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x000BA455 File Offset: 0x000B8655
		public virtual INpcPerformOnMonsterCloseby NpcMonsterClosePerform
		{
			get
			{
				if (this._NpcMonsterClosePerformInited)
				{
					return this._NpcMonsterClosePerformCache;
				}
				this._NpcMonsterClosePerformInited = true;
				this._NpcMonsterClosePerformCache = INpcPerformOnMonsterCloseby.Create(this.Instance.NpcMonsterClosePerform);
				return this._NpcMonsterClosePerformCache;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x000BA489 File Offset: 0x000B8689
		public virtual INpcPerformState NpcPerformState
		{
			get
			{
				if (this._NpcPerformStateInited)
				{
					return this._NpcPerformStateCache;
				}
				this._NpcPerformStateInited = true;
				this._NpcPerformStateCache = INpcPerformState.Create(this.Instance.NpcPerformState);
				return this._NpcPerformStateCache;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x000BA4BD File Offset: 0x000B86BD
		public virtual INpcDeathInteract DeathInteract
		{
			get
			{
				if (this._DeathInteractInited)
				{
					return this._DeathInteractCache;
				}
				this._DeathInteractInited = true;
				this._DeathInteractCache = INpcDeathInteract.Create(this.Instance.DeathInteract);
				return this._DeathInteractCache;
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x000BA4F4 File Offset: 0x000B86F4
		public virtual bool? FixedPosition
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.FixedPosition);
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x060049FA RID: 18938 RVA: 0x000BA52A File Offset: 0x000B872A
		public virtual string DefaultAbpState
		{
			get
			{
				return this.Instance.DefaultAbpState;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x000BA538 File Offset: 0x000B8738
		public virtual int? DefaultFaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DefaultFaceExpressionId);
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x000BA56F File Offset: 0x000B876F
		public virtual INpcDefaultPerform DefaultPerform
		{
			get
			{
				if (this._DefaultPerformInited)
				{
					return this._DefaultPerformCache;
				}
				this._DefaultPerformInited = true;
				this._DefaultPerformCache = INpcDefaultPerform.Create(this.Instance.DefaultPerform);
				return this._DefaultPerformCache;
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x000BA5A4 File Offset: 0x000B87A4
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
				if (this._NpcSpecialMarksInited)
				{
					return this._NpcSpecialMarksCache;
				}
				this._NpcSpecialMarksInited = true;
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				this._NpcSpecialMarksCache = ComponentReadHelper.ReadNpcPerformComponent_NpcSpecialMarks(this.Instance);
				return this._NpcSpecialMarksCache;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x000BA5F0 File Offset: 0x000B87F0
		public virtual List<EExtraMovementAbility> ExtraMovementAbilities
		{
			get
			{
				if (this._ExtraMovementAbilitiesInited)
				{
					return this._ExtraMovementAbilitiesCache;
				}
				this._ExtraMovementAbilitiesInited = true;
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				int extraMovementAbilitiesLength = this.Instance.ExtraMovementAbilitiesLength;
				this._ExtraMovementAbilitiesCache = new List<EExtraMovementAbility>(extraMovementAbilitiesLength);
				for (int i = 0; i < extraMovementAbilitiesLength; i++)
				{
					this._ExtraMovementAbilitiesCache.Add((EExtraMovementAbility)this.Instance.ExtraMovementAbilities(i));
				}
				return this._ExtraMovementAbilitiesCache;
			}
		}

		// Token: 0x040029DA RID: 10714
		private INpcPerformComponent Instance;

		// Token: 0x040029DB RID: 10715
		private IBaseRoleNpcPerform _SpecialNpcPerformConfigCache;

		// Token: 0x040029DC RID: 10716
		private bool _SpecialNpcPerformConfigInited;

		// Token: 0x040029DD RID: 10717
		private INpcHitShow _NpcHitShowCache;

		// Token: 0x040029DE RID: 10718
		private bool _NpcHitShowInited;

		// Token: 0x040029DF RID: 10719
		private INpcBumpShow _NpcBumpShowCache;

		// Token: 0x040029E0 RID: 10720
		private bool _NpcBumpShowInited;

		// Token: 0x040029E1 RID: 10721
		private INpcAwakeShow _ShowOnAwakeCache;

		// Token: 0x040029E2 RID: 10722
		private bool _ShowOnAwakeInited;

		// Token: 0x040029E3 RID: 10723
		[Nullable(0)]
		private INpcStandbyShowMode _ShowOnStandbyCache;

		// Token: 0x040029E4 RID: 10724
		private bool _ShowOnStandbyInited;

		// Token: 0x040029E5 RID: 10725
		private INpcPerformOnInteract _ShowOnInteractCache;

		// Token: 0x040029E6 RID: 10726
		private bool _ShowOnInteractInited;

		// Token: 0x040029E7 RID: 10727
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionalNpcPerformOnInteract> _ConditionalShowOnInteractsCache;

		// Token: 0x040029E8 RID: 10728
		private bool _ConditionalShowOnInteractsInited;

		// Token: 0x040029E9 RID: 10729
		[Nullable(0)]
		private INpcUiInteractType _ShowOnUiInteractCache;

		// Token: 0x040029EA RID: 10730
		private bool _ShowOnUiInteractInited;

		// Token: 0x040029EB RID: 10731
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcRideInVehiclePerformType> _ShowOnRideInVehicleCache;

		// Token: 0x040029EC RID: 10732
		private bool _ShowOnRideInVehicleInited;

		// Token: 0x040029ED RID: 10733
		private INpcPerformOnMonsterCloseby _NpcMonsterClosePerformCache;

		// Token: 0x040029EE RID: 10734
		private bool _NpcMonsterClosePerformInited;

		// Token: 0x040029EF RID: 10735
		private INpcPerformState _NpcPerformStateCache;

		// Token: 0x040029F0 RID: 10736
		private bool _NpcPerformStateInited;

		// Token: 0x040029F1 RID: 10737
		private INpcDeathInteract _DeathInteractCache;

		// Token: 0x040029F2 RID: 10738
		private bool _DeathInteractInited;

		// Token: 0x040029F3 RID: 10739
		private INpcDefaultPerform _DefaultPerformCache;

		// Token: 0x040029F4 RID: 10740
		private bool _DefaultPerformInited;

		// Token: 0x040029F5 RID: 10741
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcSpecialMarkBase> _NpcSpecialMarksCache;

		// Token: 0x040029F6 RID: 10742
		private bool _NpcSpecialMarksInited;

		// Token: 0x040029F7 RID: 10743
		private List<EExtraMovementAbility> _ExtraMovementAbilitiesCache;

		// Token: 0x040029F8 RID: 10744
		private bool _ExtraMovementAbilitiesInited;
	}
}

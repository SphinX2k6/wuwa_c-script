using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD4 RID: 3028
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent : IComponentBase
	{
		// Token: 0x0600458B RID: 17803 RVA: 0x000B00AC File Offset: 0x000AE2AC
		[NullableContext(1)]
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

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x000B00CC File Offset: 0x000AE2CC
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

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x000B0104 File Offset: 0x000AE304
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x000B011A File Offset: 0x000AE31A
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

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x000B014E File Offset: 0x000AE34E
		public virtual bool IsStare
		{
			get
			{
				return this.Instance.IsStare;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x000B015B File Offset: 0x000AE35B
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

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x000B018F File Offset: 0x000AE38F
		public virtual bool IsShowStrike
		{
			get
			{
				return this.Instance.IsShowStrike;
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x000B019C File Offset: 0x000AE39C
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

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x000B01D0 File Offset: 0x000AE3D0
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

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x000B0204 File Offset: 0x000AE404
		[Nullable(1)]
		public virtual INpcStandbyShowMode ShowOnStandby
		{
			[NullableContext(1)]
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x000B0233 File Offset: 0x000AE433
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000B0268 File Offset: 0x000AE468
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x000B02E2 File Offset: 0x000AE4E2
		[Nullable(1)]
		public virtual INpcUiInteractType ShowOnUiInteract
		{
			[NullableContext(1)]
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x000B0311 File Offset: 0x000AE511
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x000B0351 File Offset: 0x000AE551
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

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x000B0385 File Offset: 0x000AE585
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

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x000B03B9 File Offset: 0x000AE5B9
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

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x000B03F0 File Offset: 0x000AE5F0
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x000B0426 File Offset: 0x000AE626
		public virtual string DefaultAbpState
		{
			get
			{
				return this.Instance.DefaultAbpState;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x000B0434 File Offset: 0x000AE634
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x000B046B File Offset: 0x000AE66B
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x000B04A0 File Offset: 0x000AE6A0
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

		// Token: 0x04002791 RID: 10129
		private INpcPerformComponent Instance;

		// Token: 0x04002792 RID: 10130
		private IBaseRoleNpcPerform _SpecialNpcPerformConfigCache;

		// Token: 0x04002793 RID: 10131
		private bool _SpecialNpcPerformConfigInited;

		// Token: 0x04002794 RID: 10132
		private INpcHitShow _NpcHitShowCache;

		// Token: 0x04002795 RID: 10133
		private bool _NpcHitShowInited;

		// Token: 0x04002796 RID: 10134
		private INpcBumpShow _NpcBumpShowCache;

		// Token: 0x04002797 RID: 10135
		private bool _NpcBumpShowInited;

		// Token: 0x04002798 RID: 10136
		private INpcAwakeShow _ShowOnAwakeCache;

		// Token: 0x04002799 RID: 10137
		private bool _ShowOnAwakeInited;

		// Token: 0x0400279A RID: 10138
		[Nullable(1)]
		private INpcStandbyShowMode _ShowOnStandbyCache;

		// Token: 0x0400279B RID: 10139
		private bool _ShowOnStandbyInited;

		// Token: 0x0400279C RID: 10140
		private INpcPerformOnInteract _ShowOnInteractCache;

		// Token: 0x0400279D RID: 10141
		private bool _ShowOnInteractInited;

		// Token: 0x0400279E RID: 10142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionalNpcPerformOnInteract> _ConditionalShowOnInteractsCache;

		// Token: 0x0400279F RID: 10143
		private bool _ConditionalShowOnInteractsInited;

		// Token: 0x040027A0 RID: 10144
		[Nullable(1)]
		private INpcUiInteractType _ShowOnUiInteractCache;

		// Token: 0x040027A1 RID: 10145
		private bool _ShowOnUiInteractInited;

		// Token: 0x040027A2 RID: 10146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcRideInVehiclePerformType> _ShowOnRideInVehicleCache;

		// Token: 0x040027A3 RID: 10147
		private bool _ShowOnRideInVehicleInited;

		// Token: 0x040027A4 RID: 10148
		private INpcPerformOnMonsterCloseby _NpcMonsterClosePerformCache;

		// Token: 0x040027A5 RID: 10149
		private bool _NpcMonsterClosePerformInited;

		// Token: 0x040027A6 RID: 10150
		private INpcPerformState _NpcPerformStateCache;

		// Token: 0x040027A7 RID: 10151
		private bool _NpcPerformStateInited;

		// Token: 0x040027A8 RID: 10152
		private INpcDeathInteract _DeathInteractCache;

		// Token: 0x040027A9 RID: 10153
		private bool _DeathInteractInited;

		// Token: 0x040027AA RID: 10154
		private INpcDefaultPerform _DefaultPerformCache;

		// Token: 0x040027AB RID: 10155
		private bool _DefaultPerformInited;

		// Token: 0x040027AC RID: 10156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcSpecialMarkBase> _NpcSpecialMarksCache;

		// Token: 0x040027AD RID: 10157
		private bool _NpcSpecialMarksInited;
	}
}

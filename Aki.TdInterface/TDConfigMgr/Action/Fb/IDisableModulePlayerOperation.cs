using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002954 RID: 10580
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableModulePlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600EA9E RID: 60062 RVA: 0x00225B82 File Offset: 0x00223D82
		public static IDisableModulePlayerOperation Create(IDisableModulePlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableModulePlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x00225BA1 File Offset: 0x00223DA1
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x0600EAA0 RID: 60064 RVA: 0x00225BAE File Offset: 0x00223DAE
		public virtual IMoveOperationType MoveOption
		{
			get
			{
				if (this._MoveOptionInited)
				{
					return this._MoveOptionCache;
				}
				this._MoveOptionInited = true;
				this._MoveOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_MoveOption(this.Instance);
				return this._MoveOptionCache;
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00225BDD File Offset: 0x00223DDD
		public virtual ISkillOperationType SkillOption
		{
			get
			{
				if (this._SkillOptionInited)
				{
					return this._SkillOptionCache;
				}
				this._SkillOptionInited = true;
				this._SkillOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_SkillOption(this.Instance);
				return this._SkillOptionCache;
			}
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x0600EAA2 RID: 60066 RVA: 0x00225C0C File Offset: 0x00223E0C
		public virtual ICameraOperationType CameraOption
		{
			get
			{
				if (this._CameraOptionInited)
				{
					return this._CameraOptionCache;
				}
				this._CameraOptionInited = true;
				this._CameraOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_CameraOption(this.Instance);
				return this._CameraOptionCache;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x00225C3B File Offset: 0x00223E3B
		public virtual IUiOperationType UiOption
		{
			get
			{
				if (this._UiOptionInited)
				{
					return this._UiOptionCache;
				}
				this._UiOptionInited = true;
				this._UiOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_UiOption(this.Instance);
				return this._UiOptionCache;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x0600EAA4 RID: 60068 RVA: 0x00225C6A File Offset: 0x00223E6A
		public virtual ISceneInteractionOperationType SceneInteractionOption
		{
			get
			{
				if (this._SceneInteractionOptionInited)
				{
					return this._SceneInteractionOptionCache;
				}
				this._SceneInteractionOptionInited = true;
				this._SceneInteractionOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_SceneInteractionOption(this.Instance);
				return this._SceneInteractionOptionCache;
			}
		}

		// Token: 0x04008146 RID: 33094
		private IDisableModulePlayerOperation Instance;

		// Token: 0x04008147 RID: 33095
		private IMoveOperationType _MoveOptionCache;

		// Token: 0x04008148 RID: 33096
		private bool _MoveOptionInited;

		// Token: 0x04008149 RID: 33097
		private ISkillOperationType _SkillOptionCache;

		// Token: 0x0400814A RID: 33098
		private bool _SkillOptionInited;

		// Token: 0x0400814B RID: 33099
		private ICameraOperationType _CameraOptionCache;

		// Token: 0x0400814C RID: 33100
		private bool _CameraOptionInited;

		// Token: 0x0400814D RID: 33101
		private IUiOperationType _UiOptionCache;

		// Token: 0x0400814E RID: 33102
		private bool _UiOptionInited;

		// Token: 0x0400814F RID: 33103
		private ISceneInteractionOperationType _SceneInteractionOptionCache;

		// Token: 0x04008150 RID: 33104
		private bool _SceneInteractionOptionInited;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C20 RID: 11296
	public class IClientDisableModulePlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600F890 RID: 63632 RVA: 0x0024208E File Offset: 0x0024028E
		public static IClientDisableModulePlayerOperation Create(IClientDisableModulePlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientDisableModulePlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x0600F891 RID: 63633 RVA: 0x002420AD File Offset: 0x002402AD
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x0600F892 RID: 63634 RVA: 0x002420BA File Offset: 0x002402BA
		public virtual IMoveOperationType MoveOption
		{
			get
			{
				if (this._MoveOptionInited)
				{
					return this._MoveOptionCache;
				}
				this._MoveOptionInited = true;
				this._MoveOptionCache = ActionReadHelper.ReadIClientDisableModulePlayerOperation_MoveOption(this.Instance);
				return this._MoveOptionCache;
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x0600F893 RID: 63635 RVA: 0x002420E9 File Offset: 0x002402E9
		public virtual ISkillOperationType SkillOption
		{
			get
			{
				if (this._SkillOptionInited)
				{
					return this._SkillOptionCache;
				}
				this._SkillOptionInited = true;
				this._SkillOptionCache = ActionReadHelper.ReadIClientDisableModulePlayerOperation_SkillOption(this.Instance);
				return this._SkillOptionCache;
			}
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x00242118 File Offset: 0x00240318
		public virtual ICameraOperationType CameraOption
		{
			get
			{
				if (this._CameraOptionInited)
				{
					return this._CameraOptionCache;
				}
				this._CameraOptionInited = true;
				this._CameraOptionCache = ActionReadHelper.ReadIClientDisableModulePlayerOperation_CameraOption(this.Instance);
				return this._CameraOptionCache;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x0600F895 RID: 63637 RVA: 0x00242147 File Offset: 0x00240347
		public virtual IUiOperationType UiOption
		{
			get
			{
				if (this._UiOptionInited)
				{
					return this._UiOptionCache;
				}
				this._UiOptionInited = true;
				this._UiOptionCache = ActionReadHelper.ReadIClientDisableModulePlayerOperation_UiOption(this.Instance);
				return this._UiOptionCache;
			}
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x00242176 File Offset: 0x00240376
		public virtual ISceneInteractionOperationType SceneInteractionOption
		{
			get
			{
				if (this._SceneInteractionOptionInited)
				{
					return this._SceneInteractionOptionCache;
				}
				this._SceneInteractionOptionInited = true;
				this._SceneInteractionOptionCache = ActionReadHelper.ReadIClientDisableModulePlayerOperation_SceneInteractionOption(this.Instance);
				return this._SceneInteractionOptionCache;
			}
		}

		// Token: 0x040087F8 RID: 34808
		private IClientDisableModulePlayerOperation Instance;

		// Token: 0x040087F9 RID: 34809
		private IMoveOperationType _MoveOptionCache;

		// Token: 0x040087FA RID: 34810
		private bool _MoveOptionInited;

		// Token: 0x040087FB RID: 34811
		private ISkillOperationType _SkillOptionCache;

		// Token: 0x040087FC RID: 34812
		private bool _SkillOptionInited;

		// Token: 0x040087FD RID: 34813
		private ICameraOperationType _CameraOptionCache;

		// Token: 0x040087FE RID: 34814
		private bool _CameraOptionInited;

		// Token: 0x040087FF RID: 34815
		private IUiOperationType _UiOptionCache;

		// Token: 0x04008800 RID: 34816
		private bool _UiOptionInited;

		// Token: 0x04008801 RID: 34817
		private ISceneInteractionOperationType _SceneInteractionOptionCache;

		// Token: 0x04008802 RID: 34818
		private bool _SceneInteractionOptionInited;
	}
}

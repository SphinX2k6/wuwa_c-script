using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C39 RID: 11321
	public class IDisableModulePlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600F913 RID: 63763 RVA: 0x0024320B File Offset: 0x0024140B
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

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x0600F914 RID: 63764 RVA: 0x0024322A File Offset: 0x0024142A
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x0600F915 RID: 63765 RVA: 0x00243237 File Offset: 0x00241437
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

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x0600F916 RID: 63766 RVA: 0x00243266 File Offset: 0x00241466
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

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x0600F917 RID: 63767 RVA: 0x00243295 File Offset: 0x00241495
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

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x0600F918 RID: 63768 RVA: 0x002432C4 File Offset: 0x002414C4
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

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x0600F919 RID: 63769 RVA: 0x002432F3 File Offset: 0x002414F3
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

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x0600F91A RID: 63770 RVA: 0x00243322 File Offset: 0x00241522
		public virtual IPlayerAiControlBase PlayerAiOption
		{
			get
			{
				if (this._PlayerAiOptionInited)
				{
					return this._PlayerAiOptionCache;
				}
				this._PlayerAiOptionInited = true;
				this._PlayerAiOptionCache = ActionReadHelper.ReadIDisableModulePlayerOperation_PlayerAiOption(this.Instance);
				return this._PlayerAiOptionCache;
			}
		}

		// Token: 0x04008825 RID: 34853
		private IDisableModulePlayerOperation Instance;

		// Token: 0x04008826 RID: 34854
		private IMoveOperationType _MoveOptionCache;

		// Token: 0x04008827 RID: 34855
		private bool _MoveOptionInited;

		// Token: 0x04008828 RID: 34856
		private ISkillOperationType _SkillOptionCache;

		// Token: 0x04008829 RID: 34857
		private bool _SkillOptionInited;

		// Token: 0x0400882A RID: 34858
		private ICameraOperationType _CameraOptionCache;

		// Token: 0x0400882B RID: 34859
		private bool _CameraOptionInited;

		// Token: 0x0400882C RID: 34860
		private IUiOperationType _UiOptionCache;

		// Token: 0x0400882D RID: 34861
		private bool _UiOptionInited;

		// Token: 0x0400882E RID: 34862
		private ISceneInteractionOperationType _SceneInteractionOptionCache;

		// Token: 0x0400882F RID: 34863
		private bool _SceneInteractionOptionInited;

		// Token: 0x04008830 RID: 34864
		private IPlayerAiControlBase _PlayerAiOptionCache;

		// Token: 0x04008831 RID: 34865
		private bool _PlayerAiOptionInited;
	}
}

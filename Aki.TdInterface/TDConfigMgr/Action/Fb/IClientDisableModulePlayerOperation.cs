using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293E RID: 10558
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientDisableModulePlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600EA25 RID: 59941 RVA: 0x00224AAE File Offset: 0x00222CAE
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

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x0600EA26 RID: 59942 RVA: 0x00224ACD File Offset: 0x00222CCD
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x0600EA27 RID: 59943 RVA: 0x00224ADA File Offset: 0x00222CDA
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

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x0600EA28 RID: 59944 RVA: 0x00224B09 File Offset: 0x00222D09
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

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x00224B38 File Offset: 0x00222D38
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

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x0600EA2A RID: 59946 RVA: 0x00224B67 File Offset: 0x00222D67
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

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x00224B96 File Offset: 0x00222D96
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

		// Token: 0x0400811C RID: 33052
		private IClientDisableModulePlayerOperation Instance;

		// Token: 0x0400811D RID: 33053
		private IMoveOperationType _MoveOptionCache;

		// Token: 0x0400811E RID: 33054
		private bool _MoveOptionInited;

		// Token: 0x0400811F RID: 33055
		private ISkillOperationType _SkillOptionCache;

		// Token: 0x04008120 RID: 33056
		private bool _SkillOptionInited;

		// Token: 0x04008121 RID: 33057
		private ICameraOperationType _CameraOptionCache;

		// Token: 0x04008122 RID: 33058
		private bool _CameraOptionInited;

		// Token: 0x04008123 RID: 33059
		private IUiOperationType _UiOptionCache;

		// Token: 0x04008124 RID: 33060
		private bool _UiOptionInited;

		// Token: 0x04008125 RID: 33061
		private ISceneInteractionOperationType _SceneInteractionOptionCache;

		// Token: 0x04008126 RID: 33062
		private bool _SceneInteractionOptionInited;
	}
}

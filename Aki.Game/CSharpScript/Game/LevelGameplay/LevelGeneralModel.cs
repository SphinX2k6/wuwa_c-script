using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.LevelGamePlay.LevelEvents;
using CSharpScript.Game.LevelGamePlay.LevelListeners;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B0C RID: 23308
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelGeneralModel : ModelBase
	{
		// Token: 0x060394DA RID: 234714 RVA: 0x0100C39C File Offset: 0x0100A59C
		protected override bool OnInit()
		{
			this.CreatureGenAddTagList = new Dictionary<long, string>();
			this.InteractionDebug = false;
			this.SceneGuaranteeInfos = new List<GuaranteeActionInfo>();
			LevelEventCenter.RegistEvents();
			LevelConditionCenter.Instance.RegistConditions();
			GuaranteeActionCenter.Instance.RegGuaranteeActions();
			LevelListenerCenter.Init();
			LevelEntityAbilityCenter.Instance.Init();
			return true;
		}

		// Token: 0x060394DB RID: 234715 RVA: 0x0100C3F0 File Offset: 0x0100A5F0
		protected override bool OnClear()
		{
			this.CreatureGenAddTagList = null;
			this.InteractionDebug = false;
			this.SceneGuaranteeInfos = null;
			this.EntityGuaranteeInfos.Clear();
			LevelListenerCenter.Clear();
			LevelEntityAbilityCenter.Instance.Clear();
			SceneInteractPointManager.Instance.Clear();
			SceneInteractSearchStrategyRegistry.Instance.Clear();
			return true;
		}

		// Token: 0x060394DC RID: 234716 RVA: 0x0100C441 File Offset: 0x0100A641
		public void AddSceneGuaranteeActionInfo(GuaranteeActionInfo targetActionInfo)
		{
			this.SceneGuaranteeInfos.Add(targetActionInfo);
		}

		// Token: 0x060394DD RID: 234717 RVA: 0x0100C450 File Offset: 0x0100A650
		[return: Nullable(2)]
		public GuaranteeActionInfo PopSceneGuaranteeActionInfo(GuaranteeActionInfo targetActionInfo)
		{
			EActionFilterMode actionFilterMode = GuaranteeActionCenter.Instance.GetActionFilterMode(targetActionInfo.Name);
			if (actionFilterMode == EActionFilterMode.Never)
			{
				return null;
			}
			List<GuaranteeActionInfo> sceneGuaranteeInfos = this.SceneGuaranteeInfos;
			for (int i = sceneGuaranteeInfos.Count - 1; i >= 0; i--)
			{
				GuaranteeActionInfo guaranteeActionInfo = sceneGuaranteeInfos[i];
				if (guaranteeActionInfo.Name == targetActionInfo.Name && (actionFilterMode == EActionFilterMode.SameName || GuaranteeActionCenter.Instance.IsSameAction(guaranteeActionInfo, targetActionInfo)))
				{
					sceneGuaranteeInfos.RemoveAt(i);
					return guaranteeActionInfo;
				}
			}
			return null;
		}

		// Token: 0x060394DE RID: 234718 RVA: 0x0100C4C0 File Offset: 0x0100A6C0
		public bool HasSceneGuaranteeActionInfo(GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
		{
			return compareMode != EActionFilterMode.Never && this.SceneGuaranteeInfos.Exists(delegate(GuaranteeActionInfo actionInfo)
			{
				if (compareMode == EActionFilterMode.SameName)
				{
					return actionInfo.Name == targetActionInfo.Name;
				}
				return GuaranteeActionCenter.Instance.IsSameAction(actionInfo, targetActionInfo);
			});
		}

		// Token: 0x060394DF RID: 234719 RVA: 0x0100C502 File Offset: 0x0100A702
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<GuaranteeActionInfo> RemoveSceneGuaranteeActionInfos()
		{
			List<GuaranteeActionInfo> sceneGuaranteeInfos = this.SceneGuaranteeInfos;
			this.SceneGuaranteeInfos = new List<GuaranteeActionInfo>();
			return sceneGuaranteeInfos;
		}

		// Token: 0x060394E0 RID: 234720 RVA: 0x0100C515 File Offset: 0x0100A715
		public int MakeConditionGroupIncId()
		{
			this.LevelConditionGroupIncId++;
			return this.LevelConditionGroupIncId;
		}

		// Token: 0x060394E1 RID: 234721 RVA: 0x0100C52C File Offset: 0x0100A72C
		public void AddEntityGuaranteeActionInfo(int? entityId, GuaranteeActionInfo targetActionInfo)
		{
			bool flag = (entityId ?? 0) == 0;
			if (flag)
			{
				return;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId.Value);
			if (handle != null && handle.Valid)
			{
				if (!this.EntityGuaranteeInfos.ContainsKey(handle))
				{
					this.EntityGuaranteeInfos[handle] = new List<GuaranteeActionInfo>();
				}
				this.EntityGuaranteeInfos[handle].Add(targetActionInfo);
			}
		}

		// Token: 0x060394E2 RID: 234722 RVA: 0x0100C5A4 File Offset: 0x0100A7A4
		[return: Nullable(2)]
		public GuaranteeActionInfo PopEntityGuaranteeActionInfo(int? entityId, GuaranteeActionInfo targetActionInfo)
		{
			bool flag = (entityId ?? 0) == 0;
			if (flag)
			{
				return null;
			}
			EActionFilterMode actionFilterMode = GuaranteeActionCenter.Instance.GetActionFilterMode(targetActionInfo.Name);
			if (actionFilterMode == EActionFilterMode.Never)
			{
				return null;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId.Value);
			if (handle != null && handle.Valid && this.EntityGuaranteeInfos.ContainsKey(handle))
			{
				List<GuaranteeActionInfo> list = this.EntityGuaranteeInfos[handle];
				for (int i = list.Count - 1; i >= 0; i--)
				{
					GuaranteeActionInfo guaranteeActionInfo = list[i];
					if (guaranteeActionInfo.Name == targetActionInfo.Name && (actionFilterMode == EActionFilterMode.SameName || GuaranteeActionCenter.Instance.IsSameAction(guaranteeActionInfo, targetActionInfo)))
					{
						list.RemoveAt(i);
						if (list.Count == 0)
						{
							this.EntityGuaranteeInfos.Remove(handle);
						}
						else
						{
							this.EntityGuaranteeInfos[handle] = list;
						}
						return guaranteeActionInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x060394E3 RID: 234723 RVA: 0x0100C698 File Offset: 0x0100A898
		public bool HasEntityGuaranteeActionInfo(int? entityId, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
		{
			bool flag = (entityId ?? 0) == 0;
			if (flag)
			{
				return false;
			}
			if (compareMode == EActionFilterMode.Never)
			{
				return false;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId.Value);
			return handle != null && handle.Valid && this.EntityGuaranteeInfos.ContainsKey(handle) && this.EntityGuaranteeInfos[handle].Exists(delegate(GuaranteeActionInfo actionInfo)
			{
				if (compareMode == EActionFilterMode.SameName)
				{
					return actionInfo.Name == targetActionInfo.Name;
				}
				return GuaranteeActionCenter.Instance.IsSameAction(actionInfo, targetActionInfo);
			});
		}

		// Token: 0x060394E4 RID: 234724 RVA: 0x0100C72C File Offset: 0x0100A92C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<GuaranteeActionInfo> RemoveEntityGuaranteeActionInfos(EntityHandle entityHandle)
		{
			if (this.EntityGuaranteeInfos.ContainsKey(entityHandle))
			{
				List<GuaranteeActionInfo> result = null;
				if (entityHandle != null && entityHandle.Valid)
				{
					result = this.EntityGuaranteeInfos[entityHandle];
				}
				this.EntityGuaranteeInfos.Remove(entityHandle);
				return result;
			}
			return null;
		}

		// Token: 0x060394E5 RID: 234725 RVA: 0x0100C771 File Offset: 0x0100A971
		public Dictionary<EntityHandle, List<GuaranteeActionInfo>> GetEntityGuaranteeActionInfos()
		{
			return this.EntityGuaranteeInfos;
		}

		// Token: 0x060394E6 RID: 234726 RVA: 0x0100C779 File Offset: 0x0100A979
		public void ClearEntityGuaranteeActionInfos()
		{
			this.EntityGuaranteeInfos.Clear();
		}

		// Token: 0x17006D38 RID: 27960
		// (get) Token: 0x060394E7 RID: 234727 RVA: 0x0100C786 File Offset: 0x0100A986
		public static LevelGeneralModel Instance
		{
			get
			{
				return LevelGeneralModel._Instance;
			}
		}

		// Token: 0x060394E8 RID: 234728 RVA: 0x0100C78D File Offset: 0x0100A98D
		public static LevelGeneralModel GetOrCreateInstance()
		{
			if (LevelGeneralModel._Instance == null)
			{
				LevelGeneralModel.CreateInstance();
			}
			return LevelGeneralModel._Instance;
		}

		// Token: 0x060394E9 RID: 234729 RVA: 0x0100C7A1 File Offset: 0x0100A9A1
		public static bool CreateInstance()
		{
			if (LevelGeneralModel._Instance != null)
			{
				return true;
			}
			LevelGeneralModel._Instance = new LevelGeneralModel();
			return true;
		}

		// Token: 0x060394EA RID: 234730 RVA: 0x0100C7B7 File Offset: 0x0100A9B7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060394EB RID: 234731 RVA: 0x0100C7B9 File Offset: 0x0100A9B9
		public static void ResetStaticDefaultValue()
		{
			LevelGeneralModel._Instance = null;
		}

		// Token: 0x060394EC RID: 234732 RVA: 0x0100C7C1 File Offset: 0x0100A9C1
		static LevelGeneralModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelGeneralModel.CreateStaticDefaultValue), new Action(LevelGeneralModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E3E3 RID: 123875
		public const string LEVLE_CONDITION_DEBUG_KEY = "LevelCondition";

		// Token: 0x0401E3E4 RID: 123876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<long, string> CreatureGenAddTagList;

		// Token: 0x0401E3E5 RID: 123877
		public bool InteractionDebug;

		// Token: 0x0401E3E6 RID: 123878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<GuaranteeActionInfo> SceneGuaranteeInfos;

		// Token: 0x0401E3E7 RID: 123879
		private readonly Dictionary<EntityHandle, List<GuaranteeActionInfo>> EntityGuaranteeInfos = new Dictionary<EntityHandle, List<GuaranteeActionInfo>>();

		// Token: 0x0401E3E8 RID: 123880
		private int LevelConditionGroupIncId = -1;

		// Token: 0x0401E3E9 RID: 123881
		[Nullable(2)]
		private static LevelGeneralModel _Instance;
	}
}

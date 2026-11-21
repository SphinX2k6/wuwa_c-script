using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060D1 RID: 24785
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BigStuffedDollController : ControllerBase
	{
		// Token: 0x0603B6C8 RID: 243400 RVA: 0x010D0448 File Offset: 0x010CE648
		public void Open(int id, int treeConfigId, Action finishCallback)
		{
			BigStuffedDollModel instance = BigStuffedDollModel.Instance;
			instance.GameplayStart(id, treeConfigId);
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(instance.BrokenRockEntityPbDataId);
			if (entityByPbDataId != null)
			{
				instance.BrokenRockEntityCreatureDataId = entityByPbDataId.CreatureDataId;
			}
			UiManager.Instance.OpenView(EUiViewName.BigStuffedDollView, null, delegate(bool success, int viewId)
			{
				finishCallback();
			});
		}

		// Token: 0x0603B6C9 RID: 243401 RVA: 0x010D04AC File Offset: 0x010CE6AC
		public void SetBooleanValueThenSendEvent(int entityId, string key, bool value)
		{
			BlackboardModel.Instance.SetBooleanValueByEntity(entityId, key, value);
			this.SendGameplayEvent(entityId);
		}

		// Token: 0x0603B6CA RID: 243402 RVA: 0x010D04C2 File Offset: 0x010CE6C2
		public void SetIntValueThenSendEvent(int entityId, string key, int value)
		{
			BlackboardModel.Instance.SetIntValueByEntity(entityId, key, value);
			this.SendGameplayEvent(entityId);
		}

		// Token: 0x0603B6CB RID: 243403 RVA: 0x010D04D8 File Offset: 0x010CE6D8
		private void SendGameplayEvent(int entityId)
		{
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null || !entity.Valid)
			{
				return;
			}
			CharacterAbilityComponent component = entity.GetComponent<CharacterAbilityComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["关卡.大个布偶.坚固岩石玩法事件"]);
			if (gameplayTagById == null)
			{
				return;
			}
			component.SendGameplayEventToActor(gameplayTagById.Value, null);
		}

		// Token: 0x1700709A RID: 28826
		// (get) Token: 0x0603B6CC RID: 243404 RVA: 0x010D053D File Offset: 0x010CE73D
		public static BigStuffedDollController Instance
		{
			get
			{
				return BigStuffedDollController._Instance;
			}
		}

		// Token: 0x0603B6CD RID: 243405 RVA: 0x010D0544 File Offset: 0x010CE744
		public static BigStuffedDollController GetOrCreateInstance()
		{
			if (BigStuffedDollController._Instance == null)
			{
				BigStuffedDollController.CreateInstance();
			}
			return BigStuffedDollController._Instance;
		}

		// Token: 0x0603B6CE RID: 243406 RVA: 0x010D0558 File Offset: 0x010CE758
		public static bool CreateInstance()
		{
			if (BigStuffedDollController._Instance != null)
			{
				return true;
			}
			BigStuffedDollController._Instance = new BigStuffedDollController();
			return true;
		}

		// Token: 0x0603B6CF RID: 243407 RVA: 0x010D056E File Offset: 0x010CE76E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B6D0 RID: 243408 RVA: 0x010D0570 File Offset: 0x010CE770
		public static void ResetStaticDefaultValue()
		{
			BigStuffedDollController._Instance = null;
		}

		// Token: 0x0603B6D1 RID: 243409 RVA: 0x010D0578 File Offset: 0x010CE778
		static BigStuffedDollController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BigStuffedDollController.CreateStaticDefaultValue), new Action(BigStuffedDollController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F525 RID: 128293
		[Nullable(2)]
		private static BigStuffedDollController _Instance;
	}
}

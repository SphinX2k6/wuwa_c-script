using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F50 RID: 28496
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BigStuffedDollController : ControllerBase
	{
		// Token: 0x0604551A RID: 283930 RVA: 0x0112649C File Offset: 0x0112469C
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

		// Token: 0x0604551B RID: 283931 RVA: 0x01126500 File Offset: 0x01124700
		public void SetBooleanValueThenSendEvent(int entityId, string key, bool value)
		{
			BlackboardModel.Instance.SetBooleanValueByEntity(entityId, key, value);
			this.SendGameplayEvent(entityId);
		}

		// Token: 0x0604551C RID: 283932 RVA: 0x01126516 File Offset: 0x01124716
		public void SetIntValueThenSendEvent(int entityId, string key, int value)
		{
			BlackboardModel.Instance.SetIntValueByEntity(entityId, key, value);
			this.SendGameplayEvent(entityId);
		}

		// Token: 0x0604551D RID: 283933 RVA: 0x0112652C File Offset: 0x0112472C
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

		// Token: 0x17009B5B RID: 39771
		// (get) Token: 0x0604551E RID: 283934 RVA: 0x01126591 File Offset: 0x01124791
		public static BigStuffedDollController Instance
		{
			get
			{
				return BigStuffedDollController._Instance;
			}
		}

		// Token: 0x0604551F RID: 283935 RVA: 0x01126598 File Offset: 0x01124798
		public static BigStuffedDollController GetOrCreateInstance()
		{
			if (BigStuffedDollController._Instance == null)
			{
				BigStuffedDollController.CreateInstance();
			}
			return BigStuffedDollController._Instance;
		}

		// Token: 0x06045520 RID: 283936 RVA: 0x011265AC File Offset: 0x011247AC
		public static bool CreateInstance()
		{
			if (BigStuffedDollController._Instance != null)
			{
				return true;
			}
			BigStuffedDollController._Instance = new BigStuffedDollController();
			return true;
		}

		// Token: 0x06045521 RID: 283937 RVA: 0x011265C2 File Offset: 0x011247C2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045522 RID: 283938 RVA: 0x011265C4 File Offset: 0x011247C4
		public static void ResetStaticDefaultValue()
		{
			BigStuffedDollController._Instance = null;
		}

		// Token: 0x06045523 RID: 283939 RVA: 0x011265CC File Offset: 0x011247CC
		static BigStuffedDollController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BigStuffedDollController.CreateStaticDefaultValue), new Action(BigStuffedDollController.ResetStaticDefaultValue));
		}

		// Token: 0x04024270 RID: 148080
		[Nullable(2)]
		private static BigStuffedDollController _Instance;
	}
}

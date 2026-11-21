using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B11 RID: 15121
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterTeleportLockHelper : IStaticVariableResetter
	{
		// Token: 0x06026D35 RID: 159029 RVA: 0x00ADD8B8 File Offset: 0x00ADBAB8
		static CharacterTeleportLockHelper()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterTeleportLockHelper.CreateStaticDefaultValue), new Action(CharacterTeleportLockHelper.ResetStaticDefaultValue));
		}

		// Token: 0x06026D36 RID: 159030 RVA: 0x00ADD8D7 File Offset: 0x00ADBAD7
		public static void CreateStaticDefaultValue()
		{
			CharacterTeleportLockHelper.LockReasons = new HashSet<ECharacterTeleportLockReason>();
			CharacterTeleportLockHelper.FrozenEntityHandle = null;
		}

		// Token: 0x06026D37 RID: 159031 RVA: 0x00ADD8E9 File Offset: 0x00ADBAE9
		public static void ResetStaticDefaultValue()
		{
			CharacterTeleportLockHelper.LockReasons = null;
			CharacterTeleportLockHelper.FrozenEntityHandle = null;
		}

		// Token: 0x06026D38 RID: 159032 RVA: 0x00ADD8F8 File Offset: 0x00ADBAF8
		public static void Lock(ECharacterTeleportLockReason reason)
		{
			if (CharacterTeleportLockHelper.LockReasons.Count == 0)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.OnChangeRole;
				Action<EntityHandle, EntityHandle> handle;
				if ((handle = CharacterTeleportLockHelper.<>O.<0>__OnChangeRole) == null)
				{
					handle = (CharacterTeleportLockHelper.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CharacterTeleportLockHelper.OnChangeRole));
				}
				instance.Add<EntityHandle, EntityHandle>(name, handle);
				EventSystem instance2 = EventSystem.Instance;
				EEventName name2 = EEventName.OnUpdateSceneTeam;
				Action handle2;
				if ((handle2 = CharacterTeleportLockHelper.<>O.<1>__OnUpdateSceneTeam) == null)
				{
					handle2 = (CharacterTeleportLockHelper.<>O.<1>__OnUpdateSceneTeam = new Action(CharacterTeleportLockHelper.OnUpdateSceneTeam));
				}
				instance2.Add(name2, handle2);
			}
			CharacterTeleportLockHelper.LockReasons.Add(reason);
			CharacterTeleportLockHelper.LockCurrentCharacter();
		}

		// Token: 0x06026D39 RID: 159033 RVA: 0x00ADD978 File Offset: 0x00ADBB78
		public static void Unlock(ECharacterTeleportLockReason reason)
		{
			if (!CharacterTeleportLockHelper.LockReasons.Remove(reason))
			{
				return;
			}
			if (CharacterTeleportLockHelper.LockReasons.Count > 0)
			{
				return;
			}
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnChangeRole;
			Action<EntityHandle, EntityHandle> handle;
			if ((handle = CharacterTeleportLockHelper.<>O.<0>__OnChangeRole) == null)
			{
				handle = (CharacterTeleportLockHelper.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CharacterTeleportLockHelper.OnChangeRole));
			}
			instance.Remove<EntityHandle, EntityHandle>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnUpdateSceneTeam;
			Action handle2;
			if ((handle2 = CharacterTeleportLockHelper.<>O.<1>__OnUpdateSceneTeam) == null)
			{
				handle2 = (CharacterTeleportLockHelper.<>O.<1>__OnUpdateSceneTeam = new Action(CharacterTeleportLockHelper.OnUpdateSceneTeam));
			}
			instance2.Remove(name2, handle2);
			CharacterTeleportLockHelper.UnlockCurrentCharacter();
		}

		// Token: 0x06026D3A RID: 159034 RVA: 0x00ADD9FC File Offset: 0x00ADBBFC
		[NullableContext(1)]
		private static void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			CharacterTeleportLockHelper.LockCharacter(newEntity);
		}

		// Token: 0x06026D3B RID: 159035 RVA: 0x00ADDA04 File Offset: 0x00ADBC04
		private static void OnUpdateSceneTeam()
		{
			CharacterTeleportLockHelper.LockCurrentCharacter();
		}

		// Token: 0x06026D3C RID: 159036 RVA: 0x00ADDA0B File Offset: 0x00ADBC0B
		private static void LockCurrentCharacter()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			CharacterTeleportLockHelper.LockCharacter((instance != null) ? instance.GetCurrentEntity : null);
		}

		// Token: 0x06026D3D RID: 159037 RVA: 0x00ADDA24 File Offset: 0x00ADBC24
		private static void LockCharacter(EntityHandle entityHandle)
		{
			EntityHandle frozenEntityHandle = CharacterTeleportLockHelper.FrozenEntityHandle;
			if (frozenEntityHandle != null && frozenEntityHandle.Valid)
			{
				int id = CharacterTeleportLockHelper.FrozenEntityHandle.Id;
				int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
				if (id == num.GetValueOrDefault() & num != null)
				{
					return;
				}
			}
			CharacterTeleportLockHelper.UnlockCurrentCharacter();
			if (entityHandle == null || !entityHandle.Valid)
			{
				return;
			}
			WorldEntity entity = entityHandle.Entity;
			UeMovementTickManageComponent ueMovementTickManageComponent = (entity != null) ? entity.GetComponent<UeMovementTickManageComponent>() : null;
			if (ueMovementTickManageComponent != null)
			{
				ueMovementTickManageComponent.TeleportLock = true;
				CharacterTeleportLockHelper.FrozenEntityHandle = entityHandle;
			}
		}

		// Token: 0x06026D3E RID: 159038 RVA: 0x00ADDAB8 File Offset: 0x00ADBCB8
		private static void UnlockCurrentCharacter()
		{
			EntityHandle frozenEntityHandle = CharacterTeleportLockHelper.FrozenEntityHandle;
			if (frozenEntityHandle != null && frozenEntityHandle.Valid)
			{
				WorldEntity entity = CharacterTeleportLockHelper.FrozenEntityHandle.Entity;
				UeMovementTickManageComponent ueMovementTickManageComponent = (entity != null) ? entity.GetComponent<UeMovementTickManageComponent>() : null;
				if (ueMovementTickManageComponent != null)
				{
					ueMovementTickManageComponent.TeleportLock = false;
				}
			}
			CharacterTeleportLockHelper.FrozenEntityHandle = null;
		}

		// Token: 0x0401539C RID: 86940
		private static HashSet<ECharacterTeleportLockReason> LockReasons;

		// Token: 0x0401539D RID: 86941
		private static EntityHandle FrozenEntityHandle;

		// Token: 0x0200971E RID: 38686
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402F2AD RID: 193197
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Action<EntityHandle, EntityHandle> <0>__OnChangeRole;

			// Token: 0x0402F2AE RID: 193198
			[Nullable(0)]
			public static Action <1>__OnUpdateSceneTeam;
		}
	}
}

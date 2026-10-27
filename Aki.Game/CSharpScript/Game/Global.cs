using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game
{
	// Token: 0x02004523 RID: 17699
	[NullableContext(2)]
	[Nullable(0)]
	public class Global : IStaticVariableResetter
	{
		// Token: 0x0602DB8F RID: 187279 RVA: 0x00A81E06 File Offset: 0x00A80006
		static Global()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Global.CreateStaticDefaultValue), new Action(Global.ResetStaticDefaultValue));
		}

		// Token: 0x0602DB90 RID: 187280 RVA: 0x00A81E25 File Offset: 0x00A80025
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DB91 RID: 187281 RVA: 0x00A81E27 File Offset: 0x00A80027
		public static void ResetStaticDefaultValue()
		{
			Global.BaseCharacter = null;
			Global._myBaseCharacter = null;
			Global.CharacterController = null;
			Global._myCharacterControllerInternal = null;
			Global._playerControllerInternal = null;
			Global._myCharacterCameraManager = null;
			Global._myPawnOrSpectator = null;
		}

		// Token: 0x1700750A RID: 29962
		// (get) Token: 0x0602DB92 RID: 187282 RVA: 0x00A81E53 File Offset: 0x00A80053
		// (set) Token: 0x0602DB93 RID: 187283 RVA: 0x00A81E89 File Offset: 0x00A80089
		public static TsBaseCharacter BaseCharacter
		{
			get
			{
				if ((Global._myBaseCharacter == null || !Global._myBaseCharacter.IsValid()) && GlobalData.GameInstance != null)
				{
					Global._myBaseCharacter = (UGameplayStatics.GetPlayerCharacter(GlobalData.World, 0) as TsBaseCharacter);
				}
				return Global._myBaseCharacter;
			}
			set
			{
				Global._myBaseCharacter = value;
			}
		}

		// Token: 0x1700750B RID: 29963
		// (get) Token: 0x0602DB94 RID: 187284 RVA: 0x00A81E91 File Offset: 0x00A80091
		// (set) Token: 0x0602DB95 RID: 187285 RVA: 0x00A81ED1 File Offset: 0x00A800D1
		[Obsolete("慎用,可以暂时用PlayerController替代")]
		public static TsCharacterController CharacterController
		{
			get
			{
				if ((Global._myCharacterControllerInternal == null || !Global._myCharacterControllerInternal.IsValid()) && GlobalData.GameInstance != null)
				{
					Global._myCharacterControllerInternal = (UGameplayStatics.GetPlayerController(GlobalData.World, 0) as TsCharacterController);
					Global._playerControllerInternal = Global._myCharacterControllerInternal;
				}
				return Global._myCharacterControllerInternal;
			}
			set
			{
				if (Global._myCharacterControllerInternal == value)
				{
					return;
				}
				Global._myCharacterControllerInternal = value;
				Global._playerControllerInternal = value;
				if (value != null)
				{
					TickSystem.Instance.AddTickPrerequisiteActor(ETickingGroup.TG_PrePhysics, value, 2);
				}
			}
		}

		// Token: 0x1700750C RID: 29964
		// (get) Token: 0x0602DB96 RID: 187286 RVA: 0x00A81EF8 File Offset: 0x00A800F8
		public static APlayerController PlayerController
		{
			get
			{
				if ((Global._playerControllerInternal == null || !Global._playerControllerInternal.IsValid()) && GlobalData.GameInstance != null)
				{
					Global._playerControllerInternal = UGameplayStatics.GetPlayerController(GlobalData.World, 0);
				}
				return Global._playerControllerInternal;
			}
		}

		// Token: 0x1700750D RID: 29965
		// (get) Token: 0x0602DB97 RID: 187287 RVA: 0x00A81F29 File Offset: 0x00A80129
		[Nullable(1)]
		public static APlayerCameraManager CharacterCameraManager
		{
			[NullableContext(1)]
			get
			{
				if ((Global._myCharacterCameraManager == null || !Global._myCharacterCameraManager.IsValid()) && GlobalData.GameInstance != null)
				{
					Global._myCharacterCameraManager = UGameplayStatics.GetPlayerCameraManager(GlobalData.World, 0);
				}
				return Global._myCharacterCameraManager;
			}
		}

		// Token: 0x1700750E RID: 29966
		// (get) Token: 0x0602DB98 RID: 187288 RVA: 0x00A81F5A File Offset: 0x00A8015A
		public static APawn PawnOrSpectator
		{
			get
			{
				if ((Global._myPawnOrSpectator == null || !Global._myPawnOrSpectator.IsValid()) && GlobalData.GameInstance != null)
				{
					Global._myPawnOrSpectator = UGameplayStatics.GetPlayerPawn(GlobalData.World, 0);
				}
				return Global._myPawnOrSpectator;
			}
		}

		// Token: 0x0602DB99 RID: 187289 RVA: 0x00A81F8C File Offset: 0x00A8018C
		[NullableContext(1)]
		private static void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			if (GlobalData.GameInstance != null)
			{
				Global.CharacterController = (UGameplayStatics.GetPlayerController(GlobalData.World, 0) as TsCharacterController);
				Global.BaseCharacter = (UGameplayStatics.GetPlayerCharacter(GlobalData.World, 0) as TsBaseCharacter);
				Global._myCharacterCameraManager = UGameplayStatics.GetPlayerCameraManager(GlobalData.World, 0);
				Global._myPawnOrSpectator = UGameplayStatics.GetPlayerPawn(GlobalData.World, 0);
			}
		}

		// Token: 0x0602DB9A RID: 187290 RVA: 0x00A81FEA File Offset: 0x00A801EA
		[NullableContext(1)]
		public static bool IsControlledCharacter(AActor inActor)
		{
			return inActor is TsBaseCharacter && ((ACharacter)inActor).GetController() == Global.CharacterController;
		}

		// Token: 0x0602DB9B RID: 187291 RVA: 0x00A82008 File Offset: 0x00A80208
		private static void BeforeLoadMap()
		{
			Global.CharacterController = null;
			Global.BaseCharacter = null;
			Global._myCharacterCameraManager = null;
			Global._myPawnOrSpectator = null;
		}

		// Token: 0x0602DB9C RID: 187292 RVA: 0x00A82022 File Offset: 0x00A80222
		private static void AfterLoadMap()
		{
			Global.CharacterController = (UGameplayStatics.GetPlayerController(GlobalData.World, 0) as TsCharacterController);
			Global._myCharacterCameraManager = UGameplayStatics.GetPlayerCameraManager(GlobalData.World, 0);
			Global._myPawnOrSpectator = UGameplayStatics.GetPlayerPawn(GlobalData.World, 0);
		}

		// Token: 0x0602DB9D RID: 187293 RVA: 0x00A8205C File Offset: 0x00A8025C
		public static void InitEvent()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnChangeRole;
			Action<EntityHandle, EntityHandle> handle;
			if ((handle = Global.<>O.<0>__OnChangeRole) == null)
			{
				handle = (Global.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(Global.OnChangeRole));
			}
			instance.Add<EntityHandle, EntityHandle>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.BeforeLoadMap;
			Action handle2;
			if ((handle2 = Global.<>O.<1>__BeforeLoadMap) == null)
			{
				handle2 = (Global.<>O.<1>__BeforeLoadMap = new Action(Global.BeforeLoadMap));
			}
			instance2.Add(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.AfterLoadMap;
			Action handle3;
			if ((handle3 = Global.<>O.<2>__AfterLoadMap) == null)
			{
				handle3 = (Global.<>O.<2>__AfterLoadMap = new Action(Global.AfterLoadMap));
			}
			instance3.Add(name3, handle3);
		}

		// Token: 0x04018694 RID: 99988
		private static TsBaseCharacter _myBaseCharacter;

		// Token: 0x04018695 RID: 99989
		private static TsCharacterController _myCharacterControllerInternal;

		// Token: 0x04018696 RID: 99990
		private static APlayerController _playerControllerInternal;

		// Token: 0x04018697 RID: 99991
		private static APlayerCameraManager _myCharacterCameraManager;

		// Token: 0x04018698 RID: 99992
		private static APawn _myPawnOrSpectator;

		// Token: 0x0200A7FE RID: 43006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040332AE RID: 209582
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Action<EntityHandle, EntityHandle> <0>__OnChangeRole;

			// Token: 0x040332AF RID: 209583
			[Nullable(0)]
			public static Action <1>__BeforeLoadMap;

			// Token: 0x040332B0 RID: 209584
			[Nullable(0)]
			public static Action <2>__AfterLoadMap;
		}
	}
}

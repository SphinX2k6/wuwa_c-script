using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game
{
	// Token: 0x02003448 RID: 13384
	[NullableContext(2)]
	[Nullable(0)]
	public class Global : IStaticVariableResetter
	{
		// Token: 0x06022254 RID: 139860 RVA: 0x009AD02E File Offset: 0x009AB22E
		static Global()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Global.CreateStaticDefaultValue), new Action(Global.ResetStaticDefaultValue));
		}

		// Token: 0x06022255 RID: 139861 RVA: 0x009AD04D File Offset: 0x009AB24D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x009AD04F File Offset: 0x009AB24F
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

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x06022257 RID: 139863 RVA: 0x009AD07B File Offset: 0x009AB27B
		// (set) Token: 0x06022258 RID: 139864 RVA: 0x009AD0B1 File Offset: 0x009AB2B1
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

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06022259 RID: 139865 RVA: 0x009AD0B9 File Offset: 0x009AB2B9
		// (set) Token: 0x0602225A RID: 139866 RVA: 0x009AD0F9 File Offset: 0x009AB2F9
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

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x0602225B RID: 139867 RVA: 0x009AD120 File Offset: 0x009AB320
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

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x0602225C RID: 139868 RVA: 0x009AD151 File Offset: 0x009AB351
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

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0602225D RID: 139869 RVA: 0x009AD182 File Offset: 0x009AB382
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

		// Token: 0x0602225E RID: 139870 RVA: 0x009AD1B4 File Offset: 0x009AB3B4
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

		// Token: 0x0602225F RID: 139871 RVA: 0x009AD212 File Offset: 0x009AB412
		[NullableContext(1)]
		public static bool IsControlledCharacter(AActor inActor)
		{
			return inActor is TsBaseCharacter && ((ACharacter)inActor).GetController() == Global.CharacterController;
		}

		// Token: 0x06022260 RID: 139872 RVA: 0x009AD230 File Offset: 0x009AB430
		private static void BeforeLoadMap()
		{
			Global.CharacterController = null;
			Global.BaseCharacter = null;
			Global._myCharacterCameraManager = null;
			Global._myPawnOrSpectator = null;
		}

		// Token: 0x06022261 RID: 139873 RVA: 0x009AD24A File Offset: 0x009AB44A
		private static void AfterLoadMap()
		{
			Global.CharacterController = (UGameplayStatics.GetPlayerController(GlobalData.World, 0) as TsCharacterController);
			Global._myCharacterCameraManager = UGameplayStatics.GetPlayerCameraManager(GlobalData.World, 0);
			Global._myPawnOrSpectator = UGameplayStatics.GetPlayerPawn(GlobalData.World, 0);
		}

		// Token: 0x06022262 RID: 139874 RVA: 0x009AD284 File Offset: 0x009AB484
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

		// Token: 0x04012CB8 RID: 76984
		private static TsBaseCharacter _myBaseCharacter;

		// Token: 0x04012CB9 RID: 76985
		private static TsCharacterController _myCharacterControllerInternal;

		// Token: 0x04012CBA RID: 76986
		private static APlayerController _playerControllerInternal;

		// Token: 0x04012CBB RID: 76987
		private static APlayerCameraManager _myCharacterCameraManager;

		// Token: 0x04012CBC RID: 76988
		private static APawn _myPawnOrSpectator;

		// Token: 0x020091B3 RID: 37299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402DA37 RID: 186935
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Action<EntityHandle, EntityHandle> <0>__OnChangeRole;

			// Token: 0x0402DA38 RID: 186936
			[Nullable(0)]
			public static Action <1>__BeforeLoadMap;

			// Token: 0x0402DA39 RID: 186937
			[Nullable(0)]
			public static Action <2>__AfterLoadMap;
		}
	}
}

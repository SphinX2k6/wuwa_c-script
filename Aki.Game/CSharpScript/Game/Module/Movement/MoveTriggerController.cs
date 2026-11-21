using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Movement
{
	// Token: 0x02004373 RID: 17267
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoveTriggerController : ControllerBase
	{
		// Token: 0x0602B9AB RID: 178603 RVA: 0x00C3E07F File Offset: 0x00C3C27F
		protected override bool OnClear()
		{
			this.ClearController();
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x0602B9AC RID: 178604 RVA: 0x00C3E0A4 File Offset: 0x00C3C2A4
		protected override bool OnInit()
		{
			AKuroMoveTriggerController.UnRegisterController();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x0602B9AD RID: 178605 RVA: 0x00C3E0C8 File Offset: 0x00C3C2C8
		private void OnWorldDone()
		{
			this.ClearController();
			this.UeController = (ActorSystem.Instance.Get(AKuroMoveTriggerController.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as AKuroMoveTriggerController);
			if (this.UeController != null)
			{
				AKuroMoveTriggerController.RegisterController(this.UeController);
				this.UeController.Callback.Add(new FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate(MoveTriggerController.<OnWorldDone>g__OverlapTaskCallback|3_0));
				this.UeController.InitAllTriggers();
			}
		}

		// Token: 0x0602B9AE RID: 178606 RVA: 0x00C3E13B File Offset: 0x00C3C33B
		protected override bool OnLeaveLevel()
		{
			this.ClearController();
			return true;
		}

		// Token: 0x0602B9AF RID: 178607 RVA: 0x00C3E144 File Offset: 0x00C3C344
		public void ClearController()
		{
			if (this.UeController != null)
			{
				ActorSystem.Instance.Put("MoveTriggerController.ClearController", this.UeController, null);
			}
			AKuroMoveTriggerController.UnRegisterController();
			this.UeController = null;
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x0602B9B0 RID: 178608 RVA: 0x00C3E171 File Offset: 0x00C3C371
		public static MoveTriggerController Instance
		{
			get
			{
				return MoveTriggerController._Instance;
			}
		}

		// Token: 0x0602B9B1 RID: 178609 RVA: 0x00C3E178 File Offset: 0x00C3C378
		public static MoveTriggerController GetOrCreateInstance()
		{
			if (MoveTriggerController._Instance == null)
			{
				MoveTriggerController.CreateInstance();
			}
			return MoveTriggerController._Instance;
		}

		// Token: 0x0602B9B2 RID: 178610 RVA: 0x00C3E18C File Offset: 0x00C3C38C
		public static bool CreateInstance()
		{
			if (MoveTriggerController._Instance != null)
			{
				return true;
			}
			MoveTriggerController._Instance = new MoveTriggerController();
			return true;
		}

		// Token: 0x0602B9B3 RID: 178611 RVA: 0x00C3E1A2 File Offset: 0x00C3C3A2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B9B4 RID: 178612 RVA: 0x00C3E1A4 File Offset: 0x00C3C3A4
		public static void ResetStaticDefaultValue()
		{
			MoveTriggerController._Instance = null;
		}

		// Token: 0x0602B9B5 RID: 178613 RVA: 0x00C3E1AC File Offset: 0x00C3C3AC
		static MoveTriggerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoveTriggerController.CreateStaticDefaultValue), new Action(MoveTriggerController.ResetStaticDefaultValue));
		}

		// Token: 0x0602B9B7 RID: 178615 RVA: 0x00C3E1D4 File Offset: 0x00C3C3D4
		[CompilerGenerated]
		internal static void <OnWorldDone>g__OverlapTaskCallback|3_0([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FOverlapActorRecord> records)
		{
			for (int i = 0; i < records.Num(); i++)
			{
				FOverlapActorRecord foverlapActorRecord = records.Get(i);
				TsBaseCharacter tsBaseCharacter = foverlapActorRecord.Actor as TsBaseCharacter;
				if (tsBaseCharacter != null && tsBaseCharacter.IsValid())
				{
					CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
					Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
					if (entity != null && entity.Valid)
					{
						ETriggerAreaType area = foverlapActorRecord.Area;
						if (area != ETriggerAreaType.Water)
						{
							if (area != ETriggerAreaType.Other)
							{
							}
						}
						else
						{
							CharacterSwimComponent swimComp = entity.GetComponent<CharacterSwimComponent>();
							if (foverlapActorRecord.EnterOverlap)
							{
								CharacterSwimComponent swimComp4 = swimComp;
								if (swimComp4 != null && swimComp4.Valid)
								{
									swimComp.InSwimTriggerCount++;
									swimComp.LogSwimTriggerCount();
								}
							}
							else
							{
								CharacterSwimComponent swimComp2 = swimComp;
								if (swimComp2 != null && swimComp2.Valid && swimComp.InSwimTriggerCount > 0)
								{
									if (swimComp.IsRole)
									{
										TimerSystem.Instance.Delay(delegate(float _)
										{
											CharacterSwimComponent swimComp3 = swimComp;
											if (swimComp3 != null && swimComp3.Valid && swimComp.InSwimTriggerCount > 0)
											{
												swimComp.InSwimTriggerCount--;
												swimComp.LogSwimTriggerCount();
											}
										}, 1000f, null, null, true, 1f);
									}
									else
									{
										swimComp.InSwimTriggerCount--;
										swimComp.LogSwimTriggerCount();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04017899 RID: 96409
		[Nullable(2)]
		private AKuroMoveTriggerController UeController;

		// Token: 0x0401789A RID: 96410
		[Nullable(2)]
		private static MoveTriggerController _Instance;
	}
}

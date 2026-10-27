using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Movement
{
	// Token: 0x02005390 RID: 21392
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoveTriggerController : ControllerBase
	{
		// Token: 0x06036A65 RID: 223845 RVA: 0x00CEF157 File Offset: 0x00CED357
		protected override bool OnClear()
		{
			this.ClearController();
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x06036A66 RID: 223846 RVA: 0x00CEF17C File Offset: 0x00CED37C
		protected override bool OnInit()
		{
			AKuroMoveTriggerController.UnRegisterController();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x06036A67 RID: 223847 RVA: 0x00CEF1A0 File Offset: 0x00CED3A0
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

		// Token: 0x06036A68 RID: 223848 RVA: 0x00CEF213 File Offset: 0x00CED413
		protected override bool OnLeaveLevel()
		{
			this.ClearController();
			return true;
		}

		// Token: 0x06036A69 RID: 223849 RVA: 0x00CEF21C File Offset: 0x00CED41C
		public void ClearController()
		{
			if (this.UeController != null)
			{
				ActorSystem.Instance.Put("MoveTriggerController.ClearController", this.UeController, null);
			}
			AKuroMoveTriggerController.UnRegisterController();
			this.UeController = null;
		}

		// Token: 0x170083A1 RID: 33697
		// (get) Token: 0x06036A6A RID: 223850 RVA: 0x00CEF249 File Offset: 0x00CED449
		public static MoveTriggerController Instance
		{
			get
			{
				return MoveTriggerController._Instance;
			}
		}

		// Token: 0x06036A6B RID: 223851 RVA: 0x00CEF250 File Offset: 0x00CED450
		public static MoveTriggerController GetOrCreateInstance()
		{
			if (MoveTriggerController._Instance == null)
			{
				MoveTriggerController.CreateInstance();
			}
			return MoveTriggerController._Instance;
		}

		// Token: 0x06036A6C RID: 223852 RVA: 0x00CEF264 File Offset: 0x00CED464
		public static bool CreateInstance()
		{
			if (MoveTriggerController._Instance != null)
			{
				return true;
			}
			MoveTriggerController._Instance = new MoveTriggerController();
			return true;
		}

		// Token: 0x06036A6D RID: 223853 RVA: 0x00CEF27A File Offset: 0x00CED47A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036A6E RID: 223854 RVA: 0x00CEF27C File Offset: 0x00CED47C
		public static void ResetStaticDefaultValue()
		{
			MoveTriggerController._Instance = null;
		}

		// Token: 0x06036A6F RID: 223855 RVA: 0x00CEF284 File Offset: 0x00CED484
		static MoveTriggerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoveTriggerController.CreateStaticDefaultValue), new Action(MoveTriggerController.ResetStaticDefaultValue));
		}

		// Token: 0x06036A71 RID: 223857 RVA: 0x00CEF2AC File Offset: 0x00CED4AC
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

		// Token: 0x0401CE01 RID: 118273
		[Nullable(2)]
		private AKuroMoveTriggerController UeController;

		// Token: 0x0401CE02 RID: 118274
		[Nullable(2)]
		private static MoveTriggerController _Instance;
	}
}

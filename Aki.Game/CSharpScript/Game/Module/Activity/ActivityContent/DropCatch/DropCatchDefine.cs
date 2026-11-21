using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055F2 RID: 22002
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchDefine : Singleton
	{
		// Token: 0x17006981 RID: 27009
		// (get) Token: 0x060367B0 RID: 223152 RVA: 0x00F349C7 File Offset: 0x00F32BC7
		public static DropCatchDefine Instance
		{
			get
			{
				if (DropCatchDefine._instance == null)
				{
					DropCatchDefine._instance = new DropCatchDefine();
					DropCatchDefine._instance.OnInit();
				}
				return DropCatchDefine._instance;
			}
		}

		// Token: 0x060367B1 RID: 223153 RVA: 0x00F349EA File Offset: 0x00F32BEA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060367B2 RID: 223154 RVA: 0x00F349EC File Offset: 0x00F32BEC
		public static void ResetStaticDefaultValue()
		{
			DropCatchDefine instance = DropCatchDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			DropCatchDefine._instance = null;
		}

		// Token: 0x060367B3 RID: 223155 RVA: 0x00F34A05 File Offset: 0x00F32C05
		static DropCatchDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchDefine.CreateStaticDefaultValue), new Action(DropCatchDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060367B4 RID: 223156 RVA: 0x00F34A24 File Offset: 0x00F32C24
		public DropCatchDefine()
		{
			EDropCatchGameplayInputSource[] array = new EDropCatchGameplayInputSource[2];
			array[0] = EDropCatchGameplayInputSource.Command;
			this.InputPriority = array;
			base..ctor();
		}

		// Token: 0x0401CC29 RID: 117801
		public readonly Dictionary<string, IDropCatchCommand> CommandClass = new Dictionary<string, IDropCatchCommand>
		{
			{
				EDropCatchCommandName.SpawnDropItem.ToEnumString(),
				new SpawnDropItemCommand()
			},
			{
				EDropCatchCommandName.AddEnergy.ToEnumString(),
				new AddEnergyCommand()
			},
			{
				EDropCatchCommandName.FullEnergy.ToEnumString(),
				new FullEnergyCommand()
			},
			{
				EDropCatchCommandName.AddScore.ToEnumString(),
				new AddScoreCommand()
			},
			{
				EDropCatchCommandName.AddTime.ToEnumString(),
				new AddTimeCommand()
			},
			{
				EDropCatchCommandName.AddShield.ToEnumString(),
				new AddShieldCommand()
			},
			{
				EDropCatchCommandName.MoveRole.ToEnumString(),
				new MoveRoleCommand()
			},
			{
				EDropCatchCommandName.CrazyMode.ToEnumString(),
				new CrazyModeCommand()
			},
			{
				EDropCatchCommandName.ConvertDropItem.ToEnumString(),
				new ConvertDropItemCommand()
			},
			{
				EDropCatchCommandName.ModifyRoleSpeed.ToEnumString(),
				new ModifyRoleSpeedCommand()
			},
			{
				EDropCatchCommandName.ModifyDropPoolTimeInterval.ToEnumString(),
				new ModifyDropPoolTimeIntervalCommand()
			},
			{
				EDropCatchCommandName.ModifyAddScoreRate.ToEnumString(),
				new ModifyAddScoreRateCommand()
			},
			{
				EDropCatchCommandName.ModifyEnergyGetRate.ToEnumString(),
				new ModifyEnergyGetRateCommand()
			},
			{
				EDropCatchCommandName.ShowLeftMsg.ToEnumString(),
				new ShowLeftMsgCommand()
			},
			{
				EDropCatchCommandName.ShowFloatEff.ToEnumString(),
				new ShowFloatEffCommand()
			},
			{
				EDropCatchCommandName.ChangeRoleColor.ToEnumString(),
				new ChangeRoleColorCommand()
			},
			{
				EDropCatchCommandName.PostAudioEvent.ToEnumString(),
				new PostAudioEventCommand()
			},
			{
				EDropCatchCommandName.PlayFlow.ToEnumString(),
				new PlayFlowCommand()
			},
			{
				EDropCatchCommandName.SetInputEnabled.ToEnumString(),
				new SetInputEnabledCommand()
			}
		};

		// Token: 0x0401CC2A RID: 117802
		public readonly Dictionary<EDropCatchCommandName, Type> CommandParamsTypeMap = new Dictionary<EDropCatchCommandName, Type>
		{
			{
				EDropCatchCommandName.SpawnDropItem,
				typeof(ISpawnDropItemCommandParams)
			},
			{
				EDropCatchCommandName.AddEnergy,
				typeof(IAddEnergyCommandParams)
			},
			{
				EDropCatchCommandName.AddScore,
				typeof(IAddScoreCommandParams)
			},
			{
				EDropCatchCommandName.AddTime,
				typeof(IAddTimeCommandParams)
			},
			{
				EDropCatchCommandName.AddShield,
				typeof(IAddShieldCommandParams)
			},
			{
				EDropCatchCommandName.ConvertDropItem,
				typeof(IConvertDropItemCommandParams)
			},
			{
				EDropCatchCommandName.MoveRole,
				typeof(IMoveRoleCommandParams)
			},
			{
				EDropCatchCommandName.ModifyRoleSpeed,
				typeof(IModifyRoleSpeedCommandParams)
			},
			{
				EDropCatchCommandName.ModifyDropPoolTimeInterval,
				typeof(IModifyDropPoolTimeIntervalCommandParams)
			},
			{
				EDropCatchCommandName.ModifyAddScoreRate,
				typeof(IModifyAddScoreRateCommandParams)
			},
			{
				EDropCatchCommandName.ModifyEnergyGetRate,
				typeof(IModifyEnergyGetRateCommandParams)
			},
			{
				EDropCatchCommandName.ShowLeftMsg,
				typeof(IShowLeftMsgCommandParams)
			},
			{
				EDropCatchCommandName.ShowFloatEff,
				typeof(IShowFloatEffCommandParams)
			},
			{
				EDropCatchCommandName.ChangeRoleColor,
				typeof(IChangeRoleColorCommandParams)
			},
			{
				EDropCatchCommandName.PostAudioEvent,
				typeof(IPostAudioEventCommandParams)
			},
			{
				EDropCatchCommandName.PlayFlow,
				typeof(IPlayFlowCommandParams)
			},
			{
				EDropCatchCommandName.SetInputEnabled,
				typeof(ISetInputEnabledCommandParams)
			}
		};

		// Token: 0x0401CC2B RID: 117803
		public readonly EDropCatchGameplayInputSource[] InputPriority;

		// Token: 0x0401CC2C RID: 117804
		[Nullable(2)]
		private static DropCatchDefine _instance;
	}
}

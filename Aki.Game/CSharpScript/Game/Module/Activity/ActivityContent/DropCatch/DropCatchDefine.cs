using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066A2 RID: 26274
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchDefine : Singleton
	{
		// Token: 0x17009642 RID: 38466
		// (get) Token: 0x06041C64 RID: 269412 RVA: 0x00FF35BF File Offset: 0x00FF17BF
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

		// Token: 0x06041C65 RID: 269413 RVA: 0x00FF35E2 File Offset: 0x00FF17E2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041C66 RID: 269414 RVA: 0x00FF35E4 File Offset: 0x00FF17E4
		public static void ResetStaticDefaultValue()
		{
			DropCatchDefine instance = DropCatchDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			DropCatchDefine._instance = null;
		}

		// Token: 0x06041C67 RID: 269415 RVA: 0x00FF35FD File Offset: 0x00FF17FD
		static DropCatchDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchDefine.CreateStaticDefaultValue), new Action(DropCatchDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06041C68 RID: 269416 RVA: 0x00FF361C File Offset: 0x00FF181C
		public DropCatchDefine()
		{
			EDropCatchGameplayInputSource[] array = new EDropCatchGameplayInputSource[2];
			array[0] = EDropCatchGameplayInputSource.Command;
			this.InputPriority = array;
			base..ctor();
		}

		// Token: 0x040223D0 RID: 140240
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

		// Token: 0x040223D1 RID: 140241
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

		// Token: 0x040223D2 RID: 140242
		public readonly EDropCatchGameplayInputSource[] InputPriority;

		// Token: 0x040223D3 RID: 140243
		[Nullable(2)]
		private static DropCatchDefine _instance;
	}
}

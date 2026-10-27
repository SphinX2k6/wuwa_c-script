using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Input.BattleInputData;
using CSharpScript.Game.Utils;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FD0 RID: 28624
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InputModel : ModelBase
	{
		// Token: 0x060459D7 RID: 285143 RVA: 0x0114A018 File Offset: 0x01148218
		protected override bool OnInit()
		{
			this.InputDataMap[EInputDataType.NormalWorld] = new NormalWorldInputData();
			this.InputDataMap[EInputDataType.TrapDefense] = new TrapDefenseInputData();
			this.InputDataMap[EInputDataType.SurvivorsRogue] = new SurvivorsRogueInputData();
			this.InputDataMap[EInputDataType.NormalWorldMotor] = new NormalWorldMotorInputData();
			this.InputDataMap[EInputDataType.SpringManor] = new SpringManorInputData();
			this.InputDataMap[EInputDataType.PinballBattle] = new PinballBattleInputData();
			return true;
		}

		// Token: 0x060459D8 RID: 285144 RVA: 0x0114A08C File Offset: 0x0114828C
		public void SetCurrentInputDataType(EInputDataType dataType)
		{
			this.CurrentInputDataType = dataType;
		}

		// Token: 0x060459D9 RID: 285145 RVA: 0x0114A095 File Offset: 0x01148295
		public EInputDataType GetCurrentInputDataType()
		{
			return this.CurrentInputDataType;
		}

		// Token: 0x060459DA RID: 285146 RVA: 0x0114A0A0 File Offset: 0x011482A0
		[NullableContext(2)]
		public BattleInputData GetCurrentInputData()
		{
			BattleInputData result;
			if (this.InputDataMap.TryGetValue(this.CurrentInputDataType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060459DB RID: 285147 RVA: 0x0114A0C8 File Offset: 0x011482C8
		public BattleInputData GetInputData(EInputDataType dataType)
		{
			BattleInputData result;
			if (this.InputDataMap.TryGetValue(dataType, out result))
			{
				return result;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("InputData not found for type: ");
			defaultInterpolatedStringHandler.AppendFormatted<EInputDataType>(dataType);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060459DC RID: 285148 RVA: 0x0114A111 File Offset: 0x01148311
		public List<IInputHandler> GetHandlers()
		{
			return this.InputHandlers;
		}

		// Token: 0x060459DD RID: 285149 RVA: 0x0114A119 File Offset: 0x01148319
		public Dictionary<EInputAction, float> GetPressTimes()
		{
			return this.PressTimes;
		}

		// Token: 0x060459DE RID: 285150 RVA: 0x0114A121 File Offset: 0x01148321
		public Dictionary<EInputAction, float> GetHoldTimes()
		{
			return this.HoldTimes;
		}

		// Token: 0x060459DF RID: 285151 RVA: 0x0114A12C File Offset: 0x0114832C
		public float? GetHoldTime(EInputAction action)
		{
			if (!this.HoldTimes.ContainsKey(action))
			{
				return null;
			}
			return new float?(this.HoldTimes[action]);
		}

		// Token: 0x060459E0 RID: 285152 RVA: 0x0114A164 File Offset: 0x01148364
		public void SetHoldTime(EInputAction action, float? value = null)
		{
			float valueOrDefault = value.GetValueOrDefault();
			this.HoldTimes[action] = valueOrDefault;
		}

		// Token: 0x060459E1 RID: 285153 RVA: 0x0114A186 File Offset: 0x01148386
		public Dictionary<EInputAxis, float> GetAxisValues()
		{
			return this.AxisValues;
		}

		// Token: 0x17009B91 RID: 39825
		// (get) Token: 0x060459E2 RID: 285154 RVA: 0x0114A18E File Offset: 0x0114838E
		public bool LastClearAxisValue
		{
			get
			{
				return this.LastTemporaryClearAxisValue;
			}
		}

		// Token: 0x060459E3 RID: 285155 RVA: 0x0114A196 File Offset: 0x01148396
		public void ResetLastTemporaryClearAxisValues()
		{
			this.LastTemporaryClearAxisValue = false;
		}

		// Token: 0x060459E4 RID: 285156 RVA: 0x0114A19F File Offset: 0x0114839F
		public void TemporaryClearAxisValues()
		{
			this.LastTemporaryClearAxisValue = true;
			this.AxisValues.Clear();
		}

		// Token: 0x060459E5 RID: 285157 RVA: 0x0114A1B3 File Offset: 0x011483B3
		public void NextFrameRefreshAxisValues()
		{
			this.LastTemporaryClearAxisValue = true;
		}

		// Token: 0x060459E6 RID: 285158 RVA: 0x0114A1BC File Offset: 0x011483BC
		public int? QueryCommandPriority(ECommandType commandType)
		{
			int value;
			if (this.CommandPriorities.TryGetValue(commandType, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060459E7 RID: 285159 RVA: 0x0114A1EC File Offset: 0x011483EC
		public void AddInputHandler(IInputHandler handler)
		{
			if (this.InputHandlers.Contains(handler))
			{
				return;
			}
			this.InputHandlers.Add(handler);
			this.InputHandlers.Sort((IInputHandler a, IInputHandler b) => b.GetPriority() - a.GetPriority());
		}

		// Token: 0x060459E8 RID: 285160 RVA: 0x0114A240 File Offset: 0x01148440
		public bool IsAxisBlock(EInputAxis axis)
		{
			for (int i = 0; i < this.InputHandlers.Count; i++)
			{
				if (this.InputHandlers[i].GetInputFilter().BlockAxis(axis))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060459E9 RID: 285161 RVA: 0x0114A280 File Offset: 0x01148480
		public void RemoveInputHandler(IInputHandler handler)
		{
			int num = this.InputHandlers.IndexOf(handler);
			if (num == -1)
			{
				return;
			}
			this.InputHandlers.RemoveAt(num);
		}

		// Token: 0x060459EA RID: 285162 RVA: 0x0114A2AC File Offset: 0x011484AC
		protected override bool OnClear()
		{
			this.InputHandlers.Clear();
			this.PressTimes.Clear();
			this.HoldTimes.Clear();
			this.AxisValues.Clear();
			foreach (InputLayerUnit inputLayerUnit in this.InputLayers.Values)
			{
				inputLayerUnit.Clear();
			}
			this.InputLayers.Clear();
			return true;
		}

		// Token: 0x060459EB RID: 285163 RVA: 0x0114A33C File Offset: 0x0114853C
		public void AddInputLayer(int unitId, InputLayer layer)
		{
			InputLayerUnit inputLayerUnit;
			if (!this.InputLayers.TryGetValue(unitId, out inputLayerUnit))
			{
				inputLayerUnit = new InputLayerUnit();
				this.InputLayers[unitId] = inputLayerUnit;
			}
			inputLayerUnit.Add(layer);
		}

		// Token: 0x060459EC RID: 285164 RVA: 0x0114A374 File Offset: 0x01148574
		public void RemoveInputLayer(InputLayer layer)
		{
			InputLayerUnit inputLayerUnit;
			if (this.InputLayers.TryGetValue(layer.UnitId, out inputLayerUnit))
			{
				inputLayerUnit.Remove(layer);
				if (inputLayerUnit.LayerMap.Count == 0)
				{
					this.InputLayers.Remove(layer.UnitId);
				}
			}
		}

		// Token: 0x060459ED RID: 285165 RVA: 0x0114A3BC File Offset: 0x011485BC
		[NullableContext(2)]
		public InputLayer GetInputLayer(int unitId, EInputLayer layerType)
		{
			InputLayerUnit inputLayerUnit;
			if (!this.InputLayers.TryGetValue(unitId, out inputLayerUnit))
			{
				return null;
			}
			InputLayer result;
			if (!inputLayerUnit.LayerMap.TryGetValue(layerType, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060459EE RID: 285166 RVA: 0x0114A3F0 File Offset: 0x011485F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InputLayer> GetInputLayers(int unitId)
		{
			InputLayerUnit inputLayerUnit;
			if (!this.InputLayers.TryGetValue(unitId, out inputLayerUnit))
			{
				return null;
			}
			return inputLayerUnit.GetLayerList();
		}

		// Token: 0x060459EF RID: 285167 RVA: 0x0114A418 File Offset: 0x01148618
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public SInputCommandTransform[] GetInputCommandTransformData(EInputAction action, EInputState state)
		{
			if (!this.IsInitTransformMap)
			{
				this.InitInputCommandTransformMap();
			}
			if (this.InputCommandTransformMap == null)
			{
				return null;
			}
			Dictionary<EInputState, SInputCommandTransform[]> dictionary;
			if (!this.InputCommandTransformMap.TryGetValue(action, out dictionary))
			{
				return null;
			}
			SInputCommandTransform[] result;
			if (!dictionary.TryGetValue(state, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060459F0 RID: 285168 RVA: 0x0114A460 File Offset: 0x01148660
		public void InitInputCommandTransformMap()
		{
			if (this.IsInitTransformMap)
			{
				return;
			}
			this.IsInitTransformMap = true;
			Dictionary<EInputAction, Dictionary<EInputState, SInputCommandTransform[]>> dictionary = new Dictionary<EInputAction, Dictionary<EInputState, SInputCommandTransform[]>>();
			List<SInputCommandTransform> dataTableAllRow = DataTableUtil.GetDataTableAllRow<SInputCommandTransform>(EDataTable.InputCommandTransform);
			for (int i = 0; i < dataTableAllRow.Count; i++)
			{
				SInputCommandTransform sinputCommandTransform = dataTableAllRow[i];
				if (!(sinputCommandTransform.Action == EInputAction.None) && !(sinputCommandTransform.State == EInputState.None) && !(sinputCommandTransform.Tag.TagName == "None"))
				{
					if (!dictionary.ContainsKey(sinputCommandTransform.Action))
					{
						dictionary[sinputCommandTransform.Action] = new Dictionary<EInputState, SInputCommandTransform[]>();
					}
					Dictionary<EInputState, SInputCommandTransform[]> dictionary2 = dictionary[sinputCommandTransform.Action];
					if (!dictionary2.ContainsKey(sinputCommandTransform.State))
					{
						dictionary2[sinputCommandTransform.State] = new SInputCommandTransform[]
						{
							sinputCommandTransform
						};
					}
					else
					{
						SInputCommandTransform[] array = dictionary2[sinputCommandTransform.State];
						SInputCommandTransform[] array2 = new SInputCommandTransform[array.Length + 1];
						for (int j = 0; j < array.Length; j++)
						{
							array2[j] = array[j];
						}
						array2[array.Length] = sinputCommandTransform;
						dictionary2[sinputCommandTransform.State] = array2;
					}
				}
			}
			this.InputCommandTransformMap = dictionary;
		}

		// Token: 0x17009B92 RID: 39826
		// (get) Token: 0x060459F1 RID: 285169 RVA: 0x0114A5C4 File Offset: 0x011487C4
		public static InputModel Instance
		{
			get
			{
				return InputModel._Instance;
			}
		}

		// Token: 0x060459F2 RID: 285170 RVA: 0x0114A5CB File Offset: 0x011487CB
		public static InputModel GetOrCreateInstance()
		{
			if (InputModel._Instance == null)
			{
				InputModel.CreateInstance();
			}
			return InputModel._Instance;
		}

		// Token: 0x060459F3 RID: 285171 RVA: 0x0114A5DF File Offset: 0x011487DF
		public static bool CreateInstance()
		{
			if (InputModel._Instance != null)
			{
				return true;
			}
			InputModel._Instance = new InputModel();
			return true;
		}

		// Token: 0x060459F4 RID: 285172 RVA: 0x0114A5F5 File Offset: 0x011487F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060459F5 RID: 285173 RVA: 0x0114A5F7 File Offset: 0x011487F7
		public static void ResetStaticDefaultValue()
		{
			InputModel._Instance = null;
		}

		// Token: 0x060459F6 RID: 285174 RVA: 0x0114A5FF File Offset: 0x011487FF
		static InputModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputModel.CreateStaticDefaultValue), new Action(InputModel.ResetStaticDefaultValue));
		}

		// Token: 0x060459F7 RID: 285175 RVA: 0x0114A620 File Offset: 0x01148820
		public InputModel()
		{
			Dictionary<ECommandType, int> dictionary = new Dictionary<ECommandType, int>();
			dictionary[ECommandType.Jump] = 0;
			dictionary[ECommandType.Climb] = 0;
			dictionary[ECommandType.Sprint] = 0;
			dictionary[ECommandType.FastSwim] = 0;
			dictionary[ECommandType.FastClimb] = 0;
			dictionary[ECommandType.SwitchCharacter] = 0;
			dictionary[ECommandType.SwitchWalk] = 0;
			dictionary[ECommandType.SendGameplayEvent] = 0;
			dictionary[ECommandType.XaBoost] = 0;
			dictionary[ECommandType.Drop] = 0;
			this.CommandPriorities = dictionary;
			this.InputHandlers = new List<IInputHandler>();
			this.PressTimes = new Dictionary<EInputAction, float>();
			this.HoldTimes = new Dictionary<EInputAction, float>();
			this.AxisValues = new Dictionary<EInputAxis, float>();
			this.InputLayers = new Dictionary<int, InputLayerUnit>();
			this.OnlyMoveForward = new Switcher(false, null);
			this.InputDataMap = new Dictionary<EInputDataType, BattleInputData>();
			base..ctor();
		}

		// Token: 0x0402456B RID: 148843
		public const string INPUT_COMMAND_TRANSFORM_DT_PATH = "/Game/Aki/Data/Fight/DT_InputCommandTransform.DT_InputCommandTransform";

		// Token: 0x0402456C RID: 148844
		private readonly Dictionary<ECommandType, int> CommandPriorities;

		// Token: 0x0402456D RID: 148845
		private readonly List<IInputHandler> InputHandlers;

		// Token: 0x0402456E RID: 148846
		private readonly Dictionary<EInputAction, float> PressTimes;

		// Token: 0x0402456F RID: 148847
		private readonly Dictionary<EInputAction, float> HoldTimes;

		// Token: 0x04024570 RID: 148848
		private readonly Dictionary<EInputAxis, float> AxisValues;

		// Token: 0x04024571 RID: 148849
		private readonly Dictionary<int, InputLayerUnit> InputLayers;

		// Token: 0x04024572 RID: 148850
		public Switcher OnlyMoveForward;

		// Token: 0x04024573 RID: 148851
		public bool IsOpenInputAxisLog;

		// Token: 0x04024574 RID: 148852
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Dictionary<EInputAction, Dictionary<EInputState, SInputCommandTransform[]>> InputCommandTransformMap;

		// Token: 0x04024575 RID: 148853
		private bool IsInitTransformMap;

		// Token: 0x04024576 RID: 148854
		private readonly Dictionary<EInputDataType, BattleInputData> InputDataMap;

		// Token: 0x04024577 RID: 148855
		private EInputDataType CurrentInputDataType;

		// Token: 0x04024578 RID: 148856
		private bool LastTemporaryClearAxisValue;

		// Token: 0x04024579 RID: 148857
		[Nullable(2)]
		private static InputModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Input.BattleInputData;
using CSharpScript.Game.Utils;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006151 RID: 24913
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InputModel : ModelBase
	{
		// Token: 0x0603BB88 RID: 244616 RVA: 0x010F3E0C File Offset: 0x010F200C
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

		// Token: 0x0603BB89 RID: 244617 RVA: 0x010F3E80 File Offset: 0x010F2080
		public void SetCurrentInputDataType(EInputDataType dataType)
		{
			this.CurrentInputDataType = dataType;
		}

		// Token: 0x0603BB8A RID: 244618 RVA: 0x010F3E89 File Offset: 0x010F2089
		public EInputDataType GetCurrentInputDataType()
		{
			return this.CurrentInputDataType;
		}

		// Token: 0x0603BB8B RID: 244619 RVA: 0x010F3E94 File Offset: 0x010F2094
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

		// Token: 0x0603BB8C RID: 244620 RVA: 0x010F3EBC File Offset: 0x010F20BC
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

		// Token: 0x0603BB8D RID: 244621 RVA: 0x010F3F05 File Offset: 0x010F2105
		public List<IInputHandler> GetHandlers()
		{
			return this.InputHandlers;
		}

		// Token: 0x0603BB8E RID: 244622 RVA: 0x010F3F0D File Offset: 0x010F210D
		public Dictionary<EInputAction, float> GetPressTimes()
		{
			return this.PressTimes;
		}

		// Token: 0x0603BB8F RID: 244623 RVA: 0x010F3F15 File Offset: 0x010F2115
		public Dictionary<EInputAction, float> GetHoldTimes()
		{
			return this.HoldTimes;
		}

		// Token: 0x0603BB90 RID: 244624 RVA: 0x010F3F20 File Offset: 0x010F2120
		public float? GetHoldTime(EInputAction action)
		{
			if (!this.HoldTimes.ContainsKey(action))
			{
				return null;
			}
			return new float?(this.HoldTimes[action]);
		}

		// Token: 0x0603BB91 RID: 244625 RVA: 0x010F3F58 File Offset: 0x010F2158
		public void SetHoldTime(EInputAction action, float? value = null)
		{
			float valueOrDefault = value.GetValueOrDefault();
			this.HoldTimes[action] = valueOrDefault;
		}

		// Token: 0x0603BB92 RID: 244626 RVA: 0x010F3F7A File Offset: 0x010F217A
		public Dictionary<EInputAxis, float> GetAxisValues()
		{
			return this.AxisValues;
		}

		// Token: 0x170070D1 RID: 28881
		// (get) Token: 0x0603BB93 RID: 244627 RVA: 0x010F3F82 File Offset: 0x010F2182
		public bool LastClearAxisValue
		{
			get
			{
				return this.LastTemporaryClearAxisValue;
			}
		}

		// Token: 0x0603BB94 RID: 244628 RVA: 0x010F3F8A File Offset: 0x010F218A
		public void ResetLastTemporaryClearAxisValues()
		{
			this.LastTemporaryClearAxisValue = false;
		}

		// Token: 0x0603BB95 RID: 244629 RVA: 0x010F3F93 File Offset: 0x010F2193
		public void TemporaryClearAxisValues()
		{
			this.LastTemporaryClearAxisValue = true;
			this.AxisValues.Clear();
		}

		// Token: 0x0603BB96 RID: 244630 RVA: 0x010F3FA7 File Offset: 0x010F21A7
		public void NextFrameRefreshAxisValues()
		{
			this.LastTemporaryClearAxisValue = true;
		}

		// Token: 0x0603BB97 RID: 244631 RVA: 0x010F3FB0 File Offset: 0x010F21B0
		public int? QueryCommandPriority(ECommandType commandType)
		{
			int value;
			if (this.CommandPriorities.TryGetValue(commandType, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0603BB98 RID: 244632 RVA: 0x010F3FE0 File Offset: 0x010F21E0
		public void AddInputHandler(IInputHandler handler)
		{
			if (this.InputHandlers.Contains(handler))
			{
				return;
			}
			this.InputHandlers.Add(handler);
			this.InputHandlers.Sort((IInputHandler a, IInputHandler b) => b.GetPriority() - a.GetPriority());
		}

		// Token: 0x0603BB99 RID: 244633 RVA: 0x010F4034 File Offset: 0x010F2234
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

		// Token: 0x0603BB9A RID: 244634 RVA: 0x010F4074 File Offset: 0x010F2274
		public void RemoveInputHandler(IInputHandler handler)
		{
			int num = this.InputHandlers.IndexOf(handler);
			if (num == -1)
			{
				return;
			}
			this.InputHandlers.RemoveAt(num);
		}

		// Token: 0x0603BB9B RID: 244635 RVA: 0x010F40A0 File Offset: 0x010F22A0
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

		// Token: 0x0603BB9C RID: 244636 RVA: 0x010F4130 File Offset: 0x010F2330
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

		// Token: 0x0603BB9D RID: 244637 RVA: 0x010F4168 File Offset: 0x010F2368
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

		// Token: 0x0603BB9E RID: 244638 RVA: 0x010F41B0 File Offset: 0x010F23B0
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

		// Token: 0x0603BB9F RID: 244639 RVA: 0x010F41E4 File Offset: 0x010F23E4
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

		// Token: 0x0603BBA0 RID: 244640 RVA: 0x010F420C File Offset: 0x010F240C
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

		// Token: 0x0603BBA1 RID: 244641 RVA: 0x010F4254 File Offset: 0x010F2454
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

		// Token: 0x170070D2 RID: 28882
		// (get) Token: 0x0603BBA2 RID: 244642 RVA: 0x010F43B8 File Offset: 0x010F25B8
		public static InputModel Instance
		{
			get
			{
				return InputModel._Instance;
			}
		}

		// Token: 0x0603BBA3 RID: 244643 RVA: 0x010F43BF File Offset: 0x010F25BF
		public static InputModel GetOrCreateInstance()
		{
			if (InputModel._Instance == null)
			{
				InputModel.CreateInstance();
			}
			return InputModel._Instance;
		}

		// Token: 0x0603BBA4 RID: 244644 RVA: 0x010F43D3 File Offset: 0x010F25D3
		public static bool CreateInstance()
		{
			if (InputModel._Instance != null)
			{
				return true;
			}
			InputModel._Instance = new InputModel();
			return true;
		}

		// Token: 0x0603BBA5 RID: 244645 RVA: 0x010F43E9 File Offset: 0x010F25E9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BBA6 RID: 244646 RVA: 0x010F43EB File Offset: 0x010F25EB
		public static void ResetStaticDefaultValue()
		{
			InputModel._Instance = null;
		}

		// Token: 0x0603BBA7 RID: 244647 RVA: 0x010F43F3 File Offset: 0x010F25F3
		static InputModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputModel.CreateStaticDefaultValue), new Action(InputModel.ResetStaticDefaultValue));
		}

		// Token: 0x0603BBA8 RID: 244648 RVA: 0x010F4414 File Offset: 0x010F2614
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

		// Token: 0x0401F820 RID: 129056
		public const string INPUT_COMMAND_TRANSFORM_DT_PATH = "/Game/Aki/Data/Fight/DT_InputCommandTransform.DT_InputCommandTransform";

		// Token: 0x0401F821 RID: 129057
		private readonly Dictionary<ECommandType, int> CommandPriorities;

		// Token: 0x0401F822 RID: 129058
		private readonly List<IInputHandler> InputHandlers;

		// Token: 0x0401F823 RID: 129059
		private readonly Dictionary<EInputAction, float> PressTimes;

		// Token: 0x0401F824 RID: 129060
		private readonly Dictionary<EInputAction, float> HoldTimes;

		// Token: 0x0401F825 RID: 129061
		private readonly Dictionary<EInputAxis, float> AxisValues;

		// Token: 0x0401F826 RID: 129062
		private readonly Dictionary<int, InputLayerUnit> InputLayers;

		// Token: 0x0401F827 RID: 129063
		public Switcher OnlyMoveForward;

		// Token: 0x0401F828 RID: 129064
		public bool IsOpenInputAxisLog;

		// Token: 0x0401F829 RID: 129065
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Dictionary<EInputAction, Dictionary<EInputState, SInputCommandTransform[]>> InputCommandTransformMap;

		// Token: 0x0401F82A RID: 129066
		private bool IsInitTransformMap;

		// Token: 0x0401F82B RID: 129067
		private readonly Dictionary<EInputDataType, BattleInputData> InputDataMap;

		// Token: 0x0401F82C RID: 129068
		private EInputDataType CurrentInputDataType;

		// Token: 0x0401F82D RID: 129069
		private bool LastTemporaryClearAxisValue;

		// Token: 0x0401F82E RID: 129070
		[Nullable(2)]
		private static InputModel _Instance;
	}
}

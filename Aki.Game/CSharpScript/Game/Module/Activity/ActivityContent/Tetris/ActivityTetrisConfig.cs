using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FC6 RID: 24518
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityTetrisConfig : ConfigBase
	{
		// Token: 0x0603E233 RID: 254515 RVA: 0x00F01D54 File Offset: 0x00EFFF54
		public List<IShapeConfig> GetAllShape()
		{
			List<IShapeConfig> list = new List<IShapeConfig>();
			foreach (TetrisShape tetrisShape in ConfigTetrisShapeAll.GetConfigList(true))
			{
				list.Add(this.GetTetrisShape(tetrisShape.Id));
			}
			return list;
		}

		// Token: 0x0603E234 RID: 254516 RVA: 0x00F01DB4 File Offset: 0x00EFFFB4
		public IShapeConfig GetTetrisShape(int id)
		{
			TetrisShape value = ConfigTetrisShapeById.GetConfig(id, true).Value;
			string[] array = new string[]
			{
				value.Column1,
				value.Column2,
				value.Column3,
				value.Column4,
				value.Column5
			};
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					if (array[i].Length > num)
					{
						num = array[i].Length;
					}
					num2 = i + 1;
				}
			}
			if (num == 0)
			{
				return new ShapeConfig
				{
					Id = value.Id,
					Weight = value.Weight,
					Matrix = new int[0][]
				};
			}
			int[][] array2 = new int[num][];
			for (int j = 0; j < num; j++)
			{
				array2[j] = new int[num2];
			}
			for (int k = 0; k < num2; k++)
			{
				string text = array[k];
				for (int l = 0; l < num; l++)
				{
					char c = (text != null && l < text.Length) ? text[l] : '0';
					array2[l][k] = ((c == '1') ? 1 : 0);
				}
			}
			return new ShapeConfig
			{
				Id = value.Id,
				Weight = value.Weight,
				Matrix = array2
			};
		}

		// Token: 0x0603E235 RID: 254517 RVA: 0x00F01F10 File Offset: 0x00F00110
		public TetrisBoardItemConfig[][] GetTetrisMap(int id)
		{
			TetrisBoardItemConfig[][] array = new TetrisBoardItemConfig[8][];
			IReadOnlyList<TetrisMap> configList = ConfigTetrisMapByMapId.GetConfigList(id, true);
			for (int i = 0; i < 8; i++)
			{
				array[i] = new TetrisBoardItemConfig[8];
				for (int j = 0; j < 8; j++)
				{
					string name = StringUtils.Format("Column{0}", new string[]
					{
						(j + 1).ToString()
					});
					array[i][j] = (TetrisBoardItemConfig)configList[i].GetType().GetProperty(name).GetValue(configList[i]);
				}
			}
			return array;
		}

		// Token: 0x0603E236 RID: 254518 RVA: 0x00F01FA8 File Offset: 0x00F001A8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IShapeConfig> GetBlocksFromConfig(int levelId, int roundIndex)
		{
			IReadOnlyList<TetrisPreset> configList = ConfigTetrisPresetByLevelIdAndRound.GetConfigList(levelId, roundIndex, true);
			if (configList == null)
			{
				return null;
			}
			List<IShapeConfig> list = new List<IShapeConfig>();
			foreach (TetrisPreset tetrisPreset in configList)
			{
				IShapeConfig tetrisShape = this.GetTetrisShape(tetrisPreset.ShapeId);
				list.Add(tetrisShape);
			}
			return list;
		}

		// Token: 0x0603E237 RID: 254519 RVA: 0x00F02018 File Offset: 0x00F00218
		public List<ITetrisSelectGroupData> GetAllGroupByActivityId(int activityId)
		{
			IReadOnlyList<Tetris> configList = ConfigTetrisByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "俄罗斯方块配置找不到对应的活动id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new List<ITetrisSelectGroupData>();
			}
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (Tetris tetris in configList)
			{
				if (!dictionary.ContainsKey(tetris.GroupId))
				{
					dictionary.Add(tetris.GroupId, new List<int>());
				}
				dictionary[tetris.GroupId].Add(tetris.Id);
			}
			List<ITetrisSelectGroupData> list = new List<ITetrisSelectGroupData>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				list.Add(new TetrisSelectGroupData
				{
					GroupId = keyValuePair.Key,
					ChallengeIds = keyValuePair.Value
				});
			}
			return list;
		}

		// Token: 0x0603E238 RID: 254520 RVA: 0x00F02140 File Offset: 0x00F00340
		public Tetris GetLevelConfig(int id)
		{
			Tetris? config = ConfigTetrisById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "俄罗斯方块找不到对应关卡配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config.Value;
		}

		// Token: 0x0603E239 RID: 254521 RVA: 0x00F02190 File Offset: 0x00F00390
		public unsafe IReadOnlyList<Tetris> GetGroupLevels(int activityId, int groupId)
		{
			IReadOnlyList<Tetris> configList = ConfigTetrisByActivityIdAndGroupId.GetConfigList(activityId, groupId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "俄罗斯方块找不到对应关卡配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("groupId", groupId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return configList;
		}

		// Token: 0x0603E23A RID: 254522 RVA: 0x00F02204 File Offset: 0x00F00404
		public TetrisSetting? GetSetting(string key)
		{
			TetrisSetting? config = ConfigTetrisSettingByKey.GetConfig(key, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "俄罗斯方块找不到对应游戏设置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new TetrisSetting?(config.Value);
		}

		// Token: 0x0603E23B RID: 254523 RVA: 0x00F02260 File Offset: 0x00F00460
		public TetrisGem? GetGemConfig(int id)
		{
			TetrisGem? config = ConfigTetrisGemById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "俄罗斯方块找不到对应宝石配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new TetrisGem?(config.Value);
		}

		// Token: 0x17008FFC RID: 36860
		// (get) Token: 0x0603E23C RID: 254524 RVA: 0x00F022BF File Offset: 0x00F004BF
		public static ActivityTetrisConfig Instance
		{
			get
			{
				return ActivityTetrisConfig._Instance;
			}
		}

		// Token: 0x0603E23D RID: 254525 RVA: 0x00F022C6 File Offset: 0x00F004C6
		public static ActivityTetrisConfig GetOrCreateInstance()
		{
			if (ActivityTetrisConfig._Instance == null)
			{
				ActivityTetrisConfig.CreateInstance();
			}
			return ActivityTetrisConfig._Instance;
		}

		// Token: 0x0603E23E RID: 254526 RVA: 0x00F022DA File Offset: 0x00F004DA
		public static bool CreateInstance()
		{
			if (ActivityTetrisConfig._Instance != null)
			{
				return true;
			}
			ActivityTetrisConfig._Instance = new ActivityTetrisConfig();
			return true;
		}

		// Token: 0x0603E23F RID: 254527 RVA: 0x00F022F0 File Offset: 0x00F004F0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E240 RID: 254528 RVA: 0x00F022F2 File Offset: 0x00F004F2
		public static void ResetStaticDefaultValue()
		{
			ActivityTetrisConfig._Instance = null;
		}

		// Token: 0x0603E241 RID: 254529 RVA: 0x00F022FA File Offset: 0x00F004FA
		static ActivityTetrisConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityTetrisConfig.CreateStaticDefaultValue), new Action(ActivityTetrisConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020765 RID: 132965
		[Nullable(2)]
		private static ActivityTetrisConfig _Instance;
	}
}

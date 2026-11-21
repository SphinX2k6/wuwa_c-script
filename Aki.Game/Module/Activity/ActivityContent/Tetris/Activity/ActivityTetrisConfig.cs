using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Activity
{
	// Token: 0x02002FF6 RID: 12278
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	[StaticVariableRuleIgnore]
	public class ActivityTetrisConfig : ConfigBase
	{
		// Token: 0x0601D244 RID: 119364 RVA: 0x008E7520 File Offset: 0x008E5720
		public static List<ShapeConfig> GetAllShape()
		{
			if (ActivityTetrisConfig.CachedShapeConfigList == null)
			{
				IReadOnlyList<TetrisShape> configList = ConfigTetrisShapeAll.GetConfigList(true);
				if (configList == null)
				{
					ActivityTetrisConfig.CachedShapeConfigList = new List<ShapeConfig>();
				}
				else
				{
					ActivityTetrisConfig.CachedShapeConfigList = new List<ShapeConfig>(configList.Count);
					foreach (TetrisShape tetrisShape in configList)
					{
						ActivityTetrisConfig.CachedShapeConfigList.Add(ActivityTetrisConfig.GetTetrisShape(tetrisShape.Id));
					}
				}
			}
			return ActivityTetrisConfig.CachedShapeConfigList;
		}

		// Token: 0x0601D245 RID: 119365 RVA: 0x008E75AC File Offset: 0x008E57AC
		public static ShapeConfig GetTetrisShape(int id)
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
				if (array[i].Length != 0)
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
				return new ShapeConfig(value.Id, new byte[0, 0], value.Weight);
			}
			byte[,] array2 = new byte[num, num2];
			for (int j = 0; j < num2; j++)
			{
				string text = array[j];
				for (int k = 0; k < num; k++)
				{
					char c = (text != null && k < text.Length) ? text[k] : '0';
					array2[k, j] = ((c == '1') ? 1 : 0);
				}
			}
			return new ShapeConfig(value.Id, array2, value.Weight);
		}

		// Token: 0x0601D246 RID: 119366 RVA: 0x008E76D4 File Offset: 0x008E58D4
		public static int GetShapeMaxCellCount()
		{
			if (ActivityTetrisConfig.CachedShapeMaxCellCount < 0)
			{
				foreach (ShapeConfig shapeConfig in ActivityTetrisConfig.GetAllShape())
				{
					int num = 0;
					for (int i = 0; i < shapeConfig.Matrix.GetLength(0); i++)
					{
						for (int j = 0; j < shapeConfig.Matrix.GetLength(1); j++)
						{
							num += (int)shapeConfig.Matrix[i, j];
						}
					}
					if (ActivityTetrisConfig.CachedShapeMaxCellCount < num)
					{
						ActivityTetrisConfig.CachedShapeMaxCellCount = num;
					}
				}
			}
			return ActivityTetrisConfig.CachedShapeMaxCellCount;
		}

		// Token: 0x0601D247 RID: 119367 RVA: 0x008E7784 File Offset: 0x008E5984
		public TetrisBoardItemConfig[,] GetTetrisMap(int id)
		{
			IReadOnlyList<TetrisMap> configList = ConfigTetrisMapByMapId.GetConfigList(id, true);
			if (configList == null)
			{
				return new TetrisBoardItemConfig[0, 0];
			}
			TetrisBoardItemConfig[,] array = new TetrisBoardItemConfig[8, 8];
			for (int i = 0; i < 8; i++)
			{
				array[i, 0] = configList[i].Column1.GetValueOrDefault();
				array[i, 1] = configList[i].Column2.GetValueOrDefault();
				array[i, 2] = configList[i].Column3.GetValueOrDefault();
				array[i, 3] = configList[i].Column4.GetValueOrDefault();
				array[i, 4] = configList[i].Column5.GetValueOrDefault();
				array[i, 5] = configList[i].Column6.GetValueOrDefault();
				array[i, 6] = configList[i].Column7.GetValueOrDefault();
				array[i, 7] = configList[i].Column8.GetValueOrDefault();
			}
			return array;
		}

		// Token: 0x0601D248 RID: 119368 RVA: 0x008E78BF File Offset: 0x008E5ABF
		[NullableContext(2)]
		public IReadOnlyList<TetrisPreset> GetPresetConfigList(int levelId, int roundIndex)
		{
			return ConfigTetrisPresetByLevelIdAndRound.GetConfigList(levelId, roundIndex, true);
		}

		// Token: 0x0601D249 RID: 119369 RVA: 0x008E78CC File Offset: 0x008E5ACC
		public List<TetrisSelectGroupData> GetAllGroupByActivityId(int activityId)
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
				return new List<TetrisSelectGroupData>();
			}
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (Tetris tetris in configList)
			{
				List<int> list;
				if (!dictionary.TryGetValue(tetris.GroupId, out list))
				{
					dictionary.Add(tetris.GroupId, new List<int>());
				}
				dictionary[tetris.GroupId].Add(tetris.Id);
			}
			List<TetrisSelectGroupData> list2 = new List<TetrisSelectGroupData>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				list2.Add(new TetrisSelectGroupData
				{
					GroupId = keyValuePair.Key,
					ChallengeIds = keyValuePair.Value
				});
			}
			return list2;
		}

		// Token: 0x0601D24A RID: 119370 RVA: 0x008E79F8 File Offset: 0x008E5BF8
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

		// Token: 0x0601D24B RID: 119371 RVA: 0x008E7A48 File Offset: 0x008E5C48
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

		// Token: 0x0601D24C RID: 119372 RVA: 0x008E7ABC File Offset: 0x008E5CBC
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

		// Token: 0x0601D24D RID: 119373 RVA: 0x008E7B18 File Offset: 0x008E5D18
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

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0601D24E RID: 119374 RVA: 0x008E7B77 File Offset: 0x008E5D77
		public static ActivityTetrisConfig Instance
		{
			get
			{
				return ActivityTetrisConfig._Instance;
			}
		}

		// Token: 0x0601D24F RID: 119375 RVA: 0x008E7B7E File Offset: 0x008E5D7E
		public static ActivityTetrisConfig GetOrCreateInstance()
		{
			if (ActivityTetrisConfig._Instance == null)
			{
				ActivityTetrisConfig.CreateInstance();
			}
			return ActivityTetrisConfig._Instance;
		}

		// Token: 0x0601D250 RID: 119376 RVA: 0x008E7B92 File Offset: 0x008E5D92
		public static bool CreateInstance()
		{
			if (ActivityTetrisConfig._Instance != null)
			{
				return true;
			}
			ActivityTetrisConfig._Instance = new ActivityTetrisConfig();
			return true;
		}

		// Token: 0x0601D251 RID: 119377 RVA: 0x008E7BA8 File Offset: 0x008E5DA8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D252 RID: 119378 RVA: 0x008E7BAA File Offset: 0x008E5DAA
		public static void ResetStaticDefaultValue()
		{
			ActivityTetrisConfig._Instance = null;
		}

		// Token: 0x0601D253 RID: 119379 RVA: 0x008E7BB2 File Offset: 0x008E5DB2
		static ActivityTetrisConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityTetrisConfig.CreateStaticDefaultValue), new Action(ActivityTetrisConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0400F589 RID: 62857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<ShapeConfig> CachedShapeConfigList;

		// Token: 0x0400F58A RID: 62858
		private static int CachedShapeMaxCellCount = -1;

		// Token: 0x0400F58B RID: 62859
		[Nullable(2)]
		private static ActivityTetrisConfig _Instance;
	}
}

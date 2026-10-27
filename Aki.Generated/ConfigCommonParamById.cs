using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000006 RID: 6
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigCommonParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0005A6D6 File Offset: 0x000588D6
		static ConfigCommonParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonParamById.CreateStaticDefaultValue), new Action(ConfigCommonParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0005A6F8 File Offset: 0x000588F8
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_common_param.db"),
				new ValueTuple<string, object>("文件", "c.参数.xlsx"),
				new ValueTuple<string, object>("表名", "CommonParam"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonParam` where KeyName = ?")
			});
			ConfigCommonParamById.IntCache = new Dictionary<string, int>();
			ConfigCommonParamById.FloatCache = new Dictionary<string, float>();
			ConfigCommonParamById.Long54Cache = new Dictionary<string, long>();
			ConfigCommonParamById.boolCache = new Dictionary<string, bool>();
			ConfigCommonParamById.stringCache = new Dictionary<string, string>();
			ConfigCommonParamById.IntListCache = new Dictionary<string, int[]>();
			ConfigCommonParamById.FloatListCache = new Dictionary<string, float[]>();
			ConfigCommonParamById.Long54ListCache = new Dictionary<string, long[]>();
			ConfigCommonParamById.StringListCache = new Dictionary<string, string[]>();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0005A7D4 File Offset: 0x000589D4
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonParamById.LogPair = null;
			ConfigCommonParamById.HandleId = 0;
			ConfigCommonParamById.IntCache = null;
			ConfigCommonParamById.FloatCache = null;
			ConfigCommonParamById.Long54Cache = null;
			ConfigCommonParamById.boolCache = null;
			ConfigCommonParamById.stringCache = null;
			ConfigCommonParamById.IntListCache = null;
			ConfigCommonParamById.FloatListCache = null;
			ConfigCommonParamById.Long54ListCache = null;
			ConfigCommonParamById.StringListCache = null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0005A823 File Offset: 0x00058A23
		public static void Init()
		{
			ConfigCommonParamById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonParamById.HandleId, "db_common_param.db", "select BinData from `CommonParam` where KeyName = ?");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0005A840 File Offset: 0x00058A40
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static ValueTuple<bool, byte[]> GetDataView(string id)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonParamById.HandleId, new LogList<ValueTuple<string, object>>
			{
				new ValueTuple<string, object>("command", "select BinData from `CommonParam` where KeyName = ?")
			}))
			{
				return new ValueTuple<bool, byte[]>(false, null);
			}
			if (!ConfigCommon.BindString(ConfigCommonParamById.HandleId, 1, id, ConfigCommonParamById.LogPair))
			{
				ConfigCommon.Reset(ConfigCommonParamById.HandleId, new LogList<ValueTuple<string, object>>());
				return new ValueTuple<bool, byte[]>(false, null);
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			if (ConfigCommon.Step(ConfigCommonParamById.HandleId, true, ConfigCommonParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonParamById.HandleId, new LogList<ValueTuple<string, object>>());
				return new ValueTuple<bool, byte[]>(false, null);
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonParamById.HandleId, 0, ConfigCommonParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			ConfigCommon.Reset(ConfigCommonParamById.HandleId, new LogList<ValueTuple<string, object>>());
			return new ValueTuple<bool, byte[]>(item, item2.ToArray<byte>());
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0005A934 File Offset: 0x00058B34
		public static int? GetIntConfig(string id)
		{
			int value;
			if (ConfigCommonParamById.IntCache.TryGetValue(id, out value))
			{
				return new int?(value);
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<int> deserializeConfigResult = DeserializeConfig.Instance.ParseInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			ConfigCommonParamById.IntCache[id] = deserializeConfigResult.Value;
			return new int?(deserializeConfigResult.Value);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0005A9D8 File Offset: 0x00058BD8
		public static float? GetFloatConfig(string id)
		{
			float value;
			if (ConfigCommonParamById.FloatCache.TryGetValue(id, out value))
			{
				return new float?(value);
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<float> deserializeConfigResult = DeserializeConfig.Instance.ParseFloat(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			ConfigCommonParamById.FloatCache[id] = deserializeConfigResult.Value;
			return new float?(deserializeConfigResult.Value);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0005AA7C File Offset: 0x00058C7C
		public static long? GetLong54Config(string id)
		{
			long value;
			if (ConfigCommonParamById.Long54Cache.TryGetValue(id, out value))
			{
				return new long?(value);
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<long> deserializeConfigResult = DeserializeConfig.Instance.ParseBigInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			ConfigCommonParamById.Long54Cache[id] = deserializeConfigResult.Value;
			return new long?(deserializeConfigResult.Value);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0005AB20 File Offset: 0x00058D20
		public static bool? GetBoolConfig(string id)
		{
			bool value;
			if (ConfigCommonParamById.boolCache.TryGetValue(id, out value))
			{
				return new bool?(value);
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<bool> deserializeConfigResult = DeserializeConfig.Instance.ParseBoolean(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			ConfigCommonParamById.boolCache[id] = deserializeConfigResult.Value;
			return new bool?(deserializeConfigResult.Value);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0005ABC4 File Offset: 0x00058DC4
		[return: Nullable(2)]
		public static string GetStringConfig(string id)
		{
			string result;
			if (ConfigCommonParamById.stringCache.TryGetValue(id, out result))
			{
				return result;
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseString(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			ConfigCommonParamById.stringCache[id] = deserializeConfigResult.Value;
			return deserializeConfigResult.Value;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0005AC4C File Offset: 0x00058E4C
		[return: Nullable(2)]
		public static IReadOnlyList<int> GetIntArrayConfig(string id)
		{
			int[] array;
			if (ConfigCommonParamById.IntListCache.TryGetValue(id, out array))
			{
				return array;
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<int> deserializeConfigResult = DeserializeConfig.Instance.ParseInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			int position = deserializeConfigResult.Position;
			array = new int[deserializeConfigResult.Value];
			for (int i = 0; i < deserializeConfigResult.Value; i++)
			{
				DeserializeConfigResult<int> deserializeConfigResult2 = DeserializeConfig.Instance.ParseInt(item2, position, ConfigCommonParamById.LogPair);
				if (!deserializeConfigResult2.Success)
				{
					return null;
				}
				position = deserializeConfigResult2.Position;
				array[i] = deserializeConfigResult2.Value;
			}
			ConfigCommonParamById.IntListCache[id] = array;
			return array;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0005AD28 File Offset: 0x00058F28
		[return: Nullable(2)]
		public static IReadOnlyList<float> GetFloatArrayConfig(string id)
		{
			float[] array;
			if (ConfigCommonParamById.FloatListCache.TryGetValue(id, out array))
			{
				return array;
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<int> deserializeConfigResult = DeserializeConfig.Instance.ParseInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			int position = deserializeConfigResult.Position;
			array = new float[deserializeConfigResult.Value];
			for (int i = 0; i < deserializeConfigResult.Value; i++)
			{
				DeserializeConfigResult<float> deserializeConfigResult2 = DeserializeConfig.Instance.ParseFloat(item2, position, ConfigCommonParamById.LogPair);
				if (!deserializeConfigResult2.Success)
				{
					return null;
				}
				position = deserializeConfigResult2.Position;
				array[i] = deserializeConfigResult2.Value;
			}
			ConfigCommonParamById.FloatListCache[id] = array;
			return array;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0005AE04 File Offset: 0x00059004
		[return: Nullable(2)]
		public static IReadOnlyList<long> GetLong54ArrayConfig(string id)
		{
			long[] array;
			if (ConfigCommonParamById.Long54ListCache.TryGetValue(id, out array))
			{
				return array;
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<int> deserializeConfigResult = DeserializeConfig.Instance.ParseInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			array = new long[deserializeConfigResult.Value];
			int position = deserializeConfigResult.Position;
			for (int i = 0; i < deserializeConfigResult.Value; i++)
			{
				DeserializeConfigResult<long> deserializeConfigResult2 = DeserializeConfig.Instance.ParseBigInt(item2, position, ConfigCommonParamById.LogPair);
				if (!deserializeConfigResult2.Success)
				{
					return null;
				}
				position = deserializeConfigResult2.Position;
				array[i] = deserializeConfigResult2.Value;
			}
			ConfigCommonParamById.Long54ListCache[id] = array;
			return array;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0005AEE0 File Offset: 0x000590E0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> GetStringArrayConfig(string id)
		{
			string[] array;
			if (ConfigCommonParamById.StringListCache.TryGetValue(id, out array))
			{
				return array;
			}
			ValueTuple<bool, byte[]> dataView = ConfigCommonParamById.GetDataView(id);
			bool item = dataView.Item1;
			byte[] item2 = dataView.Item2;
			if (!item)
			{
				return null;
			}
			ConfigCommonParamById.LogPair.Clear();
			ConfigCommonParamById.LogPair.Add(new ValueTuple<string, object>("Id", id));
			DeserializeConfigResult<int> deserializeConfigResult = DeserializeConfig.Instance.ParseInt(item2, 0, ConfigCommonParamById.LogPair);
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			int position = deserializeConfigResult.Position;
			array = new string[deserializeConfigResult.Value];
			for (int i = 0; i < deserializeConfigResult.Value; i++)
			{
				DeserializeConfigResult<string> deserializeConfigResult2 = DeserializeConfig.Instance.ParseString(item2, position, ConfigCommonParamById.LogPair);
				if (!deserializeConfigResult2.Success)
				{
					return null;
				}
				position = deserializeConfigResult2.Position;
				array[i] = deserializeConfigResult2.Value;
			}
			ConfigCommonParamById.StringListCache[id] = array;
			return array;
		}

		// Token: 0x0400000F RID: 15
		private const string FILE = "c.参数.xlsx";

		// Token: 0x04000010 RID: 16
		private const string DB = "db_common_param.db";

		// Token: 0x04000011 RID: 17
		private const string TABLE = "CommonParam";

		// Token: 0x04000012 RID: 18
		private const string COMMAND = "select BinData from `CommonParam` where KeyName = ?";

		// Token: 0x04000013 RID: 19
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000014 RID: 20
		private static int HandleId;

		// Token: 0x04000015 RID: 21
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, int> IntCache;

		// Token: 0x04000016 RID: 22
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, float> FloatCache;

		// Token: 0x04000017 RID: 23
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, long> Long54Cache;

		// Token: 0x04000018 RID: 24
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, bool> boolCache;

		// Token: 0x04000019 RID: 25
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, string> stringCache;

		// Token: 0x0400001A RID: 26
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, int[]> IntListCache;

		// Token: 0x0400001B RID: 27
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, float[]> FloatListCache;

		// Token: 0x0400001C RID: 28
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, long[]> Long54ListCache;

		// Token: 0x0400001D RID: 29
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<string, string[]> StringListCache;
	}
}

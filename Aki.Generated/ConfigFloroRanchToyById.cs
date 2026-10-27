using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000332 RID: 818
	public class ConfigFloroRanchToyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x000C5D1F File Offset: 0x000C3F1F
		static ConfigFloroRanchToyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchToyById.CreateStaticDefaultValue), new Action(ConfigFloroRanchToyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000C5D40 File Offset: 0x000C3F40
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchToyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchToyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchToy"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchToy` where Id=?")
			});
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000C5DBF File Offset: 0x000C3FBF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchToyById.LogPair = null;
			ConfigFloroRanchToyById.HandleId = 0;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000C5DCD File Offset: 0x000C3FCD
		public static void Init()
		{
			ConfigFloroRanchToyById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchToyById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchToy` where Id=?");
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000C5DE8 File Offset: 0x000C3FE8
		public static FloroRanchToy? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchToyById.HandleId, ConfigFloroRanchToyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchToyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchToy?(FloroRanchToy.GetRootAsFloroRanchToy(configBuffer));
				}
			}
			ConfigFloroRanchToyById.LogPair.Clear();
			ConfigFloroRanchToyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchToyById.HandleId, 1, p0Id, ConfigFloroRanchToyById.LogPair) || ConfigCommon.Step(ConfigFloroRanchToyById.HandleId, true, ConfigFloroRanchToyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchToyById.HandleId, ConfigFloroRanchToyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchToyById.HandleId, 0, ConfigFloroRanchToyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchToyById.HandleId, ConfigFloroRanchToyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchToy rootAsFloroRanchToy = FloroRanchToy.GetRootAsFloroRanchToy(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchToyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchToyById.HandleId, ConfigFloroRanchToyById.LogPair);
			return new FloroRanchToy?(rootAsFloroRanchToy);
		}

		// Token: 0x04001642 RID: 5698
		private const string DB = "db_flororanch.db";

		// Token: 0x04001643 RID: 5699
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001644 RID: 5700
		private const string TABLE = "FloroRanchToy";

		// Token: 0x04001645 RID: 5701
		private const string COMMAND = "select BinData from `FloroRanchToy` where Id=?";

		// Token: 0x04001646 RID: 5702
		private const string KEY_PREFIX = "FloroRanchToyById";

		// Token: 0x04001647 RID: 5703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001648 RID: 5704
		private static int HandleId;
	}
}

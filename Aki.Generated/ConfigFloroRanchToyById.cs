using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000347 RID: 839
	public class ConfigFloroRanchToyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x000CC22B File Offset: 0x000CA42B
		static ConfigFloroRanchToyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchToyById.CreateStaticDefaultValue), new Action(ConfigFloroRanchToyById.ResetStaticDefaultValue));
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000CC24C File Offset: 0x000CA44C
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

		// Token: 0x060013B1 RID: 5041 RVA: 0x000CC2CB File Offset: 0x000CA4CB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchToyById.LogPair = null;
			ConfigFloroRanchToyById.HandleId = 0;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000CC2D9 File Offset: 0x000CA4D9
		public static void Init()
		{
			ConfigFloroRanchToyById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchToyById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchToy` where Id=?");
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000CC2F4 File Offset: 0x000CA4F4
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

		// Token: 0x040016D5 RID: 5845
		private const string DB = "db_flororanch.db";

		// Token: 0x040016D6 RID: 5846
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016D7 RID: 5847
		private const string TABLE = "FloroRanchToy";

		// Token: 0x040016D8 RID: 5848
		private const string COMMAND = "select BinData from `FloroRanchToy` where Id=?";

		// Token: 0x040016D9 RID: 5849
		private const string KEY_PREFIX = "FloroRanchToyById";

		// Token: 0x040016DA RID: 5850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016DB RID: 5851
		private static int HandleId;
	}
}

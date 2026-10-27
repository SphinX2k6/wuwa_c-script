using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000167 RID: 359
	public class ConfigCiacconaGalChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00089070 File Offset: 0x00087270
		static ConfigCiacconaGalChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChoiceById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00089090 File Offset: 0x00087290
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalChoiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalChoiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalChoice` where Id=?")
			});
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0008910F File Offset: 0x0008730F
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChoiceById.LogPair = null;
			ConfigCiacconaGalChoiceById.HandleId = 0;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0008911D File Offset: 0x0008731D
		public static void Init()
		{
			ConfigCiacconaGalChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChoiceById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChoice` where Id=?");
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00089138 File Offset: 0x00087338
		public static CiacconaGalChoice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalChoice?(CiacconaGalChoice.GetRootAsCiacconaGalChoice(configBuffer));
				}
			}
			ConfigCiacconaGalChoiceById.LogPair.Clear();
			ConfigCiacconaGalChoiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalChoiceById.HandleId, 1, p0Id, ConfigCiacconaGalChoiceById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalChoiceById.HandleId, true, ConfigCiacconaGalChoiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalChoiceById.HandleId, 0, ConfigCiacconaGalChoiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalChoice rootAsCiacconaGalChoice = CiacconaGalChoice.GetRootAsCiacconaGalChoice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
			return new CiacconaGalChoice?(rootAsCiacconaGalChoice);
		}

		// Token: 0x040009B5 RID: 2485
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009B6 RID: 2486
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009B7 RID: 2487
		private const string TABLE = "CiacconaGalChoice";

		// Token: 0x040009B8 RID: 2488
		private const string COMMAND = "select BinData from `CiacconaGalChoice` where Id=?";

		// Token: 0x040009B9 RID: 2489
		private const string KEY_PREFIX = "CiacconaGalChoiceById";

		// Token: 0x040009BA RID: 2490
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009BB RID: 2491
		private static int HandleId;
	}
}

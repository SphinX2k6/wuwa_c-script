using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041D RID: 1053
	public class ConfigInfluenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018B7 RID: 6327 RVA: 0x000E56CF File Offset: 0x000E38CF
		static ConfigInfluenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfluenceById.CreateStaticDefaultValue), new Action(ConfigInfluenceById.ResetStaticDefaultValue));
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000E56F0 File Offset: 0x000E38F0
		public static void CreateStaticDefaultValue()
		{
			ConfigInfluenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfluenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_influence.db"),
				new ValueTuple<string, object>("文件", "s.势力.xlsx"),
				new ValueTuple<string, object>("表名", "Influence"),
				new ValueTuple<string, object>("语句", "select BinData from `Influence` where Id=?")
			});
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000E576F File Offset: 0x000E396F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfluenceById.LogPair = null;
			ConfigInfluenceById.HandleId = 0;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000E577D File Offset: 0x000E397D
		public static void Init()
		{
			ConfigInfluenceById.HandleId = ConfigCommon.InitDataStatement(ConfigInfluenceById.HandleId, "db_influence.db", "select BinData from `Influence` where Id=?");
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000E5798 File Offset: 0x000E3998
		public static Influence? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfluenceById.HandleId, ConfigInfluenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Influence?(Influence.GetRootAsInfluence(configBuffer));
				}
			}
			ConfigInfluenceById.LogPair.Clear();
			ConfigInfluenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfluenceById.HandleId, 1, p0Id, ConfigInfluenceById.LogPair) || ConfigCommon.Step(ConfigInfluenceById.HandleId, true, ConfigInfluenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfluenceById.HandleId, ConfigInfluenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfluenceById.HandleId, 0, ConfigInfluenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfluenceById.HandleId, ConfigInfluenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Influence rootAsInfluence = Influence.GetRootAsInfluence(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfluenceById.HandleId, ConfigInfluenceById.LogPair);
			return new Influence?(rootAsInfluence);
		}

		// Token: 0x04001CAF RID: 7343
		private const string DB = "db_influence.db";

		// Token: 0x04001CB0 RID: 7344
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04001CB1 RID: 7345
		private const string TABLE = "Influence";

		// Token: 0x04001CB2 RID: 7346
		private const string COMMAND = "select BinData from `Influence` where Id=?";

		// Token: 0x04001CB3 RID: 7347
		private const string KEY_PREFIX = "InfluenceById";

		// Token: 0x04001CB4 RID: 7348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CB5 RID: 7349
		private static int HandleId;
	}
}

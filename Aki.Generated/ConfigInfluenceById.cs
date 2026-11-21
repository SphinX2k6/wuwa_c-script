using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000433 RID: 1075
	public class ConfigInfluenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600193B RID: 6459 RVA: 0x000EBE23 File Offset: 0x000EA023
		static ConfigInfluenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfluenceById.CreateStaticDefaultValue), new Action(ConfigInfluenceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000EBE44 File Offset: 0x000EA044
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

		// Token: 0x0600193D RID: 6461 RVA: 0x000EBEC3 File Offset: 0x000EA0C3
		public static void ResetStaticDefaultValue()
		{
			ConfigInfluenceById.LogPair = null;
			ConfigInfluenceById.HandleId = 0;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000EBED1 File Offset: 0x000EA0D1
		public static void Init()
		{
			ConfigInfluenceById.HandleId = ConfigCommon.InitDataStatement(ConfigInfluenceById.HandleId, "db_influence.db", "select BinData from `Influence` where Id=?");
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000EBEEC File Offset: 0x000EA0EC
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

		// Token: 0x04001D49 RID: 7497
		private const string DB = "db_influence.db";

		// Token: 0x04001D4A RID: 7498
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04001D4B RID: 7499
		private const string TABLE = "Influence";

		// Token: 0x04001D4C RID: 7500
		private const string COMMAND = "select BinData from `Influence` where Id=?";

		// Token: 0x04001D4D RID: 7501
		private const string KEY_PREFIX = "InfluenceById";

		// Token: 0x04001D4E RID: 7502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D4F RID: 7503
		private static int HandleId;
	}
}

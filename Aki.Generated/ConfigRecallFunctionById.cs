using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BF RID: 1983
	public class ConfigRecallFunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E8C RID: 11916 RVA: 0x00160820 File Offset: 0x0015EA20
		static ConfigRecallFunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallFunctionById.CreateStaticDefaultValue), new Action(ConfigRecallFunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00160840 File Offset: 0x0015EA40
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallFunctionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallFunctionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallFunction` where Id=?")
			});
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x001608BF File Offset: 0x0015EABF
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallFunctionById.LogPair = null;
			ConfigRecallFunctionById.HandleId = 0;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x001608CD File Offset: 0x0015EACD
		public static void Init()
		{
			ConfigRecallFunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigRecallFunctionById.HandleId, "db_questrecall.db", "select BinData from `RecallFunction` where Id=?");
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x001608E8 File Offset: 0x0015EAE8
		public static RecallFunction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallFunction?(RecallFunction.GetRootAsRecallFunction(configBuffer));
				}
			}
			ConfigRecallFunctionById.LogPair.Clear();
			ConfigRecallFunctionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRecallFunctionById.HandleId, 1, p0Id, ConfigRecallFunctionById.LogPair) || ConfigCommon.Step(ConfigRecallFunctionById.HandleId, true, ConfigRecallFunctionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallFunctionById.HandleId, 0, ConfigRecallFunctionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallFunction rootAsRecallFunction = RecallFunction.GetRootAsRecallFunction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
			return new RecallFunction?(rootAsRecallFunction);
		}

		// Token: 0x0400361F RID: 13855
		private const string DB = "db_questrecall.db";

		// Token: 0x04003620 RID: 13856
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x04003621 RID: 13857
		private const string TABLE = "RecallFunction";

		// Token: 0x04003622 RID: 13858
		private const string COMMAND = "select BinData from `RecallFunction` where Id=?";

		// Token: 0x04003623 RID: 13859
		private const string KEY_PREFIX = "RecallFunctionById";

		// Token: 0x04003624 RID: 13860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003625 RID: 13861
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BF RID: 191
	public class ConfigAvignonStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600047B RID: 1147 RVA: 0x000730D7 File Offset: 0x000712D7
		static ConfigAvignonStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonStageById.CreateStaticDefaultValue), new Action(ConfigAvignonStageById.ResetStaticDefaultValue));
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000730F8 File Offset: 0x000712F8
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonStageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonStageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonStage"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonStage` where Id=?")
			});
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00073177 File Offset: 0x00071377
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonStageById.LogPair = null;
			ConfigAvignonStageById.HandleId = 0;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00073185 File Offset: 0x00071385
		public static void Init()
		{
			ConfigAvignonStageById.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonStageById.HandleId, "db_avignon.db", "select BinData from `AvignonStage` where Id=?");
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000731A0 File Offset: 0x000713A0
		public static AvignonStage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvignonStage?(AvignonStage.GetRootAsAvignonStage(configBuffer));
				}
			}
			ConfigAvignonStageById.LogPair.Clear();
			ConfigAvignonStageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvignonStageById.HandleId, 1, p0Id, ConfigAvignonStageById.LogPair) || ConfigCommon.Step(ConfigAvignonStageById.HandleId, true, ConfigAvignonStageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonStageById.HandleId, 0, ConfigAvignonStageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvignonStage rootAsAvignonStage = AvignonStage.GetRootAsAvignonStage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
			return new AvignonStage?(rootAsAvignonStage);
		}

		// Token: 0x0400051D RID: 1309
		private const string DB = "db_avignon.db";

		// Token: 0x0400051E RID: 1310
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x0400051F RID: 1311
		private const string TABLE = "AvignonStage";

		// Token: 0x04000520 RID: 1312
		private const string COMMAND = "select BinData from `AvignonStage` where Id=?";

		// Token: 0x04000521 RID: 1313
		private const string KEY_PREFIX = "AvignonStageById";

		// Token: 0x04000522 RID: 1314
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000523 RID: 1315
		private static int HandleId;
	}
}

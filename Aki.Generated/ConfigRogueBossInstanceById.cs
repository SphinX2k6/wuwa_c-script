using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081D RID: 2077
	public class ConfigRogueBossInstanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x0016CDF8 File Offset: 0x0016AFF8
		static ConfigRogueBossInstanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueBossInstanceById.CreateStaticDefaultValue), new Action(ConfigRogueBossInstanceById.ResetStaticDefaultValue));
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0016CE18 File Offset: 0x0016B018
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueBossInstanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueBossInstanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueBossInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueBossInstance` where Id=?")
			});
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0016CE97 File Offset: 0x0016B097
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueBossInstanceById.LogPair = null;
			ConfigRogueBossInstanceById.HandleId = 0;
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x0016CEA5 File Offset: 0x0016B0A5
		public static void Init()
		{
			ConfigRogueBossInstanceById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueBossInstanceById.HandleId, "db_dreamlink.db", "select BinData from `RogueBossInstance` where Id=?");
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0016CEC0 File Offset: 0x0016B0C0
		public static RogueBossInstance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBossInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueBossInstance?(RogueBossInstance.GetRootAsRogueBossInstance(configBuffer));
				}
			}
			ConfigRogueBossInstanceById.LogPair.Clear();
			ConfigRogueBossInstanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueBossInstanceById.HandleId, 1, p0Id, ConfigRogueBossInstanceById.LogPair) || ConfigCommon.Step(ConfigRogueBossInstanceById.HandleId, true, ConfigRogueBossInstanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueBossInstanceById.HandleId, 0, ConfigRogueBossInstanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueBossInstance rootAsRogueBossInstance = RogueBossInstance.GetRootAsRogueBossInstance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBossInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
			return new RogueBossInstance?(rootAsRogueBossInstance);
		}

		// Token: 0x040038B1 RID: 14513
		private const string DB = "db_dreamlink.db";

		// Token: 0x040038B2 RID: 14514
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x040038B3 RID: 14515
		private const string TABLE = "RogueBossInstance";

		// Token: 0x040038B4 RID: 14516
		private const string COMMAND = "select BinData from `RogueBossInstance` where Id=?";

		// Token: 0x040038B5 RID: 14517
		private const string KEY_PREFIX = "RogueBossInstanceById";

		// Token: 0x040038B6 RID: 14518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038B7 RID: 14519
		private static int HandleId;
	}
}

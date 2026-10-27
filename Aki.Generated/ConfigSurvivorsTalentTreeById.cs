using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AB RID: 2475
	public class ConfigSurvivorsTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A16 RID: 14870 RVA: 0x001A236F File Offset: 0x001A056F
		static ConfigSurvivorsTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentTreeById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x001A2390 File Offset: 0x001A0590
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTalentTree` where Id=?")
			});
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x001A240F File Offset: 0x001A060F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeById.LogPair = null;
			ConfigSurvivorsTalentTreeById.HandleId = 0;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x001A241D File Offset: 0x001A061D
		public static void Init()
		{
			ConfigSurvivorsTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentTreeById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentTree` where Id=?");
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x001A2438 File Offset: 0x001A0638
		public static SurvivorsTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTalentTree?(SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(configBuffer));
				}
			}
			ConfigSurvivorsTalentTreeById.LogPair.Clear();
			ConfigSurvivorsTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTalentTreeById.HandleId, 1, p0Id, ConfigSurvivorsTalentTreeById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTalentTreeById.HandleId, true, ConfigSurvivorsTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTalentTreeById.HandleId, 0, ConfigSurvivorsTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTalentTree rootAsSurvivorsTalentTree = SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
			return new SurvivorsTalentTree?(rootAsSurvivorsTalentTree);
		}

		// Token: 0x04004393 RID: 17299
		private const string DB = "db_survivors.db";

		// Token: 0x04004394 RID: 17300
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004395 RID: 17301
		private const string TABLE = "SurvivorsTalentTree";

		// Token: 0x04004396 RID: 17302
		private const string COMMAND = "select BinData from `SurvivorsTalentTree` where Id=?";

		// Token: 0x04004397 RID: 17303
		private const string KEY_PREFIX = "SurvivorsTalentTreeById";

		// Token: 0x04004398 RID: 17304
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004399 RID: 17305
		private static int HandleId;
	}
}

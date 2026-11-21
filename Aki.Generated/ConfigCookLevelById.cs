using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B1 RID: 433
	public class ConfigCookLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x0009679B File Offset: 0x0009499B
		static ConfigCookLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookLevelById.CreateStaticDefaultValue), new Action(ConfigCookLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000967BC File Offset: 0x000949BC
		public static void CreateStaticDefaultValue()
		{
			ConfigCookLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CookLevel` where Id=?")
			});
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0009683B File Offset: 0x00094A3B
		public static void ResetStaticDefaultValue()
		{
			ConfigCookLevelById.LogPair = null;
			ConfigCookLevelById.HandleId = 0;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00096849 File Offset: 0x00094A49
		public static void Init()
		{
			ConfigCookLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigCookLevelById.HandleId, "db_cook.db", "select BinData from `CookLevel` where Id=?");
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00096864 File Offset: 0x00094A64
		public static CookLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookLevel?(CookLevel.GetRootAsCookLevel(configBuffer));
				}
			}
			ConfigCookLevelById.LogPair.Clear();
			ConfigCookLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookLevelById.HandleId, 1, p0Id, ConfigCookLevelById.LogPair) || ConfigCommon.Step(ConfigCookLevelById.HandleId, true, ConfigCookLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookLevelById.HandleId, 0, ConfigCookLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookLevel rootAsCookLevel = CookLevel.GetRootAsCookLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
			return new CookLevel?(rootAsCookLevel);
		}

		// Token: 0x04000BBB RID: 3003
		private const string DB = "db_cook.db";

		// Token: 0x04000BBC RID: 3004
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BBD RID: 3005
		private const string TABLE = "CookLevel";

		// Token: 0x04000BBE RID: 3006
		private const string COMMAND = "select BinData from `CookLevel` where Id=?";

		// Token: 0x04000BBF RID: 3007
		private const string KEY_PREFIX = "CookLevelById";

		// Token: 0x04000BC0 RID: 3008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BC1 RID: 3009
		private static int HandleId;
	}
}

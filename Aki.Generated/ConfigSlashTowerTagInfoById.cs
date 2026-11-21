using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A8 RID: 2472
	public class ConfigSlashTowerTagInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A04 RID: 14852 RVA: 0x001A4C6F File Offset: 0x001A2E6F
		static ConfigSlashTowerTagInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerTagInfoById.CreateStaticDefaultValue), new Action(ConfigSlashTowerTagInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x001A4C90 File Offset: 0x001A2E90
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashTowerTagInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashTowerTagInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashTowerTagInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashTowerTagInfo` where Id=?")
			});
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x001A4D0F File Offset: 0x001A2F0F
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerTagInfoById.LogPair = null;
			ConfigSlashTowerTagInfoById.HandleId = 0;
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x001A4D1D File Offset: 0x001A2F1D
		public static void Init()
		{
			ConfigSlashTowerTagInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerTagInfoById.HandleId, "db_shiptower.db", "select BinData from `SlashTowerTagInfo` where Id=?");
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x001A4D38 File Offset: 0x001A2F38
		public static SlashTowerTagInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashTowerTagInfoById.HandleId, ConfigSlashTowerTagInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerTagInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashTowerTagInfo?(SlashTowerTagInfo.GetRootAsSlashTowerTagInfo(configBuffer));
				}
			}
			ConfigSlashTowerTagInfoById.LogPair.Clear();
			ConfigSlashTowerTagInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSlashTowerTagInfoById.HandleId, 1, p0Id, ConfigSlashTowerTagInfoById.LogPair) || ConfigCommon.Step(ConfigSlashTowerTagInfoById.HandleId, true, ConfigSlashTowerTagInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashTowerTagInfoById.HandleId, ConfigSlashTowerTagInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashTowerTagInfoById.HandleId, 0, ConfigSlashTowerTagInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashTowerTagInfoById.HandleId, ConfigSlashTowerTagInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashTowerTagInfo rootAsSlashTowerTagInfo = SlashTowerTagInfo.GetRootAsSlashTowerTagInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashTowerTagInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashTowerTagInfoById.HandleId, ConfigSlashTowerTagInfoById.LogPair);
			return new SlashTowerTagInfo?(rootAsSlashTowerTagInfo);
		}

		// Token: 0x0400437E RID: 17278
		private const string DB = "db_shiptower.db";

		// Token: 0x0400437F RID: 17279
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004380 RID: 17280
		private const string TABLE = "SlashTowerTagInfo";

		// Token: 0x04004381 RID: 17281
		private const string COMMAND = "select BinData from `SlashTowerTagInfo` where Id=?";

		// Token: 0x04004382 RID: 17282
		private const string KEY_PREFIX = "SlashTowerTagInfoById";

		// Token: 0x04004383 RID: 17283
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004384 RID: 17284
		private static int HandleId;
	}
}

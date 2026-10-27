using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095D RID: 2397
	public class ConfigSlashTowerTagInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003842 RID: 14402 RVA: 0x00197A4F File Offset: 0x00195C4F
		static ConfigSlashTowerTagInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashTowerTagInfoById.CreateStaticDefaultValue), new Action(ConfigSlashTowerTagInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00197A70 File Offset: 0x00195C70
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

		// Token: 0x06003844 RID: 14404 RVA: 0x00197AEF File Offset: 0x00195CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashTowerTagInfoById.LogPair = null;
			ConfigSlashTowerTagInfoById.HandleId = 0;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00197AFD File Offset: 0x00195CFD
		public static void Init()
		{
			ConfigSlashTowerTagInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashTowerTagInfoById.HandleId, "db_shiptower.db", "select BinData from `SlashTowerTagInfo` where Id=?");
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00197B18 File Offset: 0x00195D18
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

		// Token: 0x04004171 RID: 16753
		private const string DB = "db_shiptower.db";

		// Token: 0x04004172 RID: 16754
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004173 RID: 16755
		private const string TABLE = "SlashTowerTagInfo";

		// Token: 0x04004174 RID: 16756
		private const string COMMAND = "select BinData from `SlashTowerTagInfo` where Id=?";

		// Token: 0x04004175 RID: 16757
		private const string KEY_PREFIX = "SlashTowerTagInfoById";

		// Token: 0x04004176 RID: 16758
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004177 RID: 16759
		private static int HandleId;
	}
}

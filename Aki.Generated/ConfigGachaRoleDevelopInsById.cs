using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000371 RID: 881
	public class ConfigGachaRoleDevelopInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014AC RID: 5292 RVA: 0x000CE680 File Offset: 0x000CC880
		static ConfigGachaRoleDevelopInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsById.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsById.ResetStaticDefaultValue));
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000CE6A0 File Offset: 0x000CC8A0
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaRoleDevelopInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacharoledevelop.db"),
				new ValueTuple<string, object>("文件", "d.当期卡池角色养成推荐.xlsx"),
				new ValueTuple<string, object>("表名", "GachaRoleDevelopIns"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaRoleDevelopIns` where Id=?")
			});
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000CE71F File Offset: 0x000CC91F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsById.LogPair = null;
			ConfigGachaRoleDevelopInsById.HandleId = 0;
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x000CE72D File Offset: 0x000CC92D
		public static void Init()
		{
			ConfigGachaRoleDevelopInsById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsById.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where Id=?");
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x000CE748 File Offset: 0x000CC948
		public static GachaRoleDevelopIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaRoleDevelopIns?(GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(configBuffer));
				}
			}
			ConfigGachaRoleDevelopInsById.LogPair.Clear();
			ConfigGachaRoleDevelopInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaRoleDevelopInsById.HandleId, 1, p0Id, ConfigGachaRoleDevelopInsById.LogPair) || ConfigCommon.Step(ConfigGachaRoleDevelopInsById.HandleId, true, ConfigGachaRoleDevelopInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaRoleDevelopInsById.HandleId, 0, ConfigGachaRoleDevelopInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaRoleDevelopIns rootAsGachaRoleDevelopIns = GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
			return new GachaRoleDevelopIns?(rootAsGachaRoleDevelopIns);
		}

		// Token: 0x040017FB RID: 6139
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x040017FC RID: 6140
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x040017FD RID: 6141
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x040017FE RID: 6142
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where Id=?";

		// Token: 0x040017FF RID: 6143
		private const string KEY_PREFIX = "GachaRoleDevelopInsById";

		// Token: 0x04001800 RID: 6144
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001801 RID: 6145
		private static int HandleId;
	}
}

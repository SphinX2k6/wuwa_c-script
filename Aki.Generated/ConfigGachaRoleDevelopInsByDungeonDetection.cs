using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000370 RID: 880
	public class ConfigGachaRoleDevelopInsByDungeonDetection : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x000CE438 File Offset: 0x000CC638
		static ConfigGachaRoleDevelopInsByDungeonDetection()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsByDungeonDetection.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsByDungeonDetection.ResetStaticDefaultValue));
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000CE458 File Offset: 0x000CC658
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacharoledevelop.db"),
				new ValueTuple<string, object>("文件", "d.当期卡池角色养成推荐.xlsx"),
				new ValueTuple<string, object>("表名", "GachaRoleDevelopIns"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaRoleDevelopIns` where DungeonDetection=?")
			});
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000CE4D7 File Offset: 0x000CC6D7
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair = null;
			ConfigGachaRoleDevelopInsByDungeonDetection.HandleId = 0;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000CE4E5 File Offset: 0x000CC6E5
		public static void Init()
		{
			ConfigGachaRoleDevelopInsByDungeonDetection.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where DungeonDetection=?");
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x000CE500 File Offset: 0x000CC700
		public static GachaRoleDevelopIns? GetConfig(int p0DungeonDetection, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByDungeonDetection");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonDetection);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaRoleDevelopIns?(GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(configBuffer));
				}
			}
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair.Clear();
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair.Add(new ValueTuple<string, object>("DungeonDetection", p0DungeonDetection));
			if (!ConfigCommon.BindInt(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, 1, p0DungeonDetection, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair) || ConfigCommon.Step(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, true, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, 0, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaRoleDevelopIns rootAsGachaRoleDevelopIns = GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByDungeonDetection");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonDetection);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, ConfigGachaRoleDevelopInsByDungeonDetection.LogPair);
			return new GachaRoleDevelopIns?(rootAsGachaRoleDevelopIns);
		}

		// Token: 0x040017F4 RID: 6132
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x040017F5 RID: 6133
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x040017F6 RID: 6134
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x040017F7 RID: 6135
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where DungeonDetection=?";

		// Token: 0x040017F8 RID: 6136
		private const string KEY_PREFIX = "GachaRoleDevelopInsByDungeonDetection";

		// Token: 0x040017F9 RID: 6137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017FA RID: 6138
		private static int HandleId;
	}
}

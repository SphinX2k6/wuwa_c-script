using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000385 RID: 901
	public class ConfigGachaRoleDevelopInsByDungeonDetection : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001524 RID: 5412 RVA: 0x000D4944 File Offset: 0x000D2B44
		static ConfigGachaRoleDevelopInsByDungeonDetection()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsByDungeonDetection.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsByDungeonDetection.ResetStaticDefaultValue));
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000D4964 File Offset: 0x000D2B64
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

		// Token: 0x06001526 RID: 5414 RVA: 0x000D49E3 File Offset: 0x000D2BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByDungeonDetection.LogPair = null;
			ConfigGachaRoleDevelopInsByDungeonDetection.HandleId = 0;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000D49F1 File Offset: 0x000D2BF1
		public static void Init()
		{
			ConfigGachaRoleDevelopInsByDungeonDetection.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsByDungeonDetection.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where DungeonDetection=?");
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000D4A0C File Offset: 0x000D2C0C
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

		// Token: 0x04001887 RID: 6279
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x04001888 RID: 6280
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x04001889 RID: 6281
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x0400188A RID: 6282
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where DungeonDetection=?";

		// Token: 0x0400188B RID: 6283
		private const string KEY_PREFIX = "GachaRoleDevelopInsByDungeonDetection";

		// Token: 0x0400188C RID: 6284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400188D RID: 6285
		private static int HandleId;
	}
}

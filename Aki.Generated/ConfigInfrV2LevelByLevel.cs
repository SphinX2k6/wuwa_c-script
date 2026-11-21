using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044D RID: 1101
	public class ConfigInfrV2LevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019D8 RID: 6616 RVA: 0x000EF3C3 File Offset: 0x000ED5C3
		static ConfigInfrV2LevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2LevelByLevel.CreateStaticDefaultValue), new Action(ConfigInfrV2LevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000EF3E4 File Offset: 0x000ED5E4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2LevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2LevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2Level"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2Level` where Level=?")
			});
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000EF463 File Offset: 0x000ED663
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2LevelByLevel.LogPair = null;
			ConfigInfrV2LevelByLevel.HandleId = 0;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000EF471 File Offset: 0x000ED671
		public static void Init()
		{
			ConfigInfrV2LevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2LevelByLevel.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Level` where Level=?");
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000EF48C File Offset: 0x000ED68C
		public static InfrV2Level? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2LevelByLevel.HandleId, ConfigInfrV2LevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2LevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2Level?(InfrV2Level.GetRootAsInfrV2Level(configBuffer));
				}
			}
			ConfigInfrV2LevelByLevel.LogPair.Clear();
			ConfigInfrV2LevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigInfrV2LevelByLevel.HandleId, 1, p0Level, ConfigInfrV2LevelByLevel.LogPair) || ConfigCommon.Step(ConfigInfrV2LevelByLevel.HandleId, true, ConfigInfrV2LevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2LevelByLevel.HandleId, ConfigInfrV2LevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2LevelByLevel.HandleId, 0, ConfigInfrV2LevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2LevelByLevel.HandleId, ConfigInfrV2LevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2Level rootAsInfrV2Level = InfrV2Level.GetRootAsInfrV2Level(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2LevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2LevelByLevel.HandleId, ConfigInfrV2LevelByLevel.LogPair);
			return new InfrV2Level?(rootAsInfrV2Level);
		}

		// Token: 0x04001DFF RID: 7679
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E00 RID: 7680
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E01 RID: 7681
		private const string TABLE = "InfrV2Level";

		// Token: 0x04001E02 RID: 7682
		private const string COMMAND = "select BinData from `InfrV2Level` where Level=?";

		// Token: 0x04001E03 RID: 7683
		private const string KEY_PREFIX = "InfrV2LevelByLevel";

		// Token: 0x04001E04 RID: 7684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E05 RID: 7685
		private static int HandleId;
	}
}

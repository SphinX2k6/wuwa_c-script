using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045F RID: 1119
	public class ConfigInstanceGameplayModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x000F189C File Offset: 0x000EFA9C
		static ConfigInstanceGameplayModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceGameplayModeById.CreateStaticDefaultValue), new Action(ConfigInstanceGameplayModeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000F18BC File Offset: 0x000EFABC
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceGameplayModeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceGameplayModeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceGameplayMode"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceGameplayMode` where Id=?")
			});
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000F193B File Offset: 0x000EFB3B
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceGameplayModeById.LogPair = null;
			ConfigInstanceGameplayModeById.HandleId = 0;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000F1949 File Offset: 0x000EFB49
		public static void Init()
		{
			ConfigInstanceGameplayModeById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceGameplayModeById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceGameplayMode` where Id=?");
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000F1964 File Offset: 0x000EFB64
		public static InstanceGameplayMode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceGameplayModeById.HandleId, ConfigInstanceGameplayModeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceGameplayModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceGameplayMode?(InstanceGameplayMode.GetRootAsInstanceGameplayMode(configBuffer));
				}
			}
			ConfigInstanceGameplayModeById.LogPair.Clear();
			ConfigInstanceGameplayModeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceGameplayModeById.HandleId, 1, p0Id, ConfigInstanceGameplayModeById.LogPair) || ConfigCommon.Step(ConfigInstanceGameplayModeById.HandleId, true, ConfigInstanceGameplayModeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceGameplayModeById.HandleId, ConfigInstanceGameplayModeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceGameplayModeById.HandleId, 0, ConfigInstanceGameplayModeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceGameplayModeById.HandleId, ConfigInstanceGameplayModeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceGameplayMode rootAsInstanceGameplayMode = InstanceGameplayMode.GetRootAsInstanceGameplayMode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceGameplayModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceGameplayModeById.HandleId, ConfigInstanceGameplayModeById.LogPair);
			return new InstanceGameplayMode?(rootAsInstanceGameplayMode);
		}

		// Token: 0x04001E7D RID: 7805
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E7E RID: 7806
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E7F RID: 7807
		private const string TABLE = "InstanceGameplayMode";

		// Token: 0x04001E80 RID: 7808
		private const string COMMAND = "select BinData from `InstanceGameplayMode` where Id=?";

		// Token: 0x04001E81 RID: 7809
		private const string KEY_PREFIX = "InstanceGameplayModeById";

		// Token: 0x04001E82 RID: 7810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E83 RID: 7811
		private static int HandleId;
	}
}

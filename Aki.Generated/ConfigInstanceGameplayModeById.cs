using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000449 RID: 1097
	public class ConfigInstanceGameplayModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019C0 RID: 6592 RVA: 0x000EB148 File Offset: 0x000E9348
		static ConfigInstanceGameplayModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceGameplayModeById.CreateStaticDefaultValue), new Action(ConfigInstanceGameplayModeById.ResetStaticDefaultValue));
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000EB168 File Offset: 0x000E9368
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

		// Token: 0x060019C2 RID: 6594 RVA: 0x000EB1E7 File Offset: 0x000E93E7
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceGameplayModeById.LogPair = null;
			ConfigInstanceGameplayModeById.HandleId = 0;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000EB1F5 File Offset: 0x000E93F5
		public static void Init()
		{
			ConfigInstanceGameplayModeById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceGameplayModeById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceGameplayMode` where Id=?");
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000EB210 File Offset: 0x000E9410
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

		// Token: 0x04001DE3 RID: 7651
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DE4 RID: 7652
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DE5 RID: 7653
		private const string TABLE = "InstanceGameplayMode";

		// Token: 0x04001DE6 RID: 7654
		private const string COMMAND = "select BinData from `InstanceGameplayMode` where Id=?";

		// Token: 0x04001DE7 RID: 7655
		private const string KEY_PREFIX = "InstanceGameplayModeById";

		// Token: 0x04001DE8 RID: 7656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DE9 RID: 7657
		private static int HandleId;
	}
}

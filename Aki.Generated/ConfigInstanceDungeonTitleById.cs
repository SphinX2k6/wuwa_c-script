using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000447 RID: 1095
	public class ConfigInstanceDungeonTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x000EACB8 File Offset: 0x000E8EB8
		static ConfigInstanceDungeonTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonTitleById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000EACD8 File Offset: 0x000E8ED8
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonTitleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonTitleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeonTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeonTitle` where Id=?")
			});
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000EAD57 File Offset: 0x000E8F57
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonTitleById.LogPair = null;
			ConfigInstanceDungeonTitleById.HandleId = 0;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000EAD65 File Offset: 0x000E8F65
		public static void Init()
		{
			ConfigInstanceDungeonTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonTitleById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonTitle` where Id=?");
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000EAD80 File Offset: 0x000E8F80
		public static InstanceDungeonTitle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonTitleById.HandleId, ConfigInstanceDungeonTitleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceDungeonTitle?(InstanceDungeonTitle.GetRootAsInstanceDungeonTitle(configBuffer));
				}
			}
			ConfigInstanceDungeonTitleById.LogPair.Clear();
			ConfigInstanceDungeonTitleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceDungeonTitleById.HandleId, 1, p0Id, ConfigInstanceDungeonTitleById.LogPair) || ConfigCommon.Step(ConfigInstanceDungeonTitleById.HandleId, true, ConfigInstanceDungeonTitleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonTitleById.HandleId, ConfigInstanceDungeonTitleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonTitleById.HandleId, 0, ConfigInstanceDungeonTitleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonTitleById.HandleId, ConfigInstanceDungeonTitleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceDungeonTitle rootAsInstanceDungeonTitle = InstanceDungeonTitle.GetRootAsInstanceDungeonTitle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonTitleById.HandleId, ConfigInstanceDungeonTitleById.LogPair);
			return new InstanceDungeonTitle?(rootAsInstanceDungeonTitle);
		}

		// Token: 0x04001DD5 RID: 7637
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DD6 RID: 7638
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DD7 RID: 7639
		private const string TABLE = "InstanceDungeonTitle";

		// Token: 0x04001DD8 RID: 7640
		private const string COMMAND = "select BinData from `InstanceDungeonTitle` where Id=?";

		// Token: 0x04001DD9 RID: 7641
		private const string KEY_PREFIX = "InstanceDungeonTitleById";

		// Token: 0x04001DDA RID: 7642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DDB RID: 7643
		private static int HandleId;
	}
}

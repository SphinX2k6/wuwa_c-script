using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000446 RID: 1094
	public class ConfigInstanceDungeonEntranceByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x000EAA70 File Offset: 0x000E8C70
		static ConfigInstanceDungeonEntranceByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceByMarkId.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000EAA90 File Offset: 0x000E8C90
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonEntranceByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeonEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeonEntrance` where MarkId=?")
			});
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000EAB0F File Offset: 0x000E8D0F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceByMarkId.LogPair = null;
			ConfigInstanceDungeonEntranceByMarkId.HandleId = 0;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000EAB1D File Offset: 0x000E8D1D
		public static void Init()
		{
			ConfigInstanceDungeonEntranceByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceByMarkId.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance` where MarkId=?");
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000EAB38 File Offset: 0x000E8D38
		public static InstanceDungeonEntrance? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceDungeonEntrance?(InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(configBuffer));
				}
			}
			ConfigInstanceDungeonEntranceByMarkId.LogPair.Clear();
			ConfigInstanceDungeonEntranceByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigInstanceDungeonEntranceByMarkId.HandleId, 1, p0MarkId, ConfigInstanceDungeonEntranceByMarkId.LogPair) || ConfigCommon.Step(ConfigInstanceDungeonEntranceByMarkId.HandleId, true, ConfigInstanceDungeonEntranceByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonEntranceByMarkId.HandleId, 0, ConfigInstanceDungeonEntranceByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceDungeonEntrance rootAsInstanceDungeonEntrance = InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
			return new InstanceDungeonEntrance?(rootAsInstanceDungeonEntrance);
		}

		// Token: 0x04001DCE RID: 7630
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DCF RID: 7631
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DD0 RID: 7632
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001DD1 RID: 7633
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance` where MarkId=?";

		// Token: 0x04001DD2 RID: 7634
		private const string KEY_PREFIX = "InstanceDungeonEntranceByMarkId";

		// Token: 0x04001DD3 RID: 7635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DD4 RID: 7636
		private static int HandleId;
	}
}

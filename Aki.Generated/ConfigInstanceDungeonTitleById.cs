using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045D RID: 1117
	public class ConfigInstanceDungeonTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A38 RID: 6712 RVA: 0x000F140C File Offset: 0x000EF60C
		static ConfigInstanceDungeonTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonTitleById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000F142C File Offset: 0x000EF62C
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

		// Token: 0x06001A3A RID: 6714 RVA: 0x000F14AB File Offset: 0x000EF6AB
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonTitleById.LogPair = null;
			ConfigInstanceDungeonTitleById.HandleId = 0;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000F14B9 File Offset: 0x000EF6B9
		public static void Init()
		{
			ConfigInstanceDungeonTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonTitleById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonTitle` where Id=?");
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000F14D4 File Offset: 0x000EF6D4
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

		// Token: 0x04001E6F RID: 7791
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E70 RID: 7792
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E71 RID: 7793
		private const string TABLE = "InstanceDungeonTitle";

		// Token: 0x04001E72 RID: 7794
		private const string COMMAND = "select BinData from `InstanceDungeonTitle` where Id=?";

		// Token: 0x04001E73 RID: 7795
		private const string KEY_PREFIX = "InstanceDungeonTitleById";

		// Token: 0x04001E74 RID: 7796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E75 RID: 7797
		private static int HandleId;
	}
}

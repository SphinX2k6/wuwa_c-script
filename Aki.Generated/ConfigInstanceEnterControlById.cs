using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045E RID: 1118
	public class ConfigInstanceEnterControlById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x000F1654 File Offset: 0x000EF854
		static ConfigInstanceEnterControlById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceEnterControlById.CreateStaticDefaultValue), new Action(ConfigInstanceEnterControlById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000F1674 File Offset: 0x000EF874
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceEnterControlById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceEnterControlById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceEnterControl"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceEnterControl` where Id=?")
			});
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000F16F3 File Offset: 0x000EF8F3
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceEnterControlById.LogPair = null;
			ConfigInstanceEnterControlById.HandleId = 0;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000F1701 File Offset: 0x000EF901
		public static void Init()
		{
			ConfigInstanceEnterControlById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceEnterControlById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceEnterControl` where Id=?");
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000F171C File Offset: 0x000EF91C
		public static InstanceEnterControl? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceEnterControlById.HandleId, ConfigInstanceEnterControlById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceEnterControlById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceEnterControl?(InstanceEnterControl.GetRootAsInstanceEnterControl(configBuffer));
				}
			}
			ConfigInstanceEnterControlById.LogPair.Clear();
			ConfigInstanceEnterControlById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceEnterControlById.HandleId, 1, p0Id, ConfigInstanceEnterControlById.LogPair) || ConfigCommon.Step(ConfigInstanceEnterControlById.HandleId, true, ConfigInstanceEnterControlById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceEnterControlById.HandleId, ConfigInstanceEnterControlById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceEnterControlById.HandleId, 0, ConfigInstanceEnterControlById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceEnterControlById.HandleId, ConfigInstanceEnterControlById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceEnterControl rootAsInstanceEnterControl = InstanceEnterControl.GetRootAsInstanceEnterControl(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceEnterControlById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceEnterControlById.HandleId, ConfigInstanceEnterControlById.LogPair);
			return new InstanceEnterControl?(rootAsInstanceEnterControl);
		}

		// Token: 0x04001E76 RID: 7798
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E77 RID: 7799
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E78 RID: 7800
		private const string TABLE = "InstanceEnterControl";

		// Token: 0x04001E79 RID: 7801
		private const string COMMAND = "select BinData from `InstanceEnterControl` where Id=?";

		// Token: 0x04001E7A RID: 7802
		private const string KEY_PREFIX = "InstanceEnterControlById";

		// Token: 0x04001E7B RID: 7803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E7C RID: 7804
		private static int HandleId;
	}
}

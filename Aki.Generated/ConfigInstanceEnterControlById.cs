using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000448 RID: 1096
	public class ConfigInstanceEnterControlById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019BA RID: 6586 RVA: 0x000EAF00 File Offset: 0x000E9100
		static ConfigInstanceEnterControlById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceEnterControlById.CreateStaticDefaultValue), new Action(ConfigInstanceEnterControlById.ResetStaticDefaultValue));
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000EAF20 File Offset: 0x000E9120
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

		// Token: 0x060019BC RID: 6588 RVA: 0x000EAF9F File Offset: 0x000E919F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceEnterControlById.LogPair = null;
			ConfigInstanceEnterControlById.HandleId = 0;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000EAFAD File Offset: 0x000E91AD
		public static void Init()
		{
			ConfigInstanceEnterControlById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceEnterControlById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceEnterControl` where Id=?");
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000EAFC8 File Offset: 0x000E91C8
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

		// Token: 0x04001DDC RID: 7644
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DDD RID: 7645
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DDE RID: 7646
		private const string TABLE = "InstanceEnterControl";

		// Token: 0x04001DDF RID: 7647
		private const string COMMAND = "select BinData from `InstanceEnterControl` where Id=?";

		// Token: 0x04001DE0 RID: 7648
		private const string KEY_PREFIX = "InstanceEnterControlById";

		// Token: 0x04001DE1 RID: 7649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DE2 RID: 7650
		private static int HandleId;
	}
}

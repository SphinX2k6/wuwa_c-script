using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E0 RID: 2016
	public class ConfigReignsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F52 RID: 12114 RVA: 0x00164AC4 File Offset: 0x00162CC4
		static ConfigReignsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReignsById.CreateStaticDefaultValue), new Action(ConfigReignsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00164AE4 File Offset: 0x00162CE4
		public static void CreateStaticDefaultValue()
		{
			ConfigReignsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigReignsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_reigns.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/w.王权玩法总表/*.csv*"),
				new ValueTuple<string, object>("表名", "Reigns"),
				new ValueTuple<string, object>("语句", "select BinData from `Reigns` where Id=?")
			});
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00164B63 File Offset: 0x00162D63
		public static void ResetStaticDefaultValue()
		{
			ConfigReignsById.LogPair = null;
			ConfigReignsById.HandleId = 0;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00164B71 File Offset: 0x00162D71
		public static void Init()
		{
			ConfigReignsById.HandleId = ConfigCommon.InitDataStatement(ConfigReignsById.HandleId, "db_reigns.db", "select BinData from `Reigns` where Id=?");
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00164B8C File Offset: 0x00162D8C
		public static Reigns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigReignsById.HandleId, ConfigReignsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReignsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Reigns?(Reigns.GetRootAsReigns(configBuffer));
				}
			}
			ConfigReignsById.LogPair.Clear();
			ConfigReignsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigReignsById.HandleId, 1, p0Id, ConfigReignsById.LogPair) || ConfigCommon.Step(ConfigReignsById.HandleId, true, ConfigReignsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigReignsById.HandleId, ConfigReignsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigReignsById.HandleId, 0, ConfigReignsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigReignsById.HandleId, ConfigReignsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Reigns rootAsReigns = Reigns.GetRootAsReigns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReignsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigReignsById.HandleId, ConfigReignsById.LogPair);
			return new Reigns?(rootAsReigns);
		}

		// Token: 0x04003706 RID: 14086
		private const string DB = "db_reigns.db";

		// Token: 0x04003707 RID: 14087
		private const string FILE = "k.可视化编辑/c.Csv/w.王权玩法总表/*.csv*";

		// Token: 0x04003708 RID: 14088
		private const string TABLE = "Reigns";

		// Token: 0x04003709 RID: 14089
		private const string COMMAND = "select BinData from `Reigns` where Id=?";

		// Token: 0x0400370A RID: 14090
		private const string KEY_PREFIX = "ReignsById";

		// Token: 0x0400370B RID: 14091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400370C RID: 14092
		private static int HandleId;
	}
}

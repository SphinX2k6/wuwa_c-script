using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FC RID: 2044
	public class ConfigReignsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FFA RID: 12282 RVA: 0x0016BDAC File Offset: 0x00169FAC
		static ConfigReignsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReignsById.CreateStaticDefaultValue), new Action(ConfigReignsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0016BDCC File Offset: 0x00169FCC
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

		// Token: 0x06002FFC RID: 12284 RVA: 0x0016BE4B File Offset: 0x0016A04B
		public static void ResetStaticDefaultValue()
		{
			ConfigReignsById.LogPair = null;
			ConfigReignsById.HandleId = 0;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0016BE59 File Offset: 0x0016A059
		public static void Init()
		{
			ConfigReignsById.HandleId = ConfigCommon.InitDataStatement(ConfigReignsById.HandleId, "db_reigns.db", "select BinData from `Reigns` where Id=?");
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0016BE74 File Offset: 0x0016A074
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

		// Token: 0x040037CA RID: 14282
		private const string DB = "db_reigns.db";

		// Token: 0x040037CB RID: 14283
		private const string FILE = "k.可视化编辑/c.Csv/w.王权玩法总表/*.csv*";

		// Token: 0x040037CC RID: 14284
		private const string TABLE = "Reigns";

		// Token: 0x040037CD RID: 14285
		private const string COMMAND = "select BinData from `Reigns` where Id=?";

		// Token: 0x040037CE RID: 14286
		private const string KEY_PREFIX = "ReignsById";

		// Token: 0x040037CF RID: 14287
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037D0 RID: 14288
		private static int HandleId;
	}
}

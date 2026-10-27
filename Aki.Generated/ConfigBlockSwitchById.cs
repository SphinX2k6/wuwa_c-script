using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000101 RID: 257
	public class ConfigBlockSwitchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0007BC14 File Offset: 0x00079E14
		static ConfigBlockSwitchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlockSwitchById.CreateStaticDefaultValue), new Action(ConfigBlockSwitchById.ResetStaticDefaultValue));
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0007BC34 File Offset: 0x00079E34
		public static void CreateStaticDefaultValue()
		{
			ConfigBlockSwitchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlockSwitchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "BlockSwitch"),
				new ValueTuple<string, object>("语句", "select BinData from `BlockSwitch` where Id=?")
			});
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0007BCB3 File Offset: 0x00079EB3
		public static void ResetStaticDefaultValue()
		{
			ConfigBlockSwitchById.LogPair = null;
			ConfigBlockSwitchById.HandleId = 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0007BCC1 File Offset: 0x00079EC1
		public static void Init()
		{
			ConfigBlockSwitchById.HandleId = ConfigCommon.InitDataStatement(ConfigBlockSwitchById.HandleId, "db_map.db", "select BinData from `BlockSwitch` where Id=?");
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0007BCDC File Offset: 0x00079EDC
		public static BlockSwitch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlockSwitchById.HandleId, ConfigBlockSwitchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlockSwitchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlockSwitch?(BlockSwitch.GetRootAsBlockSwitch(configBuffer));
				}
			}
			ConfigBlockSwitchById.LogPair.Clear();
			ConfigBlockSwitchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlockSwitchById.HandleId, 1, p0Id, ConfigBlockSwitchById.LogPair) || ConfigCommon.Step(ConfigBlockSwitchById.HandleId, true, ConfigBlockSwitchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlockSwitchById.HandleId, ConfigBlockSwitchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlockSwitchById.HandleId, 0, ConfigBlockSwitchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlockSwitchById.HandleId, ConfigBlockSwitchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlockSwitch rootAsBlockSwitch = BlockSwitch.GetRootAsBlockSwitch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlockSwitchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlockSwitchById.HandleId, ConfigBlockSwitchById.LogPair);
			return new BlockSwitch?(rootAsBlockSwitch);
		}

		// Token: 0x040006EB RID: 1771
		private const string DB = "db_map.db";

		// Token: 0x040006EC RID: 1772
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040006ED RID: 1773
		private const string TABLE = "BlockSwitch";

		// Token: 0x040006EE RID: 1774
		private const string COMMAND = "select BinData from `BlockSwitch` where Id=?";

		// Token: 0x040006EF RID: 1775
		private const string KEY_PREFIX = "BlockSwitchById";

		// Token: 0x040006F0 RID: 1776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006F1 RID: 1777
		private static int HandleId;
	}
}

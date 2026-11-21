using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000110 RID: 272
	public class ConfigBlockSwitchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00081578 File Offset: 0x0007F778
		static ConfigBlockSwitchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlockSwitchById.CreateStaticDefaultValue), new Action(ConfigBlockSwitchById.ResetStaticDefaultValue));
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00081598 File Offset: 0x0007F798
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

		// Token: 0x06000663 RID: 1635 RVA: 0x00081617 File Offset: 0x0007F817
		public static void ResetStaticDefaultValue()
		{
			ConfigBlockSwitchById.LogPair = null;
			ConfigBlockSwitchById.HandleId = 0;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00081625 File Offset: 0x0007F825
		public static void Init()
		{
			ConfigBlockSwitchById.HandleId = ConfigCommon.InitDataStatement(ConfigBlockSwitchById.HandleId, "db_map.db", "select BinData from `BlockSwitch` where Id=?");
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00081640 File Offset: 0x0007F840
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

		// Token: 0x04000754 RID: 1876
		private const string DB = "db_map.db";

		// Token: 0x04000755 RID: 1877
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04000756 RID: 1878
		private const string TABLE = "BlockSwitch";

		// Token: 0x04000757 RID: 1879
		private const string COMMAND = "select BinData from `BlockSwitch` where Id=?";

		// Token: 0x04000758 RID: 1880
		private const string KEY_PREFIX = "BlockSwitchById";

		// Token: 0x04000759 RID: 1881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400075A RID: 1882
		private static int HandleId;
	}
}

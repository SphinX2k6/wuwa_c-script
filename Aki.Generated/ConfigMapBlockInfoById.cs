using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050C RID: 1292
	public class ConfigMapBlockInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E53 RID: 7763 RVA: 0x001048AF File Offset: 0x00102AAF
		static ConfigMapBlockInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoById.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x001048D0 File Offset: 0x00102AD0
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBlockInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBlockInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "MapBlockInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBlockInfo` where BlockId=?")
			});
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0010494F File Offset: 0x00102B4F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoById.LogPair = null;
			ConfigMapBlockInfoById.HandleId = 0;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0010495D File Offset: 0x00102B5D
		public static void Init()
		{
			ConfigMapBlockInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoById.HandleId, "db_download.db", "select BinData from `MapBlockInfo` where BlockId=?");
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00104978 File Offset: 0x00102B78
		public static MapBlockInfo? GetConfig(int p0BlockId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBlockInfoById.HandleId, ConfigMapBlockInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBlockInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BlockId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapBlockInfo?(MapBlockInfo.GetRootAsMapBlockInfo(configBuffer));
				}
			}
			ConfigMapBlockInfoById.LogPair.Clear();
			ConfigMapBlockInfoById.LogPair.Add(new ValueTuple<string, object>("BlockId", p0BlockId));
			if (!ConfigCommon.BindInt(ConfigMapBlockInfoById.HandleId, 1, p0BlockId, ConfigMapBlockInfoById.LogPair) || ConfigCommon.Step(ConfigMapBlockInfoById.HandleId, true, ConfigMapBlockInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapBlockInfoById.HandleId, ConfigMapBlockInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBlockInfoById.HandleId, 0, ConfigMapBlockInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapBlockInfoById.HandleId, ConfigMapBlockInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapBlockInfo rootAsMapBlockInfo = MapBlockInfo.GetRootAsMapBlockInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBlockInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BlockId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapBlockInfoById.HandleId, ConfigMapBlockInfoById.LogPair);
			return new MapBlockInfo?(rootAsMapBlockInfo);
		}

		// Token: 0x04002338 RID: 9016
		private const string DB = "db_download.db";

		// Token: 0x04002339 RID: 9017
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x0400233A RID: 9018
		private const string TABLE = "MapBlockInfo";

		// Token: 0x0400233B RID: 9019
		private const string COMMAND = "select BinData from `MapBlockInfo` where BlockId=?";

		// Token: 0x0400233C RID: 9020
		private const string KEY_PREFIX = "MapBlockInfoById";

		// Token: 0x0400233D RID: 9021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400233E RID: 9022
		private static int HandleId;
	}
}

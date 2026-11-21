using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000522 RID: 1314
	public class ConfigMapBlockInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ED7 RID: 7895 RVA: 0x0010B003 File Offset: 0x00109203
		static ConfigMapBlockInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoById.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0010B024 File Offset: 0x00109224
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

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0010B0A3 File Offset: 0x001092A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoById.LogPair = null;
			ConfigMapBlockInfoById.HandleId = 0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0010B0B1 File Offset: 0x001092B1
		public static void Init()
		{
			ConfigMapBlockInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoById.HandleId, "db_download.db", "select BinData from `MapBlockInfo` where BlockId=?");
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0010B0CC File Offset: 0x001092CC
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

		// Token: 0x040023D2 RID: 9170
		private const string DB = "db_download.db";

		// Token: 0x040023D3 RID: 9171
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040023D4 RID: 9172
		private const string TABLE = "MapBlockInfo";

		// Token: 0x040023D5 RID: 9173
		private const string COMMAND = "select BinData from `MapBlockInfo` where BlockId=?";

		// Token: 0x040023D6 RID: 9174
		private const string KEY_PREFIX = "MapBlockInfoById";

		// Token: 0x040023D7 RID: 9175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023D8 RID: 9176
		private static int HandleId;
	}
}

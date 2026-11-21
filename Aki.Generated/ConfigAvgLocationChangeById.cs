using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C7 RID: 199
	public class ConfigAvgLocationChangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x00077A40 File Offset: 0x00075C40
		static ConfigAvgLocationChangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgLocationChangeById.CreateStaticDefaultValue), new Action(ConfigAvgLocationChangeById.ResetStaticDefaultValue));
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00077A60 File Offset: 0x00075C60
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgLocationChangeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgLocationChangeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avglocationchange.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.AVG地点切换/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgLocationChange"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgLocationChange` where Id=?")
			});
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00077ADF File Offset: 0x00075CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgLocationChangeById.LogPair = null;
			ConfigAvgLocationChangeById.HandleId = 0;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00077AED File Offset: 0x00075CED
		public static void Init()
		{
			ConfigAvgLocationChangeById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgLocationChangeById.HandleId, "db_avglocationchange.db", "select BinData from `AvgLocationChange` where Id=?");
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00077B08 File Offset: 0x00075D08
		public static AvgLocationChange? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgLocationChangeById.HandleId, ConfigAvgLocationChangeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgLocationChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgLocationChange?(AvgLocationChange.GetRootAsAvgLocationChange(configBuffer));
				}
			}
			ConfigAvgLocationChangeById.LogPair.Clear();
			ConfigAvgLocationChangeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgLocationChangeById.HandleId, 1, p0Id, ConfigAvgLocationChangeById.LogPair) || ConfigCommon.Step(ConfigAvgLocationChangeById.HandleId, true, ConfigAvgLocationChangeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgLocationChangeById.HandleId, ConfigAvgLocationChangeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgLocationChangeById.HandleId, 0, ConfigAvgLocationChangeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgLocationChangeById.HandleId, ConfigAvgLocationChangeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgLocationChange rootAsAvgLocationChange = AvgLocationChange.GetRootAsAvgLocationChange(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgLocationChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgLocationChangeById.HandleId, ConfigAvgLocationChangeById.LogPair);
			return new AvgLocationChange?(rootAsAvgLocationChange);
		}

		// Token: 0x04000555 RID: 1365
		private const string DB = "db_avglocationchange.db";

		// Token: 0x04000556 RID: 1366
		private const string FILE = "k.可视化编辑/c.Csv/a.AVG地点切换/*.csv*";

		// Token: 0x04000557 RID: 1367
		private const string TABLE = "AvgLocationChange";

		// Token: 0x04000558 RID: 1368
		private const string COMMAND = "select BinData from `AvgLocationChange` where Id=?";

		// Token: 0x04000559 RID: 1369
		private const string KEY_PREFIX = "AvgLocationChangeById";

		// Token: 0x0400055A RID: 1370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400055B RID: 1371
		private static int HandleId;
	}
}

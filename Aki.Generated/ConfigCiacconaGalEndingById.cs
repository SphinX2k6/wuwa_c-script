using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000179 RID: 377
	public class ConfigCiacconaGalEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x0008EFA7 File Offset: 0x0008D1A7
		static ConfigCiacconaGalEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalEndingById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalEnding` where Id=?")
			});
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0008F047 File Offset: 0x0008D247
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalEndingById.LogPair = null;
			ConfigCiacconaGalEndingById.HandleId = 0;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0008F055 File Offset: 0x0008D255
		public static void Init()
		{
			ConfigCiacconaGalEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalEndingById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalEnding` where Id=?");
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0008F070 File Offset: 0x0008D270
		public static CiacconaGalEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalEndingById.HandleId, ConfigCiacconaGalEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalEnding?(CiacconaGalEnding.GetRootAsCiacconaGalEnding(configBuffer));
				}
			}
			ConfigCiacconaGalEndingById.LogPair.Clear();
			ConfigCiacconaGalEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalEndingById.HandleId, 1, p0Id, ConfigCiacconaGalEndingById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalEndingById.HandleId, true, ConfigCiacconaGalEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalEndingById.HandleId, ConfigCiacconaGalEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalEndingById.HandleId, 0, ConfigCiacconaGalEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalEndingById.HandleId, ConfigCiacconaGalEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalEnding rootAsCiacconaGalEnding = CiacconaGalEnding.GetRootAsCiacconaGalEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalEndingById.HandleId, ConfigCiacconaGalEndingById.LogPair);
			return new CiacconaGalEnding?(rootAsCiacconaGalEnding);
		}

		// Token: 0x04000A33 RID: 2611
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A34 RID: 2612
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A35 RID: 2613
		private const string TABLE = "CiacconaGalEnding";

		// Token: 0x04000A36 RID: 2614
		private const string COMMAND = "select BinData from `CiacconaGalEnding` where Id=?";

		// Token: 0x04000A37 RID: 2615
		private const string KEY_PREFIX = "CiacconaGalEndingById";

		// Token: 0x04000A38 RID: 2616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A39 RID: 2617
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017B RID: 379
	public class ConfigCiacconaGalSubEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x0008F438 File Offset: 0x0008D638
		static ConfigCiacconaGalSubEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalSubEndingById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalSubEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0008F458 File Offset: 0x0008D658
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalSubEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalSubEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalSubEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalSubEnding` where Id=?")
			});
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0008F4D7 File Offset: 0x0008D6D7
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalSubEndingById.LogPair = null;
			ConfigCiacconaGalSubEndingById.HandleId = 0;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0008F4E5 File Offset: 0x0008D6E5
		public static void Init()
		{
			ConfigCiacconaGalSubEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalSubEndingById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalSubEnding` where Id=?");
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0008F500 File Offset: 0x0008D700
		public static CiacconaGalSubEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalSubEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalSubEnding?(CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(configBuffer));
				}
			}
			ConfigCiacconaGalSubEndingById.LogPair.Clear();
			ConfigCiacconaGalSubEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalSubEndingById.HandleId, 1, p0Id, ConfigCiacconaGalSubEndingById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalSubEndingById.HandleId, true, ConfigCiacconaGalSubEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalSubEndingById.HandleId, 0, ConfigCiacconaGalSubEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalSubEnding rootAsCiacconaGalSubEnding = CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalSubEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalSubEndingById.HandleId, ConfigCiacconaGalSubEndingById.LogPair);
			return new CiacconaGalSubEnding?(rootAsCiacconaGalSubEnding);
		}

		// Token: 0x04000A41 RID: 2625
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A42 RID: 2626
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A43 RID: 2627
		private const string TABLE = "CiacconaGalSubEnding";

		// Token: 0x04000A44 RID: 2628
		private const string COMMAND = "select BinData from `CiacconaGalSubEnding` where Id=?";

		// Token: 0x04000A45 RID: 2629
		private const string KEY_PREFIX = "CiacconaGalSubEndingById";

		// Token: 0x04000A46 RID: 2630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A47 RID: 2631
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000169 RID: 361
	public class ConfigCiacconaGalEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x0008944B File Offset: 0x0008764B
		static ConfigCiacconaGalEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalEndingById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0008946C File Offset: 0x0008766C
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

		// Token: 0x06000879 RID: 2169 RVA: 0x000894EB File Offset: 0x000876EB
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalEndingById.LogPair = null;
			ConfigCiacconaGalEndingById.HandleId = 0;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000894F9 File Offset: 0x000876F9
		public static void Init()
		{
			ConfigCiacconaGalEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalEndingById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalEnding` where Id=?");
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00089514 File Offset: 0x00087714
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

		// Token: 0x040009C3 RID: 2499
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009C4 RID: 2500
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009C5 RID: 2501
		private const string TABLE = "CiacconaGalEnding";

		// Token: 0x040009C6 RID: 2502
		private const string COMMAND = "select BinData from `CiacconaGalEnding` where Id=?";

		// Token: 0x040009C7 RID: 2503
		private const string KEY_PREFIX = "CiacconaGalEndingById";

		// Token: 0x040009C8 RID: 2504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009C9 RID: 2505
		private static int HandleId;
	}
}

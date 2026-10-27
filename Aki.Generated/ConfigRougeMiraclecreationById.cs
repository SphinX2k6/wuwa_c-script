using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D7 RID: 2263
	public class ConfigRougeMiraclecreationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600351D RID: 13597 RVA: 0x00185958 File Offset: 0x00183B58
		static ConfigRougeMiraclecreationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeMiraclecreationById.CreateStaticDefaultValue), new Action(ConfigRougeMiraclecreationById.ResetStaticDefaultValue));
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00185978 File Offset: 0x00183B78
		public static void CreateStaticDefaultValue()
		{
			ConfigRougeMiraclecreationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougeMiraclecreationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougeMiraclecreation"),
				new ValueTuple<string, object>("语句", "select BinData from `RougeMiraclecreation` where Id=?")
			});
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x001859F7 File Offset: 0x00183BF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeMiraclecreationById.LogPair = null;
			ConfigRougeMiraclecreationById.HandleId = 0;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00185A05 File Offset: 0x00183C05
		public static void Init()
		{
			ConfigRougeMiraclecreationById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeMiraclecreationById.HandleId, "db_rogue.db", "select BinData from `RougeMiraclecreation` where Id=?");
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00185A20 File Offset: 0x00183C20
		public static RougeMiraclecreation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougeMiraclecreation?(RougeMiraclecreation.GetRootAsRougeMiraclecreation(configBuffer));
				}
			}
			ConfigRougeMiraclecreationById.LogPair.Clear();
			ConfigRougeMiraclecreationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougeMiraclecreationById.HandleId, 1, p0Id, ConfigRougeMiraclecreationById.LogPair) || ConfigCommon.Step(ConfigRougeMiraclecreationById.HandleId, true, ConfigRougeMiraclecreationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougeMiraclecreationById.HandleId, 0, ConfigRougeMiraclecreationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougeMiraclecreation rootAsRougeMiraclecreation = RougeMiraclecreation.GetRootAsRougeMiraclecreation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
			return new RougeMiraclecreation?(rootAsRougeMiraclecreation);
		}

		// Token: 0x04003DC7 RID: 15815
		private const string DB = "db_rogue.db";

		// Token: 0x04003DC8 RID: 15816
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003DC9 RID: 15817
		private const string TABLE = "RougeMiraclecreation";

		// Token: 0x04003DCA RID: 15818
		private const string COMMAND = "select BinData from `RougeMiraclecreation` where Id=?";

		// Token: 0x04003DCB RID: 15819
		private const string KEY_PREFIX = "RougeMiraclecreationById";

		// Token: 0x04003DCC RID: 15820
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DCD RID: 15821
		private static int HandleId;
	}
}

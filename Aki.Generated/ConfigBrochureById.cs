using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012D RID: 301
	public class ConfigBrochureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x0008522D File Offset: 0x0008342D
		static ConfigBrochureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrochureById.CreateStaticDefaultValue), new Action(ConfigBrochureById.ResetStaticDefaultValue));
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0008524C File Offset: 0x0008344C
		public static void CreateStaticDefaultValue()
		{
			ConfigBrochureById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBrochureById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_brochure.db"),
				new ValueTuple<string, object>("文件", "c.册子玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Brochure"),
				new ValueTuple<string, object>("语句", "select BinData from `Brochure` where Id=?")
			});
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000852CB File Offset: 0x000834CB
		public static void ResetStaticDefaultValue()
		{
			ConfigBrochureById.LogPair = null;
			ConfigBrochureById.HandleId = 0;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000852D9 File Offset: 0x000834D9
		public static void Init()
		{
			ConfigBrochureById.HandleId = ConfigCommon.InitDataStatement(ConfigBrochureById.HandleId, "db_brochure.db", "select BinData from `Brochure` where Id=?");
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000852F4 File Offset: 0x000834F4
		public static Brochure? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBrochureById.HandleId, ConfigBrochureById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrochureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Brochure?(Brochure.GetRootAsBrochure(configBuffer));
				}
			}
			ConfigBrochureById.LogPair.Clear();
			ConfigBrochureById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBrochureById.HandleId, 1, p0Id, ConfigBrochureById.LogPair) || ConfigCommon.Step(ConfigBrochureById.HandleId, true, ConfigBrochureById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBrochureById.HandleId, ConfigBrochureById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBrochureById.HandleId, 0, ConfigBrochureById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBrochureById.HandleId, ConfigBrochureById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Brochure rootAsBrochure = Brochure.GetRootAsBrochure(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrochureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBrochureById.HandleId, ConfigBrochureById.LogPair);
			return new Brochure?(rootAsBrochure);
		}

		// Token: 0x0400081F RID: 2079
		private const string DB = "db_brochure.db";

		// Token: 0x04000820 RID: 2080
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x04000821 RID: 2081
		private const string TABLE = "Brochure";

		// Token: 0x04000822 RID: 2082
		private const string COMMAND = "select BinData from `Brochure` where Id=?";

		// Token: 0x04000823 RID: 2083
		private const string KEY_PREFIX = "BrochureById";

		// Token: 0x04000824 RID: 2084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000825 RID: 2085
		private static int HandleId;
	}
}

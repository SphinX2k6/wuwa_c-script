using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011E RID: 286
	public class ConfigBrochureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x0007F8C9 File Offset: 0x0007DAC9
		static ConfigBrochureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrochureById.CreateStaticDefaultValue), new Action(ConfigBrochureById.ResetStaticDefaultValue));
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
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

		// Token: 0x060006B7 RID: 1719 RVA: 0x0007F967 File Offset: 0x0007DB67
		public static void ResetStaticDefaultValue()
		{
			ConfigBrochureById.LogPair = null;
			ConfigBrochureById.HandleId = 0;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0007F975 File Offset: 0x0007DB75
		public static void Init()
		{
			ConfigBrochureById.HandleId = ConfigCommon.InitDataStatement(ConfigBrochureById.HandleId, "db_brochure.db", "select BinData from `Brochure` where Id=?");
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0007F990 File Offset: 0x0007DB90
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

		// Token: 0x040007B6 RID: 1974
		private const string DB = "db_brochure.db";

		// Token: 0x040007B7 RID: 1975
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x040007B8 RID: 1976
		private const string TABLE = "Brochure";

		// Token: 0x040007B9 RID: 1977
		private const string COMMAND = "select BinData from `Brochure` where Id=?";

		// Token: 0x040007BA RID: 1978
		private const string KEY_PREFIX = "BrochureById";

		// Token: 0x040007BB RID: 1979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007BC RID: 1980
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011D RID: 285
	public class ConfigBrochureByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x0007F62C File Offset: 0x0007D82C
		static ConfigBrochureByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrochureByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigBrochureByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0007F64C File Offset: 0x0007D84C
		public static void CreateStaticDefaultValue()
		{
			ConfigBrochureByActivityIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBrochureByActivityIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_brochure.db"),
				new ValueTuple<string, object>("文件", "c.册子玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Brochure"),
				new ValueTuple<string, object>("语句", "select BinData from `Brochure` where ActivityId=? AND Type=?")
			});
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0007F6CB File Offset: 0x0007D8CB
		public static void ResetStaticDefaultValue()
		{
			ConfigBrochureByActivityIdAndType.LogPair = null;
			ConfigBrochureByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0007F6D9 File Offset: 0x0007D8D9
		public static void Init()
		{
			ConfigBrochureByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigBrochureByActivityIdAndType.HandleId, "db_brochure.db", "select BinData from `Brochure` where ActivityId=? AND Type=?");
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0007F6F4 File Offset: 0x0007D8F4
		public static Brochure? GetConfig(int p0ActivityId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBrochureByActivityIdAndType.HandleId, ConfigBrochureByActivityIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BrochureByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Brochure?(Brochure.GetRootAsBrochure(configBuffer));
				}
			}
			ConfigBrochureByActivityIdAndType.LogPair.Clear();
			ConfigBrochureByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigBrochureByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigBrochureByActivityIdAndType.HandleId, 1, p0ActivityId, ConfigBrochureByActivityIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigBrochureByActivityIdAndType.HandleId, 2, p1Type, ConfigBrochureByActivityIdAndType.LogPair) || ConfigCommon.Step(ConfigBrochureByActivityIdAndType.HandleId, true, ConfigBrochureByActivityIdAndType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBrochureByActivityIdAndType.HandleId, ConfigBrochureByActivityIdAndType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBrochureByActivityIdAndType.HandleId, 0, ConfigBrochureByActivityIdAndType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBrochureByActivityIdAndType.HandleId, ConfigBrochureByActivityIdAndType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Brochure rootAsBrochure = Brochure.GetRootAsBrochure(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BrochureByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBrochureByActivityIdAndType.HandleId, ConfigBrochureByActivityIdAndType.LogPair);
			return new Brochure?(rootAsBrochure);
		}

		// Token: 0x040007AF RID: 1967
		private const string DB = "db_brochure.db";

		// Token: 0x040007B0 RID: 1968
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x040007B1 RID: 1969
		private const string TABLE = "Brochure";

		// Token: 0x040007B2 RID: 1970
		private const string COMMAND = "select BinData from `Brochure` where ActivityId=? AND Type=?";

		// Token: 0x040007B3 RID: 1971
		private const string KEY_PREFIX = "BrochureByActivityIdAndType";

		// Token: 0x040007B4 RID: 1972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007B5 RID: 1973
		private static int HandleId;
	}
}

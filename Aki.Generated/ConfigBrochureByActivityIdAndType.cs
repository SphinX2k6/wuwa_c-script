using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012C RID: 300
	public class ConfigBrochureByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00084F90 File Offset: 0x00083190
		static ConfigBrochureByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrochureByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigBrochureByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00084FB0 File Offset: 0x000831B0
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

		// Token: 0x0600070B RID: 1803 RVA: 0x0008502F File Offset: 0x0008322F
		public static void ResetStaticDefaultValue()
		{
			ConfigBrochureByActivityIdAndType.LogPair = null;
			ConfigBrochureByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0008503D File Offset: 0x0008323D
		public static void Init()
		{
			ConfigBrochureByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigBrochureByActivityIdAndType.HandleId, "db_brochure.db", "select BinData from `Brochure` where ActivityId=? AND Type=?");
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00085058 File Offset: 0x00083258
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

		// Token: 0x04000818 RID: 2072
		private const string DB = "db_brochure.db";

		// Token: 0x04000819 RID: 2073
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x0400081A RID: 2074
		private const string TABLE = "Brochure";

		// Token: 0x0400081B RID: 2075
		private const string COMMAND = "select BinData from `Brochure` where ActivityId=? AND Type=?";

		// Token: 0x0400081C RID: 2076
		private const string KEY_PREFIX = "BrochureByActivityIdAndType";

		// Token: 0x0400081D RID: 2077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400081E RID: 2078
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000055 RID: 85
	public class ConfigActivityTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00064F0F File Offset: 0x0006310F
		static ConfigActivityTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTabByType.CreateStaticDefaultValue), new Action(ConfigActivityTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00064F30 File Offset: 0x00063130
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTabByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTabByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTab"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTab` where Type = ?")
			});
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00064FAF File Offset: 0x000631AF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTabByType.LogPair = null;
			ConfigActivityTabByType.HandleId = 0;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00064FBD File Offset: 0x000631BD
		public static void Init()
		{
			ConfigActivityTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTabByType.HandleId, "db_weeklychallenge.db", "select BinData from `ActivityTab` where Type = ?");
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00064FD8 File Offset: 0x000631D8
		public static ActivityTab? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityTab?(ActivityTab.GetRootAsActivityTab(configBuffer));
				}
			}
			ConfigActivityTabByType.LogPair.Clear();
			ConfigActivityTabByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigActivityTabByType.HandleId, 1, p0Type, ConfigActivityTabByType.LogPair) || ConfigCommon.Step(ConfigActivityTabByType.HandleId, true, ConfigActivityTabByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTabByType.HandleId, 0, ConfigActivityTabByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityTab rootAsActivityTab = ActivityTab.GetRootAsActivityTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
			return new ActivityTab?(rootAsActivityTab);
		}

		// Token: 0x04000237 RID: 567
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04000238 RID: 568
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04000239 RID: 569
		private const string TABLE = "ActivityTab";

		// Token: 0x0400023A RID: 570
		private const string COMMAND = "select BinData from `ActivityTab` where Type = ?";

		// Token: 0x0400023B RID: 571
		private const string KEY_PREFIX = "ActivityTabByType";

		// Token: 0x0400023C RID: 572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400023D RID: 573
		private static int HandleId;
	}
}

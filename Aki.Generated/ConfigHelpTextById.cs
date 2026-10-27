using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D4 RID: 980
	public class ConfigHelpTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016FF RID: 5887 RVA: 0x000DB7E7 File Offset: 0x000D99E7
		static ConfigHelpTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHelpTextById.CreateStaticDefaultValue), new Action(ConfigHelpTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000DB808 File Offset: 0x000D9A08
		public static void CreateStaticDefaultValue()
		{
			ConfigHelpTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHelpTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_help.db"),
				new ValueTuple<string, object>("文件", "b.帮助.xlsx"),
				new ValueTuple<string, object>("表名", "HelpText"),
				new ValueTuple<string, object>("语句", "select BinData from `HelpText` where Id=?")
			});
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x000DB887 File Offset: 0x000D9A87
		public static void ResetStaticDefaultValue()
		{
			ConfigHelpTextById.LogPair = null;
			ConfigHelpTextById.HandleId = 0;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000DB895 File Offset: 0x000D9A95
		public static void Init()
		{
			ConfigHelpTextById.HandleId = ConfigCommon.InitDataStatement(ConfigHelpTextById.HandleId, "db_help.db", "select BinData from `HelpText` where Id=?");
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000DB8B0 File Offset: 0x000D9AB0
		public static HelpText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHelpTextById.HandleId, ConfigHelpTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HelpTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HelpText?(HelpText.GetRootAsHelpText(configBuffer));
				}
			}
			ConfigHelpTextById.LogPair.Clear();
			ConfigHelpTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHelpTextById.HandleId, 1, p0Id, ConfigHelpTextById.LogPair) || ConfigCommon.Step(ConfigHelpTextById.HandleId, true, ConfigHelpTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHelpTextById.HandleId, ConfigHelpTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHelpTextById.HandleId, 0, ConfigHelpTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHelpTextById.HandleId, ConfigHelpTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HelpText rootAsHelpText = HelpText.GetRootAsHelpText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HelpTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHelpTextById.HandleId, ConfigHelpTextById.LogPair);
			return new HelpText?(rootAsHelpText);
		}

		// Token: 0x04001AB0 RID: 6832
		private const string DB = "db_help.db";

		// Token: 0x04001AB1 RID: 6833
		private const string FILE = "b.帮助.xlsx";

		// Token: 0x04001AB2 RID: 6834
		private const string TABLE = "HelpText";

		// Token: 0x04001AB3 RID: 6835
		private const string COMMAND = "select BinData from `HelpText` where Id=?";

		// Token: 0x04001AB4 RID: 6836
		private const string KEY_PREFIX = "HelpTextById";

		// Token: 0x04001AB5 RID: 6837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AB6 RID: 6838
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EA RID: 1002
	public class ConfigHelpTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x000E1F3B File Offset: 0x000E013B
		static ConfigHelpTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHelpTextById.CreateStaticDefaultValue), new Action(ConfigHelpTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000E1F5C File Offset: 0x000E015C
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

		// Token: 0x06001785 RID: 6021 RVA: 0x000E1FDB File Offset: 0x000E01DB
		public static void ResetStaticDefaultValue()
		{
			ConfigHelpTextById.LogPair = null;
			ConfigHelpTextById.HandleId = 0;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000E1FE9 File Offset: 0x000E01E9
		public static void Init()
		{
			ConfigHelpTextById.HandleId = ConfigCommon.InitDataStatement(ConfigHelpTextById.HandleId, "db_help.db", "select BinData from `HelpText` where Id=?");
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000E2004 File Offset: 0x000E0204
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

		// Token: 0x04001B4A RID: 6986
		private const string DB = "db_help.db";

		// Token: 0x04001B4B RID: 6987
		private const string FILE = "b.帮助.xlsx";

		// Token: 0x04001B4C RID: 6988
		private const string TABLE = "HelpText";

		// Token: 0x04001B4D RID: 6989
		private const string COMMAND = "select BinData from `HelpText` where Id=?";

		// Token: 0x04001B4E RID: 6990
		private const string KEY_PREFIX = "HelpTextById";

		// Token: 0x04001B4F RID: 6991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B50 RID: 6992
		private static int HandleId;
	}
}

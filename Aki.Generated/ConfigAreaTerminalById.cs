using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AF RID: 175
	public class ConfigAreaTerminalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00070E3B File Offset: 0x0006F03B
		static ConfigAreaTerminalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalById.CreateStaticDefaultValue), new Action(ConfigAreaTerminalById.ResetStaticDefaultValue));
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00070E5C File Offset: 0x0006F05C
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTerminalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTerminalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTerminal"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTerminal` where Id=?")
			});
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00070EDB File Offset: 0x0006F0DB
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalById.LogPair = null;
			ConfigAreaTerminalById.HandleId = 0;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00070EE9 File Offset: 0x0006F0E9
		public static void Init()
		{
			ConfigAreaTerminalById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalById.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal` where Id=?");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00070F04 File Offset: 0x0006F104
		public static AreaTerminal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaTerminal?(AreaTerminal.GetRootAsAreaTerminal(configBuffer));
				}
			}
			ConfigAreaTerminalById.LogPair.Clear();
			ConfigAreaTerminalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaTerminalById.HandleId, 1, p0Id, ConfigAreaTerminalById.LogPair) || ConfigCommon.Step(ConfigAreaTerminalById.HandleId, true, ConfigAreaTerminalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTerminalById.HandleId, 0, ConfigAreaTerminalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaTerminal rootAsAreaTerminal = AreaTerminal.GetRootAsAreaTerminal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
			return new AreaTerminal?(rootAsAreaTerminal);
		}

		// Token: 0x040004AD RID: 1197
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004AE RID: 1198
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004AF RID: 1199
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004B0 RID: 1200
		private const string COMMAND = "select BinData from `AreaTerminal` where Id=?";

		// Token: 0x040004B1 RID: 1201
		private const string KEY_PREFIX = "AreaTerminalById";

		// Token: 0x040004B2 RID: 1202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004B3 RID: 1203
		private static int HandleId;
	}
}

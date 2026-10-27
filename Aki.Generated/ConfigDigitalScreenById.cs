using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000208 RID: 520
	public class ConfigDigitalScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x0009E9EC File Offset: 0x0009CBEC
		static ConfigDigitalScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDigitalScreenById.CreateStaticDefaultValue), new Action(ConfigDigitalScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0009EA0C File Offset: 0x0009CC0C
		public static void CreateStaticDefaultValue()
		{
			ConfigDigitalScreenById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDigitalScreenById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_digital_screen.db"),
				new ValueTuple<string, object>("文件", "s.数码界面.xlsx"),
				new ValueTuple<string, object>("表名", "DigitalScreen"),
				new ValueTuple<string, object>("语句", "select BinData from `DigitalScreen` where Id=?")
			});
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0009EA8B File Offset: 0x0009CC8B
		public static void ResetStaticDefaultValue()
		{
			ConfigDigitalScreenById.LogPair = null;
			ConfigDigitalScreenById.HandleId = 0;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0009EA99 File Offset: 0x0009CC99
		public static void Init()
		{
			ConfigDigitalScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigDigitalScreenById.HandleId, "db_digital_screen.db", "select BinData from `DigitalScreen` where Id=?");
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0009EAB4 File Offset: 0x0009CCB4
		public static DigitalScreen? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDigitalScreenById.HandleId, ConfigDigitalScreenById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DigitalScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DigitalScreen?(DigitalScreen.GetRootAsDigitalScreen(configBuffer));
				}
			}
			ConfigDigitalScreenById.LogPair.Clear();
			ConfigDigitalScreenById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDigitalScreenById.HandleId, 1, p0Id, ConfigDigitalScreenById.LogPair) || ConfigCommon.Step(ConfigDigitalScreenById.HandleId, true, ConfigDigitalScreenById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDigitalScreenById.HandleId, ConfigDigitalScreenById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDigitalScreenById.HandleId, 0, ConfigDigitalScreenById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDigitalScreenById.HandleId, ConfigDigitalScreenById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DigitalScreen rootAsDigitalScreen = DigitalScreen.GetRootAsDigitalScreen(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DigitalScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDigitalScreenById.HandleId, ConfigDigitalScreenById.LogPair);
			return new DigitalScreen?(rootAsDigitalScreen);
		}

		// Token: 0x04000E1C RID: 3612
		private const string DB = "db_digital_screen.db";

		// Token: 0x04000E1D RID: 3613
		private const string FILE = "s.数码界面.xlsx";

		// Token: 0x04000E1E RID: 3614
		private const string TABLE = "DigitalScreen";

		// Token: 0x04000E1F RID: 3615
		private const string COMMAND = "select BinData from `DigitalScreen` where Id=?";

		// Token: 0x04000E20 RID: 3616
		private const string KEY_PREFIX = "DigitalScreenById";

		// Token: 0x04000E21 RID: 3617
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E22 RID: 3618
		private static int HandleId;
	}
}

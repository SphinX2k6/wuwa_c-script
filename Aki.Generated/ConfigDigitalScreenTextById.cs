using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000209 RID: 521
	public class ConfigDigitalScreenTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x0009EC34 File Offset: 0x0009CE34
		static ConfigDigitalScreenTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDigitalScreenTextById.CreateStaticDefaultValue), new Action(ConfigDigitalScreenTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0009EC54 File Offset: 0x0009CE54
		public static void CreateStaticDefaultValue()
		{
			ConfigDigitalScreenTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDigitalScreenTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_digital_screen.db"),
				new ValueTuple<string, object>("文件", "s.数码界面.xlsx"),
				new ValueTuple<string, object>("表名", "DigitalScreenText"),
				new ValueTuple<string, object>("语句", "select BinData from `DigitalScreenText` where Id=?")
			});
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0009ECD3 File Offset: 0x0009CED3
		public static void ResetStaticDefaultValue()
		{
			ConfigDigitalScreenTextById.LogPair = null;
			ConfigDigitalScreenTextById.HandleId = 0;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0009ECE1 File Offset: 0x0009CEE1
		public static void Init()
		{
			ConfigDigitalScreenTextById.HandleId = ConfigCommon.InitDataStatement(ConfigDigitalScreenTextById.HandleId, "db_digital_screen.db", "select BinData from `DigitalScreenText` where Id=?");
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0009ECFC File Offset: 0x0009CEFC
		public static DigitalScreenText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDigitalScreenTextById.HandleId, ConfigDigitalScreenTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DigitalScreenTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DigitalScreenText?(DigitalScreenText.GetRootAsDigitalScreenText(configBuffer));
				}
			}
			ConfigDigitalScreenTextById.LogPair.Clear();
			ConfigDigitalScreenTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDigitalScreenTextById.HandleId, 1, p0Id, ConfigDigitalScreenTextById.LogPair) || ConfigCommon.Step(ConfigDigitalScreenTextById.HandleId, true, ConfigDigitalScreenTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDigitalScreenTextById.HandleId, ConfigDigitalScreenTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDigitalScreenTextById.HandleId, 0, ConfigDigitalScreenTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDigitalScreenTextById.HandleId, ConfigDigitalScreenTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DigitalScreenText rootAsDigitalScreenText = DigitalScreenText.GetRootAsDigitalScreenText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DigitalScreenTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDigitalScreenTextById.HandleId, ConfigDigitalScreenTextById.LogPair);
			return new DigitalScreenText?(rootAsDigitalScreenText);
		}

		// Token: 0x04000E23 RID: 3619
		private const string DB = "db_digital_screen.db";

		// Token: 0x04000E24 RID: 3620
		private const string FILE = "s.数码界面.xlsx";

		// Token: 0x04000E25 RID: 3621
		private const string TABLE = "DigitalScreenText";

		// Token: 0x04000E26 RID: 3622
		private const string COMMAND = "select BinData from `DigitalScreenText` where Id=?";

		// Token: 0x04000E27 RID: 3623
		private const string KEY_PREFIX = "DigitalScreenTextById";

		// Token: 0x04000E28 RID: 3624
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E29 RID: 3625
		private static int HandleId;
	}
}

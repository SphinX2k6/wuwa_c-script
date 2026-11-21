using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021A RID: 538
	public class ConfigDigitalScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x000A4924 File Offset: 0x000A2B24
		static ConfigDigitalScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDigitalScreenById.CreateStaticDefaultValue), new Action(ConfigDigitalScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000A4944 File Offset: 0x000A2B44
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

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000A49C3 File Offset: 0x000A2BC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDigitalScreenById.LogPair = null;
			ConfigDigitalScreenById.HandleId = 0;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000A49D1 File Offset: 0x000A2BD1
		public static void Init()
		{
			ConfigDigitalScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigDigitalScreenById.HandleId, "db_digital_screen.db", "select BinData from `DigitalScreen` where Id=?");
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000A49EC File Offset: 0x000A2BEC
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

		// Token: 0x04000E9A RID: 3738
		private const string DB = "db_digital_screen.db";

		// Token: 0x04000E9B RID: 3739
		private const string FILE = "s.数码界面.xlsx";

		// Token: 0x04000E9C RID: 3740
		private const string TABLE = "DigitalScreen";

		// Token: 0x04000E9D RID: 3741
		private const string COMMAND = "select BinData from `DigitalScreen` where Id=?";

		// Token: 0x04000E9E RID: 3742
		private const string KEY_PREFIX = "DigitalScreenById";

		// Token: 0x04000E9F RID: 3743
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EA0 RID: 3744
		private static int HandleId;
	}
}

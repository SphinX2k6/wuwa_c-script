using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021B RID: 539
	public class ConfigDigitalScreenTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x000A4B6C File Offset: 0x000A2D6C
		static ConfigDigitalScreenTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDigitalScreenTextById.CreateStaticDefaultValue), new Action(ConfigDigitalScreenTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000A4B8C File Offset: 0x000A2D8C
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

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000A4C0B File Offset: 0x000A2E0B
		public static void ResetStaticDefaultValue()
		{
			ConfigDigitalScreenTextById.LogPair = null;
			ConfigDigitalScreenTextById.HandleId = 0;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000A4C19 File Offset: 0x000A2E19
		public static void Init()
		{
			ConfigDigitalScreenTextById.HandleId = ConfigCommon.InitDataStatement(ConfigDigitalScreenTextById.HandleId, "db_digital_screen.db", "select BinData from `DigitalScreenText` where Id=?");
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000A4C34 File Offset: 0x000A2E34
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

		// Token: 0x04000EA1 RID: 3745
		private const string DB = "db_digital_screen.db";

		// Token: 0x04000EA2 RID: 3746
		private const string FILE = "s.数码界面.xlsx";

		// Token: 0x04000EA3 RID: 3747
		private const string TABLE = "DigitalScreenText";

		// Token: 0x04000EA4 RID: 3748
		private const string COMMAND = "select BinData from `DigitalScreenText` where Id=?";

		// Token: 0x04000EA5 RID: 3749
		private const string KEY_PREFIX = "DigitalScreenTextById";

		// Token: 0x04000EA6 RID: 3750
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EA7 RID: 3751
		private static int HandleId;
	}
}

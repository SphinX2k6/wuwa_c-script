using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000233 RID: 563
	public class ConfigDreamLinkWorldRunByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x000A7DD4 File Offset: 0x000A5FD4
		static ConfigDreamLinkWorldRunByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDreamLinkWorldRunByMarkId.CreateStaticDefaultValue), new Action(ConfigDreamLinkWorldRunByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000A7DF4 File Offset: 0x000A5FF4
		public static void CreateStaticDefaultValue()
		{
			ConfigDreamLinkWorldRunByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDreamLinkWorldRunByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "DreamLinkWorldRun"),
				new ValueTuple<string, object>("语句", "select BinData from `DreamLinkWorldRun` where MarkId=?")
			});
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000A7E73 File Offset: 0x000A6073
		public static void ResetStaticDefaultValue()
		{
			ConfigDreamLinkWorldRunByMarkId.LogPair = null;
			ConfigDreamLinkWorldRunByMarkId.HandleId = 0;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000A7E81 File Offset: 0x000A6081
		public static void Init()
		{
			ConfigDreamLinkWorldRunByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigDreamLinkWorldRunByMarkId.HandleId, "db_dreamlink.db", "select BinData from `DreamLinkWorldRun` where MarkId=?");
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000A7E9C File Offset: 0x000A609C
		public static DreamLinkWorldRun? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDreamLinkWorldRunByMarkId.HandleId, ConfigDreamLinkWorldRunByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkWorldRunByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DreamLinkWorldRun?(DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(configBuffer));
				}
			}
			ConfigDreamLinkWorldRunByMarkId.LogPair.Clear();
			ConfigDreamLinkWorldRunByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigDreamLinkWorldRunByMarkId.HandleId, 1, p0MarkId, ConfigDreamLinkWorldRunByMarkId.LogPair) || ConfigCommon.Step(ConfigDreamLinkWorldRunByMarkId.HandleId, true, ConfigDreamLinkWorldRunByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDreamLinkWorldRunByMarkId.HandleId, ConfigDreamLinkWorldRunByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDreamLinkWorldRunByMarkId.HandleId, 0, ConfigDreamLinkWorldRunByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDreamLinkWorldRunByMarkId.HandleId, ConfigDreamLinkWorldRunByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DreamLinkWorldRun rootAsDreamLinkWorldRun = DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkWorldRunByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDreamLinkWorldRunByMarkId.HandleId, ConfigDreamLinkWorldRunByMarkId.LogPair);
			return new DreamLinkWorldRun?(rootAsDreamLinkWorldRun);
		}

		// Token: 0x04000F49 RID: 3913
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000F4A RID: 3914
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000F4B RID: 3915
		private const string TABLE = "DreamLinkWorldRun";

		// Token: 0x04000F4C RID: 3916
		private const string COMMAND = "select BinData from `DreamLinkWorldRun` where MarkId=?";

		// Token: 0x04000F4D RID: 3917
		private const string KEY_PREFIX = "DreamLinkWorldRunByMarkId";

		// Token: 0x04000F4E RID: 3918
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F4F RID: 3919
		private static int HandleId;
	}
}

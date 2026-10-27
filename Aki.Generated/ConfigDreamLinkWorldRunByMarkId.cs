using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000221 RID: 545
	public class ConfigDreamLinkWorldRunByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x000A1E9C File Offset: 0x000A009C
		static ConfigDreamLinkWorldRunByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDreamLinkWorldRunByMarkId.CreateStaticDefaultValue), new Action(ConfigDreamLinkWorldRunByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000A1EBC File Offset: 0x000A00BC
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

		// Token: 0x06000CCC RID: 3276 RVA: 0x000A1F3B File Offset: 0x000A013B
		public static void ResetStaticDefaultValue()
		{
			ConfigDreamLinkWorldRunByMarkId.LogPair = null;
			ConfigDreamLinkWorldRunByMarkId.HandleId = 0;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000A1F49 File Offset: 0x000A0149
		public static void Init()
		{
			ConfigDreamLinkWorldRunByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigDreamLinkWorldRunByMarkId.HandleId, "db_dreamlink.db", "select BinData from `DreamLinkWorldRun` where MarkId=?");
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000A1F64 File Offset: 0x000A0164
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

		// Token: 0x04000ECB RID: 3787
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000ECC RID: 3788
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000ECD RID: 3789
		private const string TABLE = "DreamLinkWorldRun";

		// Token: 0x04000ECE RID: 3790
		private const string COMMAND = "select BinData from `DreamLinkWorldRun` where MarkId=?";

		// Token: 0x04000ECF RID: 3791
		private const string KEY_PREFIX = "DreamLinkWorldRunByMarkId";

		// Token: 0x04000ED0 RID: 3792
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ED1 RID: 3793
		private static int HandleId;
	}
}

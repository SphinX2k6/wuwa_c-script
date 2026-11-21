using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000635 RID: 1589
	public class ConfigNpcSystemBackgroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600254E RID: 9550 RVA: 0x00130160 File Offset: 0x0012E360
		static ConfigNpcSystemBackgroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcSystemBackgroundById.CreateStaticDefaultValue), new Action(ConfigNpcSystemBackgroundById.ResetStaticDefaultValue));
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00130180 File Offset: 0x0012E380
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcSystemBackgroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "NpcSystemBackground"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcSystemBackground` where Id=?")
			});
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x001301FF File Offset: 0x0012E3FF
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundById.LogPair = null;
			ConfigNpcSystemBackgroundById.HandleId = 0;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0013020D File Offset: 0x0012E40D
		public static void Init()
		{
			ConfigNpcSystemBackgroundById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcSystemBackgroundById.HandleId, "db_commonbackground.db", "select BinData from `NpcSystemBackground` where Id=?");
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00130228 File Offset: 0x0012E428
		public static NpcSystemBackground? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcSystemBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NpcSystemBackground?(NpcSystemBackground.GetRootAsNpcSystemBackground(configBuffer));
				}
			}
			ConfigNpcSystemBackgroundById.LogPair.Clear();
			ConfigNpcSystemBackgroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNpcSystemBackgroundById.HandleId, 1, p0Id, ConfigNpcSystemBackgroundById.LogPair) || ConfigCommon.Step(ConfigNpcSystemBackgroundById.HandleId, true, ConfigNpcSystemBackgroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcSystemBackgroundById.HandleId, 0, ConfigNpcSystemBackgroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NpcSystemBackground rootAsNpcSystemBackground = NpcSystemBackground.GetRootAsNpcSystemBackground(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcSystemBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
			return new NpcSystemBackground?(rootAsNpcSystemBackground);
		}

		// Token: 0x04002B59 RID: 11097
		private const string DB = "db_commonbackground.db";

		// Token: 0x04002B5A RID: 11098
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04002B5B RID: 11099
		private const string TABLE = "NpcSystemBackground";

		// Token: 0x04002B5C RID: 11100
		private const string COMMAND = "select BinData from `NpcSystemBackground` where Id=?";

		// Token: 0x04002B5D RID: 11101
		private const string KEY_PREFIX = "NpcSystemBackgroundById";

		// Token: 0x04002B5E RID: 11102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B5F RID: 11103
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA5 RID: 2725
	public class ConfigTermConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FF2 RID: 16370 RVA: 0x001C6580 File Offset: 0x001C4780
		static ConfigTermConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermConfigById.CreateStaticDefaultValue), new Action(ConfigTermConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x001C65A0 File Offset: 0x001C47A0
		public static void CreateStaticDefaultValue()
		{
			ConfigTermConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTermConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_term.db"),
				new ValueTuple<string, object>("文件", "s.术语/*.csv*"),
				new ValueTuple<string, object>("表名", "TermConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TermConfig` where Id=?")
			});
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x001C661F File Offset: 0x001C481F
		public static void ResetStaticDefaultValue()
		{
			ConfigTermConfigById.LogPair = null;
			ConfigTermConfigById.HandleId = 0;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x001C662D File Offset: 0x001C482D
		public static void Init()
		{
			ConfigTermConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTermConfigById.HandleId, "db_term.db", "select BinData from `TermConfig` where Id=?");
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001C6648 File Offset: 0x001C4848
		public static TermConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TermConfig?(TermConfig.GetRootAsTermConfig(configBuffer));
				}
			}
			ConfigTermConfigById.LogPair.Clear();
			ConfigTermConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTermConfigById.HandleId, 1, p0Id, ConfigTermConfigById.LogPair) || ConfigCommon.Step(ConfigTermConfigById.HandleId, true, ConfigTermConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTermConfigById.HandleId, 0, ConfigTermConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TermConfig rootAsTermConfig = TermConfig.GetRootAsTermConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
			return new TermConfig?(rootAsTermConfig);
		}

		// Token: 0x04004A69 RID: 19049
		private const string DB = "db_term.db";

		// Token: 0x04004A6A RID: 19050
		private const string FILE = "s.术语/*.csv*";

		// Token: 0x04004A6B RID: 19051
		private const string TABLE = "TermConfig";

		// Token: 0x04004A6C RID: 19052
		private const string COMMAND = "select BinData from `TermConfig` where Id=?";

		// Token: 0x04004A6D RID: 19053
		private const string KEY_PREFIX = "TermConfigById";

		// Token: 0x04004A6E RID: 19054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A6F RID: 19055
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BC RID: 1468
	public class ConfigMotorGeneralPreviewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002275 RID: 8821 RVA: 0x0011FF64 File Offset: 0x0011E164
		static ConfigMotorGeneralPreviewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorGeneralPreviewById.CreateStaticDefaultValue), new Action(ConfigMotorGeneralPreviewById.ResetStaticDefaultValue));
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0011FF84 File Offset: 0x0011E184
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorGeneralPreviewById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorGeneralPreviewById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorgeneralpreview.db"),
				new ValueTuple<string, object>("文件", "m.摩托车通用预览.xlsx"),
				new ValueTuple<string, object>("表名", "MotorGeneralPreview"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorGeneralPreview` where Id=?")
			});
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00120003 File Offset: 0x0011E203
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorGeneralPreviewById.LogPair = null;
			ConfigMotorGeneralPreviewById.HandleId = 0;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00120011 File Offset: 0x0011E211
		public static void Init()
		{
			ConfigMotorGeneralPreviewById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorGeneralPreviewById.HandleId, "db_motorgeneralpreview.db", "select BinData from `MotorGeneralPreview` where Id=?");
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0012002C File Offset: 0x0011E22C
		public static MotorGeneralPreview? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorGeneralPreviewById.HandleId, ConfigMotorGeneralPreviewById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorGeneralPreviewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorGeneralPreview?(MotorGeneralPreview.GetRootAsMotorGeneralPreview(configBuffer));
				}
			}
			ConfigMotorGeneralPreviewById.LogPair.Clear();
			ConfigMotorGeneralPreviewById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorGeneralPreviewById.HandleId, 1, p0Id, ConfigMotorGeneralPreviewById.LogPair) || ConfigCommon.Step(ConfigMotorGeneralPreviewById.HandleId, true, ConfigMotorGeneralPreviewById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorGeneralPreviewById.HandleId, ConfigMotorGeneralPreviewById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorGeneralPreviewById.HandleId, 0, ConfigMotorGeneralPreviewById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorGeneralPreviewById.HandleId, ConfigMotorGeneralPreviewById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorGeneralPreview rootAsMotorGeneralPreview = MotorGeneralPreview.GetRootAsMotorGeneralPreview(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorGeneralPreviewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorGeneralPreviewById.HandleId, ConfigMotorGeneralPreviewById.LogPair);
			return new MotorGeneralPreview?(rootAsMotorGeneralPreview);
		}

		// Token: 0x04002808 RID: 10248
		private const string DB = "db_motorgeneralpreview.db";

		// Token: 0x04002809 RID: 10249
		private const string FILE = "m.摩托车通用预览.xlsx";

		// Token: 0x0400280A RID: 10250
		private const string TABLE = "MotorGeneralPreview";

		// Token: 0x0400280B RID: 10251
		private const string COMMAND = "select BinData from `MotorGeneralPreview` where Id=?";

		// Token: 0x0400280C RID: 10252
		private const string KEY_PREFIX = "MotorGeneralPreviewById";

		// Token: 0x0400280D RID: 10253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400280E RID: 10254
		private static int HandleId;
	}
}

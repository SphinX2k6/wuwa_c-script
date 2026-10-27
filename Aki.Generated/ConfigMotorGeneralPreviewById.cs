using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A5 RID: 1445
	public class ConfigMotorGeneralPreviewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x0011967C File Offset: 0x0011787C
		static ConfigMotorGeneralPreviewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorGeneralPreviewById.CreateStaticDefaultValue), new Action(ConfigMotorGeneralPreviewById.ResetStaticDefaultValue));
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0011969C File Offset: 0x0011789C
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

		// Token: 0x060021ED RID: 8685 RVA: 0x0011971B File Offset: 0x0011791B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorGeneralPreviewById.LogPair = null;
			ConfigMotorGeneralPreviewById.HandleId = 0;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00119729 File Offset: 0x00117929
		public static void Init()
		{
			ConfigMotorGeneralPreviewById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorGeneralPreviewById.HandleId, "db_motorgeneralpreview.db", "select BinData from `MotorGeneralPreview` where Id=?");
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00119744 File Offset: 0x00117944
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

		// Token: 0x04002767 RID: 10087
		private const string DB = "db_motorgeneralpreview.db";

		// Token: 0x04002768 RID: 10088
		private const string FILE = "m.摩托车通用预览.xlsx";

		// Token: 0x04002769 RID: 10089
		private const string TABLE = "MotorGeneralPreview";

		// Token: 0x0400276A RID: 10090
		private const string COMMAND = "select BinData from `MotorGeneralPreview` where Id=?";

		// Token: 0x0400276B RID: 10091
		private const string KEY_PREFIX = "MotorGeneralPreviewById";

		// Token: 0x0400276C RID: 10092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400276D RID: 10093
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BE RID: 702
	public class ConfigFaceExpressionDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x000BA14C File Offset: 0x000B834C
		static ConfigFaceExpressionDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFaceExpressionDataById.CreateStaticDefaultValue), new Action(ConfigFaceExpressionDataById.ResetStaticDefaultValue));
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000BA16C File Offset: 0x000B836C
		public static void CreateStaticDefaultValue()
		{
			ConfigFaceExpressionDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFaceExpressionDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_faceexpressiondata.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/b.表情/*.csv*"),
				new ValueTuple<string, object>("表名", "FaceExpressionData"),
				new ValueTuple<string, object>("语句", "select BinData from `FaceExpressionData` where Id=?")
			});
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000BA1EB File Offset: 0x000B83EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFaceExpressionDataById.LogPair = null;
			ConfigFaceExpressionDataById.HandleId = 0;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000BA1F9 File Offset: 0x000B83F9
		public static void Init()
		{
			ConfigFaceExpressionDataById.HandleId = ConfigCommon.InitDataStatement(ConfigFaceExpressionDataById.HandleId, "db_faceexpressiondata.db", "select BinData from `FaceExpressionData` where Id=?");
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000BA214 File Offset: 0x000B8414
		public static FaceExpressionData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFaceExpressionDataById.HandleId, ConfigFaceExpressionDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FaceExpressionDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FaceExpressionData?(FaceExpressionData.GetRootAsFaceExpressionData(configBuffer));
				}
			}
			ConfigFaceExpressionDataById.LogPair.Clear();
			ConfigFaceExpressionDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFaceExpressionDataById.HandleId, 1, p0Id, ConfigFaceExpressionDataById.LogPair) || ConfigCommon.Step(ConfigFaceExpressionDataById.HandleId, true, ConfigFaceExpressionDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFaceExpressionDataById.HandleId, ConfigFaceExpressionDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFaceExpressionDataById.HandleId, 0, ConfigFaceExpressionDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFaceExpressionDataById.HandleId, ConfigFaceExpressionDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FaceExpressionData rootAsFaceExpressionData = FaceExpressionData.GetRootAsFaceExpressionData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FaceExpressionDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFaceExpressionDataById.HandleId, ConfigFaceExpressionDataById.LogPair);
			return new FaceExpressionData?(rootAsFaceExpressionData);
		}

		// Token: 0x04001316 RID: 4886
		private const string DB = "db_faceexpressiondata.db";

		// Token: 0x04001317 RID: 4887
		private const string FILE = "k.可视化编辑/c.Csv/b.表情/*.csv*";

		// Token: 0x04001318 RID: 4888
		private const string TABLE = "FaceExpressionData";

		// Token: 0x04001319 RID: 4889
		private const string COMMAND = "select BinData from `FaceExpressionData` where Id=?";

		// Token: 0x0400131A RID: 4890
		private const string KEY_PREFIX = "FaceExpressionDataById";

		// Token: 0x0400131B RID: 4891
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400131C RID: 4892
		private static int HandleId;
	}
}

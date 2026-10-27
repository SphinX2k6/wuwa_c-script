using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A9 RID: 681
	public class ConfigFaceExpressionDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FFB RID: 4091 RVA: 0x000B3C41 File Offset: 0x000B1E41
		static ConfigFaceExpressionDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFaceExpressionDataById.CreateStaticDefaultValue), new Action(ConfigFaceExpressionDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000B3C60 File Offset: 0x000B1E60
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

		// Token: 0x06000FFD RID: 4093 RVA: 0x000B3CDF File Offset: 0x000B1EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigFaceExpressionDataById.LogPair = null;
			ConfigFaceExpressionDataById.HandleId = 0;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000B3CED File Offset: 0x000B1EED
		public static void Init()
		{
			ConfigFaceExpressionDataById.HandleId = ConfigCommon.InitDataStatement(ConfigFaceExpressionDataById.HandleId, "db_faceexpressiondata.db", "select BinData from `FaceExpressionData` where Id=?");
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000B3D08 File Offset: 0x000B1F08
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

		// Token: 0x04001283 RID: 4739
		private const string DB = "db_faceexpressiondata.db";

		// Token: 0x04001284 RID: 4740
		private const string FILE = "k.可视化编辑/c.Csv/b.表情/*.csv*";

		// Token: 0x04001285 RID: 4741
		private const string TABLE = "FaceExpressionData";

		// Token: 0x04001286 RID: 4742
		private const string COMMAND = "select BinData from `FaceExpressionData` where Id=?";

		// Token: 0x04001287 RID: 4743
		private const string KEY_PREFIX = "FaceExpressionDataById";

		// Token: 0x04001288 RID: 4744
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001289 RID: 4745
		private static int HandleId;
	}
}

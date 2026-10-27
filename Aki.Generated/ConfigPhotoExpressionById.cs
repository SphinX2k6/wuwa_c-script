using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CE RID: 1742
	public class ConfigPhotoExpressionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028E4 RID: 10468 RVA: 0x00140A13 File Offset: 0x0013EC13
		static ConfigPhotoExpressionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionById.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionById.ResetStaticDefaultValue));
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00140A34 File Offset: 0x0013EC34
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoExpressionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoExpressionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoExpression` where Id=?")
			});
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00140AB3 File Offset: 0x0013ECB3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionById.LogPair = null;
			ConfigPhotoExpressionById.HandleId = 0;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00140AC1 File Offset: 0x0013ECC1
		public static void Init()
		{
			ConfigPhotoExpressionById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionById.HandleId, "db_photonew.db", "select BinData from `PhotoExpression` where Id=?");
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00140ADC File Offset: 0x0013ECDC
		public static PhotoExpression? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoExpressionById.HandleId, ConfigPhotoExpressionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoExpressionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoExpression?(PhotoExpression.GetRootAsPhotoExpression(configBuffer));
				}
			}
			ConfigPhotoExpressionById.LogPair.Clear();
			ConfigPhotoExpressionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoExpressionById.HandleId, 1, p0Id, ConfigPhotoExpressionById.LogPair) || ConfigCommon.Step(ConfigPhotoExpressionById.HandleId, true, ConfigPhotoExpressionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoExpressionById.HandleId, ConfigPhotoExpressionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoExpressionById.HandleId, 0, ConfigPhotoExpressionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoExpressionById.HandleId, ConfigPhotoExpressionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoExpression rootAsPhotoExpression = PhotoExpression.GetRootAsPhotoExpression(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoExpressionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoExpressionById.HandleId, ConfigPhotoExpressionById.LogPair);
			return new PhotoExpression?(rootAsPhotoExpression);
		}

		// Token: 0x04002F88 RID: 12168
		private const string DB = "db_photonew.db";

		// Token: 0x04002F89 RID: 12169
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002F8A RID: 12170
		private const string TABLE = "PhotoExpression";

		// Token: 0x04002F8B RID: 12171
		private const string COMMAND = "select BinData from `PhotoExpression` where Id=?";

		// Token: 0x04002F8C RID: 12172
		private const string KEY_PREFIX = "PhotoExpressionById";

		// Token: 0x04002F8D RID: 12173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F8E RID: 12174
		private static int HandleId;
	}
}

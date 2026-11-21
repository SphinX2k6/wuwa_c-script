using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E6 RID: 1766
	public class ConfigPhotoExpressionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002974 RID: 10612 RVA: 0x0014748F File Offset: 0x0014568F
		static ConfigPhotoExpressionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionById.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x001474B0 File Offset: 0x001456B0
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

		// Token: 0x06002976 RID: 10614 RVA: 0x0014752F File Offset: 0x0014572F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionById.LogPair = null;
			ConfigPhotoExpressionById.HandleId = 0;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0014753D File Offset: 0x0014573D
		public static void Init()
		{
			ConfigPhotoExpressionById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionById.HandleId, "db_photonew.db", "select BinData from `PhotoExpression` where Id=?");
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00147558 File Offset: 0x00145758
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

		// Token: 0x04003030 RID: 12336
		private const string DB = "db_photonew.db";

		// Token: 0x04003031 RID: 12337
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003032 RID: 12338
		private const string TABLE = "PhotoExpression";

		// Token: 0x04003033 RID: 12339
		private const string COMMAND = "select BinData from `PhotoExpression` where Id=?";

		// Token: 0x04003034 RID: 12340
		private const string KEY_PREFIX = "PhotoExpressionById";

		// Token: 0x04003035 RID: 12341
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003036 RID: 12342
		private static int HandleId;
	}
}

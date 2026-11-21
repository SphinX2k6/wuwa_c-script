using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E5 RID: 1765
	public class ConfigPhotoExpressionByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x00147257 File Offset: 0x00145457
		static ConfigPhotoExpressionByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionByGender.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionByGender.ResetStaticDefaultValue));
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00147278 File Offset: 0x00145478
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoExpressionByGender.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoExpressionByGender.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoExpression` where Gender=?")
			});
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x001472F7 File Offset: 0x001454F7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionByGender.LogPair = null;
			ConfigPhotoExpressionByGender.HandleId = 0;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00147305 File Offset: 0x00145505
		public static void Init()
		{
			ConfigPhotoExpressionByGender.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionByGender.HandleId, "db_photonew.db", "select BinData from `PhotoExpression` where Gender=?");
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00147320 File Offset: 0x00145520
		[NullableContext(2)]
		public static IReadOnlyList<PhotoExpression> GetConfigList(int p0Gender, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoExpressionByGender.HandleId, ConfigPhotoExpressionByGender.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoExpressionByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				IReadOnlyList<PhotoExpression> readOnlyList = (IReadOnlyList<PhotoExpression>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoExpressionByGender.LogPair.Clear();
			ConfigPhotoExpressionByGender.LogPair.Add(new ValueTuple<string, object>("Gender", p0Gender));
			if (!ConfigCommon.BindInt(ConfigPhotoExpressionByGender.HandleId, 1, p0Gender, ConfigPhotoExpressionByGender.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoExpressionByGender.HandleId, ConfigPhotoExpressionByGender.LogPair);
				return null;
			}
			List<PhotoExpression> list = new List<PhotoExpression>();
			while (ConfigCommon.Step(ConfigPhotoExpressionByGender.HandleId, false, ConfigPhotoExpressionByGender.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoExpressionByGender.HandleId, 0, ConfigPhotoExpressionByGender.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoExpressionByGender.HandleId, ConfigPhotoExpressionByGender.LogPair);
					return null;
				}
				PhotoExpression rootAsPhotoExpression = PhotoExpression.GetRootAsPhotoExpression(new ByteBuffer(item2));
				list.Add(rootAsPhotoExpression);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoExpressionByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoExpressionByGender.HandleId, ConfigPhotoExpressionByGender.LogPair);
			return list;
		}

		// Token: 0x04003029 RID: 12329
		private const string DB = "db_photonew.db";

		// Token: 0x0400302A RID: 12330
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400302B RID: 12331
		private const string TABLE = "PhotoExpression";

		// Token: 0x0400302C RID: 12332
		private const string COMMAND = "select BinData from `PhotoExpression` where Gender=?";

		// Token: 0x0400302D RID: 12333
		private const string KEY_PREFIX = "PhotoExpressionByGender";

		// Token: 0x0400302E RID: 12334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400302F RID: 12335
		private static int HandleId;
	}
}

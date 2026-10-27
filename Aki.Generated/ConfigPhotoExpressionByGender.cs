using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CD RID: 1741
	public class ConfigPhotoExpressionByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028DE RID: 10462 RVA: 0x001407DB File Offset: 0x0013E9DB
		static ConfigPhotoExpressionByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionByGender.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionByGender.ResetStaticDefaultValue));
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x001407FC File Offset: 0x0013E9FC
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

		// Token: 0x060028E0 RID: 10464 RVA: 0x0014087B File Offset: 0x0013EA7B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionByGender.LogPair = null;
			ConfigPhotoExpressionByGender.HandleId = 0;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00140889 File Offset: 0x0013EA89
		public static void Init()
		{
			ConfigPhotoExpressionByGender.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionByGender.HandleId, "db_photonew.db", "select BinData from `PhotoExpression` where Gender=?");
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x001408A4 File Offset: 0x0013EAA4
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

		// Token: 0x04002F81 RID: 12161
		private const string DB = "db_photonew.db";

		// Token: 0x04002F82 RID: 12162
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002F83 RID: 12163
		private const string TABLE = "PhotoExpression";

		// Token: 0x04002F84 RID: 12164
		private const string COMMAND = "select BinData from `PhotoExpression` where Gender=?";

		// Token: 0x04002F85 RID: 12165
		private const string KEY_PREFIX = "PhotoExpressionByGender";

		// Token: 0x04002F86 RID: 12166
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F87 RID: 12167
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E4 RID: 1764
	public class ConfigPhotoExpressionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x001470C3 File Offset: 0x001452C3
		static ConfigPhotoExpressionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionAll.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x001470E4 File Offset: 0x001452E4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoExpressionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoExpressionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoExpression`")
			});
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00147163 File Offset: 0x00145363
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionAll.LogPair = null;
			ConfigPhotoExpressionAll.HandleId = 0;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00147171 File Offset: 0x00145371
		public static void Init()
		{
			ConfigPhotoExpressionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionAll.HandleId, "db_photonew.db", "select BinData from `PhotoExpression`");
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0014718C File Offset: 0x0014538C
		[NullableContext(2)]
		public static IReadOnlyList<PhotoExpression> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoExpressionAll.HandleId, ConfigPhotoExpressionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoExpression> readOnlyList = (IReadOnlyList<PhotoExpression>)ConfigCommon.GetConfig("PhotoExpressionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoExpression> list = new List<PhotoExpression>();
			while (ConfigCommon.Step(ConfigPhotoExpressionAll.HandleId, false, ConfigPhotoExpressionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoExpressionAll.HandleId, 0, ConfigPhotoExpressionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoExpressionAll.HandleId, ConfigPhotoExpressionAll.LogPair);
					return null;
				}
				PhotoExpression rootAsPhotoExpression = PhotoExpression.GetRootAsPhotoExpression(new ByteBuffer(item2));
				list.Add(rootAsPhotoExpression);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoExpressionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoExpressionAll.HandleId, ConfigPhotoExpressionAll.LogPair);
			return list;
		}

		// Token: 0x04003022 RID: 12322
		private const string DB = "db_photonew.db";

		// Token: 0x04003023 RID: 12323
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003024 RID: 12324
		private const string TABLE = "PhotoExpression";

		// Token: 0x04003025 RID: 12325
		private const string COMMAND = "select BinData from `PhotoExpression`";

		// Token: 0x04003026 RID: 12326
		private const string KEY_PREFIX = "PhotoExpressionAll";

		// Token: 0x04003027 RID: 12327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003028 RID: 12328
		private static int HandleId;
	}
}

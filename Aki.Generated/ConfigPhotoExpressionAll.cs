using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CC RID: 1740
	public class ConfigPhotoExpressionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028D8 RID: 10456 RVA: 0x00140647 File Offset: 0x0013E847
		static ConfigPhotoExpressionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoExpressionAll.CreateStaticDefaultValue), new Action(ConfigPhotoExpressionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00140668 File Offset: 0x0013E868
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

		// Token: 0x060028DA RID: 10458 RVA: 0x001406E7 File Offset: 0x0013E8E7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoExpressionAll.LogPair = null;
			ConfigPhotoExpressionAll.HandleId = 0;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x001406F5 File Offset: 0x0013E8F5
		public static void Init()
		{
			ConfigPhotoExpressionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoExpressionAll.HandleId, "db_photonew.db", "select BinData from `PhotoExpression`");
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00140710 File Offset: 0x0013E910
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

		// Token: 0x04002F7A RID: 12154
		private const string DB = "db_photonew.db";

		// Token: 0x04002F7B RID: 12155
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002F7C RID: 12156
		private const string TABLE = "PhotoExpression";

		// Token: 0x04002F7D RID: 12157
		private const string COMMAND = "select BinData from `PhotoExpression`";

		// Token: 0x04002F7E RID: 12158
		private const string KEY_PREFIX = "PhotoExpressionAll";

		// Token: 0x04002F7F RID: 12159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F80 RID: 12160
		private static int HandleId;
	}
}

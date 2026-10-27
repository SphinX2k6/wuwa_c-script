using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000700 RID: 1792
	public class ConfigPhotoTemplateByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A10 RID: 10768 RVA: 0x001471E7 File Offset: 0x001453E7
		static ConfigPhotoTemplateByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateByGroupId.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00147208 File Offset: 0x00145408
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTemplateByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTemplateByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTemplate` where GroupId=?")
			});
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00147287 File Offset: 0x00145487
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateByGroupId.LogPair = null;
			ConfigPhotoTemplateByGroupId.HandleId = 0;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00147295 File Offset: 0x00145495
		public static void Init()
		{
			ConfigPhotoTemplateByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateByGroupId.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate` where GroupId=?");
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x001472B0 File Offset: 0x001454B0
		[NullableContext(2)]
		public static IReadOnlyList<PhotoTemplate> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTemplateByGroupId.HandleId, ConfigPhotoTemplateByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTemplateByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhotoTemplate> readOnlyList = (IReadOnlyList<PhotoTemplate>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoTemplateByGroupId.LogPair.Clear();
			ConfigPhotoTemplateByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhotoTemplateByGroupId.HandleId, 1, p0GroupId, ConfigPhotoTemplateByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoTemplateByGroupId.HandleId, ConfigPhotoTemplateByGroupId.LogPair);
				return null;
			}
			List<PhotoTemplate> list = new List<PhotoTemplate>();
			while (ConfigCommon.Step(ConfigPhotoTemplateByGroupId.HandleId, false, ConfigPhotoTemplateByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTemplateByGroupId.HandleId, 0, ConfigPhotoTemplateByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoTemplateByGroupId.HandleId, ConfigPhotoTemplateByGroupId.LogPair);
					return null;
				}
				PhotoTemplate rootAsPhotoTemplate = PhotoTemplate.GetRootAsPhotoTemplate(new ByteBuffer(item2));
				list.Add(rootAsPhotoTemplate);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTemplateByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoTemplateByGroupId.HandleId, ConfigPhotoTemplateByGroupId.LogPair);
			return list;
		}

		// Token: 0x040030E6 RID: 12518
		private const string DB = "db_photonew.db";

		// Token: 0x040030E7 RID: 12519
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030E8 RID: 12520
		private const string TABLE = "PhotoTemplate";

		// Token: 0x040030E9 RID: 12521
		private const string COMMAND = "select BinData from `PhotoTemplate` where GroupId=?";

		// Token: 0x040030EA RID: 12522
		private const string KEY_PREFIX = "PhotoTemplateByGroupId";

		// Token: 0x040030EB RID: 12523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030EC RID: 12524
		private static int HandleId;
	}
}

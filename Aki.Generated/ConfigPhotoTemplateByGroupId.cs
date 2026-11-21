using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000718 RID: 1816
	public class ConfigPhotoTemplateByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AA0 RID: 10912 RVA: 0x0014DC63 File Offset: 0x0014BE63
		static ConfigPhotoTemplateByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateByGroupId.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0014DC84 File Offset: 0x0014BE84
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

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0014DD03 File Offset: 0x0014BF03
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateByGroupId.LogPair = null;
			ConfigPhotoTemplateByGroupId.HandleId = 0;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0014DD11 File Offset: 0x0014BF11
		public static void Init()
		{
			ConfigPhotoTemplateByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateByGroupId.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate` where GroupId=?");
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0014DD2C File Offset: 0x0014BF2C
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

		// Token: 0x0400318E RID: 12686
		private const string DB = "db_photonew.db";

		// Token: 0x0400318F RID: 12687
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003190 RID: 12688
		private const string TABLE = "PhotoTemplate";

		// Token: 0x04003191 RID: 12689
		private const string COMMAND = "select BinData from `PhotoTemplate` where GroupId=?";

		// Token: 0x04003192 RID: 12690
		private const string KEY_PREFIX = "PhotoTemplateByGroupId";

		// Token: 0x04003193 RID: 12691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003194 RID: 12692
		private static int HandleId;
	}
}

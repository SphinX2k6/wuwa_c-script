using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000719 RID: 1817
	public class ConfigPhotoTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AA6 RID: 10918 RVA: 0x0014DE9B File Offset: 0x0014C09B
		static ConfigPhotoTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateById.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0014DEBC File Offset: 0x0014C0BC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTemplateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTemplateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTemplate` where Id=?")
			});
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0014DF3B File Offset: 0x0014C13B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateById.LogPair = null;
			ConfigPhotoTemplateById.HandleId = 0;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0014DF49 File Offset: 0x0014C149
		public static void Init()
		{
			ConfigPhotoTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateById.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate` where Id=?");
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0014DF64 File Offset: 0x0014C164
		public static PhotoTemplate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTemplateById.HandleId, ConfigPhotoTemplateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoTemplate?(PhotoTemplate.GetRootAsPhotoTemplate(configBuffer));
				}
			}
			ConfigPhotoTemplateById.LogPair.Clear();
			ConfigPhotoTemplateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoTemplateById.HandleId, 1, p0Id, ConfigPhotoTemplateById.LogPair) || ConfigCommon.Step(ConfigPhotoTemplateById.HandleId, true, ConfigPhotoTemplateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoTemplateById.HandleId, ConfigPhotoTemplateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTemplateById.HandleId, 0, ConfigPhotoTemplateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoTemplateById.HandleId, ConfigPhotoTemplateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoTemplate rootAsPhotoTemplate = PhotoTemplate.GetRootAsPhotoTemplate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoTemplateById.HandleId, ConfigPhotoTemplateById.LogPair);
			return new PhotoTemplate?(rootAsPhotoTemplate);
		}

		// Token: 0x04003195 RID: 12693
		private const string DB = "db_photonew.db";

		// Token: 0x04003196 RID: 12694
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003197 RID: 12695
		private const string TABLE = "PhotoTemplate";

		// Token: 0x04003198 RID: 12696
		private const string COMMAND = "select BinData from `PhotoTemplate` where Id=?";

		// Token: 0x04003199 RID: 12697
		private const string KEY_PREFIX = "PhotoTemplateById";

		// Token: 0x0400319A RID: 12698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400319B RID: 12699
		private static int HandleId;
	}
}

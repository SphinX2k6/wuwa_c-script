using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000701 RID: 1793
	public class ConfigPhotoTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A16 RID: 10774 RVA: 0x0014741F File Offset: 0x0014561F
		static ConfigPhotoTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTemplateById.CreateStaticDefaultValue), new Action(ConfigPhotoTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00147440 File Offset: 0x00145640
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

		// Token: 0x06002A18 RID: 10776 RVA: 0x001474BF File Offset: 0x001456BF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTemplateById.LogPair = null;
			ConfigPhotoTemplateById.HandleId = 0;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x001474CD File Offset: 0x001456CD
		public static void Init()
		{
			ConfigPhotoTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTemplateById.HandleId, "db_photonew.db", "select BinData from `PhotoTemplate` where Id=?");
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x001474E8 File Offset: 0x001456E8
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

		// Token: 0x040030ED RID: 12525
		private const string DB = "db_photonew.db";

		// Token: 0x040030EE RID: 12526
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030EF RID: 12527
		private const string TABLE = "PhotoTemplate";

		// Token: 0x040030F0 RID: 12528
		private const string COMMAND = "select BinData from `PhotoTemplate` where Id=?";

		// Token: 0x040030F1 RID: 12529
		private const string KEY_PREFIX = "PhotoTemplateById";

		// Token: 0x040030F2 RID: 12530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030F3 RID: 12531
		private static int HandleId;
	}
}

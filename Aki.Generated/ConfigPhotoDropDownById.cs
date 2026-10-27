using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CA RID: 1738
	public class ConfigPhotoDropDownById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x001401C8 File Offset: 0x0013E3C8
		static ConfigPhotoDropDownById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoDropDownById.CreateStaticDefaultValue), new Action(ConfigPhotoDropDownById.ResetStaticDefaultValue));
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x001401E8 File Offset: 0x0013E3E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoDropDownById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoDropDownById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoDropDown"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoDropDown` where Id=?")
			});
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00140267 File Offset: 0x0013E467
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoDropDownById.LogPair = null;
			ConfigPhotoDropDownById.HandleId = 0;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00140275 File Offset: 0x0013E475
		public static void Init()
		{
			ConfigPhotoDropDownById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoDropDownById.HandleId, "db_photograph.db", "select BinData from `PhotoDropDown` where Id=?");
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00140290 File Offset: 0x0013E490
		public static PhotoDropDown? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoDropDown?(PhotoDropDown.GetRootAsPhotoDropDown(configBuffer));
				}
			}
			ConfigPhotoDropDownById.LogPair.Clear();
			ConfigPhotoDropDownById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoDropDownById.HandleId, 1, p0Id, ConfigPhotoDropDownById.LogPair) || ConfigCommon.Step(ConfigPhotoDropDownById.HandleId, true, ConfigPhotoDropDownById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoDropDownById.HandleId, 0, ConfigPhotoDropDownById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoDropDown rootAsPhotoDropDown = PhotoDropDown.GetRootAsPhotoDropDown(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
			return new PhotoDropDown?(rootAsPhotoDropDown);
		}

		// Token: 0x04002F6C RID: 12140
		private const string DB = "db_photograph.db";

		// Token: 0x04002F6D RID: 12141
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04002F6E RID: 12142
		private const string TABLE = "PhotoDropDown";

		// Token: 0x04002F6F RID: 12143
		private const string COMMAND = "select BinData from `PhotoDropDown` where Id=?";

		// Token: 0x04002F70 RID: 12144
		private const string KEY_PREFIX = "PhotoDropDownById";

		// Token: 0x04002F71 RID: 12145
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F72 RID: 12146
		private static int HandleId;
	}
}

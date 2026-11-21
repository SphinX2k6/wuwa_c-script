using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E3 RID: 1763
	public class ConfigPhotoDropDownBySetupType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x00146E8C File Offset: 0x0014508C
		static ConfigPhotoDropDownBySetupType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoDropDownBySetupType.CreateStaticDefaultValue), new Action(ConfigPhotoDropDownBySetupType.ResetStaticDefaultValue));
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00146EAC File Offset: 0x001450AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoDropDownBySetupType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoDropDownBySetupType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoDropDown"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoDropDown` where SetupType=?")
			});
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00146F2B File Offset: 0x0014512B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoDropDownBySetupType.LogPair = null;
			ConfigPhotoDropDownBySetupType.HandleId = 0;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00146F39 File Offset: 0x00145139
		public static void Init()
		{
			ConfigPhotoDropDownBySetupType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoDropDownBySetupType.HandleId, "db_photograph.db", "select BinData from `PhotoDropDown` where SetupType=?");
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00146F54 File Offset: 0x00145154
		[NullableContext(2)]
		public static IReadOnlyList<PhotoDropDown> GetConfigList(int p0SetupType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoDropDownBySetupType.HandleId, ConfigPhotoDropDownBySetupType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownBySetupType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SetupType);
				IReadOnlyList<PhotoDropDown> readOnlyList = (IReadOnlyList<PhotoDropDown>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoDropDownBySetupType.LogPair.Clear();
			ConfigPhotoDropDownBySetupType.LogPair.Add(new ValueTuple<string, object>("SetupType", p0SetupType));
			if (!ConfigCommon.BindInt(ConfigPhotoDropDownBySetupType.HandleId, 1, p0SetupType, ConfigPhotoDropDownBySetupType.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoDropDownBySetupType.HandleId, ConfigPhotoDropDownBySetupType.LogPair);
				return null;
			}
			List<PhotoDropDown> list = new List<PhotoDropDown>();
			while (ConfigCommon.Step(ConfigPhotoDropDownBySetupType.HandleId, false, ConfigPhotoDropDownBySetupType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoDropDownBySetupType.HandleId, 0, ConfigPhotoDropDownBySetupType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoDropDownBySetupType.HandleId, ConfigPhotoDropDownBySetupType.LogPair);
					return null;
				}
				PhotoDropDown rootAsPhotoDropDown = PhotoDropDown.GetRootAsPhotoDropDown(new ByteBuffer(item2));
				list.Add(rootAsPhotoDropDown);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownBySetupType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SetupType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoDropDownBySetupType.HandleId, ConfigPhotoDropDownBySetupType.LogPair);
			return list;
		}

		// Token: 0x0400301B RID: 12315
		private const string DB = "db_photograph.db";

		// Token: 0x0400301C RID: 12316
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400301D RID: 12317
		private const string TABLE = "PhotoDropDown";

		// Token: 0x0400301E RID: 12318
		private const string COMMAND = "select BinData from `PhotoDropDown` where SetupType=?";

		// Token: 0x0400301F RID: 12319
		private const string KEY_PREFIX = "PhotoDropDownBySetupType";

		// Token: 0x04003020 RID: 12320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003021 RID: 12321
		private static int HandleId;
	}
}

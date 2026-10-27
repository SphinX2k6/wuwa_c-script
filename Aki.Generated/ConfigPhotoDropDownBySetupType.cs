using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CB RID: 1739
	public class ConfigPhotoDropDownBySetupType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028D2 RID: 10450 RVA: 0x00140410 File Offset: 0x0013E610
		static ConfigPhotoDropDownBySetupType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoDropDownBySetupType.CreateStaticDefaultValue), new Action(ConfigPhotoDropDownBySetupType.ResetStaticDefaultValue));
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00140430 File Offset: 0x0013E630
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

		// Token: 0x060028D4 RID: 10452 RVA: 0x001404AF File Offset: 0x0013E6AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoDropDownBySetupType.LogPair = null;
			ConfigPhotoDropDownBySetupType.HandleId = 0;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x001404BD File Offset: 0x0013E6BD
		public static void Init()
		{
			ConfigPhotoDropDownBySetupType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoDropDownBySetupType.HandleId, "db_photograph.db", "select BinData from `PhotoDropDown` where SetupType=?");
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x001404D8 File Offset: 0x0013E6D8
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

		// Token: 0x04002F73 RID: 12147
		private const string DB = "db_photograph.db";

		// Token: 0x04002F74 RID: 12148
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04002F75 RID: 12149
		private const string TABLE = "PhotoDropDown";

		// Token: 0x04002F76 RID: 12150
		private const string COMMAND = "select BinData from `PhotoDropDown` where SetupType=?";

		// Token: 0x04002F77 RID: 12151
		private const string KEY_PREFIX = "PhotoDropDownBySetupType";

		// Token: 0x04002F78 RID: 12152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F79 RID: 12153
		private static int HandleId;
	}
}

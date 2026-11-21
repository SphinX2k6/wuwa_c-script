using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070A RID: 1802
	public class ConfigPhotoSelfieMontageByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x0014C007 File Offset: 0x0014A207
		static ConfigPhotoSelfieMontageByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageByGender.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageByGender.ResetStaticDefaultValue));
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0014C028 File Offset: 0x0014A228
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageByGender.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSelfieMontageByGender.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSelfieMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSelfieMontage` where Gender=?")
			});
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x0014C0A7 File Offset: 0x0014A2A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageByGender.LogPair = null;
			ConfigPhotoSelfieMontageByGender.HandleId = 0;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x0014C0B5 File Offset: 0x0014A2B5
		public static void Init()
		{
			ConfigPhotoSelfieMontageByGender.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageByGender.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage` where Gender=?");
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0014C0D0 File Offset: 0x0014A2D0
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSelfieMontage> GetConfigList(int p0Gender, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSelfieMontageByGender.HandleId, ConfigPhotoSelfieMontageByGender.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSelfieMontageByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				IReadOnlyList<PhotoSelfieMontage> readOnlyList = (IReadOnlyList<PhotoSelfieMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoSelfieMontageByGender.LogPair.Clear();
			ConfigPhotoSelfieMontageByGender.LogPair.Add(new ValueTuple<string, object>("Gender", p0Gender));
			if (!ConfigCommon.BindInt(ConfigPhotoSelfieMontageByGender.HandleId, 1, p0Gender, ConfigPhotoSelfieMontageByGender.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoSelfieMontageByGender.HandleId, ConfigPhotoSelfieMontageByGender.LogPair);
				return null;
			}
			List<PhotoSelfieMontage> list = new List<PhotoSelfieMontage>();
			while (ConfigCommon.Step(ConfigPhotoSelfieMontageByGender.HandleId, false, ConfigPhotoSelfieMontageByGender.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSelfieMontageByGender.HandleId, 0, ConfigPhotoSelfieMontageByGender.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoSelfieMontageByGender.HandleId, ConfigPhotoSelfieMontageByGender.LogPair);
					return null;
				}
				PhotoSelfieMontage rootAsPhotoSelfieMontage = PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoSelfieMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSelfieMontageByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoSelfieMontageByGender.HandleId, ConfigPhotoSelfieMontageByGender.LogPair);
			return list;
		}

		// Token: 0x0400312C RID: 12588
		private const string DB = "db_photonew.db";

		// Token: 0x0400312D RID: 12589
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400312E RID: 12590
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x0400312F RID: 12591
		private const string COMMAND = "select BinData from `PhotoSelfieMontage` where Gender=?";

		// Token: 0x04003130 RID: 12592
		private const string KEY_PREFIX = "PhotoSelfieMontageByGender";

		// Token: 0x04003131 RID: 12593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003132 RID: 12594
		private static int HandleId;
	}
}

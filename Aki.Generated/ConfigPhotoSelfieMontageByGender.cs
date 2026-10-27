using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F2 RID: 1778
	public class ConfigPhotoSelfieMontageByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029BC RID: 10684 RVA: 0x0014558B File Offset: 0x0014378B
		static ConfigPhotoSelfieMontageByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageByGender.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageByGender.ResetStaticDefaultValue));
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x001455AC File Offset: 0x001437AC
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

		// Token: 0x060029BE RID: 10686 RVA: 0x0014562B File Offset: 0x0014382B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageByGender.LogPair = null;
			ConfigPhotoSelfieMontageByGender.HandleId = 0;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00145639 File Offset: 0x00143839
		public static void Init()
		{
			ConfigPhotoSelfieMontageByGender.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageByGender.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage` where Gender=?");
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00145654 File Offset: 0x00143854
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

		// Token: 0x04003084 RID: 12420
		private const string DB = "db_photonew.db";

		// Token: 0x04003085 RID: 12421
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003086 RID: 12422
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x04003087 RID: 12423
		private const string COMMAND = "select BinData from `PhotoSelfieMontage` where Gender=?";

		// Token: 0x04003088 RID: 12424
		private const string KEY_PREFIX = "PhotoSelfieMontageByGender";

		// Token: 0x04003089 RID: 12425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400308A RID: 12426
		private static int HandleId;
	}
}

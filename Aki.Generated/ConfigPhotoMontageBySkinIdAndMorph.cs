using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000706 RID: 1798
	public class ConfigPhotoMontageBySkinIdAndMorph : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A34 RID: 10804 RVA: 0x0014B6FF File Offset: 0x001498FF
		static ConfigPhotoMontageBySkinIdAndMorph()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageBySkinIdAndMorph.CreateStaticDefaultValue), new Action(ConfigPhotoMontageBySkinIdAndMorph.ResetStaticDefaultValue));
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0014B720 File Offset: 0x00149920
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageBySkinIdAndMorph.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageBySkinIdAndMorph.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where SkinId=? And Morph=?")
			});
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0014B79F File Offset: 0x0014999F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageBySkinIdAndMorph.LogPair = null;
			ConfigPhotoMontageBySkinIdAndMorph.HandleId = 0;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0014B7AD File Offset: 0x001499AD
		public static void Init()
		{
			ConfigPhotoMontageBySkinIdAndMorph.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageBySkinIdAndMorph.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where SkinId=? And Morph=?");
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x0014B7C8 File Offset: 0x001499C8
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMontage> GetConfigList(int p0SkinId, int p1Morph, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageBySkinIdAndMorph.HandleId, ConfigPhotoMontageBySkinIdAndMorph.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageBySkinIdAndMorph");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Morph);
				IReadOnlyList<PhotoMontage> readOnlyList = (IReadOnlyList<PhotoMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMontageBySkinIdAndMorph.LogPair.Clear();
			ConfigPhotoMontageBySkinIdAndMorph.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			ConfigPhotoMontageBySkinIdAndMorph.LogPair.Add(new ValueTuple<string, object>("Morph", p1Morph));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageBySkinIdAndMorph.HandleId, 1, p0SkinId, ConfigPhotoMontageBySkinIdAndMorph.LogPair) || !ConfigCommon.BindInt(ConfigPhotoMontageBySkinIdAndMorph.HandleId, 2, p1Morph, ConfigPhotoMontageBySkinIdAndMorph.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMorph.HandleId, ConfigPhotoMontageBySkinIdAndMorph.LogPair);
				return null;
			}
			List<PhotoMontage> list = new List<PhotoMontage>();
			while (ConfigCommon.Step(ConfigPhotoMontageBySkinIdAndMorph.HandleId, false, ConfigPhotoMontageBySkinIdAndMorph.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageBySkinIdAndMorph.HandleId, 0, ConfigPhotoMontageBySkinIdAndMorph.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMorph.HandleId, ConfigPhotoMontageBySkinIdAndMorph.LogPair);
					return null;
				}
				PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageBySkinIdAndMorph");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Morph);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMorph.HandleId, ConfigPhotoMontageBySkinIdAndMorph.LogPair);
			return list;
		}

		// Token: 0x04003110 RID: 12560
		private const string DB = "db_photograph.db";

		// Token: 0x04003111 RID: 12561
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003112 RID: 12562
		private const string TABLE = "PhotoMontage";

		// Token: 0x04003113 RID: 12563
		private const string COMMAND = "select BinData from `PhotoMontage` where SkinId=? And Morph=?";

		// Token: 0x04003114 RID: 12564
		private const string KEY_PREFIX = "PhotoMontageBySkinIdAndMorph";

		// Token: 0x04003115 RID: 12565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003116 RID: 12566
		private static int HandleId;
	}
}

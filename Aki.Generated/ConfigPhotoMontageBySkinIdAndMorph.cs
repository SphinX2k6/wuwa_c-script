using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EE RID: 1774
	public class ConfigPhotoMontageBySkinIdAndMorph : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029A4 RID: 10660 RVA: 0x00144C83 File Offset: 0x00142E83
		static ConfigPhotoMontageBySkinIdAndMorph()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageBySkinIdAndMorph.CreateStaticDefaultValue), new Action(ConfigPhotoMontageBySkinIdAndMorph.ResetStaticDefaultValue));
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00144CA4 File Offset: 0x00142EA4
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

		// Token: 0x060029A6 RID: 10662 RVA: 0x00144D23 File Offset: 0x00142F23
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageBySkinIdAndMorph.LogPair = null;
			ConfigPhotoMontageBySkinIdAndMorph.HandleId = 0;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00144D31 File Offset: 0x00142F31
		public static void Init()
		{
			ConfigPhotoMontageBySkinIdAndMorph.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageBySkinIdAndMorph.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where SkinId=? And Morph=?");
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00144D4C File Offset: 0x00142F4C
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

		// Token: 0x04003068 RID: 12392
		private const string DB = "db_photograph.db";

		// Token: 0x04003069 RID: 12393
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400306A RID: 12394
		private const string TABLE = "PhotoMontage";

		// Token: 0x0400306B RID: 12395
		private const string COMMAND = "select BinData from `PhotoMontage` where SkinId=? And Morph=?";

		// Token: 0x0400306C RID: 12396
		private const string KEY_PREFIX = "PhotoMontageBySkinIdAndMorph";

		// Token: 0x0400306D RID: 12397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400306E RID: 12398
		private static int HandleId;
	}
}

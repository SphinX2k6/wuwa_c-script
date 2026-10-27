using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006ED RID: 1773
	public class ConfigPhotoMontageBySkinIdAndMainAnimInstanceType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x001449F3 File Offset: 0x00142BF3
		static ConfigPhotoMontageBySkinIdAndMainAnimInstanceType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.CreateStaticDefaultValue), new Action(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.ResetStaticDefaultValue));
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00144A14 File Offset: 0x00142C14
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where SkinId=? And MainAnimInstanceType=?")
			});
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00144A93 File Offset: 0x00142C93
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair = null;
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId = 0;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00144AA1 File Offset: 0x00142CA1
		public static void Init()
		{
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where SkinId=? And MainAnimInstanceType=?");
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00144ABC File Offset: 0x00142CBC
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMontage> GetConfigList(int p0SkinId, int p1MainAnimInstanceType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageBySkinIdAndMainAnimInstanceType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MainAnimInstanceType);
				IReadOnlyList<PhotoMontage> readOnlyList = (IReadOnlyList<PhotoMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair.Clear();
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair.Add(new ValueTuple<string, object>("MainAnimInstanceType", p1MainAnimInstanceType));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, 1, p0SkinId, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair) || !ConfigCommon.BindInt(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, 2, p1MainAnimInstanceType, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair);
				return null;
			}
			List<PhotoMontage> list = new List<PhotoMontage>();
			while (ConfigCommon.Step(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, false, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, 0, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair);
					return null;
				}
				PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageBySkinIdAndMainAnimInstanceType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MainAnimInstanceType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageBySkinIdAndMainAnimInstanceType.LogPair);
			return list;
		}

		// Token: 0x04003061 RID: 12385
		private const string DB = "db_photograph.db";

		// Token: 0x04003062 RID: 12386
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003063 RID: 12387
		private const string TABLE = "PhotoMontage";

		// Token: 0x04003064 RID: 12388
		private const string COMMAND = "select BinData from `PhotoMontage` where SkinId=? And MainAnimInstanceType=?";

		// Token: 0x04003065 RID: 12389
		private const string KEY_PREFIX = "PhotoMontageBySkinIdAndMainAnimInstanceType";

		// Token: 0x04003066 RID: 12390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003067 RID: 12391
		private static int HandleId;
	}
}

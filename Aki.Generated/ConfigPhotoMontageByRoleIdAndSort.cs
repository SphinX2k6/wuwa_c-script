using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EC RID: 1772
	public class ConfigPhotoMontageByRoleIdAndSort : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x00144763 File Offset: 0x00142963
		static ConfigPhotoMontageByRoleIdAndSort()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleIdAndSort.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleIdAndSort.ResetStaticDefaultValue));
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00144784 File Offset: 0x00142984
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndSort.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageByRoleIdAndSort.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where RoleId=? And Sort=?")
			});
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00144803 File Offset: 0x00142A03
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndSort.LogPair = null;
			ConfigPhotoMontageByRoleIdAndSort.HandleId = 0;
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00144811 File Offset: 0x00142A11
		public static void Init()
		{
			ConfigPhotoMontageByRoleIdAndSort.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleIdAndSort.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=? And Sort=?");
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0014482C File Offset: 0x00142A2C
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMontage> GetConfigList(int p0RoleId, int p1Sort, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageByRoleIdAndSort.HandleId, ConfigPhotoMontageByRoleIdAndSort.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleIdAndSort");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Sort);
				IReadOnlyList<PhotoMontage> readOnlyList = (IReadOnlyList<PhotoMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMontageByRoleIdAndSort.LogPair.Clear();
			ConfigPhotoMontageByRoleIdAndSort.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigPhotoMontageByRoleIdAndSort.LogPair.Add(new ValueTuple<string, object>("Sort", p1Sort));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageByRoleIdAndSort.HandleId, 1, p0RoleId, ConfigPhotoMontageByRoleIdAndSort.LogPair) || !ConfigCommon.BindInt(ConfigPhotoMontageByRoleIdAndSort.HandleId, 2, p1Sort, ConfigPhotoMontageByRoleIdAndSort.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndSort.HandleId, ConfigPhotoMontageByRoleIdAndSort.LogPair);
				return null;
			}
			List<PhotoMontage> list = new List<PhotoMontage>();
			while (ConfigCommon.Step(ConfigPhotoMontageByRoleIdAndSort.HandleId, false, ConfigPhotoMontageByRoleIdAndSort.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageByRoleIdAndSort.HandleId, 0, ConfigPhotoMontageByRoleIdAndSort.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndSort.HandleId, ConfigPhotoMontageByRoleIdAndSort.LogPair);
					return null;
				}
				PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleIdAndSort");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Sort);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndSort.HandleId, ConfigPhotoMontageByRoleIdAndSort.LogPair);
			return list;
		}

		// Token: 0x0400305A RID: 12378
		private const string DB = "db_photograph.db";

		// Token: 0x0400305B RID: 12379
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400305C RID: 12380
		private const string TABLE = "PhotoMontage";

		// Token: 0x0400305D RID: 12381
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=? And Sort=?";

		// Token: 0x0400305E RID: 12382
		private const string KEY_PREFIX = "PhotoMontageByRoleIdAndSort";

		// Token: 0x0400305F RID: 12383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003060 RID: 12384
		private static int HandleId;
	}
}

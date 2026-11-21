using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000704 RID: 1796
	public class ConfigPhotoMontageByRoleIdAndSort : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A28 RID: 10792 RVA: 0x0014B1DF File Offset: 0x001493DF
		static ConfigPhotoMontageByRoleIdAndSort()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleIdAndSort.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleIdAndSort.ResetStaticDefaultValue));
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0014B200 File Offset: 0x00149400
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

		// Token: 0x06002A2A RID: 10794 RVA: 0x0014B27F File Offset: 0x0014947F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndSort.LogPair = null;
			ConfigPhotoMontageByRoleIdAndSort.HandleId = 0;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0014B28D File Offset: 0x0014948D
		public static void Init()
		{
			ConfigPhotoMontageByRoleIdAndSort.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleIdAndSort.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=? And Sort=?");
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0014B2A8 File Offset: 0x001494A8
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

		// Token: 0x04003102 RID: 12546
		private const string DB = "db_photograph.db";

		// Token: 0x04003103 RID: 12547
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003104 RID: 12548
		private const string TABLE = "PhotoMontage";

		// Token: 0x04003105 RID: 12549
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=? And Sort=?";

		// Token: 0x04003106 RID: 12550
		private const string KEY_PREFIX = "PhotoMontageByRoleIdAndSort";

		// Token: 0x04003107 RID: 12551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003108 RID: 12552
		private static int HandleId;
	}
}

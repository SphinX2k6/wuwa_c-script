using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EA RID: 1770
	public class ConfigPhotoMontageByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x0014429C File Offset: 0x0014249C
		static ConfigPhotoMontageByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleId.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x001442BC File Offset: 0x001424BC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where RoleId=?")
			});
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0014433B File Offset: 0x0014253B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleId.LogPair = null;
			ConfigPhotoMontageByRoleId.HandleId = 0;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00144349 File Offset: 0x00142549
		public static void Init()
		{
			ConfigPhotoMontageByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleId.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=?");
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00144364 File Offset: 0x00142564
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMontage> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageByRoleId.HandleId, ConfigPhotoMontageByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<PhotoMontage> readOnlyList = (IReadOnlyList<PhotoMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMontageByRoleId.LogPair.Clear();
			ConfigPhotoMontageByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageByRoleId.HandleId, 1, p0RoleId, ConfigPhotoMontageByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMontageByRoleId.HandleId, ConfigPhotoMontageByRoleId.LogPair);
				return null;
			}
			List<PhotoMontage> list = new List<PhotoMontage>();
			while (ConfigCommon.Step(ConfigPhotoMontageByRoleId.HandleId, false, ConfigPhotoMontageByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageByRoleId.HandleId, 0, ConfigPhotoMontageByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMontageByRoleId.HandleId, ConfigPhotoMontageByRoleId.LogPair);
					return null;
				}
				PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMontageByRoleId.HandleId, ConfigPhotoMontageByRoleId.LogPair);
			return list;
		}

		// Token: 0x0400304C RID: 12364
		private const string DB = "db_photograph.db";

		// Token: 0x0400304D RID: 12365
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400304E RID: 12366
		private const string TABLE = "PhotoMontage";

		// Token: 0x0400304F RID: 12367
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=?";

		// Token: 0x04003050 RID: 12368
		private const string KEY_PREFIX = "PhotoMontageByRoleId";

		// Token: 0x04003051 RID: 12369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003052 RID: 12370
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000702 RID: 1794
	public class ConfigPhotoMontageByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x0014AD18 File Offset: 0x00148F18
		static ConfigPhotoMontageByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleId.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0014AD38 File Offset: 0x00148F38
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

		// Token: 0x06002A1E RID: 10782 RVA: 0x0014ADB7 File Offset: 0x00148FB7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleId.LogPair = null;
			ConfigPhotoMontageByRoleId.HandleId = 0;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x0014ADC5 File Offset: 0x00148FC5
		public static void Init()
		{
			ConfigPhotoMontageByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleId.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=?");
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x0014ADE0 File Offset: 0x00148FE0
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

		// Token: 0x040030F4 RID: 12532
		private const string DB = "db_photograph.db";

		// Token: 0x040030F5 RID: 12533
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x040030F6 RID: 12534
		private const string TABLE = "PhotoMontage";

		// Token: 0x040030F7 RID: 12535
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=?";

		// Token: 0x040030F8 RID: 12536
		private const string KEY_PREFIX = "PhotoMontageByRoleId";

		// Token: 0x040030F9 RID: 12537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030FA RID: 12538
		private static int HandleId;
	}
}

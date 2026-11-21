using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000703 RID: 1795
	public class ConfigPhotoMontageByRoleIdAndMainAnimInstanceType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A22 RID: 10786 RVA: 0x0014AF4F File Offset: 0x0014914F
		static ConfigPhotoMontageByRoleIdAndMainAnimInstanceType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x0014AF70 File Offset: 0x00149170
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where RoleId=? And MainAnimInstanceType=?")
			});
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x0014AFEF File Offset: 0x001491EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair = null;
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId = 0;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0014AFFD File Offset: 0x001491FD
		public static void Init()
		{
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=? And MainAnimInstanceType=?");
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0014B018 File Offset: 0x00149218
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMontage> GetConfigList(int p0RoleId, int p1MainAnimInstanceType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleIdAndMainAnimInstanceType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MainAnimInstanceType);
				IReadOnlyList<PhotoMontage> readOnlyList = (IReadOnlyList<PhotoMontage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair.Clear();
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair.Add(new ValueTuple<string, object>("MainAnimInstanceType", p1MainAnimInstanceType));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, 1, p0RoleId, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair) || !ConfigCommon.BindInt(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, 2, p1MainAnimInstanceType, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair);
				return null;
			}
			List<PhotoMontage> list = new List<PhotoMontage>();
			while (ConfigCommon.Step(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, false, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, 0, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair);
					return null;
				}
				PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(new ByteBuffer(item2));
				list.Add(rootAsPhotoMontage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageByRoleIdAndMainAnimInstanceType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MainAnimInstanceType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair);
			return list;
		}

		// Token: 0x040030FB RID: 12539
		private const string DB = "db_photograph.db";

		// Token: 0x040030FC RID: 12540
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x040030FD RID: 12541
		private const string TABLE = "PhotoMontage";

		// Token: 0x040030FE RID: 12542
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=? And MainAnimInstanceType=?";

		// Token: 0x040030FF RID: 12543
		private const string KEY_PREFIX = "PhotoMontageByRoleIdAndMainAnimInstanceType";

		// Token: 0x04003100 RID: 12544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003101 RID: 12545
		private static int HandleId;
	}
}

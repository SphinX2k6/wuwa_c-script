using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EB RID: 1771
	public class ConfigPhotoMontageByRoleIdAndMainAnimInstanceType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002992 RID: 10642 RVA: 0x001444D3 File Offset: 0x001426D3
		static ConfigPhotoMontageByRoleIdAndMainAnimInstanceType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.CreateStaticDefaultValue), new Action(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.ResetStaticDefaultValue));
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x001444F4 File Offset: 0x001426F4
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

		// Token: 0x06002994 RID: 10644 RVA: 0x00144573 File Offset: 0x00142773
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.LogPair = null;
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId = 0;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00144581 File Offset: 0x00142781
		public static void Init()
		{
			ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageByRoleIdAndMainAnimInstanceType.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where RoleId=? And MainAnimInstanceType=?");
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0014459C File Offset: 0x0014279C
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

		// Token: 0x04003053 RID: 12371
		private const string DB = "db_photograph.db";

		// Token: 0x04003054 RID: 12372
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003055 RID: 12373
		private const string TABLE = "PhotoMontage";

		// Token: 0x04003056 RID: 12374
		private const string COMMAND = "select BinData from `PhotoMontage` where RoleId=? And MainAnimInstanceType=?";

		// Token: 0x04003057 RID: 12375
		private const string KEY_PREFIX = "PhotoMontageByRoleIdAndMainAnimInstanceType";

		// Token: 0x04003058 RID: 12376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003059 RID: 12377
		private static int HandleId;
	}
}

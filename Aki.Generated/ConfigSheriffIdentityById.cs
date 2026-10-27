using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000917 RID: 2327
	public class ConfigSheriffIdentityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600369D RID: 13981 RVA: 0x0018E174 File Offset: 0x0018C374
		static ConfigSheriffIdentityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffIdentityById.CreateStaticDefaultValue), new Action(ConfigSheriffIdentityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0018E194 File Offset: 0x0018C394
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffIdentityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffIdentityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffIdentity"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffIdentity` where Id=?")
			});
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0018E213 File Offset: 0x0018C413
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffIdentityById.LogPair = null;
			ConfigSheriffIdentityById.HandleId = 0;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0018E221 File Offset: 0x0018C421
		public static void Init()
		{
			ConfigSheriffIdentityById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffIdentityById.HandleId, "db_sheriff.db", "select BinData from `SheriffIdentity` where Id=?");
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0018E23C File Offset: 0x0018C43C
		public static SheriffIdentity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffIdentityById.HandleId, ConfigSheriffIdentityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffIdentityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffIdentity?(SheriffIdentity.GetRootAsSheriffIdentity(configBuffer));
				}
			}
			ConfigSheriffIdentityById.LogPair.Clear();
			ConfigSheriffIdentityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffIdentityById.HandleId, 1, p0Id, ConfigSheriffIdentityById.LogPair) || ConfigCommon.Step(ConfigSheriffIdentityById.HandleId, true, ConfigSheriffIdentityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffIdentityById.HandleId, ConfigSheriffIdentityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffIdentityById.HandleId, 0, ConfigSheriffIdentityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffIdentityById.HandleId, ConfigSheriffIdentityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffIdentity rootAsSheriffIdentity = SheriffIdentity.GetRootAsSheriffIdentity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffIdentityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffIdentityById.HandleId, ConfigSheriffIdentityById.LogPair);
			return new SheriffIdentity?(rootAsSheriffIdentity);
		}

		// Token: 0x04003F87 RID: 16263
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F88 RID: 16264
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F89 RID: 16265
		private const string TABLE = "SheriffIdentity";

		// Token: 0x04003F8A RID: 16266
		private const string COMMAND = "select BinData from `SheriffIdentity` where Id=?";

		// Token: 0x04003F8B RID: 16267
		private const string KEY_PREFIX = "SheriffIdentityById";

		// Token: 0x04003F8C RID: 16268
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F8D RID: 16269
		private static int HandleId;
	}
}

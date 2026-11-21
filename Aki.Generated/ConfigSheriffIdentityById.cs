using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000962 RID: 2402
	public class ConfigSheriffIdentityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600385F RID: 14431 RVA: 0x0019B394 File Offset: 0x00199594
		static ConfigSheriffIdentityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffIdentityById.CreateStaticDefaultValue), new Action(ConfigSheriffIdentityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0019B3B4 File Offset: 0x001995B4
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

		// Token: 0x06003861 RID: 14433 RVA: 0x0019B433 File Offset: 0x00199633
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffIdentityById.LogPair = null;
			ConfigSheriffIdentityById.HandleId = 0;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x0019B441 File Offset: 0x00199641
		public static void Init()
		{
			ConfigSheriffIdentityById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffIdentityById.HandleId, "db_sheriff.db", "select BinData from `SheriffIdentity` where Id=?");
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0019B45C File Offset: 0x0019965C
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

		// Token: 0x04004194 RID: 16788
		private const string DB = "db_sheriff.db";

		// Token: 0x04004195 RID: 16789
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004196 RID: 16790
		private const string TABLE = "SheriffIdentity";

		// Token: 0x04004197 RID: 16791
		private const string COMMAND = "select BinData from `SheriffIdentity` where Id=?";

		// Token: 0x04004198 RID: 16792
		private const string KEY_PREFIX = "SheriffIdentityById";

		// Token: 0x04004199 RID: 16793
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400419A RID: 16794
		private static int HandleId;
	}
}

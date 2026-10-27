using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000916 RID: 2326
	public class ConfigSheriffEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x0018DF2B File Offset: 0x0018C12B
		static ConfigSheriffEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffEndingById.CreateStaticDefaultValue), new Action(ConfigSheriffEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0018DF4C File Offset: 0x0018C14C
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffEnding` where Id=?")
			});
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0018DFCB File Offset: 0x0018C1CB
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffEndingById.LogPair = null;
			ConfigSheriffEndingById.HandleId = 0;
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0018DFD9 File Offset: 0x0018C1D9
		public static void Init()
		{
			ConfigSheriffEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffEndingById.HandleId, "db_sheriff.db", "select BinData from `SheriffEnding` where Id=?");
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x0018DFF4 File Offset: 0x0018C1F4
		public static SheriffEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffEnding?(SheriffEnding.GetRootAsSheriffEnding(configBuffer));
				}
			}
			ConfigSheriffEndingById.LogPair.Clear();
			ConfigSheriffEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffEndingById.HandleId, 1, p0Id, ConfigSheriffEndingById.LogPair) || ConfigCommon.Step(ConfigSheriffEndingById.HandleId, true, ConfigSheriffEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffEndingById.HandleId, 0, ConfigSheriffEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffEnding rootAsSheriffEnding = SheriffEnding.GetRootAsSheriffEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
			return new SheriffEnding?(rootAsSheriffEnding);
		}

		// Token: 0x04003F80 RID: 16256
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F81 RID: 16257
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F82 RID: 16258
		private const string TABLE = "SheriffEnding";

		// Token: 0x04003F83 RID: 16259
		private const string COMMAND = "select BinData from `SheriffEnding` where Id=?";

		// Token: 0x04003F84 RID: 16260
		private const string KEY_PREFIX = "SheriffEndingById";

		// Token: 0x04003F85 RID: 16261
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F86 RID: 16262
		private static int HandleId;
	}
}

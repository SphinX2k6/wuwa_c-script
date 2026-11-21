using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5D RID: 2653
	public class ConfigSpringFestivalUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E42 RID: 15938 RVA: 0x001BC9B4 File Offset: 0x001BABB4
		static ConfigSpringFestivalUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalUnlockById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x001BC9D4 File Offset: 0x001BABD4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalUnlockById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalUnlockById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalUnlock"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalUnlock` where Id=?")
			});
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x001BCA53 File Offset: 0x001BAC53
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalUnlockById.LogPair = null;
			ConfigSpringFestivalUnlockById.HandleId = 0;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x001BCA61 File Offset: 0x001BAC61
		public static void Init()
		{
			ConfigSpringFestivalUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalUnlockById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalUnlock` where Id=?");
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x001BCA7C File Offset: 0x001BAC7C
		public static SpringFestivalUnlock? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalUnlockById.HandleId, ConfigSpringFestivalUnlockById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalUnlock?(SpringFestivalUnlock.GetRootAsSpringFestivalUnlock(configBuffer));
				}
			}
			ConfigSpringFestivalUnlockById.LogPair.Clear();
			ConfigSpringFestivalUnlockById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalUnlockById.HandleId, 1, p0Id, ConfigSpringFestivalUnlockById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalUnlockById.HandleId, true, ConfigSpringFestivalUnlockById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalUnlockById.HandleId, ConfigSpringFestivalUnlockById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalUnlockById.HandleId, 0, ConfigSpringFestivalUnlockById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalUnlockById.HandleId, ConfigSpringFestivalUnlockById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalUnlock rootAsSpringFestivalUnlock = SpringFestivalUnlock.GetRootAsSpringFestivalUnlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalUnlockById.HandleId, ConfigSpringFestivalUnlockById.LogPair);
			return new SpringFestivalUnlock?(rootAsSpringFestivalUnlock);
		}

		// Token: 0x04004871 RID: 18545
		private const string DB = "db_spring26.db";

		// Token: 0x04004872 RID: 18546
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004873 RID: 18547
		private const string TABLE = "SpringFestivalUnlock";

		// Token: 0x04004874 RID: 18548
		private const string COMMAND = "select BinData from `SpringFestivalUnlock` where Id=?";

		// Token: 0x04004875 RID: 18549
		private const string KEY_PREFIX = "SpringFestivalUnlockById";

		// Token: 0x04004876 RID: 18550
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004877 RID: 18551
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000988 RID: 2440
	public class ConfigSpringFestivalUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003944 RID: 14660 RVA: 0x0019D620 File Offset: 0x0019B820
		static ConfigSpringFestivalUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalUnlockById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0019D640 File Offset: 0x0019B840
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

		// Token: 0x06003946 RID: 14662 RVA: 0x0019D6BF File Offset: 0x0019B8BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalUnlockById.LogPair = null;
			ConfigSpringFestivalUnlockById.HandleId = 0;
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x0019D6CD File Offset: 0x0019B8CD
		public static void Init()
		{
			ConfigSpringFestivalUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalUnlockById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalUnlock` where Id=?");
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x0019D6E8 File Offset: 0x0019B8E8
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

		// Token: 0x0400429E RID: 17054
		private const string DB = "db_spring26.db";

		// Token: 0x0400429F RID: 17055
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040042A0 RID: 17056
		private const string TABLE = "SpringFestivalUnlock";

		// Token: 0x040042A1 RID: 17057
		private const string COMMAND = "select BinData from `SpringFestivalUnlock` where Id=?";

		// Token: 0x040042A2 RID: 17058
		private const string KEY_PREFIX = "SpringFestivalUnlockById";

		// Token: 0x040042A3 RID: 17059
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042A4 RID: 17060
		private static int HandleId;
	}
}

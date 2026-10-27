using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000122 RID: 290
	public class ConfigBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00080199 File Offset: 0x0007E399
		static ConfigBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffById.CreateStaticDefaultValue), new Action(ConfigBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000801B8 File Offset: 0x0007E3B8
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buff.db"),
				new ValueTuple<string, object>("文件", "b.Buff.xlsx"),
				new ValueTuple<string, object>("表名", "Buff"),
				new ValueTuple<string, object>("语句", "select BinData from `Buff` where Id=?")
			});
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00080237 File Offset: 0x0007E437
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffById.LogPair = null;
			ConfigBuffById.HandleId = 0;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00080245 File Offset: 0x0007E445
		public static void Init()
		{
			ConfigBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffById.HandleId, "db_buff.db", "select BinData from `Buff` where Id=?");
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00080260 File Offset: 0x0007E460
		public static Buff? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffById.HandleId, ConfigBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Buff?(Buff.GetRootAsBuff(configBuffer));
				}
			}
			ConfigBuffById.LogPair.Clear();
			ConfigBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigBuffById.HandleId, 1, (double)p0Id, ConfigBuffById.LogPair) || ConfigCommon.Step(ConfigBuffById.HandleId, true, ConfigBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffById.HandleId, 0, ConfigBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Buff rootAsBuff = Buff.GetRootAsBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
			return new Buff?(rootAsBuff);
		}

		// Token: 0x040007D2 RID: 2002
		private const string DB = "db_buff.db";

		// Token: 0x040007D3 RID: 2003
		private const string FILE = "b.Buff.xlsx";

		// Token: 0x040007D4 RID: 2004
		private const string TABLE = "Buff";

		// Token: 0x040007D5 RID: 2005
		private const string COMMAND = "select BinData from `Buff` where Id=?";

		// Token: 0x040007D6 RID: 2006
		private const string KEY_PREFIX = "BuffById";

		// Token: 0x040007D7 RID: 2007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007D8 RID: 2008
		private static int HandleId;
	}
}

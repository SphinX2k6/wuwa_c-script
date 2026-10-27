using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000120 RID: 288
	public class ConfigBrokenRockRingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0007FD58 File Offset: 0x0007DF58
		static ConfigBrokenRockRingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrokenRockRingById.CreateStaticDefaultValue), new Action(ConfigBrokenRockRingById.ResetStaticDefaultValue));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0007FD78 File Offset: 0x0007DF78
		public static void CreateStaticDefaultValue()
		{
			ConfigBrokenRockRingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBrokenRockRingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_brokenrockconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/p.破碎岩石圆环/*.csv*"),
				new ValueTuple<string, object>("表名", "BrokenRockRing"),
				new ValueTuple<string, object>("语句", "select BinData from `BrokenRockRing` where Id=?")
			});
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0007FDF7 File Offset: 0x0007DFF7
		public static void ResetStaticDefaultValue()
		{
			ConfigBrokenRockRingById.LogPair = null;
			ConfigBrokenRockRingById.HandleId = 0;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0007FE05 File Offset: 0x0007E005
		public static void Init()
		{
			ConfigBrokenRockRingById.HandleId = ConfigCommon.InitDataStatement(ConfigBrokenRockRingById.HandleId, "db_brokenrockconfig.db", "select BinData from `BrokenRockRing` where Id=?");
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0007FE20 File Offset: 0x0007E020
		public static BrokenRockRing? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBrokenRockRingById.HandleId, ConfigBrokenRockRingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrokenRockRingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BrokenRockRing?(BrokenRockRing.GetRootAsBrokenRockRing(configBuffer));
				}
			}
			ConfigBrokenRockRingById.LogPair.Clear();
			ConfigBrokenRockRingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBrokenRockRingById.HandleId, 1, p0Id, ConfigBrokenRockRingById.LogPair) || ConfigCommon.Step(ConfigBrokenRockRingById.HandleId, true, ConfigBrokenRockRingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBrokenRockRingById.HandleId, ConfigBrokenRockRingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBrokenRockRingById.HandleId, 0, ConfigBrokenRockRingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBrokenRockRingById.HandleId, ConfigBrokenRockRingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BrokenRockRing rootAsBrokenRockRing = BrokenRockRing.GetRootAsBrokenRockRing(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrokenRockRingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBrokenRockRingById.HandleId, ConfigBrokenRockRingById.LogPair);
			return new BrokenRockRing?(rootAsBrokenRockRing);
		}

		// Token: 0x040007C4 RID: 1988
		private const string DB = "db_brokenrockconfig.db";

		// Token: 0x040007C5 RID: 1989
		private const string FILE = "k.可视化编辑/c.Csv/p.破碎岩石圆环/*.csv*";

		// Token: 0x040007C6 RID: 1990
		private const string TABLE = "BrokenRockRing";

		// Token: 0x040007C7 RID: 1991
		private const string COMMAND = "select BinData from `BrokenRockRing` where Id=?";

		// Token: 0x040007C8 RID: 1992
		private const string KEY_PREFIX = "BrokenRockRingById";

		// Token: 0x040007C9 RID: 1993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007CA RID: 1994
		private static int HandleId;
	}
}

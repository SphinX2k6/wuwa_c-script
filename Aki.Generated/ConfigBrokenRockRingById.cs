using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012F RID: 303
	public class ConfigBrokenRockRingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x000856BC File Offset: 0x000838BC
		static ConfigBrokenRockRingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrokenRockRingById.CreateStaticDefaultValue), new Action(ConfigBrokenRockRingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000856DC File Offset: 0x000838DC
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

		// Token: 0x0600071D RID: 1821 RVA: 0x0008575B File Offset: 0x0008395B
		public static void ResetStaticDefaultValue()
		{
			ConfigBrokenRockRingById.LogPair = null;
			ConfigBrokenRockRingById.HandleId = 0;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00085769 File Offset: 0x00083969
		public static void Init()
		{
			ConfigBrokenRockRingById.HandleId = ConfigCommon.InitDataStatement(ConfigBrokenRockRingById.HandleId, "db_brokenrockconfig.db", "select BinData from `BrokenRockRing` where Id=?");
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00085784 File Offset: 0x00083984
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

		// Token: 0x0400082D RID: 2093
		private const string DB = "db_brokenrockconfig.db";

		// Token: 0x0400082E RID: 2094
		private const string FILE = "k.可视化编辑/c.Csv/p.破碎岩石圆环/*.csv*";

		// Token: 0x0400082F RID: 2095
		private const string TABLE = "BrokenRockRing";

		// Token: 0x04000830 RID: 2096
		private const string COMMAND = "select BinData from `BrokenRockRing` where Id=?";

		// Token: 0x04000831 RID: 2097
		private const string KEY_PREFIX = "BrokenRockRingById";

		// Token: 0x04000832 RID: 2098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000833 RID: 2099
		private static int HandleId;
	}
}

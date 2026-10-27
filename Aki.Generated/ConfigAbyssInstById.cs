using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000013 RID: 19
	public class ConfigAbyssInstById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0005C807 File Offset: 0x0005AA07
		static ConfigAbyssInstById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssInstById.CreateStaticDefaultValue), new Action(ConfigAbyssInstById.ResetStaticDefaultValue));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0005C828 File Offset: 0x0005AA28
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssInstById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssInstById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssInst"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssInst` where Id=?")
			});
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0005C8A7 File Offset: 0x0005AAA7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssInstById.LogPair = null;
			ConfigAbyssInstById.HandleId = 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0005C8B5 File Offset: 0x0005AAB5
		public static void Init()
		{
			ConfigAbyssInstById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssInstById.HandleId, "db_dangoabyss.db", "select BinData from `AbyssInst` where Id=?");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
		public static AbyssInst? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssInstById.HandleId, ConfigAbyssInstById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssInst?(AbyssInst.GetRootAsAbyssInst(configBuffer));
				}
			}
			ConfigAbyssInstById.LogPair.Clear();
			ConfigAbyssInstById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssInstById.HandleId, 1, p0Id, ConfigAbyssInstById.LogPair) || ConfigCommon.Step(ConfigAbyssInstById.HandleId, true, ConfigAbyssInstById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssInstById.HandleId, ConfigAbyssInstById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssInstById.HandleId, 0, ConfigAbyssInstById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssInstById.HandleId, ConfigAbyssInstById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssInst rootAsAbyssInst = AbyssInst.GetRootAsAbyssInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssInstById.HandleId, ConfigAbyssInstById.LogPair);
			return new AbyssInst?(rootAsAbyssInst);
		}

		// Token: 0x04000069 RID: 105
		private const string DB = "db_dangoabyss.db";

		// Token: 0x0400006A RID: 106
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x0400006B RID: 107
		private const string TABLE = "AbyssInst";

		// Token: 0x0400006C RID: 108
		private const string COMMAND = "select BinData from `AbyssInst` where Id=?";

		// Token: 0x0400006D RID: 109
		private const string KEY_PREFIX = "AbyssInstById";

		// Token: 0x0400006E RID: 110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400006F RID: 111
		private static int HandleId;
	}
}

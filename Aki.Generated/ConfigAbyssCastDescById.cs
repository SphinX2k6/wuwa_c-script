using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000010 RID: 16
	public class ConfigAbyssCastDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0005C1F3 File Offset: 0x0005A3F3
		static ConfigAbyssCastDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssCastDescById.CreateStaticDefaultValue), new Action(ConfigAbyssCastDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0005C214 File Offset: 0x0005A414
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssCastDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssCastDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssCastDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssCastDesc` where Id=?")
			});
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0005C293 File Offset: 0x0005A493
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssCastDescById.LogPair = null;
			ConfigAbyssCastDescById.HandleId = 0;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0005C2A1 File Offset: 0x0005A4A1
		public static void Init()
		{
			ConfigAbyssCastDescById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssCastDescById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssCastDesc` where Id=?");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0005C2BC File Offset: 0x0005A4BC
		public static AbyssCastDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssCastDescById.HandleId, ConfigAbyssCastDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssCastDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssCastDesc?(AbyssCastDesc.GetRootAsAbyssCastDesc(configBuffer));
				}
			}
			ConfigAbyssCastDescById.LogPair.Clear();
			ConfigAbyssCastDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssCastDescById.HandleId, 1, p0Id, ConfigAbyssCastDescById.LogPair) || ConfigCommon.Step(ConfigAbyssCastDescById.HandleId, true, ConfigAbyssCastDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssCastDescById.HandleId, ConfigAbyssCastDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssCastDescById.HandleId, 0, ConfigAbyssCastDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssCastDescById.HandleId, ConfigAbyssCastDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssCastDesc rootAsAbyssCastDesc = AbyssCastDesc.GetRootAsAbyssCastDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssCastDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssCastDescById.HandleId, ConfigAbyssCastDescById.LogPair);
			return new AbyssCastDesc?(rootAsAbyssCastDesc);
		}

		// Token: 0x04000054 RID: 84
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x04000055 RID: 85
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000056 RID: 86
		private const string TABLE = "AbyssCastDesc";

		// Token: 0x04000057 RID: 87
		private const string COMMAND = "select BinData from `AbyssCastDesc` where Id=?";

		// Token: 0x04000058 RID: 88
		private const string KEY_PREFIX = "AbyssCastDescById";

		// Token: 0x04000059 RID: 89
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400005A RID: 90
		private static int HandleId;
	}
}

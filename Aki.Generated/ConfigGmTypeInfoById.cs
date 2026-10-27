using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A8 RID: 936
	public class ConfigGmTypeInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x000D5A5F File Offset: 0x000D3C5F
		static ConfigGmTypeInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmTypeInfoById.CreateStaticDefaultValue), new Action(ConfigGmTypeInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000D5A80 File Offset: 0x000D3C80
		public static void CreateStaticDefaultValue()
		{
			ConfigGmTypeInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmTypeInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmTypeInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GmTypeInfo` where Id=?")
			});
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000D5AFF File Offset: 0x000D3CFF
		public static void ResetStaticDefaultValue()
		{
			ConfigGmTypeInfoById.LogPair = null;
			ConfigGmTypeInfoById.HandleId = 0;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000D5B0D File Offset: 0x000D3D0D
		public static void Init()
		{
			ConfigGmTypeInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGmTypeInfoById.HandleId, "db_gm.db", "select BinData from `GmTypeInfo` where Id=?");
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000D5B28 File Offset: 0x000D3D28
		public static GmTypeInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmTypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmTypeInfo?(GmTypeInfo.GetRootAsGmTypeInfo(configBuffer));
				}
			}
			ConfigGmTypeInfoById.LogPair.Clear();
			ConfigGmTypeInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmTypeInfoById.HandleId, 1, p0Id, ConfigGmTypeInfoById.LogPair) || ConfigCommon.Step(ConfigGmTypeInfoById.HandleId, true, ConfigGmTypeInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmTypeInfoById.HandleId, 0, ConfigGmTypeInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmTypeInfo rootAsGmTypeInfo = GmTypeInfo.GetRootAsGmTypeInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmTypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
			return new GmTypeInfo?(rootAsGmTypeInfo);
		}

		// Token: 0x0400197C RID: 6524
		private const string DB = "db_gm.db";

		// Token: 0x0400197D RID: 6525
		private const string FILE = "g.GM.xlsx";

		// Token: 0x0400197E RID: 6526
		private const string TABLE = "GmTypeInfo";

		// Token: 0x0400197F RID: 6527
		private const string COMMAND = "select BinData from `GmTypeInfo` where Id=?";

		// Token: 0x04001980 RID: 6528
		private const string KEY_PREFIX = "GmTypeInfoById";

		// Token: 0x04001981 RID: 6529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001982 RID: 6530
		private static int HandleId;
	}
}

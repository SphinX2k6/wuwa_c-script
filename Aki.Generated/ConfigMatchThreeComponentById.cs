using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000543 RID: 1347
	public class ConfigMatchThreeComponentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F9D RID: 8093 RVA: 0x0010F7B7 File Offset: 0x0010D9B7
		static ConfigMatchThreeComponentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeComponentById.CreateStaticDefaultValue), new Action(ConfigMatchThreeComponentById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0010F7D8 File Offset: 0x0010D9D8
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeComponentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeComponentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeComponent"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeComponent` where Id=?")
			});
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0010F857 File Offset: 0x0010DA57
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeComponentById.LogPair = null;
			ConfigMatchThreeComponentById.HandleId = 0;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0010F865 File Offset: 0x0010DA65
		public static void Init()
		{
			ConfigMatchThreeComponentById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeComponentById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeComponent` where Id=?");
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0010F880 File Offset: 0x0010DA80
		public static MatchThreeComponent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeComponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeComponent?(MatchThreeComponent.GetRootAsMatchThreeComponent(configBuffer));
				}
			}
			ConfigMatchThreeComponentById.LogPair.Clear();
			ConfigMatchThreeComponentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeComponentById.HandleId, 1, p0Id, ConfigMatchThreeComponentById.LogPair) || ConfigCommon.Step(ConfigMatchThreeComponentById.HandleId, true, ConfigMatchThreeComponentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeComponentById.HandleId, 0, ConfigMatchThreeComponentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeComponent rootAsMatchThreeComponent = MatchThreeComponent.GetRootAsMatchThreeComponent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeComponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
			return new MatchThreeComponent?(rootAsMatchThreeComponent);
		}

		// Token: 0x040024B9 RID: 9401
		private const string DB = "db_matchthree.db";

		// Token: 0x040024BA RID: 9402
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024BB RID: 9403
		private const string TABLE = "MatchThreeComponent";

		// Token: 0x040024BC RID: 9404
		private const string COMMAND = "select BinData from `MatchThreeComponent` where Id=?";

		// Token: 0x040024BD RID: 9405
		private const string KEY_PREFIX = "MatchThreeComponentById";

		// Token: 0x040024BE RID: 9406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024BF RID: 9407
		private static int HandleId;
	}
}
